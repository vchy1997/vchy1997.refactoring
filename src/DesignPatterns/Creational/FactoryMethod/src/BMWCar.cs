using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.FactoryMehtod
{
    public class BMWCar : Car
    {
        public override string GetCarBrand()
        {
            return "bmw";
        }
    }
}
