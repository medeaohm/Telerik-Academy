namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Collections.Generic;
    using Http;

    public class ContentActionResultWithoutCaching : ContentActionResult
    {
        public ContentActionResultWithoutCaching(HttpRequest request, object model) : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Cache-Control", "private, max-age=0, no-cache"));
        }
    }
}