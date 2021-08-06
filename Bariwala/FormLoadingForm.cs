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
    public partial class FormLoadingApp : MaterialForm
    {
        public FormLoadingApp()
        {
            InitializeComponent();
            this.btnToLoginForm.Visible = false;
            this.TimerForLoadingBar.Enabled = true;
            this.progressBarLoading.Minimum = 0;
            this.progressBarLoading.Maximum = 100;
            MaterialSkinManager materialSkinManager = MaterialSkinManager.Instance;
            materialSkinManager.AddFormToManage(this);
            materialSkinManager.Theme = MaterialSkinManager.Themes.DARK;
            materialSkinManager.ColorScheme = new ColorScheme(
            Primary.LightBlue400, Primary.LightBlue500,
            Primary.LightBlue500, Accent.LightGreen400,
            TextShade.WHITE
            );
        }

        private void FormLoadingApp_Load(object sender, EventArgs e)
        {
            
                
        }

        private void TimerForLoadingBar_Tick(object sender, EventArgs e)
        {
            progressBarLoading.Increment(5);
            lblLoadingBar.Visible = true;
            lblLoadingBar.Text = progressBarLoading.Value.ToString()+"%";
            if (progressBarLoading.Value == 100)
            {
                this.btnToLoginForm.Visible = true;
                TimerForLoadingBar.Enabled = false;
            }
        }

        private void btnToLoginForm_Click(object sender, EventArgs e)
        {
            this.Visible=false;
            Form_Bariwala_Login form_Bariwala_Login = new Form_Bariwala_Login
            {
                Visible = true
            };
        }
    }
}
