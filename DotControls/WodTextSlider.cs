using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using Syndaryl.Windows.Forms;

namespace Games.RPG.WoDSheet
{
    public partial class WodTextSlider : UserControl
    {
        private WoDCharacterData.Bounded<int> Rating;
        private int preferredHeight = 25;
        private int preferredWidth = 350;
        public int PreferredHeight
        {
            get
            {
                //preferredHeight = 0;
                //foreach (System.Windows.Forms.Control item in this.Flow.Controls)
                //{
                //    preferredHeight = Math.Max(preferredHeight,(item.Height));
                //}
                //preferredHeight += 10;
                //return preferredHeight;
                return this.Flow.PreferredSize.Height;
            }
        }
        public int PreferredWidth
        {
            get
            {
                //preferredWidth = 0;
                //foreach (System.Windows.Forms.Control item in this.Flow.Controls)
                //{
                //    preferredWidth += item.Width;
                //}
                //return preferredWidth;
                return this.Flow.PreferredSize.Width;
            }
        }

        public WodTextSlider()
        {
            InitializeComponent();
        }

        public WodTextSlider(string Specialty, WoDCharacterData.Bounded<int> Rating)
        {
            if (Rating == null)
                Rating = new WoDCharacterData.Bounded<int>(0, 0, 5);
            this.Rating = Rating;
            InitializeComponent();
            textBoxSpecialty.Text = Specialty;
            UpdateTrackbar();
        }

        private void UpdateTrackbar()
        {
            trackBarScore.Minimum = this.Rating.Min;
            trackBarScore.Maximum = this.Rating.Max;
            trackBarScore.Value = this.Rating.Value;
            labelValue.Text = this.Rating.Value.ToString();
        }

        private void trackBarScore_Scroll(object sender, EventArgs e)
        {
            labelValue.Text = trackBarScore.Value.ToString();
            RaiseUpdate(trackBarScore.Value, textBoxSpecialty.Text);
        }

        private void textBoxSpecialty_TextChanged(object sender, EventArgs e)
        {
            RaiseUpdate(trackBarScore.Value, textBoxSpecialty.Text);
        }

        #region Events
        public event EventHandler<NameTextRatingEventArgs> OnUpdate;
        private void RaiseUpdate(int value, string specialty)
        {
            EventHandler<NameTextRatingEventArgs> handler = OnUpdate;
            if (handler != null)
            {
                handler(null, new NameTextRatingEventArgs(value, specialty));
            }
        }

        #endregion Events

    }

}
