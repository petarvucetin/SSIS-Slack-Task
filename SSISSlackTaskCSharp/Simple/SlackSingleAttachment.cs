using System;
using System.ComponentModel;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Microsoft.SqlServer.Dts.Runtime;
using Newtonsoft.Json;

namespace SSISSlackTaskCSharp.SSIS
{
    [DtsTask(
       DisplayName = "Slack Task",
       Description = "Send message to slack",
       UITypeName = "SSISSlackTaskCSharp.SlackSingleAttachmentUI, SSISSlackTaskCSharp",
       IconResource = "SSISSlackTaskCSharp.web_slack_32px_1175007_easyicon.net.ico",
       TaskContact = "petar.vucetin@clear-lines.com")]
    public class SlackSingleAttachment : Microsoft.SqlServer.Dts.Runtime.Task
    {
        [Category("Slack Settings")]
        public string Text { get; set; }

        [Category("Slack Settings")]
        public string Channel { get; set; }

        [Category("Slack Settings")]
        public string User { get; set; }

        [Category("Slack Settings")]
        public string WebHookUrl { get; set; }

        [Browsable(true)]
        [Category("Slack Settings")]
        public string AttachmentFallaback { get; set; }

        public string AttachmentColor { get; set; }

        public string AttachmentPreText { get; set; }

        public string AttachmentText { get; set; }

        public string AttachmentAuthorName { get; set; }

        public string AttachmentAuthorLink { get; set; }

        public string AttachmentAuthorIconUrl { get; set; }

        public string AttachmentTitle { get; set; }

        public string AttachmentTitleLinkUrl { get; set; }

        public string AttachmentImageUrl { get; set; }

        public string AttachmentThumbUrl { get; set; }

        public string AttachmentFooter { get; set; }

        public string AttachmentFooterIconUrl { get; set; }

        public int AttachmentTimeStamp { get; set; }

        public override void InitializeTask(Connections connections, VariableDispenser variableDispenser, IDTSInfoEvents events, IDTSLogging log, EventInfos eventInfos, LogEntryInfos logEntryInfos, ObjectReferenceTracker refTracker)
        {
        }

        public override DTSExecResult Validate(Connections connections, VariableDispenser variableDispenser,
            IDTSComponentEvents componentEvents, IDTSLogging log)
        {
            if (WebHookUrl == null)
            {
                componentEvents.FireError(0, "Slact Taks", "Error sending message to Slack. Webhook is not set.", "", 0);
                return DTSExecResult.Failure;
            }

            return DTSExecResult.Success;
        }

        public override DTSExecResult Execute(Connections connections, VariableDispenser variableDispenser,
            IDTSComponentEvents componentEvents, IDTSLogging log, object transaction)
        {
            try
            {
                var client = new SlackClient();
                var message = new SlackMessage();
                message.Text = this.Text;
                message.Username = this.User;
                client.SendMessage(message, this.WebHookUrl);

            }
            catch (Exception e)
            {
                componentEvents.FireError(0, "Slact Taks", "Error sending message to Slack. Webhook = " + WebHookUrl, "", 0);
            }

            //Always retun sucess because we do not want to fail package if we cannot send message to Slack
            //TODO: Should this be a setting?
            return DTSExecResult.Success;
        }

    }
}
