
namespace FillingStationManagementSystem.Forms
{
    partial class CustomerForm
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
            this.customerPetrolRB = new System.Windows.Forms.RadioButton();
            this.customerOctaneRB = new System.Windows.Forms.RadioButton();
            this.customerDieselRB = new System.Windows.Forms.RadioButton();
            this.customerAmountTB = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.customerAmountBTN = new System.Windows.Forms.Button();
            this.customerLogoutBTN = new System.Windows.Forms.Button();
            this.customerTrxTB = new System.Windows.Forms.MaskedTextBox();
            this.TRXID = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.customerIDTB = new System.Windows.Forms.MaskedTextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.label5 = new System.Windows.Forms.Label();
            this.customerDiscoutTotalTB = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cutomerTotalTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.process1 = new System.Diagnostics.Process();
            this.SuspendLayout();
            // 
            // customerPetrolRB
            // 
            this.customerPetrolRB.AutoSize = true;
            this.customerPetrolRB.Location = new System.Drawing.Point(42, 70);
            this.customerPetrolRB.Name = "customerPetrolRB";
            this.customerPetrolRB.Size = new System.Drawing.Size(68, 17);
            this.customerPetrolRB.TabIndex = 0;
            this.customerPetrolRB.TabStop = true;
            this.customerPetrolRB.Text = "PETROL";
            this.customerPetrolRB.UseVisualStyleBackColor = true;
            this.customerPetrolRB.CheckedChanged += new System.EventHandler(this.customerPetrolRB_CheckedChanged);
            // 
            // customerOctaneRB
            // 
            this.customerOctaneRB.AutoSize = true;
            this.customerOctaneRB.Location = new System.Drawing.Point(153, 70);
            this.customerOctaneRB.Name = "customerOctaneRB";
            this.customerOctaneRB.Size = new System.Drawing.Size(69, 17);
            this.customerOctaneRB.TabIndex = 1;
            this.customerOctaneRB.TabStop = true;
            this.customerOctaneRB.Text = "OCTANE";
            this.customerOctaneRB.UseVisualStyleBackColor = true;
            this.customerOctaneRB.CheckedChanged += new System.EventHandler(this.customerOctaneRB_CheckedChanged);
            // 
            // customerDieselRB
            // 
            this.customerDieselRB.AutoSize = true;
            this.customerDieselRB.Location = new System.Drawing.Point(268, 70);
            this.customerDieselRB.Name = "customerDieselRB";
            this.customerDieselRB.Size = new System.Drawing.Size(63, 17);
            this.customerDieselRB.TabIndex = 2;
            this.customerDieselRB.TabStop = true;
            this.customerDieselRB.Text = "DIESEL";
            this.customerDieselRB.UseVisualStyleBackColor = true;
            this.customerDieselRB.CheckedChanged += new System.EventHandler(this.customerDieselRB_CheckedChanged);
            // 
            // customerAmountTB
            // 
            this.customerAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAmountTB.Location = new System.Drawing.Point(136, 105);
            this.customerAmountTB.Name = "customerAmountTB";
            this.customerAmountTB.Size = new System.Drawing.Size(150, 26);
            this.customerAmountTB.TabIndex = 3;
            this.customerAmountTB.TextChanged += new System.EventHandler(this.customerAmountTB_TextChanged);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 105);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 4;
            this.label1.Text = "Enter Amount";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 110);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 5;
            this.label2.Text = "Liters";
            // 
            // customerAmountBTN
            // 
            this.customerAmountBTN.BackColor = System.Drawing.Color.BlueViolet;
            this.customerAmountBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerAmountBTN.ForeColor = System.Drawing.Color.White;
            this.customerAmountBTN.Location = new System.Drawing.Point(176, 137);
            this.customerAmountBTN.Name = "customerAmountBTN";
            this.customerAmountBTN.Size = new System.Drawing.Size(148, 33);
            this.customerAmountBTN.TabIndex = 17;
            this.customerAmountBTN.Text = "Confirm Amount";
            this.customerAmountBTN.UseVisualStyleBackColor = false;
            this.customerAmountBTN.Click += new System.EventHandler(this.customerAmountBTN_Click);
            // 
            // customerLogoutBTN
            // 
            this.customerLogoutBTN.BackColor = System.Drawing.Color.Red;
            this.customerLogoutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerLogoutBTN.ForeColor = System.Drawing.Color.White;
            this.customerLogoutBTN.Location = new System.Drawing.Point(697, 405);
            this.customerLogoutBTN.Name = "customerLogoutBTN";
            this.customerLogoutBTN.Size = new System.Drawing.Size(91, 33);
            this.customerLogoutBTN.TabIndex = 19;
            this.customerLogoutBTN.Text = "Log-out";
            this.customerLogoutBTN.UseVisualStyleBackColor = false;
            this.customerLogoutBTN.Click += new System.EventHandler(this.customerLogoutBTN_Click);
            // 
            // customerTrxTB
            // 
            this.customerTrxTB.Location = new System.Drawing.Point(688, 67);
            this.customerTrxTB.Name = "customerTrxTB";
            this.customerTrxTB.Size = new System.Drawing.Size(100, 20);
            this.customerTrxTB.TabIndex = 21;
            this.customerTrxTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.customerTrxTB_MaskInputRejected);
            // 
            // TRXID
            // 
            this.TRXID.AutoSize = true;
            this.TRXID.Location = new System.Drawing.Point(711, 51);
            this.TRXID.Name = "TRXID";
            this.TRXID.Size = new System.Drawing.Size(77, 13);
            this.TRXID.TabIndex = 22;
            this.TRXID.Text = "Transaction ID";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(600, 51);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(65, 13);
            this.label3.TabIndex = 24;
            this.label3.Text = "Customer ID";
            // 
            // customerIDTB
            // 
            this.customerIDTB.Location = new System.Drawing.Point(565, 67);
            this.customerIDTB.Name = "customerIDTB";
            this.customerIDTB.Size = new System.Drawing.Size(100, 20);
            this.customerIDTB.TabIndex = 23;
            this.customerIDTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.customerIDTB_MaskInputRejected);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 193);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 26;
            this.label4.Text = "Total";
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 200);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 27;
            this.label5.Text = "BDT";
            // 
            // customerDiscoutTotalTB
            // 
            this.customerDiscoutTotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.customerDiscoutTotalTB.Location = new System.Drawing.Point(167, 255);
            this.customerDiscoutTotalTB.Name = "customerDiscoutTotalTB";
            this.customerDiscoutTotalTB.Size = new System.Drawing.Size(173, 26);
            this.customerDiscoutTotalTB.TabIndex = 28;
            this.customerDiscoutTotalTB.TextChanged += new System.EventHandler(this.customerDiscoutTotalTB_TextChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(12, 261);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(143, 16);
            this.label6.TabIndex = 29;
            this.label6.Text = "After applying discount";
            this.label6.Click += new System.EventHandler(this.label6_Click);
            // 
            // cutomerTotalTB
            // 
            this.cutomerTotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cutomerTotalTB.Location = new System.Drawing.Point(167, 193);
            this.cutomerTotalTB.Name = "cutomerTotalTB";
            this.cutomerTotalTB.Size = new System.Drawing.Size(125, 26);
            this.cutomerTotalTB.TabIndex = 30;
            this.cutomerTotalTB.TextChanged += new System.EventHandler(this.cutomerTotalTB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(329, 9);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 33);
            this.label7.TabIndex = 59;
            this.label7.Text = "Welcome  ";
            this.label7.Click += new System.EventHandler(this.label7_Click);
            // 
            // process1
            // 
            this.process1.StartInfo.Domain = "";
            this.process1.StartInfo.LoadUserProfile = false;
            this.process1.StartInfo.Password = null;
            this.process1.StartInfo.StandardErrorEncoding = null;
            this.process1.StartInfo.StandardOutputEncoding = null;
            this.process1.StartInfo.UserName = "";
            this.process1.SynchronizingObject = this;
            // 
            // CustomerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.cutomerTotalTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.customerDiscoutTotalTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.customerIDTB);
            this.Controls.Add(this.TRXID);
            this.Controls.Add(this.customerTrxTB);
            this.Controls.Add(this.customerLogoutBTN);
            this.Controls.Add(this.customerAmountBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.customerAmountTB);
            this.Controls.Add(this.customerDieselRB);
            this.Controls.Add(this.customerOctaneRB);
            this.Controls.Add(this.customerPetrolRB);
            this.Name = "CustomerForm";
            this.Text = "CustomerForm";
            this.Load += new System.EventHandler(this.CustomerForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.RadioButton customerPetrolRB;
        private System.Windows.Forms.RadioButton customerOctaneRB;
        private System.Windows.Forms.RadioButton customerDieselRB;
        private System.Windows.Forms.TextBox customerAmountTB;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button customerAmountBTN;
        private System.Windows.Forms.Button customerLogoutBTN;
        private System.Windows.Forms.MaskedTextBox customerTrxTB;
        private System.Windows.Forms.Label TRXID;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.MaskedTextBox customerIDTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.TextBox customerDiscoutTotalTB;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox cutomerTotalTB;
        private System.Windows.Forms.Label label7;
        private System.Diagnostics.Process process1;
    }
}