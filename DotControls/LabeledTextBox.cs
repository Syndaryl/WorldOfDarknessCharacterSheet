using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndaryl.Windows.Forms
{
    public partial class LabeledTextBox : UserControl
    {
        public LabeledTextBox()
        {
            InitializeComponent();
            Label.Size = Label.PreferredSize;
        }

        public LabeledTextBox(string label, string text, Control parent = null, bool bold=true) {
            InitializeComponent();
            if (parent != null) {
                parent.Controls.Add(this);
                Label.Font = new Font(Label.Parent.Font.FontFamily, Label.Parent.Font.Size, bold ? FontStyle.Bold : FontStyle.Regular);
            }
            this.Label.Text = label;
            this.Entry.Text = text;
            Label.Size = Label.PreferredSize;
            Entry.Left = Label.Right + Entry.Margin.Left + Label.Margin.Right;
            if (parent != null)
                Entry.Width = (parent.Width - parent.Padding.Horizontal - Label.Width - Label.Padding.Horizontal);
            this.Size = this.PreferredSize;
        }

        #region Events
        public event EventHandler<NameTextEventArgs> OnEntryUpdate;
        private void RaiseUpdate(string specialty) {
            EventHandler<NameTextEventArgs> handler = OnEntryUpdate;
            if (handler != null) {
                handler(null, new NameTextEventArgs(specialty));
            }
        }

        private void Entry_TextChanged(object sender, EventArgs e) {
            RaiseUpdate(Entry.Text);
        }

        #endregion Events

        #region Method Overrides
        public override Size GetPreferredSize(Size proposedSize) {
            //return base.GetPreferredSize(proposedSize);
            if (proposedSize.Equals(new Size(0,0)) && Parent != null) {
                return new Size(
                    width: Math.Max(Label.PreferredSize.Width + Entry.Width + this.Margin.Horizontal, Parent.Width - Parent.Padding.Horizontal),
                    height: Math.Max(Label.PreferredHeight + Label.Margin.Vertical, Entry.PreferredHeight + Entry.Margin.Vertical) + this.Margin.Vertical
                    );
            }
            else
                return new Size(
                    width: Math.Max(Label.PreferredSize.Width + Entry.Width + this.Margin.Horizontal, proposedSize.Width),
                    height: Math.Max(Label.PreferredHeight + Label.Padding.Vertical, Entry.PreferredHeight + Entry.Padding.Vertical) + this.Margin.Vertical
                    );
        }

        #endregion Method Overrides
    }
}
