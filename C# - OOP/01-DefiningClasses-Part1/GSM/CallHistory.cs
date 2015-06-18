namespace GSM
{
    using System;
    using System.Collections.Generic;
    using System.Linq;

    class CallHistory
    {
        //private const string[] names =  new string[] { "Pesho", "Gosho", "Ina", "Maria", "Ivan" };
        private const double price = 0.37;

        public void CreateHistory()
        {

            string[] names =  { "Pesho", "Gosho", "Ina", "Maria", "Ivan" };
            Console.WriteLine("Call History: ");
            List<Call> someCalls = new List<Call>();
            for (int i = 0; i < 5; i++)
            {
                Call aCall = new Call(DateTime.Now.AddMinutes(i*15), names[i], "0888352125", (i*60 - i*5));
                someCalls.Add(aCall);
                Console.WriteLine(someCalls[i].ToString());
            }

            double pricePerSecond = price / 60;
            double totalPrice = 0;
            foreach (var call in someCalls)
            {
                totalPrice += pricePerSecond * call.Duration;
            }

            Console.WriteLine("Total price: {0:0.00} lv", totalPrice);

            someCalls.OrderBy(x => x.Duration);
            Console.WriteLine("\nRemoving the longest call: \n{0} ", someCalls[someCalls.Count - 1]);
            someCalls.Remove(someCalls[someCalls.Count-1]);
            totalPrice = 0;
            foreach (var call in someCalls)
            {
                totalPrice += pricePerSecond * call.Duration;
            }

            Console.WriteLine("New price : {0:0.00} lv\n", totalPrice);

            Console.WriteLine("Clearng the history....");
            someCalls.Clear();

        }
    }
}
