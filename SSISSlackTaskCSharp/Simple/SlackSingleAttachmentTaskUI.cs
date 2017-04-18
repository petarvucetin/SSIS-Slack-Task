using System;
using System.Windows.Forms;
using Microsoft.SqlServer.Dts.Runtime;
using Microsoft.SqlServer.Dts.Runtime.Design;
using SSISSlackTaskCSharp.SSIS.SlackSingleAttachmentUI;

namespace SSISSlackTaskCSharp.Simple
{
    public class SlackSingleAttachmentTaskUI : IDtsTaskUI
    {
        private TaskHost _taskHost ;
        private IServiceProvider _serviceProvider;

        public void Delete(IWin32Window parentWindow)
        {
        }

        public ContainerControl GetView()
        {
            return new SlackSingleAttachmentTaskForm(_taskHost, _serviceProvider);
        }

        public void Initialize(TaskHost taskHost, IServiceProvider serviceProvider)
        {
            _taskHost = taskHost;
            _serviceProvider = serviceProvider;
        }

        public void New(IWin32Window parentWindow)
        {
            
        }
    }
}

