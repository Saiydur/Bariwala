using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Bariwala.DAL.Entities
{
    class FlatDetails
    {
        public int FlatDetailsId { set; get; }
        public string FlatNumber { set; get; }
        public string FlatLocation { set; get; }
        public int FlatSize { set; get; }
        public int FlatBedRoom { set; get; }
        public int FlatDinningRoom { set; get; }
        public int FlatDrawingRoom { set; get; }
        public int FlatWashRoom { set; get; }
        public int FlatKitchen { set; get; }
        public int FlatBalcony { set; get; }
        public decimal FlatMonthlyGasCharge { set; get; }
        public decimal FlatMonthlyWaterCharge { set; get; }
        public decimal FlatMonthlyElectricCharge { set; get; }
        public decimal FlatMonthlyUtilitiesCharge { set; get; }
        public decimal FlatMonthlyRent { set; get; }
        public int FlatOwnerId { set; get; }
        public int FlatTenantId { set; get; }
    }
}
