using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.ColdDrinkDecorator
{
    public class DiatIceCoffee : IceCoffee
    {
        public override int GetCost()
        {
            return 13;
        }
    }
}
