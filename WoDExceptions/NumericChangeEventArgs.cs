using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syndaryl.Windows.Forms {
    public class NumericChangeEventArgs : EventArgs {
        private int value;

        public NumericChangeEventArgs(int value) {
            // TODO: Complete member initialization
            this.value = value;
        }

        public int Value { get{
            return value;
        } set{
            this.value = value;
        } }
    }
}
