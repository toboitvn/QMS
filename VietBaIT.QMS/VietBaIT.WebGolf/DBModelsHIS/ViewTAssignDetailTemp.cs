using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewTAssignDetailTemp
    {
        public long AssignDetailId { get; set; }
        public long? ExamId { get; set; }
        public long AssignId { get; set; }
        public short? ServiceId { get; set; }
        public int ServiceDetailId { get; set; }
        public short? DiagPerson { get; set; }
        public decimal? DiscountPrice { get; set; }
        public decimal? SurchargePrice { get; set; }
        public string UserId { get; set; }
        public DateTime? InputDate { get; set; }
        public byte? IsPayment { get; set; }
        public int? Quantity { get; set; }
        public string GhiChu { get; set; }
        public decimal? GiaBhytCt { get; set; }
        public decimal? GiaBnct { get; set; }
        public byte? ChoPhepIn { get; set; }
        public short? Stt { get; set; }
        public short? IdNoiThien { get; set; }
        public string TenLoaiDvu { get; set; }
        public string ServiceCode { get; set; }
        public short? IntOrderGroup { get; set; }
        public string TenDvu { get; set; }
        public int? IntOrder { get; set; }
        public string NoiThucHien { get; set; }
    }
}
