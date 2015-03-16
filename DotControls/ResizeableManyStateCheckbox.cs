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
        #region Properties
        public uint State { get; set; }
        public uint MaxState { get; set; }

        public bool IsDefault { get; set; }

        protected Rectangle BoxRectangle {
            get {
                Rectangle R = ClientRectangle;
                R.Inflate(new Size(-2, -2));
                return R;
            }
        }

        protected ImageList Images { get; set; }

        public List<List<Point>> Points { get; set; } 
        
        private DialogResult myDialogResult;
        protected Pen drawPen;

        #endregion Properties

        public ResizeableManyStateCheckbox() : base() {
            Images = new ImageList();
            drawPen = new Pen(System.Drawing.Brushes.Black, 4);
            Points = new List<List<Point>>();
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
                g.DrawRectangle(drawPen, this.BoxRectangle);
                if (Points.Count > (int)State && Points[(int)State].Count > 0)
                    g.DrawPolygon(drawPen, Points[(int)State].ToArray());
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
