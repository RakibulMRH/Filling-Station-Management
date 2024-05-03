
namespace FillingStationManagementSystem.Forms
{
    partial class LoadingForm
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
            this.progressBar2 = new System.Windows.Forms.ProgressBar();
            this.timer1 = new System.Windows.Forms.Timer(this.components);
            this.label1 = new System.Windows.Forms.Label();
            this.loadingFormPanel = new System.Windows.Forms.Panel();
            this.SuspendLayout();
            // 
            // progressBar2
            // 
            this.progressBar2.BackColor = System.Drawing.SystemColors.ControlLight;
            this.progressBar2.Location = new System.Drawing.Point(599, 426);
            this.progressBar2.Name = "progressBar2";
            this.progressBar2.Size = new System.Drawing.Size(189, 12);
            this.progressBar2.TabIndex = 44;
            this.progressBar2.Click += new System.EventHandler(this.progressBar2_Click);
            // 
            // timer1
            // 
            this.timer1.Enabled = true;
            this.timer1.Tick += new System.EventHandler(this.timer1_Tick);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Old English Text MT", 17.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DarkGray;
            this.label1.Location = new System.Drawing.Point(594, 396);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(171, 27);
            this.label1.TabIndex = 45;
            this.label1.Text = "LOADING...";
            // 
            // loadingFormPanel
            // 
            this.loadingFormPanel.BackColor = System.Drawing.Color.Transparent;
            this.loadingFormPanel.Dock = System.Windows.Forms.DockStyle.Top;
            this.loadingFormPanel.Location = new System.Drawing.Point(0, 0);
            this.loadingFormPanel.Name = "loadingFormPanel";
            this.loadingFormPanel.Size = new System.Drawing.Size(800, 48);
            this.loadingFormPanel.TabIndex = 46;
            this.loadingFormPanel.MouseDown += new System.Windows.Forms.MouseEventHandler(this.loadingMouseDown);
            this.loadingFormPanel.MouseMove += new System.Windows.Forms.MouseEventHandler(this.loadingMouseMove);
            // 
            // LoadingForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::FillingStationManagementSystem.Properties.Resources.cp2077officialscreen_a_mercenary_on_the_rise4_1528675137808_160w;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.loadingFormPanel);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.progressBar2);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Name = "LoadingForm";
            this.Text = "LoadingForm";
            this.Load += new System.EventHandler(this.LoadingForm_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.ProgressBar progressBar2;
        private System.Windows.Forms.Timer timer1;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel loadingFormPanel;
    }
}