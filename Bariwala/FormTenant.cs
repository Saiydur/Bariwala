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
    public partial class FormTenant : MaterialForm
    {
        private DataTable dataTable;
        public DataTable DataTable { get; set; }

        private FlatsLayer flatsLayer;
        internal FlatsLayer FlatsLayer { get { return flatsLayer; } set { flatsLayer = value; } }

        public FormTenant()
        {
            flatsLayer = new FlatsLayer();
            InitializeComponent();
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.LightBlue400, Primary.LightBlue500,
            Primary.LightBlue500, Accent.LightGreen400,
            TextShade.WHITE
            );
            PopulateDgvToShowAllFlatPanel();
            PopulatViewForUserAssignFlatPanel();

        }

        public FormTenant(DataTable dataTable)
        {
            flatsLayer = new FlatsLayer();
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
            PopulateDgvToShowAllFlatPanel();
        }

        private void FormTenant_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (e.CloseReason == CloseReason.UserClosing)
            {
                var result = MaterialMessageBox.Show("Do You Want To Exit?", "Bariwala", MessageBoxButtons.YesNo);
                if (result == DialogResult.Yes)
                {
                    Application.Exit();
                }

                if (result == DialogResult.No)
                {
                    e.Cancel = true;
                }
            }
        }

        private void TabControlTenant_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlTenant.SelectedTab == TabControlTenant.TabPages["tabPageTenantShowAllFlat"])
            {
                PopulateDgvToShowAllFlatPanel();
            }
            if (TabControlTenant.SelectedTab == TabControlTenant.TabPages["tabPageTenantEnrollFlat"])
            {

                PopulatViewForUserAssignFlatPanel();
            }
        }

        private void PopulateDgvToShowAllFlatPanel()
        {
            var data = FlatsLayer.GetAllFlatDetailsForTenant();
            if (data != null)
            {
                dgvShowAllFlats.AutoGenerateColumns = false;
                dgvShowAllFlats.DataSource = data.Tables[0];
                dgvShowAllFlats.Refresh();
            }
            else
            {
                MessageBox.Show("No Data Found Maybe All Flats Are Already Enrolled","Error",MessageBoxButtons.OK,MessageBoxIcon.Warning);
            }
        }

        
        private void buttonEnrollToFlat_Click(object sender, EventArgs e)
        {
            int tempFlatId = Convert.ToInt32(dgvShowAllFlats.CurrentRow.Cells[0].Value);
            int tempTeantId = Convert.ToInt32(DataTable.Rows[0]["userID"].ToString());

            int row = FlatsLayer.SetAssigneFlats(tempTeantId, tempFlatId);
            if(row==1)
            {
                MessageBox.Show("Enroll Successed");
            }
        }

        private void btnSearch_Click(object sender, EventArgs e)
        {
            string typeName = cmbFilterType.Text;
            string keyWord = txtSearchKeyword.Text;

            var data=FlatsLayer.GetTeantFlatByType(typeName, keyWord);
            if (data != null)
            {
                dgvSearchFlatPanel.AutoGenerateColumns = false;
                dgvSearchFlatPanel.DataSource = data.Tables[0];
                dgvSearchFlatPanel.Refresh();
            }
            else
            {
                MessageBox.Show("No Flat Found", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void PopulatViewForUserAssignFlatPanel()
        {
            int tenantId = Convert.ToInt32(DataTable.Rows[0]["userID"].ToString());
            var data = FlatsLayer.GetParticularTenantFlats(tenantId);
            if (data != null)
            {
                dgvAssignedFlatPanel.AutoGenerateColumns = false;
                dgvAssignedFlatPanel.DataSource = data.Tables[0];
                dgvAssignedFlatPanel.Refresh();
            }
            else
            {
                MessageBox.Show("No Flat Found", "Fail", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
        }

        private void btnLeaveFlat_Click(object sender, EventArgs e)
        {
            int tempFlatId=Convert.ToInt32(dgvAssignedFlatPanel.CurrentRow.Cells[0].Value);
            int row =FlatsLayer.LeaveFlatUpdate(tempFlatId);
            if(row==1)
            {
                MessageBox.Show("Flat Leaved");
            }
            else
            {
                MessageBox.Show("Operation Fail");
            }
            PopulatViewForUserAssignFlatPanel();
        }
    }
}
