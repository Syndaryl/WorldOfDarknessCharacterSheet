using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syndaryl.Windows.Forms {
    public class WoundStateChangeEventArgs : EventArgs {
        public Byte WoundState { get; set; }
    }
}
