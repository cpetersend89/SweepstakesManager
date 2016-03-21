using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace SweepstakesManagement
{
    class SweepstakesStackManager : ISweepstakesManager
    {
        private readonly Stack<Sweepstakes> _stack = new Stack<Sweepstakes>();
        public void InsertSweepstakes(Sweepstakes sweepstakes)
        {
            _stack.Push(sweepstakes);
        }

        public Sweepstakes GetNextSweepstakesWinner()
        {
            Sweepstakes sweepstake = _stack.Pop();
            return sweepstake;
        }
    }
}
