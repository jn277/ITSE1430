/*
 * Donald Helaire
 * ITSE 1430 
 * Lab 1 - Budget
 */
using System;

namespace Budget
{
    class Program
    {
        static void Main ( string[] args )
        {
            while (true)
            {
                string choice = DisplayMenu();
                if (choice == "Q)uit")
                    break;
                //else if (choice == "Account Name")
                else 
                    AccountName();
                //else if (choice == "Account Number")
                //AccountNumber();
                //else if (choice == "Account Balance")
                //AccountBalance();
                //return;
            };
            
            //AccountNumber();
            //AccountBalance();
        }
        static string DisplayMenu ()
        {
            // do S while (E);
            // block statement => { S* }
            do
            {
                Console.WriteLine("Account Name");
                //Console.WriteLine("Account Number");
                //Console.WriteLine("Account Balance");
                Console.WriteLine("-----------------");
                Console.WriteLine("Quit?");
                //Get input from user
                string value = Console.ReadLine();

                //if (value == "Quit")
                    //return "Exiting..";
                //else if (value == "Account Name")
                    //return 'A';
            }
            while (true);
        }
        static void AccountName()
        {
            //string accountName = "Enter the account nickname";
            Console.WriteLine("Enter your account name:");
            Console.ReadLine();
        }


      
        //static void AccountNumber()
        //{

        //}

        //static void AccountBalance()
        //{

        //}
    }
}
