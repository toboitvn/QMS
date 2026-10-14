using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class PhicongGiamdinhsuckhoe
    {
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string Sogiamdinh { get; set; }
        public DateTime Ngaygiamdinh { get; set; }
        public DateTime? Ngaygiamdinh2 { get; set; }
        public bool? Gdtaivien { get; set; }
        public string Noidunggd { get; set; }
        public string Loaigskdn { get; set; }
        public int? Lankham { get; set; }
        public string Loaigpdenghi { get; set; }
        public string Cnsklantruoc { get; set; }
        public string Noicapcnsklt { get; set; }
        public string Giayphephkhc { get; set; }
        public string Sogphc { get; set; }
        public int? Nuoccap { get; set; }
        public int? Tongsogiobay { get; set; }
        public int? Sogiobaytlt { get; set; }
        public int? Giamdinhlai { get; set; }
        public DateTime? Ngayketluan { get; set; }
        public int? Dudienkien { get; set; }
        public string Loaidieukien { get; set; }
        public DateTime? Ngaygdkdlt { get; set; }
        public DateTime? Ngaygd35lt { get; set; }
        public DateTime? Ngaygddklt { get; set; }
        public string Theluc { get; set; }
        public string Ketluan { get; set; }
        public string Chuy { get; set; }
        public string MaIcd { get; set; }
        public DateTime? Ngaytainan { get; set; }
        public string Noitainan { get; set; }
        public string Chitiettainan { get; set; }
        public int? Trangthai { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Nguoitao { get; set; }
        public string Ipmactao { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Nguoisua { get; set; }
        public string Ipmacsua { get; set; }
        public bool? DaKetluan { get; set; }
    }
}
