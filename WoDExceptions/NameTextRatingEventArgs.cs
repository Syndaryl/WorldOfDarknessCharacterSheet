using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Syndaryl.Windows.Forms {

    public class NameTextRatingEventArgs : EventArgs {
        #region Fields
        private string text;
        private int tvalue;
        #endregion Fields

        #region Constructors
        public NameTextRatingEventArgs(int value, string traitText = "") {
            TraitText = traitText;
            Value = value;
        }
        #endregion Constructors

        #region Properties
        public string TraitText {
            get { return text; }
            set { text = value; }
        }

        public int Value {
            get { return tvalue; }
            set { tvalue = value; }
        }
        #endregion Properties
    }
}
