using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    ///  <summary>
    ///  A Pythagorean triplet is a set of three natural numbers, a < b < c, for which,
    /// 
    ///  a^2 + b^2 = c^2
    ///  
    ///  For example, 3^2 + 4^2 = 9 + 16 = 25 = 5^2.
    /// 
    ///  There exists exactly one Pythagorean triplet for which a + b + c = 1000.
    ///  Find the product abc. />
    ///  </summary>
    class Problem9 : IEulerProblem
    {
        public long solve()
        {
            return getPythagoreanTripletProduct(1000);
        }

        public int getID()
        {
            return 9;
        }

        /// <summary>
        /// Brute force, there is probably a better way...
        /// </summary>
        /// <returns></returns>
        private long getPythagoreanTripletProduct(int sum)
        {
            for (int c = 5; c < sum; c++)
            {
                for (int b = 4; b < c; b++)
                {
                    for (int a = 3; a < b; a++)
                    {
                        if (a*a + b*b == c*c)
                        {
                            if (a + b + c == sum)
                            {
                                return a*b*c;
                            }
                        }
                    }
                }
            }
            return -1;
        }
    }
}
