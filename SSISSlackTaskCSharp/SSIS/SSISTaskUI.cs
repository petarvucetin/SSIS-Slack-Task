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
        private TaskHost taskHostValue ;
        public void Delete(IWin32Window parentWindow)
        {
        }

        public ContainerControl GetView()
        {
            return new SSISTaskForm(taskHostValue);
        }

        public void Initialize(TaskHost taskHost, IServiceProvider serviceProvider)
        {
            taskHostValue = taskHost;
        }

        public void New(IWin32Window parentWindow)
        {
            
        }
    }
}
