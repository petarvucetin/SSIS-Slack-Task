﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;
using Newtonsoft.Json;

namespace SSISSlackTaskCSharp
{
    public partial class SSISTaskForm : Form
    {
        private readonly TaskHost _taskHostValue;

        public SSISTaskForm()
        {
            InitializeComponent();

            if (SlackMessage == null)
                SlackMessage = new SlackMessageViewModel();

            this.AttachmentsGridView.AutoGenerateColumns = false;
            this.AttachmentsGridView.DataSource = SlackMessage.Attachments;
        }

        public SSISTaskForm(TaskHost taskHostValue) : this()
        {
            this._taskHostValue = taskHostValue;

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

                foreach (var a in attachments)
                {
                    var item = SlackMessage.Attachments.AddNew();
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

            //this.AttachmentsGridView.Refresh();
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
                    //a.Fields
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

                //var attachments = list.ToArray();
                var prop = _taskHostValue.Properties["Attachments"];
                var proval = prop.GetValue(_taskHostValue) as List<Attachment>;
                prop.SetValue(_taskHostValue, list);
               
            }

            
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var client = new SlackClient();

            var webHook = this.WebHookUrlTextBox.Text;


            //client.SendMessage(message, webHook);
        }

        public SlackMessageViewModel SlackMessage { get; set; }

    }
}