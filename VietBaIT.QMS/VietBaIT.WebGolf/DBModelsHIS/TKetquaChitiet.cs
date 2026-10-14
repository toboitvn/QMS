using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TKetquaChitiet
    {
        public long IdKqChiTiet { get; set; }
        public string AssignCode { get; set; }
        public int IdChiDinh { get; set; }
        public string BarCode { get; set; }
        public short? SoThuTuIn { get; set; }
        public string KetQua { get; set; }
        public string TbNu { get; set; }
        public string TbNam { get; set; }
        public string DonVi { get; set; }
        public string TenThongSo { get; set; }
        public string TenKq { get; set; }
        public byte? LoaiKq { get; set; }
        public bool? ChoPhepHienThi { get; set; }
        public bool? ChoPhepIn { get; set; }
        public string GhiChu { get; set; }
        public short? LoaiXn { get; set; }
        public short? IdNhomXn { get; set; }
        public string MaMay { get; set; }
        public DateTime? NgayKq { get; set; }
        public string MaChiSo { get; set; }
        public long? TestDetailId { get; set; }
        public string MaCoSo { get; set; }
    }
}
