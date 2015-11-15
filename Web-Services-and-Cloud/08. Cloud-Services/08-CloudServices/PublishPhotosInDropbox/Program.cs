namespace Dropbox
{
    using DropNet;
    using System;
    using System.Diagnostics;
    using System.IO;

    public class StartUp
    {
        private const string DropboxAppKey = "6ii14hbsuj0vesv";
        private const string DropboxAppSecret = "doohqwj7l8u2s1c";

        public static void Main()
        {
            var client = new DropNetClient(DropboxAppKey, DropboxAppSecret);

            var token = client.GetToken();
            var url = client.BuildAuthorizeUrl();

            Console.WriteLine("Open browser with in : {0}", url);
            Console.WriteLine("Press enter when clicked allow");
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", url);

            Console.ReadLine();
            var accessToken = client.GetAccessToken();

            client.UseSandbox = true;
            var metaData = client.CreateFolder("Pictures" + DateTime.Now.ToString());

            string[] dir = Directory.GetFiles("../../images/", "*.jpg");
            foreach (var item in dir)
            {
                Console.WriteLine("Uploading.....");
                FileStream stream = File.Open(item, FileMode.Open);
                var bytes = new byte[stream.Length];
                stream.Read(bytes, 0, (int)stream.Length);

                client.UploadFile("/" + metaData.Name.ToString(), item.Substring(6), bytes);
                Console.WriteLine("{0} uploaded", item);

                stream.Close();
            }
            Console.WriteLine("Done!");
            var picUrl = client.GetShare(metaData.Path);
            Process.Start(@"C:\Program Files (x86)\Google\Chrome\Application\chrome.exe", picUrl.Url);
        }
    }
}