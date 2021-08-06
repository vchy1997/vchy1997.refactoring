using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.FactoryMehtod
{
    public class PorscheCar : Car
    {
        public override string GetCarBrand()
        {
            return "porsche";
        }
    }
}
