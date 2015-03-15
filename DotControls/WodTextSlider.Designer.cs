namespace Games.RPG.WoDSheet
{
    partial class WodTextSlider
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param Name="disposing">true if managed resources should be disposed; otherwise, false.</param>
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
            this.Flow = new System.Windows.Forms.FlowLayoutPanel();
            this.textBoxSpecialty = new System.Windows.Forms.TextBox();
            this.labelValue = new System.Windows.Forms.Label();
            this.trackBarScore = new System.Windows.Forms.TrackBar();
            this.Flow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScore)).BeginInit();
            this.SuspendLayout();
            // 
            // Flow
            // 
            this.Flow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Flow.Controls.Add(this.textBoxSpecialty);
            this.Flow.Controls.Add(this.labelValue);
            this.Flow.Controls.Add(this.trackBarScore);
            this.Flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow.Location = new System.Drawing.Point(0, 0);
            this.Flow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Flow.Name = "Flow";
            this.Flow.Size = new System.Drawing.Size(466, 131);
            this.Flow.TabIndex = 3;
            // 
            // textBoxSpecialty
            // 
            this.textBoxSpecialty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBoxSpecialty.Location = new System.Drawing.Point(4, 4);
            this.textBoxSpecialty.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.textBoxSpecialty.Name = "textBoxSpecialty";
            this.textBoxSpecialty.Size = new System.Drawing.Size(226, 40);
            this.textBoxSpecialty.TabIndex = 1;
            this.textBoxSpecialty.TextChanged += new System.EventHandler(this.textBoxSpecialty_TextChanged);
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.Location = new System.Drawing.Point(240, 0);
            this.labelValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(33, 48);
            this.labelValue.TabIndex = 4;
            this.labelValue.Text = "1";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarScore
            // 
            this.trackBarScore.Location = new System.Drawing.Point(4, 52);
            this.trackBarScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarScore.Maximum = 5;
            this.trackBarScore.Name = "trackBarScore";
            this.trackBarScore.Size = new System.Drawing.Size(446, 90);
            this.trackBarScore.TabIndex = 2;
            this.trackBarScore.Value = 1;
            this.trackBarScore.Scroll += new System.EventHandler(this.trackBarScore_Scroll);
            // 
            // WodTextSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.Flow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WodTextSlider";
            this.Size = new System.Drawing.Size(466, 131);
            this.Flow.ResumeLayout(false);
            this.Flow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flow;
        private System.Windows.Forms.TextBox textBoxSpecialty;
        private System.Windows.Forms.TrackBar trackBarScore;
        private System.Windows.Forms.Label labelValue;

    }
}
