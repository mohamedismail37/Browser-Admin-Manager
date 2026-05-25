using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace ModifyYourBrowser.UrlBlocklist
{
    public partial class urlTextBox: TextBox
    {
        public urlTextBox()
        {
            InitializeComponent();
        }

        protected override void OnPaint(PaintEventArgs pe)
        {
            base.OnPaint(pe);
        }

        private bool IsValidUrl(string url)
        {
            return Uri.TryCreate(url, UriKind.Absolute, out Uri uriResult)
                   && (uriResult.Scheme == Uri.UriSchemeHttp
                       || uriResult.Scheme == Uri.UriSchemeHttps);
        }

        private void urlTextBox_Leave(object sender, EventArgs e)
        {
            string url = this.Text.Trim();

            if (string.IsNullOrWhiteSpace(url))
            {
                errorProvider1.SetError(this, "");
                return;
            }

            if (!IsValidUrl(url))
            {
                errorProvider1.SetError(this, "Invalid URL format");
            }
            else
            {
                errorProvider1.SetError(this, "");
            }

        }
    }
}
