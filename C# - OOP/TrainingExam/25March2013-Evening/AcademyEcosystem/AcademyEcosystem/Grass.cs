namespace AcademyEcosystem
{
    public class Grass : Plant
    {
        private const int GrassSize = 1;

        public Grass(Point location)
            : base(location, GrassSize)
        {

        }

        public override void Update(int time)
        {
            if (this.IsAlive)
            {
                this.Size += time;
            }
            base.Update(time);
        }
    }
}
