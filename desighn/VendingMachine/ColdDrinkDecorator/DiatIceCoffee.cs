using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.ColdDrinkDecorator
{
    public class DiatIceCoffee : IceCoffee
    {
        public DiatIceCoffee()
        {
            this.Price = 13;
            this.Name = "Diat Ice Coffee";
        }

        public override int GetCost()
        {
            return this.Price;
        }
    }
}
