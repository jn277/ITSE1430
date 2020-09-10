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
                //char choice = DisplayMenu();
                //if (choice == 'Q')
                //return;
                //else if (choice == 'A')
                //AddMovie();
                switch (DisplayMenu())
                {
                    case 'Q': return;

                    case 'A': AddMovie(); break;

                    case 'V': ViewMovie(); break;
                };
            };

            static string title = "";
            static string description = "";
            static string rating = "";
            static int duration;
            static bool isClassic;
        }

        static void AddMovie ()
        {
            //Get title
            Console.WriteLine("Movie title: ");
            //string title = Console.ReadLine();
            //string title = ReadString(true);
            //int title2 = "";
            title = ReadString(true);  //string title = ReadString(true);

            //Get description
            Console.WriteLine("Description (optional): ");
            //string description = Console.ReadLine();
            //string description = ReadString(false);
            description = ReadString(false);


            //Get rating
            Console.WriteLine("Rating: ");
            //string rating = Console.ReadLine();
            //string rating = ReadString(false);
            rating = ReadString(false);

            //Get duration
            Console.WriteLine("Duration (in minutes): ");
            //string duration = Console.ReadLine();
            //int duration = ReadInt32(0);
            duration = ReadInt32(0);

            //Get is classic
            Console.WriteLine("Is Classic (Y/N)? ");
            //string isClassic = Console.ReadLine();
            //bool isClassic = ReadBoolean();
            isClassic = ReadBoolean();
        }


        static char DisplayMenu ()
        {
            // 1+ iteration, post test
            // do S while (E);
            // block statement => { S* }
            do
            {
                Console.WriteLine("Movie Library");
                Console.WriteLine("-----------------");
                Console.WriteLine("V)iew Movie");
                Console.WriteLine("A)dd Movie");
                Console.WriteLine("Q)uit");

                //Get input from user
                string value = Console.ReadLine();

                //C++: if (x = 10) ; //Not valid in C#
                // if (E) S;
                // if (E) S else S;
                if (value == "Q")   // 2 equal signs => equality 
                    return 'Q';
                else if (value == "A")
                    return 'A';
                else if (value == "V")
                    return 'V';

                DisplayError("Invalid option");
            } while (true);
        }

        //Displays an error
        private static void DisplayError ( string message )
        {
            Console.BackgroundColor = ConsoleColor.Red;
            Console.ForegroundColor = ConsoleColor.White;

            Console.WriteLine(message);

            Console.ResetColor();
        }

        static bool ReadBoolean ()
        {
            do
            {
                //Read as string
                string value = Console.ReadLine();

                // switch - replacement for if-else-if WHEN
                //  Each condition is against same variable
                //  AND equality
                // switch (E)
                // {
                //    case*
                //    [default]
                // }
                // case    ::= case E : S*
                // default ::= default : S*

                //if (value == "Y" || value == "y")  //NOT THE SAME ::=   value == "Y" || "y"
                //    return true;
                //else if (value == "N" || value == "n")

                //Boolean.TryParse(value, out bool result)           
                //if (value == "Y")
                //return true;
                //else if (value == "N")
                // return false;
                //else
                //    S;
                // C++ DIFFERENCES
                //   1. No fallthrough  case E: S; break; case E2 : S;
                //   2. Any expression type is allowed
                //   3. Case labels must be unique and compile time constants
                //   4. Multiple statements are allowed
                switch (value)
                {
                    case "X": Console.WriteLine("Wrong value"); break;
                    case "Y":                   //If case statement empty (including semicolon) then fallthrough
                    case "y": return true;

                    case "N": return false;

                    case "A":
                    {
                        //Use block statement for more than 1 statement
                        Console.WriteLine("Wrong value");
                        Console.WriteLine("Wrong value again");
                        break;
                    };

                    default:
                    break;//if nothing else

                };
                    DisplayError("Invalid option");
            } while (true);
        }

        //Reads an integer
        static int ReadInt32 ()
        {
            return ReadInt32(Int32.MinValue);
        }

        //Reads an integer with a minimum value
        static int ReadInt32 ( int minimumValue )
        {
            do
            {
                string value = Console.ReadLine();

                //Parse to int int Int32.Parse ( string ) - not safe
                //int result = Int32.Parse(value);

                // Parameter kinds
                //   Input parameter ("pass by value") - a copy of the argument is placed into parameter inside function definition
                //   Input/output parameter ("pass by reference") - a reference to the argument is passed to the function and both original argument and parameter reference same value ( C++: int& )
                //   Output paramter - function caller does not provide input, function always provides output (C++: return type)
                //bool Int32.TryParse ( string, out int result )
                // Double.Parse/TryParse
                // Single.Parse/TryParse
                // Boolean.Parse/TryParse 
                // Int16.Parse/TryParse

                //Inline variable declaration - out parameters only
                //int result;
                //if (Int32.TryParse(value, out int result) && result >= minimumValue)
                //return result;
                if (Int32.TryParse(value, out var result) && result >= minimumValue)
                    return result;

                //Terminates the loop
                //break;
                //Terminate the iteration 
                //continue;

                if (minimumValue != Int32.MinValue)   //Int32.MaxValue
                    DisplayError("Value must be at least " + minimumValue);  //String concatenation
                else
                    DisplayError("Must be integral value");
            } while (true);
        }
            static void ViewMovie ()
            {
                Console.WriteLine(title);

                //TODO: Description if available
                Console.WriteLine(" " + description);

                //TODO: If available
                Console.WriteLine(" " + rating);

                Console.WriteLine(duration);

                Console.WriteLine(isClassic);
            }
        

        //Arithmetic (unary) 
        //  +E
        //  -E 
        //Arithmetic (binary) - type coercion
        // addition 10 + 12   
        // subtraction 123 - 110.4
        // multiplication 10 * 20
        // division 30 / 3 
        // modulus 7 % 4 => 3 (remainder), only works with integrals

        //int division problem
        //  10 / 3 => int / int => int  = 3
        //  10.0 / 3 => double / int => double = 3.33
        //  (double)10 / 3 => double /int 

        // typecast => (T)E
        //not allowed => (string)10 , (int)"Hello",  (int)10.5

        //Logical operators (booleans)
        // NOT => !E : boolean
        // AND => E && E : boolean
        // OR => E || E : boolean

        //Relational operators (primitives + a few extra)
        // equality => E == E
        // inequality => E != E
        // greater than => E > E
        // greater than or equal to => E >= E
        // less than => E < E
        // less than or equal to => E <= E
        //Reads a string, optionally required
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

        static void FunWithStrings()
        {
            // \n new line
            // \t tab
            var message = "Hello\nWorld";
        }
    }

}