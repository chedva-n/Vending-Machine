﻿using System;
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
        public Dictionary<SnacksAndBottles, int> snacksAndBottles;
        public Dictionary<Drink, int> drinks;
        public Subject subject { get; set; }
        public Supplier supplier { get; set; }
        public VendingMachine()
        {
            
            drinks = new Dictionary<Drink, int>()
            {
                {new IceCoffee() { Name="Ice Coffee"},20 },
                {new DiatIceCoffee() { Name="Diat Ice Coffee"},20 },
                {new HotDrink() { Name="Hot drink"},20 }
            };
            snacksAndBottles = new Dictionary<SnacksAndBottles, int>()
            {
            { new SnacksAndBottles(){Name="Bamba",Price=6},6 },
            { new SnacksAndBottles(){Name="Bisli",Price=6},20 },
            { new SnacksAndBottles(){Name="Potato chips",Price=6},20 },
            { new SnacksAndBottles(){Name="Bisli",Price=6},20 },
            { new SnacksAndBottles(){Name="Bamba",Price=6},20 },
            { new SnacksAndBottles(){Name="Bisli",Price=6},20 },
            { new SnacksAndBottles(){Name="Potato chips",Price=6},20 },
            { new SnacksAndBottles(){Name="Bisli",Price=6},20 },
            { new SnacksAndBottles(){Name="Bamba",Price=6},20 },
            { new SnacksAndBottles(){Name="Bisli",Price=6},20 },
            { new SnacksAndBottles(){Name="Potato chips",Price=6},20 },
            { new SnacksAndBottles(){Name="Bisli",Price=6},20 }
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
