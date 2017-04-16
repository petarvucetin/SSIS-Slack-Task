using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.SqlServer.Dts.Runtime;
using System.ComponentModel;
using System.Drawing.Design;
using System.IO;
using System.Xml.Serialization;

namespace SSISSlackTaskCSharp
{

    [DtsTask(
        DisplayName = "Slack Task",
        Description = "Send message to slack",
        UITypeName = "SSISSlackTaskCSharp.SSISTaskUI, SSISSlackTaskCSharp, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=81f28340fabd6dd7",
        IconResource = "SSISSlackTaskCSharp.web_slack_32px_1175007_easyicon.net.ico",
        TaskContact = "petar.vucetin@clear-lines.com")]
    public class SSISTask : Microsoft.SqlServer.Dts.Runtime.Task, IDTSComponentPersist
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

        [Browsable(true)]
        [Category("Slack Settings")]
        public List<Attachment> Attachments { get; set; }

        public override void InitializeTask(Connections connections, VariableDispenser variableDispenser, IDTSInfoEvents events, IDTSLogging log, EventInfos eventInfos, LogEntryInfos logEntryInfos, ObjectReferenceTracker refTracker)
        {
            Attachments = new List<Attachment>();
            //base.InitializeTask(connections, variableDispenser, events, log, eventInfos, logEntryInfos, refTracker);
        }

        public override DTSExecResult Validate(Connections connections, VariableDispenser variableDispenser,
            IDTSComponentEvents componentEvents, IDTSLogging log)
        {
            //if (WebHookUrl != null)
            return DTSExecResult.Success;
            //else
            //    return DTSExecResult.Failure;
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
                message.Attachments = Attachments.ToArray();

                client.SendMessage(message, this.WebHookUrl);

            }
            catch (Exception e)
            {
                componentEvents.FireError(0, "Slact Taks", "Error sending message to Slack. Webhook = " + WebHookUrl, "", 0);
            }

            //Always retun sucess
            return DTSExecResult.Success;
        }

        public void LoadFromXML(XmlElement node, IDTSInfoEvents infoEvents)
        {
            var serializer = new XmlSerializer(typeof(TaskProperties));

            using (var sr = new StringReader(node.OuterXml))
            {
                var instance = serializer.Deserialize(sr) as TaskProperties;
                this.WebHookUrl = instance.WebHookUrl;
                this.Text = instance.SlackMessage.Text;
                this.User = instance.SlackMessage.Username;
                this.Channel = instance.Channel;
                this.Attachments = new List<Attachment>(instance.SlackMessage.Attachments);
            }


        }

        public void SaveToXML(XmlDocument doc, IDTSInfoEvents infoEvents)
        {
            var serializer = new XmlSerializer(typeof(TaskProperties));

            var sm = new SlackMessage();
            sm.Text = this.Text;
            sm.Username = this.User;
            sm.Attachments = this.Attachments.ToArray();

            var tp = new TaskProperties();
            tp.WebHookUrl = WebHookUrl;
            tp.Channel = this.Channel;
            tp.SlackMessage = sm;

            using (var sww = new StringWriter())
            {
                using (XmlWriter writer = XmlWriter.Create(sww))
                {
                    serializer.Serialize(writer, tp);
                    var xml = sww.ToString(); // Your XML
                    doc.LoadXml(xml);
                }
            }

        }
    }

    public class TaskProperties
    {
        public string WebHookUrl { get; set; }
        public string Channel { get; set; }
        public SlackMessage SlackMessage { get; set; }
    }
}

