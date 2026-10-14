using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace VietBaIT.WebGolf.APIModels
{
    public class QMSModels
    {
        public string PhongKham { get; set; }
        public string TenPhongKham { get; set; }
        public List<QMSDangTiepDon> QMSDangKham { get; set; }
        public List<QMSChoTiepDon> QMSChoKham { get; set; }
        public List<QMSNho> QMSNho { get; set; }

    }

    public class QMSDangTiepDon
    {
        public QMSBenhNhanDangTiepDon BenhNhanDangTiepDon { get; set; }
    }
    public class QMSBenhNhanDangTiepDon
    {
        public string So_Kham { get; set; }
        public string ten_bn { get; set; }
        public string nam_sinh { get; set; }
        public string dia_chi { get; set; }

        public string Is_UuTien { get; set; }
    }

    public class QMSChoTiepDon
    {
        public List<QMSBenhNhanChoTiepDon> DanhSachChoTiepDon { get; set; }
    }
    public class QMSBenhNhanChoTiepDon
    {
        public string So_Kham { get; set; }
        public string ten_bn { get; set; }
        public string nam_sinh { get; set; }
        public string dia_chi { get; set; }


        public string Is_UuTien { get; set; }
    }

    public class QMSNho
    {
        public List<QMSBenhNhanNho> DanhSachNho { get; set; }
    }
    public class QMSBenhNhanNho
    {
        public string So_Kham { get; set; }
        public string ten_bn { get; set; }
        public string nam_sinh { get; set; }

        public string Is_UuTien { get; set; }
    }
}
