using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Syndaryl.Windows.Forms {
    public partial class DoubleClickRadioButton : System.Windows.Forms.RadioButton {
        public DoubleClickRadioButton() {
            InitializeComponent();

            this.SetStyle(ControlStyles.StandardClick | ControlStyles.StandardDoubleClick, true);
        }

        [EditorBrowsable(EditorBrowsableState.Always), Browsable(true)]
        public new event MouseEventHandler MouseDoubleClick;

        protected override void OnMouseDoubleClick(MouseEventArgs e) {
            base.OnMouseDoubleClick(e);

            // raise the event
            if (this.MouseDoubleClick != null)
                this.MouseDoubleClick(this, e);
        }
    }
}
