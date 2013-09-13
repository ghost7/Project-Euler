using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    class TableSolutionWriter : SolutionWriter
    {
        public override void WriteAllSolutions(IEulerProblem[] problems)
        {
            base.WriteAllSolutions(problems);
            Console.Read();
        }

        public override void WriteSolution(IEulerProblem problem)
        {
            string solution;
            try
            {
                solution = problem.solve().ToString();
            }
            catch (NotImplementedException)
            {
                solution = "Not solved yet!";
            }
            Console.WriteLine(String.Format("| Problem {0,3} | {1,16} |", problem.getID(), solution));
        }

        public override void WriteHeader()
        {
            WriteSeparator();
            Console.WriteLine(String.Format("| Problem     | {0,16} |", "Solution"));
            WriteSeparator();
        }

        public override void WriteSeparator()
        {
            Console.WriteLine(new string('-', 34));
        }
    }
}
