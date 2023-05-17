using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.SupplierObserver
{
    public class Subject : ISubject
    {
        private List<IObserver> observers;
        public Subject()
        {
            this.observers = new List<IObserver>();
        }
        public void Attach(IObserver observer)
        {
            this.observers.Add(observer);
        }

        public void Detach(IObserver observer)
        {
            this.observers.Remove(observer);
        }

        public void Notify(Product updateProduct)
        {
            foreach (var observer in observers)
            {
                observer.Update(updateProduct);
            }
        }

       
    }
}
