using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;
//added
using EasyTabs;

namespace WindowsFormsAppWebBrowser
{
    internal static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]

        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContainer container = new AppContainer();

            //add the initial tab
            container.Tabs.Add(
                //our first tabcreated by default
                new TitleBarTab(container)
                {
                    Content = new frmBrowser()
                    {
                        Text = "New Piña Tab"
                    }
                }
            );

            //Set the initial tab the first one
            container.SelectedTabIndex = 0;

            //Create tas and start application
            TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
            applicationContext.Start(container);
            Application.Run(applicationContext);
        }
    }
}
