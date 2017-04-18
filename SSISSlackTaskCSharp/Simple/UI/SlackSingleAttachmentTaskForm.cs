using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;
using SSISSlackTaskCSharp.Infrastructure;
using SSISSlackTaskCSharp.Simple.UI;
using SSISSlackTaskCSharp.SSIS;

namespace SSISSlackTaskCSharp.Simple
{
    public partial class SlackSingleAttachmentTaskForm : Form
    {
        private readonly IDTSPropertiesProvider _propertiesProvider;
        private IServiceProvider _serviceProvider;

        public SlackMessageViewModel SlackMessage { get; set; }

        public SlackSingleAttachmentTaskForm()
        {
            InitializeComponent();
        }

        public SlackSingleAttachmentTaskForm(IDTSPropertiesProvider propertiesProvider, 
            IServiceProvider serviceProvider) : this()
        {
            _propertiesProvider = propertiesProvider;
            this._serviceProvider = serviceProvider;

            ExtractPropetiesFromProvider(propertiesProvider);

            //var messageTextProp = _propertiesProvider.Properties[Member.Of<SlackSingleAttachment>(p => p.Text)];
            //this.SimpleMessageTextBox.Text = (string)messageTextProp.GetValue(_propertiesProvider);

            //var webHook = _propertiesProvider.Properties[Member.Of<SlackSingleAttachment>(p => p.WebHookUrl)];
            //this.WebHookUrlTextBox.Text = (string)webHook.GetValue(_propertiesProvider);

            //var json = _propertiesProvider.Properties["SlackMessageJson"];
            //this.SlackMessageJsonTextBox.Text = (string)json.GetValue(_propertiesProvider);

            //var channel = _propertiesProvider.Properties["Channel"];
            //this.ChannelTextBox.Text = (string)channel.GetValue(_propertiesProvider);

            //var user = _propertiesProvider.Properties["User"];
            //this.UserTextBox.Text = (string)user.GetValue(_propertiesProvider);

        }

        private KeyValuePair<string, object>[] ExtractPropetiesFromProvider(IDTSPropertiesProvider propertiesProvider)
        {
            //get properties with category custom attribute
            var properties = typeof(SlackSingleAttachment).GetProperties()
                .Where(z => z.CustomAttributes.Any(x => x.AttributeType == typeof(CategoryAttribute)));

            var list = new List<KeyValuePair<string, object>>();

            foreach (var propertyInfo in properties)
            {
                var prop = propertiesProvider.Properties[propertyInfo.Name];
                var propValue = prop.GetValue(_propertiesProvider);

                list.Add(new KeyValuePair<string, object>(propertyInfo.Name, propValue));
            }

            return list.ToArray();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            _propertiesProvider.Properties["Text"].SetValue(_propertiesProvider, this.SimpleMessageTextBox.Text);
            _propertiesProvider.Properties["WebHookUrl"].SetValue(_propertiesProvider, this.WebHookUrlTextBox.Text);
            _propertiesProvider.Properties["SlackMessageJson"].SetValue(_propertiesProvider, this.SlackMessageJsonTextBox.Text);
            _propertiesProvider.Properties["Channel"].SetValue(_propertiesProvider, this.ChannelTextBox.Text);
            _propertiesProvider.Properties["User"].SetValue(_propertiesProvider, this.UserTextBox.Text);

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


            this.ResponseTextBox.Text = client.SendMessage(message, webHook);
        }

        private void AttachmentColorTextBox_DoubleClick(object sender, EventArgs e)
        {
            if (colorDialog1.ShowDialog() == DialogResult.OK)
            {
                AttachmentColorTextBox.Text = (colorDialog1.Color.ToArgb() & 0x00FFFFFF).ToString("X6");
                this.ColorPanel.BackColor = colorDialog1.Color;
            }
        }
    }
}
