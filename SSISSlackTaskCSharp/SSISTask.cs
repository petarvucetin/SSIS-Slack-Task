using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml;
using Microsoft.SqlServer.Dts.Runtime;
using System.ComponentModel;
using System.Drawing.Design;

namespace SSISSlackTaskCSharp
{
    [DtsTask(
        DisplayName = "Slack Task",
        Description = "Send message to slack",
        UITypeName = "SSISSlackTaskCSharp.SSISTaskUI, SSISSlackTaskCSharp, Version=1.0.0.0, Culture=Neutral, PublicKeyToken=81f28340fabd6dd7",
        IconResource = "SSISSlackTaskCSharp.web_slack_32px_1175007_easyicon.net.ico",
        TaskContact = "Petar_Vucetin@gap.com or Mercury_Schroeppel@gap.com")]
    public class SSISTask :  Microsoft.SqlServer.Dts.Runtime.Task, IDTSComponentPersist
    {
        public string SimpleMessageText { get; set; }

        public string SlackMessageJson { get; set; }

        public string WebHookUrl { get; set; }

        [System.ComponentModel.Browsable(true)]
        [System.ComponentModel.Editor(typeof(SlackMessageEditor), typeof(UITypeEditor))]
        public SlackMessage SlackMessage { get; set; }

        public override void InitializeTask(Connections connections, VariableDispenser variableDispenser, IDTSInfoEvents events, IDTSLogging log, EventInfos eventInfos, LogEntryInfos logEntryInfos, ObjectReferenceTracker refTracker)
        {
            SlackMessage = new SlackMessage();
            SlackMessage.Text = "hello";

            //base.InitializeTask(connections, variableDispenser, events, log, eventInfos, logEntryInfos, refTracker);
        }

        public override DTSExecResult Validate(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log)
        {
            //return base.Validate(connections, variableDispenser, componentEvents, log);
            return DTSExecResult.Success;
        }

        public override DTSExecResult Execute(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log, object transaction)
        {
            System.Windows.Forms.MessageBox.Show(SimpleMessageText);
            return DTSExecResult.Success;
        }

        public void LoadFromXML(XmlElement node, IDTSInfoEvents infoEvents)
        {
            //Todo
        }

        public void SaveToXML(XmlDocument doc, IDTSInfoEvents infoEvents)
        {
            //todo
        }


    }
}
