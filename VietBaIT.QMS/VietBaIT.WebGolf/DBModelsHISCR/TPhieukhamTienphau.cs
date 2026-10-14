using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TPhieukhamTienphau
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string CdTruocmo { get; set; }
        public bool? LoaiMo { get; set; }
        public string TsDiungthuoc { get; set; }
        public string TsVetmocu { get; set; }
        public string TsBenhmantinh { get; set; }
        public string TsBenhtimmach { get; set; }
        public string TsBatthuongkhac { get; set; }
        public string KqclsHa { get; set; }
        public string KqclsMach { get; set; }
        public string KqclsN { get; set; }
        public string KqclsTrongluong { get; set; }
        public string KqclsHc { get; set; }
        public string KqclsBc { get; set; }
        public string KqclsTq { get; set; }
        public string KqclsTck { get; set; }
        public string KqclsHb { get; set; }
        public string KqclsXnnuoctieu { get; set; }
        public string KqclsDientim { get; set; }
        public string KqclsCdha { get; set; }
        public string KqKhamtmh { get; set; }
        public DateTime? Ngaykham { get; set; }
        public string BsPhauthuat { get; set; }
        public string TinhtrangBnHientai { get; set; }
        public string PpvcDukien { get; set; }
        public string Ranggia { get; set; }
        public string Didang { get; set; }
        public DateTime? YlenhTienme { get; set; }
        public string BsGaymehoisuc { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string NguoiSua { get; set; }
        public string IpMaytao { get; set; }
    }
}
