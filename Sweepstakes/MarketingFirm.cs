using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        // Constructor
        public MarketingFirm(ISweepstakesManager manager)
        {
            CreateSweepstakes(manager);
        }
        // Member Methods
        private void CreateSweepstakes(ISweepstakesManager manager)
        {
            int numberOfSweepstakes = UI.AskUserForInt("How Many Sweepstakes Would You Like To Make?");
            for (int i = 0; i < numberOfSweepstakes; i++)
            {
                Sweepstakes sweepstakes = new Sweepstakes(UI.GetUserString("What Is The Name Of Your Sweepstakes?"));
                sweepstakes = AddContestants(sweepstakes);
                manager.InsertSweekstakes(sweepstakes);
            }
            PickWinner(manager, numberOfSweepstakes);
        }
        public Sweepstakes AddContestants(Sweepstakes sweepstakes)
        {
            int numberOfContestants = UI.AskUserForInt($"How Many Contestants Would You Like To Create For {sweepstakes.name}?");
            for (int j = 0; j < numberOfContestants; j++)
            {
                Contestant contestant = new Contestant();
                sweepstakes.RegisterContestant(contestant);
            }
            return sweepstakes;
        }
        public void PickWinner(ISweepstakesManager manager, int numberOfSweepstakes)
        {
            while (numberOfSweepstakes > 0)
            {
                Sweepstakes currentSweepstakes;
                currentSweepstakes = manager.GetSweepstakes();
                currentSweepstakes.PickWinner();
                UI.EmailSweepstakesWinner(currentSweepstakes.sweepstakesWinner);
            }
        }
    }
}
