using System;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Syndaryl.Games.CharacterGeneration.WorldOfDarkness
{
    class RadioButtonWithCount : RadioButton
    {
        public int Index
        {
            get;
            set;
        }
        public RadioButtonWithCount()
            : this(0)
        {
        }

        public RadioButtonWithCount (int index) : base()
        {
            this.Index = index;
            this.Text = "";
            this.Width = 10;
        }
    }
}
