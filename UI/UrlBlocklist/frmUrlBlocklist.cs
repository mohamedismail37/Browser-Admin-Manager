using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModifyYourBrowser
{
    public partial class frmUrlBlocklist: Form
    {
        string BrowserName;
        public frmUrlBlocklist(string browserName)
        {
            InitializeComponent();
            BrowserName = browserName;
        }

        private void btnClose_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void frmUrlBlocklist_Load(object sender, EventArgs e)
        {
            this.ctrlUrlBlocklist1.LoadBrowserName(BrowserName);
            
        }
    }
}
