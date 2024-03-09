using SlotMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    public class ConsoleDisplayBalanceAdapter : IDisplayBalancePort
    {
        public void DisplayBalance(decimal balance)
        {
            Console.WriteLine("Current Balance: " + string.Format("{0:C}", balance));
        }

    }
}
