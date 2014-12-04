// Alexandra's Lemonade Stand by Ashiwin - December 2014 //

using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace AshMemberInfo
{
    public partial class Splash : Form
    {
        public Splash()
        {
            InitializeComponent();
        }

        private void splashProgressBarTimer_Tick(object sender, EventArgs e)
        {
            splashProgressBar.PerformStep();
        }

        private void closeSplashTimer_Tick(object sender, EventArgs e)
        {
            this.Close();
        }

        private void Splash_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
    }
}
