using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// The sum of the squares of the first ten natural numbers is,
    ///
    /// 12 + 22 + ... + 102 = 385
    /// 
    /// The square of the sum of the first ten natural numbers is,
    ///
    /// (1 + 2 + ... + 10)2 = 552 = 3025
    /// 
    /// Hence the difference between the sum of the squares of the first ten natural numbers and the square of the sum is 3025 − 385 = 2640.
    ///
    /// Find the difference between the sum of the squares of the first one hundred natural numbers and the square of the sum.
    /// </summary>
    class Problem6 : IEulerProblem
    {
        public long solve()
        {
            return sumSquareDiff(100);
        }

        public int getID()
        {
            return 6;
        }

        private long sumSquareDiff(long n)
        {
            long sumOfSquares = 0;
            for (long i = 0; i <= n; i++)
            {
                sumOfSquares += i*i;
            }
            long sum = MathUtilities.SumFrom1ToN(n);
            long sqaureOfSum = sum*sum;
            return sqaureOfSum - sumOfSquares;
        }
    }
}
