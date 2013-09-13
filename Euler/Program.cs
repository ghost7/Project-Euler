using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class Program
    {
        private static readonly IEulerProblem[] problems =
            {
                new Problem1(),
                new Problem2(), 
                new Problem3(), 
                new Problem4(), 
                new Problem5(),
                new Problem6(), 
                new Problem7(),
                new Problem8(), 
                new Problem9(), 
                new Problem10(), 
                new Problem11(), 
            };
        
        private static void Main(string[] args)
        {
            SolutionWriter solutionWriter = new TableSolutionWriter();
            solutionWriter.WriteAllSolutions(problems);
        }
    }
}
