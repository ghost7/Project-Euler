using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Euler
{
    interface IEulerProblem
    {
        long solve();
        int getID();
    }
}
