using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Globalization;
using Newtonsoft.Json;

namespace SSISSlackTaskCSharp
{
    public class Attachment
    {
        /// <summary>
        /// Required plain-text summary of the attachment.
        /// </summary>
        [JsonProperty("fallback")]
        public string Fallaback { get; set; }

        /// <summary>
        /// Like traffic signals, color-coding messages can quickly communicate intent and 
        /// help separate them from the flow of other messages in the timeline.
        ///An optional value that can either be one of good, warning, danger, or any hex color 
        /// code(eg. #439FE0). This value is used to color the border along the left side of the message attachment.
        /// </summary>
        [JsonProperty("color")]
        public string Color { get; set; }

        /// <summary>
        /// This is optional text that appears above the message attachment block.
        /// </summary>
        [JsonProperty("pretext")]
        public string PreText { get; set; }

        /// <summary>
        /// This is the main text in a message attachment, and can contain standard message markup. 
        /// The content will automatically collapse if it contains 700+ characters or 5+ linebreaks, and will display a "Show more..." 
        /// link to expand the content. Links posted in the text field will not unfurl.
        /// </summary>
        [JsonProperty("text")]
        public string Text { get; set; }

        /// <summary>
        /// The author parameters will display a small section at the top of a message attachment 
        /// Small text used to display the author's name.
        /// </summary>
        [JsonProperty("author_name")]
        public string AuthorName { get; set; }

        /// <summary>
        /// A valid URL that will hyperlink the author_name text mentioned above. Will only work if author_name is present.
        /// </summary>
        [JsonProperty("author_link")]
        public string AuthorLink { get; set; }

        /// <summary>
        /// A valid URL that displays a small 16x16px image to the left of the author_name text. Will only work if author_name is present.
        /// </summary>
        [JsonProperty("author_icon")]
        public string AuthorIconUrl { get; set; }

        /// <summary>
        /// The title is displayed as larger, bold text near the top of a message attachment
        /// </summary>
        [JsonProperty("title")]
        public string Title { get; set; }

        /// <summary>
        ///  By passing a valid URL in the title_link parameter (optional), the title text will be hyperlinked.
        /// </summary>
        [JsonProperty("title_link")]
        public string TitleLinkUrl { get; set; }

        [JsonProperty("fields")]
        public Field[] Fields { get; set; }

        /// <summary>
        /// A valid URL to an image file that will be displayed inside a message attachment. 
        /// We currently support the following formats: GIF, JPEG, PNG, and BMP.
        ///Large images will be resized to a maximum width of 400px or a maximum height of 500px, 
        /// while still maintaining the original aspect ratio.
        /// </summary>
        [JsonProperty("image_url")]
        public string ImageUrl { get; set; }

        /// <summary>
        /// A valid URL to an image file that will be displayed as a thumbnail on the right side of a message attachment. 
        /// We currently support the following formats: GIF, JPEG, PNG, and BMP.
        ///The thumbnail's longest dimension will be scaled down to 75px while maintaining the aspect ratio of the image. 
        /// The filesize of the image must also be less than 500 KB.
        ///For best results, please use images that are already 75px by 75px.
        /// </summary>
        [JsonProperty("thumb_url")]
        public string ThumbUrl { get; set; }

        /// <summary>
        /// Add some brief text to help contextualize and identify an attachment. 
        /// Limited to 300 characters, and may be truncated further when displayed to 
        /// users in environments with limited screen real estate.
        /// </summary>
        [JsonProperty("footer")]
        public string Footer { get; set; }

        /// <summary>
        /// To render a small icon beside your footer text, provide a publicly accessible URL string in the footer_icon field. You must also provide a footer for the field to be recognized.
        ///We'll render what you provide at 16px by 16px. It's best to use an image that is similarly sized.
        ///Example: "https://platform.slack-edge.com/img/default_application_icon.png"
        /// </summary>
        [JsonProperty("footer_icon")]
        public string FooterIconUrl { get; set; }


        /// <summary>
        /// Does your attachment relate to something happening at a specific time?
        ///By providing the ts field with an integer value in "epoch time", the attachment will display an 
        ///additional timestamp value as part of the attachment's footer.
        /// 
        ///Use ts when referencing articles or happenings.Your message will have its own timestamp when published.
        ///Example: Providing 123456789 would result in a rendered timestamp of Nov 29th, 1973.
        /// </summary>
        [JsonProperty("ts")]
        public int TimeStamp { get; set; }

    }

}