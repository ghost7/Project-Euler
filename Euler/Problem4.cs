using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    /// <summary>
    /// A palindromic number reads the same both ways. The largest palindrome made from the product of two 2-digit numbers is 9009 = 91 × 99.
    ///
    /// Find the largest palindrome made from the product of two 3-digit numbers.
    /// </summary>
    class Problem4 : IEulerProblem
    {
        public long solve()
        {
            return largestPalindromeProduct(999, 100);
        }

        public int getID()
        {
            return 4;
        }

        private int largestPalindromeProduct(int maxNum, int minNum)
        {
            int max = 0;

            for (int i = maxNum; i >= minNum; i--)
            {
                for (int j = i; j >= minNum; j--)
                {
                    int product = i * j;
                    if (max < product && isPalindrome(product))
                    {
                        max = product;
                    }
                }
            }
            return max;
        }

        private bool isPalindrome(int num)
        {
            string numString = num.ToString();
            int min = 0;
            int max = numString.Length - 1;
            while (min < max)
            {
                if (numString[min] != numString[max])
                {
                    return false;
                }
                min++;
                max--;
            }
            return true;
        }
    }
}
