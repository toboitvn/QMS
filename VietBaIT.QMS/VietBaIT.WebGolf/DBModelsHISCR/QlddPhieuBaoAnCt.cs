using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class QlddPhieuBaoAnCt
    {
        public int IdPhieuBaoAnCt { get; set; }
        public int IdPhieuBaoAn { get; set; }
        public string MaCheDo { get; set; }
        public short IdGio { get; set; }
        public int SoLuong { get; set; }
        public decimal DonGia { get; set; }
        public bool PaymentStatus { get; set; }
        public DateTime? PaymentDate { get; set; }
        public int? PaymentId { get; set; }
        public bool? IsPayment { get; set; }
        public bool? IsCancel { get; set; }
        public int? IdPhieuHuyBaoAn { get; set; }
    }
}
