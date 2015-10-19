namespace Computers.Utilities.Components
{
    public interface IBattery
    {
        int Percentage { get; set; }

        void Charge(int percentage);
    }
}
