using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class LServices
    {
        public LServices()
        {
            LServiceDetail = new HashSet<LServiceDetail>();
        }

        public short ServiceId { get; set; }
        public short ServiceTypeId { get; set; }
        public string ServiceCode { get; set; }
        public string ServiceName { get; set; }
        public decimal Price { get; set; }
        public byte Valid { get; set; }
        public short? HtechService { get; set; }
        public short IntOrder { get; set; }
        public byte? ServiceDetail { get; set; }
        public string Sdesc { get; set; }
        public string MaKetNoi { get; set; }
        public string MaNhom { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public short? DepartmentId { get; set; }
        public string TieuDePhieuCls { get; set; }
        public string MaInPhieu { get; set; }
        public string MaInPhieuHa { get; set; }
        public bool? IsChiPhiThem { get; set; }
        public bool? GuiLis { get; set; }
        public string EmrDocument { get; set; }
        public string EmrPhieuketqua { get; set; }

        public virtual LServiceType ServiceType { get; set; }
        public virtual ICollection<LServiceDetail> LServiceDetail { get; set; }
    }
}
