using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The prime factors of 13195 are 5, 7, 13 and 29.
    /// 
    /// What is the largest prime factor of the number 600851475143 ?
    /// </summary>
    class Problem3 : IEulerProblem
    {
        public long solve()
        {
            return getLargestPrimeFactor(600851475143);
        }

        public int getID()
        {
            return 3;
        }

        private long getLargestPrimeFactor(long num)
        {
            long sqrtNum = (long) Math.Sqrt(num);
            bool[] isPrime = MathUtilities.Sieve(sqrtNum);
            for (long i = sqrtNum; i > 1; i--)
            {
                if (isPrime[i] && num%i == 0)
                {
                    return i;
                }
            }
            return 1;
        }
    }
}
