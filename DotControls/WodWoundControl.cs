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

        public WodWoundControl() {
            InitializeComponent();
            this.FlowPanel.Controls.Add(WoundCheckbox);
            WoundCheckbox.Size = new Size(23, 23);
        }

        public WodWoundControl(string name, int penalty, int woundStates) {
            InitializeComponent();
            WoundName.Text = name;
            WoundPenalty.Text = penalty!=0? penalty.ToString():"";
            WoundCheckbox.State = woundStates;
        }

        private void WoundCheckbox_Click(object sender, EventArgs e) {
            RaiseUpdate((int)WoundCheckbox.State);
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

        private void WodWoundControl_Resize(object sender, EventArgs e) {
            WoundName.Padding = new Padding(WoundName.Padding.Left, WoundName.Padding.Top,
                this.ClientSize.Width - this.Padding.Horizontal - this.Margin.Horizontal 
                    - WoundName.Margin.Horizontal - WoundName.Padding.Horizontal
                    - WoundCheckbox.Width - WoundCheckbox.Padding.Horizontal
                    - WoundPenalty.Width - WoundPenalty.Padding.Horizontal
                    - System.Windows.Forms.SystemInformation.VerticalScrollBarWidth,
                WoundName.Padding.Bottom);
        }

    }
}
