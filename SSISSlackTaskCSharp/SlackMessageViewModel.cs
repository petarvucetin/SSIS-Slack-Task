using System.ComponentModel;

namespace SSISSlackTaskCSharp
{
    public class SlackMessageViewModel
    {
        public SlackMessageViewModel()
        {
            Attachments = new BindingList<AttachementViewModel>();
            Attachments.RaiseListChangedEvents = true;
            

        }

        public string Channel { get; set; }

        public string Username { get; set; }

        public string Text { get; set; }

        public BindingList<AttachementViewModel> Attachments { get; set; }
    }
}