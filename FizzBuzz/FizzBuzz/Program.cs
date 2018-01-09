using System;

namespace FizzBuzz
{
    class Program
    {
        static void Main(string[] args)
        {
            var fizzBuzzEvaluator = new FizzBuzzEvaluator();

            for (int i=1; i<100; i++)
            {
                Console.WriteLine(fizzBuzzEvaluator.EvaluateNumber(i));
            }

            Console.ReadLine();
        }
    }
}
