namespace ModifyYourBrowser.ApplicationFeatures.EdgeFeatures
{
    partial class frmEdgeFeatures
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.btnBlock = new System.Windows.Forms.Button();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.cbInPrivateMode = new System.Windows.Forms.CheckBox();
            this.cbJS = new System.Windows.Forms.CheckBox();
            this.cbAutoUpdateCheck = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lblBrowserName = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // btnBlock
            // 
            this.btnBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.ForeColor = System.Drawing.Color.DarkGreen;
            this.btnBlock.Image = global::ModifyYourBrowser.Properties.Resources.Save_32;
            this.btnBlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlock.Location = new System.Drawing.Point(390, 176);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(135, 36);
            this.btnBlock.TabIndex = 15;
            this.btnBlock.Text = "Save";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbInPrivateMode);
            this.groupBox1.Controls.Add(this.cbJS);
            this.groupBox1.Controls.Add(this.cbAutoUpdateCheck);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 112);
            this.groupBox1.TabIndex = 14;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties (Features):";
            // 
            // cbInPrivateMode
            // 
            this.cbInPrivateMode.AutoSize = true;
            this.cbInPrivateMode.Location = new System.Drawing.Point(239, 74);
            this.cbInPrivateMode.Name = "cbInPrivateMode";
            this.cbInPrivateMode.Size = new System.Drawing.Size(88, 24);
            this.cbInPrivateMode.TabIndex = 6;
            this.cbInPrivateMode.Text = "Disable";
            this.cbInPrivateMode.UseVisualStyleBackColor = true;
            // 
            // cbJS
            // 
            this.cbJS.AutoSize = true;
            this.cbJS.Location = new System.Drawing.Point(239, 54);
            this.cbJS.Name = "cbJS";
            this.cbJS.Size = new System.Drawing.Size(88, 24);
            this.cbJS.TabIndex = 5;
            this.cbJS.Text = "Disable";
            this.cbJS.UseVisualStyleBackColor = true;
            // 
            // cbAutoUpdateCheck
            // 
            this.cbAutoUpdateCheck.AutoSize = true;
            this.cbAutoUpdateCheck.Location = new System.Drawing.Point(239, 34);
            this.cbAutoUpdateCheck.Name = "cbAutoUpdateCheck";
            this.cbAutoUpdateCheck.Size = new System.Drawing.Size(88, 24);
            this.cbAutoUpdateCheck.TabIndex = 4;
            this.cbAutoUpdateCheck.Text = "Disable";
            this.cbAutoUpdateCheck.UseVisualStyleBackColor = true;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(58, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(171, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Auto Update Check:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(98, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(131, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "JavaScript(JS):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(223, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "InPrivate Mode Availability:";
            // 
            // lblBrowserName
            // 
            this.lblBrowserName.AutoSize = true;
            this.lblBrowserName.Font = new System.Drawing.Font("Microsoft Uighur", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowserName.ForeColor = System.Drawing.Color.Black;
            this.lblBrowserName.Location = new System.Drawing.Point(323, 9);
            this.lblBrowserName.Name = "lblBrowserName";
            this.lblBrowserName.Size = new System.Drawing.Size(195, 46);
            this.lblBrowserName.TabIndex = 13;
            this.lblBrowserName.Text = "Microsoft Edge";
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Uighur", 28F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.DarkGreen;
            this.lTitle.Location = new System.Drawing.Point(12, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(305, 46);
            this.lTitle.TabIndex = 12;
            this.lTitle.Text = "Application Features for:";
            // 
            // frmEdgeFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(545, 229);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBrowserName);
            this.Controls.Add(this.lTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmEdgeFeatures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Edge Features";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.CheckBox cbInPrivateMode;
        private System.Windows.Forms.CheckBox cbJS;
        private System.Windows.Forms.CheckBox cbAutoUpdateCheck;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label lblBrowserName;
        private System.Windows.Forms.Label lTitle;
    }
}