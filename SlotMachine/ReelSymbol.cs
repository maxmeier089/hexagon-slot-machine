namespace SlotMachine
{

    public abstract class ReelSymbol
    {
    }

    public class LossSymbol : ReelSymbol
    {
        public override string ToString()
        {
            return " X ";
        }
    }

    public class MoneySymbol : ReelSymbol
    {

        public virtual decimal Amount { get; }

        private string displayString;

        public override string ToString()
        {
            return displayString;
        }

        public MoneySymbol(decimal amount, string displayString)
        {
            Amount = amount;
            this.displayString = displayString;
        }

    }

    public class Hexagon : ReelSymbol
    {
        public override string ToString()
        {
            return "<=>";
        }
    }

}
