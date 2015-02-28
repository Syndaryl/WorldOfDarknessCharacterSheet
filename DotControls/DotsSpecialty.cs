using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Games.RPG.WoDCharacterData;

namespace Syndaryl.Windows.Forms
{
    public partial class DotsSpecialty : UserControl
    {
        private string Label;
        private string Specialty;
        private Bounded<int> Dots;

        public DotsSpecialty() : this(label: "", specialty: "", dotsmax: 5, dotsmin: 1, dots: 1) {
        }

        public DotsSpecialty(string label = "Trait", string specialty = "", int dotsmax = 5, int dotsmin = 1, int dots = 1)
        {
            this.Label = label;
            this.Specialty = specialty;
            this.Dots = new Bounded<int>(dots, minimum: dotsmin, maximum: dotsmax);

            InitializeComponent();
            this.label1.Text = Label;
            this.dotsGroup1.Dots = Dots.Max;
            this.textBox1.Text = specialty;
            dotsGroup1.SetupDotsTable();
        }

        public event EventHandler<NameTextRatingEventArgs> OnUpdate;

        private void RaiseUpdate(string specialty, int rating) {
            EventHandler<NameTextRatingEventArgs> handler = OnUpdate;
            if (handler != null) {
                handler(null, new NameTextRatingEventArgs(Dots, Specialty));
            }
        }

    }
}
