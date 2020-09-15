using System;
using System.Collections.Generic;

namespace Calculator
{
    public class CalculatorManager
    {
  
        public CalculatorManager Execute()
        {
            Console.WriteLine(" Welcome to Calculatron 3000");
            Console.WriteLine(" 1) Add two numbers");
            Console.WriteLine(" 2) Subtract two numbers");
            Console.WriteLine(" 3) Multiply two numbers");
            Console.WriteLine(" 4) Divide two numbers");
            Console.WriteLine(" 0) Exit");

            Console.Write("> ");
            string choice = Console.ReadLine();

            switch (choice)
            {
                case "1":
                    Calculator.Add();
                    return this;

                case "2":
                    Calculator.Subtract();
                    return this;

                case "3":
                    Calculator.Multiply();
                    return this;

                case "4":
                    Calculator.Divide();
                    return this;

                case "0":
                    Console.WriteLine("GoodBye");
                    return null;
                default:
                    Console.WriteLine("Invalid Selection");
                    return this;
            }
        }
    }
}
