using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class ViewDuocDanhSachThuocChoXacNhan
    {
        public double? SoLuong { get; set; }
        public short? IdKho { get; set; }
        public int? IdThuocKho { get; set; }
        public int IdThuoc { get; set; }
        public int? LoaiPhieu { get; set; }
    }
}
