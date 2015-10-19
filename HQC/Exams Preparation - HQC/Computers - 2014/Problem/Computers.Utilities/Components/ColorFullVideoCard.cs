namespace Computers.Utilities.Components
{
    using System;

    public class ColorFullVideoCard : MotherboardComponents, IVideoCard
    {
        public void Draw(string data)
        {
            Console.ForegroundColor = ConsoleColor.Green;
            Console.WriteLine(data);
            Console.ResetColor();
        }
    }
}
