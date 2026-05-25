using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModifyYourBrowser.Resources
{
    public partial class ctrlExtensionForcelist: UserControl
    {
        public ctrlExtensionForcelist()
        {
            InitializeComponent();
        }

        public void LoadBrowserName(string browserName)
        {
            lblBrowserName.Text = browserName;
        }
    }
}
