namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Collections.Generic;
    using System.Net;
    using Http;

    public class RedirectActionResults : ActionResult
    {
        private const string ContentType = "text/plain; charset=utf-8";

        public RedirectActionResults(HttpRequest request, object model)
            : base(request, model)
        {
            this.ResponseHeaders.Add(new KeyValuePair<string, string>("Location:", "https://telerikacademy.com/Forum/Home"));
        }

        public virtual HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.Redirect;
        }

        public string GetContent()
        {
            return this.Model.ToString();
        }

        public override HttpResponse GetResponse()
        {
            var response = new HttpResponse(Request.ProtocolVersion, this.GetStatusCode(), this.GetContent(), ContentType);
            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }
    }
}