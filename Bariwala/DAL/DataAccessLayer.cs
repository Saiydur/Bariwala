using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bariwala.DAL
{
    class DataAccessLayer
    {
        private SqlConnection sqlcon;
        public SqlConnection Sqlcon
        {
            get { return sqlcon; }
            set { sqlcon = value; }
        }

        private SqlCommand sqlcom;
        public SqlCommand Sqlcom
        {
            get { return sqlcom; }
            set { sqlcom = value; }
        }

        private SqlDataAdapter sda;
        public SqlDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }

        private DataSet ds;
        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }

        public DataAccessLayer()
        {
            this.Sqlcon = new SqlConnection(@"Data Source=SAIYDUR;Initial Catalog=BariwalaLocalDB;Persist Security Info=True;User ID=sa;Password=123");
            Sqlcon.Open();
        }

        private void QueryText(string query)
        {
            this.Sqlcom = new SqlCommand(query, this.Sqlcon);
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.QueryText(sql);
            this.Sda = new SqlDataAdapter(this.Sqlcom);
            this.Ds = new DataSet();
            this.Sda.Fill(this.Ds);
            return Ds;
        }

        public int ExecuteUpdateQuery(string sql)
        {
            this.QueryText(sql);
            int u = this.Sqlcom.ExecuteNonQuery();
            return u;
        }
        public int ImageAdditionQueryExecution(string sql, byte[] images)
        {
            this.Sqlcom = new SqlCommand();
            this.Sqlcom.Connection = Sqlcon;
            this.Sqlcom.Parameters.Clear();
            this.Sqlcom.Parameters.AddWithValue("@pictures", images);
            this.Sqlcom.CommandText = sql;
            return this.Sqlcom.ExecuteNonQuery();
        }
    }
}
