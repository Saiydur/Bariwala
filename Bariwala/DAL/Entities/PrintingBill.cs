using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bariwala.DAL.Entities
{
    class PrintingBill
    {
        public int TenantId { set; get; }
        public string TenantName { set; get; }
        public string TenantPhoneNumber { set; get; }
        public string TenantFlatNumber { set; get; }
        public string TenantFlatLocation { set; get; }
        public string BillingDate { set; get; }
        public decimal FlatMonthlyRent { set; get; }
        public decimal FlatMonthlyWaterCharge { set; get; }
        public decimal FlatMonthlyGasCharge { set; get; }
        public decimal FlatMonthlyElectricCharge { set; get; }
        public decimal FlatMonthlyUtilitiesCharge { set; get; }
        public decimal FlatMonthlyOtherCharge { set; get; }
        public decimal FlatMonthlyTotalBill { set; get; }
        public int FlatDetailsId { set; get; }
    }
}
