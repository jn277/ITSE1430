﻿using System;
using System.Text;

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

            //static string title = "";
            //static string description = "";
            //static string rating = "";
            //static int duration;
            //static bool isClassic;
        }

        static void AddMovie ()
        {
            //Get title
            Console.WriteLine("Movie title: ");
            string title = Console.ReadLine();
            //string title = ReadString(true);
            //int title2 = "";
            title = ReadString(true);  //string title = ReadString(true);

            //Get description
            Console.WriteLine("Description (optional): ");
            string description = Console.ReadLine();
            //string description = ReadString(false);
            description = ReadString(false);


            //Get rating
            Console.WriteLine("Rating: ");
            string rating = Console.ReadLine();
            //string rating = ReadString(false);
            rating = ReadString(false);

            //Get duration
            Console.WriteLine("Duration (in minutes): ");
            //string duration = Console.ReadLine();
            int duration = ReadInt32(0);
            //duration = ReadInt32(0);

            //Get is classic
            Console.WriteLine("Is Classic (Y/N)? ");
            //string isClassic = Console.ReadLine();
            bool isClassic = ReadBoolean();
            //isClassic = ReadBoolean();
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
                //if (value == "Q")   // 2 equal signs => equality 
                if (String.Compare(value, "Q", true) == 0)
                    return 'Q';
                else if (String.Compare(value, "A", StringComparison.CurrentCultureIgnoreCase) == 0)
                    return 'A';
                else if (String.Compare(value, "V", true) == 0)
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
                //switch (value)
                switch (value.ToLower())
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
                Console.WriteLine("Title\t\tRating\tDuration (in mins)\tIsClassic");
                //Console.WriteLine("-----------------");
                Console.WriteLine("".PadLeft(50, '-'));
            //1. Format arguments
            // Format string - consists of string characters with arguments specified in curly braces as zero-based ordinals
            // 1. Readable but not great
            // 2. No compile time checking, runtime error
            //Console.WriteLine("{0}\t{1}\t{2}\t{3}", title, rating, duration, isClassic);

            string title = null;
            object rating = null;
            object duration = null;
            object isClassic = null;
            //2. String.Format
            var message = String.Format("{0}\t{1}\t{2}\t{3}", title, rating, duration, isClassic);
            //Console.WriteLine(message);

            //3. String concatenation
            //   A: Programmatically build it
            //   A: Somewhat readable
            //   D: Harder to read as it gets longer
            //   D: Bad performance
            //var message = title + "\t" + rating + "\t" + duration + "\t" + isClassic;
            Console.WriteLine(message);

            //4. String builder
            var builder = new StringBuilder();
            builder.Append(title);
            builder.Append("\t");
            builder.Append(rating);
            builder.Append("\t");
            builder.Append(duration);
            builder.Append("\t");
            builder.Append("isClassic");
            builder.Append("\t");
            message = builder.ToString();
            Console.WriteLine(message);

            //5. String Joining
            message = String.Join("\t", title, rating, duration, isClassic);

            //Conditional operator     C ? T : 
            // if (C) return T else return F

            //6. String interpolation - $
            //   A. Use expressions instead of ordinals
            //   A. More readable
            //   A. Compile time checked
            //   D. Compile time only and against literals
            var classicIndicator = (bool)isClassic ? "Yes" : "No";
            if ((bool)isClassic)
                classicIndicator = "Yes";
            else
                classicIndicator = "No";
            //var message = $"{title}\t\t{rating}\t{duration}\t\t{isClassic}";
            Console.WriteLine(message);

            string description = null;
            //Write description if available
            if (!String.IsNullOrEmpty(description))
                Console.WriteLine(description);

            Console.WriteLine("");

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

        /*static void FunWithStrings()
        {
            //5 characters in it, takes up 10 bytes
            // C++ difference: no NULL

            // Escape sequence begins with \ and is followed by generally 1 character, only works in literals
            //   \n - newline
            //   \t - tab
            //   \" - "
            //   \' - ' (char literal)
            //   \\ - \ 
            //   \xHH - hex equivalent \x0A 
            var name = "Bob";  //Compiler warning - Bobc            

            //File paths - always escape sequences
            var filePath2 = @"C:\Temp\test.pdf";  //Verbatim string

            //TODO: null and empty string//5 characters in it, takes up 10 bytes
            // C++ difference: no NULL

            //TODO: null and empty string
            var emptyString = "";

            var emptyString2 = String.Empty;  // ""
            var areEqual = emptyString == emptyString2;  //True

            //Checking for empty string
            // 1. comparison
            var isEmpty1 = emptyString == "";
            var isEmpty1_Part2 = emptyString == String.Empty;

            // 2. Length
            var isEmpty2 = emptyString.Length == 0;

            // 3. String.Compare
            var isEmpty3 = String.Compare(emptyString, "") == 0;
            // 3. String.Compare => int
            //      < 0     left < right
            //      == 0    left == right
            //      > 0     left > right

            // 4. Preferred IsNullOrEmpty => boolean
            var isEmpty4 = String.IsNullOrEmpty(emptyString);

            // Can be null
            string nullString = null;
            var areEqual3 = emptyString == nullString;  //false
            //var willCrash = nullString.Length == 0;     //Will crash
            var willNotBeEqual = String.Compare(emptyString, null) == 0;
            //var isEmpty5 = nullString != null && nullString != "";  //Inefficient

            //Converting to string E.ToString()
            var asString = emptyString.ToString();
            asString = 10.ToString();  // "10"
            asString = (50 * 3).ToString(); // "150

            // Common Functions -> E.func()

            //Comparison
            // 1. Relational operator == != ::= case sensitive
            // 2. String.Compare
            var relationalCompare = String.Compare("Hello", "hello") == 0;  //Case sensitive
            var caseInsensitiveCompare = String.Compare("Hello", "hello", true) == 0;  //Case insensitive
            //locale - Windows cultural settings
            var ordinalCompare = String.Compare("Hello", "hello", StringComparison.OrdinalIgnoreCase) == 0;  //Case insensitive, ordinal (keys, paths)

            // 3. Case conversion - PLEASE DON'T DO THIS
            var toUpper = "Hello".ToUpper();  // HELLO ToUpper() => string
            var toLower = "Hello".ToLower();  // hello ToLower() => string


            // trim and padding
            name = "   Bob   ";

            name = name.Trim();  //Removes leading and trailing whitespace (newlines, tabs, spaces) - "Bob"
                                 //TrimStart, TrimEnd         }
            filePath2 = filePath2.TrimEnd('\\');

            //PadLeft(#) PadRight(#) - pads to width, never truncates
            var paddedName = name.PadLeft(10);  // "       Bob"

            // String formatting
            // 1. Format argument overloads WriteLine(string, [args])
            // 2. String.Format 
            // 3. String concatenation
            //   A: Programmatically build it
            //   A: Somewhat readable
            //   D: Harder to read as it gets longer
            //   D: Bad performance            
            // 4. String builder
            //   A: Efficient on memory
            //   A: Conditional formatting
            //   D: Longer
            //   D: Harder to read
            // 5. Joining strings
            // 6. String interpolation

            // Contains ( string ) => boolean
            // Index/IndexOfAny ( string ) => index
            // StartsWith / EndsWith

            var leftPath = @"C:\temp";
            var rightPath = "folderA\file.txt";

            var endsWithSlash = leftPath.EndsWith(@"\");
            var startsWithSlash = rightPath.StartsWith(@"\");

        }

        //private static void FunWithVariables ()
        //{
            //Definition before usage
            //value;

            //Declares hours of type int with initial value 10 (initializer expression)

            //Definitely assigned rule
            //int value;
            //value = 10;
            //int calculatedValue = value * 10;

            //When needed
            //int x = 10;
            //int y = 20;
            //int z = x * y;

            // double rate1 = x * 0.5;


        //}

        //Function definition - declaration + implementation
        // [modifiers] T id ([parameters) { S* }
        //Function signature - [return-type] name, parameter types
        //static void FunWithTypes ()
        //{
            //Variable - named memory location where you can read and write a value; name, type and value
            //
            //Literal - value that can be read, fixed at compilation; type and value

            //Body

            //Primitive - type implicitly known by the language

            //Integral - whole numbers
            // Signed 
            //   sbyte - 1 byte -128 to 127
            //   short - 2 bytes +-32K
            //   int   - 4 bytes, +-2 billion - DEFAULT  
            //   long  - 8 bytes, really big  - larger size
            // Unsigned
            //   byte - 1 byte 0 to 255
            //   ushort - 2 bytes 0 to 64K
            //   uint   - 4 bytes, 0 to 4 billion
            //   ulong  - 8 bytes, 0 to really big
            // Literals
            //   10, 20, 30 => int
            //   150L => long
            //   0xFFUL => ulong  or 0xFFU => uint
            //   decimal = 0-9, hex = 0-9A-F, binary = 0-1 (0b101010)
            //   32_766, 3_2_7_6_6, 0b1011_1010

            //Variable declaration - T id [ = E ];
            //int hours = 10;
            //int ratio = hours * 40;
            //Floating point types - real numbers IEEE
            //  float - 4 bytes, +-E38, 7 to 9 precision 123.456789
            //  double - 8 bytes, +-E308, 15 to 17 precision - DEFAULT
            //  decimal - 16 bytes, precise => currency
            // Literals
            //    123.45F; => float
            //     123.45M => decimal

            //boolean
            // bool - 1 byte, true or false (0) 
            //bool success = 1;  //ERROR
            //int isPassing = 1;  //BAD

            //Textual
            //  char - 2 byte, '\0' to '\uFFFF'
            //  string - 0+ bytes
            //  'X' => char
            //  "abcf" => string literal

        */}
 }


