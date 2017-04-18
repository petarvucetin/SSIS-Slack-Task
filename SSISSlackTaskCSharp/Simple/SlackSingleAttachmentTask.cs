using System;
using Microsoft.SqlServer.Dts.Runtime;

namespace SSISSlackTaskCSharp.Simple
{
  
    [DtsTask(
       DisplayName = "Slack Attachment Task",
       Description = "Send message to slack",
       UITypeName = "SSISSlackTaskCSharp.Simple.UI.SlackSingleAttachmentTaskUI, SSISSlackTaskCSharp",
       IconResource = "SSISSlackTaskCSharp.web_slack_32px_1175007_easyicon.net.ico",
       TaskContact = "petar.vucetin@clear-lines.com")]
    public partial class SlackSingleAttachmentTask : Microsoft.SqlServer.Dts.Runtime.Task
    {

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
