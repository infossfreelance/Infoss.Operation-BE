namespace Infoss.Operation.EstimateProfitLossModel
{
    public class EstimateProfitLossResponse
    {
        public string RowStatus { get; set; } = string.Empty;
        public int Id { get; set; } = 0;
        public int EPLNo { get; set; } = 0;
        public int ShipmentId { get; set; } = 0;
        public int CountryId { get; set; } = 0;
        public int CompanyId { get; set; } = 0;
        public int BranchId { get; set; } = 0;
        public decimal Rate { get; set; } = 0;
        public DateTime ExRateDate { get; set; }
        public decimal EstUSDShipCons { get; set; } = 0;
        public decimal EstIDRShipCons { get; set; } = 0;
        public decimal EstUSDAgent { get; set; } = 0;
        public decimal EstIDRAgent { get; set; } = 0;
        public int TimeCloseEPL { get; set; } = 0;
        public bool CloseEPL { get; set; }
        public DateTime ClosedEPLOn { get; set; }
        public int Period { get; set; } = 0;
        public int YearPeriod { get; set; } = 0;
        public int ExRateId { get; set; } = 0;
        public int IdLama { get; set; } = 0;
        public int Printing { get; set; } = 0;
        public DateTime PrintedOn { get; set; }
        public int Deleted { get; set; } = 0;
        public DateTime DeletedOn { get; set; }
        public string ModifiedBy { get; set; } = string.Empty;
        public DateTime ModifiedOn { get; set; } = DateTime.Today;
        public string CreatedBy { get; set; } = string.Empty;
        public DateTime CreatedOn { get; set; } = DateTime.Today;

    }

    public class responsePagination
    {
        public IEnumerable<EstimateProfitLossResponse> list { get; set; }
        public int pageSize { get; set; }
        public int PageNo{ get; set; }
        public int RecordCount { get; set; }

    }

    public class ShipmentOrderResponse
    {
        public int ShipmentId { get; set; }
        public int Shipper { get; set; }
        public int Agent { get; set; }
        public int AccountId { get; set; }
    }

    public class ResponseShipmentList
    {
        public IEnumerable<ShipmentOrderResponse> list { get; set; }

        public int pageSize { get; set; }
        public int PageNo { get; set; }
        public int RecordCount { get; set; }

    }
}
