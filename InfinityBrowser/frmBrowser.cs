using CefSharp;
using CefSharp.WinForms;
using EasyTabs;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinityBrowser
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
        }

        protected TitleBarTabs ParentTabs
        {
            get 
            {
                return (ParentForm as TitleBarTabs);
            }
        }

        private void bunifuImageButton2_Click(object sender, EventArgs e)
        {

        }

        private void bunifuCards1_Paint(object sender, PaintEventArgs e)
        {

        }

        private void bunifuIconButton1_Click(object sender, EventArgs e)
        {
            if (browser.CanGoBack)
                browser.Back();
        }

        private void frmBrowser_Load(object sender, EventArgs e)
        {
            browser = new ChromiumWebBrowser("www.google.com");
            browser.Dock = DockStyle.Fill;
            this.pContainer.Controls.Add(browser);
        }

        private void txtURL_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == (char)13)
                browser.Load(txtURL.Text);
        }

        ChromiumWebBrowser browser;
        private void btnGo_Click(object sender, EventArgs e)
        {
            browser.Load(txtURL.Text);
        }

        private void btnRefresh_Click(object sender, EventArgs e)
        {
            browser.Refresh();
        }

        private void btnForward_Click(object sender, EventArgs e)
        {
            if (browser.CanGoForward)
                browser.Forward();
        }

        private void btnHome_Click(object sender, EventArgs e)
        {
            browser.Load("www.google.com");
        }

        private void txtURL_KeyUp(object sender, KeyEventArgs e)
        {
            if(e.KeyCode == Keys.Enter && txtURL.Text.Trim().Length > 0)
            {

                if (txtURL.Text.Contains("."))
                {
                    browser.Load(txtURL.Text.Trim());
                }
                else 
                {
                    browser.Load("https://www.google.com/search?q=" + txtURL.Text.Trim().Replace(" ", "+") + "&aqs=chrome..69i57j0i512l7j0i22i30l2.2386j0j7&sourceid=chrome&ie=UTF-8");
                }

            }
        }
    }
}
