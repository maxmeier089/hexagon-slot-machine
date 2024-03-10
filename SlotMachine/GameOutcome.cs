namespace SlotMachine
{
    public class GameOutcome
    {

        public List<ReelSymbol> Symbols { get; }

        public decimal Amount { get; }

        public override string ToString()
        {
            string text = string.Empty;

            Symbols.ForEach(s => text += s.ToString() + " ");

            text += "\n" + string.Format("{0:C}", Amount);

            return text;
        }

        internal GameOutcome(List<ReelSymbol> symbols, decimal amount)
        {
            Symbols = symbols;
            Amount = amount;
        }
    }
}
