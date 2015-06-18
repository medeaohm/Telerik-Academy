namespace GSM
{
    using System;


    class StartGSM
    {
        static void Main()
        {
            string model = "S3";
            Manufacturer man = Manufacturer.SAMSUNG;
            string owner = "Pesho";
            Display display = new Display(5.6, 1600000);
            Battery battery = new Battery(BatteryType.LiIon, 20, 50);
            decimal price = 500;
            GSM myGSM = new GSM(model, man, owner, display, battery, price);

            
            Console.WriteLine(myGSM.ToString());
            CallHistory test = new CallHistory();
            test.CreateHistory();

            //Console.WriteLine(GSM.iPhone6.ToString());
        }
    }
}
