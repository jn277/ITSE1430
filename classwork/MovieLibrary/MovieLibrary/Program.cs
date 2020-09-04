using System;

namespace MovieLibrary
{
    class Program
    {
     static void Main ( string[] args )
        {
            //FunWithTypes();
            //FunWithVariables();

             // while => while (E) S;
            // 0+ iterations, pre test condition
            while (true)
            {
                char choice = DisplayMenu();
                if (choice == 'Q')
                    return;
                 else if (choice == 'A')
                    AddMovie();
            };

            string title = "";
            string description = "";
            string rating = "";
            int duration;
        }

     static void AddMovie ()
            {
              //Get title
            Console.WriteLine("Movie title: ");
            string title = Console.ReadLine();

            //Get description
            Console.WriteLine("Description (optional):  ");

            string description = ReadString(false);

            //Get rating
            Console.WriteLine("Rating: ");
            string rating = Console.ReadLine();

            //Get duration
            Console.WriteLine("Duration (in minutes): ");
            string duration = Console.ReadLine();

            //Get is classic
            Console.WriteLine("Is Classic (Y/N)? ");
            string isClassic = Console.ReadLine();
            }

     static char DisplayMenu()
        {
            // do S while (E);
            // block statement => { S* }
            do
            {
                Console.WriteLine("Movie Library");
                 Console.WriteLine("-----------------");
                 Console.WriteLine("Q)uit");
                //Get input from user
                string value = Console.ReadLine();

                if (value == "Q")
                    return 'Q';
                else if (value == "A")
                    return 'A';

                DisplayError();
            }
            while (true);
        }
     private static void DisplayError (string message)
         {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(message);

            Console.ResetColor();
         }

      static int ReadInt32 (int minimumValue )
        {
            do
            {
                string value = Console.Readline();
                //Parse to int int Int32.Parse ( string ) - not safe
                //int result = Int32.Parse(value);

                // Parameter kinds
                //   Input parameter ("pass by value") - a copy of the argument is placed into parameter inside function definition
                //   Input parameter ("pass by reference") - a reference to the argument is passed to the function and both the original argument and parameter reference the same value (C++; int&).
                //   Output parameter Function caller does not provide input, function always provide output (C++ return type).
                //bool Int32.TryParse ( string, out int result )
                int result;
                if (Int32.TryParse(value, out result)) && result >= minimumValue
                    return result;
                if (minimumValue)
                    DisplayError("Value must be at least " + minimumValue);
                else
                    DisplayError("Must be integral value");
            } while (true);
        }

      //Logical operators (booleans)
      // NOT => !E
      // AND =>
      // OR => E || E

      //Relational operators
      // equality => E == E
     //Logical operators 
     // NOT => !E
     static string ReadString ( bool required )
     {
        do
            {
                string value = Console.ReadLine();
                //If not required or not empty return
                if (!required || value != "")
                    return value;

                    DisplayError("Value is required");
            } while (true);
     }
        
            //private static void FunWithVariables()
    /*{
        int hours = 10;
        int value;
        value = 10;
        int calculatedValue = value * 10;
    }
     static void FunWithTypes()
        {
            bool isPassing = true;
            char letterA = 'A';
            string name = "Bob";
        */
    }

}