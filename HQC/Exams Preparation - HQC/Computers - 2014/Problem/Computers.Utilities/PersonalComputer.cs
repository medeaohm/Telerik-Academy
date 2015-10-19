namespace Computers.Utilities
{
    using System.Collections.Generic;
    using Computers.Utilities.Components;

    public class PersonalComputer : Computer
    {
        private const string LostGameMessage = "You didn't guess the number {0}.";

        private const string WinGameMessage = "You win!";

        public PersonalComputer(ICpu cpu, IRam ram, IEnumerable<IHardDriver> hardDrives, IVideoCard videoCard)
            : base(cpu, ram, hardDrives, videoCard)
        {
        }

        public void Play(int guessNumber)
        {
            Cpu.GenerateRandomNumber(1, 10);
            var number = this.Ram.LoadValue();
            if (number + 1 != guessNumber + 1)
            {
                this.VideoCard.Draw(string.Format(LostGameMessage, number));
            }
            else
            {
                this.VideoCard.Draw(WinGameMessage);
            }
        }
    }
}
