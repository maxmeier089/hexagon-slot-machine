using SlotMachine;

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
