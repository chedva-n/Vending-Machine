using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachine.SupplierObserver
{
    public class Supplier:IObserver
    {
        //VendingMachine vendingMachine = new VendingMachine();

        public void Update(Product product)
        {
           MessageBox.Show($"Stock is { product.Name} running out");
            if(product is Drink)
            {
                VendingMachine.drinks[(Drink)product] += 10;
            }
            else
            {
                VendingMachine.snacksAndBottles[(SnacksAndBottles)product] += 10;
            }
            
        }
    }
}
