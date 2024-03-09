using Payment;
using SlotMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    public class CoinInputAdapter
    {

        private IInsertMoneyPort insertMoneyPort;

        private void CoinSlotAndDispenser_CoinInserted(object? sender, CoinInsertedEventArgs e)
        {
            insertMoneyPort.InsertMoney(e.Amount);
        }

        public CoinInputAdapter(CoinSlotAndDispenser coinSlotAndDispenser, IInsertMoneyPort insertMoneyPort)
        {
            this.insertMoneyPort = insertMoneyPort;
            coinSlotAndDispenser.CoinInserted += CoinSlotAndDispenser_CoinInserted;
        }
  
    }
}
