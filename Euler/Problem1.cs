using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// If we list all the natural numbers below 10 that are multiples of 3 or 
    /// 5, we get 3, 5, 6 and 9. The sum of these multiples is 23. Find the sum
    /// of all the multiples of 3 or 5 below 1000.
    /// </summary>
    class Problem1 : IEulerProblem
    {
        public long solve()
        {
            int sum3 = sumOfMultiples(3, 1000);
            int sum5 = sumOfMultiples(5, 1000);
            int sum15 = sumOfMultiples(15, 1000);
            return sum3 + sum5 - sum15;
        }

        public int getID()
        {
            return 1;
        }

        private int sumOfMultiples(int num, int limit)
        {
            List<int> multiples = new List<int>();

            for (int i = num; i < limit; i++)
            {
                if (i % num == 0)
                {
                    multiples.Add(i);
                }
            }
            return multiples.Sum();
        }
    }
}
