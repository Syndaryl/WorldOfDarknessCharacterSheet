﻿using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syndaryl.Windows.Forms;
using Games.RPG.WoDCharacterData;

namespace Syndaryl.Windows.Forms {
    public partial class WoDWoundCheckboxButton : UserControl {

        public WoundStates WoundState;

        public WoDWoundCheckboxButton() {
            WoundState = WoundStates.Unwounded;
            InitializeComponent();
        }

        public WoDWoundCheckboxButton(WoundStates woundState) {
            WoundState = woundState;
        }

        private void WoundButton_MouseClick(object sender, MouseEventArgs e) {
            RotateWoundState();
        }

        private void WoundButton_KeyPress(object sender, KeyPressEventArgs e) {
            if (e.KeyChar == ' ' || e.KeyChar == '\r')
                RotateWoundState();
        }

        private void RotateWoundState() {
            if ((int)WoundState == Enum.GetValues(typeof(WoundStates)).Length-1) WoundState = 0;
                else WoundState++;
            WoundButton.ImageIndex = (int)WoundState;
            RaiseUpdate(WoundState);
        }

        #region Events
        public event EventHandler<WoundStateChangeEventArgs> WoundUpdate;
        
        private void RaiseUpdate(WoundStates State) {
            EventHandler<WoundStateChangeEventArgs> handler = WoundUpdate;
            if (handler != null) {
                handler(null, new WoundStateChangeEventArgs((byte)State));
            }
        }

        #endregion Events
    }

}
