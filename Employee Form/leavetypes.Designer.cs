namespace Employee_Form
{
    partial class leavetypes
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
            this.dataGridLeaveTypes = new System.Windows.Forms.DataGridView();
            this.label3 = new System.Windows.Forms.Label();
            this.txtLeaveType = new System.Windows.Forms.TextBox();
            this.txtLeaveCode = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.resetButton = new System.Windows.Forms.Button();
            this.deleteButton = new System.Windows.Forms.Button();
            this.updateButton = new System.Windows.Forms.Button();
            this.insetButton = new System.Windows.Forms.Button();
            this.txtCount = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeaveTypes)).BeginInit();
            this.SuspendLayout();
            // 
            // dataGridLeaveTypes
            // 
            this.dataGridLeaveTypes.AllowUserToOrderColumns = true;
            this.dataGridLeaveTypes.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dataGridLeaveTypes.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridLeaveTypes.Location = new System.Drawing.Point(545, 201);
            this.dataGridLeaveTypes.Name = "dataGridLeaveTypes";
            this.dataGridLeaveTypes.RowHeadersWidth = 51;
            this.dataGridLeaveTypes.RowTemplate.Height = 24;
            this.dataGridLeaveTypes.Size = new System.Drawing.Size(846, 445);
            this.dataGridLeaveTypes.TabIndex = 17;
            this.dataGridLeaveTypes.CellClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dataGridLeaveTypes_CellClick);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Gold;
            this.label3.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(65, 233);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(129, 27);
            this.label3.TabIndex = 13;
            this.label3.Text = "Leave Type";
            // 
            // txtLeaveType
            // 
            this.txtLeaveType.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveType.ImeMode = System.Windows.Forms.ImeMode.On;
            this.txtLeaveType.Location = new System.Drawing.Point(230, 226);
            this.txtLeaveType.Name = "txtLeaveType";
            this.txtLeaveType.Size = new System.Drawing.Size(263, 34);
            this.txtLeaveType.TabIndex = 18;
            // 
            // txtLeaveCode
            // 
            this.txtLeaveCode.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtLeaveCode.Location = new System.Drawing.Point(230, 319);
            this.txtLeaveCode.Name = "txtLeaveCode";
            this.txtLeaveCode.Size = new System.Drawing.Size(263, 34);
            this.txtLeaveCode.TabIndex = 20;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Gold;
            this.label1.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(65, 320);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(132, 27);
            this.label1.TabIndex = 19;
            this.label1.Text = "Leave Code";
            // 
            // resetButton
            // 
            this.resetButton.BackColor = System.Drawing.Color.Gold;
            this.resetButton.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.resetButton.ForeColor = System.Drawing.Color.Black;
            this.resetButton.Location = new System.Drawing.Point(95, 581);
            this.resetButton.Name = "resetButton";
            this.resetButton.Size = new System.Drawing.Size(159, 58);
            this.resetButton.TabIndex = 56;
            this.resetButton.Text = "RESET";
            this.resetButton.UseVisualStyleBackColor = false;
            this.resetButton.Click += new System.EventHandler(this.resetButton_Click);
            // 
            // deleteButton
            // 
            this.deleteButton.BackColor = System.Drawing.Color.Gold;
            this.deleteButton.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.deleteButton.ForeColor = System.Drawing.Color.Black;
            this.deleteButton.Location = new System.Drawing.Point(276, 581);
            this.deleteButton.Name = "deleteButton";
            this.deleteButton.Size = new System.Drawing.Size(162, 58);
            this.deleteButton.TabIndex = 55;
            this.deleteButton.Text = "DELETE";
            this.deleteButton.UseVisualStyleBackColor = false;
            this.deleteButton.Click += new System.EventHandler(this.deleteButton_Click);
            // 
            // updateButton
            // 
            this.updateButton.BackColor = System.Drawing.Color.Gold;
            this.updateButton.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.updateButton.ForeColor = System.Drawing.Color.Black;
            this.updateButton.Location = new System.Drawing.Point(276, 497);
            this.updateButton.Name = "updateButton";
            this.updateButton.Size = new System.Drawing.Size(162, 58);
            this.updateButton.TabIndex = 54;
            this.updateButton.Text = "UPDATE";
            this.updateButton.UseVisualStyleBackColor = false;
            this.updateButton.Click += new System.EventHandler(this.updateButton_Click);
            // 
            // insetButton
            // 
            this.insetButton.BackColor = System.Drawing.Color.Gold;
            this.insetButton.Font = new System.Drawing.Font("Gadugi", 10.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.insetButton.ForeColor = System.Drawing.Color.Black;
            this.insetButton.Location = new System.Drawing.Point(95, 497);
            this.insetButton.Name = "insetButton";
            this.insetButton.Size = new System.Drawing.Size(159, 58);
            this.insetButton.TabIndex = 53;
            this.insetButton.Text = "INSERT";
            this.insetButton.UseVisualStyleBackColor = false;
            this.insetButton.Click += new System.EventHandler(this.insetButton_Click);
            // 
            // txtCount
            // 
            this.txtCount.Font = new System.Drawing.Font("Microsoft YaHei", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCount.Location = new System.Drawing.Point(230, 403);
            this.txtCount.Name = "txtCount";
            this.txtCount.Size = new System.Drawing.Size(263, 34);
            this.txtCount.TabIndex = 58;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Gold;
            this.label2.Font = new System.Drawing.Font("Gadugi", 13.8F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(65, 404);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(77, 27);
            this.label2.TabIndex = 57;
            this.label2.Text = "Count";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft YaHei UI", 55.2F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(482, 23);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(361, 122);
            this.label5.TabIndex = 59;
            this.label5.Text = "Leaves";
            this.label5.TextAlign = System.Drawing.ContentAlignment.TopCenter;
            // 
            // leavetypes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(8F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.ActiveBorder;
            this.ClientSize = new System.Drawing.Size(1430, 755);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtCount);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.resetButton);
            this.Controls.Add(this.deleteButton);
            this.Controls.Add(this.updateButton);
            this.Controls.Add(this.insetButton);
            this.Controls.Add(this.txtLeaveCode);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txtLeaveType);
            this.Controls.Add(this.dataGridLeaveTypes);
            this.Controls.Add(this.label3);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "leavetypes";
            this.Text = "leavetypes";
            this.Load += new System.EventHandler(this.leavetypes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dataGridLeaveTypes)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dataGridLeaveTypes;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox txtLeaveType;
        private System.Windows.Forms.TextBox txtLeaveCode;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button resetButton;
        private System.Windows.Forms.Button deleteButton;
        private System.Windows.Forms.Button updateButton;
        private System.Windows.Forms.Button insetButton;
        private System.Windows.Forms.TextBox txtCount;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label5;
    }
}