using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.State
{
    public abstract class State
    {
         protected Form1 form;

        public State(Form1 form)
        {
            this.form = form;
        }
        public abstract void Handle(Context contex);
      
    }
}
