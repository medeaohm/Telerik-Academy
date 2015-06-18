namespace ExtensionMethods
{
    using System;
    using System.Text;
    
    public static class StringBuilderSubstring
    {
        public static StringBuilder Substring(this StringBuilder strBuilder, int startIndex, int count)
        {
            string startString = strBuilder.ToString();
            StringBuilder result = new StringBuilder(count);

            if (startIndex < 0 || startIndex >= strBuilder.Length)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }
            if (count < 0 || startIndex + count >= strBuilder.Length)
            {
                throw new IndexOutOfRangeException("Count out of range");
            }

            string substr = startString.Substring(startIndex, count);
            return result.Append(substr);
        }

        public static StringBuilder Substring(this StringBuilder strBuilder, int startIndex)
        {
            string startString = strBuilder.ToString();
            StringBuilder result = new StringBuilder(startString.Length - 1 - startIndex);

            if (startIndex < 0 || startIndex >= strBuilder.Length)
            {
                throw new IndexOutOfRangeException("Invalid index!");
            }

            string substr = startString.Substring(startIndex);
            return result.Append(substr);
        }
    }
}
