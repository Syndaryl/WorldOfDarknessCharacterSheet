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
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.WoundName = new System.Windows.Forms.Label();
            this.WoundPenalty = new System.Windows.Forms.Label();
            this.WoundCheckbox = new Syndaryl.Windows.Forms.WodWoundManystateCheckbox();
            this.FlowPanel.SuspendLayout();
            this.SuspendLayout();
            // 
            // FlowPanel
            // 
            this.FlowPanel.Controls.Add(this.WoundName);
            this.FlowPanel.Controls.Add(this.WoundPenalty);
            this.FlowPanel.Controls.Add(this.WoundCheckbox);
            this.FlowPanel.Dock = System.Windows.Forms.DockStyle.Fill;
            this.FlowPanel.Location = new System.Drawing.Point(0, 0);
            this.FlowPanel.Name = "FlowPanel";
            this.FlowPanel.Size = new System.Drawing.Size(204, 30);
            this.FlowPanel.TabIndex = 0;
            // 
            // WoundName
            // 
            this.WoundName.AutoSize = true;
            this.WoundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.WoundName.Location = new System.Drawing.Point(3, 0);
            this.WoundName.Name = "WoundName";
            this.WoundName.Padding = new System.Windows.Forms.Padding(3, 5, 3, 5);
            this.WoundName.Size = new System.Drawing.Size(52, 28);
            this.WoundName.TabIndex = 0;
            this.WoundName.Text = "label1";
            this.WoundName.TextAlign = System.Drawing.ContentAlignment.MiddleLeft;
            // 
            // WoundPenalty
            // 
            this.WoundPenalty.AutoSize = true;
            this.WoundPenalty.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.WoundPenalty.Location = new System.Drawing.Point(61, 0);
            this.WoundPenalty.Name = "WoundPenalty";
            this.WoundPenalty.Padding = new System.Windows.Forms.Padding(25, 5, 25, 5);
            this.WoundPenalty.Size = new System.Drawing.Size(66, 28);
            this.WoundPenalty.TabIndex = 1;
            this.WoundPenalty.Text = "0";
            this.WoundPenalty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WoundCheckbox
            // 
            this.WoundCheckbox.DialogResult = System.Windows.Forms.DialogResult.None;
            this.WoundCheckbox.IsDefault = false;
            this.WoundCheckbox.Location = new System.Drawing.Point(133, 3);
            this.WoundCheckbox.MaxState = ((uint)(3u));
            this.WoundCheckbox.Name = "WoundCheckbox";
            this.WoundCheckbox.Points = ((System.Collections.Generic.List<System.Collections.Generic.List<System.Drawing.Point>>)(resources.GetObject("WoundCheckbox.Points")));
            this.WoundCheckbox.Size = new System.Drawing.Size(25, 25);
            this.WoundCheckbox.State = ((uint)(0u));
            this.WoundCheckbox.TabIndex = 2;
            this.WoundCheckbox.Text = "wodWoundManystateCheckbox1";
            // 
            // WodWoundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlowPanel);
            this.Name = "WodWoundControl";
            this.Size = new System.Drawing.Size(204, 30);
            this.Resize += new System.EventHandler(this.WodWoundControl_Resize);
            this.FlowPanel.ResumeLayout(false);
            this.FlowPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Label WoundName;
        private System.Windows.Forms.Label WoundPenalty;
        private WodWoundManystateCheckbox WoundCheckbox;


    }
}
