namespace School
{
    using System;

    public static class Validator
    {
        public static bool IsValidName(string name)
        {
            return !string.IsNullOrWhiteSpace(name);
        }

        public static bool IsCoureValueNull(Course value)
        {
            return value == null;
        }

        public static bool IsStudentValueNull(Student value)
        {
            return value == null;
        }

        public static bool IsValidUniqueNumber(int uniqueNumber, int min, int max)
        {
            return min <= uniqueNumber && uniqueNumber <= max;
        }
    }
}