﻿using Payment;
using SlotMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

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