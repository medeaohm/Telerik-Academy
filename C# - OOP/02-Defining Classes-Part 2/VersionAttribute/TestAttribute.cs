namespace VersionAttribute
{
    using System;
    using System.Reflection;

    [Version(VersionAttribute.Type.Class, "TestAttribute", "1.0")]

    class TestAttribute
    {
        public static void Main(string[] args)
        {
            var att = typeof(TestAttribute).GetCustomAttributes<VersionAttribute>();

            foreach (var attribute in att)
            {
                Console.WriteLine("Type: {0}\nName: {1}\nVersion: {2}", attribute.Component, attribute.Name, attribute.Version);
            }
        }
    }
}
