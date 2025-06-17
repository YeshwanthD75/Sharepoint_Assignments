// See https://aka.ms/new-console-template for more information
using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.Metadata;
using System.Text;
using System.Threading.Tasks;


namespace firstprojcsharp
{
    public class Excan
    {
        public string fname;
    }
    class Program
    {
        static void Main(string[] args)
        { //hello World
            Console.WriteLine("***** Basic Console I/O *****"); //cout
            //GetUserData();
            //FormatNumericalData();
            //LocalVarDeclarations();
            //NewingDataTypes();
            //ObjectFunctionality();
            //DataTypeFunctionality();
            //BasicStringFunctionality();
            //StringConcatenation();
            //StringsAreImmutable();
            //EscapeChars();
            //FunWithStringBuilder();
            //StringInterpolation();

            //ForAndForEachLoop();
            //VarInForeachLoop();
            //ExecuteWhileLoop();
            //ExecuteDoWhileLoop();
            //ExecuteIfElse();
            //ExecuteSwitch();
            //ExecuteSwitchOnString();
            //SwitchOnEnumExample();

            //DeclareImplicitVars();
            //QueryOverInts();

            SimpleArrays();
            ArrayInitialization();
            DeclareImplicitArrays();
            ArrayOfObjects();
            RectMultidimensionalArray();

            JaggedMultidimensionalArray();
            PassAndReceiveArrays();
            SystemArrayFunctionality();
            Console.ReadLine();
        }
        #region Get user data
        private static void GetUserData()
        {
            //Get name and age
            Console.Write("Please Enter Your Name: "); //cout
            string userName = Console.ReadLine(); //cin
            Console.Write("Please Enter Your Age: ");
            string userAge = Console.ReadLine();
            //Change echo color, just for fun.
            ConsoleColor prevbackColor = Console.BackgroundColor; //storing the default color
            Console.BackgroundColor = ConsoleColor.Green; //new colour
            ConsoleColor prevColor = Console.ForegroundColor;
            Console.ForegroundColor = ConsoleColor.Red; //new colour

            // Echo to console
            Console.WriteLine("Hello {0}! You are {1} years old.", userName, userAge);
            //cout<<"Hello"<<username<<"Age"<<userAge;

            // Restore previous color
            Console.ForegroundColor = prevColor; //White
            Console.BackgroundColor = prevbackColor; //black
            Console.WriteLine("Thank you!");
        }
        #endregion

        #region Format numerical data
        //Now make use of some format tags
        private static void FormatNumericalData()
        {
            Console.WriteLine("The value of 99999 in various formats:  ");
            Console.WriteLine("c format: {0:c}", 99999);
            Console.WriteLine("d9 format: {0:d9}", 99999);
            Console.WriteLine("f3 format: {0:f3}", 99999);
            Console.WriteLine("n format: {0:n}", 99999);
            // Notice that upper- pr lowercasing for hex
            //determines if letters are upper- or lowercase.
            Console.WriteLine("E format: {0:E}", 99999);
            Console.WriteLine("e format: {0:e}", 99999);
            Console.WriteLine("X format: {0:X}", 99999);
            Console.WriteLine("e format: {0:x}", 99999);
            /*
             Character

            Meaning in Life

            C or c	Used to format currency. By default, the flag will prefix the local cultural symbol (a dollar sign [$] for U.S. English).

            D or d	Used to format decimal numbers. This flag may also specify the minimum number of digits used to pad the  value.

            E or e	Used for exponential notation. Casing controls whether the exponential constant is uppercase (E) or lowercase (e).

            F or f	Used for fixed-point formatting. This flag may also  specify the minimum number of digits used to pad the  value.

            G or g	Stands for general. This character can be used to  format a number to fixed or exponential format.
            N or n	Used for basic numerical formatting (with commas).

            X or x	Used for hexadecimal formatting. If you use an uppercase X, your hex format will also contain uppercase characters.
            */
        }
        #endregion

        #region Datatypeexamples
        #region Local variable declarations
        static void LocalVarDeclarations()
        {
            Console.WriteLine("=> Data Declarations:");
            // Local variables are declared and initialized as follows:
            // dataType varName initialValue;
            int myInt = 0;

            string myString;
            myString = "This is my character data";

            // Declare 3 bools on a single line.
            bool b1 = true, b2 = false, b3 = b1;

            // Very verbose manner in which to declare a bool.
            System.Boolean b4 = false;

            Console.WriteLine("Your data: {0}, {1}, {2}, {3}, {4}, {5}",
                myInt, myString, b1, b2, b3, b4);

            //"Your data: (0), (1), (2), (3}, {4}, {5}"
            //           myInt, myString, b1, b2, b3, b4
           
        }

        static void NewingDataTypes()
        {
                Console.WriteLine("=> Using new to create variables:");
                bool b = new bool();             // Set to false.
                int i = new int();               // Set to 0
                double d = new double();         // Set to 0.
                DateTime dt = new DateTime();    // Set to 1/1/0001 12:00:00 AM
                Console.WriteLine("{0}, {1}, {2}, {3}", b, i, d, dt);
                Console.WriteLine();
        }
        #endregion

        #region Test Object functionality
        static void ObjectFunctionality()
        {
            Console.WriteLine("=> System.Object Functionality: ");
            //A C# int is really a shorthand for System.Int32
            //Which inherits the following members from System.Object

            int x = 12;
            Console.WriteLine("X variable contains {0}", x);
            Console.WriteLine("12.Equals(23) = {0}", 12.Equals(23));
            Console.WriteLine("12.ToString() = {0}", 12.ToString());
            Console.WriteLine("12.GetType() = {0}", 12.GetType());
            Console.WriteLine();
        }
        #endregion

        #region Test data type functionality
        static void DataTypeFunctionality()
        {
            double a = -10;
            double b = 0;
            double ans = a / b;

            Console.WriteLine(ans);
            Console.WriteLine("=> Data Type Functionality:");
            Console.WriteLine("Max of int: {0}", int.MaxValue);
            Console.WriteLine("Min of int: {0}", int.MinValue);
            Console.WriteLine("Max of double: {0}", double.MaxValue);
            Console.WriteLine("Min of double: {0}", double.MinValue);
            Console.WriteLine("double.Epsilon: {0}", double.Epsilon); //nearest to zero
            Console.WriteLine("double.PositiveInfinity: {0}", 
                double.PositiveInfinity);
            Console.WriteLine("double.NegativeInfinity: {0}",
                double.NegativeInfinity);
            Console.WriteLine("bool.FalseString: {0}",bool.FalseString);
            Console.WriteLine("bool.TrueString: {0}", bool.TrueString);
            Console.WriteLine("bool.sizeof: {0}", sizeof(bool));
            Console.WriteLine();
        }
        #endregion

        #region String basics
        static void BasicStringFunctionality()
        {
            Console.WriteLine("=> Basic String Functionality: ");
            string firstName = "Freddy";
            Console.WriteLine("Value of firstName: {0}", firstName);
            Console.WriteLine("firstName has {0} characters.", firstName.Length);
            Console.WriteLine("firstName in uppercase: {0}", firstName.ToUpper());
            Console.WriteLine("firstName in lowercase: {0}", firstName.ToLower());
            Console.WriteLine("firstName contains the letter y?: {0}", firstName.Contains("y"));
            Console.WriteLine("New first name: {0}", firstName.Replace("dy", ""));
            Console.WriteLine();
        }
        #endregion

        #region Concatenation
        static void StringConcatenation()
        {
            Console.WriteLine("=> String concatenation:");
            string s1 = "Programming the ";
            string s2 = "PsychoDrill (PTP)";
            string s3 = s1 + s2;
            Console.WriteLine(s2);
            Console.WriteLine(s3);
            Console.WriteLine();
        }
        #endregion

        #region Immutable test
        static void StringsAreImmutable()
        {
            // Set initial string value..
            string s1 = "This is my string.";
            Console.WriteLine("s1 = {0}", s1);
            s1 = s1 + "some more addition to string ";
            Console.WriteLine("s1 = {0}", s1);

            // Uppercase s1?
            string upperString = s1.ToUpper();
            Console.WriteLine("upperString = {0}", upperString);

            // Nope! s1 is in the same format!
            Console.WriteLine("s1 = {0}", s1);

            string s2 = "My other string";
            s2 = "New string value";
            Console.WriteLine(s2);
        }
        #endregion

        #region Escape Chars
        static void EscapeChars()
        {
            Console.WriteLine("=> Escape characters:\a");
            string strWithTabs = "Model\tColor\tSpeed\tPet Name\a ";
            Console.WriteLine(strWithTabs);

            Console.WriteLine("Everyone loves \"Hello World\"\a ");
            Console.WriteLine("C:\\MyApp\\bin\\Debug\a ");
            // Adds a total of 4 blank lines (then beep again!).
            Console.WriteLine("All finished.\n\n\n\a ");
            Console.WriteLine();

            // The following string is printed verbatim
            // thus, all escape characters are displayed.
            Console.WriteLine(@"C:\MyApp\bin\Debug");

            // White space is preserved with verbatim strings.
            string myLongString = @"This is a very
                 very
                      very
                           long string";
            Console.WriteLine(myLongString);
            Console.WriteLine();
            Console.WriteLine(@"Cerebus said ""Darrr! Pret-ty sun-sets""");
        }
        #endregion

        #region StringBuilder
        static void FunWithStringBuilder()
        {
            Console.WriteLine("=> Using the StringBuilder:");

            // Make a StringBuilder with an initial size of 256.
            StringBuilder sb = new StringBuilder("**** Fantastic Games ****", 256);

            sb.Append("\n");
            sb.AppendLine("Half Life");
            sb.AppendLine("Beyond Good and Evil");
            sb.AppendLine("Deus Ex 2");
            sb.AppendLine("System Shock");
            Console.WriteLine(sb.ToString());

            sb.Replace("2", "Invisible War");
            Console.WriteLine(sb.ToString());
            Console.WriteLine("sb has {0} chars.", sb.Length);
            // sb.Console.WriteLine();
        }
        #endregion

        #region String interpolation
        static void StringInterpolation()
        {
            // Some local variables we will plug into our larger string
            int age = 14;
            string name = "Sweety";

            // Using curly bracket syntax.
            string greeting = string.Format("\tHello {0} you are {1} years old.", name.ToUpper(), age);
            Console.WriteLine(greeting);

            // Using string interpolation
            string greeting2 = $"\tHello {name.ToUpper()} you are {age} years old.";
            Console.WriteLine(greeting2);
        }
        #endregion

        #region For / foreach loops
        // A basic for loop.
        static void ForAndForEachLoop()
        {
            // Note! "i" is only visible within the scope of the for loop.
            for (int i = 0; i < 4; i++)//for(;;)
            {
                Console.WriteLine("Number is: {0} ", i);
            }
            // "i" is not visible here.
            Console.WriteLine();
            Excan[] ex = new Excan[4];
            ex[0] = new Excan();
            ex[1] = new Excan(); ex[2] = new Excan(); ex[3] = new Excan();
            ex[0].fname = "Seema";
            ex[1].fname = "Teema";
            ex[2].fname = "Leema";
            ex[3].fname = "Neema";

            for (int x = 0; x < 4; x++)
            {
                Console.WriteLine(ex[x].fname);
            }

            Console.WriteLine();
            foreach (Excan c in ex)
            { Console.WriteLine(c.fname); }


            string[] carTypes = { "Ford", "BMW", "Yugo", "Honda" };
            foreach (string c in carTypes)
            { Console.WriteLine(c); }
            Console.WriteLine();

            int[] myInts = { 10, 20, 30, 40 };
            foreach (int i in myInts)
            { Console.WriteLine(i); }

            Console.WriteLine();
        }
        #endregion

        #region Var keyword in foreach
        static void VarInForeachLoop()
        {
            int[] myInts = { 10, 20, 30, 40 };

            // Use "var" in a standard foreach loop.
            foreach (var item in myInts)
            {
                Console.WriteLine("Item value: {0}", item);
            }

            Console.WriteLine();
        }
        #endregion

        #region while loop
        static void ExecuteWhileLoop()
        {
            string userIsDone = "";

            // Test on a lower-class copy of the string.
            while (userIsDone.ToLower() != "yes")
            {
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
                Console.WriteLine("In while loop");
            }
            Console.WriteLine();
        }
        #endregion

        #region do/while loop
        static void ExecuteDoWhileLoop()
        {
            string userIsDone = "";

            do
            {
                Console.WriteLine("In do/while loop");
                Console.Write("Are you done? [yes] [no]: ");
                userIsDone = Console.ReadLine();
            } while (userIsDone.ToLower() != "yes"); // Note the semicolon!

            Console.WriteLine();
        }
        #endregion

        #region If/else
        static void ExecuteIfElse()
        {
            // This is illegal, given that Length returns an int, not a bool.
            string stringData = "My textual data";
            if (stringData.Length > 0)
            { Console.WriteLine("string is greater than 0 characters"); }
            else
            { Console.WriteLine("string is not greater than 0 characters"); }
            Console.WriteLine("Hello");
        }
        #endregion

        #region switch statements
        // Switch on a numerical value.
        static void ExecuteSwitch()
        {
            Console.WriteLine("1 [C#], 2 [VB]");
            Console.Write("Please pick your language preference: ");

            string langChoice = Console.ReadLine();//in.nextInt()
            int n = int.Parse(langChoice);

            switch (n)
            {
                case 1:
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case 2:
                    Console.WriteLine("VB: OOP, multithreading, and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }
            Console.WriteLine();
        }

        static void ExecuteSwitchOnString()
        {
            Console.WriteLine("C# or VB");
            Console.Write("Please pick your language preference: ");

            string langChoice = Console.ReadLine();
            switch (langChoice)
            {
                case "C#":
                    Console.WriteLine("Good choice, C# is a fine language.");
                    break;
                case "VB":
                    Console.WriteLine("VB: OOP, multithreading and more!");
                    break;
                default:
                    Console.WriteLine("Well...good luck with that!");
                    break;
            }

            Console.WriteLine();
        }

        static void SwitchOnEnumExample()
        {
            Console.Write("Enter your favorite day of the week: ");
            DayOfWeek favDay;
            try
            {
                favDay = (DayOfWeek)Enum.Parse(typeof(DayOfWeek), Console.ReadLine());
            }
            catch (Exception)
            {
                Console.WriteLine("Bad input!");
                return;
            }
            switch (favDay)
            {
                case DayOfWeek.Friday:
                    Console.WriteLine("Yes, Friday rules!");
                    break;
                case DayOfWeek.Monday:
                    Console.WriteLine("Another day, another dollar");
                    break;
                case DayOfWeek.Saturday:
                    Console.WriteLine("Great day indeed.");
                    break;
                case DayOfWeek.Sunday:
                    Console.WriteLine("Football!!");
                    break;
                case DayOfWeek.Thursday:
                    Console.WriteLine("Almost Friday...");
                    break;
                case DayOfWeek.Tuesday:
                    Console.WriteLine("At least it is not Monday");
                    break;
                case DayOfWeek.Wednesday:
                    Console.WriteLine("A fine day.");
                    break;
            }
            Console.WriteLine();
        }
        #endregion

        #region Implicit data typing
        static void DeclareImplicitVars()
        {
            // Implicitly typed local variables.
            var myInt = 0;
            var myBool = true;
            var myString = "Time, marches on...";

            // Print out the underlying type.
            Console.WriteLine("myInt is a: {0}", myInt.GetType().Name);
            Console.WriteLine("myBool is a: {0}", myBool.GetType().Name);
            Console.WriteLine("myString is a: {0}", myString.GetType().Name);
        }
        #endregion

        #region LINQ example
        static void QueryOverInts()
        {
            int[] numbers = { 10, 20, 30, 40, 1, 2, 3, 8 };
            var subset = from i in numbers where i < 10 select i; //select * From numbers where values<10

            Console.Write("Values in subset: ");
            foreach (var i in subset)
            {
                Console.Write("{0} ", i);
            }
            Console.WriteLine();

            // Hmm...what type is subset?
            Console.WriteLine("subset is a: {0}", subset.GetType().Name);
            Console.WriteLine("subset is defined in: {0}", subset.GetType().Namespace);
        }
        #endregion

        #region Simple Array
        static void SimpleArrays()
        {
            Console.WriteLine("=> Simple Array Creation.");
            // Create and fill an array of 3 Integers
            int[] myInts = new int[3];
            myInts[0] = 100;
            myInts[1] = 200;
            myInts[2] = 300;

            // Now print each value.
            foreach (int i in myInts)
                Console.WriteLine(i);
            Console.WriteLine();
        }
        #endregion

        #region Array Init Syntax
        static void ArrayInitialization()
        {
            Console.WriteLine("=> Array Initialization.");

            // Array initialization syntax using the new keyword.
            string[] stringArray = new string[] { "one", "two", "three" };
            Console.WriteLine("stringArray has {0} elements", stringArray.Length);

            // Array initialization syntax without using the new keyword.
            bool[] boolArray = { false, false, true };
            Console.WriteLine("boolArray has {0} elements", boolArray.Length);

            // Array initialization with new keyword and size.
            int[] intArray = new int[4] { 20, 22, 23, 0 };
            Console.WriteLine("intArray has {0} elements", intArray.Length);
            Console.WriteLine();
        }
        #endregion

        #region Var keyword with arrays
        static void DeclareImplicitArrays()
        {
            Console.WriteLine("=> Implicit Array Initialization.");

            // a is really int[].
            var a = new[] { 1, 10, 100, 1000 };
            Console.WriteLine("a is a: {0}", a.ToString());

            // b is really double[].
            var b = new[] { 1, 1.5, 2, 2.5 };
            Console.WriteLine("b is a: {0}", b.ToString());

            // c is really string[].
            var c = new[] { "hello", null, "world" };
            Console.WriteLine("c is a: {0}", c.ToString());
            Console.WriteLine();
        }
        #endregion

        #region Array of objects
        static void ArrayOfObjects()
        {
            Console.WriteLine("=> Array of Objects.");

            // An array of objects can be anything at all.
            object[] myObjects = new object[4];
            myObjects[0] = 10;
            myObjects[1] = false;
            myObjects[2] = new DateTime(1969, 3, 24);
            myObjects[3] = "Form & Void";

            foreach (object obj in myObjects)
            {
                // Print the type and value for each item in array.
                Console.WriteLine("Type: {0}, Value: {1}, tostring output: {2}", obj.GetType(), obj, obj.ToString());
            }
            Console.WriteLine(myObjects[0].ToString());

            Console.WriteLine();
        }
        #endregion

        #region MD arrays
        static void RectMultidimensionalArray()
        {
            Console.WriteLine("=> Rectangular multidimensional array:\n");
            // A rectangular MD array.
            int[,] myMatrix;
            myMatrix = new int[3, 4];

            // Populate (3 * 4) array.
            for (int i = 0; i < 3; i++)
                for (int j = 0; j < 4; j++)
                    myMatrix[i, j] = i * j;

            // Print (3 * 4) array.
            for (int i = 0; i < 3; i++)
            {
                for (int j = 0; j < 4; j++)
                    Console.Write(myMatrix[i, j] + "\t");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        static void JaggedMultidimensionalArray()
        {
            Console.WriteLine("=> Jagged multidimensional array:\n");
            // A jagged MD array (i.e., an array of arrays).
            // Here we have an array of 5 different arrays.
            int[][] myJagArray = new int[5][];

            // Create the jagged array.
            for (int i = 0; i < myJagArray.Length; i++)
                myJagArray[i] = new int[i + 7];

            // Print each row (remember, each element is defaulted to zero!)
            for (int i = 0; i < 5; i++)
            {
                for (int j = 0; j < myJagArray[i].Length; j++)
                    Console.Write(myJagArray[i][j] + " ");
                Console.WriteLine();
            }
            Console.WriteLine();
        }

        #endregion

        #region Arrays as params and return values
        static void PrintArray(int[] myInts)
        {
            for (int i = 0; i < myInts.Length; i++)
                Console.WriteLine("Item {0} is {1}", i, myInts[i]);
        }

        static string[] GetStringArray()
        {
            string[] theStrings = { "Hello", "from", "GetStringArray" };
            return theStrings;
        }

        static void PassAndReceiveArrays()
        {
            Console.WriteLine("=> Arrays as params and return values.");
            // Pass array as parameter.
            int[] ages = { 20, 22, 23, 0 };
            PrintArray(ages);

            // Get array as return value.
            string[] strs = GetStringArray();
            foreach (string s in strs)
                Console.WriteLine(s);

            Console.WriteLine();
        }
        #endregion

        #region System.Array functionality
        static void SystemArrayFunctionality()
        {
            Console.WriteLine("=> Working with System.Array.");
            // Initialize items at startup.
            string[] gothicBands = { "Tones on Tail", "Bauhaus", "Sisters of Mercy" };

            // Print out names in declared order.
            Console.WriteLine(" -> Here is the array:");
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // Reverse them...
            Array.Reverse(gothicBands);
            Console.WriteLine(" -> The reversed array");
            // ... and print them.
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine("\n");

            // Clear out all but the final member.
            Console.WriteLine(" -> Cleared out all but one...");
            Array.Clear(gothicBands, 1, 2);
            for (int i = 0; i < gothicBands.Length; i++)
            {
                // Print a name
                Console.Write(gothicBands[i] + ", ");
            }
            Console.WriteLine();
        }
        #endregion


        #endregion
    }
}


        