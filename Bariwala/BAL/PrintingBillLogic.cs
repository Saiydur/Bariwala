using Bariwala.DAL.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Bariwala.DAL;
using System.Data;

namespace Bariwala.BAL
{
    class PrintingBillLogic
    {
        private InvoiceDL invoiceDL;
        public InvoiceDL InvoiceDL { set { this.invoiceDL = value; } get { return invoiceDL; } }

        public PrintingBillLogic()
        {
            InvoiceDL = new InvoiceDL();
        }
        public int AddToTransactionHistory(string tenantName, string tenantPhoneNumber, string tenantFlatNumber,
            string tenantFlatLocation, string billingDate, decimal flatMonthlyRent, decimal flatMonthlyWaterCharge,
            decimal flatMonthlyGasCharge, decimal flatMonthlyElectricCharge, decimal flatMonthlyUtilitiesCharge,
            decimal flatMonthlyOtherCharge, decimal flatMonthlyTotalBill)
        {
            PrintingBill printingBill = new PrintingBill()
            {
                TenantName=tenantName,
                TenantPhoneNumber=tenantPhoneNumber,
                TenantFlatNumber=tenantFlatNumber,
                TenantFlatLocation=tenantFlatLocation,
                BillingDate=billingDate,
                FlatMonthlyRent=flatMonthlyRent,
                FlatMonthlyWaterCharge=flatMonthlyWaterCharge,
                FlatMonthlyGasCharge=flatMonthlyGasCharge,
                FlatMonthlyElectricCharge=flatMonthlyElectricCharge,
                FlatMonthlyUtilitiesCharge=flatMonthlyUtilitiesCharge,
                FlatMonthlyOtherCharge=flatMonthlyOtherCharge,
                FlatMonthlyTotalBill=flatMonthlyTotalBill
            };
            return InvoiceDL.AddToTransactionHistoryDB(printingBill);
            
        }
    }
}
