using Reels;
using SlotMachine;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Adapters
{
    public class ReelAdapter : IReelPort
    {

        private Reel reel;

        public void Spin()
        {
            reel.StartReel();
        }

        public ReelSymbol Stop()
        {
            string outcome = reel.StopReel();

            switch (outcome)
            {
                case "0": return new LossSymbol();
                case "10": return new MoneySymbol(0.1m, "10 ");
                case "50": return new MoneySymbol(0.5m, "50 ");
                case "100": return new MoneySymbol(1.0m, "100");
                case "Hexagon": return new Hexagon();
                default: throw new Exception("Unknown Symbol");
            }
        }

        public ReelAdapter(Reel reel)
        {
            this.reel = reel;
        }

    }
}
