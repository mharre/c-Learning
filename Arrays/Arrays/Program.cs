using System;

namespace Arrays
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //int[] grades = new int[5];
            //grades[0] = 20;


            //int[] grades2 = { 12, 13, 14, 15 };

            //int[] grades3 = new int[] { 5, 4, 3, 2, 1 };

            //int[] nums = new int[10];

            //for (int i=0; i< nums.Length; i++)
            //{
            //    nums[i] = i;
            //}

            //foreach(int k in nums)
            //{
            //    Console.WriteLine(nums[k]);
            //}

            // declare 2D array
            //string[,] matrix;
            // declare 3d
            //int[,,] threeD;

            //int[,] array2D = new int[,]
            //{
            //    {1, 2, 3},
            //    {4, 5, 6},
            //    {7, 8, 9}


            // jagged array - array within array
            // 3 arrays within array
            //int[][] jagged = new int[][]
            //{
            //    new int[] { 1, 2, 3 },
            //    new int[] {4, 5, 7, 3, 4}
            //};

            //Console.WriteLine(jagged[1][3]);

            int[] grades = new int[] { 15, 14, 13, 12, 11, 5 };
            double avg = GetAverage(grades);

            Console.WriteLine(avg);
        }
        static double GetAverage(int[] gradesArray)
        {
            int size = gradesArray.Length;
            double average;
            int sum = 0;

            for (int i = 0; i < size; i++)
            {
                sum += gradesArray[i];
            }
            average = (double)sum / size;
            return average;
        }
    }
}
