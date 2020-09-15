using System;
using System.Collections.Generic;


namespace Calculator
{
    public class Calculator
    {
        public static void Add()
        {
            Start1:
            Console.Write("Please enter the first number: ");
            string string1 = Console.ReadLine();
            int int1;
            bool success1 = Int32.TryParse(string1, out int1);
            if (success1)
            {
                int1 = Int32.Parse(string1);
            }
            else
            {
                Console.WriteLine($@"Invalid Selection, ""{string1}"" is not a number");
                Console.WriteLine();
                goto Start1;
            }
            Start2:
            Console.Write("Please enter the second number: ");
            string string2 = Console.ReadLine();
            int int2;
            bool success2 = Int32.TryParse(string2, out int2);
            if (success2)
            {
                int2 = Int32.Parse(string2);
            }
            else
            {
                Console.WriteLine(@$"Invalid Selection, ""{string2}"" is not a number");
                Console.WriteLine();
                goto Start2;
            }
            int answer = int1 + int2;
            Console.WriteLine("___________________________________________________");
            Console.WriteLine();
            Console.WriteLine($"The result of adding {int1} and {int2} is {answer}");
            Console.WriteLine();
            Console.Write("Press any key to continue... ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Subtract()
        {
        Start1:
            Console.Write("Please enter the first number: ");
            string string1 = Console.ReadLine();
            int int1;
            bool success1 = Int32.TryParse(string1, out int1);
            if (success1)
            {
                int1 = Int32.Parse(string1);
            }
            else
            {
                Console.WriteLine($@"Invalid Selection, ""{string1}"" is not a number");
                Console.WriteLine();
                goto Start1;
            }
        Start2:
            Console.Write("Please enter the second number: ");
            string string2 = Console.ReadLine();
            int int2;
            bool success2 = Int32.TryParse(string2, out int2);
            if (success2)
            {
                int2 = Int32.Parse(string2);
            }
            else
            {
                Console.WriteLine(@$"Invalid Selection, ""{string2}"" is not a number");
                Console.WriteLine();
                goto Start2;
            }
            int answer = int1 - int2;
            Console.WriteLine("___________________________________________________");
            Console.WriteLine();
            Console.WriteLine($"The result of subtracting {int1} and {int2} is {answer}");
            Console.WriteLine();
            Console.Write("Press any key to continue... ");
            Console.ReadKey();
            Console.Clear();
        }
        public static void Multiply()
        {
        Start1:
            Console.Write("Please enter the first number: ");
            string string1 = Console.ReadLine();
            int int1;
            bool success1 = Int32.TryParse(string1, out int1);
            if (success1)
            {
                int1 = Int32.Parse(string1);
            }
            else
            {
                Console.WriteLine($@"Invalid Selection, ""{string1}"" is not a number");
                Console.WriteLine();
                goto Start1;
            }
        Start2:
            Console.Write("Please enter the second number: ");
            string string2 = Console.ReadLine();
            int int2;
            bool success2 = Int32.TryParse(string2, out int2);
            if (success2)
            {
                int2 = Int32.Parse(string2);
            }
            else
            {
                Console.WriteLine(@$"Invalid Selection, ""{string2}"" is not a number");
                Console.WriteLine();
                goto Start2;
            }
            int answer = int1 * int2;
            Console.WriteLine("___________________________________________________");
            Console.WriteLine();
            Console.WriteLine($"The result of multiplying {int1} and {int2} is {answer}");
            Console.WriteLine();
            Console.Write("Press any key to continue... ");
            Console.ReadKey();
            Console.Clear();
        }

        public static void Divide()
        {
        Start1:
            Console.Write("Please enter the first number: ");
            string string1 = Console.ReadLine();
            int int1;
            bool success1 = Int32.TryParse(string1, out int1);
            if (success1)
            {
                int1 = Int32.Parse(string1);
            }
            else
            {
                Console.WriteLine($@"Invalid Selection, ""{string1}"" is not a number");
                Console.WriteLine();
                goto Start1;
            }
        Start2:
            Console.Write("Please enter the second number: ");
            string string2 = Console.ReadLine();
            int int2;
            bool success2 = Int32.TryParse(string2, out int2);
            if (success2)
            {
                int2 = Int32.Parse(string2);
            }
            else
            {
                Console.WriteLine(@$"Invalid Selection, ""{string2}"" is not a number");
                Console.WriteLine();
                goto Start2;
            }
            int answer = int1 / int2;
            Console.WriteLine("___________________________________________________");
            Console.WriteLine();
            Console.WriteLine($"The result of dividing {int1} and {int2} is {answer}");
            Console.WriteLine();
            Console.Write("Press any key to continue... ");
            Console.ReadKey();
            Console.Clear();
        }
    }
}
