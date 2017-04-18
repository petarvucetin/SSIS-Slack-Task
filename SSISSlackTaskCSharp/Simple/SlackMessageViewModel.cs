using System.ComponentModel;
using SSISSlackTaskCSharp.Full.UI;
using SSISSlackTaskCSharp.SSIS.SlackTaskUI;

namespace SSISSlackTaskCSharp.SSIS.SlackSingleAttachmentUI
{
    public class SlackMessageViewModel
    {
        public SlackMessageViewModel()
        {
            Attachments = new BindingList<Full.UI.AttachementViewModel>();
            Attachments.RaiseListChangedEvents = true;
            SelectedAttachmentFields = new BindingList<FieldViewModel>();
            SelectedAttachmentFields.RaiseListChangedEvents = true;
        }

        public string Username { get; set; }

        public string Text { get; set; }

        public BindingList<Full.UI.AttachementViewModel> Attachments { get; set; }

        public BindingList<FieldViewModel> SelectedAttachmentFields { get; set; }
        public int SelectedRowIndex { get; set; }
    }
}
