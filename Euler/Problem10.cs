using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The sum of the primes below 10 is 2 + 3 + 5 + 7 = 17.
    ///
    /// Find the sum of all the primes below two million.
    /// </summary>
    class Problem10 : IEulerProblem
    {
        public long solve()
        {
            return sumOfPrimes(2000000);
        }

        public int getID()
        {
            return 10;
        }

        private long sumOfPrimes(int max)
        {
            bool[] isPrime = MathUtilities.Sieve(max);
            long sum = 0;
            for (int i = 0; i < isPrime.Length; i++)
            {
                if (isPrime[i])
                {
                    sum += i;
                }
            }
            return sum;
        }
    }
}
