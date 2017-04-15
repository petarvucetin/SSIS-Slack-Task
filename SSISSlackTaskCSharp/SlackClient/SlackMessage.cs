using Newtonsoft.Json;

namespace SSISSlackTaskCSharp
{
    public class SlackMessage
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("attachment")]
        public Attachment[] Attachments { get; set; }
    }
}