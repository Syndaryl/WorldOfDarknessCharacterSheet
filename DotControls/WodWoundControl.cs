using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Games.RPG.WoDCharacterData;

namespace Syndaryl.Windows.Forms {
    public partial class WodWoundControl : UserControl {
        private int woundStates;

        public WodWoundControl() {
            InitializeComponent();
        }

        public WodWoundControl(string name, int penalty, int woundStates) {
            WoundName.Text = name;
            WoundPenalty.Text = penalty!=0? penalty.ToString():"";
            this.woundStates = woundStates;
        }

        private void WoundCheckbox_Click(object sender, EventArgs e) {
            RaiseUpdate((int)WoundCheckbox.WoundState);
        }

        #region Events
        public event EventHandler<WoundStateChangeEventArgs> OnCheck;
        private void RaiseUpdate(int value) {
            EventHandler<WoundStateChangeEventArgs> handler = OnCheck;
            if (handler != null) {
                handler(null, new WoundStateChangeEventArgs(value));
            }
        }

        #endregion Events

    }
}
