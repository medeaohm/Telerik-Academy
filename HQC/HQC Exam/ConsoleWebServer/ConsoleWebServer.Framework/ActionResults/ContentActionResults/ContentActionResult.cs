namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Net;
    using Http;

    public class ContentActionResult : ActionResult
    {
        private const string ContentType = "text/plain; charset=utf-8";

        public ContentActionResult(HttpRequest request, object model)
            : base(request, model)
        {
        }

        public override HttpResponse GetResponse()
        {
            var response = new HttpResponse(this.Request.ProtocolVersion, HttpStatusCode.OK, this.Model.ToString(), ContentType);
            foreach (var responseHeader in this.ResponseHeaders)
            {
                response.AddHeader(responseHeader.Key, responseHeader.Value);
            }

            return response;
        }
    }
}