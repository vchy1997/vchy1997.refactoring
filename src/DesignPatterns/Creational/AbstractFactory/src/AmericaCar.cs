using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.AbstractFactory
{
    public class AmericaCar : Car
    {
        public override string GetCarOrigin()
        {
            return "america";
        }
    }
}
