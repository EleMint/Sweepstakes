using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Program
    {
        static void Main(string[] args)
        {
            Contestant Dylan = new Contestant();
            UI.EmailSweepstakesWinner(Dylan);
            Sweepstakes mySweepstakes = new Sweepstakes("Sweepstakes");
        }
    }
}
