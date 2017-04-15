using System;
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
        private TaskHost _taskHostValue;

        public SSISTaskForm()
        {
            InitializeComponent();

            if (SlackMessage == null)
                SlackMessage = new SlackMessageViewModel();

            this.AttachmentsGridView.DataSource = SlackMessage.Attachments;
        }

        public SSISTaskForm(TaskHost taskHostValue) : this()
        {
            this._taskHostValue = taskHostValue;

            var messageTextProp = taskHostValue.Properties["SimpleMessageText"];
            this.SimpleMessageTextBox.Text = (string) messageTextProp.GetValue(taskHostValue);

            var webHook = taskHostValue.Properties["WebHookUrl"];
            this.WebHookUrlTextBox.Text = (string) webHook.GetValue(taskHostValue);

            var json = taskHostValue.Properties["SlackMessageJson"];
            this.SlackMessageJsonTextBox.Text = (string)json.GetValue(taskHostValue);

            var channel = taskHostValue.Properties["Channel"];
            this.ChannelTextBox.Text = (string)channel.GetValue(taskHostValue);

            var user = taskHostValue.Properties["User"];
            this.UserTextBox.Text = (string)user.GetValue(taskHostValue);


            var slackMessage = taskHostValue.Properties["SlackMessage"];
            var slackMessageInstance = slackMessage.GetValue(taskHostValue) as SlackMessage;

            if (slackMessageInstance != null)
            {
                SlackMessage = new SlackMessageViewModel
                {
                    Channel = slackMessageInstance.Channel,
                    Text = slackMessageInstance.Text,
                    Username = slackMessageInstance.Username
                };

                if (slackMessageInstance.Attachments != null)
                {
                    foreach (var a in slackMessageInstance.Attachments)
                    {
                        var item = SlackMessage.Attachments.AddNew();
                        item.PreText = a.PreText;
                    }
                }

            }


        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            _taskHostValue.Properties["SimpleMessageText"].SetValue(_taskHostValue, this.SimpleMessageTextBox.Text);
            _taskHostValue.Properties["WebHookUrl"].SetValue(_taskHostValue, this.WebHookUrlTextBox.Text);
            _taskHostValue.Properties["SlackMessageJson"].SetValue(_taskHostValue, this.SlackMessageJsonTextBox.Text);
            _taskHostValue.Properties["Channel"].SetValue(_taskHostValue, this.ChannelTextBox.Text);
            _taskHostValue.Properties["User"].SetValue(_taskHostValue, this.UserTextBox.Text);

            //transfer property to real slack message
            var slackMessage = new SlackMessage();

            slackMessage.Channel = this.SlackMessage.Channel;
            slackMessage.Text = this.SlackMessage.Text;
            slackMessage.Username = this.SlackMessage.Username;

            if (this.SlackMessage.Attachments.Count > 0)
            {
                var list = new List<Attachement>();
                foreach (var slackMessageAttachment in SlackMessage.Attachments)
                {
                    var a = new Attachement();
                    a.PreText = slackMessageAttachment.PreText;
                    list.Add(a);
                }

                slackMessage.Attachments = list.ToArray();
            }

            _taskHostValue.Properties["SlackMessage"].SetValue(_taskHostValue, slackMessage);
        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var client = new SlackClient();

            var webHook = this.WebHookUrlTextBox.Text;


            //client.SendMessage(message, webHook);
        }

        public SlackMessageViewModel SlackMessage { get; set; }

        private void AttachmentsGridView_NewRowNeeded(object sender, DataGridViewRowEventArgs e)
        {

        }

        private void AttachmentsGridView_UserAddedRow(object sender, DataGridViewRowEventArgs e)
        {

        }
    }

    public class SlackMessageViewModel
    {
        public SlackMessageViewModel()
        {
            Attachments = new BindingList<AttachementViewModel>();
            
        }

        public string Channel { get; set; }

        public string Username { get; set; }

        public string Text { get; set; }

        public BindingList<AttachementViewModel> Attachments { get; set; }
    }

    public class AttachementViewModel
    {
        public AttachementViewModel()
        {
            Fields = new BindingList<FieldViewModel>();
        }
        public string Fallaback { get; set; }

        public string Color { get; set; }

        public string PreText { get; set; }

        public string AuthorName { get; set; }

        public string AuthorLink { get; set; }

        public string AuthorIconUrl { get; set; }

        public string Title { get; set; }

        public string TitleLinkUrl { get; set; }

        public BindingList<FieldViewModel> Fields { get; set; }

        public string ImageUrl { get; set; }

        public string ThumbUrl { get; set; }

        public string Footer { get; set; }

        public string FooterIconUrl { get; set; }

        public int TimeStamp { get; set; }

    }

    public class FieldViewModel
    {
        public string Title { get; set; }
        public string Value { get; set; }
        public bool Short { get; set; }
    }
}