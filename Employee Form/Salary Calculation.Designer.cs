namespace Employee_Form
{
    partial class Salary_Calculation
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Salary_Calculation));
            this.panel2 = new System.Windows.Forms.Panel();
            this.txtBoxOtRate = new System.Windows.Forms.TextBox();
            this.employeeComboBox = new System.Windows.Forms.ComboBox();
            this.lblBoxOtRate = new System.Windows.Forms.Label();
            this.label19 = new System.Windows.Forms.Label();
            this.txtBoxGovTax = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.txtBoxEmpId = new System.Windows.Forms.TextBox();
            this.txtBoxLeaveCount = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txtBoxOtHours = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.ButtonCalculate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel3 = new System.Windows.Forms.Panel();
            this.label11 = new System.Windows.Forms.Label();
            this.txtBoxTaxDeduction = new System.Windows.Forms.TextBox();
            this.label15 = new System.Windows.Forms.Label();
            this.txtBoxNoPay = new System.Windows.Forms.TextBox();
            this.txtBoxBasePay = new System.Windows.Forms.TextBox();
            this.label12 = new System.Windows.Forms.Label();
            this.txtBoxTotalOT = new System.Windows.Forms.TextBox();
            this.txtBoxAllowance = new System.Windows.Forms.TextBox();
            this.label10 = new System.Windows.Forms.Label();
            this.txtBoxMonthlySalary = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.label13 = new System.Windows.Forms.Label();
            this.txtGrossPay = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.txtBoxHolidays = new System.Windows.Forms.TextBox();
            this.label18 = new System.Windows.Forms.Label();
            this.label17 = new System.Windows.Forms.Label();
            this.label16 = new System.Windows.Forms.Label();
            this.label14 = new System.Windows.Forms.Label();
            this.dateTimePickerStart = new System.Windows.Forms.DateTimePicker();
            this.dateTimePickerEnd = new System.Windows.Forms.DateTimePicker();
            this.comboBoxMonth = new System.Windows.Forms.ComboBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txtDateRange = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.bunifuThinButton21 = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonClear = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panel4 = new System.Windows.Forms.Panel();
            this.btnCalculate = new Bunifu.Framework.UI.BunifuThinButton2();
            this.label2 = new System.Windows.Forms.Label();
            this.buttonSave = new Bunifu.Framework.UI.BunifuThinButton2();
            this.ButtonSalarySheet = new Bunifu.Framework.UI.BunifuThinButton2();
            this.panelSalarySheet = new System.Windows.Forms.Panel();
            this.panel5 = new System.Windows.Forms.Panel();
            this.panel2.SuspendLayout();
            this.panel3.SuspendLayout();
            this.panel1.SuspendLayout();
            this.panel4.SuspendLayout();
            this.panelSalarySheet.SuspendLayout();
            this.SuspendLayout();
            // 
            // panel2
            // 
            this.panel2.BackColor = System.Drawing.Color.LightGray;
            this.panel2.Controls.Add(this.txtBoxOtRate);
            this.panel2.Controls.Add(this.employeeComboBox);
            this.panel2.Controls.Add(this.lblBoxOtRate);
            this.panel2.Controls.Add(this.label19);
            this.panel2.Controls.Add(this.txtBoxGovTax);
            this.panel2.Controls.Add(this.label1);
            this.panel2.Controls.Add(this.label6);
            this.panel2.Controls.Add(this.txtBoxEmpId);
            this.panel2.Controls.Add(this.txtBoxLeaveCount);
            this.panel2.Controls.Add(this.label7);
            this.panel2.Controls.Add(this.txtBoxOtHours);
            this.panel2.Controls.Add(this.label4);
            this.panel2.Location = new System.Drawing.Point(525, 137);
            this.panel2.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(473, 498);
            this.panel2.TabIndex = 1;
            this.panel2.Paint += new System.Windows.Forms.PaintEventHandler(this.panel2_Paint);
            // 
            // txtBoxOtRate
            // 
            this.txtBoxOtRate.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxOtRate.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxOtRate.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOtRate.Location = new System.Drawing.Point(288, 238);
            this.txtBoxOtRate.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxOtRate.Name = "txtBoxOtRate";
            this.txtBoxOtRate.ReadOnly = true;
            this.txtBoxOtRate.Size = new System.Drawing.Size(140, 31);
            this.txtBoxOtRate.TabIndex = 64;
            this.txtBoxOtRate.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // employeeComboBox
            // 
            this.employeeComboBox.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.employeeComboBox.FormattingEnabled = true;
            this.employeeComboBox.Location = new System.Drawing.Point(288, 57);
            this.employeeComboBox.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.employeeComboBox.Name = "employeeComboBox";
            this.employeeComboBox.Size = new System.Drawing.Size(140, 35);
            this.employeeComboBox.TabIndex = 63;
            this.employeeComboBox.SelectedIndexChanged += new System.EventHandler(this.employeeComboBox_SelectedIndexChanged);
            // 
            // lblBoxOtRate
            // 
            this.lblBoxOtRate.AutoSize = true;
            this.lblBoxOtRate.BackColor = System.Drawing.Color.Gold;
            this.lblBoxOtRate.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBoxOtRate.Location = new System.Drawing.Point(56, 242);
            this.lblBoxOtRate.Name = "lblBoxOtRate";
            this.lblBoxOtRate.Size = new System.Drawing.Size(96, 27);
            this.lblBoxOtRate.TabIndex = 63;
            this.lblBoxOtRate.Text = "OT Rate";
            // 
            // label19
            // 
            this.label19.AutoSize = true;
            this.label19.BackColor = System.Drawing.Color.Gold;
            this.label19.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label19.Location = new System.Drawing.Point(55, 59);
            this.label19.Name = "label19";
            this.label19.Size = new System.Drawing.Size(143, 34);
            this.label19.TabIndex = 60;
            this.label19.Text = "Employee";
            // 
            // txtBoxGovTax
            // 
            this.txtBoxGovTax.BackColor = System.Drawing.Color.LightCyan;
            this.txtBoxGovTax.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxGovTax.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxGovTax.ForeColor = System.Drawing.Color.Red;
            this.txtBoxGovTax.Location = new System.Drawing.Point(288, 426);
            this.txtBoxGovTax.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxGovTax.Name = "txtBoxGovTax";
            this.txtBoxGovTax.Size = new System.Drawing.Size(140, 31);
            this.txtBoxGovTax.TabIndex = 48;
            this.txtBoxGovTax.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtBoxGovTax.TextChanged += new System.EventHandler(this.txtBoxGovTax_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(57, 130);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(78, 24);
            this.label1.TabIndex = 14;
            this.label1.Text = "Emp ID";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Gold;
            this.label6.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(56, 426);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(124, 27);
            this.label6.TabIndex = 45;
            this.label6.Text = "Gov Tax %";
            // 
            // txtBoxEmpId
            // 
            this.txtBoxEmpId.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxEmpId.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxEmpId.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxEmpId.Location = new System.Drawing.Point(288, 127);
            this.txtBoxEmpId.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxEmpId.Name = "txtBoxEmpId";
            this.txtBoxEmpId.ReadOnly = true;
            this.txtBoxEmpId.Size = new System.Drawing.Size(140, 27);
            this.txtBoxEmpId.TabIndex = 13;
            this.txtBoxEmpId.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxLeaveCount
            // 
            this.txtBoxLeaveCount.BackColor = System.Drawing.Color.LightCyan;
            this.txtBoxLeaveCount.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxLeaveCount.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxLeaveCount.Location = new System.Drawing.Point(288, 364);
            this.txtBoxLeaveCount.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxLeaveCount.Name = "txtBoxLeaveCount";
            this.txtBoxLeaveCount.Size = new System.Drawing.Size(140, 31);
            this.txtBoxLeaveCount.TabIndex = 51;
            this.txtBoxLeaveCount.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.Gold;
            this.label7.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(56, 368);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(144, 27);
            this.label7.TabIndex = 49;
            this.label7.Text = "Absent Days";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // txtBoxOtHours
            // 
            this.txtBoxOtHours.BackColor = System.Drawing.Color.LightCyan;
            this.txtBoxOtHours.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxOtHours.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxOtHours.Location = new System.Drawing.Point(288, 303);
            this.txtBoxOtHours.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxOtHours.Name = "txtBoxOtHours";
            this.txtBoxOtHours.Size = new System.Drawing.Size(140, 31);
            this.txtBoxOtHours.TabIndex = 32;
            this.txtBoxOtHours.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Gold;
            this.label4.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(56, 306);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(113, 27);
            this.label4.TabIndex = 29;
            this.label4.Text = "OT Hours";
            // 
            // ButtonCalculate
            // 
            this.ButtonCalculate.ActiveBorderThickness = 1;
            this.ButtonCalculate.ActiveCornerRadius = 20;
            this.ButtonCalculate.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.ButtonCalculate.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonCalculate.ActiveLineColor = System.Drawing.Color.SeaGreen;
            this.ButtonCalculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonCalculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonCalculate.BackgroundImage")));
            this.ButtonCalculate.ButtonText = "Calculate";
            this.ButtonCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonCalculate.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonCalculate.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonCalculate.IdleBorderThickness = 1;
            this.ButtonCalculate.IdleCornerRadius = 20;
            this.ButtonCalculate.IdleFillColor = System.Drawing.Color.SandyBrown;
            this.ButtonCalculate.IdleForecolor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonCalculate.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.ButtonCalculate.Location = new System.Drawing.Point(944, 1153);
            this.ButtonCalculate.Margin = new System.Windows.Forms.Padding(8);
            this.ButtonCalculate.Name = "ButtonCalculate";
            this.ButtonCalculate.Size = new System.Drawing.Size(322, 153);
            this.ButtonCalculate.TabIndex = 65;
            this.ButtonCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonCalculate.Visible = false;
            this.ButtonCalculate.Click += new System.EventHandler(this.ButtonCalculate_Click);
            // 
            // panel3
            // 
            this.panel3.BackColor = System.Drawing.Color.LightGray;
            this.panel3.Controls.Add(this.label11);
            this.panel3.Controls.Add(this.txtBoxTaxDeduction);
            this.panel3.Controls.Add(this.label15);
            this.panel3.Controls.Add(this.txtBoxNoPay);
            this.panel3.Controls.Add(this.txtBoxBasePay);
            this.panel3.Controls.Add(this.label12);
            this.panel3.Controls.Add(this.txtBoxTotalOT);
            this.panel3.Controls.Add(this.txtBoxAllowance);
            this.panel3.Controls.Add(this.label10);
            this.panel3.Controls.Add(this.txtBoxMonthlySalary);
            this.panel3.Controls.Add(this.label3);
            this.panel3.Controls.Add(this.label5);
            this.panel3.Location = new System.Drawing.Point(1004, 137);
            this.panel3.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel3.Name = "panel3";
            this.panel3.Size = new System.Drawing.Size(513, 498);
            this.panel3.TabIndex = 2;
            this.panel3.Paint += new System.Windows.Forms.PaintEventHandler(this.panel3_Paint);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Gold;
            this.label11.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.Location = new System.Drawing.Point(47, 441);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(194, 27);
            this.label11.TabIndex = 55;
            this.label11.Text = "TAX DEDUCTION";
            // 
            // txtBoxTaxDeduction
            // 
            this.txtBoxTaxDeduction.BackColor = System.Drawing.Color.Linen;
            this.txtBoxTaxDeduction.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTaxDeduction.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTaxDeduction.ForeColor = System.Drawing.Color.Red;
            this.txtBoxTaxDeduction.Location = new System.Drawing.Point(304, 442);
            this.txtBoxTaxDeduction.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTaxDeduction.Name = "txtBoxTaxDeduction";
            this.txtBoxTaxDeduction.ReadOnly = true;
            this.txtBoxTaxDeduction.Size = new System.Drawing.Size(156, 31);
            this.txtBoxTaxDeduction.TabIndex = 54;
            this.txtBoxTaxDeduction.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label15
            // 
            this.label15.AutoSize = true;
            this.label15.BackColor = System.Drawing.Color.Gold;
            this.label15.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label15.Location = new System.Drawing.Point(46, 370);
            this.label15.Name = "label15";
            this.label15.Size = new System.Drawing.Size(97, 27);
            this.label15.TabIndex = 53;
            this.label15.Text = "NO PAY";
            // 
            // txtBoxNoPay
            // 
            this.txtBoxNoPay.BackColor = System.Drawing.Color.Linen;
            this.txtBoxNoPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxNoPay.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxNoPay.ForeColor = System.Drawing.Color.Red;
            this.txtBoxNoPay.Location = new System.Drawing.Point(303, 371);
            this.txtBoxNoPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxNoPay.Name = "txtBoxNoPay";
            this.txtBoxNoPay.ReadOnly = true;
            this.txtBoxNoPay.Size = new System.Drawing.Size(156, 31);
            this.txtBoxNoPay.TabIndex = 52;
            this.txtBoxNoPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxBasePay
            // 
            this.txtBoxBasePay.BackColor = System.Drawing.Color.Linen;
            this.txtBoxBasePay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxBasePay.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxBasePay.Location = new System.Drawing.Point(303, 289);
            this.txtBoxBasePay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxBasePay.Name = "txtBoxBasePay";
            this.txtBoxBasePay.ReadOnly = true;
            this.txtBoxBasePay.Size = new System.Drawing.Size(156, 36);
            this.txtBoxBasePay.TabIndex = 50;
            this.txtBoxBasePay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label12
            // 
            this.label12.AutoSize = true;
            this.label12.BackColor = System.Drawing.Color.Gold;
            this.label12.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label12.Location = new System.Drawing.Point(46, 292);
            this.label12.Name = "label12";
            this.label12.Size = new System.Drawing.Size(146, 34);
            this.label12.TabIndex = 49;
            this.label12.Text = "BASE PAY";
            // 
            // txtBoxTotalOT
            // 
            this.txtBoxTotalOT.BackColor = System.Drawing.Color.Linen;
            this.txtBoxTotalOT.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxTotalOT.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxTotalOT.ForeColor = System.Drawing.Color.Green;
            this.txtBoxTotalOT.Location = new System.Drawing.Point(303, 213);
            this.txtBoxTotalOT.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxTotalOT.Name = "txtBoxTotalOT";
            this.txtBoxTotalOT.ReadOnly = true;
            this.txtBoxTotalOT.Size = new System.Drawing.Size(156, 31);
            this.txtBoxTotalOT.TabIndex = 26;
            this.txtBoxTotalOT.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // txtBoxAllowance
            // 
            this.txtBoxAllowance.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxAllowance.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxAllowance.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxAllowance.ForeColor = System.Drawing.Color.Green;
            this.txtBoxAllowance.Location = new System.Drawing.Point(303, 135);
            this.txtBoxAllowance.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxAllowance.Name = "txtBoxAllowance";
            this.txtBoxAllowance.Size = new System.Drawing.Size(156, 31);
            this.txtBoxAllowance.TabIndex = 33;
            this.txtBoxAllowance.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.BackColor = System.Drawing.Color.Gold;
            this.label10.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.Location = new System.Drawing.Point(46, 213);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(92, 27);
            this.label10.TabIndex = 23;
            this.label10.Text = "OT PAY";
            // 
            // txtBoxMonthlySalary
            // 
            this.txtBoxMonthlySalary.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxMonthlySalary.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxMonthlySalary.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxMonthlySalary.Location = new System.Drawing.Point(303, 57);
            this.txtBoxMonthlySalary.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxMonthlySalary.Name = "txtBoxMonthlySalary";
            this.txtBoxMonthlySalary.ReadOnly = true;
            this.txtBoxMonthlySalary.Size = new System.Drawing.Size(156, 31);
            this.txtBoxMonthlySalary.TabIndex = 31;
            this.txtBoxMonthlySalary.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(46, 135);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(152, 27);
            this.label3.TabIndex = 30;
            this.label3.Text = "ALLOWANCE";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Gold;
            this.label5.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(46, 57);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(110, 27);
            this.label5.TabIndex = 28;
            this.label5.Text = "SALLARY";
            // 
            // label13
            // 
            this.label13.AutoSize = true;
            this.label13.BackColor = System.Drawing.Color.Gold;
            this.label13.Font = new System.Drawing.Font("Gadugi", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label13.Location = new System.Drawing.Point(25, 24);
            this.label13.Name = "label13";
            this.label13.Size = new System.Drawing.Size(178, 36);
            this.label13.TabIndex = 55;
            this.label13.Text = "GROSS PAY";
            // 
            // txtGrossPay
            // 
            this.txtGrossPay.BackColor = System.Drawing.SystemColors.ButtonHighlight;
            this.txtGrossPay.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtGrossPay.Font = new System.Drawing.Font("Gadugi", 19.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtGrossPay.ForeColor = System.Drawing.SystemColors.InactiveCaptionText;
            this.txtGrossPay.Location = new System.Drawing.Point(216, 21);
            this.txtGrossPay.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtGrossPay.Name = "txtGrossPay";
            this.txtGrossPay.ReadOnly = true;
            this.txtGrossPay.Size = new System.Drawing.Size(218, 44);
            this.txtGrossPay.TabIndex = 54;
            this.txtGrossPay.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.BackColor = System.Drawing.Color.Gold;
            this.label8.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.Location = new System.Drawing.Point(62, 425);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(177, 27);
            this.label8.TabIndex = 48;
            this.label8.Text = "Holidays Count";
            // 
            // txtBoxHolidays
            // 
            this.txtBoxHolidays.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtBoxHolidays.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtBoxHolidays.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBoxHolidays.Location = new System.Drawing.Point(277, 421);
            this.txtBoxHolidays.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtBoxHolidays.Name = "txtBoxHolidays";
            this.txtBoxHolidays.Size = new System.Drawing.Size(187, 31);
            this.txtBoxHolidays.TabIndex = 50;
            this.txtBoxHolidays.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            // 
            // label18
            // 
            this.label18.AutoSize = true;
            this.label18.BackColor = System.Drawing.Color.Gold;
            this.label18.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label18.Location = new System.Drawing.Point(62, 309);
            this.label18.Name = "label18";
            this.label18.Size = new System.Drawing.Size(85, 27);
            this.label18.TabIndex = 52;
            this.label18.Text = "Month";
            this.label18.Click += new System.EventHandler(this.label18_Click);
            // 
            // label17
            // 
            this.label17.AutoSize = true;
            this.label17.BackColor = System.Drawing.Color.Gold;
            this.label17.Font = new System.Drawing.Font("Gadugi", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label17.Location = new System.Drawing.Point(61, 59);
            this.label17.Name = "label17";
            this.label17.Size = new System.Drawing.Size(171, 34);
            this.label17.TabIndex = 53;
            this.label17.Text = "Salary Cycle";
            // 
            // label16
            // 
            this.label16.AutoSize = true;
            this.label16.BackColor = System.Drawing.Color.Gold;
            this.label16.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label16.Location = new System.Drawing.Point(61, 149);
            this.label16.Name = "label16";
            this.label16.Size = new System.Drawing.Size(107, 24);
            this.label16.TabIndex = 54;
            this.label16.Text = "Start Date";
            // 
            // label14
            // 
            this.label14.AutoSize = true;
            this.label14.BackColor = System.Drawing.Color.Gold;
            this.label14.Font = new System.Drawing.Font("Gadugi", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label14.Location = new System.Drawing.Point(61, 226);
            this.label14.Name = "label14";
            this.label14.Size = new System.Drawing.Size(96, 24);
            this.label14.TabIndex = 55;
            this.label14.Text = "End Date";
            // 
            // dateTimePickerStart
            // 
            this.dateTimePickerStart.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerStart.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerStart.Location = new System.Drawing.Point(277, 145);
            this.dateTimePickerStart.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerStart.Name = "dateTimePickerStart";
            this.dateTimePickerStart.Size = new System.Drawing.Size(187, 30);
            this.dateTimePickerStart.TabIndex = 56;
            // 
            // dateTimePickerEnd
            // 
            this.dateTimePickerEnd.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dateTimePickerEnd.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dateTimePickerEnd.Location = new System.Drawing.Point(277, 221);
            this.dateTimePickerEnd.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.dateTimePickerEnd.Name = "dateTimePickerEnd";
            this.dateTimePickerEnd.Size = new System.Drawing.Size(187, 30);
            this.dateTimePickerEnd.TabIndex = 57;
            this.dateTimePickerEnd.ValueChanged += new System.EventHandler(this.dateTimePickerEnd_ValueChanged);
            // 
            // comboBoxMonth
            // 
            this.comboBoxMonth.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBoxMonth.FormattingEnabled = true;
            this.comboBoxMonth.Items.AddRange(new object[] {
            "January ",
            "February ",
            "March ",
            "April ",
            "May ",
            "June ",
            "July ",
            "August ",
            "September ",
            "October ",
            "November",
            "December"});
            this.comboBoxMonth.Location = new System.Drawing.Point(277, 300);
            this.comboBoxMonth.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.comboBoxMonth.Name = "comboBoxMonth";
            this.comboBoxMonth.Size = new System.Drawing.Size(187, 35);
            this.comboBoxMonth.TabIndex = 58;
            this.comboBoxMonth.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Gold;
            this.label9.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.Location = new System.Drawing.Point(62, 367);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(129, 27);
            this.label9.TabIndex = 61;
            this.label9.Text = "Date range";
            // 
            // txtDateRange
            // 
            this.txtDateRange.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.txtDateRange.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.txtDateRange.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDateRange.Location = new System.Drawing.Point(277, 362);
            this.txtDateRange.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.txtDateRange.Name = "txtDateRange";
            this.txtDateRange.Size = new System.Drawing.Size(187, 31);
            this.txtDateRange.TabIndex = 62;
            this.txtDateRange.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtDateRange.TextChanged += new System.EventHandler(this.txtDateRange_TextChanged);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.LightGray;
            this.panel1.Controls.Add(this.txtDateRange);
            this.panel1.Controls.Add(this.label9);
            this.panel1.Controls.Add(this.comboBoxMonth);
            this.panel1.Controls.Add(this.dateTimePickerEnd);
            this.panel1.Controls.Add(this.dateTimePickerStart);
            this.panel1.Controls.Add(this.label14);
            this.panel1.Controls.Add(this.label16);
            this.panel1.Controls.Add(this.label17);
            this.panel1.Controls.Add(this.label18);
            this.panel1.Controls.Add(this.txtBoxHolidays);
            this.panel1.Controls.Add(this.label8);
            this.panel1.Font = new System.Drawing.Font("Gadugi", 10.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.panel1.Location = new System.Drawing.Point(12, 137);
            this.panel1.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(507, 498);
            this.panel1.TabIndex = 0;
            this.panel1.Paint += new System.Windows.Forms.PaintEventHandler(this.panel1_Paint);
            // 
            // bunifuThinButton21
            // 
            this.bunifuThinButton21.ActiveBorderThickness = 2;
            this.bunifuThinButton21.ActiveCornerRadius = 30;
            this.bunifuThinButton21.ActiveFillColor = System.Drawing.Color.Crimson;
            this.bunifuThinButton21.ActiveForecolor = System.Drawing.Color.White;
            this.bunifuThinButton21.ActiveLineColor = System.Drawing.Color.White;
            this.bunifuThinButton21.BackColor = System.Drawing.Color.Transparent;
            this.bunifuThinButton21.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("bunifuThinButton21.BackgroundImage")));
            this.bunifuThinButton21.ButtonText = "Exit";
            this.bunifuThinButton21.Cursor = System.Windows.Forms.Cursors.Hand;
            this.bunifuThinButton21.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.bunifuThinButton21.ForeColor = System.Drawing.Color.SeaGreen;
            this.bunifuThinButton21.IdleBorderThickness = 1;
            this.bunifuThinButton21.IdleCornerRadius = 30;
            this.bunifuThinButton21.IdleFillColor = System.Drawing.Color.White;
            this.bunifuThinButton21.IdleForecolor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.IdleLineColor = System.Drawing.Color.DarkRed;
            this.bunifuThinButton21.Location = new System.Drawing.Point(316, 772);
            this.bunifuThinButton21.Margin = new System.Windows.Forms.Padding(5);
            this.bunifuThinButton21.Name = "bunifuThinButton21";
            this.bunifuThinButton21.Size = new System.Drawing.Size(151, 70);
            this.bunifuThinButton21.TabIndex = 64;
            this.bunifuThinButton21.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.bunifuThinButton21.Click += new System.EventHandler(this.bunifuThinButton21_Click);
            // 
            // ButtonClear
            // 
            this.ButtonClear.ActiveBorderThickness = 2;
            this.ButtonClear.ActiveCornerRadius = 30;
            this.ButtonClear.ActiveFillColor = System.Drawing.Color.Crimson;
            this.ButtonClear.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonClear.ActiveLineColor = System.Drawing.Color.White;
            this.ButtonClear.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ButtonClear.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonClear.BackgroundImage")));
            this.ButtonClear.ButtonText = "Clear";
            this.ButtonClear.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonClear.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonClear.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonClear.IdleBorderThickness = 1;
            this.ButtonClear.IdleCornerRadius = 30;
            this.ButtonClear.IdleFillColor = System.Drawing.Color.White;
            this.ButtonClear.IdleForecolor = System.Drawing.Color.MediumVioletRed;
            this.ButtonClear.IdleLineColor = System.Drawing.Color.Crimson;
            this.ButtonClear.Location = new System.Drawing.Point(889, 777);
            this.ButtonClear.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonClear.Name = "ButtonClear";
            this.ButtonClear.Size = new System.Drawing.Size(151, 70);
            this.ButtonClear.TabIndex = 66;
            this.ButtonClear.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonClear.Click += new System.EventHandler(this.ButtonClear_Click);
            // 
            // panel4
            // 
            this.panel4.BackColor = System.Drawing.Color.Gold;
            this.panel4.Controls.Add(this.txtGrossPay);
            this.panel4.Controls.Add(this.label13);
            this.panel4.Location = new System.Drawing.Point(1029, 642);
            this.panel4.Name = "panel4";
            this.panel4.Size = new System.Drawing.Size(454, 85);
            this.panel4.TabIndex = 56;
            // 
            // btnCalculate
            // 
            this.btnCalculate.ActiveBorderThickness = 2;
            this.btnCalculate.ActiveCornerRadius = 40;
            this.btnCalculate.ActiveFillColor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.ActiveForecolor = System.Drawing.Color.White;
            this.btnCalculate.ActiveLineColor = System.Drawing.Color.White;
            this.btnCalculate.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.btnCalculate.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("btnCalculate.BackgroundImage")));
            this.btnCalculate.ButtonText = "Calculate";
            this.btnCalculate.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnCalculate.Font = new System.Drawing.Font("Century Gothic", 16.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCalculate.ForeColor = System.Drawing.Color.SeaGreen;
            this.btnCalculate.IdleBorderThickness = 1;
            this.btnCalculate.IdleCornerRadius = 40;
            this.btnCalculate.IdleFillColor = System.Drawing.Color.White;
            this.btnCalculate.IdleForecolor = System.Drawing.Color.DodgerBlue;
            this.btnCalculate.IdleLineColor = System.Drawing.Color.SteelBlue;
            this.btnCalculate.Location = new System.Drawing.Point(646, 747);
            this.btnCalculate.Margin = new System.Windows.Forms.Padding(7, 7, 7, 7);
            this.btnCalculate.Name = "btnCalculate";
            this.btnCalculate.Size = new System.Drawing.Size(231, 100);
            this.btnCalculate.TabIndex = 67;
            this.btnCalculate.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.btnCalculate.Click += new System.EventHandler(this.btnCalculate_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft YaHei UI", 48F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(394, 22);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(762, 106);
            this.label2.TabIndex = 71;
            this.label2.Text = "Salary Calculation";
            this.label2.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // buttonSave
            // 
            this.buttonSave.ActiveBorderThickness = 2;
            this.buttonSave.ActiveCornerRadius = 30;
            this.buttonSave.ActiveFillColor = System.Drawing.Color.SeaGreen;
            this.buttonSave.ActiveForecolor = System.Drawing.Color.White;
            this.buttonSave.ActiveLineColor = System.Drawing.Color.White;
            this.buttonSave.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.buttonSave.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("buttonSave.BackgroundImage")));
            this.buttonSave.ButtonText = "Save";
            this.buttonSave.Cursor = System.Windows.Forms.Cursors.Hand;
            this.buttonSave.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buttonSave.ForeColor = System.Drawing.Color.SeaGreen;
            this.buttonSave.IdleBorderThickness = 1;
            this.buttonSave.IdleCornerRadius = 30;
            this.buttonSave.IdleFillColor = System.Drawing.Color.White;
            this.buttonSave.IdleForecolor = System.Drawing.Color.SeaGreen;
            this.buttonSave.IdleLineColor = System.Drawing.Color.SeaGreen;
            this.buttonSave.Location = new System.Drawing.Point(483, 777);
            this.buttonSave.Margin = new System.Windows.Forms.Padding(5);
            this.buttonSave.Name = "buttonSave";
            this.buttonSave.Size = new System.Drawing.Size(151, 70);
            this.buttonSave.TabIndex = 72;
            this.buttonSave.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.buttonSave.Click += new System.EventHandler(this.buttonSave_Click);
            // 
            // ButtonSalarySheet
            // 
            this.ButtonSalarySheet.ActiveBorderThickness = 2;
            this.ButtonSalarySheet.ActiveCornerRadius = 30;
            this.ButtonSalarySheet.ActiveFillColor = System.Drawing.Color.Indigo;
            this.ButtonSalarySheet.ActiveForecolor = System.Drawing.Color.White;
            this.ButtonSalarySheet.ActiveLineColor = System.Drawing.Color.White;
            this.ButtonSalarySheet.BackColor = System.Drawing.Color.Transparent;
            this.ButtonSalarySheet.BackgroundImage = ((System.Drawing.Image)(resources.GetObject("ButtonSalarySheet.BackgroundImage")));
            this.ButtonSalarySheet.ButtonText = "Salary Sheet";
            this.ButtonSalarySheet.Cursor = System.Windows.Forms.Cursors.Hand;
            this.ButtonSalarySheet.Font = new System.Drawing.Font("Century Gothic", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ButtonSalarySheet.ForeColor = System.Drawing.Color.SeaGreen;
            this.ButtonSalarySheet.IdleBorderThickness = 1;
            this.ButtonSalarySheet.IdleCornerRadius = 30;
            this.ButtonSalarySheet.IdleFillColor = System.Drawing.Color.White;
            this.ButtonSalarySheet.IdleForecolor = System.Drawing.Color.Indigo;
            this.ButtonSalarySheet.IdleLineColor = System.Drawing.Color.SaddleBrown;
            this.ButtonSalarySheet.Location = new System.Drawing.Point(1049, 772);
            this.ButtonSalarySheet.Margin = new System.Windows.Forms.Padding(5);
            this.ButtonSalarySheet.Name = "ButtonSalarySheet";
            this.ButtonSalarySheet.Size = new System.Drawing.Size(151, 70);
            this.ButtonSalarySheet.TabIndex = 73;
            this.ButtonSalarySheet.TextAlign = System.Drawing.ContentAlignment.MiddleCenter;
            this.ButtonSalarySheet.Click += new System.EventHandler(this.ButtonSalarySheet_Click);
            // 
            // panelSalarySheet
            // 
            this.panelSalarySheet.BackColor = System.Drawing.Color.Transparent;
            this.panelSalarySheet.Controls.Add(this.ButtonSalarySheet);
            this.panelSalarySheet.Controls.Add(this.label2);
            this.panelSalarySheet.Controls.Add(this.bunifuThinButton21);
            this.panelSalarySheet.Controls.Add(this.panel5);
            this.panelSalarySheet.Location = new System.Drawing.Point(4, 5);
            this.panelSalarySheet.Name = "panelSalarySheet";
            this.panelSalarySheet.Size = new System.Drawing.Size(1513, 897);
            this.panelSalarySheet.TabIndex = 63;
            // 
            // panel5
            // 
            this.panel5.Location = new System.Drawing.Point(0, 735);
            this.panel5.Name = "panel5";
            this.panel5.Size = new System.Drawing.Size(1547, 159);
            this.panel5.TabIndex = 74;
            // 
            // Salary_Calculation
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1522, 903);
            this.Controls.Add(this.buttonSave);
            this.Controls.Add(this.panel4);
            this.Controls.Add(this.btnCalculate);
            this.Controls.Add(this.ButtonClear);
            this.Controls.Add(this.panel3);
            this.Controls.Add(this.ButtonCalculate);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.panel2);
            this.Controls.Add(this.panelSalarySheet);
            this.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(3, 4, 3, 4);
            this.Name = "Salary_Calculation";
            this.Text = "Salary Calculation";
            this.WindowState = System.Windows.Forms.FormWindowState.Maximized;
            this.Load += new System.EventHandler(this.Salary_Calculation_Load);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel3.ResumeLayout(false);
            this.panel3.PerformLayout();
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            this.panel4.ResumeLayout(false);
            this.panel4.PerformLayout();
            this.panelSalarySheet.ResumeLayout(false);
            this.panelSalarySheet.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Panel panel2;
        private System.Windows.Forms.Panel panel3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtBoxEmpId;
        private System.Windows.Forms.TextBox txtBoxTotalOT;
        private System.Windows.Forms.Label label10;
        private System.Windows.Forms.TextBox txtBoxAllowance;
        private System.Windows.Forms.TextBox txtBoxOtHours;
        private System.Windows.Forms.TextBox txtBoxMonthlySalary;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox txtBoxGovTax;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox txtBoxLeaveCount;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox txtBoxBasePay;
        private System.Windows.Forms.Label label12;
        private System.Windows.Forms.Label label13;
        private System.Windows.Forms.TextBox txtGrossPay;
        private System.Windows.Forms.Label label15;
        private System.Windows.Forms.TextBox txtBoxNoPay;
        private System.Windows.Forms.TextBox txtBoxOtRate;
        private System.Windows.Forms.Label lblBoxOtRate;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox txtBoxHolidays;
        private System.Windows.Forms.Label label18;
        private System.Windows.Forms.Label label17;
        private System.Windows.Forms.Label label16;
        private System.Windows.Forms.Label label14;
        private System.Windows.Forms.DateTimePicker dateTimePickerStart;
        private System.Windows.Forms.DateTimePicker dateTimePickerEnd;
        private System.Windows.Forms.ComboBox comboBoxMonth;
        private System.Windows.Forms.Label label19;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox txtDateRange;
        private System.Windows.Forms.ComboBox employeeComboBox;
        private System.Windows.Forms.Panel panel1;
        private Bunifu.Framework.UI.BunifuThinButton2 bunifuThinButton21;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonCalculate;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonClear;
        private System.Windows.Forms.Panel panel4;
        private Bunifu.Framework.UI.BunifuThinButton2 btnCalculate;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.TextBox txtBoxTaxDeduction;
        private Bunifu.Framework.UI.BunifuThinButton2 buttonSave;
        private Bunifu.Framework.UI.BunifuThinButton2 ButtonSalarySheet;
        private System.Windows.Forms.Panel panelSalarySheet;
        private System.Windows.Forms.Panel panel5;
    }
}