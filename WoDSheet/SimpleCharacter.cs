using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Games.RPG.WoDSheet
{
    public partial class SimpleCharacter : Form
    {
        public SimpleCharacter()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            #region Proven to work
            TextBox myText = new TextBox();
            myText.Location = new Point(25, 50);
            myText.Text = "I AM A TEST";
            this.Controls.Add(myText);
            #endregion

            #region Doesn't Work
            Label label1 = new Label(); 
            label1.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;

            label1.Text = "I AM A TEST";
            label1.Location = new Point(25, 150); 
            label1.Size = new Size(label1.PreferredWidth, label1.PreferredHeight);

            this.Controls.Add(label1);
            #endregion
        }
    }
}
