using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.Strategy
{
    internal abstract class CashSuper
    {
        internal abstract double AcceptCash(double money);
    }

    /// <summary>
    /// 正常收费
    /// </summary>
    internal class CashNormal : CashSuper
    {
        internal override double AcceptCash(double money)
        {
            return money;
        }
    }

    /// <summary>
    /// 折扣收费
    /// </summary>
    class CashRebate : CashSuper
    {
        private readonly double _rebate;

        public CashRebate(double rebate)
        {
            _rebate = rebate;
        }

        internal override double AcceptCash(double money)
        {
            return money * _rebate;
        }
    }

    /// <summary>
    /// 消费返利
    /// </summary>
    class CashReturn : CashSuper
    {
        private readonly double _moneyCondition;
        private readonly double _moneyReturn;

        public CashReturn(double moneyCondition, double moneyReturn)
        {
            _moneyCondition = moneyCondition;
            _moneyReturn = moneyReturn;
        }
        internal override double AcceptCash(double money)
        {
            double result = money;
            if (money >= _moneyCondition)
            {
                result = money - Math.Floor(money / _moneyCondition) * _moneyReturn;
            }

            return result;
        }
    }
}
