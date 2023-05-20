﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.ColdDrinkDecorator
{
    public class IceCoffee : Drink
    {
        public IceCoffee()
        {
            this.Price = 10;
        }
        public virtual int GetCost()
        {
            return this.Price;
        }
    }
}
