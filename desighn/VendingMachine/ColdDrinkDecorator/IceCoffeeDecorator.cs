using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.ColdDrinkDecorator
{
    public abstract class IceCoffeeDecorator : IceCoffee
    {
        protected IceCoffee iceCoffee { get; set; }

        public IceCoffeeDecorator(IceCoffee iceCoffee)
        {
            this.iceCoffee = iceCoffee;
        }
        public override int GetCost()
        {
           return iceCoffee.GetCost();
        }
    }
}
