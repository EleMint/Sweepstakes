using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        Stack<Sweepstakes> sweepstakesStack;

        public SweepstakesStackManager()
        {
            sweepstakesStack = new Stack<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesStack.Pop();
        }

        public void InsertSweekstakes(Sweepstakes sweepstakes)
        {
            sweepstakesStack.Push(sweepstakes);
        }
    }
}
