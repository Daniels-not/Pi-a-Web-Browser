using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
//added
using EasyTabs;
using Microsoft.Win32;

namespace WindowsFormsAppWebBrowser
{
    public partial class frmBrowser : Form
    {
        public frmBrowser()
        {
            InitializeComponent();
            btn_back.Image.RotateFlip((RotateFlipType.Rotate180FlipNone));
            wbr_main.ScriptErrorsSuppressed = true;
            //Upgrade the default web browser

            try
            {
                var appName = System.Diagnostics.Process.GetCurrentProcess().ProcessName + ".exe";

                using (var Key = Registry.CurrentUser.OpenSubKey(@"SOFTWARE\Microsoft\Internet Explorer\Main\FeatureControl\FEATURE_BROWSER_EMULATION", true))
                Key.SetValue(appName, 99999, RegistryValueKind.DWord);
            }
            catch(Exception e)
            {
                MessageBox.Show(e.Message);
            }

            //open duckduck
            wbr_main.Navigate("www.duckduckgo.com");
        }

        protected TitleBarTabs ParentTabs
        {
            get { return ParentForm as TitleBarTabs; }
        }
        
        private void btn_back_Click(object sender, EventArgs e)
        {
            if (wbr_main.CanGoBack) wbr_main.GoBack(); 
        }

        private void btn_forward_Click(object sender, EventArgs e)
        {
            if (wbr_main.CanGoForward) wbr_main.GoForward();
        }

        private void btn_home_Click(object sender, EventArgs e)
        {
            wbr_main.Navigate("www.duckduckgo.com");
        }

        private void btn_reset_Click(object sender, EventArgs e)
        {
            wbr_main.Refresh();
        }

        private void txt_search_KeyUp(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter && txt_search.Text.Trim().Length > 0)
            {
                if (txt_search.Text.Contains("."))
                {
                    wbr_main.Navigate(txt_search.Text.Trim());
                } else
                {
                    wbr_main.Navigate($"https://duckduckgo.com/?q={txt_search.Text}&t=hs&va=l&ia=web");
                }
            }
        }

        private void wbr_main_DocumentCompleted(object sender, WebBrowserDocumentCompletedEventArgs e)
        {
            txt_search.Text = wbr_main.Url.AbsoluteUri;
        }
    }
}
