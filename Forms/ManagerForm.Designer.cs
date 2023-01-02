
namespace FillingStationManagementSystem
{
    partial class ManagerForm
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
            this.managerLogoutBTN = new System.Windows.Forms.Button();
            this.managerShowStocksBTN = new System.Windows.Forms.Button();
            this.managerShowEmpBTN = new System.Windows.Forms.Button();
            this.managerAttendenanceBTN = new System.Windows.Forms.Button();
            this.label4 = new System.Windows.Forms.Label();
            this.managerTrxIdTB = new System.Windows.Forms.TextBox();
            this.managerRemoveTrxBTN = new System.Windows.Forms.Button();
            this.ceoShowTrxBTN = new System.Windows.Forms.Button();
            this.managerDataGridView = new System.Windows.Forms.DataGridView();
            ((System.ComponentModel.ISupportInitialize)(this.managerDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 15.75F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Purple;
            this.label1.Location = new System.Drawing.Point(224, 24);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(241, 25);
            this.label1.TabIndex = 6;
            this.label1.Text = "Welcome,Mr Manager";
            // 
            // managerLogoutBTN
            // 
            this.managerLogoutBTN.BackColor = System.Drawing.Color.Blue;
            this.managerLogoutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerLogoutBTN.ForeColor = System.Drawing.Color.White;
            this.managerLogoutBTN.Location = new System.Drawing.Point(707, 405);
            this.managerLogoutBTN.Name = "managerLogoutBTN";
            this.managerLogoutBTN.Size = new System.Drawing.Size(81, 33);
            this.managerLogoutBTN.TabIndex = 55;
            this.managerLogoutBTN.Text = "Log-Out";
            this.managerLogoutBTN.UseVisualStyleBackColor = false;
            this.managerLogoutBTN.Click += new System.EventHandler(this.managerLogoutBTN_Click);
            // 
            // managerShowStocksBTN
            // 
            this.managerShowStocksBTN.BackColor = System.Drawing.Color.Blue;
            this.managerShowStocksBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerShowStocksBTN.ForeColor = System.Drawing.Color.White;
            this.managerShowStocksBTN.Location = new System.Drawing.Point(29, 210);
            this.managerShowStocksBTN.Name = "managerShowStocksBTN";
            this.managerShowStocksBTN.Size = new System.Drawing.Size(205, 33);
            this.managerShowStocksBTN.TabIndex = 53;
            this.managerShowStocksBTN.Text = "Show All Stocks";
            this.managerShowStocksBTN.UseVisualStyleBackColor = false;
            this.managerShowStocksBTN.Click += new System.EventHandler(this.managerShowStocksBTN_Click);
            // 
            // managerShowEmpBTN
            // 
            this.managerShowEmpBTN.BackColor = System.Drawing.Color.Blue;
            this.managerShowEmpBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerShowEmpBTN.ForeColor = System.Drawing.Color.White;
            this.managerShowEmpBTN.Location = new System.Drawing.Point(29, 101);
            this.managerShowEmpBTN.Name = "managerShowEmpBTN";
            this.managerShowEmpBTN.Size = new System.Drawing.Size(205, 33);
            this.managerShowEmpBTN.TabIndex = 51;
            this.managerShowEmpBTN.Text = "Show All Employees";
            this.managerShowEmpBTN.UseVisualStyleBackColor = false;
            this.managerShowEmpBTN.Click += new System.EventHandler(this.managerShowEmpBTN_Click);
            // 
            // managerAttendenanceBTN
            // 
            this.managerAttendenanceBTN.BackColor = System.Drawing.Color.Blue;
            this.managerAttendenanceBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerAttendenanceBTN.ForeColor = System.Drawing.Color.White;
            this.managerAttendenanceBTN.Location = new System.Drawing.Point(29, 405);
            this.managerAttendenanceBTN.Name = "managerAttendenanceBTN";
            this.managerAttendenanceBTN.Size = new System.Drawing.Size(108, 33);
            this.managerAttendenanceBTN.TabIndex = 56;
            this.managerAttendenanceBTN.Text = "Attendance";
            this.managerAttendenanceBTN.UseVisualStyleBackColor = false;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(26, 281);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 79;
            this.label4.Text = "Enter Trx ID";
            // 
            // managerTrxIdTB
            // 
            this.managerTrxIdTB.Location = new System.Drawing.Point(96, 278);
            this.managerTrxIdTB.Name = "managerTrxIdTB";
            this.managerTrxIdTB.Size = new System.Drawing.Size(100, 20);
            this.managerTrxIdTB.TabIndex = 78;
            // 
            // managerRemoveTrxBTN
            // 
            this.managerRemoveTrxBTN.BackColor = System.Drawing.Color.Blue;
            this.managerRemoveTrxBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.managerRemoveTrxBTN.ForeColor = System.Drawing.Color.White;
            this.managerRemoveTrxBTN.Location = new System.Drawing.Point(29, 304);
            this.managerRemoveTrxBTN.Name = "managerRemoveTrxBTN";
            this.managerRemoveTrxBTN.Size = new System.Drawing.Size(180, 34);
            this.managerRemoveTrxBTN.TabIndex = 77;
            this.managerRemoveTrxBTN.Text = "Remove  Transaction";
            this.managerRemoveTrxBTN.UseVisualStyleBackColor = false;
            this.managerRemoveTrxBTN.Click += new System.EventHandler(this.managerRemoveTrxBTN_Click);
            // 
            // ceoShowTrxBTN
            // 
            this.ceoShowTrxBTN.BackColor = System.Drawing.Color.Blue;
            this.ceoShowTrxBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceoShowTrxBTN.ForeColor = System.Drawing.Color.White;
            this.ceoShowTrxBTN.Location = new System.Drawing.Point(29, 156);
            this.ceoShowTrxBTN.Name = "ceoShowTrxBTN";
            this.ceoShowTrxBTN.Size = new System.Drawing.Size(205, 33);
            this.ceoShowTrxBTN.TabIndex = 76;
            this.ceoShowTrxBTN.Text = "Show All Transactions";
            this.ceoShowTrxBTN.UseVisualStyleBackColor = false;
            this.ceoShowTrxBTN.Click += new System.EventHandler(this.ceoShowTrxBTN_Click);
            // 
            // managerDataGridView
            // 
            this.managerDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.managerDataGridView.Location = new System.Drawing.Point(356, 97);
            this.managerDataGridView.Name = "managerDataGridView";
            this.managerDataGridView.Size = new System.Drawing.Size(377, 241);
            this.managerDataGridView.TabIndex = 81;
            this.managerDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.managerDataGridView_CellContentClick);
            // 
            // ManagerForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.managerDataGridView);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.managerTrxIdTB);
            this.Controls.Add(this.managerRemoveTrxBTN);
            this.Controls.Add(this.ceoShowTrxBTN);
            this.Controls.Add(this.managerAttendenanceBTN);
            this.Controls.Add(this.managerLogoutBTN);
            this.Controls.Add(this.managerShowStocksBTN);
            this.Controls.Add(this.managerShowEmpBTN);
            this.Controls.Add(this.label1);
            this.Name = "ManagerForm";
            this.Text = "Manager";
            ((System.ComponentModel.ISupportInitialize)(this.managerDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button managerLogoutBTN;
        private System.Windows.Forms.Button managerShowStocksBTN;
        private System.Windows.Forms.Button managerShowEmpBTN;
        private System.Windows.Forms.Button managerAttendenanceBTN;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.TextBox managerTrxIdTB;
        private System.Windows.Forms.Button managerRemoveTrxBTN;
        private System.Windows.Forms.Button ceoShowTrxBTN;
        private System.Windows.Forms.DataGridView managerDataGridView;
    }
}