using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TExamFull
    {
        public string PatientCode { get; set; }
        public int PatientId { get; set; }
        public string BloodType { get; set; }
        public string BodyTemp { get; set; }
        public string BloodPres { get; set; }
        public string Artery { get; set; }
        public string BreatheRate { get; set; }
        public string Height { get; set; }
        public string Weight { get; set; }
        public string SDesc { get; set; }
        public string CreatedBy { get; set; }
        public DateTime? CreateDate { get; set; }
        public string ModifiedBy { get; set; }
        public DateTime? ModifiedDate { get; set; }
        public string Bmi { get; set; }
        public string ToanThanDangDi { get; set; }
        public string ToanThanTinhThan { get; set; }
        public string ToanThanHinhDangChung { get; set; }
        public string ToanThanMauSacDa { get; set; }
        public string ToanThanTinhTrangDa { get; set; }
        public string ToanThanHeThongLongToc { get; set; }
        public string BoPhanNghiCoBenh { get; set; }
        public string BoPhanDau { get; set; }
        public string BoPhanCo { get; set; }
        public string BoPhanNguc { get; set; }
        public string BoPhanBung { get; set; }
        public string BoPhanCotSong { get; set; }
        public string BoPhanChatThai { get; set; }
        public string IdbacSy { get; set; }
        public DateTime NgayKham { get; set; }
        public string KhamToanThan { get; set; }
        public string KhamBoPhan { get; set; }
        public decimal? Spo2 { get; set; }
        public int? IsNoiTru { get; set; }
    }
}
