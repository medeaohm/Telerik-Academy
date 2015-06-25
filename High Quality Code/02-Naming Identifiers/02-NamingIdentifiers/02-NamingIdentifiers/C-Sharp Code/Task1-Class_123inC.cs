using System;

public class ExternalClass
{
    public const int MAXCOUNT = 6;

    public static void SomeMethod()
    {
        ExternalClass.InternalClass createInternalClass = new ExternalClass.InternalClass();
        createInternalClass.SomeMethod(true);
    }

    public class InternalClass
    {
        public void SomeMethod(bool some_variale)
        {
            string some_variable_as_string = some_variale.ToString();
            Console.WriteLine(some_variable_as_string);
        }
    }
}