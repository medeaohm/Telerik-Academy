namespace Computers.Utilities.Components
{
    using System;

    public class MonochromeVideoCard : MotherboardComponents, IVideoCard
    {
        public void Draw(string data)
        {
            Console.ForegroundColor = ConsoleColor.Gray;
            Console.WriteLine(data);
            Console.ResetColor();
        }
    }
}
