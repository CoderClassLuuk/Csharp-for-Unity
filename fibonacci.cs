using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace fibonacci
{
    class Program
    {
        public static int fibonacci(int n)
        {
            int fibonacciFirst = 0;
            int fibonacciSecond = 1;
            for (int i = 0; i < n; i++)
            {
                int fibonacciTemporary = fibonacciFirst;
                fibonacciFirst = fibonacciSecond;
                fibonacciSecond = fibonacciTemporary + fibonacciSecond;
            }
            return fibonacciFirst;
        }
        public static void Main(string[] args)
        {
            for (int i = 0; i < 20; i++)
            {
                Console.Write(fibonacci(i) + " ");
            }
            Console.ReadKey();
        }
    }
}
