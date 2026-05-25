using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Core;

namespace ModifyYourBrowser
{
    public partial class ctrlUrlBlocklist: UserControl
    {

        Core.clsCore.enBrowser enBrowser;

        enum enBlockAllSites { All = 0, notAll = 1}
        enBlockAllSites enMode = enBlockAllSites.notAll;
        public ctrlUrlBlocklist()
        {
            InitializeComponent();
        }

        private void rbBlockAllWebsites_CheckedChanged(object sender, EventArgs e)
        {
            if (enMode == enBlockAllSites.notAll)
            {
                gbSpecificWebsite.Enabled = false;
                enMode = enBlockAllSites.All;
            }
            else
            {
                gbSpecificWebsite.Enabled = true;
                enMode = enBlockAllSites.notAll;

            }
        }

        private async void ctrlUrlBlocklist_Load(object sender, EventArgs e)
        {
            await LoadBlockedWebsitesAsync();
        }

        private async Task LoadBlockedWebsitesAsync()
        {
            List<clsCore.BlockedWebsite> websites = await Task.Run(() =>
            BLL.UrlBlocklist.GetBlockedWebsites(enBrowser));


            dgvBlockedWebsites.DataSource = null;
            dgvBlockedWebsites.Rows.Clear();
            dgvBlockedWebsites.Columns.Clear();
            dgvBlockedWebsites.AutoGenerateColumns = true;
            dgvBlockedWebsites.DataSource = websites;

            dgvBlockedWebsites.Columns[0].HeaderText = "Name";
            dgvBlockedWebsites.Columns[0].Width = 220;

            dgvBlockedWebsites.Columns[1].HeaderText = "Data";
            dgvBlockedWebsites.Columns[1].Width = 280;

        }

        private void btnBlock_Click(object sender, EventArgs e)
        {
            if (this.ValidateChildren())
            {
                if (MessageBox.Show($"Are you sure you want to block \"{urlTextBox1.Text}\"", "Block a Website", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BLL.UrlBlocklist.BlockSpecificWebsite(enBrowser, urlTextBox1.Text))
                    {
                        MessageBox.Show("Website Blocked Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Website did NOT Blocked", "An error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            ctrlUrlBlocklist_Load(null, null);
        }

        public void LoadBrowserName(string browserName)
        {
            lblBrowserName.Text = browserName;
            if (browserName == "Google Chrome")
                enBrowser = clsCore.enBrowser.Chrome;
            else if (browserName == "Microsoft Edge")
                enBrowser = clsCore.enBrowser.Edge;   
        }

        private void button1_Click(object sender, EventArgs e)
        {
            if (rbBlockAllWebsites.Checked)
            {
                if (MessageBox.Show($"Are you sure you want to block all Websites", "Block all Websites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BLL.UrlBlocklist.BlockAllWebsites(enBrowser))
                    {
                        MessageBox.Show("All websites blocked Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Websites did NOT Blocked", "An error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }
            }
            else
            {
                if (MessageBox.Show($"Are you sure you want to unlock all Websites", "Unlock all Websites", MessageBoxButtons.YesNo, MessageBoxIcon.Question) == DialogResult.Yes)
                {
                    if (BLL.UrlBlocklist.UnblockAllWebsites(enBrowser))
                    {
                        MessageBox.Show("All websites unblocked Successfully", "Done", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else
                    {
                        MessageBox.Show("Websites did NOT unblocked", "An error Occured", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    }
                }

            }

            ctrlUrlBlocklist_Load(null, null);
        }
    }
}
