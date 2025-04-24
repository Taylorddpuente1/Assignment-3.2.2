using System;
using System.Drawing;

namespace MyApplication
{
    class Program
    {
        static void Main(string[] args)
        {
            int size = 2;
            int[,] nums1 = { { 1, 2 }, { 3, 4 } };
            int[,] nums2 = { { 5, 6 }, { 7, 8 } };
            int[,] sumNums = new int[size, size];

            // Add matrix

            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    sumNums[i, j] = nums1[i, j] + nums2[i, j];
                }
            }

            Console.WriteLine(" The first Matrix is: ");
            PrintMatrix(nums1, size);

            Console.WriteLine(" The second Matrix is: ");
            PrintMatrix(nums2, size);

            Console.WriteLine("The sum of two matrix is: ");
            PrintMatrix(sumNums, size);
        }
        static void PrintMatrix(int[,] nums, int size)
        {
            for (int i = 0; i < size; i++)
            {
                for (int j = 0; j < size; j++)
                {
                    Console.Write(nums[i, j]);
                }

                Console.WriteLine();
            }
        }
    }

}
