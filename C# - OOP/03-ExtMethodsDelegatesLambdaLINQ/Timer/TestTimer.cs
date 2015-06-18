namespace Timer
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class TestTimer
    {
        public static void Main()
        {
            TimerDel timer = new TimerDel(5);

            timer.SomeMethods += FirstTestMethod;
            timer.SomeMethods += SecondTestMethod;

            timer.ExecuteMethods();
        }

        public static void FirstTestMethod()
        {
            Console.WriteLine("First added method!");
        }

        public static void SecondTestMethod()
        {
            Console.WriteLine("Second added method!");
        }
    }
}