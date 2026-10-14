using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class LObjectTypeService
    {
        public int ObjectTypeServiceId { get; set; }
        public short ObjectTypeId { get; set; }
        public short ServiceId { get; set; }
        public int? ServiceDetailId { get; set; }
        public decimal? DiscountRate { get; set; }
        public byte DiscountType { get; set; }
        public string SDesc { get; set; }
        public decimal? LastPrice { get; set; }
        public decimal? Surcharge { get; set; }
        public int? ObjectTypeType { get; set; }
        public decimal? PhuThuTraiTuyen { get; set; }
        public string MaDtuong { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string MaKhoaThien { get; set; }
        public decimal? GiaCu { get; set; }
        public DateTime? NgayBatdau { get; set; }
        public DateTime? NgayKetthuc { get; set; }
        public decimal? TyleTt { get; set; }

        public virtual LObjectType ObjectType { get; set; }
        public virtual LServiceDetail ServiceDetail { get; set; }
    }
}
