using Payment;
using SlotMachine;

namespace Adapters
{
    public class CoinOutputAdapter : IDispenseMoneyPort
    {

        public void DispenseMoney(decimal amount)
        {
            CoinSlotAndDispenser.Instance.Disburse(amount);
        }

    }
}
