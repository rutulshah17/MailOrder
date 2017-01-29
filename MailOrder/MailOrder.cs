using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Globalization;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace MailOrder
{
    public partial class MailOrder1 : Form
    {
        public MailOrder1()
        {
            InitializeComponent();
        }

        private void calculateSalesBonusButton_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(employeeNameTextBox.Text)
                || string.IsNullOrEmpty(employeeIDTextbox.Text)
                    || string.IsNullOrEmpty(totalHoursWorkedTextBox.Text)
                        || string.IsNullOrEmpty(totalMonthlySalesTextBox.Text))
            {
                MessageBox.Show("No Field Can Remain Empty", "Empty Field Detected !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if ( double.Parse(totalHoursWorkedTextBox.Text) < 0 || double.Parse(totalHoursWorkedTextBox.Text) > 160 )
            {
                MessageBox.Show("Total Working Hours Cannot be less than 0 and cannot exceed 160. It can neither be an Alphabet", "Total Working Hours Exceeded !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else 
            {
                string employeeName = employeeNameTextBox.Text;
                int employeeId = int.Parse(employeeIDTextbox.Text);

                double percentageOfHoursWorked = (double.Parse(totalHoursWorkedTextBox.Text) / 160);

                double totalBonusAmount = (double.Parse(totalMonthlySalesTextBox.Text) * 0.02);

                salesBonusTextBox.Text = ( (percentageOfHoursWorked * totalBonusAmount).ToString("C", CultureInfo.CurrentCulture) );

            }
            ///MessageBox.Show(employeeName + ' ' + employeeId + ' ' + salesBonusTextBox);
        }

        private void printSalesBonusButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form is being sent to the printer", "Sales Bonus",MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void nextEntryButton_Click(object sender, EventArgs e)
        {
            employeeNameTextBox.Clear();
            employeeIDTextbox.Clear();
            totalHoursWorkedTextBox.Clear();
            salesBonusTextBox.Clear();
        }

        private void EnglishRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var culture = CultureInfo.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("en-US");
            culture = CultureInfo.CurrentCulture;
        }

        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            var culture = CultureInfo.CurrentCulture;
            Thread.CurrentThread.CurrentCulture = new CultureInfo("fr-FR");
            culture = CultureInfo.CurrentCulture;
        }
    }
}
