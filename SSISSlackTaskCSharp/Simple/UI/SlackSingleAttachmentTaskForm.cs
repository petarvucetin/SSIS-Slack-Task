using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;

namespace SSISSlackTaskCSharp.Simple.UI
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

            var properties = ExtractPropetiesFromProvider(propertiesProvider);
            BindPropertiesToForm(properties);

        }

        private void BindPropertiesToForm(Tuple<string, Type, object>[] properties)
        {
            var textProperties = properties.Where(z => z.Item2 == typeof(string)).ToArray();

            foreach (var text in textProperties)
            {

                var textBoxName = text.Item1 + "TextBox";
                var textBox = this.Controls.Find(textBoxName, true).Single();
                textBox.Text = (string)text.Item3;
            }

        }


        private Tuple<string, Type, object>[] ExtractPropetiesFromProvider(IDTSPropertiesProvider propertiesProvider)
        {
            //get properties with category custom attribute
            var properties = typeof(SlackSingleAttachmentTask).GetProperties()
                .Where(z => z.CustomAttributes.Any(x => x.AttributeType == typeof(CategoryAttribute)));

            var list = new List<Tuple<string, Type, object>>();

            foreach (var propertyInfo in properties)
            {
                var prop = propertiesProvider.Properties[propertyInfo.Name];
                var propValue = prop.GetValue(_propertiesProvider);

                list.Add(new Tuple<string, Type, object>(propertyInfo.Name, propertyInfo.PropertyType, propValue));
            }

            return list.ToArray();
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            _propertiesProvider.Properties["Text"].SetValue(_propertiesProvider, this.TextTextBox.Text);
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

            var text = this.TextTextBox.Text;

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
