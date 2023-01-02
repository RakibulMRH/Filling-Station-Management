
namespace FillingStationManagementSystem.Forms
{
    partial class Guest
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
            this.process1 = new System.Diagnostics.Process();
            this.label7 = new System.Windows.Forms.Label();
            this.gcutomerTotalTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.TRXID = new System.Windows.Forms.Label();
            this.gcustomerTrxTB = new System.Windows.Forms.MaskedTextBox();
            this.gcustomerLogoutBTN = new System.Windows.Forms.Button();
            this.gcustomerAmountBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.gcustomerAmountTB = new System.Windows.Forms.TextBox();
            this.gcustomerDieselRB = new System.Windows.Forms.RadioButton();
            this.gcustomerOctaneRB = new System.Windows.Forms.RadioButton();
            this.gcustomerPetrolRB = new System.Windows.Forms.RadioButton();
            this.SuspendLayout();
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
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.BackColor = System.Drawing.Color.OldLace;
            this.label7.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(192)))), ((int)(((byte)(0)))));
            this.label7.Location = new System.Drawing.Point(304, 11);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(121, 33);
            this.label7.TabIndex = 77;
            this.label7.Text = "Welcome  ";
            // 
            // gcutomerTotalTB
            // 
            this.gcutomerTotalTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcutomerTotalTB.Location = new System.Drawing.Point(167, 195);
            this.gcutomerTotalTB.Name = "gcutomerTotalTB";
            this.gcutomerTotalTB.Size = new System.Drawing.Size(125, 26);
            this.gcutomerTotalTB.TabIndex = 76;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(295, 202);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(29, 13);
            this.label5.TabIndex = 73;
            this.label5.Text = "BDT";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(111, 195);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(44, 20);
            this.label4.TabIndex = 72;
            this.label4.Text = "Total";
            // 
            // TRXID
            // 
            this.TRXID.AutoSize = true;
            this.TRXID.Location = new System.Drawing.Point(711, 53);
            this.TRXID.Name = "TRXID";
            this.TRXID.Size = new System.Drawing.Size(77, 13);
            this.TRXID.TabIndex = 69;
            this.TRXID.Text = "Transaction ID";
            // 
            // gcustomerTrxTB
            // 
            this.gcustomerTrxTB.Location = new System.Drawing.Point(688, 69);
            this.gcustomerTrxTB.Name = "gcustomerTrxTB";
            this.gcustomerTrxTB.Size = new System.Drawing.Size(100, 20);
            this.gcustomerTrxTB.TabIndex = 68;
            this.gcustomerTrxTB.MaskInputRejected += new System.Windows.Forms.MaskInputRejectedEventHandler(this.gcustomerTrxTB_MaskInputRejected);
            // 
            // gcustomerLogoutBTN
            // 
            this.gcustomerLogoutBTN.BackColor = System.Drawing.Color.Red;
            this.gcustomerLogoutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcustomerLogoutBTN.ForeColor = System.Drawing.Color.White;
            this.gcustomerLogoutBTN.Location = new System.Drawing.Point(697, 407);
            this.gcustomerLogoutBTN.Name = "gcustomerLogoutBTN";
            this.gcustomerLogoutBTN.Size = new System.Drawing.Size(91, 33);
            this.gcustomerLogoutBTN.TabIndex = 67;
            this.gcustomerLogoutBTN.Text = "Log-out";
            this.gcustomerLogoutBTN.UseVisualStyleBackColor = false;
            this.gcustomerLogoutBTN.Click += new System.EventHandler(this.gcustomerLogoutBTN_Click);
            // 
            // gcustomerAmountBTN
            // 
            this.gcustomerAmountBTN.BackColor = System.Drawing.Color.BlueViolet;
            this.gcustomerAmountBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcustomerAmountBTN.ForeColor = System.Drawing.Color.White;
            this.gcustomerAmountBTN.Location = new System.Drawing.Point(176, 139);
            this.gcustomerAmountBTN.Name = "gcustomerAmountBTN";
            this.gcustomerAmountBTN.Size = new System.Drawing.Size(148, 33);
            this.gcustomerAmountBTN.TabIndex = 66;
            this.gcustomerAmountBTN.Text = "Confirm Amount";
            this.gcustomerAmountBTN.UseVisualStyleBackColor = false;
            this.gcustomerAmountBTN.Click += new System.EventHandler(this.customerAmountBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(292, 112);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(32, 13);
            this.label2.TabIndex = 65;
            this.label2.Text = "Liters";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(22, 107);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(108, 20);
            this.label1.TabIndex = 64;
            this.label1.Text = "Enter Amount";
            // 
            // gcustomerAmountTB
            // 
            this.gcustomerAmountTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gcustomerAmountTB.Location = new System.Drawing.Point(136, 107);
            this.gcustomerAmountTB.Name = "gcustomerAmountTB";
            this.gcustomerAmountTB.Size = new System.Drawing.Size(150, 26);
            this.gcustomerAmountTB.TabIndex = 63;
            this.gcustomerAmountTB.TextChanged += new System.EventHandler(this.gcustomerAmountTB_TextChanged);
            // 
            // gcustomerDieselRB
            // 
            this.gcustomerDieselRB.AutoSize = true;
            this.gcustomerDieselRB.Location = new System.Drawing.Point(268, 72);
            this.gcustomerDieselRB.Name = "gcustomerDieselRB";
            this.gcustomerDieselRB.Size = new System.Drawing.Size(63, 17);
            this.gcustomerDieselRB.TabIndex = 62;
            this.gcustomerDieselRB.TabStop = true;
            this.gcustomerDieselRB.Text = "DIESEL";
            this.gcustomerDieselRB.UseVisualStyleBackColor = true;
            this.gcustomerDieselRB.CheckedChanged += new System.EventHandler(this.gcustomerDieselRB_CheckedChanged);
            // 
            // gcustomerOctaneRB
            // 
            this.gcustomerOctaneRB.AutoSize = true;
            this.gcustomerOctaneRB.Location = new System.Drawing.Point(153, 72);
            this.gcustomerOctaneRB.Name = "gcustomerOctaneRB";
            this.gcustomerOctaneRB.Size = new System.Drawing.Size(69, 17);
            this.gcustomerOctaneRB.TabIndex = 61;
            this.gcustomerOctaneRB.TabStop = true;
            this.gcustomerOctaneRB.Text = "OCTANE";
            this.gcustomerOctaneRB.UseVisualStyleBackColor = true;
            this.gcustomerOctaneRB.CheckedChanged += new System.EventHandler(this.gcustomerOctaneRB_CheckedChanged);
            // 
            // gcustomerPetrolRB
            // 
            this.gcustomerPetrolRB.AutoSize = true;
            this.gcustomerPetrolRB.Location = new System.Drawing.Point(42, 72);
            this.gcustomerPetrolRB.Name = "gcustomerPetrolRB";
            this.gcustomerPetrolRB.Size = new System.Drawing.Size(68, 17);
            this.gcustomerPetrolRB.TabIndex = 60;
            this.gcustomerPetrolRB.TabStop = true;
            this.gcustomerPetrolRB.Text = "PETROL";
            this.gcustomerPetrolRB.UseVisualStyleBackColor = true;
            this.gcustomerPetrolRB.CheckedChanged += new System.EventHandler(this.gcustomerPetrolRB_CheckedChanged);
            // 
            // Guest
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.gcutomerTotalTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.TRXID);
            this.Controls.Add(this.gcustomerTrxTB);
            this.Controls.Add(this.gcustomerLogoutBTN);
            this.Controls.Add(this.gcustomerAmountBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.gcustomerAmountTB);
            this.Controls.Add(this.gcustomerDieselRB);
            this.Controls.Add(this.gcustomerOctaneRB);
            this.Controls.Add(this.gcustomerPetrolRB);
            this.Name = "Guest";
            this.Text = "Guest";
            this.Load += new System.EventHandler(this.Guest_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Diagnostics.Process process1;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox gcutomerTotalTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label TRXID;
        private System.Windows.Forms.MaskedTextBox gcustomerTrxTB;
        private System.Windows.Forms.Button gcustomerLogoutBTN;
        private System.Windows.Forms.Button gcustomerAmountBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox gcustomerAmountTB;
        private System.Windows.Forms.RadioButton gcustomerDieselRB;
        private System.Windows.Forms.RadioButton gcustomerOctaneRB;
        private System.Windows.Forms.RadioButton gcustomerPetrolRB;
    }
}