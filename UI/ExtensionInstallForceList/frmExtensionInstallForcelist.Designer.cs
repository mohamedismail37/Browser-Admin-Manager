namespace ModifyYourBrowser.ExtensionInstallForceList
{
    partial class frmExtensionInstallForcelist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmExtensionInstallForcelist));
            this.ctrlExtensionForcelist1 = new ModifyYourBrowser.Resources.ctrlExtensionForcelist();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlExtensionForcelist1
            // 
            this.ctrlExtensionForcelist1.Location = new System.Drawing.Point(12, 12);
            this.ctrlExtensionForcelist1.Name = "ctrlExtensionForcelist1";
            this.ctrlExtensionForcelist1.Size = new System.Drawing.Size(575, 196);
            this.ctrlExtensionForcelist1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(431, 200);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmExtensionInstallForcelist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(588, 252);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlExtensionForcelist1);
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "frmExtensionInstallForcelist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Extensions Install Forcelist";
            this.Load += new System.EventHandler(this.frmExtensionInstallForcelist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private Resources.ctrlExtensionForcelist ctrlExtensionForcelist1;
        private System.Windows.Forms.Button btnClose;
    }
}