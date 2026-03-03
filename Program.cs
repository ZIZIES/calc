using System;
using System.Collections.Generic;
using System.ComponentModel;
namespace calc
{
    public class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("hey, welcome to the calculator!");
            Console.WriteLine("what will the first number be?");
            
            string? stringFirstNumber = Console.ReadLine();
            double FirstNumber = double.Parse(stringFirstNumber!);
            Console.WriteLine("what's the operation(+,-,x,/)?");
            string? operation = Console.ReadLine();
            Console.WriteLine("alright, and what will be the last number?");
            string? stringSecondNumber = Console.ReadLine();
            double SecondNumber = double.Parse(stringSecondNumber!);
    
            string output = "";
            if (operation == "+")
            {
                output = (FirstNumber + SecondNumber).ToString();
            }
            else if (operation == "-")
            {
                output = (FirstNumber - SecondNumber).ToString();
            }
            else if (operation == "x")
            {
                output = (FirstNumber * SecondNumber).ToString();
            }
            else if (operation == "/")
            {
                output = (FirstNumber / SecondNumber).ToString();
            }
            Console.WriteLine($"the answer is {output}!");
            Console.WriteLine($"thank you for using my calc");
            Console.WriteLine("press any key to close...");
            Console.ReadKey();
        }
    }
}