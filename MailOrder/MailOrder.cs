using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
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
            string employeeName = employeeNameTextBox.Text;
            int employeeId = int.Parse(employeeIDTextbox.Text);

            double percentageOfHoursWorked = ( double.Parse( totalHoursWorkedTextBox.Text ) / 160 ) ;

            double totalBonusAmount = ( double.Parse( totalMonthlySalesTextBox.Text ) * 0.02);

            salesBonusTextBox.Text = (percentageOfHoursWorked * totalBonusAmount).ToString();


            ///MessageBox.Show(employeeName + ' ' + employeeId + ' ' + salesBonusTextBox);
        }

        private void printSalesBonusButton_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Form is being sent to the printer", "Sales Bonus",
MessageBoxButtons.OK, MessageBoxIcon.Asterisk);
        }

        private void nextEntryButton_Click(object sender, EventArgs e)
        {
            employeeNameTextBox.Clear();
            employeeIDTextbox.Clear();
            totalHoursWorkedTextBox.Clear();
            salesBonusTextBox.Clear();
        }
    }
}
