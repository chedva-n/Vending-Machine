using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.SupplierObserver
{
    public class Supplier:IObserver
    {
      
        public void Update(Product product)
        {
           MessageBox.Show($"Stock is { product.Name} running out");
            //product.Amount += 30;
        }
    }
}
