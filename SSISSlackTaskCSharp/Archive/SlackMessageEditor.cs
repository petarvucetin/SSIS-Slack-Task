using System;
using System.ComponentModel;
using System.Drawing.Design;
using System.Windows.Forms;
using System.Windows.Forms.Design;

namespace SSISSlackTaskCSharp
{
    internal class SlackMessageEditor : UITypeEditor
    {
        public override object EditValue(ITypeDescriptorContext context, IServiceProvider provider, object value)
        {

            if (null != context && null != context.Instance && null != provider)
            {
                var service = (IWindowsFormsEditorService)provider.GetService
                            (typeof(IWindowsFormsEditorService));

                if (null != service)
                {
                    var instance = value as SlackMessage;

                    if (instance == null)
                        instance = new SlackMessage();

                     var slackMessageEditorForm = new SlackMessageEditorForm(instance);

                    switch (service.ShowDialog(slackMessageEditorForm))
                    {
                        case DialogResult.OK:
                            value = slackMessageEditorForm.SlackMessage;
                            break;
                        case DialogResult.Cancel:
                            break;
                    }
                }
            }
            return value;
        }

        public override UITypeEditorEditStyle GetEditStyle(ITypeDescriptorContext context)
        {
            if (null != context && null != context.Instance)
            {
                return UITypeEditorEditStyle.Modal;
            }

            return base.GetEditStyle(context);
        }
    }
}