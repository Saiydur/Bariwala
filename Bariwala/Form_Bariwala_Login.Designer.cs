namespace Bariwala
{
    partial class Form_Bariwala_Login
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
            this.GroupBoxLoginUser = new Guna.UI2.WinForms.Guna2GroupBox();
            this.tableLayoutPanel1 = new System.Windows.Forms.TableLayoutPanel();
            this.btnCreateAccount = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.panel2 = new System.Windows.Forms.Panel();
            this.btnForgetPass = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.btnLogin = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.checkBoxShowPass = new MaterialSkin.Controls.MaterialCheckbox();
            this.lblPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblUserName = new MaterialSkin.Controls.MaterialLabel();
            this.txtLoginFormUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtLoginFormUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.errorProviderUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUserPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.GroupBoxLoginUser.SuspendLayout();
            this.tableLayoutPanel1.SuspendLayout();
            this.panel2.SuspendLayout();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserPassword)).BeginInit();
            this.SuspendLayout();
            // 
            // GroupBoxLoginUser
            // 
            this.GroupBoxLoginUser.Controls.Add(this.tableLayoutPanel1);
            this.GroupBoxLoginUser.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.GroupBoxLoginUser.Font = new System.Drawing.Font("Segoe UI", 9F);
            this.GroupBoxLoginUser.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(125)))), ((int)(((byte)(137)))), ((int)(((byte)(149)))));
            this.GroupBoxLoginUser.Location = new System.Drawing.Point(3, 211);
            this.GroupBoxLoginUser.Name = "GroupBoxLoginUser";
            this.GroupBoxLoginUser.ShadowDecoration.Parent = this.GroupBoxLoginUser;
            this.GroupBoxLoginUser.Size = new System.Drawing.Size(394, 386);
            this.GroupBoxLoginUser.TabIndex = 0;
            this.GroupBoxLoginUser.Text = "Login";
            // 
            // tableLayoutPanel1
            // 
            this.tableLayoutPanel1.ColumnCount = 1;
            this.tableLayoutPanel1.ColumnStyles.Add(new System.Windows.Forms.ColumnStyle(System.Windows.Forms.SizeType.Percent, 20.75F));
            this.tableLayoutPanel1.Controls.Add(this.btnCreateAccount, 0, 1);
            this.tableLayoutPanel1.Controls.Add(this.panel2, 0, 0);
            this.tableLayoutPanel1.Dock = System.Windows.Forms.DockStyle.Bottom;
            this.tableLayoutPanel1.Location = new System.Drawing.Point(0, 40);
            this.tableLayoutPanel1.Name = "tableLayoutPanel1";
            this.tableLayoutPanel1.RowCount = 2;
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 83.23699F));
            this.tableLayoutPanel1.RowStyles.Add(new System.Windows.Forms.RowStyle(System.Windows.Forms.SizeType.Percent, 16.76301F));
            this.tableLayoutPanel1.Size = new System.Drawing.Size(394, 346);
            this.tableLayoutPanel1.TabIndex = 0;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Dock = System.Windows.Forms.DockStyle.Fill;
            this.btnCreateAccount.Location = new System.Drawing.Point(3, 290);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnCreateAccount.Size = new System.Drawing.Size(388, 53);
            this.btnCreateAccount.TabIndex = 0;
            this.btnCreateAccount.Values.Text = "Create New Account";
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // panel2
            // 
            this.panel2.Controls.Add(this.btnForgetPass);
            this.panel2.Controls.Add(this.btnLogin);
            this.panel2.Controls.Add(this.checkBoxShowPass);
            this.panel2.Controls.Add(this.lblPassword);
            this.panel2.Controls.Add(this.lblUserName);
            this.panel2.Controls.Add(this.txtLoginFormUserPassword);
            this.panel2.Controls.Add(this.txtLoginFormUserName);
            this.panel2.Location = new System.Drawing.Point(3, 3);
            this.panel2.Name = "panel2";
            this.panel2.Size = new System.Drawing.Size(388, 281);
            this.panel2.TabIndex = 1;
            // 
            // btnForgetPass
            // 
            this.btnForgetPass.Location = new System.Drawing.Point(233, 207);
            this.btnForgetPass.Name = "btnForgetPass";
            this.btnForgetPass.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnForgetPass.Size = new System.Drawing.Size(121, 42);
            this.btnForgetPass.StatePressed.Back.Color1 = System.Drawing.Color.Tomato;
            this.btnForgetPass.TabIndex = 4;
            this.btnForgetPass.Values.Text = "Forget Password";
            this.btnForgetPass.Click += new System.EventHandler(this.btnForgetPass_Click);
            // 
            // btnLogin
            // 
            this.btnLogin.Location = new System.Drawing.Point(35, 207);
            this.btnLogin.Name = "btnLogin";
            this.btnLogin.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Blue;
            this.btnLogin.Size = new System.Drawing.Size(162, 42);
            this.btnLogin.TabIndex = 3;
            this.btnLogin.Values.Text = "Login";
            this.btnLogin.Click += new System.EventHandler(this.btnLogin_Click);
            // 
            // checkBoxShowPass
            // 
            this.checkBoxShowPass.AutoSize = true;
            this.checkBoxShowPass.Depth = 0;
            this.checkBoxShowPass.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F);
            this.checkBoxShowPass.Location = new System.Drawing.Point(133, 135);
            this.checkBoxShowPass.Margin = new System.Windows.Forms.Padding(0);
            this.checkBoxShowPass.MouseLocation = new System.Drawing.Point(-1, -1);
            this.checkBoxShowPass.MouseState = MaterialSkin.MouseState.HOVER;
            this.checkBoxShowPass.Name = "checkBoxShowPass";
            this.checkBoxShowPass.Ripple = true;
            this.checkBoxShowPass.Size = new System.Drawing.Size(149, 37);
            this.checkBoxShowPass.TabIndex = 2;
            this.checkBoxShowPass.Text = "Show Password";
            this.checkBoxShowPass.UseVisualStyleBackColor = true;
            this.checkBoxShowPass.CheckedChanged += new System.EventHandler(this.checkBoxShowPass_CheckedChanged);
            // 
            // lblPassword
            // 
            this.lblPassword.AutoSize = true;
            this.lblPassword.Depth = 0;
            this.lblPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPassword.Location = new System.Drawing.Point(34, 105);
            this.lblPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPassword.Name = "lblPassword";
            this.lblPassword.Size = new System.Drawing.Size(71, 19);
            this.lblPassword.TabIndex = 1;
            this.lblPassword.Text = "Password";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Depth = 0;
            this.lblUserName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserName.Location = new System.Drawing.Point(31, 34);
            this.lblUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 19);
            this.lblUserName.TabIndex = 1;
            this.lblUserName.Text = "User Name";
            // 
            // txtLoginFormUserPassword
            // 
            this.txtLoginFormUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginFormUserPassword.DefaultText = "";
            this.txtLoginFormUserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginFormUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginFormUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginFormUserPassword.DisabledState.Parent = this.txtLoginFormUserPassword;
            this.txtLoginFormUserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginFormUserPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginFormUserPassword.FocusedState.Parent = this.txtLoginFormUserPassword;
            this.txtLoginFormUserPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginFormUserPassword.HoverState.Parent = this.txtLoginFormUserPassword;
            this.txtLoginFormUserPassword.Location = new System.Drawing.Point(134, 93);
            this.txtLoginFormUserPassword.Name = "txtLoginFormUserPassword";
            this.txtLoginFormUserPassword.PasswordChar = '\0';
            this.txtLoginFormUserPassword.PlaceholderText = "Enter User Password";
            this.txtLoginFormUserPassword.SelectedText = "";
            this.txtLoginFormUserPassword.ShadowDecoration.Parent = this.txtLoginFormUserPassword;
            this.txtLoginFormUserPassword.Size = new System.Drawing.Size(220, 40);
            this.txtLoginFormUserPassword.TabIndex = 0;
            this.txtLoginFormUserPassword.UseSystemPasswordChar = true;
            // 
            // txtLoginFormUserName
            // 
            this.txtLoginFormUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtLoginFormUserName.DefaultText = "";
            this.txtLoginFormUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtLoginFormUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtLoginFormUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginFormUserName.DisabledState.Parent = this.txtLoginFormUserName;
            this.txtLoginFormUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtLoginFormUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginFormUserName.FocusedState.Parent = this.txtLoginFormUserName;
            this.txtLoginFormUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtLoginFormUserName.HoverState.Parent = this.txtLoginFormUserName;
            this.txtLoginFormUserName.Location = new System.Drawing.Point(134, 22);
            this.txtLoginFormUserName.Name = "txtLoginFormUserName";
            this.txtLoginFormUserName.PasswordChar = '\0';
            this.txtLoginFormUserName.PlaceholderText = "Enter User Name";
            this.txtLoginFormUserName.SelectedText = "";
            this.txtLoginFormUserName.ShadowDecoration.Parent = this.txtLoginFormUserName;
            this.txtLoginFormUserName.Size = new System.Drawing.Size(220, 40);
            this.txtLoginFormUserName.TabIndex = 0;
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.pictureBox1);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 144);
            this.panel1.TabIndex = 1;
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::Bariwala.Properties.Resources.BariwalaLogo;
            this.pictureBox1.Location = new System.Drawing.Point(-94, -156);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(595, 408);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // errorProviderUserName
            // 
            this.errorProviderUserName.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderUserName.ContainerControl = this;
            // 
            // errorProviderUserPassword
            // 
            this.errorProviderUserPassword.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.errorProviderUserPassword.ContainerControl = this;
            // 
            // Form_Bariwala_Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.GroupBoxLoginUser);
            this.Font = new System.Drawing.Font("Segoe UI", 8.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "Form_Bariwala_Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bariwala-Login";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.Form_Bariwala_Login_FormClosed);
            this.GroupBoxLoginUser.ResumeLayout(false);
            this.tableLayoutPanel1.ResumeLayout(false);
            this.panel2.ResumeLayout(false);
            this.panel2.PerformLayout();
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserPassword)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private Guna.UI2.WinForms.Guna2GroupBox GroupBoxLoginUser;
        private System.Windows.Forms.TableLayoutPanel tableLayoutPanel1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateAccount;
        private System.Windows.Forms.Panel panel2;
        private MaterialSkin.Controls.MaterialLabel lblPassword;
        private MaterialSkin.Controls.MaterialLabel lblUserName;
        private Guna.UI2.WinForms.Guna2TextBox txtLoginFormUserPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtLoginFormUserName;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox pictureBox1;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnForgetPass;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnLogin;
        private System.Windows.Forms.ErrorProvider errorProviderUserName;
        private System.Windows.Forms.ErrorProvider errorProviderUserPassword;
        private MaterialSkin.Controls.MaterialCheckbox  checkBoxShowPass;
    }
}