namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Collections.Generic;
    using Http;

    public class RedirectActionResultsWithCors : JsonActionResult
    {
        public RedirectActionResultsWithCors(HttpRequest request, object model, string corsSettings)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Access-Control-Allow-Origin", corsSettings));
        }
    }
}