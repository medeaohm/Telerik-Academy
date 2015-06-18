using System;

//### Problem 11.	Bank Account Data
//*	A bank account has a holder name (first name, middle name and last name), available amount of money (balance), bank name, IBAN, 3 credit card numbers associated with the account.
//*	Declare the variables needed to keep the information for a single bank account using the appropriate data types and descriptive names.

    class BankAccount
    {
        static void Main()
        {
            string firstName = "Niya";
            string middleName = "Vaskova";
            string lastName = "Omerska";
            decimal balance = 150500.258m;
            string bank = "Unicredit";
            string myIBAN = "BG25 UBBS 7423 5987 5486 05";
            long creditCard1 = 111222333444555;
            long creditCard2 = 666777888999000;
            long creditCard3 = 123456789012345;

            Console.WriteLine(" First name: {0} \n Middle Name: {1} \n Last name: {2} \n Balance: {3} \n Bank name: {4} \n IBAN: {5} \n Credit Card 1: {6} \n Credit Card 2: {7} \n Credit Card 3: {8}", firstName, middleName, lastName, balance, bank, myIBAN, creditCard1, creditCard2, creditCard3);
        }
    }

