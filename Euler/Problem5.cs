using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// 2520 is the smallest number that can be divided by each of the numbers from 1 to 10 without any remainder.
    ///
    /// What is the smallest positive number that is evenly divisible by all of the numbers from 1 to 20?
    /// </summary>
    class Problem5 : IEulerProblem
    {
        public long solve()
        {
            return smallestMultiple(1, 20);
        }

        public int getID()
        {
            return 5;
        }

        public long smallestMultiple(int low, int high)
        {
            long lcm = MathUtilities.GetLCM(low, low + 1);
            for (int i = low+2; i <= high; i++)
            {
                lcm = MathUtilities.GetLCM(lcm, i);
            }
            return lcm;
        }
    }
}
