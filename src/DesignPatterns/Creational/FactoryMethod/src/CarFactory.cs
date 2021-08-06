using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.FactoryMehtod
{
    public class CarFactory
    {
        public static Car GetCar(string brand)
        {
            switch (brand)
            {
                case "porsche":
                    return new PorscheCar();
                case "bmw":
                    return new BMWCar();
                default:
                    throw new ArgumentException($"invalid argument {brand}");
            }
        }

    }
}
