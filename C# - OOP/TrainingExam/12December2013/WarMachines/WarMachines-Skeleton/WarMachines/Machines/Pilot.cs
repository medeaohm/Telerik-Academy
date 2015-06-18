namespace WarMachines.Machines
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    using Interfaces;

    public class Pilot : IPilot
    {
        private string name;
        private IList<IMachine> machines;
        
        public Pilot(string name)
        {
            this.Name = name;
            this.Machines = new List<IMachine>();
        }

        public string Name
        {
            get 
            {
                return this.name; 
            }
            private set
            {
                if (string.IsNullOrEmpty(value))
                {
                    throw new ArgumentNullException("Pilot name cannot be null or empy.");
                }
                this.name = value;
            }
        }

        public IList<IMachine> Machines
        {
            get
            {
                return this.machines;
            }
            private set
            {
                if (value == null)
                {
                    throw new ArgumentNullException("List of machines cannot be null");
                }
                this.machines = value;
            }
        }

        public void AddMachine(IMachine machine)
        {
            this.Machines.Add(machine);
        }

        public string Report()
        {
            var report = new StringBuilder();
            report.AppendFormat("{0} - {1} {2}", this.Name, this.Machines.Count == 0 ? "no" : this.Machines.Count.ToString(), this.Machines.Count > 1 ? "machines" : this.Machines.Count == 1 ? "machine" : "");

            var sortedMachines = this.Machines.OrderBy(m => m.HealthPoints).ThenBy(m => m.Name);

            foreach (var machine in sortedMachines)
            {
                report.AppendLine(machine.ToString());
            }

            return report.ToString().Trim();
        }
    }
}
