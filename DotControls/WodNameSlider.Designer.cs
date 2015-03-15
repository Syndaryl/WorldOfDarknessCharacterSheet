namespace Games.RPG.WoDSheet
{
    partial class WodNameSlider
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
            this.labelTrait = new System.Windows.Forms.Label();
            this.labelValue = new System.Windows.Forms.Label();
            this.trackBarScore = new System.Windows.Forms.TrackBar();
            this.Flow.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScore)).BeginInit();
            this.SuspendLayout();
            // 
            // Flow
            // 
            this.Flow.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Flow.Controls.Add(this.labelTrait);
            this.Flow.Controls.Add(this.labelValue);
            this.Flow.Controls.Add(this.trackBarScore);
            this.Flow.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Flow.Location = new System.Drawing.Point(0, 0);
            this.Flow.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Flow.Name = "Flow";
            this.Flow.Size = new System.Drawing.Size(466, 131);
            this.Flow.TabIndex = 3;
            // 
            // labelTrait
            // 
            this.labelTrait.AutoSize = true;
            this.labelTrait.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelTrait.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelTrait.Location = new System.Drawing.Point(4, 0);
            this.labelTrait.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.labelTrait.Name = "labelTrait";
            this.labelTrait.Size = new System.Drawing.Size(160, 37);
            this.labelTrait.TabIndex = 0;
            this.labelTrait.Text = "Trait Name";
            this.labelTrait.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // labelValue
            // 
            this.labelValue.AutoSize = true;
            this.labelValue.Dock = System.Windows.Forms.DockStyle.Fill;
            this.labelValue.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.labelValue.Location = new System.Drawing.Point(174, 0);
            this.labelValue.Margin = new System.Windows.Forms.Padding(6, 0, 6, 0);
            this.labelValue.Name = "labelValue";
            this.labelValue.Size = new System.Drawing.Size(33, 37);
            this.labelValue.TabIndex = 4;
            this.labelValue.Text = "1";
            this.labelValue.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // trackBarScore
            // 
            this.trackBarScore.Location = new System.Drawing.Point(4, 41);
            this.trackBarScore.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.trackBarScore.Maximum = 5;
            this.trackBarScore.Name = "trackBarScore";
            this.trackBarScore.Size = new System.Drawing.Size(446, 90);
            this.trackBarScore.TabIndex = 2;
            this.trackBarScore.Value = 1;
            this.trackBarScore.Scroll += new System.EventHandler(this.trackBarScore_Scroll);
            // 
            // WodNameSlider
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(12F, 25F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSizeMode = System.Windows.Forms.AutoSizeMode.GrowAndShrink;
            this.Controls.Add(this.Flow);
            this.Margin = new System.Windows.Forms.Padding(4, 4, 4, 4);
            this.Name = "WodNameSlider";
            this.Size = new System.Drawing.Size(466, 131);
            this.Flow.ResumeLayout(false);
            this.Flow.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.trackBarScore)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel Flow;
        private System.Windows.Forms.Label labelTrait;
        private System.Windows.Forms.TrackBar trackBarScore;
        private System.Windows.Forms.Label labelValue;

    }
}
