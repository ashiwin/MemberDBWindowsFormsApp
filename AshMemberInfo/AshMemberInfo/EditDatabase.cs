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
    public partial class EditDatabase : Form
    {
        public EditDatabase()
        {
            InitializeComponent();
        }

        private void EditDatabase_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);

            // TODO: This line of code loads data into the 'alexandraDBDataSet.Customer' table. You can move, or remove it, as needed.
            this.customerTableAdapter.Fill(this.alexandraDBDataSet.Customer);

        }

        private void button1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void saveToolStripButton_Click(object sender, EventArgs e)
        {            
            try
            {
                this.Validate();
                this.customerBindingSource.EndEdit();
                this.customerTableAdapter.Update(this.alexandraDBDataSet.Customer);
                MessageBox.Show("Records updated", "Success");
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message, "Error");
            }
        }

        private void firstNameTextBox_TextChanged(object sender, EventArgs e)
        {
            saveToolStripButton.Enabled = !(firstNameTextBox.Text == String.Empty);
        }
    }
}
