namespace ConsoleWebServer.Framework.ActionResults
{
    using System;
    using System.Collections.Generic;
    using Http;

    public class RedirectActionResultsWithoutCaching : JsonActionResult
    {
        public RedirectActionResultsWithoutCaching(HttpRequest request, object model)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Cache-Control", "private, max-age=0, no-cache"));
            throw new Exception();
        }
    }
}