using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        public int numberOfSweepstakes;
        public MarketingFirm(ISweepstakesManager manager)
        {
            CreateSweepstakes(manager);
        }
        private void CreateSweepstakes(ISweepstakesManager manager)
        {
            numberOfSweepstakes = UI.AskUserForInt("How Many Sweepstakes Would You Like To Make?");
            for (int i = 0; i < numberOfSweepstakes; i++)
            {
                Sweepstakes sweepstakes = new Sweepstakes(UI.GetUserString("What Is The Name Of Your Sweepstakes?"));
                sweepstakes = AddContestants(sweepstakes);
                manager.InsertSweekstakes(sweepstakes);
            }
            PickWinners(manager);
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
        public void PickWinners(ISweepstakesManager manager)
        {
            for(int i = 0; i < numberOfSweepstakes; i++)
            {
                UI.Print(manager.GetSweepstakes().PickWinner());
            }
        }
    }
}
