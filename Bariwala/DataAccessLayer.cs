using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using System.Data;

namespace Bariwala
{
    public class DataAccessLayer
    {
        private SqlConnection sqlCon;
        private SqlCommand sqlCom;
        private SqlDataAdapter sda;
        private DataSet ds;

        public SqlConnection Sqlcon
        {
            get { return sqlCon; }
            set { sqlCon = value; }
        }
        public SqlCommand Sqlcom
        {
            get { return sqlCom; }
            set { sqlCom = value; }
        }
        public SqlDataAdapter Sda
        {
            get { return sda; }
            set { sda = value; }
        }
        public DataSet Ds
        {
            get { return ds; }
            set { ds = value; }
        }
        public DataAccessLayer()
        {
            try
            {
                this.Sqlcon = new SqlConnection(@"Data Source = SAIYDUR; Initial Catalog = BariwalaLocalDB; User ID = sa; Password = 123; Connect Timeout = 30; Encrypt = False; TrustServerCertificate = False; ApplicationIntent = ReadWrite; MultiSubnetFailover = False");
                Sqlcon.Open();
            }
            catch(Exception exc)
            {
                Console.WriteLine(exc);
            }
        }
        private void QueryText(string query)
        {
            try
            {
                this.Sqlcom = new SqlCommand(query, this.Sqlcon);
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
        }

        public DataSet ExecuteQuery(string sql)
        {
            this.Ds = new DataSet();
            try
            {
                this.QueryText(sql);
                this.Sda = new SqlDataAdapter(this.Sqlcom);
                this.Sda.Fill(this.Ds);
                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            return Ds;
        }
        public int ExecuteUpdateQuery(string sql)
        {
            int u = 0;
            try
            {
                this.QueryText(sql);
                u = this.Sqlcom.ExecuteNonQuery();
                
            }
            catch (Exception exc)
            {
                Console.WriteLine(exc);
            }
            return u;
        }
    }
}
