using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TDatLichKham
    {
        public int DatKhamId { get; set; }
        public string TenBn { get; set; }
        public byte GioiTinh { get; set; }
        public DateTime? NgaySinh { get; set; }
        public short NamSinh { get; set; }
        public string DienThoai { get; set; }
        public string DiaChi { get; set; }
        public string Email { get; set; }
        public string Cmt { get; set; }
        public short KieuKhamId { get; set; }
        public DateTime NgayTaoKham { get; set; }
        public string NguoiTao { get; set; }
        public DateTime NgayHenKham { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public string YeuCauDacBiet { get; set; }
    }
}
