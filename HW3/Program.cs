using System;

namespace HW3
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // - Write a C# program to check two given integers and return true if one is negative and one is positive.
            Console.WriteLine("- Write a C# program to check two given integers and return true if one is negative and one is positive.");
            Console.WriteLine();

            #region Solution_1 

            Console.WriteLine("Solution 1");

            Console.WriteLine("Input first integer:");

            var firstNumber1 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer:");

            var secondNumber1 = int.Parse(Console.ReadLine());

            var result1 = ((firstNumber1 ^ secondNumber1) < 0);

            Console.WriteLine(result1);

            #endregion


            #region Solution_2

            Console.WriteLine();

            Console.WriteLine("Solution 2");

            Console.WriteLine("Input first integer:");

            var firstNumber2 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer:");

            var secondNumber2 = int.Parse(Console.ReadLine());

            var result2 = false;

            if ((firstNumber2 > 0 && secondNumber2 < 0) || (firstNumber2 < 0 && secondNumber2 > 0))
            {
                result2 = true;
            }

            Console.WriteLine(result2);

            #endregion


            #region Solution_3

            Console.WriteLine();

            Console.WriteLine("Solution 3");

            Console.WriteLine("Input first integer:");

            var firstNumber3 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer:");

            var secondNumber3 = int.Parse(Console.ReadLine());

            var result3 = false;

            switch (firstNumber3)
            {
                case > 0 when secondNumber3 < 0:
                case < 0 when secondNumber3 > 0:
                    result3 = true;
                    break;
            }
            Console.WriteLine(result3);

            #endregion


            #region Solution_4

            Console.WriteLine();

            Console.WriteLine("Solution 4");

            Console.WriteLine("Input first integer:");

            var firstNumber4 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer:");

            var secondNumber4 = int.Parse(Console.ReadLine());

            Console.WriteLine((firstNumber4 * secondNumber4) < 0);

            #endregion


            #region Solution_5 

            Console.WriteLine();

            Console.WriteLine("Solution 5");

            Console.WriteLine("Input first integer:");

            var firstNumber5 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer:");

            var secondNumber5 = int.Parse(Console.ReadLine());

            var result5 = (firstNumber5 > 0 && secondNumber5 < 0) || (firstNumber5 < 0 && secondNumber5 > 0);

            Console.WriteLine(result5);

            #endregion


            // - Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.
            Console.WriteLine();
            Console.WriteLine("- Write a C# program to check the sum of the two given integers and return true if one of the integer is 20 or if their sum is 20.");
            Console.WriteLine();
            Console.WriteLine("Input first integer:");

            var firstNumber21 = int.Parse(Console.ReadLine());

            Console.WriteLine("Input second integer:");

            var secondNumber21 = int.Parse(Console.ReadLine());

            var result21 = (firstNumber21 == 20 || secondNumber21 == 20) || (firstNumber21 + secondNumber21 == 20);

            // Or like this:
            //var result21 = (firstNumber21 == 20 || secondNumber21 == 20) ? true : (firstNumber21 + secondNumber21 == 20);

            Console.WriteLine(result21);
            Console.WriteLine();


            // - Write a C# program to print the odd numbers from 1 to 99. Prints one number per line.
            Console.WriteLine("- Write a C# program to print the odd numbers from 1 to 99. Prints one number per line");
            Console.WriteLine();

            for (var i = 1; i <= 99; i += 2)
            {
                Console.WriteLine(i);
            }


            // - Write a C# program to compute the sum of the first 500 prime numbers.
            Console.WriteLine("- Write a C# program to compute the sum of the first 500 prime numbers.");
            Console.WriteLine();

            var sumPrimeNumbers = 0;
            var num = 2;
            var countPrimeNumbers = 0;

            while (countPrimeNumbers < 500)
            {
                for (var i = num; i > 0;)
                {
                    var isDividedWithoutRemainder = false;
                    var isNoOthersFound = false;
                    var testNumber = 0;

                    for (var j = 2; j <= i; j++)
                    {
                        testNumber = j;

                        if (i % j == 0 && i != j)
                        {
                            isNoOthersFound = true;
                            break;
                        }

                        if (i % j == 0 && i == j)
                        {
                            isDividedWithoutRemainder = true;
                        }
                    }

                    if (!isNoOthersFound && isDividedWithoutRemainder)
                    {
                        sumPrimeNumbers += testNumber;
                        countPrimeNumbers++;
                    }

                    break;
                }
                num++;
            }

            Console.WriteLine($"Sum of the first 500 prime numbers: {sumPrimeNumbers}");
            Console.WriteLine();


            // - Write a C# program and compute the sum of the digits of an integer.
            Console.WriteLine("- Write a C# program and compute the sum of the digits of an integer.");
            Console.WriteLine();
            Console.Write("Input a number: ");

            var number = Console.ReadLine();

            var sum = 0;

            foreach (var t in number)
            {
                sum += int.Parse(t.ToString());
            }

            Console.WriteLine($"Sum of the digits of the said integer: {sum}");
        }
    }
}