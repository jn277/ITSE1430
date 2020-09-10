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
            //while (true)
            //{
                string choice = DisplayMenu();
            //}
        }
        private static string DisplayMenu ()
        {
            // do S while (E);
            // block statement => { S* }
            //do
            //while (true)
            //{
                Console.WriteLine("Account Name    = 1");
                Console.WriteLine("Account Number  = 2");
                Console.WriteLine("Account Balance = 3");
                Console.WriteLine("Quit = q");
                Console.WriteLine("-----------------");
                Console.WriteLine("Please enter a menu option.");

                //Get input from user
                string value = Console.ReadLine();

                switch(value)
                {
                    case " ":
                    DisplayError("Please enter a valid menu option");
                    break;

                    case "1":
                        AccountName();
                    break;

                    //case "2":
                        //AccountNumber();
                    //break;

                    //case "3":
                        //AccountBalance();
                    //break;

                    case "q":
                    Console.WriteLine(" ");
                    break;
                };
            //}
            //while (true);
            return value;
        }
        private static void DisplayError ( string message )
        {
            //Console.BackgroundColor = ConsoleColor.Red;
            //Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(message);

            //Console.ResetColor();
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
