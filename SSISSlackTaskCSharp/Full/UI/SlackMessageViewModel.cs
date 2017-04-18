using System.ComponentModel;

namespace SSISSlackTaskCSharp.Full.UI
{
    public class SlackMessageViewModel
    {
        public SlackMessageViewModel()
        {
            Attachments = new BindingList<AttachementViewModel>();
            Attachments.RaiseListChangedEvents = true;
            SelectedAttachmentFields = new BindingList<FieldViewModel>();
            SelectedAttachmentFields.RaiseListChangedEvents = true;
        }

        public string Username { get; set; }

        public string Text { get; set; }

        public BindingList<AttachementViewModel> Attachments { get; set; }

        public BindingList<FieldViewModel> SelectedAttachmentFields { get; set; }
        public int SelectedRowIndex { get; set; }
    }
}
