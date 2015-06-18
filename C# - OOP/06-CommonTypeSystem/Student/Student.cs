namespace Student
{
    using System;
    using System.Text;

    public class Student : ICloneable, IComparable
    {
        public string FirstName { get; set; }
        public string MiddleName { get; set; }
        public string LastName { get; set; }
        public string SSN { get; set; }
        public string Address { get; set; }
        public string MobilePhone { get; set; }
        public string Email { get; set; }
        public byte Course { get; set; }
        public Specialty Spec { get; set; }
        public University Univ { get; set; }
        public Faculty Fac { get; set; }

        public Student(string firstName, string middleName, string lastName, string ssn, string address, string mobilePhone, string email, byte course, Specialty speciality, University university, Faculty faculty)
        {
            this.FirstName = firstName;
            this.MiddleName = middleName;
            this.LastName = lastName;
            this.SSN = ssn;
            this.Address = address;
            this.MobilePhone = mobilePhone;
            this.Email = email;
            this.Course = course;
            this.Spec = speciality;
            this.Univ = university;
            this.Fac = faculty;
        }

        public object Clone()
        {
            return new Student(this.FirstName, this.MiddleName, this.LastName, this.SSN, this.Address, this.MobilePhone, this.Email, this.Course, this.Spec, this.Univ, this.Fac);
        }

        public int CompareTo(object obj)
        {
            if (this.FirstName.CompareTo((obj as Student).FirstName) != 0)
            {
                return this.FirstName.CompareTo((obj as Student).FirstName);
            }
            if (this.MiddleName.CompareTo((obj as Student).MiddleName) != 0)
            {
                return this.MiddleName.CompareTo((obj as Student).MiddleName);
            }
            if (this.LastName.CompareTo((obj as Student).LastName) != 0)
            {
                return this.LastName.CompareTo((obj as Student).LastName);
            }
            if (this.SSN.CompareTo((obj as Student).SSN) != 0)
            {
                return this.SSN.CompareTo((obj as Student).SSN);
            }
            return 0;
        }

        public override string ToString()
        {
            var output = new StringBuilder();

            output.AppendFormat("Student: {0} {1} {2}", this.FirstName, this.MiddleName, this.LastName);
            output.AppendLine("SSN: " + this.SSN);
            output.AppendLine("Address: " + this.Address);
            output.AppendLine("Mobile Phone: " + this.MobilePhone);
            output.AppendLine("E-mail: " + this.Email);
            output.AppendLine("Course: " + this.Course);
            output.AppendLine("University: " + this.Univ);
            output.AppendLine("Faculty: " + this.Fac);
            output.AppendLine("Speciality: " + this.Spec);

            return output.ToString();
        }

        public override int GetHashCode()
        {
            return this.LastName.GetHashCode() * 3;
        }

        public override bool Equals(object obj)
        {
            if (!this.FirstName.Equals((obj as Student).FirstName)) return false;
            if (!this.MiddleName.Equals((obj as Student).MiddleName)) return false;
            if (!this.LastName.Equals((obj as Student).LastName)) return false;
            if (!this.SSN.Equals((obj as Student).SSN)) return false;
            if (!this.MobilePhone.Equals((obj as Student).MobilePhone)) return false;
            if (!this.Address.Equals((obj as Student).Address)) return false;
            if (!this.Email.Equals((obj as Student).Email)) return false;
            if (!this.Fac.Equals((obj as Student).Fac)) return false;
            if (!this.Course.Equals((obj as Student).Course)) return false;
            if (!this.Univ.Equals((obj as Student).Univ)) return false;
            if (!this.Spec.Equals((obj as Student).Spec)) return false;

            return true;
        }

        public static bool operator == (Student firstStudent, Student secondStudent)
        {
            return firstStudent.Equals(secondStudent);
        }

        public static bool operator !=(Student firstStudent, Student secondStudent)
        {
            return !(firstStudent.Equals(secondStudent));
        }
    }

    public enum Specialty
    {
        Low,
        Art,
        IT,
        Mathematician,
        Physicist,
        Economician
    }

    public enum University
    {
        SU, 
        TU, 
        UNSS, 
        NATFIZ
    }

    public enum Faculty
    {
        Low,
        Art,
        IT,
        Mathematics,
        Physics,
        Economy
    }
}
