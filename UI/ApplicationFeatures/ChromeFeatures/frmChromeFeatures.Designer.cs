namespace ModifyYourBrowser.ApplicationFeatures.ChromeFeatures
{
    partial class frmChromeFeatures
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
            this.lblBrowserName = new System.Windows.Forms.Label();
            this.lTitle = new System.Windows.Forms.Label();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.Button();
            this.cbAddPerson = new System.Windows.Forms.CheckBox();
            this.cbGuestMode = new System.Windows.Forms.CheckBox();
            this.cbIncognito = new System.Windows.Forms.CheckBox();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lblBrowserName
            // 
            this.lblBrowserName.AutoSize = true;
            this.lblBrowserName.Font = new System.Drawing.Font("Microsoft Uighur", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowserName.ForeColor = System.Drawing.Color.Black;
            this.lblBrowserName.Location = new System.Drawing.Point(323, 9);
            this.lblBrowserName.Name = "lblBrowserName";
            this.lblBrowserName.Size = new System.Drawing.Size(202, 46);
            this.lblBrowserName.TabIndex = 9;
            this.lblBrowserName.Text = "Google Chrome";
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
            this.lTitle.TabIndex = 8;
            this.lTitle.Text = "Application Features for:";
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.cbIncognito);
            this.groupBox1.Controls.Add(this.cbGuestMode);
            this.groupBox1.Controls.Add(this.cbAddPerson);
            this.groupBox1.Controls.Add(this.label3);
            this.groupBox1.Controls.Add(this.label1);
            this.groupBox1.Controls.Add(this.label2);
            this.groupBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.groupBox1.Location = new System.Drawing.Point(20, 58);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(505, 112);
            this.groupBox1.TabIndex = 10;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Properties (Features):";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 74);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(227, 20);
            this.label2.TabIndex = 1;
            this.label2.Text = "Incognito Mode Availability:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(121, 54);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(112, 20);
            this.label1.TabIndex = 2;
            this.label1.Text = "Guest Mode:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(43, 34);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(190, 20);
            this.label3.TabIndex = 3;
            this.label3.Text = "Add Person (Account):";
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
            this.btnBlock.TabIndex = 11;
            this.btnBlock.Text = "Save";
            this.btnBlock.UseVisualStyleBackColor = true;
            // 
            // cbAddPerson
            // 
            this.cbAddPerson.AutoSize = true;
            this.cbAddPerson.Location = new System.Drawing.Point(239, 34);
            this.cbAddPerson.Name = "cbAddPerson";
            this.cbAddPerson.Size = new System.Drawing.Size(88, 24);
            this.cbAddPerson.TabIndex = 4;
            this.cbAddPerson.Text = "Disable";
            this.cbAddPerson.UseVisualStyleBackColor = true;
            // 
            // cbGuestMode
            // 
            this.cbGuestMode.AutoSize = true;
            this.cbGuestMode.Location = new System.Drawing.Point(239, 54);
            this.cbGuestMode.Name = "cbGuestMode";
            this.cbGuestMode.Size = new System.Drawing.Size(88, 24);
            this.cbGuestMode.TabIndex = 5;
            this.cbGuestMode.Text = "Disable";
            this.cbGuestMode.UseVisualStyleBackColor = true;
            // 
            // cbIncognito
            // 
            this.cbIncognito.AutoSize = true;
            this.cbIncognito.Location = new System.Drawing.Point(239, 74);
            this.cbIncognito.Name = "cbIncognito";
            this.cbIncognito.Size = new System.Drawing.Size(88, 24);
            this.cbIncognito.TabIndex = 6;
            this.cbIncognito.Text = "Disable";
            this.cbIncognito.UseVisualStyleBackColor = true;
            // 
            // frmChromeFeatures
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(536, 218);
            this.Controls.Add(this.btnBlock);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.lblBrowserName);
            this.Controls.Add(this.lTitle);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmChromeFeatures";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Chrome Features";
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBrowserName;
        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.CheckBox cbAddPerson;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.CheckBox cbIncognito;
        private System.Windows.Forms.CheckBox cbGuestMode;
    }
}