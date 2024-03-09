
namespace Reels
{

    public class Reel
    {

        private readonly string[] symbols;

        private int currentSymbol = 0;

        public string Symbol => symbols[currentSymbol];


        private static readonly Random randomStatic = new();

        private Random random = new();


        public void StartReel()
        {
            random = new Random(randomStatic.Next());
        }

        public string StopReel()
        {
            currentSymbol = random.Next(symbols.Length);
            return Symbol;
        }

        public Reel()
        {
            symbols = 
                [
                    "0", "10", "10", "10", "50", "50", "100", "Hexagon"
                ];
        }

    }
}
