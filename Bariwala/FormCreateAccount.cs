using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Text.RegularExpressions;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bariwala.BAL;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Bariwala
{
    public partial class FormCreateAccount : MaterialForm
    {
        private LogicLayer logicLayer;

        internal LogicLayer LogicLayer { get; set; }

        public FormCreateAccount()
        {
            //Connecting Data Base Indirectly
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
        #region Extra Methods
        private bool ValidatingAllTextBox()
        {
            bool status = true;
            if (string.IsNullOrEmpty(txtUserName.Text))
            {
                errorProviderUserName.SetError(txtUserName, "Text Box Cannot Empty");
                status = false;
            }
            else
            {
                errorProviderUserName.SetError(txtUserName, null);
            }
            if(string.IsNullOrEmpty(txtUserFullName.Text))
            {
                errorProviderFullName.SetError(txtUserFullName, "Text Box Cannot Empty");
                status = false;
            }
            else
            {
                errorProviderFullName.SetError(txtUserFullName, null);
            }
            if (string.IsNullOrEmpty(txtUserPhoneNumber.Text))
            {
                errorProviderPhoneNumber.SetError(txtUserPhoneNumber, "Text Box Cannot Empty");
                status = false;
            }
            else
            {
                int textLength = txtUserPhoneNumber.Text.Length;
                if (textLength == 11 || textLength == 13 || textLength == 14)
                {
                    errorProviderPhoneNumber.SetError(txtUserPhoneNumber, null);
                }
                else {
                    errorProviderPhoneNumber.SetError(txtUserPhoneNumber, "Invalid Phone Number");
                    status = false;
                }
            }
            if (string.IsNullOrEmpty(txtUserAddress.Text))
            {
                errorProviderAddress.SetError(txtUserAddress, "Text Box Cannot Empty");
                status = false;
            }
            else
            {
                errorProviderAddress.SetError(txtUserAddress, null);
            }
            if (string.IsNullOrEmpty(txtEmailAddress.Text))
            {
                errorProviderEmail.SetError(txtEmailAddress, "Text Box Cannot Empty");
                status = false;
            }
            else
            {
                errorProviderEmail.SetError(txtEmailAddress, null);
            }
            if (string.IsNullOrEmpty(txtUserPassword.Text))
            {
                errorProviderPassword.SetError(txtUserPassword, "Text Box Cannot Empty");
                status = false;
            }
            else
            {
                errorProviderPassword.SetError(txtUserPassword, null);
            }
            if (string.IsNullOrEmpty(txtUserPasswordConfirm.Text))
            {
                errorProviderConfirmPassword.SetError(txtUserPasswordConfirm, "Text Box Cannot Empty");
                status = false;
            }
            else
            {
                errorProviderConfirmPassword.SetError(txtUserPasswordConfirm, null);
            }
            if (string.IsNullOrEmpty(txtUserSecretCode.Text))
            {
                errorProviderSecretCode.SetError(txtUserSecretCode, "Text Box Cannot Empty");
                status = false;
            }
            else
            {
                errorProviderSecretCode.SetError(txtUserSecretCode, null);
            }
            if (CBUserType.SelectedItem==null)
            {
                errorProviderUserType.SetError(CBUserType, "Combo Box Cannot Empty");
                status = false;
            }
            else
            {
                errorProviderUserType.SetError(CBUserType, null);
            }
            if (txtUserPassword.Text != txtUserPasswordConfirm.Text)
            {
                errorProviderConfirmPasswordCheck.SetError(txtUserPasswordConfirm, "Not Match Check Check Again");
                status = false;
            }
            else
            {
                errorProviderConfirmPasswordCheck.SetError(txtUserPasswordConfirm, null);
            }
            return status;
        }
        private void ClearAllTextBox()
        {
            txtUserName.Text = "";
            txtUserFullName.Text = "";
            txtEmailAddress.Text = "";
            txtUserPassword.Text = "";
            txtUserPasswordConfirm.Text = "";
            txtUserPhoneNumber.Text = "";
            txtUserSecretCode.Text = "";
            txtUserAddress.Text = "";
            CBUserType.SelectedItem = null;
            DateTimePickerUserDOB.Text = null;
        }

        private bool isValidEmail()
        {
            string expression = @"\w+([-+.']\w+)*@\w+([-.]\w+)*\.\w+([-.]\w+)*";

            if (Regex.IsMatch(txtEmailAddress.Text, expression))
            {
               return true; 
            }
            return false;
        }
        #endregion

        //create account button
        private void BtnCreateAccount_Click(object sender, EventArgs e)
        {
            if (ValidatingAllTextBox())
            {
                var tempDOB = DateTimePickerUserDOB.Value.ToString("dd-MM-yyyy");

                int row =LogicLayer.AddUser(txtUserName.Text, txtUserFullName.Text, txtEmailAddress.Text,
                    txtUserPhoneNumber.Text, txtUserPassword.Text, CBUserType.Text, "no", tempDOB, txtUserSecretCode.Text,
                    txtUserAddress.Text);

                if (row == 0)
                {
                    MaterialMessageBox.Show("Signed Up Fail", "Error");
                }
                else { MaterialMessageBox.Show("Signed Up Successfully", "Success"); }
                ClearAllTextBox();
                this.Visible = false;
            }
        }

        //Form Close
        private void FormCreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }

        //Phone Number Text Box Accept + and Digit
        private void txtUserPhoneNumber_KeyPress(object sender, KeyPressEventArgs e)
        {
            if(!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '+') )
            {
                e.Handled = true;
            }
        }

        //Checking Email Address Valid Or Not
        private void txtEmailAddress_TextChanged(object sender, EventArgs e)
        {
            if (isValidEmail())
            {
                errorProviderEmail.SetError(txtEmailAddress, null);
            }
            else
            {
                if (txtEmailAddress.Text.Equals(""))
                {
                    errorProviderEmail.SetError(txtEmailAddress, "Text Box Cannot Be Empty");
                }
                else
                {
                    errorProviderEmail.SetError(txtEmailAddress, "Enter Valid Email");
                }
            }
        }
    }
}
