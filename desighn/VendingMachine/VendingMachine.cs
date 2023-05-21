using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using VendingMachine.ColdDrinkDecorator;
using VendingMachine.SupplierObserver;
using VendingMachine.BuilderHotDrink;
using VendingMachine.State;
namespace VendingMachine
{
    public class VendingMachine
    {
        public Context context { get; set; }
        public static Dictionary<SnacksAndBottles, int> snacksAndBottles;
        public static Dictionary<Drink, int> drinks;
        public Subject subject { get; set; }
        public Supplier supplier { get; set; }
        public VendingMachine()
        {
            
            drinks = new Dictionary<Drink, int>()
            {
                {new IceCoffee() { Name="Ice Coffee",Price=10 },10 },
                {new DiatIceCoffee() { Name="Diat Ice Coffee",Price=13},6 },
                {new HotDrink() { Name="Hot drink"},10 }
            };
            snacksAndBottles = new Dictionary<SnacksAndBottles, int>()
            {
            { new SnacksAndBottles(){Name="Dorituz",Price=7},6 },
            { new SnacksAndBottles(){Name="Bisli",Price=7},9 },
            { new SnacksAndBottles(){Name="Potato chips",Price=6},10 },
            { new SnacksAndBottles(){Name="Sugi",Price=3},12 },
            { new SnacksAndBottles(){Name="Bamba",Price=5},15 },
            { new SnacksAndBottles(){Name="Bonbonim",Price=7},7 },
            { new SnacksAndBottles(){Name="Popsim",Price=5},25 },
            { new SnacksAndBottles(){Name="Coca-cola",Price=10},96 },
            { new SnacksAndBottles(){Name="Coca-cola zero",Price=10},4 },
            { new SnacksAndBottles(){Name="Pepsi",Price=9},20 },
            { new SnacksAndBottles(){Name="RC cola",Price=8},27 },
            { new SnacksAndBottles(){Name="Water",Price=5},67 }
            };
            
            this.subject = new Subject();
            this.supplier = new Supplier();
            subject.Attach(supplier);
        }
        public void RemoveProduct(SnacksAndBottles product)
        {
            if (snacksAndBottles.ContainsKey(product))
            {
                snacksAndBottles[product] -= 1;
            }
            if (snacksAndBottles[product] <= 5)
            {
                subject.Notify(product);
            }
        }
        public void RemoveDrink(Drink product)
        {
            if (drinks.ContainsKey(product))
            {
                drinks[product] -= 1;
            }
            if (drinks[product] <= 5)
            {
                subject.Notify(product);
            }
        }


    }
}
