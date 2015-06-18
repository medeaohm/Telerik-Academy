namespace School
{
    using System;
    using System.Collections.Generic;
using System.Text;

    public class School
    {
        private string schoolName;
        private List<Clas> classes;

        public School(string schoolName)
        {
            this.SchoolName = schoolName;
            this.classes = new List<Clas>();
        }

        public string SchoolName
        {
            get { return schoolName; }
            set { schoolName = value; }
        }

        public List<Clas> Classes
        {
            get
            {
                return new List<Clas>(this.Classes);
            }
        }


        public void AddClasses(Clas clas)
        {
            this.classes.Add(clas);
        }

        public List<Clas> GetClasses()
        {
            return new List<Clas>(this.classes);
        }

        public override string ToString()
        {
            StringBuilder result = new StringBuilder();
            result.AppendLine(string.Format("SCHOOL: {0}\n", this.SchoolName));

            foreach (Clas currentClass in this.classes)
            {
                result.Append("Classes:");
                result.AppendLine(currentClass.ToString());
            }

            return result.ToString();
        }
    }
}
