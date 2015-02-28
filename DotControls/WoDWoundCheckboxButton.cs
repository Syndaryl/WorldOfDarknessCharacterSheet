using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Games.RPG.WoDCharacterData {
    public partial class WoDWoundCheckboxButton : UserControl {

        public WoundStates WoundState;

        public WoDWoundCheckboxButton() {
            WoundState = WoundStates.Unwounded;
            InitializeComponent();
        }

        private void WoundButton_MouseClick(object sender, MouseEventArgs e) {
            RotateWoundState();
        }

        private void WoundButton_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == ' ' || e.KeyChar == '\r')
                RotateWoundState();
        }

        private void RotateWoundState() {
            WoundState++;
            if ((int)WoundState > Enum.GetValues(typeof(WoundStates)).Length) { WoundState = 0; }
            WoundButton.ImageIndex = (int)WoundState;
            RaiseUpdate(WoundState);
        }

        #region Events
        public event EventHandler<WoundStateChangeEventArgs> WoundUpdate;
        private void RaiseUpdate(WoundStates State) {
            EventHandler<WoundStateChangeEventArgs> handler = WoundUpdate;
            if (handler != null) {
                handler(null, new WoundStateChangeEventArgs(State));
            }
        }

        #endregion Events


    }
    public class WoundStateChangeEventArgs : EventArgs {
 
        #region Constructors
        public WoundStateChangeEventArgs(WoundStates Wound) {
            WoundState = Wound;
        }
        #endregion Constructors

        #region Properties
        public WoundStates WoundState { get; set; }
        #endregion Properties
    }
}
