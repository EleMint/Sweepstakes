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
            Sweepstakes mySweepstakes = new Sweepstakes("Sweepstakes");
            Contestant contestant = new Contestant();
            Contestant contestant2 = new Contestant();
            Contestant contestant3 = new Contestant();
            Contestant contestant4 = new Contestant();
            mySweepstakes.RegisterContestant(contestant);
            mySweepstakes.RegisterContestant(contestant2);
            mySweepstakes.RegisterContestant(contestant3);
            mySweepstakes.RegisterContestant(contestant4);
            string winner = mySweepstakes.PickWinner();
            UI.Print(winner);
            Console.ReadLine();
            
        }
    }
}
