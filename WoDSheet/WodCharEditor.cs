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
    public partial class WoDCharEditor : Form
    {
        Games.RPG.WoDCharacterData.WoDCharacter Character;
        public FlowLayoutPanel LayoutManager { get; set; }

        public WoDCharEditor()
        {
            InitializeComponent();
            Character = new WoDCharacterData.WoDCharacter();
            StatusLabel.Text = "Reset to new character";
        }

        private void openToolStripButton_Click(object sender, EventArgs e)
        {
            openCharacter.ShowDialog();
            string file = openCharacter.FileName;
            //StatusBar.TextTrait = "Opening character from " + file;
            StatusLabel.Text = "Opening character from " + file;
            try
            {
                Character = new WoDCharacterData.WoDCharacter(FromFile: file);
                //LayoutManager = WoDGUIBuilder.Build(Character, LayoutManager);
                StatusLabel.Text = "Opened " + file;
            }
            catch (Exception OpeningException)
            {
                MessageBox.Show(OpeningException.ToString());
                Character = null;
                StatusLabel.Text = "Failed to open " + file;
            }
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {
            saveCharacter.ShowDialog();
            string file = saveCharacter.FileName;
            StatusLabel.Text = "Saving character to " + file;
            Character.Save(ToFile: file);
            StatusLabel.Text = "Saved character to " + file;
            
        }

        private void newToolStripButton_Click(object sender, EventArgs e)
        {
            Character = new WoDCharacterData.WoDCharacter();
        }

        private void TestCharacterButton_Click(object sender, EventArgs e)
        {
            try
            {
                Character = Games.RPG.WoDCharacterData.TestCharacterBuilder.TestCharacter();
                WoDGUIBuilder.Build(Character, WodFlowRoot);
                StatusLabel.Text = "Opened standard character";
            }
            catch (Exception OpeningException) {
                System.Windows.Forms.MessageBox.Show(OpeningException.ToString());
                Character = null;
                StatusLabel.Text = "Failed to open standard character!?!?";
            }
        }
    }
}
