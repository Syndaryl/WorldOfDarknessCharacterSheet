using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Drawing;
using System.Windows.Forms;
using Syndaryl.Windows.Forms.Extensions;

namespace Syndaryl.Windows.Forms {
    public class WodWoundManystateCheckbox : ResizeableManyStateCheckbox {
        public WodWoundManystateCheckbox()
            : base() {
                MaxState = 3;
                State = 0;
                for (int i = 0; i <= MaxState; i++) {
                    Points.Add( new List<Point>());
                }
                RegeneratePoints();
        }

        private void RegeneratePoints() {
            for (int i = 0; i <= MaxState; i++) {
                Points[i].Clear();
            }
            
            Points[1].Add(this.TopLeft());
            Points[1].Add(this.BottomRight());

            Points[2].Add(this.TopLeft());
            Points[2].Add(this.BottomRight());
            Points[2].Add(this.TopRight());
            Points[2].Add(this.BottomLeft());

            Points[3].Add(this.TopLeft());
            Points[3].Add(this.BottomRight());
            Points[3].Add(this.BottomCenter());
            Points[3].Add(this.TopCenter());
            Points[3].Add(this.TopRight());
            Points[3].Add(this.BottomLeft());
            Points[3].Add(this.LeftCenter());
            Points[3].Add(this.RightCenter());
        }

        protected override void OnResize(EventArgs e) {
            base.OnResize(e);
            RegeneratePoints();
            this.Invalidate();
        }
    }
}

