using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Syndaryl.Windows.Forms;
using Syndaryl.Games.CharacterGeneration.WorldOfDarkness.Helpers;

namespace Syndaryl.Windows.Forms
{

    //[DesignerAttribute(typeof(DotsGroupControlDesigner))]
    //[ToolboxItem(typeof(DotsGroupToolboxItem))]
    public class DotsGroup : TableLayoutPanel
    {
        public int Dots { get; set; }
        public bool CanBeZero { get; set; }
        System.Windows.Forms.ToolTip ToolTip;

        internal RadioButtonWithCount[] radioButtons;
        public DotsGroup()
            : this(5, 1)
        {
        }
        public DotsGroup ( int dots, float scale = 1 ) : base()
        {
            Dots = dots;
            GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
            CanBeZero = false;
            ToolTip = new System.Windows.Forms.ToolTip();
        }

        public void SetupDotsTable()
        {
            radioButtons = new RadioButtonWithCount[Dots];

            this.Width = 15;
            this.Height = 15;
            this.AutoSize = true;
            this.SetAutoSizeMode(AutoSizeMode.GrowOnly);

            SuspendLayout();
            float colWidth = 1 / Dots;
            //this.RowStyles.Clear();
            this.RowCount = 1;
            this.ColumnCount = Dots;
            // ColumnStyle colStyle = new ColumnStyle(SizeType.Percent, colWidth);

            SizeF factor;
            factor = new SizeF(1.5F, 1.5F);
            Padding noPadding = new Padding(0);
            for (int d = 0; d < Dots; d++)
            {
                MakeRadioButton(noPadding, d);
            }
            Width = radioButtons[0].Width * Dots;
            Height = radioButtons[0].Height;
            this.FillRowStyles(SizeType.AutoSize, 1);
            this.FillColumnStyles(SizeType.Percent, colWidth);
            //SetRadioButtons(Dots-1);
            ResumeLayout();
        }

        private RadioButtonWithCount MakeRadioButton(Padding padding, int d) {
            radioButtons[d] = new RadioButtonWithCount(d);
            radioButtons[d].CheckAlign = ContentAlignment.TopCenter;
            radioButtons[d].AutoCheck = false;
            radioButtons[d].MouseClick += DotsGroup_Click;
            //radioButtons[d].MouseDoubleClick += DotsGroup_DoubleClick;
            radioButtons[d].Text = "";
            radioButtons[d].Margin = padding;
            radioButtons[d].Padding = padding;
            if (CanBeZero)
                ToolTip.SetToolTip(radioButtons[d], "CTRL-Click to Uncheck");
            this.Controls.Add(radioButtons[d]);
            return radioButtons[d];
        }

        internal void SetRadioButtons(int index) {

            //button.Checked = !button.Checked;
            for (int i = 0; i <= index; i++) {
                radioButtons[i].Checked = true;
            }
            for (int i = index + 1; i < radioButtons.Count(); i++) {
                radioButtons[i].Checked = false;
            }
            RaiseUpdate(index + 1);
        }

        #region Events and Event Handlers

        private void DotsGroup_DoubleClick(object sender, EventArgs e) {
            // Never gets called, sadpanda
            RadioButtonWithCount button = (RadioButtonWithCount)sender;
            lock (radioButtons) { 
                if (CanBeZero)
                    SetRadioButtons(button.Index - 1);
                else
                    SetRadioButtons(Math.Max(button.Index - 1,0));
            }
        }

        //private void DotsGroup_Click(object sender, MouseEventArgs e) {
        //    throw new NotImplementedException();
        //}

        public void DotsGroup_Click(object sender, MouseEventArgs e) {
            RadioButtonWithCount button = (RadioButtonWithCount)sender;
            lock (radioButtons) {
                if (e.Button == System.Windows.Forms.MouseButtons.Left && ModifierKeys == Keys.Control) {
                    if (CanBeZero)
                        SetRadioButtons(button.Index - 1);
                    else
                        SetRadioButtons(Math.Max(button.Index - 1, 0));
                }
                else
                    SetRadioButtons(button.Index);
            }
        }

        public event EventHandler<NumericChangeEventArgs> OnEntryUpdate;
        private void RaiseUpdate(int value) {
            EventHandler<NumericChangeEventArgs> handler = OnEntryUpdate;
            if (handler != null) {
                handler(null, new NumericChangeEventArgs(value));
            }
        }

        #endregion Events and Event Handlers
    }
}
