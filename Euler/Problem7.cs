using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Problem7 : IEulerProblem
    {
        public long solve()
        {
            return findNthPrime(10001);
        }

        public int getID()
        {
            return 7;
        }

        private long findNthPrime(long n)
        {
            bool[] isPrime = MathUtilities.Sieve(1000000); // is there a better way?
            long currentPrime = 1;
            long currentIndex = 2;
            while (currentPrime < n)
            {
                currentIndex++;
                if (isPrime[currentIndex])
                {
                    currentPrime++;
                }
            }
            return currentIndex;
        }
    }
}
