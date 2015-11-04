namespace Hash
{
    using System;
    using System.Collections.Generic;
    using System.Linq;
    using System.Text;
    using System.Threading.Tasks;

    public class Program
    {
        public static void Main()
        {
            HashTable<string, string> hash = new HashTable<string, string>();

            hash.Add("1", "item 1");
            hash.Add("2", "item 2");
            hash.Add("dsfdsdbdjsd", "s");
            hash.Add("dsfdsdsd", "sadsadsadsad");

            string one = hash.Find("1");
            string two = hash.Find("2");
            string dsfdsdsd = hash.Find("dsfdsdsd");
            hash.Remove("1");           
        }
    }
}
