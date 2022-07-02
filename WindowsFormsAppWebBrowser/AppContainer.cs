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

namespace WindowsFormsAppWebBrowser
{
    public partial class AppContainer : TitleBarTabs
    {
        public AppContainer()
        {
            InitializeComponent();
            AeroPeekEnabled = true;
            TabRenderer = new ChromeTabRenderer(this);
        }

        //handle the creation of the tabs
        public override TitleBarTab CreateTab()
        {
            return new TitleBarTab(this)
            {
                Content = new frmBrowser()
                {
                    Text = "New Piña Tab"
                }
            };
        }

        private void AppContainer_Load(object sender, EventArgs e)
        {

        }
    }
}
