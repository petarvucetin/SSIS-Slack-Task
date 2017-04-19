using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;
using SSISSlackTaskCSharp.Infrastructure;


namespace SSISSlackTaskCSharp.Simple.UI
{
    public partial class SlackSingleAttachmentTaskForm : Form
    {
        private readonly IDTSPropertiesProvider _propertiesProvider;
        private IServiceProvider _serviceProvider;
        private readonly Tuple<string, Type, object>[] _providerProperties;

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

            _providerProperties = ExtractPropetiesFromProvider(propertiesProvider);
            BindTextPropertiesToForm(_providerProperties);

            
            var timeStampProperty = (DateTime) _providerProperties.Single(z => z.Item1 == "AttachmentTimeStamp").Item3;
            this.AttachmentTimeStampDatePicker.Value = timeStampProperty;
        }

        private void BindTextPropertiesToForm(Tuple<string, Type, object>[] properties)
        {
            var textProperties = properties.Where(z => z.Item2 == typeof(string)).ToArray();

            foreach (var text in textProperties)
            {
                var textBoxName = text.Item1 + "TextBox";
                var textBox = this.FindControl<TextBox>(textBoxName);
                var t = textBox.Single();
                t.Text = (string)text.Item3;
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

        private void PushTextPropertiesToProvider()
        {
            var textProperties = _providerProperties.Where(z => z.Item2 == typeof(string));

            foreach (var providerProperty in textProperties)
            {
                var reference = _propertiesProvider.Properties[providerProperty.Item1];

                var textBoxName = providerProperty.Item1 + "TextBox";
                var textBox = this.FindControl<TextBox>(textBoxName);
                var t = textBox.Single();
                reference.SetValue(_propertiesProvider, t.Text);
            }
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            PushTextPropertiesToProvider();

            //time stamp
            var timeStamp = this.AttachmentTimeStampDatePicker.Value;
            var propertyName = _providerProperties.Single(z => z.Item1 == "AttachmentTimeStamp");
            var reference = _propertiesProvider.Properties[propertyName.Item1];
            reference.SetValue(_propertiesProvider, timeStamp);

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
