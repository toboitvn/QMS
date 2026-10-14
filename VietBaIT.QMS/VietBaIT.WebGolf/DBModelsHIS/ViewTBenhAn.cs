using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class ViewTBenhAn
    {
        public short? MaBaNoitru { get; set; }
        public string PatientName { get; set; }
        public int? Tuoi { get; set; }
        public byte PatientSex { get; set; }
        public short? ObjectTypeId { get; set; }
        public string PatientJob { get; set; }
        public string PatientAddr { get; set; }
        public short? IdNoiGioiThieu { get; set; }
        public DateTime? NgayNhapVien { get; set; }
        public DateTime? NgayChuyenVien { get; set; }
        public DateTime? NgayRaVien { get; set; }
        public DateTime? NgayTao { get; set; }
        public string ChanDoanNoiChuyenDen { get; set; }
        public string CdKhoaDtri { get; set; }
        public string ChanDoanGphau { get; set; }
        public int? PatientCode { get; set; }
        public int? IdKetQuaDtri { get; set; }
        public string LoaiBa { get; set; }
        public string CdKkbCcuu { get; set; }
    }
}
