using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        public Stack<Sweepstakes> sweepstakesAll;
        public SweepstakesStackManager()
        {
            sweepstakesAll = new Stack<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesAll.Pop();
        }
        public void InsertSweekstakes(Sweepstakes sweepstakes)
        {
            sweepstakesAll.Push(sweepstakes);
        }
    }
}
