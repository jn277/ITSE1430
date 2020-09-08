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
                char choice = DisplayMenu();
            };
        }
        private static char DisplayMenu ()
        {
            // do S while (E);
            // block statement => { S* }
            do
            {
                Console.WriteLine("Account Name    = 1");
                Console.WriteLine("Account Number  = 2");
                Console.WriteLine("Account Balance = 3");
                Console.WriteLine("-----------------");
                Console.WriteLine("Please enter a menu number");

                //Get input from user
                string value = Console.ReadLine();

                switch(value)
                {
                    case "1":
                    AccountName();
                    break;

                    //case "2":
                    //AccountNumber();
                    //break;

                    //case "3":
                    //AccountBalance();
                    //break;

                    case " ":
                    break;
                }
            }
            while (true);
            
        }
        private static string AccountName()
        {
            //string accountName = "Enter the account nickname";
            Console.WriteLine("Enter your account name:");
            string name = Console.ReadLine();
            Console.WriteLine("The account name entered is: " + name);
            return name;
        }

        //static void AccountNumber()
        //{

        //}

        //static void AccountBalance()
        //{

        //}
    }
}
