using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.State
{
    public class Wrapper : State
    {
        public Wrapper(Form1 form) : base(form)
        {
            form.Wrapper();
        }
        public override void Handle(Context contex)
        {
            contex.state = new Payment(form);
        }
    }
}
