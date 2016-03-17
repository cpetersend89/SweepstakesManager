using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManagement
{
    class Sweepstakes
    {
        public Sweepstakes()
        {
            
        }

        Dictionary<int, Contestant> sweep = new Dictionary<int, Contestant>();

        public void RegisterContestant(Contestant contestant)
        {
            sweep.Add(sweep.Count, contestant);
            
        }

        public Contestant PickWinner()
        {
            int max = sweep.Count + 1;
            Random random = new Random();
            int randomNumber = random.Next(0, max);
            Contestant value = sweep[randomNumber];
            return value;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            foreach (var entry in sweep)
            {
                Console.WriteLine("Winner: [{0} {1}]", entry.Key, entry.Value);
            }
        }

    }
}
