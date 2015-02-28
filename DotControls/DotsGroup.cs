using System;
using System.ComponentModel;
using System.ComponentModel.Design;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing;
using Syndaryl.Games.CharacterGeneration.WorldOfDarkness.DotControls;
using Syndaryl.Games.CharacterGeneration.WorldOfDarkness.Helpers;

namespace Syndaryl.Games.CharacterGeneration.WorldOfDarkness
{

    //[DesignerAttribute(typeof(DotsGroupControlDesigner))]
    //[ToolboxItem(typeof(DotsGroupToolboxItem))]
    public class DotsGroup : TableLayoutPanel
    {
        public int Dots { get; set; }
        internal RadioButtonWithCount[] radioButtons;
        public DotsGroup()
            : this(5, 1)
        {
        }
        public DotsGroup ( int dots, float scale = 1 ) : base()
        {
            Dots = dots;
            GrowStyle = TableLayoutPanelGrowStyle.AddColumns;
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

            for (int d = 0; d < Dots; d++)
            {
                radioButtons[d] = new RadioButtonWithCount(d);
                radioButtons[d].CheckAlign = ContentAlignment.TopCenter;
                radioButtons[d].AutoCheck = false;
                radioButtons[d].Click += DotsGroup_Click;
                radioButtons[d].Text = "";
                this.Controls.Add(radioButtons[d]);
                factor = new SizeF(1.5F, 1.5F);
                radioButtons[d].Scale(factor);
            }
            Width = radioButtons[0].Width * Dots;
            Height = radioButtons[0].Height;
            this.FillRowStyles(SizeType.AutoSize, 1);
            this.FillColumnStyles(SizeType.Percent, colWidth);
            ResumeLayout();
        }

        public void DotsGroup_Click(object sender, EventArgs e)
        {
            RadioButtonWithCount button = (RadioButtonWithCount)sender;
            //button.Checked = !button.Checked;
            for (int i = 0; i <= button.Index; i++)
            {
                radioButtons[i].Checked = true;
            }
            for (int i = button.Index+1; i < radioButtons.Count(); i++)
            {
                radioButtons[i].Checked = false;
            }
        }
    }
}
