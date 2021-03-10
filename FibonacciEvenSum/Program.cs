using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
           
            int fib1 = 0; //variable for first number
            int fib2 = 1; //variable for second number
            int sum = 0; //stores addition
            do
            {
                //string to make the output of addition stored in new variable
                sum = sum + fib1 + fib2;

                //divide by 2 to make it even numbers only
                sum = sum / 2;

            } while (sum < 4000000); //variable goes until 4 mill
            Console.WriteLine(sum);
        }
    }
}
