using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DPhieuCapphatCtTemp
    {
        public int? IdCapPhatCt { get; set; }
        public int? IdCapphat { get; set; }
        public int? IdDonthuoc { get; set; }
        public int? IdDonthuocCtiet { get; set; }
        public bool? DaLinh { get; set; }
        public int? SoLuong { get; set; }
        public int? IdThuoc { get; set; }
        public int? IdDtri { get; set; }
        public DateTime? NgayTao { get; set; }
    }
}
