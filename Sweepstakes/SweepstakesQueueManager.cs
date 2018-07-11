using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        public Queue<Sweepstakes> sweepstakesAll;

        public SweepstakesQueueManager()
        {
            sweepstakesAll = new Queue<Sweepstakes>();
        }
        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesAll.Dequeue();
        }
        public void InsertSweekstakes(Sweepstakes sweepstakes)
        {
            sweepstakesAll.Enqueue(sweepstakes);
        }
    }
}
