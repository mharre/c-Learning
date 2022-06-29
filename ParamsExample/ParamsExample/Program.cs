using System;

namespace ParamsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int min = MinV2(5, 3, 2, 1, 6, 33, 1, 67, 3);
            Console.WriteLine($"{min}");

        }

        public static int MinV2(params int[] numbers)
        {
            int min = int.MaxValue;
            foreach (int num in numbers)
            {
                if (num < min)
                {
                    min = num;
                }
            }
            return min;
        }

        public static void ParamsMethod(params string[] sentence)
        {
            for(int i=0; i<sentence.Length; i++)
            {
                Console.WriteLine(sentence[i] + " ");
            }
        }

        public static void ParamsMethod2(params object[] stuff)
        {
            foreach (object obj in stuff)
            {
                Console.Write(obj + " ");
            }
            Console.WriteLine();
        }

    }
}
