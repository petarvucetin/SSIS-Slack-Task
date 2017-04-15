using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSISSlackTaskCSharp
{
    public partial class SlackMessageEditorForm : Form
    {

        public SlackMessageEditorForm()
        {
            InitializeComponent();
        }

        public SlackMessageEditorForm(SlackMessage instance) : this()
        {
            SlackMessage = instance;

            //init form
            this.SimpleMessageTextBox.Text = SlackMessage.Text;
            if (SlackMessage.Attachments != null)
            {
                foreach (var attachemnt in SlackMessage.Attachments)
                {
                    this.AttachmentGrid.addr
                }
            }
           
        }

        public SlackMessage SlackMessage { get; internal set; }
    }
}
