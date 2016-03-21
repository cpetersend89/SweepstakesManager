using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManagement
{
    class Sweepstakes
    {
        private string _name;
        private readonly Dictionary<int, Contestant> _sweep;
        public Sweepstakes(string name)
        {
            _name = name;
            _sweep = new Dictionary<int, Contestant>();
        }

        public void RegisterContestant(Contestant contestant)
        {
            _sweep.Add(_sweep.Count, contestant);
        }

        public Contestant PickWinner()
        {
            int max = _sweep.Count + 1;
            Random random = new Random();
            int randomNumber = random.Next(0, max);
            Contestant value = _sweep[randomNumber];
            return value;
        }

        public void PrintContestantInfo(Contestant contestant)
        {
            foreach (var entry in _sweep)
            {
                Console.WriteLine("Winner: [{0} {1}]", entry.Key, entry.Value);
            }
        }
        public void DisplaySweepStakesMenu()
        {
            Console.WriteLine("Main Menu:\n(1) Start Sweepstakes\n(2) Register Contestant");
            while (true)
            {
                int choice = Tools.VerifyNumber();
                switch (choice)
                {
                    case 1: //Make Sweepstakes
                        Console.Write("Name your sweepstakes: ");
                        _name = Console.ReadLine();
                        Sweepstakes sweepstakes = new Sweepstakes(_name);
                        Tools.ClearConsole();
                        break;
                    case 2: //Register Contestant
                        string name = UserInput.CollectUserName();
                        string phoneNumber = UserInput.CollectUserPhoneNumber();
                        RegisterContestant(new Contestant(name, phoneNumber));
                        Tools.ClearConsole();
                        break;
                    default:
                        Console.WriteLine("Invalid: Choose a valid menu option");
                        Console.ReadKey();
                        Console.Clear();
                        break;

                }
                DisplaySweepStakesMenu();
            }
            

        }

    }
}
