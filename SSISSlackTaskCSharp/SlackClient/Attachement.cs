using Newtonsoft.Json;

namespace SSISSlackTaskCSharp
{
    public class Attachement
    {
        [JsonProperty("fallback")]
        public string Fallaback { get; set; }

        [JsonProperty("color")]
        public string Color { get; set; }

        [JsonProperty("pretext")]
        public string PreText { get; set; }

        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        [JsonProperty("author_link")]
        public string AuthorLink { get; set; }

        [JsonProperty("author_icon")]
        public string AuthorIconUrl { get; set; }

        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("title_link")]
        public string TitleLinkUrl { get; set; }

        [JsonProperty("fields")]
        public Field[] Fields { get; set; }

        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }

        [JsonProperty("footer")]
        public string Footer { get; set; }

        [JsonProperty("footer_icon")]
        public string FooterIconUrl { get; set; }

        [JsonProperty("ts")]
        public int TimeStamp { get; set; }

    }
}