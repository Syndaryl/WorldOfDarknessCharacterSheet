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
            this.FlowPanel = new System.Windows.Forms.FlowLayoutPanel();
            this.WoundName = new System.Windows.Forms.Label();
            this.WoundPenalty = new System.Windows.Forms.Label();
            this.WoundCheckbox = new WoDWoundCheckboxButton();
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
            this.FlowPanel.Size = new System.Drawing.Size(204, 71);
            this.FlowPanel.TabIndex = 0;
            // 
            // WoundName
            // 
            this.WoundName.AutoSize = true;
            this.WoundName.Font = new System.Drawing.Font("Microsoft Sans Serif", 10.8F);
            this.WoundName.Location = new System.Drawing.Point(3, 0);
            this.WoundName.Name = "WoundName";
            this.WoundName.Padding = new System.Windows.Forms.Padding(3, 7, 3, 7);
            this.WoundName.Size = new System.Drawing.Size(52, 32);
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
            this.WoundPenalty.Padding = new System.Windows.Forms.Padding(25, 7, 25, 7);
            this.WoundPenalty.Size = new System.Drawing.Size(66, 32);
            this.WoundPenalty.TabIndex = 1;
            this.WoundPenalty.Text = "0";
            this.WoundPenalty.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            // 
            // WoundCheckbox
            // 
            this.WoundCheckbox.Location = new System.Drawing.Point(131, 1);
            this.WoundCheckbox.Margin = new System.Windows.Forms.Padding(1);
            this.WoundCheckbox.MaximumSize = new System.Drawing.Size(65, 65);
            this.WoundCheckbox.MinimumSize = new System.Drawing.Size(65, 65);
            this.WoundCheckbox.Name = "WoundCheckbox";
            this.WoundCheckbox.Padding = new System.Windows.Forms.Padding(3);
            this.WoundCheckbox.Size = new System.Drawing.Size(65, 65);
            this.WoundCheckbox.TabIndex = 2;
            this.WoundCheckbox.Click += new System.EventHandler(this.WoundCheckbox_Click);
            // 
            // WodWoundControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.FlowPanel);
            this.Name = "WodWoundControl";
            this.Size = new System.Drawing.Size(204, 71);
            this.FlowPanel.ResumeLayout(false);
            this.FlowPanel.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.FlowLayoutPanel FlowPanel;
        private System.Windows.Forms.Label WoundName;
        private System.Windows.Forms.Label WoundPenalty;
        private WoDWoundCheckboxButton WoundCheckbox;


    }
}
