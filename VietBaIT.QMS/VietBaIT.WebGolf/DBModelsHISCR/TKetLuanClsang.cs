using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TKetLuanClsang
    {
        public long IdKetLuan { get; set; }
        public long? AssignDetailId { get; set; }
        public long? AssignId { get; set; }
        public string MaChidinh { get; set; }
        public string VungKsat { get; set; }
        public string NoiDung { get; set; }
        public string KetLuan { get; set; }
        public string DeNghi { get; set; }
        public string DocumentName { get; set; }
        public string NguoiTraKqua { get; set; }
        public DateTime NgayTraKqua { get; set; }
        public string IdBsiTraKqua { get; set; }
        public string LoaiKqua { get; set; }
        public string MaMay { get; set; }
        public string MaChiso { get; set; }
        public string LinkUrl { get; set; }
        public DateTime? ThoigianBatdau { get; set; }
        public string TenChiso { get; set; }

        public virtual TAssignDetail AssignDetail { get; set; }
    }
}
