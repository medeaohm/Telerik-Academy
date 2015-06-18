using System;

//### Problem 10.	Employee Data
//A marketing company wants to keep record of its employees. Each record would have the following characteristics:
//*	First name
//*	Last name
//*	Age (0...100)
//*	Gender (m or f)
//*	Personal ID number (e.g. 8306112507)
//*	Unique employee number (27560000…27569999)

//Declare the variables needed to keep the information for a single employee using appropriate primitive data types. Use descriptive names. Print the data at the console.

    class EmployeeData
    {
        static void Main()
        {
            string firstName = "Niya";
            string lastName = "Omerska";
            ushort age = 25;
            char gender = 'f';
            ulong personalID = 8902036479;
            uint employeeNumber = 27560015;

            Console.WriteLine(" First name: {0} \n Last name: {1} \n Age: {2} \n Gender: {3} \n Personal ID number: {4} \n Unique Employee number: {5}", firstName, lastName, age, gender, personalID, employeeNumber);
        }
    }

