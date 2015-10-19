namespace ConsoleWebServer.Framework.Http
{
    using System;

    public class HttpNotFound : Exception
    {
        public const string ClassName = "HttpNotFoundException";

        public HttpNotFound(string message, ActionDescriptor request = null)
            : base(message)
        {
        }

        public class ParserException : Exception
        {
            public ParserException(string message, ActionDescriptor request = null)
                : base(message)
            {
            }
        }
    }
}