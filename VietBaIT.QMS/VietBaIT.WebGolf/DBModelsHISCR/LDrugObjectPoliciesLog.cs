using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LDrugObjectPoliciesLog
    {
        public int Id { get; set; }
        public int? DrugId { get; set; }
        public int? ObjectTypeId { get; set; }
        public string DiscountType { get; set; }
        public decimal? DiscountRate { get; set; }
        public decimal? OriginalPrice { get; set; }
        public decimal? LastPrice { get; set; }
        public decimal? Surcharge { get; set; }
        public int? ObjectTypeType { get; set; }
        public decimal? PhuThuTraiTuyen { get; set; }
        public string ObjectTypeCode { get; set; }
        public DateTime? NgaySua { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public string NguoiTao { get; set; }
        public string Status { get; set; }
        public string Ip { get; set; }
    }
}
