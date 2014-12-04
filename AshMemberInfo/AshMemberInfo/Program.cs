// Alexandra's Lemonade Stand by Ashiwin - December 2014 //

using System;
using System.Collections.Generic;
using System.Linq;
using System.Windows.Forms;

namespace AshMemberInfo
{
    static class Program
    {
        /// <summary>
        /// The main entry point for the application.
        /// </summary>
        [STAThread]
        static void Main()
        {
            Application.EnableVisualStyles();
            Application.SetCompatibleTextRenderingDefault(false);
            Splash aSplash = new Splash();
            aSplash.ShowDialog();
            Application.Run(new Home());
        }
    }
}
