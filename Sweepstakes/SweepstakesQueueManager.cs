using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class SweepstakesQueueManager : ISweepstakesManager
    {
        Queue<Sweepstakes> sweepstakesQueue;

        public SweepstakesQueueManager()
        {
            sweepstakesQueue = new Queue<Sweepstakes>();
        }

        public Sweepstakes GetSweepstakes()
        {
            return sweepstakesQueue.Dequeue();
        }
        public void InsertSweekstakes(Sweepstakes sweepstakes)
        {
            sweepstakesQueue.Enqueue(sweepstakes);
        }
    }
}
