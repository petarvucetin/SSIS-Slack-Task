using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

namespace SSISSlackTaskCSharp
{
    public class SlackClient
    {
        private readonly Encoding _encoding = new UTF8Encoding();

        public void SendMessage(SlackMessage message, string webHook)
        {
            var slackMessage = ConvertToSlackMessage(message);
            var response = Send(slackMessage, new Uri(webHook));

            switch (response)
            {
                case "":
                    break;
                case "ok":
                    break;
                default:
                    throw new ApplicationException(string.Format("Invalid response from slack {0}", response));
            }
        }

        private string ConvertToSlackMessage(SlackMessage message)
        {
            var payloadJson = JsonConvert.SerializeObject(message);
            return payloadJson;
        }

        private string Send(string slackMessage, Uri webHook)
        {
            try
            {
                using (WebClient client = new WebClient())
                {
                    var data = new NameValueCollection();
                    data["payload"] = slackMessage;

                    var response = client.UploadValues(webHook, "POST", data);

                    //The response text is usually "ok"  
                    return _encoding.GetString(response);
                }
            }
            catch (Exception ex)
            {
                return "";
            }
        }
    }

    public class SlackMessage
    {
        [JsonProperty("channel")]
        public string Channel { get; set; }

        [JsonProperty("username")]
        public string Username { get; set; }

        [JsonProperty("text")]
        public string Text { get; set; }

        [JsonProperty("attachment")]
        public Attachement[] Attachments { get; set; }
    }

    public class Field
    {
        [JsonProperty("title")]
        public string Title { get; set; }

        [JsonProperty("value")]
        public string Value { get; set; }

        [JsonProperty("short")]
        public bool Short { get; set; }
    }

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
