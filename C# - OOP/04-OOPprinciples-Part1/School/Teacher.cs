namespace School
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;

    public class Teacher : Person, IComment
    {
        private List<Disciplines> disciplines;

        public Teacher(string firstName, string lastName, IEnumerable<Disciplines> disciplines)
            : base(firstName, lastName)
        {
            this.disciplines = disciplines.ToList();
        }

        public List<Disciplines> GetDisciplines()
        {
            return new List<Disciplines>(this.disciplines);
        }

        public override string ToString()
        {
            var sb = new StringBuilder();

            sb.AppendLine("Teacher name: " + base.FirstName + " " + base.LastName);
            sb.AppendLine("Teacher disciplines: ");

            sb.AppendLine(string.Join(", ", disciplines));

            return sb.ToString();
        }
    }
}
