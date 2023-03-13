using System;
using System.Threading.Channels;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace HW2
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //print the sum of two numbers
            var a = 10;
            var b = 20;
            var c = a + b;
            Console.WriteLine($"{a} + {b} = {c}");

            //print the result of dividing two numbers
            c = b / a;
            Console.WriteLine($"{b} / {a} = {c}");

            //print the result of the specified operations 
            Console.WriteLine($"-1 + 4*6 = {-1 + 4 * 6}");

            Console.WriteLine($"(35 + 5) % 7 = {(35 + 5) % 7}");

            var result = 14 + (double)-4 * 6 / 11;
            Console.WriteLine($"14 + -4 * 6 / 11 = {result:F2}");

            result = 2 + (double)15 / 6 * 1 - 7 % 2;
            Console.WriteLine($"2 + 15 / 6 * 1 - 7 % 2 = {result:F2}");

            //swap two numbers 

            //a)
            var firstNumber = 5;
            var secondNumber = 6;
            Console.WriteLine($"firstNumber: {firstNumber}");
            Console.WriteLine($"secondNumber: {secondNumber}");
            var temp = firstNumber;
            firstNumber = secondNumber;
            secondNumber = temp;
            Console.WriteLine($"firstNumber: {firstNumber}");
            Console.WriteLine($"secondNumber: {secondNumber}");

            //b)
            firstNumber = 5;
             secondNumber = 6;
            Console.WriteLine($"firstNumber: {firstNumber}");
            Console.WriteLine($"secondNumber: {secondNumber}");
            (firstNumber, secondNumber) = (secondNumber, firstNumber);
            Console.WriteLine($"firstNumber: {firstNumber}");
            Console.WriteLine($"secondNumber: {secondNumber}");


            //print the output of multiplication of three numbers which will be entered by the user 
            Console.WriteLine("Input the first number to multiply:");
            var num1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number to multiply:");
            var num2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input the second number to multiply:");
            var num3 = int.Parse(Console.ReadLine()); 

            Console.WriteLine($"Output of multiplication of three numbers: {num1 * num2 * num3}");
        }
    }
}