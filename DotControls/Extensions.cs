using System;
using System.Collections.Generic;
using System.Drawing;
using System.Windows.Forms;


namespace Syndaryl.Windows.Forms.Extensions {
    public static class Extensions {
        public static Point TopLeft(this Control @this) {
            return new Point(@this.Left, @this.Top);
        }
        public static Point TopRight(this Control @this) {
            return new Point(@this.Right, @this.Top);
        }
        public static Point BottomLeft(this Control @this) {
            return new Point(@this.Left, @this.Bottom);
        }
        public static Point BottomRight(this Control @this) {
            return new Point(@this.Right, @this.Bottom);
        }
        public static Point BottomCenter(this Control @this) {
            return new Point((@this.Left + @this.Right) / 2, @this.Bottom);
        }
        public static Point TopCenter(this Control @this) {
            return new Point((@this.Left + @this.Right) / 2, @this.Bottom);
        }
        public static Point LeftCenter(this Control @this) {
            return new Point(@this.Left, (@this.Top + @this.Bottom) / 2);
        }
        public static Point RightCenter(this Control @this) {
            return new Point(@this.Right, (@this.Top + @this.Bottom) / 2);
        }


    }
}
