using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Syndaryl.Windows.Forms.Extensions {
    public static class Extensions {
        public static Point TopLeft(this Control @this) {
            return new Point(0, 0);
        }
        public static Point TopRight(this Control @this) {
            return new Point(@this.Width, 0);
        }
        public static Point BottomLeft(this Control @this) {
            return new Point(0, @this.Height);
        }
        public static Point BottomRight(this Control @this) {
            return new Point(@this.Width, @this.Height);
        }
        public static Point BottomCenter(this Control @this) {
            return new Point((0 + @this.Width) / 2, @this.Height);
        }
        public static Point TopCenter(this Control @this) {
            return new Point((0 + @this.Width) / 2, @this.Height);
        }
        public static Point LeftCenter(this Control @this) {
            return new Point(0, (0 + @this.Height) / 2);
        }
        public static Point RightCenter(this Control @this) {
            return new Point(@this.Width, (0 + @this.Height) / 2);
        }


    }
}
