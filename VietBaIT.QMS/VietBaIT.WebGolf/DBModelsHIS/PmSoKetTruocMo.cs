using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHIS
{
    public partial class PmSoKetTruocMo
    {
        public long IdPhieu { get; set; }
        public int PatientId { get; set; }
        public string PatientCode { get; set; }
        public int IdPhongMo { get; set; }
        public DateTime? NgayLapPhieu { get; set; }
        public string ChanDoanTruocMo { get; set; }
        public string BenhSuVaDienBien { get; set; }
        public string TrieuChung { get; set; }
        public string KetQuaXnHh { get; set; }
        public string DuKienPpmo { get; set; }
        public string DuKienPpvoCam { get; set; }
        public string DuTruMau { get; set; }
        public string DuKienKhoKhan { get; set; }
        public string ChuTri { get; set; }
        public string CacBstrongKhoa { get; set; }
        public string TomTatYkien { get; set; }
        public string KetLuan { get; set; }
        public bool? ThuongOrCapCuu { get; set; }
        public int? SoKetBoSung { get; set; }
        public DateTime? NgayTao { get; set; }
        public string NguoiTao { get; set; }
        public string IpMayTao { get; set; }
        public string IpMacTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgaySua { get; set; }
        public string IpMaySua { get; set; }
        public string IpMacSua { get; set; }
        public string ListMaPppt { get; set; }
        public decimal? TongChiPhi { get; set; }
        public string KetQuaXnNt { get; set; }
        public string KetQuaXnKhac { get; set; }
        public string KetQuaCdhaXqtp { get; set; }
        public string KetQuaCdhaXq { get; set; }
        public string KetQuaCdhaSa { get; set; }
        public string KetQuaCdhaNs { get; set; }
        public string KetQuaCdhaDt { get; set; }
        public string KetQuaCdhaKhac { get; set; }
        public string PhanUngThuoc { get; set; }
        public string KhamGayMe { get; set; }
        public DateTime? NgayDuKienMo { get; set; }
        public string KipPttt { get; set; }
        public string KipGayme { get; set; }
        public string Phudungcu { get; set; }
        public int? AssignDetailId { get; set; }
        public string MotaKipPttt { get; set; }
        public string MotaKipGayme { get; set; }
    }
}
