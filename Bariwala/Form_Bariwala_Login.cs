using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bariwala.BAL;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Bariwala
{
    public partial class Form_Bariwala_Login : MaterialForm
    {
        private LogicLayer logicLayer;

        internal LogicLayer LogicLayer { get { return logicLayer; } set { logicLayer = value; } }
        public Form_Bariwala_Login()
        {
            LogicLayer = new LogicLayer();

            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.LightBlue400, Primary.LightBlue500,
            Primary.LightBlue500, Accent.LightGreen400,
            TextShade.WHITE
            );
        }

        private void Form_Bariwala_Login_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        #region custom methods
        private bool Validator()
        {
            bool status = false;
            if(this.txtLoginFormUserName.Text != "" && this.txtLoginFormUserPassword.Text !="")
            {
                this.errorProviderUserName.SetError(this.txtLoginFormUserName, null);
                this.errorProviderUserPassword.SetError(this.txtLoginFormUserPassword, null);
                status =true;
            }
            else
            {
                if(txtLoginFormUserName.Text == "" && this.txtLoginFormUserPassword.Text == "")
                {
                    this.errorProviderUserName.SetError(this.txtLoginFormUserName, "User Name Cannot Be Empty");
                    this.errorProviderUserPassword.SetError(this.txtLoginFormUserPassword, "Password Cannot Be Empty");
                    status = false;
                }
                else if(this.txtLoginFormUserName.Text == "")
                {
                    this.errorProviderUserName.SetError(this.txtLoginFormUserName, "User Name Cannot Be Empty");
                    this.errorProviderUserPassword.SetError(this.txtLoginFormUserPassword, null);
                    status = false;
                }
                else if(this.txtLoginFormUserPassword.Text == "")
                {
                    this.errorProviderUserName.SetError(this.txtLoginFormUserName, null);
                    errorProviderUserPassword.SetError(this.txtLoginFormUserPassword, "Password Cannot Be Empty");
                    status = false;
                }
            }
            return status;
        }
        #endregion

        #region Events

        //login button
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (Validator())
            {
                try
                {
                    string tempUserName = txtLoginFormUserName.Text;
                    string tempUserPass = txtLoginFormUserPassword.Text;

                    var dataSet = LogicLayer.GetLoginUser(tempUserName, tempUserPass);
                    if (dataSet.Tables[0].Rows[0]["userName"].ToString().Equals(tempUserName) && dataSet.Tables[0].Rows[0]["userPassword"].ToString().Equals(tempUserPass))
                    {
                        
                        var dataSetToTable = dataSet.Tables[0];
                        var userTypeString = dataSetToTable.Rows[0]["userType"].ToString().Trim().ToLower();
                        var userActiveStatus = dataSetToTable.Rows[0]["activeStatus"].ToString().Trim().ToLower();

                        //checking User Account Active Or Not
                        if (userActiveStatus.Equals("yes"))
                        {
                            MaterialMessageBox.Show("Login Successful", "Success");
                            if (userTypeString == "admin")
                            {
                                this.Hide();
                                FormAdmin formAdmin = new FormAdmin(dataSetToTable);
                                formAdmin.Visible = true;
                            }
                            if (userTypeString.Equals("flat owner"))
                            {
                                this.Visible = false;
                                FormFlatOwner formFlatOwner = new FormFlatOwner(dataSetToTable);
                                formFlatOwner.Visible = true;
                            }
                            if (userTypeString.Equals("tenant"))
                            {
                                this.Dispose();
                                FormTenant formTenant = new FormTenant(dataSetToTable);
                                formTenant.Visible = true;
                            }
                        }
                        else
                        {
                            MaterialMessageBox.Show("User Not Active", "Warning");
                        }

                    }
                    else
                    {
                        MaterialMessageBox.Show("Check user name/password", "Error");
                    }
                }
                catch(Exception exe)
                {
                    MessageBox.Show("Check user name/password", "Error");
                }
            }

        }

        //Hide/Show Pass Button
        private void checkBoxShowPass_CheckedChanged(object sender, EventArgs e)
        {
            if (checkBoxShowPass.Checked)
            {
                txtLoginFormUserPassword.UseSystemPasswordChar = false;
                checkBoxShowPass.Text = "Hide Password";
            }
            else
            {
                txtLoginFormUserPassword.UseSystemPasswordChar = true;
                checkBoxShowPass.Text = "Show Password";
            }
        }

        //Forget Pass Button
        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Take Rest And Try To Remeber Password :>");
        }

        //Create Account Button Take To FormCreateAccount
        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            FormCreateAccount formCreateAccount = new FormCreateAccount();
            formCreateAccount.Visible = true;
        }
    }
    #endregion
}
