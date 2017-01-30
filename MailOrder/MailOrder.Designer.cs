namespace MailOrder
{
    partial class MailOrder1
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.nextEntryButton = new System.Windows.Forms.Button();
            this.printSalesBonusButton = new System.Windows.Forms.Button();
            this.calculateSalesBonusButton = new System.Windows.Forms.Button();
            this.LogoRutulMailOrder = new System.Windows.Forms.PictureBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.EnglishRadioButton = new System.Windows.Forms.RadioButton();
            this.FrenchRadioButton = new System.Windows.Forms.RadioButton();
            this.panel1 = new System.Windows.Forms.Panel();
            this.salesBonusTextBox = new System.Windows.Forms.TextBox();
            this.totalMonthlySalesTextBox = new System.Windows.Forms.TextBox();
            this.totalHoursWorkedTextBox = new System.Windows.Forms.TextBox();
            this.employeeIDTextbox = new System.Windows.Forms.TextBox();
            this.employeeNameTextBox = new System.Windows.Forms.TextBox();
            this.panel2 = new System.Windows.Forms.Panel();
            this.SalesBonusLabel = new System.Windows.Forms.Label();
            this.HoursWorkedLabel = new System.Windows.Forms.Label();
            this.EmployeeIDLabel = new System.Windows.Forms.Label();
            this.TotalSalesLabel = new System.Windows.Forms.Label();
            this.EmployeeNameLabel = new System.Windows.Forms.Label();
            this.SpanishRadioButton = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.LogoRutulMailOrder)).BeginInit();
            this.groupBox1.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.SuspendLayout();
            // 
            // nextEntryButton
            // 
            this.nextEntryButton.Location = new System.Drawing.Point(372, 426);
            this.nextEntryButton.Name = "nextEntryButton";
            this.nextEntryButton.Size = new System.Drawing.Size(75, 23);
            this.nextEntryButton.TabIndex = 55;
            this.nextEntryButton.Text = "Next";
            this.nextEntryButton.UseVisualStyleBackColor = true;
            this.nextEntryButton.Click += new System.EventHandler(this.nextEntryButton_Click);
            // 
            // printSalesBonusButton
            // 
            this.printSalesBonusButton.Location = new System.Drawing.Point(204, 426);
            this.printSalesBonusButton.Name = "printSalesBonusButton";
            this.printSalesBonusButton.Size = new System.Drawing.Size(75, 23);
            this.printSalesBonusButton.TabIndex = 54;
            this.printSalesBonusButton.Text = "Print";
            this.printSalesBonusButton.UseVisualStyleBackColor = true;
            this.printSalesBonusButton.Click += new System.EventHandler(this.printSalesBonusButton_Click);
            // 
            // calculateSalesBonusButton
            // 
            this.calculateSalesBonusButton.Location = new System.Drawing.Point(33, 426);
            this.calculateSalesBonusButton.Name = "calculateSalesBonusButton";
            this.calculateSalesBonusButton.Size = new System.Drawing.Size(75, 23);
            this.calculateSalesBonusButton.TabIndex = 53;
            this.calculateSalesBonusButton.Text = "Calculate";
            this.calculateSalesBonusButton.UseVisualStyleBackColor = true;
            this.calculateSalesBonusButton.Click += new System.EventHandler(this.calculateSalesBonusButton_Click);
            // 
            // LogoRutulMailOrder
            // 
            this.LogoRutulMailOrder.Image = global::MailOrder.Properties.Resources.mailOrderLogo_3_;
            this.LogoRutulMailOrder.Location = new System.Drawing.Point(15, 11);
            this.LogoRutulMailOrder.Name = "LogoRutulMailOrder";
            this.LogoRutulMailOrder.Size = new System.Drawing.Size(219, 171);
            this.LogoRutulMailOrder.TabIndex = 42;
            this.LogoRutulMailOrder.TabStop = false;
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.SpanishRadioButton);
            this.groupBox1.Controls.Add(this.EnglishRadioButton);
            this.groupBox1.Controls.Add(this.FrenchRadioButton);
            this.groupBox1.Location = new System.Drawing.Point(269, 36);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(201, 119);
            this.groupBox1.TabIndex = 41;
            this.groupBox1.TabStop = false;
            this.groupBox1.Text = "Language";
            // 
            // EnglishRadioButton
            // 
            this.EnglishRadioButton.AutoSize = true;
            this.EnglishRadioButton.Checked = true;
            this.EnglishRadioButton.Location = new System.Drawing.Point(6, 35);
            this.EnglishRadioButton.Name = "EnglishRadioButton";
            this.EnglishRadioButton.Size = new System.Drawing.Size(59, 17);
            this.EnglishRadioButton.TabIndex = 0;
            this.EnglishRadioButton.TabStop = true;
            this.EnglishRadioButton.Text = "English";
            this.EnglishRadioButton.UseVisualStyleBackColor = true;
            this.EnglishRadioButton.CheckedChanged += new System.EventHandler(this.EnglishRadioButton_CheckedChanged);
            // 
            // FrenchRadioButton
            // 
            this.FrenchRadioButton.AutoSize = true;
            this.FrenchRadioButton.Location = new System.Drawing.Point(6, 58);
            this.FrenchRadioButton.Name = "FrenchRadioButton";
            this.FrenchRadioButton.Size = new System.Drawing.Size(65, 17);
            this.FrenchRadioButton.TabIndex = 1;
            this.FrenchRadioButton.Text = "Français";
            this.FrenchRadioButton.UseVisualStyleBackColor = true;
            this.FrenchRadioButton.CheckedChanged += new System.EventHandler(this.FrenchRadioButton_CheckedChanged);
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.salesBonusTextBox);
            this.panel1.Controls.Add(this.totalMonthlySalesTextBox);
            this.panel1.Controls.Add(this.totalHoursWorkedTextBox);
            this.panel1.Controls.Add(this.employeeIDTextbox);
            this.panel1.Controls.Add(this.employeeNameTextBox);
            this.panel1.Location = new System.Drawing.Point(236, 210);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(249, 177);
            this.panel1.TabIndex = 56;
            // 
            // salesBonusTextBox
            // 
            this.salesBonusTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.salesBonusTextBox.Location = new System.Drawing.Point(1, 156);
            this.salesBonusTextBox.Name = "salesBonusTextBox";
            this.salesBonusTextBox.ReadOnly = true;
            this.salesBonusTextBox.Size = new System.Drawing.Size(92, 21);
            this.salesBonusTextBox.TabIndex = 53;
            // 
            // totalMonthlySalesTextBox
            // 
            this.totalMonthlySalesTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalMonthlySalesTextBox.Location = new System.Drawing.Point(1, 123);
            this.totalMonthlySalesTextBox.Name = "totalMonthlySalesTextBox";
            this.totalMonthlySalesTextBox.Size = new System.Drawing.Size(92, 21);
            this.totalMonthlySalesTextBox.TabIndex = 52;
            // 
            // totalHoursWorkedTextBox
            // 
            this.totalHoursWorkedTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.totalHoursWorkedTextBox.Location = new System.Drawing.Point(1, 90);
            this.totalHoursWorkedTextBox.Name = "totalHoursWorkedTextBox";
            this.totalHoursWorkedTextBox.Size = new System.Drawing.Size(92, 21);
            this.totalHoursWorkedTextBox.TabIndex = 51;
            // 
            // employeeIDTextbox
            // 
            this.employeeIDTextbox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeIDTextbox.Location = new System.Drawing.Point(1, 34);
            this.employeeIDTextbox.Name = "employeeIDTextbox";
            this.employeeIDTextbox.Size = new System.Drawing.Size(92, 21);
            this.employeeIDTextbox.TabIndex = 50;
            // 
            // employeeNameTextBox
            // 
            this.employeeNameTextBox.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeNameTextBox.Location = new System.Drawing.Point(1, 0);
            this.employeeNameTextBox.Name = "employeeNameTextBox";
            this.employeeNameTextBox.Size = new System.Drawing.Size(158, 21);
            this.employeeNameTextBox.TabIndex = 49;
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.SalesBonusLabel);
            this.panel2.Controls.Add(this.HoursWorkedLabel);
            this.panel2.Controls.Add(this.EmployeeIDLabel);
            this.panel2.Controls.Add(this.TotalSalesLabel);
            this.panel2.Controls.Add(this.EmployeeNameLabel);
            this.panel2.Location = new System.Drawing.Point(0, 209);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(230, 178);
            this.panel2.TabIndex = 57;
            // 
            // SalesBonusLabel
            // 
            this.SalesBonusLabel.AutoSize = true;
            this.SalesBonusLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.SalesBonusLabel.Location = new System.Drawing.Point(130, 160);
            this.SalesBonusLabel.Name = "SalesBonusLabel";
            this.SalesBonusLabel.Size = new System.Drawing.Size(85, 15);
            this.SalesBonusLabel.TabIndex = 57;
            this.SalesBonusLabel.Text = " Sales Bonus :";
            // 
            // HoursWorkedLabel
            // 
            this.HoursWorkedLabel.AutoSize = true;
            this.HoursWorkedLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.HoursWorkedLabel.Location = new System.Drawing.Point(94, 97);
            this.HoursWorkedLabel.Name = "HoursWorkedLabel";
            this.HoursWorkedLabel.Size = new System.Drawing.Size(121, 15);
            this.HoursWorkedLabel.TabIndex = 55;
            this.HoursWorkedLabel.Text = "Total Hours Worked :";
            // 
            // EmployeeIDLabel
            // 
            this.EmployeeIDLabel.AutoSize = true;
            this.EmployeeIDLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeIDLabel.Location = new System.Drawing.Point(132, 35);
            this.EmployeeIDLabel.Name = "EmployeeIDLabel";
            this.EmployeeIDLabel.Size = new System.Drawing.Size(83, 15);
            this.EmployeeIDLabel.TabIndex = 54;
            this.EmployeeIDLabel.Text = "Employee ID :";
            // 
            // TotalSalesLabel
            // 
            this.TotalSalesLabel.AutoSize = true;
            this.TotalSalesLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.TotalSalesLabel.Location = new System.Drawing.Point(95, 127);
            this.TotalSalesLabel.Name = "TotalSalesLabel";
            this.TotalSalesLabel.Size = new System.Drawing.Size(120, 15);
            this.TotalSalesLabel.TabIndex = 56;
            this.TotalSalesLabel.Text = "Total Monthly Sales :";
            // 
            // EmployeeNameLabel
            // 
            this.EmployeeNameLabel.AutoSize = true;
            this.EmployeeNameLabel.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmployeeNameLabel.Location = new System.Drawing.Point(101, 4);
            this.EmployeeNameLabel.Name = "EmployeeNameLabel";
            this.EmployeeNameLabel.Size = new System.Drawing.Size(114, 15);
            this.EmployeeNameLabel.TabIndex = 53;
            this.EmployeeNameLabel.Text = "Employee\'s Name :";
            // 
            // SpanishRadioButton
            // 
            this.SpanishRadioButton.AutoSize = true;
            this.SpanishRadioButton.Location = new System.Drawing.Point(6, 81);
            this.SpanishRadioButton.Name = "SpanishRadioButton";
            this.SpanishRadioButton.Size = new System.Drawing.Size(63, 17);
            this.SpanishRadioButton.TabIndex = 2;
            this.SpanishRadioButton.Text = "Espanol";
            this.SpanishRadioButton.UseVisualStyleBackColor = true;
            this.SpanishRadioButton.CheckedChanged += new System.EventHandler(this.radioButton1_CheckedChanged);
            // 
            // MailOrder1
            // 
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.None;
            this.ClientSize = new System.Drawing.Size(484, 461);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.nextEntryButton);
            this.Controls.Add(this.printSalesBonusButton);
            this.Controls.Add(this.calculateSalesBonusButton);
            this.Controls.Add(this.LogoRutulMailOrder);
            this.Controls.Add(this.groupBox1);
            this.Name = "MailOrder1";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Sales Bonus";
            ((System.ComponentModel.ISupportInitialize)(this.LogoRutulMailOrder)).EndInit();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Button nextEntryButton;
        private System.Windows.Forms.Button printSalesBonusButton;
        private System.Windows.Forms.Button calculateSalesBonusButton;
        private System.Windows.Forms.PictureBox LogoRutulMailOrder;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton EnglishRadioButton;
        private System.Windows.Forms.RadioButton FrenchRadioButton;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.TextBox salesBonusTextBox;
        private System.Windows.Forms.TextBox totalMonthlySalesTextBox;
        private System.Windows.Forms.TextBox totalHoursWorkedTextBox;
        private System.Windows.Forms.TextBox employeeIDTextbox;
        private System.Windows.Forms.TextBox employeeNameTextBox;
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Label SalesBonusLabel;
        private System.Windows.Forms.Label HoursWorkedLabel;
        private System.Windows.Forms.Label EmployeeIDLabel;
        private System.Windows.Forms.Label TotalSalesLabel;
        private System.Windows.Forms.Label EmployeeNameLabel;
        private System.Windows.Forms.RadioButton SpanishRadioButton;
    }
}

