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
    public class SSISTask :  Microsoft.SqlServer.Dts.Runtime.Task //, IDTSComponentPersist
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

        public override DTSExecResult Validate(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log)
        {
            //return base.Validate(connections, variableDispenser, componentEvents, log);
            return DTSExecResult.Success;
        }

        public override DTSExecResult Execute(Connections connections, VariableDispenser variableDispenser, IDTSComponentEvents componentEvents, IDTSLogging log, object transaction)
        {
            System.Windows.Forms.MessageBox.Show(Text);
            return DTSExecResult.Success;
        }


    }
}
