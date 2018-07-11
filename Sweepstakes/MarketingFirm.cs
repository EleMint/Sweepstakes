using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class MarketingFirm
    {
        // Member Variables
        SweepstakesQueueManager queueManager = null;
        SweepstakesStackManager stackManager = null;
        bool isStack;
        // Constructor
        public MarketingFirm()
        {
            AskStyleofSweepstakesManager();
        }
        // Member Methods
        private void AskStyleofSweepstakesManager()
        {
            switch (UI.GetUserString("What Kind Of Manager Would You Like? (Stack or Queue)").ToLower())
            {
                case "stack":
                    stackManager = new SweepstakesStackManager();
                    isStack = true;
                    break;
                case "queue":
                    queueManager = new SweepstakesQueueManager();
                    isStack = false;
                    break;
                default:
                    queueManager = new SweepstakesQueueManager();
                    isStack = false;
                    break;
            }
        }
        private void CreateSweepstakes()
        {
            int numberOfSweepstakes = UI.AskUserForInt("How Many Sweepstakes Would You Like To Make?");
            for (int i = 0; i < numberOfSweepstakes; i++)
            {
                Sweepstakes sweepstakes = new Sweepstakes(UI.GetUserString("What Is The Name Of Your Sweepstakes?"));
                sweepstakes = AddContestants(sweepstakes);
                if (isStack)
                {
                    stackManager.InsertSweekstakes(sweepstakes);
                }
                else
                {
                    queueManager.InsertSweekstakes(sweepstakes);
                }
            }
            while (stackManager.sweepstakesStack.Count > 0)
            {
                Sweepstakes currentSweepstakes;
                if(isStack)
                {
                    currentSweepstakes = stackManager.GetSweepstakes();
                }
                else
                {
                    currentSweepstakes = queueManager.GetSweepstakes();
                }
                currentSweepstakes.PickWinner();
                UI.EmailSweepstakesWinner(currentSweepstakes.sweepstakesWinner);
            }
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
    }
}
