using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;


namespace VendingMachine.State
{
    public class Payment : State
    {
        public Payment(Form1 form) : base(form)
        {
            form.Payment();
        }
        public override void Handle(Context contex)
        {
            MessageBox.Show("hi");
            contex.state = new Selection(form);
        }
    }
}
