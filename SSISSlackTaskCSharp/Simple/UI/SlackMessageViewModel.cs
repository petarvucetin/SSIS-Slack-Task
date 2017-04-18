using System.ComponentModel;
using SSISSlackTaskCSharp.Full.UI;

namespace SSISSlackTaskCSharp.Simple.UI
{
    public class SlackMessageViewModel
    {
        public SlackMessageViewModel()
        {
            Attachment = new AttachementViewModel();
            AttachmentFields = new BindingList<FieldViewModel>();
            AttachmentFields.RaiseListChangedEvents = true;
        }

        public string Username { get; set; }

        public string Text { get; set; }

        public AttachementViewModel Attachment { get; set; }

        public BindingList<FieldViewModel> AttachmentFields { get; set; }

        public int SelectedRowIndex { get; set; }
    }
}
