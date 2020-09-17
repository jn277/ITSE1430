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
               switch (DisplayMenu())
                {
                    case "q": return;

                    case "1": AccountName(); break;

                    case "2": AccountNumber(); break;

                    case "3": AccountBalance(); break;
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
                Console.WriteLine("Please enter a menu option.");

                //Get input from user
                string value = Console.ReadLine();

                //if (value ==  "q")
                if (String.Compare(value, "q", true) == 0)
                    return "q";
                else if (String.Compare(value, "1", true) == 0)
                    return "1";
                else if (String.Compare(value, "2", true) == 0)
                    return "2";
                else if (String.Compare(value, "3", true) == 0)
                    return "3";
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
        private static void AccountName()
        {
                Console.WriteLine("Enter your account name:");
                string name = Console.ReadLine();
                if (!String.IsNullOrEmpty(name))
                    {
                        Console.WriteLine("Invalid account name entered");
                        //Console.WriteLine("Enter the account name or press q to quit");
                    }
                    //Console.WriteLine("The account name entered is: " + name);
                    //Console.WriteLine("Invalid account name entered");
                else
            //Console.WriteLine("Invalid account name entered");
                    {
                        Console.WriteLine("The account name entered is: " + name);
                    }
                    
            //return name;
        }

        private static string AccountNumber()
        {
            Console.WriteLine("Enter your account number:");
            string number = Console.ReadLine();
            //int accountNumber = Int32.Parse(number);
            Console.WriteLine("The account number entered is: " + number);
            return number;
        }

        private static string AccountBalance()
        {
            Console.WriteLine("Enter your account balance:");
            string balance = Console.ReadLine();
            Console.WriteLine("The account balance entered is: " + balance);
            return balance;
        }
    }
}
