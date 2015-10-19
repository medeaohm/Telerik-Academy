namespace ConsoleWebServer.Framework
{
    using System;
    using System.IO;
    using System.Linq;
    using System.Net;

    using ConsoleWebServer.Framework.Http;

    public class StaticFileHandler
    {
        private const int DefaultDepth = 3;
        private const int MinDepth = 0;

        public bool CanHandle(HttpRequest request)
        {
            int indexOfDot = request.Uri.LastIndexOf(".", StringComparison.Ordinal);
            int indexOfSlash = request.Uri.LastIndexOf("/", StringComparison.Ordinal);

            return indexOfDot > indexOfSlash;
        }

        public HttpResponse Handle(HttpRequest request)
        {
            string filePath = Environment.CurrentDirectory + "/" + request.Uri;

            if (!this.FileExists("C:\\", filePath, DefaultDepth))
            {
                return new HttpResponse(request.ProtocolVersion, HttpStatusCode.NotFound, "File not found");
            }

            string fileContents = File.ReadAllText(filePath);
            var response = new HttpResponse(request.ProtocolVersion, HttpStatusCode.OK, fileContents);
            return response;
        }

        private bool FileExists(string path, string filePath, int depth)
        {
            if (depth <= MinDepth)
            {
                return File.Exists(filePath);
            }

            try
            {
                var file = Directory.GetFiles(path);

                if (file.Contains(filePath))
                {
                    return true;
                }

                var subdirectories = Directory.GetDirectories(path);

                foreach (var subdirectory in subdirectories)
                {
                    if (this.FileExists(subdirectory, filePath, depth - 1))
                    {
                        return true;
                    }
                }

                return false;
            }
            catch (Exception)
            {
                return false;
            }
        }
    }
}