using SlotMachine;

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
