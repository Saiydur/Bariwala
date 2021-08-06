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
    public partial class FormCreateAccount : MaterialForm
    {
        private DataAccessLayer dataAL;

        public DataAccessLayer DataAL
        {
            get { return dataAL; }
        }
        public FormCreateAccount()
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
                errorProviderPhoneNumber.SetError(txtUserPhoneNumber, null);
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
            DateTimePickerUserDOB.Text = "";
        }
        #endregion

        private void btnCreateAccount_Click(object sender, EventArgs e)
        {
            if (ValidatingAllTextBox())
            {
                var tempEmailAddress=txtEmailAddress.Text;
                var tempUserAddress = txtUserAddress.Text;
                var tempUserFullName = txtUserFullName.Text;
                var tempUserName = txtUserName.Text;
                var tempUserPassword = txtUserPassword.Text;
                var tempUserPhoneNumber = txtUserPhoneNumber.Text;
                var tempUserSecretCode = txtUserSecretCode.Text;
                var tempUserType = CBUserType.Text;
                var tempDOB = DateTimePickerUserDOB.Value.ToString("dd-MM-yyyy");

                var queryToInsert = $"insert into UserInformations " +
                    $"values('{tempUserName}','{tempUserFullName}','{tempEmailAddress}'," +
                    $"'{tempUserPhoneNumber}','{tempUserPassword}','{tempUserType}'," +
                    $"0,'{tempDOB}','{tempUserSecretCode}','{tempUserAddress}')";

                try
                {
                    var result = DataAL.ExecuteUpdateQuery(queryToInsert);
                    ClearAllTextBox();
                    MaterialMessageBox.Show(result.ToString()+" User Added");
                }
                catch (Exception exc)
                {
                    MaterialMessageBox.Show(exc.ToString());
                }
            }
        }

        private void FormCreateAccount_FormClosed(object sender, FormClosedEventArgs e)
        {
            this.Dispose();
        }
    }
}
