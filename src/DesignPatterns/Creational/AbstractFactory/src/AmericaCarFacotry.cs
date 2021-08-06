﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Design.AbstractFactory
{
    public class AmericaCarFacotry : CarFactory
    {
        public override Car GetCar()
        {
            return new AmericaCar();
        }
    }
}
