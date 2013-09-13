using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    public static class ArrayExtensions
    {
        public static T[] Fill<T>(this T[] originalArray, T with)
        {
            for (int i = 0; i < originalArray.Count(); i++)
            {
                originalArray[i] = with;
            }
            return originalArray;
        }
    }

    class MathUtilities
    {
        /// <summary>
        /// Implementation of the Sieve of Eratosthenes
        /// 
        /// Generates a boolean array where the value ’true’ 
        /// indicates that index being a prime number. 
        /// </summary>
        /// <param name="N">Upper Limit</param>
        /// <returns>All primes up to and including N.</returns>
        public static bool[] Sieve(long N)
        {
            bool[] isPrime = new bool[N + 1];
            isPrime.Fill(true);
            isPrime[0] = false;
            isPrime[1] = false;

            // Iterate throught all the numbers upto sqrt(N) to
            // locate all the prime numbers.
            for (int i = 2; i*i <= N; i++)
            {
                if (!isPrime[i])
                {
                    continue;
                }

                // Iterate thought all multiples of the prime and mark them as 
                // not prime
                for (int multiples = i*i; multiples <= N; multiples += i)
                {
                    isPrime[multiples] = false;
                }
            }
            return isPrime;
        }

        public static long GetGCD(long num1, long num2)
        {
            while (num1 != num2)
            {
                if (num1 > num2)
                    num1 = num1 - num2;

                if (num2 > num1)
                    num2 = num2 - num1;
            }
            return num1;
        }

        public static long GetLCM(long num1, long num2)
        {
            return (num1 * num2) / GetGCD(num1, num2);
        }

        public static long SumFrom1ToN(long N)
        {
            return N*(N + 1)/2;
        }
    }
}
