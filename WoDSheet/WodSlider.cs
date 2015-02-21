using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Games.RPG.WoDSheet
{
    public partial class WodSlider : UserControl
    {
        private WoDCharacterData.BoundedInt Rating;
        private int preferredHeight = 25;
        private int preferredWidth = 350;
        public int PreferredHeight
        {
            get
            {
                preferredHeight = 0;
                foreach (System.Windows.Forms.Control item in this.Flow.Controls)
                {
                    preferredHeight = Math.Max(preferredHeight,(item.Height));
                }
                preferredHeight += 10;
                return preferredHeight;
            }
        }
        public int PreferredWidth
        {
            get
            {
                preferredWidth = 0;
                foreach (System.Windows.Forms.Control item in this.Flow.Controls)
                {
                    preferredWidth += item.Width;
                }
                return preferredWidth;
            }
        }

        public WodSlider()
        {
            InitializeComponent();
        }

        public WodSlider(string LabelText, string SpecialtyText, WoDCharacterData.BoundedInt Rating)
        {
            this.Rating = Rating;
            InitializeComponent();
            labelTrait.Text = LabelText;
            textBoxSpecialty.Text = SpecialtyText;
            trackBarScore.Value = Rating.Value;
            trackBarScore.Minimum = Rating.Min;
            trackBarScore.Maximum = Rating.Max;
        }

        private void trackBarScore_Scroll(object sender, EventArgs e)
        {
            labelValue.Text = trackBarScore.Value.ToString();
            RaiseUpdate(trackBarScore.Value, textBoxSpecialty.Text);
        }

        private void trackBar1_Scroll(object sender, EventArgs e)
        {

        }

        private void textBoxSpecialty_TextChanged(object sender, EventArgs e)
        {
            RaiseUpdate(trackBarScore.Value, textBoxSpecialty.Text);
        }

        #region Events
        public event EventHandler<NameTextRatingEventArgs> Update;
        private void RaiseUpdate(int value, string specialty)
        {
            EventHandler<NameTextRatingEventArgs> handler = Update;
            if (handler != null)
            {
                handler(null, new NameTextRatingEventArgs(value, specialty));
            }
        }

        #endregion Events

    }
    public class NameTextRatingEventArgs : EventArgs
    {
        #region Fields
        private string text;
        private int tvalue;
        #endregion Fields

        #region Constructors
        public NameTextRatingEventArgs(int value, string traitText = "")
        {
            TraitText = traitText;
            Value = value;
        }
        #endregion Constructors

        #region Properties
        public string TraitText
        {
            get { return text; }
            set { text = value; }
        }
        #endregion Properties

        public int Value
        {
            get { return tvalue; }
            set { tvalue = value; }
        }
    }

}
