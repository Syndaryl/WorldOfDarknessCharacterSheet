namespace Games.RPG.WoDCharacterData {
    partial class WoDWoundCheckboxButton {
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(WoDWoundCheckboxButton));
            this.WoundButton = new System.Windows.Forms.Button();
            this.WoundCheckStatesImages = new System.Windows.Forms.ImageList(this.components);
            this.SuspendLayout();
            // 
            // WoundButton
            // 
            this.WoundButton.Dock = System.Windows.Forms.DockStyle.Fill;
            this.WoundButton.FlatAppearance.BorderSize = 0;
            this.WoundButton.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.WoundButton.ImageIndex = 0;
            this.WoundButton.ImageList = this.WoundCheckStatesImages;
            this.WoundButton.Location = new System.Drawing.Point(0, 0);
            this.WoundButton.Name = "WoundButton";
            this.WoundButton.Size = new System.Drawing.Size(64, 64);
            this.WoundButton.TabIndex = 0;
            this.WoundButton.UseMnemonic = false;
            this.WoundButton.UseVisualStyleBackColor = true;
            this.WoundButton.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.WoundButton_KeyPress);
            this.WoundButton.MouseClick += new System.Windows.Forms.MouseEventHandler(this.WoundButton_MouseClick);
            // 
            // WoundCheckStatesImages
            // 
            this.WoundCheckStatesImages.ImageStream = ((System.Windows.Forms.ImageListStreamer)(resources.GetObject("WoundCheckStatesImages.ImageStream")));
            this.WoundCheckStatesImages.TransparentColor = System.Drawing.Color.Transparent;
            this.WoundCheckStatesImages.Images.SetKeyName(0, "WioundCheckbox1.png");
            this.WoundCheckStatesImages.Images.SetKeyName(1, "WioundCheckbox2.png");
            this.WoundCheckStatesImages.Images.SetKeyName(2, "WioundCheckbox3.png");
            this.WoundCheckStatesImages.Images.SetKeyName(3, "WioundCheckbox4.png");
            // 
            // WoDWoundCheckboxButton
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.Controls.Add(this.WoundButton);
            this.Margin = new System.Windows.Forms.Padding(1);
            this.MaximumSize = new System.Drawing.Size(65, 65);
            this.MinimumSize = new System.Drawing.Size(17, 17);
            this.Name = "WoDWoundCheckboxButton";
            this.Size = new System.Drawing.Size(64, 64);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button WoundButton;
        private System.Windows.Forms.ImageList WoundCheckStatesImages;

    }
}
