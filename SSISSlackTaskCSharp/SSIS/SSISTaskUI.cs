using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

using Microsoft.SqlServer.Dts.Runtime;
using Microsoft.SqlServer.Dts.Runtime.Design;

using System.Windows.Forms;

namespace SSISSlackTaskCSharp
{
    public class SSISTaskUI : IDtsTaskUI
    {
        private TaskHost _taskHost ;
        private IServiceProvider _serviceProvider;

        public void Delete(IWin32Window parentWindow)
        {
        }

        public ContainerControl GetView()
        {
            return new SSISTaskForm(_taskHost, _serviceProvider);
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

