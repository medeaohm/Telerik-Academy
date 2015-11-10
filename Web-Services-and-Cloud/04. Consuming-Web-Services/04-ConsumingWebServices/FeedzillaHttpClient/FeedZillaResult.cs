namespace FeedzillaHttpClient
{
    using System.Collections.Generic;
    using Newtonsoft.Json;

    public class FeedZillaResult
    {
        [JsonProperty("articles")]
        public List<Article> Articles
        {
            get; set;
        }
    }
}