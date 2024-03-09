using SlotMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    public class ConsoleGameOutcomePort : IGameOutcomePort
    {
        public void NotifyGameOutcome(DateTime timestamp, GameOutcome outcome)
        {
            Console.WriteLine(outcome);
        }
    }
}
