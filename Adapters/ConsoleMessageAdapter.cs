using SlotMachine;

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
