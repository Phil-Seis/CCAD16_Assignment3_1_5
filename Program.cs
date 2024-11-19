//CCAD Assignment 3-1-5
//Write a function which takes an array as input and finds the first occurence of 2 consecutive 1s and changes their value to 0.
using System;

namespace CCAD16_Assignment3_1_5
{
    internal class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Let's change those consecutive 1s to 0s!");
            Console.WriteLine("Original Array: 1, 5, 5, 4, 3, 1, 1, 2, 9, 1, 1, 4 ");
            
            int[] resultArray = ConsecutiveOnes();

            Console.WriteLine("Modified array:");
            Console.WriteLine(string.Join(", ", resultArray));
        }

        static int[] ConsecutiveOnes()
        {
            int[] ints = { 1, 5, 5, 4, 3, 1, 1, 2, 9, 1, 1, 4 };

            for (int i = 0; i < ints.Length - 1; i++)
            {
                if (ints[i] == 1 && ints[i + 1] == 1)
                {
                    ints[i] = 0;
                    ints[i + 1] = 0;
                    break;      
                }
            }

            return ints;
        }
    }
}
