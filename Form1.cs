using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Diagnostics;
using ModifyYourBrowser.ExtensionInstallForceList;
using ModifyYourBrowser.ApplicationFeatures.ChromeFeatures;
using ModifyYourBrowser.ApplicationFeatures.EdgeFeatures;

namespace ModifyYourBrowser
{
    public partial class frmMain: Form
    {
        public frmMain()
        {
            InitializeComponent();
        }

        private void llLinkedIn_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llLinkedIn.LinkVisited = true;

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://www.linkedin.com/in/mohamed-ismail-fh",
                UseShellExecute = true
            };

            Process.Start(psi);

        }

        private void llGithub_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            llGithub.LinkVisited = true;

            ProcessStartInfo psi = new ProcessStartInfo
            {
                FileName = "https://github.com/mohamedismail37",
                UseShellExecute = true
            };

            Process.Start(psi);
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void btnChromeURLBlock_Click(object sender, EventArgs e)
        {
            Form frm = new frmUrlBlocklist("Google Chrome");
            frm.ShowDialog();
        }

        private void btnEdgeURLBlock_Click(object sender, EventArgs e)
        {
            Form frm = new frmUrlBlocklist("Microsoft Edge");
            frm.ShowDialog();
        }

        private void btnChromeExtenstions_Click(object sender, EventArgs e)
        {
            Form frm = new frmExtensionInstallForcelist("Google Chrome");
            frm.ShowDialog();
        }

        private void btnEdgeExtensions_Click(object sender, EventArgs e)
        {
            Form frm = new frmExtensionInstallForcelist("Microsoft Edge");
            frm.ShowDialog();
        }

        private void btnChromeFeatures_Click(object sender, EventArgs e)
        {
            Form frm = new frmChromeFeatures();
            frm.ShowDialog();
        }

        private void btnEdgeFeatures_Click(object sender, EventArgs e)
        {
            Form frm = new frmEdgeFeatures();
            frm.ShowDialog();

        }
    }
}
