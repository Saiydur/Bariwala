using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using MaterialSkin.Controls;
using MaterialSkin;
using Bariwala.BAL;
using System.IO;
using System.Globalization;

namespace Bariwala
{
    public partial class FormAdmin : MaterialForm
    {
        private DataTable dataTable;

        public DataTable DataTable { get; set; }

        private LogicLayer logicLayer;

        internal LogicLayer LogicLayer { get { return logicLayer; } set { logicLayer = value; } }

        public FormAdmin()
        {
            LogicLayer = new LogicLayer();

            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.LightBlue400, Primary.LightBlue500,
            Primary.LightBlue500, Accent.LightGreen400,
            TextShade.WHITE
            );
        }


        public FormAdmin(DataTable dataTable)
        {
            //Initialize Logic Layer By Property
            LogicLayer = new LogicLayer();

            //Auto Generated
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.LightBlue400, Primary.LightBlue500,
            Primary.LightBlue500, Accent.LightGreen400,
            TextShade.WHITE
            );

            //setting table to Data Table
            DataTable = dataTable;

            //on load methods
            try
            {
                SetTextToProfilePanel();
                setPictureToProfile();
            }
            catch
            {
                SetTextToProfilePanel();
            }
        }

        #region Auto Generated Events
        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void TabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            //logout panel
            if (TabControlAdmin.SelectedTab == TabControlAdmin.TabPages["tabPageLogout"])
            {
                this.Visible = false;
                Form_Bariwala_Login fbl = new Form_Bariwala_Login();
                fbl.Visible = true;
            }

            //profile panel
            if (TabControlAdmin.SelectedTab == TabControlAdmin.TabPages["tabPageUserProfile"])
            {
                try
                {
                    SetTextToProfilePanel();
                    setPictureToProfile();
                }
                catch(Exception exe)
                {
                    MessageBox.Show(exe.Message.ToString());
                    txtProfileUserAddress.Text = "";
                    txtProfileUserEmail.Text = "";
                    txtProfileUserFullName.Text = "";
                    txtProfileUserName.Text = "";
                    txtProfileUserPhoneNo.Text = "";
                    txtProfileUserSecretCode.Text = "";
                    dtpProfileUserDOB.Text = "";
                }
            }

            //Add User Panel
            if (TabControlAdmin.SelectedTab == TabControlAdmin.TabPages["tabPageAddUser"])
            {
                showDataAtAddUserPanel();
            }

            if (TabControlAdmin.SelectedTab == TabControlAdmin.TabPages["tabPageDeleteUser"])
            {
                ShowAllDataToDeleteUserPanel();
            }

            if(TabControlAdmin.SelectedTab == TabControlAdmin.TabPages["tabPageUserActiveStatus"])
            {
                ShowDataToActiveStatPanel();
            }
        }
        #endregion

        #region Custom Methods
        //Getting Text From Data Table
        private string GetTextFormColumn(string columnName)
        {
            return DataTable.Rows[0][$"{columnName}"].ToString();
        }
        //New Password Validation For Profile Panel
        private bool NewPassIsValid()
        {

            if (txtProfileUserOldPassword.Text.Equals(GetTextFormColumn("userPassword"))
                && txtProfileUserNewPassword.Text.Equals(txtProfileUserConfirmNewPassword.Text))
            {
                return true;
            }
            else
                return false;
        }
        //New Setting For Profile Panel
        private void SetTextToProfilePanel()
        {
            txtProfileUserAddress.Text = GetTextFormColumn("userAddress");
            txtProfileUserEmail.Text = GetTextFormColumn("userMailAddress");
            txtProfileUserFullName.Text = GetTextFormColumn("userFullName");
            txtProfileUserName.Text = GetTextFormColumn("userName");
            txtProfileUserPhoneNo.Text = GetTextFormColumn("userPhoneNumber");
            txtProfileUserSecretCode.Text = GetTextFormColumn("userSecretCode");
        }
        //Setting Profile Picture To Profile Panel
        public void setPictureToProfile()
        {
            try
            {
                Image image = ConvertBytesToImage((byte[])(DataTable.Rows[0]["userPic"]));
                pictureBoxProfile.Image = image;
            }
            catch { }
        }
        //Image Conversion Start
        public byte[] ConvertImageToBytes(Image receive)
        {
            MemoryStream memoryStream = new MemoryStream();
            receive.Save(memoryStream, receive.RawFormat);
            byte[] image = memoryStream.GetBuffer();
            memoryStream.Close();
            return image;
        }
        public Image ConvertBytesToImage(byte[] image)
        {
            MemoryStream memoryStream = new MemoryStream(image);
            return Image.FromStream(memoryStream);
        }
        //Image Conversion Stop
        //text box clearing
        
        #endregion

        #region Profile Panel
        private bool IsAllTextBoxValid()
        {
            bool flag = true;
            if(string.IsNullOrEmpty(txtProfileUserName.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtProfileUserFullName.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtProfileUserEmail.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtProfileUserPhoneNo.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtProfileUserConfirmNewPassword.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtProfileUserNewPassword.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtProfileUserSecretCode.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtProfileUserAddress.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtProfileUserOldPassword.Text))
            {
                flag = false;
            }
            return flag;
        }
        //Logout Button
        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_Bariwala_Login fbl = new Form_Bariwala_Login();
            fbl.Visible = true;
        }

        //Update Profile Details Button
        private void btnUpdateProfileDetails_Click(object sender, EventArgs e)
        {

            if (NewPassIsValid()&& IsAllTextBoxValid())
            {
                try
                {
                    int userId = Convert.ToInt32(GetTextFormColumn("userID"));
                    string userActiveStatus = GetTextFormColumn("activeStatus");
                    string userType = GetTextFormColumn("userType");
                    int row = LogicLayer.UpdateUser(userId, txtProfileUserName.Text, txtProfileUserFullName.Text,
                        txtProfileUserEmail.Text, txtProfileUserPhoneNo.Text, txtProfileUserConfirmNewPassword.Text,
                        userType, userActiveStatus, dtpProfileUserDOB.Value.ToString("dd-MM-yyyy"),
                        txtProfileUserSecretCode.Text, txtProfileUserAddress.Text);
                    if (row == 0)
                    {
                        MaterialMessageBox.Show("Can't Update", "Error");
                    }
                    else { MaterialMessageBox.Show("Updated Successfully", "Success"); }
                    SetTextToProfilePanel();
                }
                catch (Exception exc)
                {
                    MaterialMessageBox.Show(exc.Message.ToString() + " Occured\n Try Again", "Error");
                }
                
            }
            else
            {
                MaterialMessageBox.Show("Text Box Cannot Empty", "Error");
            }

        }

        //Update Profile Picture Button
        private void btnUpdateProfilePic_Click(object sender, EventArgs e)
        {
            int userId = Convert.ToInt32(GetTextFormColumn("userID"));
            OpenFileDialog openFileDialog = new OpenFileDialog();
            openFileDialog.Filter = "Image Files (*.jpeg;*.jpg;*.png;*bmp;)|*.jpeg;*.jpg;*.png;*.bmp;";
            try
            {
                if (openFileDialog.ShowDialog() == DialogResult.OK)
                {
                    int row = LogicLayer.UpdateProfilePicture(userId, ConvertImageToBytes(Image.FromFile(openFileDialog.FileName)));

                    if (row == 1)
                    {
                        MessageBox.Show("Update Successfully");
                        pictureBoxProfile.ImageLocation = openFileDialog.FileName;
                    }
                    else
                    {
                        MessageBox.Show("Error");
                    }

                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message.ToString());
                MaterialMessageBox.Show("An Error To Upload Picture", "Error");
            }

        }

        #endregion

        #region Add User Panel
        //Refresh Text Boxes
        private void clearTextUserAddPanel()
        {
            txtUserName.Clear();
            txtUserFullName.Clear();
            txtUserEmailAddress.Clear();
            txtUserAddress.Clear();
            txtUserPassword.Clear();
            txtUserSecretCode.Clear();
            txtUserPhoneNumber.Clear();
            DateTimePickerUserDOB = null;
            cmbUserActiveStatus.SelectedIndex = -1;
            cmbUserType.SelectedIndex = -1;
        }
        //Checking Text Valid Or Not
        private bool IsAllUserPanelTextBoxValid()
        {
            bool flag = true;
            if(string.IsNullOrEmpty(txtUserName.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUserFullName.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUserEmailAddress.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUserAddress.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUserPassword.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUserSecretCode.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUserPhoneNumber.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(cmbUserActiveStatus.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(cmbUserType.Text))
            {
                flag = false;
            }
            return flag;
        }
        //showing all data at data grid view
        private void showDataAtAddUserPanel()
        {
            try
            {
                dataGridViewAddUser.AutoGenerateColumns = false;
                var users = LogicLayer.GetAllUser();
                if (users != null)
                {
                    dataGridViewAddUser.DataSource = users.Tables[0];
                    dataGridViewAddUser.Refresh();
                }
                else
                {
                    MaterialMessageBox.Show("NO Data Found", "Error");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message.ToString() + " Occured\n Try Again");
            }
        }
        //button add user
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            if (IsAllUserPanelTextBoxValid())
            {
                string tempUserName = txtUserName.Text;
                string tempUserFullName = txtUserFullName.Text;
                string tempUserEmail = txtUserEmailAddress.Text;
                string tempUserAddress = txtUserAddress.Text;
                string tempUserPassword = txtUserPassword.Text;
                string tempUserSecretCode = txtUserSecretCode.Text;
                string tempUserPhoneNumber = txtUserPhoneNumber.Text;
                string tempUserDOB = DateTimePickerUserDOB.Value.ToString("dd-MM-yyyy");
                string tempUserActiveStatus = cmbUserActiveStatus.Text;
                string tempUserType = cmbUserType.Text;
                int row = LogicLayer.AddUser(tempUserName, tempUserFullName, tempUserEmail, tempUserPhoneNumber, tempUserPassword,
                    tempUserType, tempUserActiveStatus, tempUserDOB, tempUserSecretCode, tempUserAddress);
                if (row == 1)
                {

                    MaterialMessageBox.Show("User Inserted Successfully", "Success");
                    showDataAtAddUserPanel();
                    clearTextUserAddPanel();
                    dataGridViewAddUser.CurrentCell = dataGridViewAddUser.Rows[dataGridViewAddUser.RowCount - 2].Cells[0];
                }
            }
            else
            {
                MessageBox.Show("Text Boxes Cannot Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        #endregion

        #region Update User Panel
        //temp varibale
        private string setPass = "";
        private string secretCode = "";
        private string setDOB = "";
        //Checking All Text Boxes Valid Or Not
        private bool IsUpdateUserPanelTextBoxValid()
        {
            bool flag = true;
            if(string.IsNullOrEmpty(txtUpdateUserInput.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(cmbUpdateUserUserActiveStatus.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(cmbUpdateUserUserType.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUpdateUserUserPhoneNumber.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUpdateUserUserName.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUpdateUserUserId.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUpdateUserUserFullName.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUpdateUserUserEmail.Text))
            {
                flag = false;
            }
            if (string.IsNullOrEmpty(txtUpdateUserUserAddress.Text))
            {
                flag = false;
            }
            return flag;
        }
        //Clear Text Boxs
        private void ClearAllTxtBoxUpdateUserPanel()
        {
            txtUpdateUserUserAddress.Clear();
            txtUpdateUserUserEmail.Clear();
            txtUpdateUserUserFullName.Clear();
            txtUpdateUserUserId.Clear();
            txtUpdateUserUserName.Clear();
            txtUpdateUserUserPhoneNumber.Clear();
            cmbUpdateUserUserType.SelectedIndex=-1;
            cmbUpdateUserUserActiveStatus.SelectedIndex=-1;
            txtUpdateUserInput.Clear();
        }
        //Button Search User
        private void btnSearch_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(cmbUpdateUserSearchBy.Text))
            {
                string type = cmbUpdateUserSearchBy.Text;
                string searchKeyword = txtUpdateUserInput.Text;
                string userType = "";
                if (type == "User Id") { userType = "userID"; }
                if (type == "User Name") { userType = "userName"; }
                if (type == "User Full Name") { userType = "userFullName"; }
                if (type == "User Phone Number") { userType = "userPhoneNumber"; }
                try
                {
                    var user = LogicLayer.GetUserByType(userType, searchKeyword);
                    if (user.Tables[0].Rows.Count > 0)
                    {
                        var dataSetToRow = user.Tables[0].Rows[0];
                        txtUpdateUserUserAddress.Text = dataSetToRow["userAddress"].ToString();
                        txtUpdateUserUserEmail.Text = dataSetToRow["userMailAddress"].ToString();
                        txtUpdateUserUserFullName.Text = dataSetToRow["userFullName"].ToString();
                        txtUpdateUserUserId.Text = dataSetToRow["userID"].ToString();
                        txtUpdateUserUserName.Text = dataSetToRow["userName"].ToString();
                        txtUpdateUserUserPhoneNumber.Text = dataSetToRow["userPhoneNumber"].ToString();
                        cmbUpdateUserUserType.Text = dataSetToRow["userType"].ToString();
                        cmbUpdateUserUserActiveStatus.Text = dataSetToRow["activeStatus"].ToString();
                        setPass = dataSetToRow["userPassword"].ToString();
                        secretCode = dataSetToRow["userSecretCode"].ToString();
                        setDOB = dataSetToRow["userDOB"].ToString();

                    }
                    else { MaterialMessageBox.Show("User Not Found"); }
                }
                catch (Exception exe)
                {
                    MaterialMessageBox.Show(exe.Message.ToString() + " Occured\n Try Again", "Error");
                }
            }
            else
            {
                MessageBox.Show("Search Box Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }
        //button Update User
        private void btnUpdateUser_Click(object sender, EventArgs e)
        {
            if (IsUpdateUserPanelTextBoxValid())
            {
                var tempAddress = txtUpdateUserUserAddress.Text;
                var tempEmail = txtUpdateUserUserEmail.Text;
                var tempFullName = txtUpdateUserUserFullName.Text;
                var tempUserId = txtUpdateUserUserId.Text;
                var tempUserName = txtUpdateUserUserName.Text;
                var tempPhone = txtUpdateUserUserPhoneNumber.Text;
                var tempType = cmbUpdateUserUserType.Text;
                var tempActvStat = cmbUpdateUserUserActiveStatus.Text;
                var tempDOB = setDOB;
                var tempPass = setPass;
                var tempSecretCode = secretCode;

                try
                {
                    int row = LogicLayer.UpdateUser(Convert.ToInt32(tempUserId), tempUserName, tempFullName,
                        tempEmail, tempPhone, tempPass, tempType, tempActvStat, tempDOB, tempSecretCode, tempAddress);
                    if (row == 1)
                    {
                        MaterialMessageBox.Show("Updated Successfully", "Success");
                    }
                    else
                    {
                        MaterialMessageBox.Show("Update Fail", "Error");
                    }

                }
                catch (Exception exe)
                {
                    MaterialMessageBox.Show(exe.Message.ToString() + " Occured\n Try Again", "Error");
                }
                IsUpdateUserPanelTextBoxValid();
            }
            else
            {
                MessageBox.Show("Text Boxes Cannot Be Empty", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }


        }
        //button Clear Text Field
        private void btnClearTextFieldUpdateUser_Click(object sender, EventArgs e)
        {
            ClearAllTxtBoxUpdateUserPanel();
        }
        #endregion

        #region Delete User Panel
        //show all Data 
        public void ShowAllDataToDeleteUserPanel()
        {
            try
            {
                dataGridViewDeleteUser.AutoGenerateColumns = false;
                var users = LogicLayer.GetAllUser();
                if (users != null)
                {
                    dataGridViewDeleteUser.DataSource = users.Tables[0];
                    dataGridViewDeleteUser.Refresh();
                }
                else
                {
                    MaterialMessageBox.Show("NO Data Found", "Error");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message.ToString() + " Occured\n Try Again");
            }
        }
        //Button Delete User
        private void btnDeleteUser_Click(object sender, EventArgs e)
        {
            try
            {
                foreach (DataGridViewRow item in this.dataGridViewDeleteUser.SelectedRows)
                {
                    if (dataGridViewDeleteUser.Rows.Count > 1 && dataGridViewDeleteUser.SelectedCells[0].RowIndex != dataGridViewDeleteUser.Rows.Count - 1)
                    {
                        int takeUserIdFromDataGridView = Convert.ToInt32(dataGridViewDeleteUser.SelectedRows[0].Cells[0].Value);
                        int row = LogicLayer.DeleteUser(takeUserIdFromDataGridView);
                        if (row > 0)
                        {
                            MessageBox.Show("Deleted Successfully");
                            dataGridViewDeleteUser.Rows.RemoveAt(this.dataGridViewDeleteUser.SelectedRows[0].Index);
                        }
                        else
                        {
                            MessageBox.Show("Operation Fail");
                        }
                    }
                    else
                    {
                        MessageBox.Show("Select A Valid Row");
                    }
                }
            }
            catch(Exception exe)
            {
                MessageBox.Show(exe.Message.ToString());
            }
            
        }
        #endregion

        #region UserActive Status
        //show username and user activestatus
        public void ShowDataToActiveStatPanel()
        {
            try
            {
                dataGridViewActiveStatus.AutoGenerateColumns = false;
                var users = LogicLayer.GetAllUser();
                if (users != null)
                {
                    dataGridViewActiveStatus.DataSource = users.Tables[0];
                    dataGridViewActiveStatus.Refresh();
                }
                else
                {
                    MaterialMessageBox.Show("NO Data Found", "Error");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message.ToString() + " Occured\n Try Again");
            }
        }

        private void btnActiveStatusUpdate_Click(object sender, EventArgs e)
        {
            string tempUserType = cmbActiveStatusUserType.Text;
            int tempUserId = 0;
            try
            {
                foreach (DataGridViewRow item in this.dataGridViewActiveStatus.SelectedRows)
                {
                    if (dataGridViewActiveStatus.Rows.Count > 1 && dataGridViewActiveStatus.SelectedCells[0].RowIndex != dataGridViewActiveStatus.Rows.Count - 1)
                    {
                        tempUserId = Convert.ToInt32(dataGridViewActiveStatus.SelectedRows[0].Cells[0].Value);
                        int row = LogicLayer.UpdateUserActiveStatus(tempUserType, tempUserId);
                        if (row > 0)
                        {
                            MessageBox.Show("Updated Successfully");

                        }
                        else
                        {
                            MessageBox.Show("Operation Fail");
                        }
                        ShowDataToActiveStatPanel();
                    }
                    else
                    {
                        MessageBox.Show("Select A Valid Row");
                    }
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message.ToString());
            }
        }
        #endregion
    }
}
