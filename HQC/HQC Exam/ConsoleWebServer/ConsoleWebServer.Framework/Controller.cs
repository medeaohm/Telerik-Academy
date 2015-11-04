﻿namespace ConsoleWebServer.Framework
{
    using ConsoleWebServer.Framework.ActionResults;
    using ConsoleWebServer.Framework.Http;

    public abstract class Controller
    {
        protected Controller(HttpRequest request)
        {
            this.Request = request;
        }

        public HttpRequest Request
        {
            get;
            private set;
        }

        protected IActionResult Content(object model)
        {
            return new ContentActionResult(this.Request, model);
        }

        protected IActionResult Json(object model)
        {
            return new JsonActionResult(this.Request, model);
        }

        protected IActionResult Redirect(object model)
        {
            return new RedirectActionResults(this.Request, model);
        }
    }
}