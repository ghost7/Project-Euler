using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    abstract class SolutionWriter
    {
        public abstract void WriteSolution(IEulerProblem problem);
        public abstract void WriteHeader();
        public abstract void WriteSeparator();

        public virtual void WriteAllSolutions(IEulerProblem[] problems)
        {
            WriteHeader();
            for (int i = 0; i < problems.Length; i++)
            {
                WriteSolution(problems[i]);
                WriteSeparator();
            }
        }
    }
}
