using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class QheChiatienPhauthuat
    {
        public int Id { get; set; }
        public int IdLoaiphautthuat { get; set; }
        public int StaffId { get; set; }
        public byte HienThi { get; set; }
        public decimal? DongiaChietkhau { get; set; }
        public decimal? PtramChietkhau { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
    }
}
