using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.SupplierObserver
{
    public interface IObserver
    {
      public  void Update(Product product);
    }
}
