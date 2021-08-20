using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bariwala.BAL;
using MaterialSkin;
using MaterialSkin.Controls;

namespace Bariwala
{
    public partial class FormFlatOwner : MaterialForm
    {
        private DataTable dataTable;
        public DataTable DataTable { get; set; }

        private LogicLayer logicLayer;
        private FlatsLayer flatsLayer;
        private PrintingBillLogic printingBillLogic;

        internal LogicLayer LogicLayer { get { return logicLayer; } set { logicLayer = value; } }
        internal FlatsLayer FlatsLayer { get { return flatsLayer; } set { flatsLayer = value; } }
        internal PrintingBillLogic PrintingBillLogic { get { return printingBillLogic; } set { printingBillLogic = value; } }

        public FormFlatOwner()
        {
            LogicLayer = new LogicLayer();
            flatsLayer = new FlatsLayer();
            printingBillLogic = new PrintingBillLogic();

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

        public FormFlatOwner(DataTable dataTable)
        {
            
            LogicLayer = new LogicLayer();
            flatsLayer = new FlatsLayer();
            printingBillLogic = new PrintingBillLogic();

            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.LightBlue400, Primary.LightBlue500,
            Primary.LightBlue500, Accent.LightGreen400,
            TextShade.WHITE
            );

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

        private void TabControlFlatOwner_SelectedIndexChanged(object sender, EventArgs e)
        {
            //logout panel
            if (TabControlFlatOwner.SelectedTab == TabControlFlatOwner.TabPages["tabPageLogout"])
            {
                this.Visible = false;
                Form_Bariwala_Login fbl = new Form_Bariwala_Login();
                fbl.Visible = true;
            }

            //profile panel
            if (TabControlFlatOwner.SelectedTab == TabControlFlatOwner.TabPages["tabPageUserProfile"])
            {
                try
                {
                    SetTextToProfilePanel();
                    setPictureToProfile();
                }
                catch (Exception exe)
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
            //update Flat Panel
            if (TabControlFlatOwner.SelectedTab == TabControlFlatOwner.TabPages["tabPageUpdateFlat"])
            {
                LoadDataForUpadatePanel();
            }

            //delete Flat Panel
            if (TabControlFlatOwner.SelectedTab == TabControlFlatOwner.TabPages["tabPageDeleteFlat"])
            {
                LoadDataForDeletePanel();
            }

            //create bill Panel
            if(TabControlFlatOwner.SelectedTab==TabControlFlatOwner.TabPages["tabPageCreateBill"])
            {
                PopulateGridViewForCreateBill();
                lblTotalAmount.Visible = false;
            }
        }

        private void FormFlatOwner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

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

        #endregion

        #region Profile Panel
        //Is Text Box Valid Or Not
        private bool IsAllTextBoxValid()
        {
            bool flag = true;
            if (string.IsNullOrEmpty(txtProfileUserName.Text))
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
                MaterialMessageBox.Show("Text Boxes Cannot Be Empty", "Error");
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

        #region Add Flat Panel
        //Is Add Flat Panel All Text Box Valid Or Not

        private void btnAddFlat_Click(object sender, EventArgs e)
        {

            string flatNumber = txtFlatId.Text;
            string flatLocation = txtFlatLocation.Text;
            int flatSize = Convert.ToInt32(txtFlatSize.Text);
            int flatBedRoom = Convert.ToInt32(txtFlatBedRoom.Text);
            int flatDinningRoom = Convert.ToInt32(txtFlatDinningRoom.Text);
            int flatDrawingRoom = Convert.ToInt32(txtFlatDrawingRoom.Text);
            int flatWashRoom = Convert.ToInt32(txtFlatBath.Text);
            int flatKitchen = Convert.ToInt32(txtFlatKitchen.Text);
            int flatBalcony = Convert.ToInt32(txtFlatBalcony.Text);
            decimal flatMonthlyGasCharge = Convert.ToDecimal(txtFlatGasCharge.Text);
            decimal flatMonthlyWaterCharge = Convert.ToDecimal(txtFlatWaterCharge.Text);
            decimal flatMonthlyElectricCharge = Convert.ToDecimal(txtFlatElectrictCharge.Text);
            decimal flatMonthlyUtilities = Convert.ToDecimal(txtFlatUtilities.Text);
            decimal flatMonthlyRent = Convert.ToDecimal(txtFlatMonthlyBill.Text);
            int flatOwnerId = Convert.ToInt32(GetTextFormColumn("userID"));
            try
            {
                int row = FlatsLayer.AddFlat(flatNumber, flatLocation, flatSize, flatBedRoom, flatDinningRoom, flatDrawingRoom, flatWashRoom, flatKitchen, flatBalcony, flatMonthlyGasCharge, flatMonthlyGasCharge, flatMonthlyElectricCharge, flatMonthlyUtilities, flatMonthlyRent, flatOwnerId);
                if (row == 1)
                {
                    MessageBox.Show("Flat Added Successfully");
                }
                else
                {
                    MessageBox.Show("Flat Not Added");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message.ToString());
            }

        }
        #endregion

        #region Update Flat
        public void LoadDataForUpadatePanel()
        {
            int ownerId = Convert.ToInt32(GetTextFormColumn("userID"));
            var data=FlatsLayer.GetOwnerFlats(ownerId);
            if(data!=null)
            {
                dataGridViewFlatOwnerUpdateFlat.AutoGenerateColumns = false;
                dataGridViewFlatOwnerUpdateFlat.DataSource = data.Tables[0];
                dataGridViewFlatOwnerUpdateFlat.Refresh();
            }
            else
            {
                MessageBox.Show("No Data Found","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }
        private decimal ConvertStringToDecimal(string text)
        {
            return Convert.ToDecimal(text);
        }
        private int rowId;
        private void dataGridViewFlatOwnerUpdateFlat_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                txtMonthlyRent.Text = dataGridViewFlatOwnerUpdateFlat.CurrentRow.Cells["ColMonthlyRent"].Value.ToString();
                txtMonthlyElectricCharge.Text = dataGridViewFlatOwnerUpdateFlat.CurrentRow.Cells["ColFlatElectricCharge"].Value.ToString();
                txtMonthlyGasCharge.Text = dataGridViewFlatOwnerUpdateFlat.CurrentRow.Cells["ColFlatGasCharge"].Value.ToString();
                txtMonthlyWaterCharge.Text = dataGridViewFlatOwnerUpdateFlat.CurrentRow.Cells["ColFlatWaterCharge"].Value.ToString();
                txtUtilitiesCharge.Text = dataGridViewFlatOwnerUpdateFlat.CurrentRow.Cells["ColFlatUtilities"].Value.ToString();
                rowId = Convert.ToInt32(dataGridViewFlatOwnerUpdateFlat.CurrentRow.Cells["ColFlatId"].Value.ToString());
            }
            catch
            {
                MessageBox.Show("Please Select A Valid Row","Warning",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
            
        }

        private void btnUpdate_Click(object sender, EventArgs e)
        {
            decimal flatRent = ConvertStringToDecimal(txtMonthlyRent.Text);
            decimal flatElectricCharge = ConvertStringToDecimal(txtMonthlyElectricCharge.Text);
            decimal flatGasCharge = ConvertStringToDecimal(txtMonthlyGasCharge.Text);
            decimal flatWaterCharge = ConvertStringToDecimal(txtMonthlyWaterCharge.Text);
            decimal flatUtilitiesCharge = ConvertStringToDecimal(txtUtilitiesCharge.Text);
            try
            {
                int row = FlatsLayer.UpdateFlats(rowId, flatRent, flatGasCharge, flatElectricCharge, flatWaterCharge, flatUtilitiesCharge);
                if (row == 1)
                {
                    MaterialMessageBox.Show("Flat Updated", "Success");
                    LoadDataForUpadatePanel();
                }
                else
                {
                    MaterialMessageBox.Show("Flat Not Updated", "Failed");
                }
            }
            catch (Exception exe)
            {
                MessageBox.Show(exe.Message.ToString());
            }
        }
        #endregion

        #region Delete Flat
        private void LoadDataForDeletePanel()
        {
            int ownerId = Convert.ToInt32(GetTextFormColumn("userID"));

                var data = FlatsLayer.GetOwnerFlats(ownerId);
                if (data != null)
                {
                    dataGridViewFlatOwnerDeleteFlat.AutoGenerateColumns = false;
                    dataGridViewFlatOwnerDeleteFlat.DataSource = data.Tables[0];
                    dataGridViewFlatOwnerDeleteFlat.Refresh();
                }
                else
                {
                    MessageBox.Show("No Data Found", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
        }
        private void btnFlatOwnerDeleteFlat_Click(object sender, EventArgs e)
        {
            try
            {
                int flatId = Convert.ToInt32(dataGridViewFlatOwnerDeleteFlat.CurrentRow.Cells["ColFlatsId"].Value.ToString());
                try
                {
                    int row = FlatsLayer.DeleteFlats(flatId);
                    if (row == 1)
                    {
                        MaterialMessageBox.Show("Flat Deleted", "Success");
                        LoadDataForDeletePanel();
                    }
                    else
                    {
                        MaterialMessageBox.Show("Flat Not Deleted", "Failed");
                    }
                }
                catch (Exception exe)
                {
                    MessageBox.Show(exe.Message.ToString());
                }
            }
            catch
            {
                MessageBox.Show("Please Select A Valid Row", "Warning", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        #endregion

        #region Search Flat
        private void btnFlatOwnerSearchFlat_Click(object sender, EventArgs e)
        {
            string tempFlatNumber = txtFlatOwnerSearchFlat.Text;
            int tempOwnerId = Convert.ToInt32(GetTextFormColumn("userID"));

            var data = FlatsLayer.SearchFlats(tempFlatNumber, tempOwnerId);
            if(data!=null)
            {
                dataGridViewFlatOwnerFlatSearch.AutoGenerateColumns = true;
                dataGridViewFlatOwnerFlatSearch.DataSource = data.Tables[0];
                dataGridViewFlatOwnerFlatSearch.Refresh();
            }
            else
            {
                MessageBox.Show("No Data Found", "Failed");
            }
        }
        #endregion

        #region Flat Status
        private void btnShowEmptyFlat_Click(object sender, EventArgs e)
        {
            int tempOwnerId = Convert.ToInt32(GetTextFormColumn("userID"));

            var data = FlatsLayer.GetAllFlatsStatus(tempOwnerId, "empty");
            if (data != null)
            {
                dataGridViewFlatStatus.AutoGenerateColumns = false;
                dataGridViewFlatStatus.DataSource = data.Tables[0];
                dataGridViewFlatStatus.Refresh();
            }
            else
            {
                MessageBox.Show("No Data Found", "Failed");
            }
        }

        private void btnShowFullFlat_Click(object sender, EventArgs e)
        {
            int tempOwnerId = Convert.ToInt32(GetTextFormColumn("userID"));

            var data = FlatsLayer.GetAllFlatsStatus(tempOwnerId, "assign");
            if (data != null)
            {
                dataGridViewFlatStatus.AutoGenerateColumns = false;
                dataGridViewFlatStatus.DataSource = data.Tables[0];
                dataGridViewFlatStatus.Refresh();
            }
            else
            {
                MessageBox.Show("No Data Found", "Failed");
            }
        }
        #endregion

        #region CreateBill
        private void PopulateGridViewForCreateBill()
        {
            var data = FlatsLayer.GetAllFlatDetailsWithTeantInfo(Convert.ToInt32(GetTextFormColumn("userID")));
            if(data!=null)
            {
                dgvShowAllFlatForCreateBill.AutoGenerateColumns = false;
                dgvShowAllFlatForCreateBill.DataSource = data.Tables[0];
                dgvShowAllFlatForCreateBill.Refresh();
            }
            else
            {
                MessageBox.Show("No Data Found");
            }
        }

        #endregion
        
        private void dgvShowAllFlatForCreateBill_CellDoubleClick(object sender, DataGridViewCellEventArgs e)
        {
            lblTenantName.Text = dgvShowAllFlatForCreateBill.CurrentRow.Cells["TenantName"].Value.ToString();
            lblTenantPhnNo.Text = dgvShowAllFlatForCreateBill.CurrentRow.Cells["TenantPhoneNumber"].Value.ToString();
            lblTenantAllocatedFlat.Text =  dgvShowAllFlatForCreateBill.CurrentRow.Cells["FlatNumber"].Value.ToString();
            lblFlatLocation.Text =  dgvShowAllFlatForCreateBill.CurrentRow.Cells["FlatLocation"].Value.ToString();
            txtTenantFlatMonthlyRent.Text = dgvShowAllFlatForCreateBill.CurrentRow.Cells["MonthlyRent"].Value.ToString();
            txtTenantFlatMonthlyWaterCharge.Text = dgvShowAllFlatForCreateBill.CurrentRow.Cells["MonthlyWaterCharge"].Value.ToString();
            txtTenantFlatMonthlyGasCharge.Text = dgvShowAllFlatForCreateBill.CurrentRow.Cells["MonthlyGasCharge"].Value.ToString();
            txtTenantFlatElectricCharge.Text = dgvShowAllFlatForCreateBill.CurrentRow.Cells["MonthlyElectricCharge"].Value.ToString();
            txtTeantFlatUtilitiesCharge.Text = dgvShowAllFlatForCreateBill.CurrentRow.Cells["MonthlyUtilitiesCharge"].Value.ToString();
        }
        private int invId;
        private void btnCalculateAll_Click(object sender, EventArgs e)
        {
            decimal flatRent = ConvertStringToDecimal(txtTenantFlatMonthlyRent.Text.ToString());
            decimal flatWaterCharge = ConvertStringToDecimal(txtTenantFlatMonthlyWaterCharge.Text.ToString());
            decimal flatGasCharge = ConvertStringToDecimal(txtTenantFlatMonthlyGasCharge.Text.ToString());
            decimal flatElectricCharge = ConvertStringToDecimal(txtTenantFlatElectricCharge.Text.ToString());
            decimal flatUtilitiesCharge = ConvertStringToDecimal(txtTeantFlatUtilitiesCharge.Text.ToString());
            decimal flatOtherCharge = ConvertStringToDecimal(txtTenantOtherCharge.Text.ToString());
            string billingDate = dtpBillingDate.Value.ToString();
            
            decimal totalBill = flatRent + flatWaterCharge + flatGasCharge + flatElectricCharge + flatUtilitiesCharge + flatOtherCharge;

            lblTotalAmount.Text = "Total: "+totalBill.ToString(".00")+" BDT";
            lblTotalAmount.Visible = true;

            invId=PrintingBillLogic.AddToTransactionHistory(lblTenantName.Text, lblTenantPhnNo.Text, lblTenantAllocatedFlat.Text, lblFlatLocation.Text,
                billingDate, flatRent, flatWaterCharge, flatGasCharge, flatElectricCharge, flatUtilitiesCharge, flatOtherCharge, totalBill);
            
        }

        private void btnClaculateElectricBill_Click(object sender, EventArgs e)
        {
            decimal perUnitCost = ConvertStringToDecimal(txtElectricityPerUnitCost.Text.ToString());
            decimal fromUnit = ConvertStringToDecimal(txtElectricityUnitFrom.Text.ToString());
            decimal toUnit = ConvertStringToDecimal(txtElectricityUnitTo.Text.ToString());

            decimal totalUnit = toUnit - fromUnit;
            if(toUnit<0)
            {
                totalUnit = -(totalUnit);
            }
            decimal totalUnitCost = totalUnit * perUnitCost;
            txtTenantFlatElectricCharge.Text = totalUnitCost.ToString();
        }

        private void btnPrintBill_Click(object sender, EventArgs e)
        {

            this.Hide();
            FormPrintingBill formPrintingBill = new FormPrintingBill(invId);
            formPrintingBill.Show();
        }
    }
}
