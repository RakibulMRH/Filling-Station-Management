
namespace FillingStationManagementSystem
{
    partial class LoginForm
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
            this.label3 = new System.Windows.Forms.Label();
            this.logInFormExitButton = new System.Windows.Forms.Button();
            this.loginRegisterBTN = new System.Windows.Forms.Button();
            this.logInUserNameTB = new System.Windows.Forms.TextBox();
            this.loginPasswordTB = new System.Windows.Forms.TextBox();
            this.loginBTN = new System.Windows.Forms.Button();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // label3
            // 
            this.label3.AllowDrop = true;
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Monotype Corsiva", 20.25F, ((System.Drawing.FontStyle)((System.Drawing.FontStyle.Bold | System.Drawing.FontStyle.Italic))), System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Snow;
            this.label3.Location = new System.Drawing.Point(179, 9);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(441, 33);
            this.label3.TabIndex = 38;
            this.label3.Text = "Welcome to filling Station Management ";
            this.label3.Click += new System.EventHandler(this.label3_Click);
            // 
            // logInFormExitButton
            // 
            this.logInFormExitButton.BackColor = System.Drawing.Color.Red;
            this.logInFormExitButton.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInFormExitButton.ForeColor = System.Drawing.Color.White;
            this.logInFormExitButton.Location = new System.Drawing.Point(719, 405);
            this.logInFormExitButton.Name = "logInFormExitButton";
            this.logInFormExitButton.Size = new System.Drawing.Size(59, 33);
            this.logInFormExitButton.TabIndex = 36;
            this.logInFormExitButton.Text = "EXIT";
            this.logInFormExitButton.UseVisualStyleBackColor = false;
            this.logInFormExitButton.Click += new System.EventHandler(this.logInFormExitButton_Click);
            // 
            // loginRegisterBTN
            // 
            this.loginRegisterBTN.BackColor = System.Drawing.Color.Blue;
            this.loginRegisterBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginRegisterBTN.ForeColor = System.Drawing.Color.White;
            this.loginRegisterBTN.Location = new System.Drawing.Point(521, 289);
            this.loginRegisterBTN.Name = "loginRegisterBTN";
            this.loginRegisterBTN.Size = new System.Drawing.Size(81, 33);
            this.loginRegisterBTN.TabIndex = 35;
            this.loginRegisterBTN.Text = "Register";
            this.loginRegisterBTN.UseVisualStyleBackColor = false;
            this.loginRegisterBTN.Click += new System.EventHandler(this.loginRegisterBTN_Click);
            // 
            // logInUserNameTB
            // 
            this.logInUserNameTB.BackColor = System.Drawing.Color.Aqua;
            this.logInUserNameTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.logInUserNameTB.ForeColor = System.Drawing.SystemColors.WindowText;
            this.logInUserNameTB.Location = new System.Drawing.Point(411, 207);
            this.logInUserNameTB.Name = "logInUserNameTB";
            this.logInUserNameTB.Size = new System.Drawing.Size(191, 22);
            this.logInUserNameTB.TabIndex = 34;
            // 
            // loginPasswordTB
            // 
            this.loginPasswordTB.BackColor = System.Drawing.Color.Yellow;
            this.loginPasswordTB.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginPasswordTB.Location = new System.Drawing.Point(411, 250);
            this.loginPasswordTB.Name = "loginPasswordTB";
            this.loginPasswordTB.PasswordChar = '*';
            this.loginPasswordTB.Size = new System.Drawing.Size(191, 22);
            this.loginPasswordTB.TabIndex = 33;
            // 
            // loginBTN
            // 
            this.loginBTN.BackColor = System.Drawing.Color.Green;
            this.loginBTN.Font = new System.Drawing.Font("Microsoft Sans Serif", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.loginBTN.ForeColor = System.Drawing.Color.White;
            this.loginBTN.Location = new System.Drawing.Point(441, 289);
            this.loginBTN.Name = "loginBTN";
            this.loginBTN.Size = new System.Drawing.Size(69, 33);
            this.loginBTN.TabIndex = 32;
            this.loginBTN.Text = "Login";
            this.loginBTN.UseVisualStyleBackColor = false;
            this.loginBTN.Click += new System.EventHandler(this.loginBTN_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Tomato;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(305, 248);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(86, 20);
            this.label2.TabIndex = 31;
            this.label2.Text = "Password";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.SystemColors.ControlText;
            this.label1.Location = new System.Drawing.Point(305, 207);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(91, 20);
            this.label1.TabIndex = 30;
            this.label1.Text = "Username";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // LoginForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FillingStationManagementSystem.Properties.Resources.df0cmye_a9e6502b_9c4d_4e59_a112_0e761e46d135;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.logInFormExitButton);
            this.Controls.Add(this.loginRegisterBTN);
            this.Controls.Add(this.logInUserNameTB);
            this.Controls.Add(this.loginPasswordTB);
            this.Controls.Add(this.loginBTN);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.label1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoginForm";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.LoginForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Button logInFormExitButton;
        private System.Windows.Forms.Button loginRegisterBTN;
        private System.Windows.Forms.TextBox logInUserNameTB;
        private System.Windows.Forms.TextBox loginPasswordTB;
        private System.Windows.Forms.Button loginBTN;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
    }
}