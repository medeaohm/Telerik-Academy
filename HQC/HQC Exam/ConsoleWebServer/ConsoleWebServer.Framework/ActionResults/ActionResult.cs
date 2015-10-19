namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Collections.Generic;
    using Http;

    public abstract class ActionResult : IActionResult
    {
        public readonly object Model;

        public ActionResult(HttpRequest request, object model)
        {
            this.Model = model;
            this.Request = request;
            this.ResponseHeaders = new List<KeyValuePair<string, string>>();
        }

        public HttpRequest Request
        {
            get; private set;
        }

        public List<KeyValuePair<string, string>> ResponseHeaders
        {
            get; private set;
        }

        public abstract HttpResponse GetResponse();
    }
}