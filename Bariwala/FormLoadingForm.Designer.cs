namespace Bariwala
{
    partial class FormLoadingApp
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
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.progressBarLoading = new System.Windows.Forms.ProgressBar();
            this.btnToLoginForm = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.TimerForLoadingBar = new System.Windows.Forms.Timer(this.components);
            this.lblLoadingBar = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 412);
            this.panel1.TabIndex = 0;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.pictureBox1.Image = global::Bariwala.Properties.Resources.BariwalaLogo;
            this.pictureBox1.Location = new System.Drawing.Point(0, 0);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(394, 412);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // progressBarLoading
            // 
            this.progressBarLoading.Location = new System.Drawing.Point(34, 556);
            this.progressBarLoading.MarqueeAnimationSpeed = 50;
            this.progressBarLoading.Name = "progressBarLoading";
            this.progressBarLoading.Size = new System.Drawing.Size(318, 21);
            this.progressBarLoading.TabIndex = 1;
            // 
            // btnToLoginForm
            // 
            this.btnToLoginForm.Location = new System.Drawing.Point(154, 502);
            this.btnToLoginForm.Name = "btnToLoginForm";
            this.btnToLoginForm.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnToLoginForm.Size = new System.Drawing.Size(99, 32);
            this.btnToLoginForm.TabIndex = 2;
            this.btnToLoginForm.Values.Text = "Next";
            this.btnToLoginForm.Click += new System.EventHandler(this.btnToLoginForm_Click);
            // 
            // TimerForLoadingBar
            // 
            this.TimerForLoadingBar.Tick += new System.EventHandler(this.TimerForLoadingBar_Tick);
            // 
            // lblLoadingBar
            // 
            this.lblLoadingBar.AutoSize = true;
            this.lblLoadingBar.BackColor = System.Drawing.Color.Transparent;
            this.lblLoadingBar.Font = new System.Drawing.Font("Minion Pro", 9.749999F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblLoadingBar.Location = new System.Drawing.Point(355, 557);
            this.lblLoadingBar.Name = "lblLoadingBar";
            this.lblLoadingBar.Size = new System.Drawing.Size(18, 18);
            this.lblLoadingBar.TabIndex = 3;
            this.lblLoadingBar.Text = "%";
            this.lblLoadingBar.Visible = false;
            // 
            // FormLoadingApp
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.lblLoadingBar);
            this.Controls.Add(this.btnToLoginForm);
            this.Controls.Add(this.progressBarLoading);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "FormLoadingApp";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "বাড়ীওয়ালা";
            this.Load += new System.EventHandler(this.FormLoadingApp_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.ProgressBar progressBarLoading;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnToLoginForm;
        private System.Windows.Forms.Timer TimerForLoadingBar;
        private System.Windows.Forms.Label lblLoadingBar;
    }
}

