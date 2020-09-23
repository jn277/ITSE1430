﻿/*
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
               switch (DisplayMenu())
                {
                    case "1": AccountName(); break;

                    case "2": AccountNumber(); break;

                    case "3": AccountBalance(); break;

                    case "q": Quit(); break;
                };
            }
            
        }
        private static string DisplayMenu ()
        {
            do
            {
                Console.WriteLine("Account Name    = 1");
                Console.WriteLine("Account Number  = 2");
                Console.WriteLine("Account Balance = 3");
                Console.WriteLine("Quit = q");
                Console.WriteLine("-----------------");
                Console.WriteLine("Please enter a menu option, or press q to quit.");

                //Get input from user
                string value = Console.ReadLine();

                if (String.Compare(value, "1", true) == 0)
                    return "1";
                else if (String.Compare(value, "2", true) == 0)
                    return "2";
                else if (String.Compare(value, "3", true) == 0)
                    return "3";
                else if (String.Compare(value, "q", true) == 0)
                    return "q";
                DisplayError("Invalid option");
            } while (true);
            
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
            do
            {
                Console.WriteLine("Enter your account name:");
                string name = Console.ReadLine();
            
                if (String.IsNullOrEmpty(name))
                    Console.WriteLine("Invalid account name entered.");
                else
                    Console.WriteLine("The account name entered is: " + name);
                return name;
            } while (true);
        }

        private static string AccountNumber()
        {
            do
            {
                Console.WriteLine("Enter your account number:");
                string number = Console.ReadLine();
                int accountNumber = Int32.Parse(number);

                if (accountNumber == 0)
                    //if (number.Length < 6)
                    Console.WriteLine("Invalid account number entered.");
                else
                    Console.WriteLine("The account number entered is: " + accountNumber);
                return number;
            } while (true);
        }

        private static string AccountBalance()
        {
            do
            {
                Console.WriteLine("Enter your account balance:");
                string balance = Console.ReadLine();
                double accountBalance = Double.Parse(balance);

                if (accountBalance <= 0)
                    Console.WriteLine("Invalid account balance entered.");
                else
                    Console.WriteLine("The account balance entered is: " + balance);
                return balance;
            } while (true);
        }

        private static void Quit ( )
        {
            do
            {
                Console.WriteLine("Do you want to exit? Enter y or n");
                string answer = Console.ReadLine();
                if (answer == "n")
                    //Console.WriteLine("Please enter a menu option, or press q to quit.");
                    DisplayMenu();
                else
                if (answer == "y")
                    break;
            } while (true);
        }
    }
}
