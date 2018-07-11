using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Sweepstakes
{
    class Sweepstakes
    {
        // Member Variables
        public string name;
        private Dictionary<int, Contestant> registeredContestants;
        private Random random = new Random();
        // Constructor
        public Sweepstakes(string name)
        {
            this.name = name;
            registeredContestants = new Dictionary<int, Contestant>();
        }
        // Member Methods
        public void RegisterContestant(Contestant contestant)
        {
            registeredContestants.Add(registeredContestants.Count + 1, contestant);
        }
        public string PickWinner()
        {
            int winner = random.Next(registeredContestants.Count + 1);
            return $"The Winner is: {registeredContestants[winner].lastName}, {registeredContestants[winner].firstName}";
        }
        public void PrintContestantInfo(Contestant contestant)
        {
            UI.Print($"\r\nName: {contestant.lastName}, {contestant.firstName} \r\nEmail: {contestant.email} \r\nRegistration Number: {contestant.registrationNumber}");
        }
    }
}
