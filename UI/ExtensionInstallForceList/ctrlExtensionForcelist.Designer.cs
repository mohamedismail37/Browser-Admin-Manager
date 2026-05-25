namespace ModifyYourBrowser.Resources
{
    partial class ctrlExtensionForcelist
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
            this.gbSpecificExtension = new System.Windows.Forms.GroupBox();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBrowserName = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.gbSpecificExtension.SuspendLayout();
            this.SuspendLayout();
            // 
            // gbSpecificExtension
            // 
            this.gbSpecificExtension.Controls.Add(this.textBox1);
            this.gbSpecificExtension.Controls.Add(this.label3);
            this.gbSpecificExtension.Controls.Add(this.btnBlock);
            this.gbSpecificExtension.Controls.Add(this.label2);
            this.gbSpecificExtension.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSpecificExtension.ForeColor = System.Drawing.Color.SteelBlue;
            this.gbSpecificExtension.Location = new System.Drawing.Point(11, 63);
            this.gbSpecificExtension.Name = "gbSpecificExtension";
            this.gbSpecificExtension.Size = new System.Drawing.Size(542, 117);
            this.gbSpecificExtension.TabIndex = 8;
            this.gbSpecificExtension.TabStop = false;
            this.gbSpecificExtension.Text = "Extension Disable Unistall:";
            // 
            // textBox1
            // 
            this.textBox1.Location = new System.Drawing.Point(152, 38);
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(384, 26);
            this.textBox1.TabIndex = 5;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(149, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(239, 26);
            this.label3.TabIndex = 4;
            this.label3.Text = "From Extensions manager:\r\n(i.e) kbfnbcaeplbcioakkpcpgfkobkghlhen";
            // 
            // btnBlock
            // 
            this.btnBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.ForeColor = System.Drawing.Color.SteelBlue;
            this.btnBlock.Image = global::ModifyYourBrowser.Properties.Resources.Save_32;
            this.btnBlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlock.Location = new System.Drawing.Point(401, 70);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(135, 36);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Save";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(117, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Extension ID:";
            // 
            // lblBrowserName
            // 
            this.lblBrowserName.AutoSize = true;
            this.lblBrowserName.Font = new System.Drawing.Font("Microsoft Uighur", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowserName.ForeColor = System.Drawing.Color.Black;
            this.lblBrowserName.Location = new System.Drawing.Point(373, 14);
            this.lblBrowserName.Name = "lblBrowserName";
            this.lblBrowserName.Size = new System.Drawing.Size(50, 46);
            this.lblBrowserName.TabIndex = 7;
            this.lblBrowserName.Text = "???";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Uighur", 28F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.DeepSkyBlue;
            this.lTitle.Location = new System.Drawing.Point(3, 14);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(364, 46);
            this.lTitle.TabIndex = 6;
            this.lTitle.Text = "Extension Install Forcelist for:";
            // 
            // ctrlExtensionForcelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.gbSpecificExtension);
            this.Controls.Add(this.lblBrowserName);
            this.Controls.Add(this.lTitle);
            this.Name = "ctrlExtensionForcelist";
            this.Size = new System.Drawing.Size(575, 196);
            this.gbSpecificExtension.ResumeLayout(false);
            this.gbSpecificExtension.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.GroupBox gbSpecificExtension;
        private System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBrowserName;
        private System.Windows.Forms.Label lTitle;
    }
}
