namespace ConsoleWebServer.Framework
{
    using ConsoleWebServer.Framework.Http;

    /// <summary>
    /// Conteins a method witch returns a HTTP response from a string
    /// </summary>
    public interface IResponseProvider
    {
        /// <summary>
        /// Gets the HTTP Response from a string
        /// </summary>
        /// <param name="requestAsString">The string to be transformed in HTTP response</param>
        /// <returns></returns>
        HttpResponse GetResponse(string requestAsString);
    }
}