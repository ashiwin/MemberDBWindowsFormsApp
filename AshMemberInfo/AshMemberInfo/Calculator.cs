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
    public partial class Calculator : Form
    {
        private const decimal DISCOUNT_RATE_Decimal = 0.1m;
        private decimal totalSalesDecimal;
        private int totalTransactionsInteger;

        public Calculator()
        {
            InitializeComponent();
        }

        private void closeButton_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void clearButton_Click(object sender, EventArgs e)
        {
            scoopsNumberTextBox.Clear();
            scoopsPriceTextBox.Clear();
            conesNumberTextBox.Clear();
            conesPriceTextBox.Clear();
            discountTextBox.Clear();
            normalPriceTextBox.Clear();
            amountDueTextBox.Clear();
            scoopsNumberTextBox.Focus();
        }

        private void calculateButton_Click(object sender, EventArgs e)
        {
            int scoopsNumberInteger, conesNumberInteger;
            decimal scoopsPriceDecimal, conesPriceDecimal, normalPriceDecimal, discountDecimal, amountDueDecimal;

            try
            {
                scoopsNumberInteger = int.Parse(scoopsNumberTextBox.Text);

                try
                {
                    scoopsPriceDecimal = decimal.Parse(scoopsPriceTextBox.Text);


                    try
                    {
                        conesNumberInteger = int.Parse(conesNumberTextBox.Text);

                        try
                        {
                            conesPriceDecimal = decimal.Parse(conesPriceTextBox.Text);

                            normalPriceDecimal = (scoopsNumberInteger * scoopsPriceDecimal) + (conesNumberInteger * conesPriceDecimal);
                            discountDecimal = decimal.Round((normalPriceDecimal * DISCOUNT_RATE_Decimal), 2);
                            amountDueDecimal = normalPriceDecimal - discountDecimal;
                            totalSalesDecimal += amountDueDecimal;
                            totalTransactionsInteger++;

                            normalPriceTextBox.Text = normalPriceDecimal.ToString("C");
                            discountTextBox.Text = discountDecimal.ToString("C");
                            amountDueTextBox.Text = amountDueDecimal.ToString("C");

                            totalSalesTextBox.Text = totalSalesDecimal.ToString("C");
                            totalTransactionsTextBox.Text = totalTransactionsInteger.ToString("D");

                        }
                        catch
                        {
                            MessageBox.Show("Invalid price per cone. Please try again.", "Input Error");
                            conesPriceTextBox.Focus();
                            conesPriceTextBox.SelectAll();
                        }
                    }
                    catch
                    {
                        MessageBox.Show("Invalid number of cones. Please try again.", "Input Error");
                        conesNumberTextBox.Focus();
                        conesNumberTextBox.SelectAll();
                    }
                }
                catch
                {
                    MessageBox.Show("Invalid price per scoop. Please try again.", "Input Error");
                    scoopsPriceTextBox.Focus();
                    scoopsPriceTextBox.SelectAll();
                }
            }
            catch
            {
                MessageBox.Show("Invalid number of scoops. Please try again.", "Input Error");
                scoopsNumberTextBox.Focus();
                scoopsNumberTextBox.SelectAll();
            }
        }

        private void Calculator_Load(object sender, EventArgs e)
        {
            this.Icon = Icon.ExtractAssociatedIcon(Application.ExecutablePath);
        }

    }
    
}
