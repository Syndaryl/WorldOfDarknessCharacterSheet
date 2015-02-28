namespace Syndaryl.Windows.Forms
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
            this.Label.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.Label.AutoEllipsis = true;
            this.Label.Location = new System.Drawing.Point(0, 0);
            this.Label.Name = "Label";
            this.Label.Size = new System.Drawing.Size(76, 29);
            this.Label.TabIndex = 0;
            this.Label.Text = "label1";
            this.Label.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // Entry
            // 
            this.Entry.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.Entry.BackColor = System.Drawing.SystemColors.Window;
            this.Entry.Location = new System.Drawing.Point(82, 0);
            this.Entry.Name = "Entry";
            this.Entry.Size = new System.Drawing.Size(108, 20);
            this.Entry.TabIndex = 1;
            this.Entry.WordWrap = false;
            this.Entry.TextChanged += new System.EventHandler(this.Entry_TextChanged);
            // 
            // LabeledTextBox
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Entry);
            this.Controls.Add(this.Label);
            this.Name = "LabeledTextBox";
            this.Size = new System.Drawing.Size(196, 29);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label Label;
        private System.Windows.Forms.TextBox Entry;
    }
}
