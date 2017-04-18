using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SSISSlackTaskCSharp.Simple
{
    public partial class SlackSingleAttachment
    {
        [Category("Slack Settings")]
        public string Text { get; set; }

        [Category("Slack Settings")]
        public string Channel { get; set; }

        [Category("Slack Settings")]
        public string User { get; set; }
        [Category("Slack Settings")]
        public string SlackMessageJson { get; set; }

        [Category("Slack Settings")]
        public string WebHookUrl { get; set; }

        [Category("Slack Settings")]
        public string AttachmentFallaback { get; set; }
        [Category("Slack Settings")]
        public string AttachmentColor { get; set; }
        [Category("Slack Settings")]
        public string AttachmentPreText { get; set; }
        [Category("Slack Settings")]
        public string AttachmentText { get; set; }
        [Category("Slack Settings")]
        public string AttachmentAuthorName { get; set; }
        [Category("Slack Settings")]
        public string AttachmentAuthorLink { get; set; }
        [Category("Slack Settings")]
        public string AttachmentAuthorIconUrl { get; set; }
        [Category("Slack Settings")]
        public string AttachmentTitle { get; set; }
        [Category("Slack Settings")]
        public string AttachmentTitleLinkUrl { get; set; }
        [Category("Slack Settings")]
        public string AttachmentImageUrl { get; set; }
        [Category("Slack Settings")]
        public string AttachmentThumbUrl { get; set; }
        [Category("Slack Settings")]
        public string AttachmentFooter { get; set; }
        [Category("Slack Settings")]
        public string AttachmentFooterIconUrl { get; set; }
        [Category("Slack Settings")]
        public int AttachmentTimeStamp { get; set; }
    }
}
