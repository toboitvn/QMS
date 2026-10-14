using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TPhieuKhamGayMeTruocMo
    {
        public string SttRec { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public DateTime NgayLapPhieu { get; set; }
        public int? IdBsyDtri { get; set; }
        public int? IdKhoa { get; set; }
        public DateTime? CreateDate { get; set; }
        public string CreateBy { get; set; }
        public DateTime? ModifyDate { get; set; }
        public string ModifiedBy { get; set; }
        public string BloodTypeAbo { get; set; }
        public string CanNang { get; set; }
        public string ChieuCao { get; set; }
        public string Asa { get; set; }
        public string Mallampati { get; set; }
        public string GioAn { get; set; }
        public string CamGiac { get; set; }
        public string HaMieng { get; set; }
        public short? ChkRangGia { get; set; }
        public short? ChkCapCuu { get; set; }
        public string ChanDoan { get; set; }
        public string HuongXuTri { get; set; }
        public string TienSuNoiKhoa { get; set; }
        public string TienSuNgoaiKhoa { get; set; }
        public string TienSuGayMeGayTe { get; set; }
        public string DiUng { get; set; }
        public short? ChkNghien { get; set; }
        public string BenhLayNhiem { get; set; }
        public string ThuocDangDtri { get; set; }
        public string KhamLamSang { get; set; }
        public string TuanHoan { get; set; }
        public string M { get; set; }
        public string Ha { get; set; }
        public string HoHap { get; set; }
        public string ThanKinh { get; set; }
        public string CotSong { get; set; }
        public string XnBatThuong { get; set; }
        public string YeuCauBoSung { get; set; }
        public string DuKienCachThuocVoCam { get; set; }
        public string DuKienGiamDauSauPt { get; set; }
        public string YlenhTruocMo { get; set; }
        public string YtaThucHien { get; set; }
        public string ThuocTienMe { get; set; }
        public DateTime? NgayKham { get; set; }
        public DateTime? NgayThamLai { get; set; }
        public string IpMayTao { get; set; }
        public string GhiChu { get; set; }
        public int? TrangThaiIn { get; set; }
        public int? LanIn { get; set; }
        public bool? NghienThuocla { get; set; }
        public bool? NghienThuoclao { get; set; }
        public bool? NghienRuou { get; set; }
        public bool? NghienMatuy { get; set; }
    }
}
