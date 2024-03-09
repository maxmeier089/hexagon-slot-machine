using SlotMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    public class ConsoleMessageAdapter : IMessagePort
    {
        public void SendMessage(string message)
        {
            Console.WriteLine(message);
        }
    }
}
