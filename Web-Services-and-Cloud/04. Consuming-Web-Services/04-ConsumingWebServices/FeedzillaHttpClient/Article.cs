namespace FeedzillaHttpClient
{
    using Newtonsoft.Json;

    public class Article
    {
        [JsonProperty("title")]
        public string Title
        {
            get; set;
        }

        [JsonProperty("url")]
        public string Url
        {
            get; set;
        }
    }
}
