namespace Bariwala
{
    partial class FormCreateAccount
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
            this.CBUserType = new ComponentFactory.Krypton.Toolkit.KryptonComboBox();
            this.DateTimePickerUserDOB = new ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker();
            this.btnCreateAccount = new ComponentFactory.Krypton.Toolkit.KryptonButton();
            this.txtUserSecretCode = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserPasswordConfirm = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserPassword = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtEmailAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserAddress = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserPhoneNumber = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserFullName = new Guna.UI2.WinForms.Guna2TextBox();
            this.txtUserName = new Guna.UI2.WinForms.Guna2TextBox();
            this.lblUserSecretCode = new MaterialSkin.Controls.MaterialLabel();
            this.lblConfirmPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblUserPassword = new MaterialSkin.Controls.MaterialLabel();
            this.lblType = new MaterialSkin.Controls.MaterialLabel();
            this.lblDOB = new MaterialSkin.Controls.MaterialLabel();
            this.lblMailAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lblAddress = new MaterialSkin.Controls.MaterialLabel();
            this.lblPhoneNumber = new MaterialSkin.Controls.MaterialLabel();
            this.lblFullName = new MaterialSkin.Controls.MaterialLabel();
            this.lblUserName = new MaterialSkin.Controls.MaterialLabel();
            this.errorProviderUserName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderFullName = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPhoneNumber = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderAddress = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderEmail = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderUserType = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmPassword = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderSecretCode = new System.Windows.Forms.ErrorProvider(this.components);
            this.errorProviderConfirmPasswordCheck = new System.Windows.Forms.ErrorProvider(this.components);
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBUserType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFullName)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhoneNumber)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserType)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSecretCode)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPasswordCheck)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Controls.Add(this.CBUserType);
            this.panel1.Controls.Add(this.DateTimePickerUserDOB);
            this.panel1.Controls.Add(this.btnCreateAccount);
            this.panel1.Controls.Add(this.txtUserSecretCode);
            this.panel1.Controls.Add(this.txtUserPasswordConfirm);
            this.panel1.Controls.Add(this.txtUserPassword);
            this.panel1.Controls.Add(this.txtEmailAddress);
            this.panel1.Controls.Add(this.txtUserAddress);
            this.panel1.Controls.Add(this.txtUserPhoneNumber);
            this.panel1.Controls.Add(this.txtUserFullName);
            this.panel1.Controls.Add(this.txtUserName);
            this.panel1.Controls.Add(this.lblUserSecretCode);
            this.panel1.Controls.Add(this.lblConfirmPassword);
            this.panel1.Controls.Add(this.lblUserPassword);
            this.panel1.Controls.Add(this.lblType);
            this.panel1.Controls.Add(this.lblDOB);
            this.panel1.Controls.Add(this.lblMailAddress);
            this.panel1.Controls.Add(this.lblAddress);
            this.panel1.Controls.Add(this.lblPhoneNumber);
            this.panel1.Controls.Add(this.lblFullName);
            this.panel1.Controls.Add(this.lblUserName);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Fill;
            this.panel1.Location = new System.Drawing.Point(3, 64);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(394, 533);
            this.panel1.TabIndex = 0;
            // 
            // CBUserType
            // 
            this.CBUserType.AutoCompleteMode = System.Windows.Forms.AutoCompleteMode.Suggest;
            this.CBUserType.AutoCompleteSource = System.Windows.Forms.AutoCompleteSource.ListItems;
            this.CBUserType.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.CBUserType.DropDownWidth = 200;
            this.CBUserType.FormattingEnabled = true;
            this.CBUserType.Items.AddRange(new object[] {
            "Tenant",
            "Flat Owner"});
            this.CBUserType.Location = new System.Drawing.Point(157, 305);
            this.CBUserType.Name = "CBUserType";
            this.CBUserType.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.CBUserType.Size = new System.Drawing.Size(200, 21);
            this.CBUserType.TabIndex = 6;
            // 
            // DateTimePickerUserDOB
            // 
            this.DateTimePickerUserDOB.Location = new System.Drawing.Point(157, 261);
            this.DateTimePickerUserDOB.Name = "DateTimePickerUserDOB";
            this.DateTimePickerUserDOB.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.DateTimePickerUserDOB.ShowUpDown = true;
            this.DateTimePickerUserDOB.Size = new System.Drawing.Size(200, 21);
            this.DateTimePickerUserDOB.TabIndex = 5;
            // 
            // btnCreateAccount
            // 
            this.btnCreateAccount.Location = new System.Drawing.Point(155, 489);
            this.btnCreateAccount.Name = "btnCreateAccount";
            this.btnCreateAccount.PaletteMode = ComponentFactory.Krypton.Toolkit.PaletteMode.Office2010Silver;
            this.btnCreateAccount.Size = new System.Drawing.Size(90, 25);
            this.btnCreateAccount.TabIndex = 10;
            this.btnCreateAccount.Values.Text = "Sign Up";
            this.btnCreateAccount.Click += new System.EventHandler(this.btnCreateAccount_Click);
            // 
            // txtUserSecretCode
            // 
            this.txtUserSecretCode.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserSecretCode.DefaultText = "";
            this.txtUserSecretCode.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserSecretCode.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserSecretCode.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserSecretCode.DisabledState.Parent = this.txtUserSecretCode;
            this.txtUserSecretCode.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserSecretCode.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserSecretCode.FocusedState.Parent = this.txtUserSecretCode;
            this.txtUserSecretCode.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserSecretCode.HoverState.Parent = this.txtUserSecretCode;
            this.txtUserSecretCode.Location = new System.Drawing.Point(157, 436);
            this.txtUserSecretCode.Name = "txtUserSecretCode";
            this.txtUserSecretCode.PasswordChar = '\0';
            this.txtUserSecretCode.PlaceholderText = "For Reseting Password";
            this.txtUserSecretCode.SelectedText = "";
            this.txtUserSecretCode.ShadowDecoration.Parent = this.txtUserSecretCode;
            this.txtUserSecretCode.Size = new System.Drawing.Size(200, 36);
            this.txtUserSecretCode.TabIndex = 9;
            // 
            // txtUserPasswordConfirm
            // 
            this.txtUserPasswordConfirm.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPasswordConfirm.DefaultText = "";
            this.txtUserPasswordConfirm.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserPasswordConfirm.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserPasswordConfirm.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPasswordConfirm.DisabledState.Parent = this.txtUserPasswordConfirm;
            this.txtUserPasswordConfirm.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPasswordConfirm.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserPasswordConfirm.FocusedState.Parent = this.txtUserPasswordConfirm;
            this.txtUserPasswordConfirm.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserPasswordConfirm.HoverState.Parent = this.txtUserPasswordConfirm;
            this.txtUserPasswordConfirm.Location = new System.Drawing.Point(157, 390);
            this.txtUserPasswordConfirm.Name = "txtUserPasswordConfirm";
            this.txtUserPasswordConfirm.PasswordChar = '\0';
            this.txtUserPasswordConfirm.PlaceholderText = "Retype Password";
            this.txtUserPasswordConfirm.SelectedText = "";
            this.txtUserPasswordConfirm.ShadowDecoration.Parent = this.txtUserPasswordConfirm;
            this.txtUserPasswordConfirm.Size = new System.Drawing.Size(200, 36);
            this.txtUserPasswordConfirm.TabIndex = 8;
            // 
            // txtUserPassword
            // 
            this.txtUserPassword.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPassword.DefaultText = "";
            this.txtUserPassword.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserPassword.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserPassword.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPassword.DisabledState.Parent = this.txtUserPassword;
            this.txtUserPassword.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPassword.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserPassword.FocusedState.Parent = this.txtUserPassword;
            this.txtUserPassword.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserPassword.HoverState.Parent = this.txtUserPassword;
            this.txtUserPassword.Location = new System.Drawing.Point(157, 344);
            this.txtUserPassword.Name = "txtUserPassword";
            this.txtUserPassword.PasswordChar = '\0';
            this.txtUserPassword.PlaceholderText = "Enter Password";
            this.txtUserPassword.SelectedText = "";
            this.txtUserPassword.ShadowDecoration.Parent = this.txtUserPassword;
            this.txtUserPassword.Size = new System.Drawing.Size(200, 36);
            this.txtUserPassword.TabIndex = 7;
            // 
            // txtEmailAddress
            // 
            this.txtEmailAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtEmailAddress.DefaultText = "";
            this.txtEmailAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtEmailAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtEmailAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailAddress.DisabledState.Parent = this.txtEmailAddress;
            this.txtEmailAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtEmailAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailAddress.FocusedState.Parent = this.txtEmailAddress;
            this.txtEmailAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtEmailAddress.HoverState.Parent = this.txtEmailAddress;
            this.txtEmailAddress.Location = new System.Drawing.Point(157, 206);
            this.txtEmailAddress.Name = "txtEmailAddress";
            this.txtEmailAddress.PasswordChar = '\0';
            this.txtEmailAddress.PlaceholderText = "Enter Email Address";
            this.txtEmailAddress.SelectedText = "";
            this.txtEmailAddress.ShadowDecoration.Parent = this.txtEmailAddress;
            this.txtEmailAddress.Size = new System.Drawing.Size(200, 36);
            this.txtEmailAddress.TabIndex = 4;
            // 
            // txtUserAddress
            // 
            this.txtUserAddress.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserAddress.DefaultText = "";
            this.txtUserAddress.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserAddress.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserAddress.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserAddress.DisabledState.Parent = this.txtUserAddress;
            this.txtUserAddress.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserAddress.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserAddress.FocusedState.Parent = this.txtUserAddress;
            this.txtUserAddress.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserAddress.HoverState.Parent = this.txtUserAddress;
            this.txtUserAddress.Location = new System.Drawing.Point(157, 160);
            this.txtUserAddress.Name = "txtUserAddress";
            this.txtUserAddress.PasswordChar = '\0';
            this.txtUserAddress.PlaceholderText = "Enter Address";
            this.txtUserAddress.SelectedText = "";
            this.txtUserAddress.ShadowDecoration.Parent = this.txtUserAddress;
            this.txtUserAddress.Size = new System.Drawing.Size(200, 36);
            this.txtUserAddress.TabIndex = 3;
            // 
            // txtUserPhoneNumber
            // 
            this.txtUserPhoneNumber.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserPhoneNumber.DefaultText = "";
            this.txtUserPhoneNumber.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserPhoneNumber.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserPhoneNumber.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPhoneNumber.DisabledState.Parent = this.txtUserPhoneNumber;
            this.txtUserPhoneNumber.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserPhoneNumber.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserPhoneNumber.FocusedState.Parent = this.txtUserPhoneNumber;
            this.txtUserPhoneNumber.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserPhoneNumber.HoverState.Parent = this.txtUserPhoneNumber;
            this.txtUserPhoneNumber.Location = new System.Drawing.Point(157, 114);
            this.txtUserPhoneNumber.Name = "txtUserPhoneNumber";
            this.txtUserPhoneNumber.PasswordChar = '\0';
            this.txtUserPhoneNumber.PlaceholderText = "Enter Phone Number";
            this.txtUserPhoneNumber.SelectedText = "";
            this.txtUserPhoneNumber.ShadowDecoration.Parent = this.txtUserPhoneNumber;
            this.txtUserPhoneNumber.Size = new System.Drawing.Size(200, 36);
            this.txtUserPhoneNumber.TabIndex = 2;
            // 
            // txtUserFullName
            // 
            this.txtUserFullName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserFullName.DefaultText = "";
            this.txtUserFullName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserFullName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserFullName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserFullName.DisabledState.Parent = this.txtUserFullName;
            this.txtUserFullName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserFullName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserFullName.FocusedState.Parent = this.txtUserFullName;
            this.txtUserFullName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserFullName.HoverState.Parent = this.txtUserFullName;
            this.txtUserFullName.Location = new System.Drawing.Point(157, 68);
            this.txtUserFullName.Name = "txtUserFullName";
            this.txtUserFullName.PasswordChar = '\0';
            this.txtUserFullName.PlaceholderText = "Enter Full Name";
            this.txtUserFullName.SelectedText = "";
            this.txtUserFullName.ShadowDecoration.Parent = this.txtUserFullName;
            this.txtUserFullName.Size = new System.Drawing.Size(200, 36);
            this.txtUserFullName.TabIndex = 1;
            // 
            // txtUserName
            // 
            this.txtUserName.Cursor = System.Windows.Forms.Cursors.IBeam;
            this.txtUserName.DefaultText = "";
            this.txtUserName.DisabledState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(208)))), ((int)(((byte)(208)))), ((int)(((byte)(208)))));
            this.txtUserName.DisabledState.FillColor = System.Drawing.Color.FromArgb(((int)(((byte)(226)))), ((int)(((byte)(226)))), ((int)(((byte)(226)))));
            this.txtUserName.DisabledState.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.DisabledState.Parent = this.txtUserName;
            this.txtUserName.DisabledState.PlaceholderForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(138)))), ((int)(((byte)(138)))), ((int)(((byte)(138)))));
            this.txtUserName.FocusedState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.FocusedState.Parent = this.txtUserName;
            this.txtUserName.HoverState.BorderColor = System.Drawing.Color.FromArgb(((int)(((byte)(94)))), ((int)(((byte)(148)))), ((int)(((byte)(255)))));
            this.txtUserName.HoverState.Parent = this.txtUserName;
            this.txtUserName.Location = new System.Drawing.Point(157, 14);
            this.txtUserName.Name = "txtUserName";
            this.txtUserName.PasswordChar = '\0';
            this.txtUserName.PlaceholderText = "Enter User Name";
            this.txtUserName.SelectedText = "";
            this.txtUserName.ShadowDecoration.Parent = this.txtUserName;
            this.txtUserName.Size = new System.Drawing.Size(200, 36);
            this.txtUserName.TabIndex = 0;
            // 
            // lblUserSecretCode
            // 
            this.lblUserSecretCode.AutoSize = true;
            this.lblUserSecretCode.Depth = 0;
            this.lblUserSecretCode.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserSecretCode.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserSecretCode.Location = new System.Drawing.Point(37, 445);
            this.lblUserSecretCode.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserSecretCode.Name = "lblUserSecretCode";
            this.lblUserSecretCode.Size = new System.Drawing.Size(85, 19);
            this.lblUserSecretCode.TabIndex = 0;
            this.lblUserSecretCode.Text = "Secret Code";
            // 
            // lblConfirmPassword
            // 
            this.lblConfirmPassword.AutoSize = true;
            this.lblConfirmPassword.Depth = 0;
            this.lblConfirmPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblConfirmPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblConfirmPassword.Location = new System.Drawing.Point(47, 390);
            this.lblConfirmPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblConfirmPassword.Name = "lblConfirmPassword";
            this.lblConfirmPassword.Size = new System.Drawing.Size(139, 19);
            this.lblConfirmPassword.TabIndex = 0;
            this.lblConfirmPassword.Text = "Confirm\r\nPassword";
            // 
            // lblUserPassword
            // 
            this.lblUserPassword.AutoSize = true;
            this.lblUserPassword.Depth = 0;
            this.lblUserPassword.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserPassword.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserPassword.Location = new System.Drawing.Point(44, 353);
            this.lblUserPassword.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserPassword.Name = "lblUserPassword";
            this.lblUserPassword.Size = new System.Drawing.Size(71, 19);
            this.lblUserPassword.TabIndex = 0;
            this.lblUserPassword.Text = "Password";
            // 
            // lblType
            // 
            this.lblType.AutoSize = true;
            this.lblType.Depth = 0;
            this.lblType.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblType.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblType.Location = new System.Drawing.Point(44, 307);
            this.lblType.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblType.Name = "lblType";
            this.lblType.Size = new System.Drawing.Size(71, 19);
            this.lblType.TabIndex = 0;
            this.lblType.Text = "User Type";
            // 
            // lblDOB
            // 
            this.lblDOB.AutoSize = true;
            this.lblDOB.Depth = 0;
            this.lblDOB.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblDOB.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblDOB.Location = new System.Drawing.Point(44, 261);
            this.lblDOB.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblDOB.Name = "lblDOB";
            this.lblDOB.Size = new System.Drawing.Size(92, 19);
            this.lblDOB.TabIndex = 0;
            this.lblDOB.Text = "Date Of Birth";
            // 
            // lblMailAddress
            // 
            this.lblMailAddress.AutoSize = true;
            this.lblMailAddress.Depth = 0;
            this.lblMailAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblMailAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblMailAddress.Location = new System.Drawing.Point(44, 215);
            this.lblMailAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblMailAddress.Name = "lblMailAddress";
            this.lblMailAddress.Size = new System.Drawing.Size(41, 19);
            this.lblMailAddress.TabIndex = 0;
            this.lblMailAddress.Text = "Email";
            // 
            // lblAddress
            // 
            this.lblAddress.AutoSize = true;
            this.lblAddress.Depth = 0;
            this.lblAddress.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblAddress.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblAddress.Location = new System.Drawing.Point(44, 169);
            this.lblAddress.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblAddress.Name = "lblAddress";
            this.lblAddress.Size = new System.Drawing.Size(58, 19);
            this.lblAddress.TabIndex = 0;
            this.lblAddress.Text = "Address";
            // 
            // lblPhoneNumber
            // 
            this.lblPhoneNumber.AutoSize = true;
            this.lblPhoneNumber.Depth = 0;
            this.lblPhoneNumber.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblPhoneNumber.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblPhoneNumber.Location = new System.Drawing.Point(44, 123);
            this.lblPhoneNumber.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblPhoneNumber.Name = "lblPhoneNumber";
            this.lblPhoneNumber.Size = new System.Drawing.Size(106, 19);
            this.lblPhoneNumber.TabIndex = 0;
            this.lblPhoneNumber.Text = "Phone Number";
            // 
            // lblFullName
            // 
            this.lblFullName.AutoSize = true;
            this.lblFullName.Depth = 0;
            this.lblFullName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblFullName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblFullName.Location = new System.Drawing.Point(44, 77);
            this.lblFullName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblFullName.Name = "lblFullName";
            this.lblFullName.Size = new System.Drawing.Size(73, 19);
            this.lblFullName.TabIndex = 0;
            this.lblFullName.Text = "Full Name";
            // 
            // lblUserName
            // 
            this.lblUserName.AutoSize = true;
            this.lblUserName.Depth = 0;
            this.lblUserName.Font = new System.Drawing.Font("Roboto", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Pixel);
            this.lblUserName.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(222)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblUserName.Location = new System.Drawing.Point(44, 23);
            this.lblUserName.MouseState = MaterialSkin.MouseState.HOVER;
            this.lblUserName.Name = "lblUserName";
            this.lblUserName.Size = new System.Drawing.Size(78, 19);
            this.lblUserName.TabIndex = 0;
            this.lblUserName.Text = "User Name";
            // 
            // errorProviderUserName
            // 
            this.errorProviderUserName.ContainerControl = this;
            // 
            // errorProviderFullName
            // 
            this.errorProviderFullName.ContainerControl = this;
            // 
            // errorProviderPhoneNumber
            // 
            this.errorProviderPhoneNumber.ContainerControl = this;
            // 
            // errorProviderAddress
            // 
            this.errorProviderAddress.ContainerControl = this;
            // 
            // errorProviderEmail
            // 
            this.errorProviderEmail.ContainerControl = this;
            // 
            // errorProviderUserType
            // 
            this.errorProviderUserType.ContainerControl = this;
            // 
            // errorProviderPassword
            // 
            this.errorProviderPassword.ContainerControl = this;
            // 
            // errorProviderConfirmPassword
            // 
            this.errorProviderConfirmPassword.ContainerControl = this;
            // 
            // errorProviderSecretCode
            // 
            this.errorProviderSecretCode.ContainerControl = this;
            // 
            // errorProviderConfirmPasswordCheck
            // 
            this.errorProviderConfirmPasswordCheck.ContainerControl = this;
            // 
            // FormCreateAccount
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(400, 600);
            this.Controls.Add(this.panel1);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(400, 600);
            this.MinimumSize = new System.Drawing.Size(400, 600);
            this.Name = "FormCreateAccount";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Bariwala-CreateAccount";
            this.FormClosed += new System.Windows.Forms.FormClosedEventHandler(this.FormCreateAccount_FormClosed);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.CBUserType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderFullName)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPhoneNumber)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderAddress)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderEmail)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderUserType)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPassword)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderSecretCode)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.errorProviderConfirmPasswordCheck)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private Guna.UI2.WinForms.Guna2TextBox txtUserSecretCode;
        private Guna.UI2.WinForms.Guna2TextBox txtUserPasswordConfirm;
        private Guna.UI2.WinForms.Guna2TextBox txtUserPassword;
        private Guna.UI2.WinForms.Guna2TextBox txtEmailAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtUserAddress;
        private Guna.UI2.WinForms.Guna2TextBox txtUserPhoneNumber;
        private Guna.UI2.WinForms.Guna2TextBox txtUserFullName;
        private Guna.UI2.WinForms.Guna2TextBox txtUserName;
        private MaterialSkin.Controls.MaterialLabel lblUserSecretCode;
        private MaterialSkin.Controls.MaterialLabel lblConfirmPassword;
        private MaterialSkin.Controls.MaterialLabel lblUserPassword;
        private MaterialSkin.Controls.MaterialLabel lblType;
        private MaterialSkin.Controls.MaterialLabel lblDOB;
        private MaterialSkin.Controls.MaterialLabel lblMailAddress;
        private MaterialSkin.Controls.MaterialLabel lblAddress;
        private MaterialSkin.Controls.MaterialLabel lblPhoneNumber;
        private MaterialSkin.Controls.MaterialLabel lblFullName;
        private MaterialSkin.Controls.MaterialLabel lblUserName;
        private ComponentFactory.Krypton.Toolkit.KryptonButton btnCreateAccount;
        private ComponentFactory.Krypton.Toolkit.KryptonDateTimePicker DateTimePickerUserDOB;
        private ComponentFactory.Krypton.Toolkit.KryptonComboBox CBUserType;
        private System.Windows.Forms.ErrorProvider errorProviderUserName;
        private System.Windows.Forms.ErrorProvider errorProviderFullName;
        private System.Windows.Forms.ErrorProvider errorProviderPhoneNumber;
        private System.Windows.Forms.ErrorProvider errorProviderAddress;
        private System.Windows.Forms.ErrorProvider errorProviderEmail;
        private System.Windows.Forms.ErrorProvider errorProviderUserType;
        private System.Windows.Forms.ErrorProvider errorProviderPassword;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmPassword;
        private System.Windows.Forms.ErrorProvider errorProviderSecretCode;
        private System.Windows.Forms.ErrorProvider errorProviderConfirmPasswordCheck;
    }
}