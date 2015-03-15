using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Syndaryl.Windows.Forms {

    public class NameTextEventArgs : EventArgs {
        #region Fields
        private string text;
        #endregion Fields

        #region Constructors
        public NameTextEventArgs(string traitText = "") {
            TraitText = traitText;
        }
        #endregion Constructors

        #region Properties
        public string TraitText {
            get { return text; }
            set { text = value; }
        }
        #endregion Properties
    }
}
