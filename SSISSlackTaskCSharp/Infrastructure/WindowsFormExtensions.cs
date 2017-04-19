using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace SSISSlackTaskCSharp.Infrastructure
{
    public static class FormsExtensions
    {
        public static IEnumerable<T> FindControl<T>(this Control parentControl, String name = "")
        {
            if (parentControl is T)
            {
                if (String.IsNullOrWhiteSpace(name))
                    yield return (T)(object)parentControl;
                else if (parentControl.Name.Equals(name))
                {
                    yield return (T)(object)parentControl;
                    yield break;
                }
            }

            var filteredControlList = from controlList in parentControl.Controls.Cast<Control>()
                                      where controlList is T || controlList.Controls.Count > 0
                                      select controlList;

            foreach (var childControl in filteredControlList)
            {
                foreach (T foundControl in FindControl<T>(childControl, name))
                {
                    yield return foundControl;
                    if (!String.IsNullOrWhiteSpace(name))
                        yield break;
                }
            }
        }
    }
}
