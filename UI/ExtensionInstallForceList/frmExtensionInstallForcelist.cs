using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModifyYourBrowser.ExtensionInstallForceList
{
    public partial class frmExtensionInstallForcelist: Form
    {
        string BrowserName;
        public frmExtensionInstallForcelist(string browserName)
        {
            InitializeComponent();
            BrowserName = browserName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmExtensionInstallForcelist_Load(object sender, EventArgs e)
        {
            this.ctrlExtensionForcelist1.LoadBrowserName(BrowserName);
        }
    }
}
