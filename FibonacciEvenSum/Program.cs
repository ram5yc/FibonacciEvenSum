using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


//Each new term in the Fibonacci sequence is generated
//by adding the previous two terms.By starting with
//1 and 2, the first 10 terms will be:

//1, 2, 3, 5, 8, 13, 21, 34, 55, 89, ...
//By considering the terms in the Fibonacci sequence whose values do not exceed four million, find the sum of the even-valued terms.

namespace FibonacciEvenSum
{
    class Program
    {
        static void Main(string[] args)
        {
           

            int fib1 = 1; //variable for first number
            int fib2 = 2; //variable for second number
            int fib3 = 0; //stores addition

            int fib4 = 0;
            
            do
            {
                //string to make the output of addition stored in new variable
                fib3 = fib1 + fib2;
                fib1 = fib2; //have to equal second variable to first
                fib2 = fib3; //have to equal third variable to second to push down the line
                //fib4 += fib2; //keep for later


                if (fib2 % 2 == 0) //find numbers divisible by 2 (even)
                {
                    fib4 += fib2; //fib2 turns into fib3 so that is why we need to store it in fib4
                }

                
            } while (fib4 < 4000000); //variable goes until 4 mill
            Console.WriteLine(fib4);
        }
    }
}

//divide by 2 to make it even numbers only
//sum = sum % 2;