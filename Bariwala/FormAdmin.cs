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

namespace Bariwala
{
    public partial class FormAdmin : MaterialForm
    {
        public FormAdmin()
        {
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

        private void FormAdmin_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
        private void btnAddUser_Click(object sender, EventArgs e)
        {
            dataGridViewAddUser.Rows.Add(txtUserName.Text.ToString());
            dataGridViewAddUser.CurrentCell = dataGridViewAddUser.Rows[dataGridViewAddUser.RowCount - 2].Cells[0];
        }

        private void TabControlAdmin_SelectedIndexChanged(object sender, EventArgs e)
        {
            if (TabControlAdmin.SelectedTab == TabControlAdmin.TabPages["tabPageLogout"])
            {
                this.Visible = false;
                Form_Bariwala_Login fbl = new Form_Bariwala_Login("Light");
                fbl.Visible = true;
            }
        }

        private void BtnLogout_Click(object sender, EventArgs e)
        {
            this.Visible = false;
            Form_Bariwala_Login fbl = new Form_Bariwala_Login("Light");
            fbl.Visible = true;
        }
    }
}
