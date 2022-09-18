﻿using EasyTabs;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace InfinityBrowser
{
    internal static class Program
    {
        /// <summary>
        /// Punto de entrada principal para la aplicación.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            AppContainer container = new AppContainer();

            container.Tabs.Add(
                
                new TitleBarTab(container)
                {
                    Content = new frmBrowser
                    { 
                        Text = "Infinity Browser"
                    }
                }
           );

           container.SelectedTabIndex = 0;

           TitleBarTabsApplicationContext applicationContext = new TitleBarTabsApplicationContext();
           applicationContext.Start(container);
           Application.Run(applicationContext);

        }
    }
}
