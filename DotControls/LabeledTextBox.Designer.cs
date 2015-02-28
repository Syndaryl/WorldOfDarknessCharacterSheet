namespace Syndaryl.Games.CharacterGeneration.WorldOfDarkness.DotControls
{
    partial class LabeledTextBox
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.Label = new System.Windows.Forms.Label();
            this.Entry = new System.Windows.Forms.TextBox();
            this.SuspendLayout();
            // 
            // Label
            // 
            this.Label.AutoSize = true;
            this.Label.Location = new System.Drawing.Point(3, 3);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(35, 13);
            this.Label.TabIndex = 0;
            this.Label.Text = "label1";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Entry
            // 
            this.Entry.Dock = System.Windows.Forms.DockStyle.Right;
            this.Entry.Location = new System.Drawing.Point(88, 0);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(181, 20);
            this.Entry.TabIndex = 1;
            // 
            // LabeledTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Entry);
            this.Controls.Add(this.Label);
            this.Name = "LabeledTextBox";
            this.Size = new System.Drawing.Size(269, 20);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox Entry;
    }
}
