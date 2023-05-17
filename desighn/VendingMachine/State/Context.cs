using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace VendingMachine.State
{
    public class Context
    {
        public State state { get; set; }
        public Context(State state)
        {
            this.state = state;
        }
        public void Request()
        {
            state.Handle(this);
        }
    }
}
