using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Bariwala.DAL;
using Bariwala.DAL.Entities;
using MaterialSkin;
using MaterialSkin.Controls;
using Microsoft.Reporting.WinForms;

namespace Bariwala
{
    public partial class FormPrintingBill : MaterialForm
    {
        private int Id { set; get; }
        public FormPrintingBill(int id)
        {
            Id = id;
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

        private void FormPrintingBill_FormClosed(object sender, FormClosedEventArgs e)
        {
            Application.Exit();
        }

        private void FormPrintingBill_Load(object sender, EventArgs e)
        {
            string sqlCon = @"Data Source=SAIYDUR;Initial Catalog=BariwalaLocalDB;Persist Security Info=True;User ID=sa;Password=123";
            SqlConnection con = new SqlConnection(sqlCon);
            SqlCommand cmd = new SqlCommand($"select * from TransactionHistory where invoiceId='{Id}'", con);
            SqlDataAdapter da = new SqlDataAdapter(cmd);
            DataSetForInvoice ds = new DataSetForInvoice();
            da.Fill(ds, "TransactionHistory");
            ReportDataSource dataSource = new ReportDataSource("DataSet", ds.Tables[0]);
            this.reportViewer1.LocalReport.DataSources.Clear();
            this.reportViewer1.LocalReport.DataSources.Add(dataSource);
            this.reportViewer1.RefreshReport();
        }
    }
}
