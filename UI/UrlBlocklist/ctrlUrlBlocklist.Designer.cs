namespace ModifyYourBrowser
{
    partial class ctrlUrlBlocklist
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
            this.components = new System.ComponentModel.Container();
            this.lTitle = new System.Windows.Forms.Label();
            this.lblBrowserName = new System.Windows.Forms.Label();
            this.gbBlocking = new System.Windows.Forms.GroupBox();
            this.rbNo = new System.Windows.Forms.RadioButton();
            this.gbSpecificWebsite = new System.Windows.Forms.GroupBox();
            this.label3 = new System.Windows.Forms.Label();
            this.btnBlock = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.rbBlockAllWebsites = new System.Windows.Forms.RadioButton();
            this.label1 = new System.Windows.Forms.Label();
            this.gbListing = new System.Windows.Forms.GroupBox();
            this.dgvBlockedWebsites = new System.Windows.Forms.DataGridView();
            this.contextMenuStrip1 = new System.Windows.Forms.ContextMenuStrip(this.components);
            this.deleteBlockedWebsiteToolStripMenuItem = new System.Windows.Forms.ToolStripMenuItem();
            this.button1 = new System.Windows.Forms.Button();
            this.urlTextBox1 = new ModifyYourBrowser.UrlBlocklist.urlTextBox();
            this.gbBlocking.SuspendLayout();
            this.gbSpecificWebsite.SuspendLayout();
            this.gbListing.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockedWebsites)).BeginInit();
            this.contextMenuStrip1.SuspendLayout();
            this.SuspendLayout();
            // 
            // lTitle
            // 
            this.lTitle.AutoSize = true;
            this.lTitle.Font = new System.Drawing.Font("Microsoft Uighur", 28F, ((System.Drawing.FontStyle)(((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic) 
                | System.Drawing.FontStyle.Underline))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lTitle.ForeColor = System.Drawing.Color.Red;
            this.lTitle.Location = new System.Drawing.Point(3, 9);
            this.lTitle.Name = "lTitle";
            this.lTitle.Size = new System.Drawing.Size(227, 46);
            this.lTitle.TabIndex = 1;
            this.lTitle.Text = "URL Blocklist for:";
            // 
            // lblBrowserName
            // 
            this.lblBrowserName.AutoSize = true;
            this.lblBrowserName.Font = new System.Drawing.Font("Microsoft Uighur", 28F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBrowserName.ForeColor = System.Drawing.Color.Black;
            this.lblBrowserName.Location = new System.Drawing.Point(236, 9);
            this.lblBrowserName.Name = "lblBrowserName";
            this.lblBrowserName.Size = new System.Drawing.Size(50, 46);
            this.lblBrowserName.TabIndex = 2;
            this.lblBrowserName.Text = "???";
            // 
            // gbBlocking
            // 
            this.gbBlocking.Controls.Add(this.button1);
            this.gbBlocking.Controls.Add(this.rbNo);
            this.gbBlocking.Controls.Add(this.gbSpecificWebsite);
            this.gbBlocking.Controls.Add(this.rbBlockAllWebsites);
            this.gbBlocking.Controls.Add(this.label1);
            this.gbBlocking.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBlocking.Location = new System.Drawing.Point(11, 58);
            this.gbBlocking.Name = "gbBlocking";
            this.gbBlocking.Size = new System.Drawing.Size(558, 185);
            this.gbBlocking.TabIndex = 3;
            this.gbBlocking.TabStop = false;
            this.gbBlocking.Text = "URL BlockList:";
            // 
            // rbNo
            // 
            this.rbNo.AutoSize = true;
            this.rbNo.Checked = true;
            this.rbNo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbNo.Location = new System.Drawing.Point(238, 31);
            this.rbNo.Name = "rbNo";
            this.rbNo.Size = new System.Drawing.Size(49, 24);
            this.rbNo.TabIndex = 3;
            this.rbNo.TabStop = true;
            this.rbNo.Text = "No";
            this.rbNo.UseVisualStyleBackColor = true;
            // 
            // gbSpecificWebsite
            // 
            this.gbSpecificWebsite.Controls.Add(this.label3);
            this.gbSpecificWebsite.Controls.Add(this.btnBlock);
            this.gbSpecificWebsite.Controls.Add(this.label2);
            this.gbSpecificWebsite.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbSpecificWebsite.ForeColor = System.Drawing.Color.IndianRed;
            this.gbSpecificWebsite.Location = new System.Drawing.Point(10, 61);
            this.gbSpecificWebsite.Name = "gbSpecificWebsite";
            this.gbSpecificWebsite.Size = new System.Drawing.Size(542, 117);
            this.gbSpecificWebsite.TabIndex = 2;
            this.gbSpecificWebsite.TabStop = false;
            this.gbSpecificWebsite.Text = "Block a Specific Website:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.ForeColor = System.Drawing.SystemColors.ControlDarkDark;
            this.label3.Location = new System.Drawing.Point(128, 70);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(205, 40);
            this.label3.TabIndex = 4;
            this.label3.Text = "Should be in this format:\r\n(i.e) http://example.com";
            // 
            // btnBlock
            // 
            this.btnBlock.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBlock.ForeColor = System.Drawing.Color.IndianRed;
            this.btnBlock.Image = global::ModifyYourBrowser.Properties.Resources.ic_block_128_28186;
            this.btnBlock.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btnBlock.Location = new System.Drawing.Point(401, 70);
            this.btnBlock.Name = "btnBlock";
            this.btnBlock.Size = new System.Drawing.Size(135, 36);
            this.btnBlock.TabIndex = 3;
            this.btnBlock.Text = "Block";
            this.btnBlock.UseVisualStyleBackColor = true;
            this.btnBlock.Click += new System.EventHandler(this.btnBlock_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(6, 41);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(120, 20);
            this.label2.TabIndex = 0;
            this.label2.Text = "Website URL:";
            // 
            // rbBlockAllWebsites
            // 
            this.rbBlockAllWebsites.AutoSize = true;
            this.rbBlockAllWebsites.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rbBlockAllWebsites.Location = new System.Drawing.Point(174, 31);
            this.rbBlockAllWebsites.Name = "rbBlockAllWebsites";
            this.rbBlockAllWebsites.Size = new System.Drawing.Size(58, 24);
            this.rbBlockAllWebsites.TabIndex = 1;
            this.rbBlockAllWebsites.Text = "Yes";
            this.rbBlockAllWebsites.UseVisualStyleBackColor = true;
            this.rbBlockAllWebsites.CheckedChanged += new System.EventHandler(this.rbBlockAllWebsites_CheckedChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(6, 33);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(162, 20);
            this.label1.TabIndex = 0;
            this.label1.Text = "Block All Websites:";
            // 
            // gbListing
            // 
            this.gbListing.Controls.Add(this.dgvBlockedWebsites);
            this.gbListing.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbListing.Location = new System.Drawing.Point(11, 249);
            this.gbListing.Name = "gbListing";
            this.gbListing.Size = new System.Drawing.Size(558, 259);
            this.gbListing.TabIndex = 4;
            this.gbListing.TabStop = false;
            this.gbListing.Text = "Listing All Blocked Websites:";
            // 
            // dgvBlockedWebsites
            // 
            this.dgvBlockedWebsites.AllowUserToAddRows = false;
            this.dgvBlockedWebsites.AllowUserToDeleteRows = false;
            this.dgvBlockedWebsites.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvBlockedWebsites.ContextMenuStrip = this.contextMenuStrip1;
            this.dgvBlockedWebsites.Location = new System.Drawing.Point(6, 25);
            this.dgvBlockedWebsites.Name = "dgvBlockedWebsites";
            this.dgvBlockedWebsites.ReadOnly = true;
            this.dgvBlockedWebsites.Size = new System.Drawing.Size(546, 228);
            this.dgvBlockedWebsites.TabIndex = 0;
            // 
            // contextMenuStrip1
            // 
            this.contextMenuStrip1.Items.AddRange(new System.Windows.Forms.ToolStripItem[] {
            this.deleteBlockedWebsiteToolStripMenuItem});
            this.contextMenuStrip1.Name = "contextMenuStrip1";
            this.contextMenuStrip1.Size = new System.Drawing.Size(275, 42);
            // 
            // deleteBlockedWebsiteToolStripMenuItem
            // 
            this.deleteBlockedWebsiteToolStripMenuItem.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold);
            this.deleteBlockedWebsiteToolStripMenuItem.Image = global::ModifyYourBrowser.Properties.Resources.Delete_32;
            this.deleteBlockedWebsiteToolStripMenuItem.ImageScaling = System.Windows.Forms.ToolStripItemImageScaling.None;
            this.deleteBlockedWebsiteToolStripMenuItem.Name = "deleteBlockedWebsiteToolStripMenuItem";
            this.deleteBlockedWebsiteToolStripMenuItem.Size = new System.Drawing.Size(274, 38);
            this.deleteBlockedWebsiteToolStripMenuItem.Text = "Delete Blocked Website";
            // 
            // button1
            // 
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.SteelBlue;
            this.button1.Image = global::ModifyYourBrowser.Properties.Resources.Save_32;
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(411, 19);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(135, 36);
            this.button1.TabIndex = 4;
            this.button1.Text = "Save";
            this.button1.UseVisualStyleBackColor = true;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // urlTextBox1
            // 
            this.urlTextBox1.Location = new System.Drawing.Point(153, 154);
            this.urlTextBox1.Name = "urlTextBox1";
            this.urlTextBox1.Size = new System.Drawing.Size(404, 20);
            this.urlTextBox1.TabIndex = 5;
            // 
            // ctrlUrlBlocklist
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.urlTextBox1);
            this.Controls.Add(this.gbListing);
            this.Controls.Add(this.gbBlocking);
            this.Controls.Add(this.lblBrowserName);
            this.Controls.Add(this.lTitle);
            this.Name = "ctrlUrlBlocklist";
            this.Size = new System.Drawing.Size(584, 520);
            this.Load += new System.EventHandler(this.ctrlUrlBlocklist_Load);
            this.gbBlocking.ResumeLayout(false);
            this.gbBlocking.PerformLayout();
            this.gbSpecificWebsite.ResumeLayout(false);
            this.gbSpecificWebsite.PerformLayout();
            this.gbListing.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvBlockedWebsites)).EndInit();
            this.contextMenuStrip1.ResumeLayout(false);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lTitle;
        private System.Windows.Forms.Label lblBrowserName;
        private System.Windows.Forms.GroupBox gbBlocking;
        private System.Windows.Forms.GroupBox gbSpecificWebsite;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btnBlock;
        private System.Windows.Forms.GroupBox gbListing;
        private System.Windows.Forms.DataGridView dgvBlockedWebsites;
        private System.Windows.Forms.ContextMenuStrip contextMenuStrip1;
        private System.Windows.Forms.ToolStripMenuItem deleteBlockedWebsiteToolStripMenuItem;
        private System.Windows.Forms.Label label3;
        private UrlBlocklist.urlTextBox urlTextBox1;
        private System.Windows.Forms.RadioButton rbNo;
        private System.Windows.Forms.RadioButton rbBlockAllWebsites;
        private System.Windows.Forms.Button button1;
    }
}
