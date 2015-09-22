using System;
/*
 * The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
 * Find the sum of all the primes below two million.
 * 
 * Using sieve of Eratosthenes just calculate the result.
 */
namespace PEProblem010
{
    class Program
    {
        static void Main(string[] args)
        {
            DateTime StartTime = DateTime.Now;

            UInt64 arraySize = 2000001;

            UInt64[] numbers = new UInt64[arraySize];

            for (UInt64 i = 0; i < arraySize; i++)
            {
                numbers[i] = i;
            }

            for (UInt64 i = 2; i < arraySize; i++)
            {
                if (numbers[i] != 0)
                {
                    for (UInt64 j = i + i; j < arraySize; j = j + i)
                    {
                        numbers[j] = 0;
                    }
                }
            }

            UInt64 result = 0;

            for (UInt64 i = 2; i < arraySize; i++)
            {
                if (numbers[i] != 0)
                {
                    result += numbers[i];
                }
            }

            TimeSpan elapsedTime = DateTime.Now - StartTime;

            Console.WriteLine("result: " + result.ToString());
            Console.WriteLine("elapsed time: " + elapsedTime.ToString("mm':'ss':'fff") + " mm:ss:fff");
            Console.ReadLine();
        }
    }
}