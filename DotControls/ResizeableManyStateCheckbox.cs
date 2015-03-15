using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Syndaryl.Windows.Forms {
    public partial class ResizeableManyStateCheckbox : Control, IButtonControl {
        public uint State { get; set; }
        public uint MaxState { get; set; }
        public bool IsDefault { get; set; }

        public Rectangle BoxRectangle {
            get {
                Rectangle R = ClientRectangle;
                R.Inflate(new Size(-2, -2));
                return R;
            }
        }

        private ImageList Images { get; set; }    
        
        private DialogResult myDialogResult;
        private Pen drawPen;


        public ResizeableManyStateCheckbox() : base() {
            Images = new ImageList();
            drawPen = new Pen(System.Drawing.Brushes.Black, 4);
        }

        public DialogResult DialogResult {
            get {
                return this.myDialogResult;
            }

            set {
                if (Enum.IsDefined(typeof(DialogResult), value)) {
                    this.myDialogResult = value;
                }
            }
        }

        protected override void OnPaint(PaintEventArgs e) {
            base.OnPaint(e);
            using (Graphics g = e.Graphics) {
                g.DrawLine(Pens.Blue, this.Left, this.Top, this.Right, this.Bottom);
                g.DrawRectangle(drawPen, this.BoxRectangle);
            }
        }

        public void NotifyDefault(bool value) {
            if (this.IsDefault != value) {
                this.IsDefault = value;
            }
        }

        private void RotateWoundState() {
            if (State == MaxState) State = 0;
            else State++;
            this.Invalidate();
            RaiseUpdate(State);
        }

        public void PerformClick() {
            if (this.CanSelect) {
                this.OnClick(EventArgs.Empty);
            }
        }
        #region Events
        public event EventHandler<WoundStateChangeEventArgs> WoundUpdate;
        private void RaiseUpdate(uint value) {
            EventHandler<WoundStateChangeEventArgs> handler = WoundUpdate;
            if (handler != null) {
                handler(null, new WoundStateChangeEventArgs((byte)value));
            }
        }

        #endregion Events
    }
}
