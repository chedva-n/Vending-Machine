using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.State
{
    public class Selection : State

    {

        public Selection(Form1 form):base(form)
        {
            form.Selection();
        }
        public override void Handle(Context contex)
        {
            //Product selectedProduct = form.
            contex.state = new Wrapper(form);
        }
    }
}
