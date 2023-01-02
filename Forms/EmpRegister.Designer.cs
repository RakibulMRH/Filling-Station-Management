
namespace FillingStationManagementSystem.Forms
{
    partial class EmpRegister
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
            this.label6 = new System.Windows.Forms.Label();
            this.empRegisterSalaryTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.empRegistrationOthersRB = new System.Windows.Forms.RadioButton();
            this.empRegistrationFemaleRB = new System.Windows.Forms.RadioButton();
            this.empRegistrationMaleRB = new System.Windows.Forms.RadioButton();
            this.label3 = new System.Windows.Forms.Label();
            this.empRegisterMobileNumTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.empRegisterAddressTB = new System.Windows.Forms.TextBox();
            this.empRegisterNameTB = new System.Windows.Forms.TextBox();
            this.EmpRegistrtaionGoBackBTN = new System.Windows.Forms.Button();
            this.EmpRegistrationConfirmBTN = new System.Windows.Forms.Button();
            this.comboBox1 = new System.Windows.Forms.ComboBox();
            this.empPasswordTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(41, 222);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(39, 18);
            this.label6.TabIndex = 84;
            this.label6.Text = "Role";
            // 
            // empRegisterSalaryTB
            // 
            this.empRegisterSalaryTB.Location = new System.Drawing.Point(510, 223);
            this.empRegisterSalaryTB.Multiline = true;
            this.empRegisterSalaryTB.Name = "empRegisterSalaryTB";
            this.empRegisterSalaryTB.Size = new System.Drawing.Size(214, 28);
            this.empRegisterSalaryTB.TabIndex = 83;
            this.empRegisterSalaryTB.TextChanged += new System.EventHandler(this.empRegisterSalaryTB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(442, 223);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(49, 18);
            this.label5.TabIndex = 82;
            this.label5.Text = "Salary";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(91, 280);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(57, 18);
            this.label4.TabIndex = 81;
            this.label4.Text = "Gender";
            // 
            // empRegistrationOthersRB
            // 
            this.empRegistrationOthersRB.AutoSize = true;
            this.empRegistrationOthersRB.Location = new System.Drawing.Point(307, 301);
            this.empRegistrationOthersRB.Name = "empRegistrationOthersRB";
            this.empRegistrationOthersRB.Size = new System.Drawing.Size(56, 17);
            this.empRegistrationOthersRB.TabIndex = 80;
            this.empRegistrationOthersRB.TabStop = true;
            this.empRegistrationOthersRB.Text = "Others";
            this.empRegistrationOthersRB.UseVisualStyleBackColor = true;
            this.empRegistrationOthersRB.CheckedChanged += new System.EventHandler(this.empRegistrationOthersRB_CheckedChanged);
            // 
            // empRegistrationFemaleRB
            // 
            this.empRegistrationFemaleRB.AutoSize = true;
            this.empRegistrationFemaleRB.Location = new System.Drawing.Point(217, 301);
            this.empRegistrationFemaleRB.Name = "empRegistrationFemaleRB";
            this.empRegistrationFemaleRB.Size = new System.Drawing.Size(59, 17);
            this.empRegistrationFemaleRB.TabIndex = 79;
            this.empRegistrationFemaleRB.TabStop = true;
            this.empRegistrationFemaleRB.Text = "Female";
            this.empRegistrationFemaleRB.UseVisualStyleBackColor = true;
            this.empRegistrationFemaleRB.CheckedChanged += new System.EventHandler(this.empRegistrationFemaleRB_CheckedChanged);
            // 
            // empRegistrationMaleRB
            // 
            this.empRegistrationMaleRB.AutoSize = true;
            this.empRegistrationMaleRB.Location = new System.Drawing.Point(152, 301);
            this.empRegistrationMaleRB.Name = "empRegistrationMaleRB";
            this.empRegistrationMaleRB.Size = new System.Drawing.Size(48, 17);
            this.empRegistrationMaleRB.TabIndex = 78;
            this.empRegistrationMaleRB.TabStop = true;
            this.empRegistrationMaleRB.Text = "Male";
            this.empRegistrationMaleRB.UseVisualStyleBackColor = true;
            this.empRegistrationMaleRB.CheckedChanged += new System.EventHandler(this.empRegistrationMaleRB_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(39, 161);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(109, 18);
            this.label3.TabIndex = 77;
            this.label3.Text = "Mobile Number";
            // 
            // empRegisterMobileNumTB
            // 
            this.empRegisterMobileNumTB.Location = new System.Drawing.Point(165, 161);
            this.empRegisterMobileNumTB.Multiline = true;
            this.empRegisterMobileNumTB.Name = "empRegisterMobileNumTB";
            this.empRegisterMobileNumTB.Size = new System.Drawing.Size(228, 30);
            this.empRegisterMobileNumTB.TabIndex = 76;
            this.empRegisterMobileNumTB.TextChanged += new System.EventHandler(this.empRegisterMobileNumTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(41, 102);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(62, 18);
            this.label2.TabIndex = 75;
            this.label2.Text = "Address";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(41, 43);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(48, 18);
            this.label1.TabIndex = 74;
            this.label1.Text = "Name";
            // 
            // empRegisterAddressTB
            // 
            this.empRegisterAddressTB.Location = new System.Drawing.Point(165, 102);
            this.empRegisterAddressTB.Multiline = true;
            this.empRegisterAddressTB.Name = "empRegisterAddressTB";
            this.empRegisterAddressTB.Size = new System.Drawing.Size(287, 30);
            this.empRegisterAddressTB.TabIndex = 73;
            this.empRegisterAddressTB.TextChanged += new System.EventHandler(this.empRegisterAddressTB_TextChanged);
            // 
            // empRegisterNameTB
            // 
            this.empRegisterNameTB.Location = new System.Drawing.Point(165, 43);
            this.empRegisterNameTB.Multiline = true;
            this.empRegisterNameTB.Name = "empRegisterNameTB";
            this.empRegisterNameTB.Size = new System.Drawing.Size(287, 30);
            this.empRegisterNameTB.TabIndex = 72;
            this.empRegisterNameTB.TextChanged += new System.EventHandler(this.empRegisterNameTB_TextChanged);
            // 
            // EmpRegistrtaionGoBackBTN
            // 
            this.EmpRegistrtaionGoBackBTN.BackColor = System.Drawing.Color.Blue;
            this.EmpRegistrtaionGoBackBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpRegistrtaionGoBackBTN.ForeColor = System.Drawing.Color.White;
            this.EmpRegistrtaionGoBackBTN.Location = new System.Drawing.Point(604, 375);
            this.EmpRegistrtaionGoBackBTN.Name = "EmpRegistrtaionGoBackBTN";
            this.EmpRegistrtaionGoBackBTN.Size = new System.Drawing.Size(137, 33);
            this.EmpRegistrtaionGoBackBTN.TabIndex = 71;
            this.EmpRegistrtaionGoBackBTN.Text = "Go Back";
            this.EmpRegistrtaionGoBackBTN.UseVisualStyleBackColor = false;
            this.EmpRegistrtaionGoBackBTN.Click += new System.EventHandler(this.EmpRegistrtaionGoBackBTN_Click);
            // 
            // EmpRegistrationConfirmBTN
            // 
            this.EmpRegistrationConfirmBTN.BackColor = System.Drawing.Color.Blue;
            this.EmpRegistrationConfirmBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.EmpRegistrationConfirmBTN.ForeColor = System.Drawing.Color.White;
            this.EmpRegistrationConfirmBTN.Location = new System.Drawing.Point(435, 375);
            this.EmpRegistrationConfirmBTN.Name = "EmpRegistrationConfirmBTN";
            this.EmpRegistrationConfirmBTN.Size = new System.Drawing.Size(163, 33);
            this.EmpRegistrationConfirmBTN.TabIndex = 70;
            this.EmpRegistrationConfirmBTN.Text = "Confirm";
            this.EmpRegistrationConfirmBTN.UseVisualStyleBackColor = false;
            this.EmpRegistrationConfirmBTN.Click += new System.EventHandler(this.EmpRegistrationConfirmBTN_Click);
            // 
            // comboBox1
            // 
            this.comboBox1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.comboBox1.FormattingEnabled = true;
            this.comboBox1.Items.AddRange(new object[] {
            "Manager",
            "Cashier",
            "Lineman"});
            this.comboBox1.Location = new System.Drawing.Point(165, 223);
            this.comboBox1.Name = "comboBox1";
            this.comboBox1.Size = new System.Drawing.Size(214, 28);
            this.comboBox1.TabIndex = 86;
            this.comboBox1.SelectedIndexChanged += new System.EventHandler(this.comboBox1_SelectedIndexChanged);
            // 
            // empPasswordTB
            // 
            this.empPasswordTB.Location = new System.Drawing.Point(510, 323);
            this.empPasswordTB.Multiline = true;
            this.empPasswordTB.Name = "empPasswordTB";
            this.empPasswordTB.Size = new System.Drawing.Size(214, 28);
            this.empPasswordTB.TabIndex = 87;
            this.empPasswordTB.TextChanged += new System.EventHandler(this.empPasswordTB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.Location = new System.Drawing.Point(442, 299);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(75, 18);
            this.label7.TabIndex = 88;
            this.label7.Text = "Password";
            // 
            // EmpRegister
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.empPasswordTB);
            this.Controls.Add(this.comboBox1);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.empRegisterSalaryTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.empRegistrationOthersRB);
            this.Controls.Add(this.empRegistrationFemaleRB);
            this.Controls.Add(this.empRegistrationMaleRB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.empRegisterMobileNumTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.empRegisterAddressTB);
            this.Controls.Add(this.empRegisterNameTB);
            this.Controls.Add(this.EmpRegistrtaionGoBackBTN);
            this.Controls.Add(this.EmpRegistrationConfirmBTN);
            this.Name = "EmpRegister";
            this.Text = "EmpRegister";
            this.Load += new System.EventHandler(this.EmpRegister_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox empRegisterSalaryTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.RadioButton empRegistrationOthersRB;
        private System.Windows.Forms.RadioButton empRegistrationFemaleRB;
        private System.Windows.Forms.RadioButton empRegistrationMaleRB;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox empRegisterMobileNumTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox empRegisterAddressTB;
        private System.Windows.Forms.TextBox empRegisterNameTB;
        private System.Windows.Forms.Button EmpRegistrtaionGoBackBTN;
        private System.Windows.Forms.Button EmpRegistrationConfirmBTN;
        private System.Windows.Forms.ComboBox comboBox1;
        private System.Windows.Forms.TextBox empPasswordTB;
        private System.Windows.Forms.Label label7;
    }
}