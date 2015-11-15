namespace Sender
{
    using System;
    using IronMQ;

    public class IronMQSender
    {
        public const string IronProjectID = "5648f4d09195a800070000a4";
        public const string Token = "9kpEjSZpJqUbP34WIncg";

        public static void Main()
        {
            Client client = new Client(IronProjectID, Token);
            Queue queue = client.Queue("LiveChat");

            while (true)
            {
                Console.WriteLine("Please enter the message you want to send ot type exit to close the application:");
                string msg = Console.ReadLine();

                if (msg == "exit")
                {
                    break;
                }

                queue.Push(msg);
                Console.WriteLine("Your message has been send to the IRANMQ server.\n");
            }
        }
    }
}
