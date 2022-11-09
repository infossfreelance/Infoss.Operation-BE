using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Infoss.Operation.EstimateProfitLossModel
{
    public class ShippmentListByIdResponse
    {
        public string RowStatus { set; get; }
        public int HeaderId { set; get; }
        public int DetailId { set; get; }
        public int CountryId { set; get; }
        public int BranchId { set; get; }
        public int CustomerId { set; get; }
        public int CustomerTypeId { set; get; }
        public int AccountId { set; get; }
        public string Description { set; get; }
        public int AmountIDR { set; get; }
        public int AmountUSD { set; get; }
        public int IsCostToCost { set; get; }
        public int IsCostTrucking { set; get; }
        public int IsAdditional { set; get; }
        public int IsIgnoreItem { set; get; }
        public int KendaraanId { set; get; }
        public string KendaraanNopol { set; get; }
        public int EmployeeId { set; get; }
        public string EmployeeName { set; get; }
    }

    public class ShipmentRequestById
    {
        public int flag { get; set; }
        public int ShipmentId { get; set; }
        public int CustomerTypeId { get; set; }
        public int CountryId { get; set; }
        public int BranchId { get; set; }
        public int CompanyId { get; set; }
    }

  
}
