using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class BaMatPkkq
    {
        public long IdBenhan { get; set; }
        public string SoBenhan { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public string DoiTuong { get; set; }
        public string QlnbTiensuDiungThuoc { get; set; }
        public DateTime? QlnbNgaygioVaovien { get; set; }
        public string QlnbTructiepvao { get; set; }
        public string QlnbNoigioithieu { get; set; }
        public int QlnbLanVaovien { get; set; }
        public int? QlnbVaokhoa { get; set; }
        public string QlnbChuyenvien { get; set; }
        public string QlnbChuyenden { get; set; }
        public DateTime? QlnbNgaygioRavien { get; set; }
        public string QlnbLydoRavien { get; set; }
        public int QlnbSongayDieutri { get; set; }
        public string CdNoichuyenden { get; set; }
        public string CdNoichuyendenIcd { get; set; }
        public string CdKkbCapcuu { get; set; }
        public string CdKkbCapcuuIcd { get; set; }
        public int? CdKkbCapcuuBacsicd { get; set; }
        public DateTime? CdKkbCapcuuNgaycd { get; set; }
        public string CdKhivaoKdt { get; set; }
        public string CdKhivaoKdtIcd { get; set; }
        public bool? CdRavienBienchung { get; set; }
        public bool? CdRavienTaibien { get; set; }
        public string CdLydoTaibienBienchung { get; set; }
        public string CdRavienBenhchinh { get; set; }
        public string CdRavienBenhchinhIcd { get; set; }
        public string CdRvBenhchinhNguyennhan { get; set; }
        public string CdRvBenhchinhNguyennhanIcd { get; set; }
        public string CdRavienBenhphu { get; set; }
        public string CdRavienBenhphuIcd { get; set; }
        public string CdTruocPhauthuat { get; set; }
        public string CdTruocPhauthuatIcd { get; set; }
        public string CdSauPhauthuat { get; set; }
        public string CdSauPhauthuatIcd { get; set; }
        public int CdSongayDtriSaupt { get; set; }
        public int? CdSolanPhauthuat { get; set; }
        public string TtrvKqdt { get; set; }
        public string TtrvGiaiphau { get; set; }
        public DateTime? TtrvNgaygioTuvong { get; set; }
        public string TtrvLydoTuvong { get; set; }
        public string TtrvThoigianTuvong { get; set; }
        public string TtrvNguyennhanchinhTuvong { get; set; }
        public string TtrvNguyennhanchinhTuvongIcd { get; set; }
        public bool? TtrvKhamnghiem { get; set; }
        public string TtrvCdGiaiphau { get; set; }
        public string TtrvCdGiaiphauIcd { get; set; }
        public string BaLydovaovien { get; set; }
        public int BaNgaybenh { get; set; }
        public string BaBenhsu { get; set; }
        public string BaKbToanthan { get; set; }
        public string BaKbTuanhoan { get; set; }
        public string BaKbHohap { get; set; }
        public string BaKbTieuhoa { get; set; }
        public string BaKbKhac { get; set; }
        public string BaKbThilucMp { get; set; }
        public string BaKbThilucMt { get; set; }
        public string BaKbNAMp { get; set; }
        public string BaKbNAMt { get; set; }
        public string BaKbTeboMp { get; set; }
        public string BaKbTeboMt { get; set; }
        public string BaKbMimatMp { get; set; }
        public string BaKbMimatMt { get; set; }
        public string BaKbKetmacMp { get; set; }
        public string BaKbKetmacMt { get; set; }
        public string BaKbMathotMp { get; set; }
        public string BaKbMathotMt { get; set; }
        public string BaKbGiacmacMp { get; set; }
        public string BaKbGiacmacMt { get; set; }
        public string BaKbTienphongMp { get; set; }
        public string BaKbTienphongMt { get; set; }
        public string BaKbMongmatMp { get; set; }
        public string BaKbMongmatMt { get; set; }
        public string BaKbDongtuMp { get; set; }
        public string BaKbDongtuMt { get; set; }
        public string BaKbNhanmatMp { get; set; }
        public string BaKbNhanmatMt { get; set; }
        public string BaKbDichkinhMp { get; set; }
        public string BaKbDichkinhMt { get; set; }
        public string BaKbKhucxaMp { get; set; }
        public string BaKbKhucxaMt { get; set; }
        public string BaKbVannhanMp { get; set; }
        public string BaKbVannhanMt { get; set; }
        public string BaKbDaymatMp { get; set; }
        public string BaKbDaymatMt { get; set; }
        public string BaKlTomtat { get; set; }
        public string BaKlChandoan { get; set; }
        public string BaKlXetnghiem { get; set; }
        public string BaKlHuongdieutri { get; set; }
        public string BaKlTienluong { get; set; }
        public string TkCachdieutri { get; set; }
        public string TkKetqua { get; set; }
        public string TkDieutri { get; set; }
        public string TkNoiravien { get; set; }
        public string TkKhananglaodong { get; set; }
        public int? TkSolanTruyenmau { get; set; }
        public decimal? TkSomau { get; set; }
        public string TkTaibien { get; set; }
        public string TkTaibienNguyennhan { get; set; }
        public string TkTaibienNguyennhanIcd { get; set; }
        public string TkTinhchat { get; set; }
        public string TkSosanh { get; set; }
        public string TkVocam { get; set; }
        public string TkKetquataibien { get; set; }
        public string TkNguyenhanTuvong { get; set; }
        public string TkSosanhCuoicung { get; set; }
        public string TkNhandinh { get; set; }
        public DateTime NgayTaoBenhan { get; set; }
        public string NguoiTaoBenhan { get; set; }
        public string NguoiGiaoHoso { get; set; }
        public string NguoiNhanHoso { get; set; }
        public DateTime NgayTongket { get; set; }
        public string BsDieutri { get; set; }
        public string NguoiTao { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMacTao { get; set; }
        public string IpMacSua { get; set; }
    }
}
