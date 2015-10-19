namespace ConsoleWebServer.Framework.ActionResults
{
    using System.Collections.Generic;
    using ConsoleWebServer.Framework.Http;

    /// <summary>
    /// Interface for Action Result class and all that inherite it
    /// </summary>
    public interface IActionResult
    {
        /// <summary>
        /// Gets the HTTP request
        /// </summary>
        HttpRequest Request
        {
            get;
        }

        /// <summary>
        /// Gets a List of Key-Value Pairs - the Response Headers
        /// </summary>
        List<KeyValuePair<string, string>> ResponseHeaders
        {
            get;
        }

        /// <summary>
        /// Get the HTTP response
        /// </summary>
        /// <returns>HTTP response</returns>
        HttpResponse GetResponse();
    }
}