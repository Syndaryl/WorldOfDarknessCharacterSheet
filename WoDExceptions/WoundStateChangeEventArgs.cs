using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syndaryl.Windows.Forms {
    public class WoundStateChangeEventArgs : EventArgs {

        public WoundStateChangeEventArgs(Byte State) {
            this.WoundState = State;
        }

        public WoundStateChangeEventArgs(int State) {
            this.WoundState = (Byte)State;
        }
        public Byte WoundState { get; set; }
    }
}
