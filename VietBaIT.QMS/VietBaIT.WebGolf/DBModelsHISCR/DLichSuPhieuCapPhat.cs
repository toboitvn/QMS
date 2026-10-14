using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class DLichSuPhieuCapPhat
    {
        public int Id { get; set; }
        public short? IdKhoXuat { get; set; }
        public int IdCapphat { get; set; }
        public int SoLuong { get; set; }
        public DateTime NgayHetHan { get; set; }
        public int IdThuoc { get; set; }
        public decimal DonGia { get; set; }
        public decimal GiaBan { get; set; }
        public decimal Vat { get; set; }
    }
}
