using System;

namespace HW4
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine(NearestTo20(-21, 15));
            Console.ReadKey();

            var arr = new[] { 2, 4, 3 };
            Console.WriteLine(SumArrayValues(arr));
            Console.ReadKey();

            Console.WriteLine(GetLargestValueInArray(arr));
            Console.ReadKey();
        }

        //-Write a C# method to find the largest value from three integer values.
        static int LargestValue(int num1, int num2, int num3)
        {
            var result = num1;

            if (num2 > result)
                result = num2;
            if (num3 > result)
                result = num3;

            return result;
        }

        //-Write a C# method to find the lowest value from three integer values.
        static int LowestValue(int num1, int num2, int num3)
        {
            var result = num1;

            if (num2 < result) 
                result = num2;

            if (num3 < result) 
                result = num3;

            return result;
        }

        //Write a C# method to check the nearest value of 20 of two given integers and return 0 if two numbers are same 
        static int NearestTo20(int num1, int num2)
        {
            if (num1 == num2)
                return 0;

            var absNum1 = GetAbsoluteValue(num1 - 20);
            var absNum2 = GetAbsoluteValue(num2 - 20);

            return absNum1 < absNum2 ? num1 : num2;
        }

        //Used to find the absolute value of a number instead of 'Math.Abs'
        static int GetAbsoluteValue(int num)
        {
            return num > 0 ? num : -num;
        }

        //-Write a C# method to compute the sum of all the elements of an array of integers
        static int SumArrayValues(int[] arr)
        {
            var sum = 0;

            foreach (var item in arr)
            {
                sum += item;
            }

            return sum;
        }

        //- Write a C# method to get the larger value from array
        static int GetLargestValueInArray(int[] arr)
        {
            var max = arr[0]; 

            for (var i = 1; i < arr.Length; i++)
            {
                if (arr[i] > max) 
                    max = arr[i];
            }

            return max;
        }
    }
}