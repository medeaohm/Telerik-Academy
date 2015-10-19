namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Collections.Generic;
    using Http;

    public class ContentActionResultWithCors : ContentActionResult
    {
        public ContentActionResultWithCors(HttpRequest request, object model, string corsSettings) : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Access-Control-Allow-Origin", corsSettings));
        }
    }
}