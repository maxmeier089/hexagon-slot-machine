namespace SlotMachine
{
    public class SlotMachine : ISlotMachine
    {


        private decimal balance;

        public decimal Balance
        {
            get => balance;
            set
            {
                balance = value;
                displayBalancePort.DisplayBalance(balance);
            }
        }



        private List<IReelPort> reels;


        private IMessagePort messagePort;


        private IDispenseMoneyPort dispenseMoneyPort;


        private IDisplayBalancePort displayBalancePort;


        private IGameOutcomePort gameOutcomePort;



        public void PullLever()
        {
            Balance -= 0.1m;
            reels.ForEach(r => r.Spin());
        }


        public void ReleaseLever()
        {
            List<ReelSymbol> symbols = [];
            reels.ForEach(r => symbols.Add(r.Stop()));

            decimal amount = 0.0m;

            if (symbols.Exists(o => o is LossSymbol))
            {
                amount = 0.0m;
            }
            else if (symbols.TrueForAll(o => o is Hexagon))
            {
                amount = 5.0m;
            }
            else
            {
                amount = symbols.Where(s => s is MoneySymbol).Select(s => (s as MoneySymbol).Amount).Order().FirstOrDefault();
            }

            gameOutcomePort.NotifyGameOutcome(DateTime.Now, new GameOutcome(symbols, amount));

            Balance += amount;
        }

        public void Payout()
        {
            dispenseMoneyPort.DispenseMoney(Balance);
            Balance = 0m;
        }

        public void InsertMoney(decimal amount)
        {
            Balance += amount;
        }

        public SlotMachine(
            IReelPort reel1, IReelPort reel2, IReelPort reel3,
            IDispenseMoneyPort dispenseMoneyPort,
            IMessagePort messagePort, 
            IDisplayBalancePort displayBalancePort,
            IGameOutcomePort gameOutcomePort
            )
        {
            reels = [reel1, reel2, reel3];
            this.messagePort = messagePort;
            this.dispenseMoneyPort = dispenseMoneyPort;
            this.displayBalancePort = displayBalancePort;
            this.gameOutcomePort = gameOutcomePort;
        }
        
    }
}
