using System.ComponentModel;
using SSISSlackTaskCSharp.SSIS.SlackTaskUI;

namespace SSISSlackTaskCSharp.Full.UI
{
    public class AttachementViewModel
    {
        public AttachementViewModel()
        {
            Fields = new BindingList<FieldViewModel>();
        }

        public int RowId { get; set; }

        public string Fallaback { get; set; }

        public string Color { get; set; }

        public string Text { get; set; }

        public string PreText { get; set; }

        public string AuthorName { get; set; }

        public string AuthorLink { get; set; }

        public string AuthorIconUrl { get; set; }

        public string Title { get; set; }

        public string TitleLinkUrl { get; set; }

        public BindingList<FieldViewModel> Fields { get; set; }

        public string ImageUrl { get; set; }

        public string ThumbUrl { get; set; }

        public string Footer { get; set; }

        public string FooterIconUrl { get; set; }

        public int TimeStamp { get; set; }

    }
}