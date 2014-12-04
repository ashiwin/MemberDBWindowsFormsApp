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
    public partial class Home : Form
    {
        public Home()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewDatabaseButton_Click(object sender, EventArgs e)
        {
            ViewDatabase aViewDatabase = new ViewDatabase();
            aViewDatabase.ShowDialog();
        }

        private void editDatabaseButton_Click(object sender, EventArgs e)
        {
            EditDatabase aEditDatabase = new EditDatabase();
            aEditDatabase.ShowDialog();
        }

        private void iceCreamCalcButton_Click(object sender, EventArgs e)
        {
            Calculator aCalculator = new Calculator();
            aCalculator.ShowDialog();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            About aAbout = new About();
            aAbout.ShowDialog();
        }

        private void exitToolStripMenuItem_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void viewToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            ViewDatabase aViewDatabase = new ViewDatabase();
            aViewDatabase.ShowDialog();
        }

        private void editToolStripMenuItem_Click(object sender, EventArgs e)
        {
            EditDatabase aEditDatabase = new EditDatabase();
            aEditDatabase.ShowDialog();
        }

        private void calculatorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            Calculator aCalculator = new Calculator();
            aCalculator.ShowDialog();
        }

        private void aboutToolStripMenuItem_Click(object sender, EventArgs e)
        {
            About aAbout = new About();
            aAbout.ShowDialog();
        }

        private void Home_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }
    }
}
