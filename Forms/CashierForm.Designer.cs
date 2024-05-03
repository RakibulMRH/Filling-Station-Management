
namespace FillingStationManagementSystem
{
    partial class CashierForm
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
            this.label1 = new System.Windows.Forms.Label();
            this.cashierShowTrxBTN = new System.Windows.Forms.Button();
            this.cashierRemoveTrxBTN = new System.Windows.Forms.Button();
            this.cashierLogotBTN = new System.Windows.Forms.Button();
            this.cashierRemoveTrxTB = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.cashierAttendanceBTN = new System.Windows.Forms.Button();
            this.cashierDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(217, 21);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(205, 33);
            this.label1.TabIndex = 11;
            this.label1.Text = "Welcome,  Cashier";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // cashierShowTrxBTN
            // 
            this.cashierShowTrxBTN.BackColor = System.Drawing.Color.Blue;
            this.cashierShowTrxBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierShowTrxBTN.ForeColor = System.Drawing.Color.White;
            this.cashierShowTrxBTN.Location = new System.Drawing.Point(586, 308);
            this.cashierShowTrxBTN.Name = "cashierShowTrxBTN";
            this.cashierShowTrxBTN.Size = new System.Drawing.Size(205, 33);
            this.cashierShowTrxBTN.TabIndex = 62;
            this.cashierShowTrxBTN.Text = "Show All Transactions";
            this.cashierShowTrxBTN.UseVisualStyleBackColor = false;
            this.cashierShowTrxBTN.Click += new System.EventHandler(this.cashierShowTrxBTN_Click);
            // 
            // cashierRemoveTrxBTN
            // 
            this.cashierRemoveTrxBTN.BackColor = System.Drawing.Color.Blue;
            this.cashierRemoveTrxBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierRemoveTrxBTN.ForeColor = System.Drawing.Color.White;
            this.cashierRemoveTrxBTN.Location = new System.Drawing.Point(603, 190);
            this.cashierRemoveTrxBTN.Name = "cashierRemoveTrxBTN";
            this.cashierRemoveTrxBTN.Size = new System.Drawing.Size(188, 33);
            this.cashierRemoveTrxBTN.TabIndex = 63;
            this.cashierRemoveTrxBTN.Text = "Remove Transaction";
            this.cashierRemoveTrxBTN.UseVisualStyleBackColor = false;
            // 
            // cashierLogotBTN
            // 
            this.cashierLogotBTN.BackColor = System.Drawing.Color.Red;
            this.cashierLogotBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierLogotBTN.ForeColor = System.Drawing.Color.White;
            this.cashierLogotBTN.Location = new System.Drawing.Point(687, 405);
            this.cashierLogotBTN.Name = "cashierLogotBTN";
            this.cashierLogotBTN.Size = new System.Drawing.Size(101, 33);
            this.cashierLogotBTN.TabIndex = 66;
            this.cashierLogotBTN.Text = "Log-Out";
            this.cashierLogotBTN.UseVisualStyleBackColor = false;
            this.cashierLogotBTN.Click += new System.EventHandler(this.cashierLogotBTN_Click);
            // 
            // cashierRemoveTrxTB
            // 
            this.cashierRemoveTrxTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierRemoveTrxTB.Location = new System.Drawing.Point(623, 153);
            this.cashierRemoveTrxTB.Name = "cashierRemoveTrxTB";
            this.cashierRemoveTrxTB.Size = new System.Drawing.Size(168, 31);
            this.cashierRemoveTrxTB.TabIndex = 67;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(600, 128);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(105, 13);
            this.label2.TabIndex = 68;
            this.label2.Text = "Enter Transaction ID";
            // 
            // cashierAttendanceBTN
            // 
            this.cashierAttendanceBTN.BackColor = System.Drawing.Color.Blue;
            this.cashierAttendanceBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cashierAttendanceBTN.ForeColor = System.Drawing.Color.White;
            this.cashierAttendanceBTN.Location = new System.Drawing.Point(12, 405);
            this.cashierAttendanceBTN.Name = "cashierAttendanceBTN";
            this.cashierAttendanceBTN.Size = new System.Drawing.Size(101, 33);
            this.cashierAttendanceBTN.TabIndex = 69;
            this.cashierAttendanceBTN.Text = "Attendance";
            this.cashierAttendanceBTN.UseVisualStyleBackColor = false;
            // 
            // cashierDataGridView
            // 
            this.cashierDataGridView.AllowUserToAddRows = false;
            this.cashierDataGridView.AllowUserToDeleteRows = false;
            this.cashierDataGridView.AllowUserToOrderColumns = true;
            this.cashierDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.cashierDataGridView.Location = new System.Drawing.Point(12, 76);
            this.cashierDataGridView.Name = "cashierDataGridView";
            this.cashierDataGridView.ReadOnly = true;
            this.cashierDataGridView.Size = new System.Drawing.Size(560, 265);
            this.cashierDataGridView.TabIndex = 70;
            this.cashierDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.cashierDataGridView_CellContentClick);
            // 
            // CashierForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.cashierDataGridView);
            this.Controls.Add(this.cashierAttendanceBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.cashierRemoveTrxTB);
            this.Controls.Add(this.cashierLogotBTN);
            this.Controls.Add(this.cashierRemoveTrxBTN);
            this.Controls.Add(this.cashierShowTrxBTN);
            this.Controls.Add(this.label1);
            this.Name = "CashierForm";
            this.Text = "Cashier";
            ((System.ComponentModel.ISupportInitialize)(this.cashierDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button cashierShowTrxBTN;
        private System.Windows.Forms.Button cashierRemoveTrxBTN;
        private System.Windows.Forms.Button cashierLogotBTN;
        private System.Windows.Forms.TextBox cashierRemoveTrxTB;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button cashierAttendanceBTN;
        private System.Windows.Forms.DataGridView cashierDataGridView;
    }
}