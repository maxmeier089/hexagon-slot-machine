namespace Payment
{

    public class CoinInsertedEventArgs : EventArgs
    {

        public decimal Amount { get; }

        internal CoinInsertedEventArgs(decimal amount)
        {
            Amount = amount;
        }

    }

    public class CoinSlotAndDispenser
    {


        public static CoinSlotAndDispenser Instance { get;  }



        public event EventHandler<CoinInsertedEventArgs>? CoinInserted;

        public void Disburse(decimal amount)
        {
            Console.WriteLine("Disburse " + string.Format("{0:C}", amount));
        }

        public void InsertCoinTest(decimal amount)
        {
            CoinInserted?.Invoke(this, new CoinInsertedEventArgs(amount));
        }


        static CoinSlotAndDispenser()
        {
            Instance = new CoinSlotAndDispenser();
        }

        private CoinSlotAndDispenser()
        {
        }

    }
}
