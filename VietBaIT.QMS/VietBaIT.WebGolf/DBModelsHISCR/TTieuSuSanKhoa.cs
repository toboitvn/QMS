using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TTieuSuSanKhoa
    {
        public int Id { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public short? Nam { get; set; }
        public bool? DeDuThang { get; set; }
        public bool? DeThieuThang { get; set; }
        public bool? Say { get; set; }
        public bool? Hut { get; set; }
        public bool? Nao { get; set; }
        public bool? PhaThaiTo { get; set; }
        public bool? ChuaNgoaiTcung { get; set; }
        public bool? ChuaTrung { get; set; }
        public bool? ThaiChetLuu { get; set; }
        public string ConHienSong { get; set; }
        public string CanNang { get; set; }
        public string PphapDe { get; set; }
        public string TaiBien { get; set; }
    }
}
