using System;

namespace Design.Strategy
{
    public class CashContext
    {
        private readonly CashSuper _cashSuper;
        public CashContext(string type)
        {
            switch (type)
            {
                case "Normal":
                    _cashSuper = new CashNormal();
                    break;
                case "Rebate":
                    _cashSuper = new CashRebate(0.8);
                    break;
                case "Return":
                    _cashSuper = new CashReturn(300, 100);
                    break;
                default:
                    break;
            }
        }

        public double ContextInterface(double money)
        {
            return _cashSuper.AcceptCash(money);
        }
    }
}
