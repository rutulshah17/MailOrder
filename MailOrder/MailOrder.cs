/*
 Name : Rutul Shah
 Student No : #200329341
 Date Last Modified : 29th January
 About Program : This program calculates sales bonus depending on total hours worked by employee and RUTUL MAIL ORDER's monthly sales. For convinience of the user, form is avalable in 3 different languages.  
 */

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
            double _id;
            if (string.IsNullOrEmpty(employeeNameTextBox.Text)
                || string.IsNullOrEmpty(employeeIDTextbox.Text)
                    || string.IsNullOrEmpty(totalHoursWorkedTextBox.Text)
                        || string.IsNullOrEmpty(totalMonthlySalesTextBox.Text))
            {
                MessageBox.Show("No Field Can Remain Empty", "Empty Field Detected !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            /// Got information about TryParse() from msdn.microsoft.com  
            else if (!double.TryParse(totalHoursWorkedTextBox.Text, out _id))
            {
                ///my condition is satisfied and hence it will return true which means the input is a string
                MessageBox.Show("TOTAL HOURS WORKED cannot be a string", "Please check TOTAL HOURS WORKED", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (double.Parse(totalHoursWorkedTextBox.Text) < 0 || double.Parse(totalHoursWorkedTextBox.Text) > 160)
            {
                MessageBox.Show("Total Working Hours Cannot be NEGATIVE and cannot exceed 160 HOURS. It can neither be an ALPHABET", "Please check TOTAL HOURS WORKED !", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }

            else if (!double.TryParse(totalMonthlySalesTextBox.Text, out _id))
            {
                ///information about adding more arguments to show method is taken from msdn.microsoft.com
       
                ///my condition is satisfied and hence it will return true which means the input is a string
                MessageBox.Show("TOTAL MONTHLY SALES cannot be a string", "Please check TOTAL MONTHLY SALES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else if (double.Parse(totalMonthlySalesTextBox.Text) < 0)
            {
                MessageBox.Show("Total Monthly Sales cannot be NEGATIVE !", "Please check MONTHLY SALES", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                string _employeeName = employeeNameTextBox.Text;
                int _employeeId = int.Parse(employeeIDTextbox.Text);

                double _percentageOfHoursWorked = (double.Parse(totalHoursWorkedTextBox.Text) / 160);

                double _totalBonusAmount = (double.Parse(totalMonthlySalesTextBox.Text) * 0.02);

                ///the arguments which is passed in ToString(), is taken from msdn.microsoft.com
                double _value = double.Parse(totalMonthlySalesTextBox.Text);
                totalMonthlySalesTextBox.Text = _value.ToString("C", CultureInfo.CurrentCulture);

                salesBonusTextBox.Text = ((_percentageOfHoursWorked * _totalBonusAmount).ToString("C", CultureInfo.CurrentCulture));

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
            EmployeeNameLabel.Text = "Employee Name : ";
            EmployeeIDLabel.Text = "Employee ID : ";

            HoursWorkedLabel.Text = "Total Hours Worked : ";
            TotalSalesLabel.Text = "Total Monthly Sales : ";
            SalesBonusLabel.Text = "Sales Bonus : ";

            calculateSalesBonusButton.Text = "Calculate";
            printSalesBonusButton.Text = "Print";
            nextEntryButton.Text = "Next";
        }

        private void FrenchRadioButton_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Le nom de l'employé";
            EmployeeIDLabel.Text = "Employé id";

            HoursWorkedLabel.Text = "Nombre total d'heures";
            TotalSalesLabel.Text = "Ventes totales";
            SalesBonusLabel.Text = "Bonus de vente";

            calculateSalesBonusButton.Text = "Calculer";
            printSalesBonusButton.Text = "Impression";
            nextEntryButton.Text = "Prochain";
        }
        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            EmployeeNameLabel.Text = "Nombre de empleado";
            EmployeeIDLabel.Text = "ID de empleado";

            HoursWorkedLabel.Text = "Horas trabajadas";
            TotalSalesLabel.Text = "Ventas totales";
            SalesBonusLabel.Text = "Bono de ventas";

            calculateSalesBonusButton.Text = "Calcular";
            printSalesBonusButton.Text = "Impresión";
            nextEntryButton.Text = "Siguiente";
        }
        private void employeeNameTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void employeeIDTextbox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalHoursWorkedTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void totalMonthlySalesTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        private void salesBonusTextBox_TextChanged(object sender, EventArgs e)
        {

        }

        
    }
}
