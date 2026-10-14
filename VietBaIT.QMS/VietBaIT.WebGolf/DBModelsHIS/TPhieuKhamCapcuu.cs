using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class TPhieuKhamCapcuu
    {
        public int IdPhieukhamcapcuu { get; set; }
        public string PatientCode { get; set; }
        public int? PatientId { get; set; }
        public string Nguoitao { get; set; }
        public DateTime? Ngaytao { get; set; }
        public string Ipmaytao { get; set; }
        public string Nguoisua { get; set; }
        public DateTime? Ngaysua { get; set; }
        public string Ipmaysua { get; set; }
        public DateTime? Ngaygiodencapcuu { get; set; }
        public string Bacsicapcuu { get; set; }
        public string Ytacapcuu { get; set; }
        public string Phuongtienchuyen { get; set; }
        public string Lydocapcuu { get; set; }
        public string Benhsu { get; set; }
        public string Ngaythumaycuabenh { get; set; }
        public string Tiensu { get; set; }
        public string ThamkhamHuyetap { get; set; }
        public string ThamkhamMach { get; set; }
        public string ThamkhamNhietdo { get; set; }
        public string ThamkhamNhiptho { get; set; }
        public string ThamkhamKhotho { get; set; }
        public string ThamkhamSpo2 { get; set; }
        public string ThamkhamLiet { get; set; }
        public string ThamkhamVitriliet { get; set; }
        public string ThamkhamDiemglasgow { get; set; }
        public string ThamkhamPhu { get; set; }
        public string ThamkhamTimmach { get; set; }
        public string ThamkhamHohap { get; set; }
        public string ThamkhamTieuhoa { get; set; }
        public string ThamkhamThantietnieu { get; set; }
        public string ThamkhamTamthankinh { get; set; }
        public string ThamkhamKhac { get; set; }
        public string NgoaikhoaTonthuong { get; set; }
        public string NgoaikhoaChanthuong { get; set; }
        public string NgoaikhoaVitri { get; set; }
        public string NgoaikhoaTrieuchungtaicho { get; set; }
        public string NgoaikhoaTrieuchungtoanthan { get; set; }
        public string ClsCtmHongcau { get; set; }
        public string ClsCtmHb { get; set; }
        public string ClsCtmHema { get; set; }
        public string ClsCtmBachcau { get; set; }
        public string ClsCtmTieucau { get; set; }
        public string ClsCtmCtbc { get; set; }
        public string ClsCtmGran { get; set; }
        public string ClsCtmLym { get; set; }
        public string ClsCtmMono { get; set; }
        public string ClsCtmEosin { get; set; }
        public string ClsSh { get; set; }
        public string ClsNtHongcau { get; set; }
        public string ClsNtBachcau { get; set; }
        public string ClsNtGlu { get; set; }
        public string ClsNtPro { get; set; }
        public string ClsNtKhac { get; set; }
        public string ClsDientim { get; set; }
        public string ClsXquang { get; set; }
        public string ClsSieuam { get; set; }
        public string Chandoan { get; set; }
        public string ClsChandoanPhanbiet { get; set; }
        public DateTime? NgaygioBibenh { get; set; }
        public int? Nguonden { get; set; }
        public int? BacCapcuu { get; set; }
        public int? Chuyenkhoacapcuu { get; set; }
        public string ClsHuyethoc { get; set; }
        public string ClsDongmau { get; set; }
        public string ClsXnKhac { get; set; }
        public string ClsXqTp { get; set; }
        public string ClsNoisoi { get; set; }
        public string ClsCdhaKhac { get; set; }
        public int? IsCapCuu { get; set; }
    }
}
