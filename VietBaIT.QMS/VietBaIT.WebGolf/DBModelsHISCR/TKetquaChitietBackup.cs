using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TKetquaChitietBackup
    {
        public long IdKqChiTiet { get; set; }
        public string AssignCode { get; set; }
        public int IdChiDinh { get; set; }
        public string BarCode { get; set; }
        public int? SoThuTuIn { get; set; }
        public string KetQua { get; set; }
        public string TbNu { get; set; }
        public string TbNam { get; set; }
        public string DonVi { get; set; }
        public string TenThongSo { get; set; }
        public string TenKq { get; set; }
        public int? LoaiKq { get; set; }
        public int? ChoPhepHienThi { get; set; }
        public int? ChoPhepIn { get; set; }
        public string GhiChu { get; set; }
        public int? LoaiXn { get; set; }
        public short? IdNhomXn { get; set; }
    }
}
