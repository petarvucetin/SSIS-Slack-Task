using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;

namespace SSISSlackTaskCSharp
{
    public partial class SSISTaskForm : Form
    {
        private readonly TaskHost _taskHostValue;
        private IServiceProvider _serviceProvider;

        public SlackMessageViewModel SlackMessage { get; set; }

        public SSISTaskForm()
        {
            InitializeComponent();

            if (SlackMessage == null)
                SlackMessage = new SlackMessageViewModel();

            this.AttachmentsGridView.AutoGenerateColumns = false;
            this.AttachmentFieldsGridView.AutoGenerateColumns = false;
            this.AttachmentsGridView.DataSource = SlackMessage.Attachments;
            this.AttachmentFieldsGridView.DataSource = this.SlackMessage.SelectedAttachmentFields;
        }

        public SSISTaskForm(TaskHost taskHostValue, IServiceProvider serviceProvider) : this()
        {
            this._taskHostValue = taskHostValue;
            this._serviceProvider = serviceProvider;

            var messageTextProp = taskHostValue.Properties["Text"];
            this.SimpleMessageTextBox.Text = (string)messageTextProp.GetValue(taskHostValue);

            var webHook = taskHostValue.Properties["WebHookUrl"];
            this.WebHookUrlTextBox.Text = (string)webHook.GetValue(taskHostValue);

            var json = taskHostValue.Properties["SlackMessageJson"];
            this.SlackMessageJsonTextBox.Text = (string)json.GetValue(taskHostValue);

            var channel = taskHostValue.Properties["Channel"];
            this.ChannelTextBox.Text = (string)channel.GetValue(taskHostValue);

            var user = taskHostValue.Properties["User"];
            this.UserTextBox.Text = (string)user.GetValue(taskHostValue);


            var attachment = taskHostValue.Properties["Attachments"];
            var attachmentInstance = attachment.GetValue(taskHostValue) as List<Attachment>;

            if (attachmentInstance != null)
            {
                var attachments = attachmentInstance.Cast<Attachment>();
                var index = 0;
                foreach (var a in attachments)
                {
                    var item = SlackMessage.Attachments.AddNew();
                    item.RowId = index++;
                    item.PreText = a.PreText;
                    item.AuthorIconUrl = a.AuthorIconUrl;
                    item.AuthorLink = a.AuthorLink;
                    item.AuthorName = a.AuthorName;
                    item.Color = a.Color;
                    item.Fallaback = a.Fallaback;

                    if (a.Fields != null)
                    {
                        var fields = new BindingList<FieldViewModel>();
                        foreach (var field in a.Fields)
                        {
                            var f = new FieldViewModel
                            {
                                AttachementRowId = item.RowId,
                                Title = field.Title,
                                Short = field.Short,
                                Value = field.Value
                            };
                            fields.Add(f);
                        }

                        item.Fields = fields;
                    }
                    item.Footer = a.Footer;
                    item.FooterIconUrl = a.FooterIconUrl;
                    item.ImageUrl = a.ImageUrl;
                    item.ThumbUrl = a.ThumbUrl;
                    item.TimeStamp = a.TimeStamp;
                    item.Title = a.Title;
                    item.TitleLinkUrl = a.TitleLinkUrl;

                }
            }

            if (SlackMessage.Attachments.Any())
            {
                var firstAttachement = SlackMessage.Attachments.First();

                foreach (var field in firstAttachement.Fields)
                {
                    SlackMessage.SelectedAttachmentFields.Add(field);
                }
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            _taskHostValue.Properties["Text"].SetValue(_taskHostValue, this.SimpleMessageTextBox.Text);
            _taskHostValue.Properties["WebHookUrl"].SetValue(_taskHostValue, this.WebHookUrlTextBox.Text);
            _taskHostValue.Properties["SlackMessageJson"].SetValue(_taskHostValue, this.SlackMessageJsonTextBox.Text);
            _taskHostValue.Properties["Channel"].SetValue(_taskHostValue, this.ChannelTextBox.Text);
            _taskHostValue.Properties["User"].SetValue(_taskHostValue, this.UserTextBox.Text);

            //transfer property to real slack message
            if (this.SlackMessage.Attachments.Count > 0)
            {
                var list = new List<Attachment>();
                foreach (var av in SlackMessage.Attachments)
                {
                    var a = new Attachment();
                    a.PreText = av.PreText;
                    a.AuthorIconUrl = av.AuthorIconUrl;
                    a.AuthorName = av.AuthorName;

                    a.Fields = av.Fields.Select(z => new Field { Title = z.Title, Value =  z.Value, Short = z.Short}).ToArray();

                    a.FooterIconUrl = av.FooterIconUrl;
                    a.ImageUrl = av.ImageUrl;
                    a.ThumbUrl = av.ThumbUrl;
                    a.TimeStamp = av.TimeStamp;
                    a.Title = av.Title;
                    a.TitleLinkUrl = av.TitleLinkUrl;
                    a.AuthorLink = av.AuthorLink;
                    a.Color = av.Color;
                    a.Fallaback = av.Fallaback;
                    a.Footer = av.Footer;

                    list.Add(a);
                }

                var prop = _taskHostValue.Properties["Attachments"];
                prop.SetValue(_taskHostValue, list);

            }


        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var client = new SlackClient();

            var webHook = this.WebHookUrlTextBox.Text;

            var channel = this.ChannelTextBox.Text;

            var user = this.UserTextBox.Text;

            var text = this.SimpleMessageTextBox.Text;

            var message = new SlackMessage();
            message.Username = user;
            message.Text = text;

            message.Attachments = this.SlackMessage.Attachments.Select(z =>
            {
                var a = new Attachment();
                a.Text = z.Text;
                a.PreText = z.PreText;
                a.AuthorIconUrl = z.AuthorIconUrl;
                a.AuthorName = z.AuthorName;
                if (z.Fields != null)
                {
                    a.Fields = z.Fields.Select(f => new Field { Title = f.Title, Value = f.Value, Short = f.Short }).ToArray();
                }
                a.FooterIconUrl = z.FooterIconUrl;
                a.ImageUrl = z.ImageUrl;
                a.ThumbUrl = z.ThumbUrl;
                a.TimeStamp = z.TimeStamp;
                a.Title = z.Title;
                a.TitleLinkUrl = z.TitleLinkUrl;
                a.AuthorLink = z.AuthorLink;
                a.Color = z.Color;
                a.Fallaback = z.Fallaback;
                a.Footer = z.Footer;

                return a;
            }).ToArray();



            this.ResponseTextBox.Text = client.SendMessage(message, webHook);
        }

        private void AttachmentsGridView_SelectionChanged(object sender, EventArgs e)
        {
            var dg = sender as DataGridView;

            if (dg.CurrentRow != null)
            {
                var attachmentSource = dg.CurrentRow.DataBoundItem as AttachementViewModel;


                //find the previous row
                var previousRow = dg.Rows[SlackMessage.SelectedRowIndex].DataBoundItem as AttachementViewModel;

                //update previous row
                if (previousRow != null)
                {
                    previousRow.Fields.Clear();

                    foreach (var field in SlackMessage.SelectedAttachmentFields)
                    {
                        previousRow.Fields.Add(field);
                    }
                }

                //set the current SelectedAttachmentFields

                SlackMessage.SelectedAttachmentFields.Clear();

                foreach (var field in attachmentSource.Fields)
                {
                    SlackMessage.SelectedAttachmentFields.Add(field);
                }

                //set current row index
                SlackMessage.SelectedRowIndex = dg.CurrentRow.Index;
            }
        }
    }
}