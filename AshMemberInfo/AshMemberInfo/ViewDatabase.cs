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
    public partial class ViewDatabase : Form
    {
        public ViewDatabase()
        {
            InitializeComponent();
        }

        private void ViewDatabase_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            // TODO: This line of code loads data into the 'alexandraDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.alexandraDBDataSet.Customer);
            // TODO: This line of code loads data into the 'alexandraDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.alexandraDBDataSet.Customer);
            // TODO: This line of code loads data into the 'alexandraDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.alexandraDBDataSet.Customer);
            countTextBox.Text = alexandraDBDataSet.Customer.Count.ToString();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
