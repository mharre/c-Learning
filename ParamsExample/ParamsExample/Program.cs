using System;

namespace ParamsExample
{
    internal class Program
    {
        static void Main(string[] args)
        {
            int price = 50;
            float pi = 3.14f;
            char at = '@';
            string book = "Book";

            ParamsMethod("This", "is", "a", "sentence", "accept", "everything");
            ParamsMethod2(price, pi, at, book);
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
