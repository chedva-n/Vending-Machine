using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.BuilderHotDrink
{
    public class HotDrinkBuilder : IBuilder
    {
        private HotDrink hotDrink = new HotDrink();
        public HotDrinkBuilder()
        {
            this.Reset();
        }
        public void Reset()
        {
            this.hotDrink = new HotDrink();
        }
        public void AddChocolate()
        {
            this.hotDrink.Ingredients.Add("chocolate");
        }

        public void AddCoffee()
        {
            this.hotDrink.Ingredients.Add("coffee");
        }

        public void AddMilk()
        {
            this.hotDrink.Ingredients.Add("milk");
        }

        public void AddShoko()
        {
            this.hotDrink.Ingredients.Add("shoko");

        }

        public void AddSugar()
        {
            this.hotDrink.Ingredients.Add("sugar");

        }

        public void AddWater()
        {
            this.hotDrink.Ingredients.Add("water");

        }

        public void AddWhippedmilk()
        {

            this.hotDrink.Ingredients.Add("whipped milk");
        }
        public HotDrink getDrink()
        {
            HotDrink result = this.hotDrink;
            this.Reset();
            return result;
        }

    }
}
