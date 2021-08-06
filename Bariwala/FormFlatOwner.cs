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
    public partial class FormFlatOwner : MaterialForm
    {
        public FormFlatOwner()
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

        private void FormFlatOwner_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }
    }
}
