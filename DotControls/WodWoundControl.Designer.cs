namespace Syndaryl.Windows.Forms {
    partial class WodWoundControl {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing) {
            if (disposing && (components != null)) {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent() {
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WodWoundControl));
            this.WoundName = new System.Windows.Forms.Label();
            this.WoundPenalty = new System.Windows.Forms.Label();
            this.WoundCheckbox = new Syndaryl.Windows.Forms.WodWoundManystateCheckbox();
            this.SuspendLayout();
            // 
            // WoundName
            // 
            this.WoundName.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.WoundName.AutoSize = true;
            this.WoundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.WoundName.Location = new System.Drawing.Point(2, 0);
            this.WoundName.Name = "WoundName";
            this.WoundName.Padding = new System.Windows.Forms.Padding(3);
            this.WoundName.Size = new System.Drawing.Size(52, 24);
            this.WoundName.TabIndex = 3;
            this.WoundName.Text = "label1";
            this.WoundName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WoundPenalty
            // 
            this.WoundPenalty.AutoSize = true;
            this.WoundPenalty.Dock = System.Windows.Forms.DockStyle.Right;
            this.WoundPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.WoundPenalty.Location = new System.Drawing.Point(151, 0);
            this.WoundPenalty.Name = "WoundPenalty";
            this.WoundPenalty.Padding = new System.Windows.Forms.Padding(25, 3, 25, 3);
            this.WoundPenalty.Size = new System.Drawing.Size(66, 24);
            this.WoundPenalty.TabIndex = 4;
            this.WoundPenalty.Text = "0";
            this.WoundPenalty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WoundCheckbox
            // 
            this.WoundCheckbox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.WoundCheckbox.Dock = System.Windows.Forms.DockStyle.Right;
            this.WoundCheckbox.IsDefault = false;
            this.WoundCheckbox.Location = new System.Drawing.Point(217, 0);
            this.WoundCheckbox.MaxState = 3;
            this.WoundCheckbox.Name = "WoundCheckbox";
            this.WoundCheckbox.Points = ((System.Collections.Generic.List<System.Collections.Generic.List<System.Drawing.Point>>)(resources.GetObject("WoundCheckbox.Points")));
            this.WoundCheckbox.Size = new System.Drawing.Size(28, 28);
            this.WoundCheckbox.State = 0;
            this.WoundCheckbox.TabIndex = 5;
            this.WoundCheckbox.Text = "wodWoundManystateCheckbox1";
            // 
            // WodWoundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.WoundName);
            this.Controls.Add(this.WoundPenalty);
            this.Controls.Add(this.WoundCheckbox);
            this.Name = "WodWoundControl";
            this.Size = new System.Drawing.Size(245, 28);
            this.Resize += new System.EventHandler(this.WodWoundControl_Resize);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label WoundName;
        private System.Windows.Forms.Label WoundPenalty;
        private WodWoundManystateCheckbox WoundCheckbox;



    }
}
