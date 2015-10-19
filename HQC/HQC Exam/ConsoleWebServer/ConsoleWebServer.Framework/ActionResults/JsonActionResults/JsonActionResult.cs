namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Net;
    using Http;
    using Newtonsoft.Json;

    public class JsonActionResult : ActionResult
    {
        private const string ContentType = "application/json";

        public JsonActionResult(HttpRequest request, object model)
            : base(request, model)
        {
        }

        public virtual HttpStatusCode GetStatusCode()
        {
            return HttpStatusCode.OK;
        }

        public string GetContent()
        {
            return JsonConvert.SerializeObject(this.Model);
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