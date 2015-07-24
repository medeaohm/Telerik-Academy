namespace Methods
{
    using System;

    public class Student
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public string OtherInfo { get; set; }

        public bool IsOlderThan(Student other)
        {
            DateTime firstStudentDOB = DateTime.Parse(this.OtherInfo.Substring(this.OtherInfo.Length - 10));
            DateTime secondStudentDOB = DateTime.Parse(other.OtherInfo.Substring(other.OtherInfo.Length - 10));
            bool secondStudentIsOlder = (firstStudentDOB > secondStudentDOB);

            return secondStudentIsOlder;
        }
    }
}
