using Adapters;
using Payment;
using Reels;
using SlotMachine;

namespace DependencyInjection
{
    public static class SlotMachineFactory
    {

        public static ISlotMachine CreateSlotMachine()
        {
            SlotMachine.SlotMachine slotMachine = new(
                new ReelAdapter(new Reel()),
                new ReelAdapter(new Reel()),
                new ReelAdapter(new Reel()),
                new CoinOutputAdapter(),
                new ConsoleMessageAdapter(),     
                new ConsoleDisplayBalanceAdapter(),
                new ConsoleGameOutcomePort()
                ); ;

            new CoinInputAdapter(CoinSlotAndDispenser.Instance, slotMachine);

            return slotMachine;
        }

    }
}
