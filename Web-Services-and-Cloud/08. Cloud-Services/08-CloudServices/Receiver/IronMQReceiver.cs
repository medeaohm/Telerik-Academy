namespace Receiver
{
    using System;
    using System.Threading;

    using IronMQ;
    using IronMQ.Data;

    public class IronMQReceiver
    {
        public const string IronProjectID = "5648f4d09195a800070000a4";
        public const string Token = "9kpEjSZpJqUbP34WIncg";

        public static void Main()
        {
            Client client = new Client(IronProjectID, Token);
            Queue queue = client.Queue("LiveChat");

            Console.WriteLine("Listening for new messages from IronMQ server:");
            while (true)
            {
                Message msg = queue.Get();
                if (msg != null)
                {
                    Console.WriteLine("\nYou have a new message: ");
                    Console.WriteLine(string.Format("{{{0} : {1}}}", msg.Id, msg.Body));
                    queue.DeleteMessage(msg);
                }
                Thread.Sleep(100);
            }
        }
    }
}
