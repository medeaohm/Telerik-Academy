namespace Builder
{
    /// <summary>
    /// The 'Builder' abstract class
    /// </summary>
    public abstract class VehicleBuilder
    {
        private Vehicle vehicle;

        // Gets vehicle instance
        public Vehicle Vehicle
        {
            get 
            { 
                return this.vehicle; 
            }
            set
            {
                this.vehicle = value;
            }
        }

        // Abstract build methods
        public abstract void BuildFrame();

        public abstract void BuildEngine();
        
        public abstract void BuildWheels();
        
        public abstract void BuildDoors();
    }
}
