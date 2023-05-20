using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.BuilderHotDrink
{
    public class HotDrink:Drink
    {
        public List<string> Ingredients { get; set; }
        public HotDrink():base() 
        {
            this.Price = 15;
            this.Name = "hot drink";
            this.Ingredients = new List<string>();
        }
        //public void showDrink()
        //{
        //    this.Ingredients.ForEach(i=>Console.WriteLine(i));
        //}
    }
}
