using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin;
using MaterialSkin.Controls;


namespace Bariwala
{
    public partial class Form_Bariwala_Login : MaterialForm
    {
        private DataAccessLayer dataAL;

        public DataAccessLayer DataAL
        {
            get { return dataAL; }
        }

        public Form_Bariwala_Login()
        {
            InitializeComponent();
            dataAL = new DataAccessLayer();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.LightBlue400, Primary.LightBlue500,
            Primary.LightBlue500, Accent.LightGreen400,
            TextShade.WHITE
            );
        }
        public Form_Bariwala_Login(string themeName)
        {
            InitializeComponent();
            dataAL = new DataAccessLayer();
            if (themeName.ToLower() == "light")
            {
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.LIGHT;
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.LightBlue400, Primary.LightBlue500,
                Primary.LightBlue500, Accent.LightGreen400,
                TextShade.WHITE
                );
            }
            if (themeName.ToLower() == "dark")
            {
                MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
                materialSkinManager.AddFormToManage(this);
                materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
                materialSkinManager.ColorScheme = new ColorScheme(
                Primary.LightBlue400, Primary.LightBlue500,
                Primary.LightBlue500, Accent.LightGreen400,
                TextShade.WHITE
                );
            }
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
        private void btnLogin_Click(object sender, EventArgs e)
        {

            if (Validator())
            {
                string username = txtLoginFormUserName.Text;
                var userPassword = txtLoginFormUserPassword.Text;
                var query = $"select * from UserInformations where " +
                    $"userName='{username}'and userPassword='{userPassword}'";
                try
                {
                    var result = DataAL.ExecuteQuery(query);
                    var multiRow = result.Tables[0].Rows;
                    if (multiRow.Count > 0)
                    {
                        int i = 0;
                        while (i < multiRow.Count)
                        {
                            if (multiRow[i]["userActiveStatus"].ToString() != "1")
                            {
                                MessageBox.Show("Account Is Not Active");
                            }
                            else
                            {
                                MessageBox.Show("Login Successful");
                                if (multiRow[i]["userType"].ToString().Trim().ToLower().Equals("admin"))
                                {
                                    this.Visible = false;
                                    FormAdmin formAdmin = new FormAdmin();
                                    formAdmin.Visible = true;
                                }
                                else
                                {
                                    MessageBox.Show(multiRow[i]["userType"].ToString());
                                }

                            }
                            i++;
                        }

                    }
                    else
                    {
                        MessageBox.Show("Check Username/Password");
                    }
                }
                catch (Exception exc)
                {
                    MessageBox.Show(exc.Message.ToString());
                }
            }

        }

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

        private void ToggleSwitchThemeMode_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void btnForgetPass_Click(object sender, EventArgs e)
        {
            MessageBox.Show("Take Rest And Try To Remeber Password :>");
        }

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            FormCreateAccount formCreateAccount = new FormCreateAccount();
            formCreateAccount.Visible = true;
        }
    }
    #endregion
}
