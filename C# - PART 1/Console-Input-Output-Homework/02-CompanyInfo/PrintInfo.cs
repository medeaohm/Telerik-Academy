using System;


//### Problem 2.	Print Company Information
//*	A company has name, address, phone number, fax number, web site and manager. The manager has first name, last name, age and a phone number.
//*	Write a program that reads the information about a company and its manager and prints it back on the console.

//_Example input:_

//|       program       |            user            |
//|---------------------|----------------------------|
//| Company name:       | Telerik Academy            |
//| Company address:    | 31 Al. Malinov, Sofia      |
//| Phone number:       | +359 888 55 55 555         |
//| Fax number:         | 2                          |
//| Web site:           | http://telerikacademy.com/ |
//| Manager first name: | Nikolay                    |
//| Manager last name:  | Kostov                     |
//| Manager age:        | 25                         |
//| Manager phone:      | +359 2 981 981             |

//_Example output:_

//    Telerik Academy
//    Address: 231 Al. Malinov, Sofia
//    Tel. +359 888 55 55 555
//    Fax: (no fax)
//    Web site: http://telerikacademy.com/
//    Manager: Nikolay Kostov (age: 25, tel. +359 2 981 981)	

class PrintInfo
    {
        static void Main()
        {
            Console.WriteLine("Enter the company name...");
            string nameC = Console.ReadLine();
            Console.WriteLine("Enter the company address...");
            string address = Console.ReadLine();
            Console.WriteLine("Enter the company phone number...");
            string phone = Console.ReadLine();
            Console.WriteLine("Enter the company fax number...");
            string fax = Console.ReadLine();
            Console.WriteLine("Enter the company web site...");
            string site = Console.ReadLine();
            Console.WriteLine("Enter the manager first name...");
            string nameM = Console.ReadLine();
            Console.WriteLine("Enter the manager last name...");
            string surnameM = Console.ReadLine();
            Console.WriteLine("Enter the manager's age...");
            string ageM = Console.ReadLine();
            Console.WriteLine("Enter the manager's phone...");
            string phoneM = Console.ReadLine();
            
            if (fax.Length >= 6)
	        {
                fax=fax;
	        }
            else
            {
                fax = "(no fax)";
            }

            Console.WriteLine("\n\n{0}", nameC);
            Console.WriteLine("Address: {0}", address);
            Console.WriteLine("Tel. {0}", phone);
            Console.WriteLine("Fax: {0}", fax);
            Console.WriteLine("Web site: {0}", site);
            Console.WriteLine("Manager: {0} {1} (age: {2}, tel. {3})", nameM, surnameM, ageM, phoneM);
        }
    }
