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
                if (choice == 'y')
                    //AccountName();
                return;
                else if (choice == ' ')
                    break;

                //else if (choice == "Account Number")
                //AccountNumber();
                //else if (choice == "Account Balance")
                //AccountBalance();
                //return;
            };
            
            //AccountNumber();
            //AccountBalance();
        }
        private static char DisplayMenu ()
        {
            // do S while (E);
            // block statement => { S* }
            do
            {
                Console.WriteLine("Account Name");
                //Console.WriteLine("Account Number");
                //Console.WriteLine("Account Balance");
                Console.WriteLine("-----------------");
                Console.WriteLine("Continue?");

                //Get input from user
                string value = Console.ReadLine();

                if (value == "y")
                    AccountName();
                else if (value == "n")
                    return ' ';
                else if (value == " ")
                    return ' ';
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
