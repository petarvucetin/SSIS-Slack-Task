namespace SSISSlackTaskCSharp.Full
{
    public class TaskProperties
    {
        public string WebHookUrl { get; set; }
        public string Channel { get; set; }
        public SlackMessage SlackMessage { get; set; }
    }
}