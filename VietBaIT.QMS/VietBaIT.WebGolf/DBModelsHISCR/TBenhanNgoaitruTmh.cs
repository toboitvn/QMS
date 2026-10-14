using System;
using System.Collections.Generic;

// Code scaffolded by EF Core assumes nullable reference types (NRTs) are not used or disabled.
// If you have enabled NRTs for your project, then un-comment the following line:
// #nullable disable

namespace VietBaIT.WebGolf.DBModelsHISCR
{
    public partial class TBenhanNgoaitruTmh
    {
        public long Id { get; set; }
        public string SoBenhAn { get; set; }
        public int IdBnhan { get; set; }
        public string PatientCode { get; set; }
        public string NgaySinh { get; set; }
        public string ThangSinh { get; set; }
        public short? NamSinh { get; set; }
        public string DiaChi { get; set; }
        public string DoiTuong { get; set; }
        public string SoBhyt { get; set; }
        public string DanToc { get; set; }
        public string NoiLamviec { get; set; }
        public string ThongtinLhe { get; set; }
        public string DthoaiLhe { get; set; }
        public string CdoanGioithieu { get; set; }
        public short? YTe { get; set; }
        public DateTime? NgayKham { get; set; }
        public string BatLdvv { get; set; }
        public string BatBhQtbl { get; set; }
        public string BatHbBt { get; set; }
        public string BatHbGd { get; set; }
        public string BatKbTt { get; set; }
        public string BatKbCbp { get; set; }
        public string KcbMach { get; set; }
        public string KcbNhietdo { get; set; }
        public string KcbHuyetap1 { get; set; }
        public string KcbNhiptho { get; set; }
        public string KcbCannang { get; set; }
        public string KcbChieucao { get; set; }
        public string KcbBmi { get; set; }
        public string BatKbKqcls { get; set; }
        public string BatKbCdbd { get; set; }
        public string BatKbDxl { get; set; }
        public DateTime? KcbDtriTungay { get; set; }
        public DateTime? KcbDtriDenngay { get; set; }
        public string KqdtToanthan { get; set; }
        public string KqdtTaicho { get; set; }
        public string BatKbCdrv { get; set; }
        public string BatKbCdrvMa { get; set; }
        public string BatKbBenhphu { get; set; }
        public string BatKbBenhphuMa { get; set; }
        public string Tienluongbenh { get; set; }
        public string Chidan { get; set; }
        public string NguoiTao { get; set; }
        public string NguoiSua { get; set; }
        public DateTime? NgayTao { get; set; }
        public DateTime? NgaySua { get; set; }
        public string MaCoso { get; set; }
    }
}
