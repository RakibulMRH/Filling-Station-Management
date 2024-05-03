
namespace FillingStationManagementSystem
{
    partial class CEOForm
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
            this.components = new System.ComponentModel.Container();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.ceoLiftdTB = new System.Windows.Forms.TextBox();
            this.ceoTrxIdTB = new System.Windows.Forms.TextBox();
            this.ceoEmpIdTB = new System.Windows.Forms.TextBox();
            this.ceoRemoveStockBTN = new System.Windows.Forms.Button();
            this.ceoRemoveTrxBTN = new System.Windows.Forms.Button();
            this.ceoRemoveEmpBTN = new System.Windows.Forms.Button();
            this.ceoLogoutBTN = new System.Windows.Forms.Button();
            this.ceoShowStocksBTN = new System.Windows.Forms.Button();
            this.ceoShowTrxBTN = new System.Windows.Forms.Button();
            this.ceoEmpShowBTN = new System.Windows.Forms.Button();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.ceoEnterEmployeeBTN = new System.Windows.Forms.Button();
            this.ceoDataGridView = new System.Windows.Forms.DataGridView();
            this.button1 = new System.Windows.Forms.Button();
            this.ceoShowTransactionBTN = new System.Windows.Forms.Button();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.ceoDataGridView)).BeginInit();
            this.SuspendLayout();
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Location = new System.Drawing.Point(616, 265);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(63, 13);
            this.label5.TabIndex = 75;
            this.label5.Text = "Enter Lift ID";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Location = new System.Drawing.Point(609, 168);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(64, 13);
            this.label4.TabIndex = 74;
            this.label4.Text = "Enter Trx ID";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(610, 73);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 13);
            this.label1.TabIndex = 73;
            this.label1.Text = "Enter Emp ID";
            // 
            // ceoLiftdTB
            // 
            this.ceoLiftdTB.Location = new System.Drawing.Point(685, 259);
            this.ceoLiftdTB.Name = "ceoLiftdTB";
            this.ceoLiftdTB.Size = new System.Drawing.Size(100, 20);
            this.ceoLiftdTB.TabIndex = 72;
            this.ceoLiftdTB.TextChanged += new System.EventHandler(this.ceoLiftdTB_TextChanged);
            // 
            // ceoTrxIdTB
            // 
            this.ceoTrxIdTB.Location = new System.Drawing.Point(690, 168);
            this.ceoTrxIdTB.Name = "ceoTrxIdTB";
            this.ceoTrxIdTB.Size = new System.Drawing.Size(100, 20);
            this.ceoTrxIdTB.TabIndex = 71;
            // 
            // ceoEmpIdTB
            // 
            this.ceoEmpIdTB.Location = new System.Drawing.Point(691, 73);
            this.ceoEmpIdTB.Name = "ceoEmpIdTB";
            this.ceoEmpIdTB.Size = new System.Drawing.Size(100, 20);
            this.ceoEmpIdTB.TabIndex = 70;
            // 
            // ceoRemoveStockBTN
            // 
            this.ceoRemoveStockBTN.BackColor = System.Drawing.Color.Blue;
            this.ceoRemoveStockBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceoRemoveStockBTN.ForeColor = System.Drawing.Color.White;
            this.ceoRemoveStockBTN.Location = new System.Drawing.Point(616, 294);
            this.ceoRemoveStockBTN.Name = "ceoRemoveStockBTN";
            this.ceoRemoveStockBTN.Size = new System.Drawing.Size(174, 32);
            this.ceoRemoveStockBTN.TabIndex = 69;
            this.ceoRemoveStockBTN.Text = "Remove Stocks";
            this.ceoRemoveStockBTN.UseVisualStyleBackColor = false;
            this.ceoRemoveStockBTN.Click += new System.EventHandler(this.ceoRemoveStockBTN_Click);
            // 
            // ceoRemoveTrxBTN
            // 
            this.ceoRemoveTrxBTN.BackColor = System.Drawing.Color.Blue;
            this.ceoRemoveTrxBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceoRemoveTrxBTN.ForeColor = System.Drawing.Color.White;
            this.ceoRemoveTrxBTN.Location = new System.Drawing.Point(621, 194);
            this.ceoRemoveTrxBTN.Name = "ceoRemoveTrxBTN";
            this.ceoRemoveTrxBTN.Size = new System.Drawing.Size(170, 35);
            this.ceoRemoveTrxBTN.TabIndex = 68;
            this.ceoRemoveTrxBTN.Text = "Remove  Transaction";
            this.ceoRemoveTrxBTN.UseVisualStyleBackColor = false;
            this.ceoRemoveTrxBTN.Click += new System.EventHandler(this.ceoRemoveTrxBTN_Click);
            // 
            // ceoRemoveEmpBTN
            // 
            this.ceoRemoveEmpBTN.BackColor = System.Drawing.Color.Blue;
            this.ceoRemoveEmpBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceoRemoveEmpBTN.ForeColor = System.Drawing.Color.White;
            this.ceoRemoveEmpBTN.Location = new System.Drawing.Point(621, 99);
            this.ceoRemoveEmpBTN.Name = "ceoRemoveEmpBTN";
            this.ceoRemoveEmpBTN.Size = new System.Drawing.Size(170, 33);
            this.ceoRemoveEmpBTN.TabIndex = 67;
            this.ceoRemoveEmpBTN.Text = "Remove an Employee";
            this.ceoRemoveEmpBTN.UseVisualStyleBackColor = false;
            this.ceoRemoveEmpBTN.Click += new System.EventHandler(this.ceoRemoveEmpBTN_Click);
            // 
            // ceoLogoutBTN
            // 
            this.ceoLogoutBTN.BackColor = System.Drawing.Color.Red;
            this.ceoLogoutBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceoLogoutBTN.ForeColor = System.Drawing.Color.White;
            this.ceoLogoutBTN.Location = new System.Drawing.Point(709, 398);
            this.ceoLogoutBTN.Name = "ceoLogoutBTN";
            this.ceoLogoutBTN.Size = new System.Drawing.Size(81, 33);
            this.ceoLogoutBTN.TabIndex = 66;
            this.ceoLogoutBTN.Text = "Log-Out";
            this.ceoLogoutBTN.UseVisualStyleBackColor = false;
            this.ceoLogoutBTN.Click += new System.EventHandler(this.ceoLogoutBTN_Click);
            // 
            // ceoShowStocksBTN
            // 
            this.ceoShowStocksBTN.BackColor = System.Drawing.Color.Blue;
            this.ceoShowStocksBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceoShowStocksBTN.ForeColor = System.Drawing.Color.White;
            this.ceoShowStocksBTN.Location = new System.Drawing.Point(12, 181);
            this.ceoShowStocksBTN.Name = "ceoShowStocksBTN";
            this.ceoShowStocksBTN.Size = new System.Drawing.Size(163, 41);
            this.ceoShowStocksBTN.TabIndex = 64;
            this.ceoShowStocksBTN.Text = "Show All Stocks";
            this.ceoShowStocksBTN.UseVisualStyleBackColor = false;
            this.ceoShowStocksBTN.Click += new System.EventHandler(this.ceoShowStocksBTN_Click);
            // 
            // ceoShowTrxBTN
            // 
            this.ceoShowTrxBTN.BackColor = System.Drawing.Color.Blue;
            this.ceoShowTrxBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceoShowTrxBTN.ForeColor = System.Drawing.Color.White;
            this.ceoShowTrxBTN.Location = new System.Drawing.Point(12, 120);
            this.ceoShowTrxBTN.Name = "ceoShowTrxBTN";
            this.ceoShowTrxBTN.Size = new System.Drawing.Size(163, 40);
            this.ceoShowTrxBTN.TabIndex = 63;
            this.ceoShowTrxBTN.Text = "Show All Customer";
            this.ceoShowTrxBTN.UseVisualStyleBackColor = false;
            this.ceoShowTrxBTN.Click += new System.EventHandler(this.ceoShowTrxBTN_Click);
            // 
            // ceoEmpShowBTN
            // 
            this.ceoEmpShowBTN.BackColor = System.Drawing.Color.Blue;
            this.ceoEmpShowBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceoEmpShowBTN.ForeColor = System.Drawing.Color.White;
            this.ceoEmpShowBTN.Location = new System.Drawing.Point(12, 62);
            this.ceoEmpShowBTN.Name = "ceoEmpShowBTN";
            this.ceoEmpShowBTN.Size = new System.Drawing.Size(163, 39);
            this.ceoEmpShowBTN.TabIndex = 62;
            this.ceoEmpShowBTN.Text = "Show All Employees";
            this.ceoEmpShowBTN.UseVisualStyleBackColor = false;
            this.ceoEmpShowBTN.Click += new System.EventHandler(this.ceoEmpShowBTN_Click);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(12, 428);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(48, 13);
            this.label3.TabIndex = 59;
            this.label3.Text = "By time";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Yellow;
            this.label2.Location = new System.Drawing.Point(259, 9);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(218, 33);
            this.label2.TabIndex = 58;
            this.label2.Text = "Welcome ,Mr CEO ";
            this.label2.Click += new System.EventHandler(this.label2_Click);
            // 
            // ceoEnterEmployeeBTN
            // 
            this.ceoEnterEmployeeBTN.BackColor = System.Drawing.Color.DarkOrange;
            this.ceoEnterEmployeeBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceoEnterEmployeeBTN.ForeColor = System.Drawing.Color.White;
            this.ceoEnterEmployeeBTN.Location = new System.Drawing.Point(12, 276);
            this.ceoEnterEmployeeBTN.Name = "ceoEnterEmployeeBTN";
            this.ceoEnterEmployeeBTN.Size = new System.Drawing.Size(174, 37);
            this.ceoEnterEmployeeBTN.TabIndex = 76;
            this.ceoEnterEmployeeBTN.Text = "Enter a new employee!!";
            this.ceoEnterEmployeeBTN.UseVisualStyleBackColor = false;
            this.ceoEnterEmployeeBTN.Click += new System.EventHandler(this.ceoEnterEmployeeBTN_Click);
            // 
            // ceoDataGridView
            // 
            this.ceoDataGridView.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.ceoDataGridView.Location = new System.Drawing.Point(201, 60);
            this.ceoDataGridView.Name = "ceoDataGridView";
            this.ceoDataGridView.Size = new System.Drawing.Size(402, 296);
            this.ceoDataGridView.TabIndex = 77;
            this.ceoDataGridView.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.ceoDataGridView_CellContentClick);
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.SystemColors.AppWorkspace;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Location = new System.Drawing.Point(12, 324);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(174, 32);
            this.button1.TabIndex = 78;
            this.button1.Text = "Switch to lineman";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // ceoShowTransactionBTN
            // 
            this.ceoShowTransactionBTN.BackColor = System.Drawing.Color.Blue;
            this.ceoShowTransactionBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ceoShowTransactionBTN.ForeColor = System.Drawing.Color.White;
            this.ceoShowTransactionBTN.Location = new System.Drawing.Point(12, 228);
            this.ceoShowTransactionBTN.Name = "ceoShowTransactionBTN";
            this.ceoShowTransactionBTN.Size = new System.Drawing.Size(163, 41);
            this.ceoShowTransactionBTN.TabIndex = 79;
            this.ceoShowTransactionBTN.Text = "Show All Transaction";
            this.ceoShowTransactionBTN.UseVisualStyleBackColor = false;
            this.ceoShowTransactionBTN.Click += new System.EventHandler(this.ceoShowTransactionBTN_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // CEOForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.InactiveCaption;
            this.BackgroundImage = global::FillingStationManagementSystem.Properties.Resources.HD_wallpaper_neon_waves_purple_reflection_abstract;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.ceoShowTransactionBTN);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.ceoDataGridView);
            this.Controls.Add(this.ceoEnterEmployeeBTN);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.ceoLiftdTB);
            this.Controls.Add(this.ceoTrxIdTB);
            this.Controls.Add(this.ceoEmpIdTB);
            this.Controls.Add(this.ceoRemoveStockBTN);
            this.Controls.Add(this.ceoRemoveTrxBTN);
            this.Controls.Add(this.ceoRemoveEmpBTN);
            this.Controls.Add(this.ceoLogoutBTN);
            this.Controls.Add(this.ceoShowStocksBTN);
            this.Controls.Add(this.ceoShowTrxBTN);
            this.Controls.Add(this.ceoEmpShowBTN);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.label2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "CEOForm";
            this.Text = "CEOForm";
            this.Load += new System.EventHandler(this.CEOForm_Load);
            ((System.ComponentModel.ISupportInitialize)(this.ceoDataGridView)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox ceoLiftdTB;
        private System.Windows.Forms.TextBox ceoTrxIdTB;
        private System.Windows.Forms.TextBox ceoEmpIdTB;
        private System.Windows.Forms.Button ceoRemoveStockBTN;
        private System.Windows.Forms.Button ceoRemoveTrxBTN;
        private System.Windows.Forms.Button ceoRemoveEmpBTN;
        private System.Windows.Forms.Button ceoLogoutBTN;
        private System.Windows.Forms.Button ceoShowStocksBTN;
        private System.Windows.Forms.Button ceoShowTrxBTN;
        private System.Windows.Forms.Button ceoEmpShowBTN;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button ceoEnterEmployeeBTN;
        private System.Windows.Forms.DataGridView ceoDataGridView;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Button ceoShowTransactionBTN;
        private System.Windows.Forms.Timer timer1;
    }
}