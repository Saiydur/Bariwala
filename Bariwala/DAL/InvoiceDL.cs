using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bariwala.DAL.Entities;

namespace Bariwala.DAL
{
    class InvoiceDL:DataAccessLayer
    {
        private int GetInvoiceId()
        {
            string sqlString = "select invoiceId from TransactionHistory order by invoiceId desc";
            var data = ExecuteQuery(sqlString);
            int invoiceId = 0;
            if (data.Tables[0].Rows.Count > 0)
            {
                invoiceId = Convert.ToInt32(data.Tables[0].Rows[0][0]);
                ++invoiceId;
            }
            else
            {
                ++invoiceId;
            }
            return invoiceId;
        }
        public int invIdGlobal;
        public int AddToTransactionHistoryDB(PrintingBill printingBill)
        {
            int invId =invIdGlobal= GetInvoiceId();
            string sqlString = $"insert into TransactionHistory(invoiceId,tenantName,tenantPhoneNumber," +
                $"flatNumber,flatLocation,flatMonthlyRent,flatGasCharge,flatWaterCharge,flatElectricCharge,flatUtilitiesCharge,flatOtherCharge,billingDate,flatTotalAmount) " +
                $"values('{invId}','{printingBill.TenantName}','{printingBill.TenantPhoneNumber}'," +
                $"'{printingBill.TenantFlatNumber}','{printingBill.TenantFlatLocation}','{printingBill.FlatMonthlyRent}'," +
                $"'{printingBill.FlatMonthlyGasCharge}','{printingBill.FlatMonthlyWaterCharge}','{printingBill.FlatMonthlyElectricCharge}'," +
                $"'{printingBill.FlatMonthlyUtilitiesCharge}','{printingBill.FlatMonthlyOtherCharge}','{printingBill.BillingDate}'," +
                $"'{printingBill.FlatMonthlyTotalBill}')";
            int row = ExecuteUpdateQuery(sqlString);
            if(row==1)
            {
                return invId;
            }
            else
            {
                return 0;
            }
        }
    }
}
