using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.Collections.Specialized;
using System.ComponentModel;
using System.Linq;
using System.Net;
using System.Text;
using System.Threading.Tasks;

/// <summary>
/// https://hooks.slack.com/services/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
/// </summary>
namespace SSISSlackTaskCSharp
{
    public class SlackClient
    {

        private readonly Encoding _encoding = new UTF8Encoding();

        public string SendMessage(SlackMessage message, string webHook)
        {
            var slackMessage = ConvertToSlackMessage(message);
            var response = Send(slackMessage, new Uri(webHook));

            return response;
        }

        public static string ConvertToSlackMessage(SlackMessage message)
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
}
