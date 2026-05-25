namespace ModifyYourBrowser
{
    partial class frmUrlBlocklist
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(frmUrlBlocklist));
            this.ctrlUrlBlocklist1 = new ModifyYourBrowser.ctrlUrlBlocklist();
            this.btnClose = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // ctrlUrlBlocklist1
            // 
            this.ctrlUrlBlocklist1.Location = new System.Drawing.Point(12, 12);
            this.ctrlUrlBlocklist1.Name = "ctrlUrlBlocklist1";
            this.ctrlUrlBlocklist1.Size = new System.Drawing.Size(584, 520);
            this.ctrlUrlBlocklist1.TabIndex = 0;
            // 
            // btnClose
            // 
            this.btnClose.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnClose.Image = ((System.Drawing.Image)(resources.GetObject("btnClose.Image")));
            this.btnClose.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnClose.Location = new System.Drawing.Point(446, 522);
            this.btnClose.Name = "btnClose";
            this.btnClose.Size = new System.Drawing.Size(135, 36);
            this.btnClose.TabIndex = 4;
            this.btnClose.Text = "Close";
            this.btnClose.UseVisualStyleBackColor = true;
            this.btnClose.Click += new System.EventHandler(this.btnClose_Click);
            // 
            // frmUrlBlocklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(607, 570);
            this.Controls.Add(this.btnClose);
            this.Controls.Add(this.ctrlUrlBlocklist1);
            this.Name = "frmUrlBlocklist";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "URL Blocklist";
            this.Load += new System.EventHandler(this.frmUrlBlocklist_Load);
            this.ResumeLayout(false);

        }

        #endregion

        private ctrlUrlBlocklist ctrlUrlBlocklist1;
        private System.Windows.Forms.Button btnClose;
    }
}