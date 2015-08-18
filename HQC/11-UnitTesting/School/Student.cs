namespace School
{
    using System;

    public class Student
    {
        private const int MinValueUniqueNumber = 10000;
        private const int MaxValueUniqueNumber = 99999;
        private string name;
        private int uniqueNumber;

        public Student(string name, int uniqueNumber)
        {
            this.Name = name;
            this.UniqueNumber = uniqueNumber;
        }

        public string Name
        {
            get
            {
                return this.name;
            }

            set
            {
                if (!Validator.IsValidName(value))
                {
                    throw new ArgumentNullException("Name can't be empty");
                }

                this.name = value;
            }
        }

        public int UniqueNumber
        {
            get
            {
                return this.uniqueNumber;
            }

            set
            {
                if (!Validator.IsValidUniqueNumber(value, MinValueUniqueNumber, MaxValueUniqueNumber))
                {
                    throw new ArgumentException("Unique number must be between " + MinValueUniqueNumber + " and " + MaxValueUniqueNumber);
                }

                this.uniqueNumber = value;
            }
        }

        public void AttendCourse(Course course)
        {
            if (Validator.IsCoureValueNull(course))
            {
                throw new ArgumentNullException("Course cannot be null.");
            }

            course.AddStudent(this);
        }

        public void LeaveCourse(Course course)
        {
            if (Validator.IsCoureValueNull(course))
            {
                throw new ArgumentNullException("Course cannot be null.");
            }

            course.RemoveStudent(this);
        }
    }
}
