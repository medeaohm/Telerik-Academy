namespace HostingInIIS
{
    using System;
    using System.ServiceModel;
    using System.ServiceModel.Description;
    using Strings;

    /// <summary>
    /// Open containing solution folder and run .exe as Administrator.
    /// </summary>
    public class Program
    {
        public static void Main()
        {
            StartHost();
        }

        private static void StartHost()
        {
            string url = "http://localhost:2389/StringsService";

            ServiceHost selfHost = new ServiceHost(typeof(StringsService), new Uri(url));

            ServiceMetadataBehavior smb = new ServiceMetadataBehavior();
            smb.HttpGetEnabled = true;
            selfHost.Description.Behaviors.Add(smb);
            selfHost.Open();

            Console.WriteLine(url);
            Console.ReadLine();
        }
    }
}
