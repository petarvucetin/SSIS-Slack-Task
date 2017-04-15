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

namespace SSISSlackTaskCSharp
{
    public partial class SSISTaskForm : Form
    {
        private TaskHost _taskHostValue;

        public SSISTaskForm()
        {
            InitializeComponent();
        }

        public SSISTaskForm(TaskHost taskHostValue) : this()
        {
            this._taskHostValue = taskHostValue;

            var messageTextProp = taskHostValue.Properties["SimpleMessageText"];
            this.SimpleMessageTextBox.Text = (string)messageTextProp.GetValue(taskHostValue);

            var webHook = taskHostValue.Properties["WebHookUrl"];
            this.WebHookUrlTextBox.Text = (string)messageTextProp.GetValue(taskHostValue);

            //var attachment = taskHostValue.Properties["Attachments"];
            //this.SimpleMessageTextBox.Text = (string)messageTextProp.GetValue(taskHostValue);
        }

        private void DoneButton_Click(object sender, EventArgs e)
        {
            _taskHostValue.Properties["SimpleMessageText"].SetValue(_taskHostValue, this.SimpleMessageTextBox.Text);

        }

        private void TestButton_Click(object sender, EventArgs e)
        {
            var client = new SlackClient();

            var webHook = this.WebHookUrlTextBox.Text;


            //client.SendMessage(message, webHook);
        }
    }
}
