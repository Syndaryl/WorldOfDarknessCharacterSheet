using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndaryl.Games.CharacterGeneration.WorldOfDarkness
{
    public partial class DotsSpecialty : UserControl
    {
        private string Label;
        private string Specialty;
        private int DotsMax;
        private int Dots;

        public DotsSpecialty() : this("","", 5, 1)
        {
        }

        public DotsSpecialty(string label = "Trait", string specialty = "", int dotsmax = 5, int dots = 1)
        {
            this.Label = label;
            this.Specialty = specialty;
            this.DotsMax = dotsmax;
            this.Dots = dots;

            InitializeComponent();
            this.label1.Text = Label;
            this.dotsGroup1.Dots = DotsMax;
            this.textBox1.Text = specialty;
            dotsGroup1.SetupDotsTable();
        }

    }
}
