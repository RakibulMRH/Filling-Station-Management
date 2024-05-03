
namespace FillingStationManagementSystem.Forms
{
    partial class LinemanForm
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
            this.linemanLogoutBTN = new System.Windows.Forms.Button();
            this.linemanPrintAllLiftBTN = new System.Windows.Forms.Button();
            this.label1 = new System.Windows.Forms.Label();
            this.linemanPetrolTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.linemanOctaneTB = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.linemanDieselTB = new System.Windows.Forms.TextBox();
            this.linemanConfirmBTN = new System.Windows.Forms.Button();
            this.linemanPetrolidTB = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.linemanOctaneidTB = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.linemanDieselidTB = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.linemanFormDateTB = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.linemanFormUserIdTB = new System.Windows.Forms.TextBox();
            this.linemandataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.linemandataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // linemanLogoutBTN
            // 
            this.linemanLogoutBTN.BackColor = System.Drawing.Color.Red;
            this.linemanLogoutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linemanLogoutBTN.ForeColor = System.Drawing.Color.White;
            this.linemanLogoutBTN.Location = new System.Drawing.Point(687, 328);
            this.linemanLogoutBTN.Name = "linemanLogoutBTN";
            this.linemanLogoutBTN.Size = new System.Drawing.Size(101, 33);
            this.linemanLogoutBTN.TabIndex = 73;
            this.linemanLogoutBTN.Text = "Log-Out";
            this.linemanLogoutBTN.UseVisualStyleBackColor = false;
            this.linemanLogoutBTN.Click += new System.EventHandler(this.linemanLogoutBTN_Click);
            // 
            // linemanPrintAllLiftBTN
            // 
            this.linemanPrintAllLiftBTN.BackColor = System.Drawing.Color.Blue;
            this.linemanPrintAllLiftBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linemanPrintAllLiftBTN.ForeColor = System.Drawing.Color.White;
            this.linemanPrintAllLiftBTN.Location = new System.Drawing.Point(532, 204);
            this.linemanPrintAllLiftBTN.Name = "linemanPrintAllLiftBTN";
            this.linemanPrintAllLiftBTN.Size = new System.Drawing.Size(205, 33);
            this.linemanPrintAllLiftBTN.TabIndex = 70;
            this.linemanPrintAllLiftBTN.Text = "Print All Lifting Details";
            this.linemanPrintAllLiftBTN.UseVisualStyleBackColor = false;
            this.linemanPrintAllLiftBTN.Click += new System.EventHandler(this.button5_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(-2, 9);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(212, 33);
            this.label1.TabIndex = 67;
            this.label1.Text = "Welcome, Lineman";
            // 
            // linemanPetrolTB
            // 
            this.linemanPetrolTB.Location = new System.Drawing.Point(209, 150);
            this.linemanPetrolTB.Name = "linemanPetrolTB";
            this.linemanPetrolTB.Size = new System.Drawing.Size(100, 20);
            this.linemanPetrolTB.TabIndex = 74;
            this.linemanPetrolTB.TextChanged += new System.EventHandler(this.linemanPetrolTB_TextChanged);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(206, 134);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(51, 13);
            this.label2.TabIndex = 75;
            this.label2.Text = "Lift Petrol";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Location = new System.Drawing.Point(206, 84);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(59, 13);
            this.label3.TabIndex = 77;
            this.label3.Text = "Lift Octane";
            // 
            // linemanOctaneTB
            // 
            this.linemanOctaneTB.Location = new System.Drawing.Point(209, 100);
            this.linemanOctaneTB.Name = "linemanOctaneTB";
            this.linemanOctaneTB.Size = new System.Drawing.Size(100, 20);
            this.linemanOctaneTB.TabIndex = 76;
            this.linemanOctaneTB.TextChanged += new System.EventHandler(this.linemanOctaneTB_TextChanged);
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(206, 45);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(53, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Lift Diesel";
            // 
            // linemanDieselTB
            // 
            this.linemanDieselTB.Location = new System.Drawing.Point(209, 61);
            this.linemanDieselTB.Name = "linemanDieselTB";
            this.linemanDieselTB.Size = new System.Drawing.Size(100, 20);
            this.linemanDieselTB.TabIndex = 78;
            this.linemanDieselTB.TextChanged += new System.EventHandler(this.linemanDieselTB_TextChanged);
            // 
            // linemanConfirmBTN
            // 
            this.linemanConfirmBTN.BackColor = System.Drawing.Color.Blue;
            this.linemanConfirmBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.linemanConfirmBTN.ForeColor = System.Drawing.Color.White;
            this.linemanConfirmBTN.Location = new System.Drawing.Point(285, 256);
            this.linemanConfirmBTN.Name = "linemanConfirmBTN";
            this.linemanConfirmBTN.Size = new System.Drawing.Size(101, 33);
            this.linemanConfirmBTN.TabIndex = 81;
            this.linemanConfirmBTN.Text = "Confirm Lifting";
            this.linemanConfirmBTN.UseVisualStyleBackColor = false;
            this.linemanConfirmBTN.Click += new System.EventHandler(this.linemanConfirmBTN_Click);
            // 
            // linemanPetrolidTB
            // 
            this.linemanPetrolidTB.Location = new System.Drawing.Point(4, 61);
            this.linemanPetrolidTB.Name = "linemanPetrolidTB";
            this.linemanPetrolidTB.Size = new System.Drawing.Size(100, 20);
            this.linemanPetrolidTB.TabIndex = 82;
            this.linemanPetrolidTB.TextChanged += new System.EventHandler(this.linemanPetrolidTB_TextChanged);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(1, 45);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(144, 13);
            this.label5.TabIndex = 83;
            this.label5.Text = "Please Enter Lift Id For Petrol";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Location = new System.Drawing.Point(1, 84);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(152, 13);
            this.label6.TabIndex = 85;
            this.label6.Text = "Please Enter Lift Id For Octane";
            // 
            // linemanOctaneidTB
            // 
            this.linemanOctaneidTB.Location = new System.Drawing.Point(3, 100);
            this.linemanOctaneidTB.Name = "linemanOctaneidTB";
            this.linemanOctaneidTB.Size = new System.Drawing.Size(101, 20);
            this.linemanOctaneidTB.TabIndex = 84;
            this.linemanOctaneidTB.TextChanged += new System.EventHandler(this.linemanOctaneidTB_TextChanged);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Location = new System.Drawing.Point(-1, 134);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(146, 13);
            this.label7.TabIndex = 87;
            this.label7.Text = "Please Enter Lift Id For Diesel";
            // 
            // linemanDieselidTB
            // 
            this.linemanDieselidTB.Location = new System.Drawing.Point(2, 150);
            this.linemanDieselidTB.Name = "linemanDieselidTB";
            this.linemanDieselidTB.Size = new System.Drawing.Size(101, 20);
            this.linemanDieselidTB.TabIndex = 86;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Location = new System.Drawing.Point(20, 191);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(112, 13);
            this.label8.TabIndex = 90;
            this.label8.Text = "ENTER DDMMYYYY:";
            // 
            // linemanFormDateTB
            // 
            this.linemanFormDateTB.Location = new System.Drawing.Point(53, 212);
            this.linemanFormDateTB.Name = "linemanFormDateTB";
            this.linemanFormDateTB.Size = new System.Drawing.Size(100, 20);
            this.linemanFormDateTB.TabIndex = 89;
            this.linemanFormDateTB.TextChanged += new System.EventHandler(this.linemanFormDateTB_TextChanged);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Location = new System.Drawing.Point(194, 191);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(84, 13);
            this.label9.TabIndex = 92;
            this.label9.Text = "ENTER EMPID:";
            // 
            // linemanFormUserIdTB
            // 
            this.linemanFormUserIdTB.Location = new System.Drawing.Point(228, 212);
            this.linemanFormUserIdTB.Name = "linemanFormUserIdTB";
            this.linemanFormUserIdTB.Size = new System.Drawing.Size(100, 20);
            this.linemanFormUserIdTB.TabIndex = 91;
            // 
            // linemandataGridView
            // 
            this.linemandataGridView.BackgroundColor = System.Drawing.SystemColors.ActiveCaption;
            this.linemandataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.linemandataGridView.Location = new System.Drawing.Point(498, 12);
            this.linemandataGridView.Name = "linemandataGridView";
            this.linemandataGridView.Size = new System.Drawing.Size(263, 177);
            this.linemandataGridView.TabIndex = 93;
            // 
            // LinemanForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.linemandataGridView);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.linemanFormUserIdTB);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.linemanFormDateTB);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.linemanDieselidTB);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.linemanOctaneidTB);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.linemanPetrolidTB);
            this.Controls.Add(this.linemanConfirmBTN);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.linemanDieselTB);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.linemanOctaneTB);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.linemanPetrolTB);
            this.Controls.Add(this.linemanLogoutBTN);
            this.Controls.Add(this.linemanPrintAllLiftBTN);
            this.Controls.Add(this.label1);
            this.Name = "LinemanForm";
            this.Text = "LinemanForm";
            ((System.ComponentModel.ISupportInitialize)(this.linemandataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button linemanLogoutBTN;
        private System.Windows.Forms.Button linemanPrintAllLiftBTN;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox linemanPetrolTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.TextBox linemanOctaneTB;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox linemanDieselTB;
        private System.Windows.Forms.Button linemanConfirmBTN;
        private System.Windows.Forms.TextBox linemanPetrolidTB;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.TextBox linemanOctaneidTB;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.TextBox linemanDieselidTB;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.TextBox linemanFormDateTB;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.TextBox linemanFormUserIdTB;
        private System.Windows.Forms.DataGridView linemandataGridView;
    }
}