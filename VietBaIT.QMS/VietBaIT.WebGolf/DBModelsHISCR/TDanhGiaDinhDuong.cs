using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TDanhGiaDinhDuong
    {
        public long IdPhieu { get; set; }
        public string SoPhieu { get; set; }
        public int LoaiPhieu { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string Chandoan { get; set; }
        public int? CannangVaovien { get; set; }
        public int? Chieucao { get; set; }
        public int? Bmi { get; set; }
        public int? CannangRavien { get; set; }
        public string SlncBmi { get; set; }
        public string SlncSutcan { get; set; }
        public string SlncLuongan { get; set; }
        public string SlncBenhnang { get; set; }
        public string SlncKetluan { get; set; }
        public string SlncChidinh { get; set; }
        public string DgddBmi { get; set; }
        public string DgddSutcan { get; set; }
        public string DgddLuongan { get; set; }
        public string DgddBenhly { get; set; }
        public string DgddKetluan { get; set; }
        public string CtddMaso { get; set; }
        public string CtddAnkieng { get; set; }
        public string CtddDuongnuoian { get; set; }
        public string CtddHoichan { get; set; }
        public string CtddTaidanhgia { get; set; }
        public DateTime NgayDanhgia { get; set; }
        public string BsDanhgia { get; set; }
        public int? TrangThai { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMacTao { get; set; }
        public string IpMacSua { get; set; }
    }
}
