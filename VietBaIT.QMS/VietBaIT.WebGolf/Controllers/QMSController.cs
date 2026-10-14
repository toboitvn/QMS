using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.SignalR;
using Microsoft.Data.SqlClient;
using Microsoft.Extensions.Options;
using Newtonsoft.Json;
using NLog;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Threading.Tasks;
using VietBaIT.WebGolf.APIHelpers;
using VietBaIT.WebGolf.APIModels;
using VietBaIT.WebGolf.DBModelsHIS;
using VietBaIT.WebGolf.DBModelsHISCR;
using VietBaIT.WebGolf.DBModelsQMS;
using VietBaIT.WebGolf.Helper;


namespace VietBaIT.WebGolf.Controllers
{
    public class QMSController : Controller
    {
        public readonly AppSettings _appSettings;
        private IOptions<AppSettings> appIdentitySettingsAccessor;
        private QMSContext _dbcontext = new QMSContext();
        private HISlink_hungviet_newContext _dbcontextHIS = new HISlink_hungviet_newContext();

        public QMSController(IOptions<AppSettings> appSettings)
        {
            _appSettings = appSettings.Value;
            /* var _phoneNumber = TokenHelpers.JWTTokenGetPhoneNumber(_appSettings.Secret, httpContextAccessor.HttpContext.Request.Headers["Authorization"].FirstOrDefault()?.Split(" ").Last());*/
            /*LUser user = _dbcontext.LUser.FirstOrDefault(x => x.SoDienThoai == _phoneNumber);*/
        }
        public interface IHubClient
        {
            Task BroadcastMessage(MessageInstance msg);
        }
        public class SignalrHub : Hub<IHubClient>
        {
            public async Task BroadcastMessage(MessageInstance msg)
            {
                await Clients.All.BroadcastMessage(msg);
            }
        }
        public class MessageInstance
        {
            public string Timestamp { get; set; }
            public string From { get; set; }
            public string Message { get; set; }
        }

        //[HttpPost("/api/QMS/TaoSoQMSPhongKham")]
        //public IActionResult TaoSoQMSPhongKham([FromBody] TaoSoQMSPhongKhamRequest request)
        //{
        //    try
        //    {
        //        if (request.Department_ID == 0)
        //        {
        //            return BadRequest(new APIResponse(false, "Phòng khám không hợp lệ (Department_ID = 0)", null));
        //        }
        //        short soKhamMoi = 1;
        //        int regIdMoi = 1;
        //        int examIdMoi = 1;

        //        // Lấy số khám lớn nhất theo MA_PHONG_STT, MaCoSo và ngày
        //        var lastSoKhamRecord = _dbcontext.QmsChoKham
        //            .Where(x => x.MaPhongStt == request.MA_PHONG_STT
        //                        && x.DepartmentId == request.Department_ID
        //                        && x.MaCoSo == request.Ma_CoSo
        //                        && x.RegDate == request.Reg_Date.Date)
        //            .OrderByDescending(x => x.SoKham)
        //            .FirstOrDefault();

        //        if (lastSoKhamRecord != null)
        //        {
        //            soKhamMoi = (short)((lastSoKhamRecord?.SoKham ?? 0) + 1);
        //        }

        //        // Lấy Reg_ID lớn nhất hiện tại trong toàn bộ bảng
        //        var lastRegId = _dbcontext.QmsChoKham
        //            .OrderByDescending(x => x.RegId)
        //            .Select(x => x.RegId)
        //            .FirstOrDefault();

        //        regIdMoi = lastRegId + 1;

        //        var lastExamId = _dbcontext.QmsChoKham
        //            .OrderByDescending(x => x.ExamId)
        //            .Select(x => x.ExamId)
        //            .FirstOrDefault();

        //        examIdMoi = lastExamId + 1;

        //        var newRecord = new DBModelsQMS.QmsChoKham
        //        {
        //            RegId = regIdMoi, // Thêm Reg_ID mới
        //            PatientId = request.Patient_ID,
        //            PatientCode = request.Patient_Code,
        //            PatientName = request.PatientName,
        //            YearOfBirth = request.YearOfBirth,
        //            PatientSex = request.PatientSex,
        //            RegDate = request.Reg_Date.Date,
        //            InputDate = DateTime.Now,
        //            DepartmentId = request.Department_ID,
        //            DoctorAssignId = request.DoctorAssign_ID,
        //            Status = request.Status,
        //            SoKham = soKhamMoi,
        //            UuTien = request.uu_tien,
        //            MaKhoaThien = request.MA_KHOA_THIEN,
        //            MaPhongStt = request.MA_PHONG_STT,
        //            MaCoSo = request.Ma_CoSo,
        //            ExamId = examIdMoi,
        //            HienThi = 1,
        //            QmsHienThi = request.QMS_HienThi
        //        };

        //        _dbcontext.QmsChoKham.Add(newRecord);
        //        _dbcontext.SaveChanges();

        //        return Ok(new APIResponse(true, "Tạo số khám thành công", newRecord));
        //    }
        //    catch (Exception ex)
        //    {
        //        var message = ex.InnerException?.Message ?? ex.Message;
        //        return BadRequest(new APIResponse(false, message, null));
        //    }
        //}

        [HttpGet("/api/QMS/getListStaff")]
        public IActionResult getListStaff()
        {
            try
            {
                var functions1 = _dbcontextHIS.LStaffs.Select(x => x).Where(x => x.StaffTypeId == 5 || x.StaffTypeId == 1);

                return Ok(new APIResponse(true, string.Empty, functions1));
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse(false, ex.Message, ""));
            }
        }

        // Lấy danh sách phòng khám
        [HttpGet("/api/QMS/getListDepartment")]
        public IActionResult GetListDepartment()
        {
            try
            {
                var ds = SPHelper.ExecuteStoredProcedure(
                    globalValue.ConnectionString,
                    "Web_GetListDepartment"
                    );

                return Ok(new
                {
                    success = true,
                    message = string.Empty,
                    data = ds
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    message = e.Message
                });
            }
        }

        // Lấy danh sách phòng chức năng
        [HttpGet("/api/QMS/getListDepartmentFunction")]
        public IActionResult GetListDepartmentFunction()
        {
            try
            {
                var ds = SPHelper.ExecuteStoredProcedure(
                    globalValue.ConnectionString,
                    "QMS_GetListDepartmentFunction"
                );

                // Lấy DataTable đầu tiên từ DataSet
                var dataTable = ds.Tables[0];

                // Chuyển đổi dữ liệu trong DataTable thành danh sách
                var result = dataTable.AsEnumerable().Select(row => new
                {
                    service_ID = row.Field<int>("service_ID"),
                    ten_phong = row.Field<string>("ten_phong")
                }).ToList();

                return Ok(new
                {
                    success = true,
                    message = string.Empty,
                    data = result // Trả về danh sách trực tiếp
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    message = e.Message
                });
            }
        }

        // Lấy danh sách thống kê bệnh nhân theo phòng khám
        [HttpGet("/api/QMS/ThongKeBenhNhanTheoPhongKham")]
        public IActionResult ThongKeBenhNhanTheoPhongKham()
        {
            try
            {
                var ds = SPHelper.ExecuteStoredProcedure(
                    globalValue.QMSConnectionString,
                    "ThongKeBenhNhanPhongKham"
                    );

                return Ok(new
                {
                    success = true,
                    message = string.Empty,
                    data = ds
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    message = e.Message
                });
            }
        }

        // Danh sách chỉ định
        [HttpGet("/api/QMS/DanhSachChiDinh")]
        public IActionResult ThongKeBenhNhanTheoPhongCLS(string patientCode )
        {
            try
            {
                var ds = SPHelper.ExecuteStoredProcedure(
                    globalValue.QMSConnectionString,
                    "Web_GetDanhSachChiDinh", patientCode
                    );

                return Ok(new
                {
                    success = true,
                    message = string.Empty,
                    data = ds
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    message = e.Message
                });
            }
        }

        // Lấy danh sách bác sĩ
        [HttpGet("/api/QMS/ThongKeBenhNhanTheoPhongCLS")]
        public IActionResult ThongKeBenhNhanTheoPhongCLS()
        {
            try
            {
                var ds = SPHelper.ExecuteStoredProcedure(
                    globalValue.QMSConnectionString,
                    "ThongKeBenhNhanCLS"
                    );

                return Ok(new
                {
                    success = true,
                    message = string.Empty,
                    data = ds
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    message = e.Message
                });
            }
        }

            [HttpGet("/api/QMS/QMSDanhSachChoKham")]
            public async Task<ActionResult<string>> QMSDanhSachChoKham(string maPhong, string maKhoa, int numberRow = 3)
            {
                Utility.Log = LogManager.GetLogger("QMSDanhSachChoKham");
                var responseData = new ResultResponse();

                try
                {
                    var lstQMSModels = new List<QMSModels>();

                    DataSet ds = SPHelper.ExecuteStoredProcedure(
                        globalValue.QMSConnectionString,
                        "QMS_DanhSachChoKham",
                        maPhong,
                        maKhoa,
                        numberRow
                    );

                    if (ds == null || ds.Tables.Count == 0)
                    {
                        responseData.IsSuccess = true;
                        responseData.Messge = "Không có dữ liệu";
                        responseData.data = lstQMSModels;
                        return new JsonResult(responseData);
                    }

                    var dt = ds.Tables[0];

                    DataTable Filter(DataTable src, string expr)
                    {
                        var rows = src.Select(expr);
                        return rows.Length > 0 ? rows.CopyToDataTable() : src.Clone();
                    }

                    var dtDangKham = Filter(dt, "Status = 1");
                    var dtChoKham = Filter(dt, "Status = 0");
                    var dtNho = Filter(dt, "Hien_Thi = 3");

                    var idsFromInput = maPhong.Split(',')
                                              .Select(s => s.Trim())
                                              .Where(s => int.TryParse(s, out _))
                                              .Select(int.Parse)
                                              .ToList();

                    var idsFromData = dt.AsEnumerable()
                                        .Select(r => Utility.Int32Dbnull(r["Department_ID"]))
                                        .Where(id => id > 0)
                                        .Distinct()
                                        .ToList();

                    var phongIds = idsFromInput.Any() ? idsFromInput : idsFromData;

                    foreach (var deptId in phongIds)
                    {
                        var model = new QMSModels
                        {
                            PhongKham = deptId.ToString(),
                            QMSDangKham = GetQMSListDangKham_ByDeptId(dtDangKham, deptId),
                            QMSChoKham = GetQMSListChoKham_ByDeptId(dtChoKham, deptId),
                            QMSNho = GetQMSListNho_ByDeptId(dtNho, deptId)
                        };

                        lstQMSModels.Add(model);
                    }

                    responseData.IsSuccess = true;
                    responseData.Messge = "Thành công";
                    responseData.data = lstQMSModels;
                }
                catch (Exception ex)
                {
                    Utility.Log.Error(ex.Message);
                    var resp = new ResultResponse
                    {
                        IsSuccess = false,
                        Messge = ex.Message,
                        data = null
                    };
                    return new JsonResult(resp);
                }

                return new JsonResult(responseData);
            }

            private List<QMSNho> GetQMSListNho_ByDeptId(DataTable dtNho, int departmentId)
            {
                var lst = new List<QMSNho>();
                if (dtNho.Rows.Count == 0) return lst;

                var rows = dtNho.AsEnumerable()
                                .Where(r => Utility.Int32Dbnull(r["Department_ID"]) == departmentId);
                if (!rows.Any()) return lst;

                var table = rows.CopyToDataTable();
                var take = Math.Min(4, table.Rows.Count);

                var nho = new QMSNho
                {
                    DanhSachNho = Enumerable.Range(0, take).Select(i =>
                    {
                        var r = table.Rows[i];
                        return new QMSBenhNhanNho
                        {
                            So_Kham = Utility.sDbnull(r["So_Kham"]),
                            ten_bn = Utility.sDbnull(r["ten_bn"]),
                            Is_UuTien = Utility.sDbnull(r["uu_tien"])
                        };
                    }).ToList()
                };

                lst.Add(nho);
                return lst;
            }

            private List<QMSChoTiepDon> GetQMSListChoKham_ByDeptId(DataTable dtChoKham, int departmentId)
            {
                var lst = new List<QMSChoTiepDon>();
                if (dtChoKham.Rows.Count == 0) return lst;

                var rows = dtChoKham.AsEnumerable()
                                    .Where(r => Utility.Int32Dbnull(r["Department_ID"]) == departmentId);
                if (!rows.Any()) return lst;

                var table = rows.CopyToDataTable();
                var take = Math.Min(4, table.Rows.Count);

                var cho = new QMSChoTiepDon
                {
                    DanhSachChoTiepDon = Enumerable.Range(0, take).Select(i =>
                    {
                        var r = table.Rows[i];
                        return new QMSBenhNhanChoTiepDon
                        {
                            So_Kham = Utility.sDbnull(r["So_Kham"]),
                            ten_bn = Utility.sDbnull(r["ten_bn"]),
                            nam_sinh = Utility.sDbnull(r["nam_sinh"]),
                            Is_UuTien = Utility.sDbnull(r["uu_tien"])
                        };
                    }).ToList()
                };

                lst.Add(cho);
                return lst;
            }

            private List<QMSDangTiepDon> GetQMSListDangKham_ByDeptId(DataTable dtDangKham, int departmentId)
            {
                var lst = new List<QMSDangTiepDon>();
                if (dtDangKham.Rows.Count == 0) return lst;

                var rows = dtDangKham.AsEnumerable()
                                     .Where(r => Utility.Int32Dbnull(r["Department_ID"]) == departmentId);
                if (!rows.Any()) return lst;

                var r = rows.First();

                var benhNhan = new QMSBenhNhanDangTiepDon
                {
                    So_Kham = Utility.sDbnull(r["So_Kham"]),
                    ten_bn = Utility.sDbnull(r["ten_bn"]),
                    nam_sinh = Utility.sDbnull(r["nam_sinh"]),
                    Is_UuTien = Utility.sDbnull(r["uu_tien"])
                };

                lst.Add(new QMSDangTiepDon { BenhNhanDangTiepDon = benhNhan });
                return lst;
            }
        
    



    // Lấy danh sách phòng khám
    [HttpGet("/api/QMS/QMSDanhSachCLS")]
        public async Task<ActionResult<string>> QMSDanhSachCLS(string maPhong, string maKhoa, int numberRow = 3)
        {
            Utility.Log = LogManager.GetLogger("QMSDanhSachCLS");
            ResultResponse responseData = new ResultResponse();
            //if(numberRow == null)
            //{
            //    numberRow = 3;
            //}
            try
            {
                var lstQMSModels = new List<QMSModels>();
                DataSet ds = SPHelper.ExecuteStoredProcedure(globalValue.QMSConnectionString, "QMS_DanhSachCLS_New", maPhong, maKhoa, 5);
                var dt = ds.Tables[0];
                var rowDangKham = dt.Select("TrangThai = 2");
                var dtDangKham = rowDangKham.Any() ? rowDangKham.CopyToDataTable() : new DataTable();

                var rowChoKham = dt.Select("TrangThai = 1");
                var dtChoKham = rowChoKham.Any() ? rowChoKham.CopyToDataTable() : new DataTable();

                var rowNho = dt.Select("TrangThai = 0");
                var dtNho = rowNho.Any() ? rowNho.CopyToDataTable() : new DataTable();

                //var lstPhongKham = (from row in dt.AsEnumerable()
                //                    select Utility.sDbnull(row["MA_PHONG_STT"])).Distinct().ToList();
                var lstPhongKham = maPhong.Split(',');
                foreach (string phongKham in lstPhongKham)
                {
                    var qmsModels = new QMSModels();
                    qmsModels.PhongKham = phongKham.Trim();
                    qmsModels.QMSDangKham = GetQMSListDangKham1(dtDangKham, phongKham);
                    qmsModels.QMSChoKham = GetQMSListChoKham1(dtChoKham, phongKham);
                    qmsModels.QMSNho = GetQMSListNho1(dtNho, phongKham);
                    lstQMSModels.Add(qmsModels);
                }
                responseData.IsSuccess = true;
                responseData.Messge = "Thành công";

                //responseData.data = JsonConvert.SerializeObject(qmsModels, Formatting.Indented);
                //responseData.data = JsonConvert.SerializeObject(lstQMSModels);
                responseData.data = lstQMSModels;
            }
            catch (Exception exception)
            {
                Utility.Log.Error(exception.Message);
                responseData.IsSuccess = false;
                responseData.Messge = exception.Message;
            }
            return new JsonResult(responseData);
        }

        private List<QMSNho> GetQMSListNho1(DataTable dtNho, string phongKham)
        {
            var lstNho = new List<QMSNho>();
            if (dtNho.Rows.Count > 0)
            {
                var qmsNho = new QMSNho();

                var drsNhoTheoPhong = (from row in dtNho.AsEnumerable()
                                       where Utility.sDbnull(row["Ma_Phong"]) == phongKham
                                       select row);
                if (drsNhoTheoPhong.Any())
                {
                    var dtNhoTheoPhong = drsNhoTheoPhong.CopyToDataTable();

                    var objDanhSachNho = new List<QMSBenhNhanNho>();
                    var count = dtNho.Rows.Count <= 4 ? dtNho.Rows.Count : 4;
                    for (int i = 0; i < count; i++)
                    {
                        var row = dtNhoTheoPhong.Rows[i];
                        var qmsBenhNhanNho = new QMSBenhNhanNho();
                        qmsBenhNhanNho.So_Kham = Utility.sDbnull(row["So_Kham"]);
                        qmsBenhNhanNho.ten_bn = Utility.sDbnull(row["ten_bn"]);
                        qmsBenhNhanNho.nam_sinh = Utility.sDbnull(row["nam_sinh"]);
                        qmsBenhNhanNho.Is_UuTien = Utility.sDbnull(row["uu_tien"]);
                        objDanhSachNho.Add(qmsBenhNhanNho);
                    }
                    qmsNho.DanhSachNho = objDanhSachNho;
                    lstNho.Add(qmsNho);
                }
            }
            return lstNho;
        }

        private List<QMSChoTiepDon> GetQMSListChoKham1(DataTable dtChoKham, string phongKham)
        {
            var lstChoTiepDon = new List<QMSChoTiepDon>();
            if (dtChoKham.Rows.Count > 0)
            {
                var qmsChoTiepDon = new QMSChoTiepDon();

                var drsChoKhamTheoPhong = (from row in dtChoKham.AsEnumerable()
                                           where Utility.sDbnull(row["Ma_Phong"]) == phongKham
                                           select row);
                if (drsChoKhamTheoPhong.Any())
                {
                    var dtChoKhamTheoPhong = drsChoKhamTheoPhong.CopyToDataTable();

                    var objDanhSachChoTiepDon = new List<QMSBenhNhanChoTiepDon>();
                    var count = dtChoKhamTheoPhong.Rows.Count <= 4 ? dtChoKhamTheoPhong.Rows.Count : 4;
                    for (int i = 0; i < count; i++)
                    {
                        var row = dtChoKhamTheoPhong.Rows[i];
                        var qmsBenhNhanDangTiepDon = new QMSBenhNhanChoTiepDon();
                        qmsBenhNhanDangTiepDon.So_Kham = Utility.sDbnull(row["So_Kham"]);
                        qmsBenhNhanDangTiepDon.ten_bn = Utility.sDbnull(row["ten_bn"]);
                        qmsBenhNhanDangTiepDon.nam_sinh = Utility.sDbnull(row["nam_sinh"]);
                        qmsBenhNhanDangTiepDon.dia_chi = Utility.sDbnull(row["dia_chi"]);
                        qmsBenhNhanDangTiepDon.Is_UuTien = Utility.sDbnull(row["uu_tien"]);
                        objDanhSachChoTiepDon.Add(qmsBenhNhanDangTiepDon);
                    }
                    qmsChoTiepDon.DanhSachChoTiepDon = objDanhSachChoTiepDon;
                    lstChoTiepDon.Add(qmsChoTiepDon);
                }
            }
            return lstChoTiepDon;
        }

        private List<QMSDangTiepDon> GetQMSListDangKham1(DataTable dtDangKham, string phongKham)
        {
            var lstDangTiepDon = new List<QMSDangTiepDon>();
            if (dtDangKham.Rows.Count > 0)
            {
                var qmsDangTiepDon = new QMSDangTiepDon();

                var drsDangKhamTheoPhong = (from row in dtDangKham.AsEnumerable()
                                            where Utility.sDbnull(row["Ma_Phong"]) == phongKham
                                            select row);
                if (drsDangKhamTheoPhong.Any())
                {
                    var dtDangKhamTheoPhong = drsDangKhamTheoPhong.CopyToDataTable();
                    // Danh sách đang khám chỉ lấy 1 BN đầu tiên
                    var rowDangKham = dtDangKhamTheoPhong.Rows[0];
                    QMSBenhNhanDangTiepDon qmsBenhNhanDangTiepDon = new QMSBenhNhanDangTiepDon();
                    qmsBenhNhanDangTiepDon.So_Kham = Utility.sDbnull(rowDangKham["So_Kham"]);
                    qmsBenhNhanDangTiepDon.ten_bn = Utility.sDbnull(rowDangKham["ten_bn"]);
                    qmsBenhNhanDangTiepDon.nam_sinh = Utility.sDbnull(rowDangKham["nam_sinh"]);
                    qmsBenhNhanDangTiepDon.dia_chi = Utility.sDbnull(rowDangKham["dia_chi"]);
                    qmsBenhNhanDangTiepDon.Is_UuTien = Utility.sDbnull(rowDangKham["uu_tien"]);

                    qmsDangTiepDon.BenhNhanDangTiepDon = qmsBenhNhanDangTiepDon;
                    lstDangTiepDon.Add(qmsDangTiepDon);
                }
            }
            return lstDangTiepDon;
        }

        //[HttpPost("/api/QMS/SinhSoKhamMoi")]
        //public IActionResult SinhSoKhamMoi([FromBody] TaoSoQMSPhongKhamRequest request)
        //{
        //    try
        //    {
        //        if (request.Department_ID == 0)
        //        {
        //            return BadRequest(new APIResponse(false, "Phòng khám không hợp lệ (Department_ID = 0)", null));
        //        }

        //        // Kiểm tra trùng lặp PatientId và PatientCode trong cùng ngày
        //        var existingRecord = _dbcontext.QmsChoKham
        //            .Where(x => x.PatientId == request.Patient_ID
        //                       && x.PatientCode == request.Patient_Code
        //                       && x.RegDate == request.Reg_Date.Date)
        //            .FirstOrDefault();

        //        if (existingRecord != null)
        //        {
        //            return BadRequest(new APIResponse(false, "PatientId và PatientCode đã tồn tại cho ngày này.", null));
        //        }

        //        // Lấy số khám lớn nhất dựa trên MA_PHONG_STT, MaCoSo, RegDate, và uu_tien
        //        var lastSoKhamRecord = _dbcontext.QmsChoKham
        //            .Where(x => x.MaPhongStt == request.MA_PHONG_STT
        //                       && x.MaCoSo == request.Ma_CoSo
        //                       && x.RegDate == request.Reg_Date.Date
        //                       && x.UuTien == request.uu_tien) // Lọc theo uu_tien
        //            .OrderByDescending(x => x.SoKham)
        //            .FirstOrDefault();

        //        short soKhamMoi = 1;
        //        if (lastSoKhamRecord != null)
        //        {
        //            soKhamMoi = (short)(lastSoKhamRecord.SoKham + 1);
        //        }

        //        // Lấy Reg_ID và Exam_ID lớn nhất hiện tại
        //        var lastRegId = _dbcontext.QmsChoKham
        //            .OrderByDescending(x => x.RegId)
        //            .Select(x => x.RegId)
        //            .FirstOrDefault();
        //        int regIdMoi = lastRegId + 1;

        //        var lastExamId = _dbcontext.QmsChoKham
        //            .OrderByDescending(x => x.ExamId)
        //            .Select(x => x.ExamId)
        //            .FirstOrDefault();
        //        int examIdMoi = lastExamId + 1;

        //        var newRecord = new VietBaIT.WebGolf.DBModelsQMS.QmsChoKham
        //        {
        //            RegId = regIdMoi,
        //            PatientId = request.Patient_ID,
        //            PatientCode = request.Patient_Code,
        //            PatientName = request.PatientName,
        //            YearOfBirth = request.YearOfBirth,
        //            PatientSex = request.PatientSex,
        //            RegDate = request.Reg_Date.Date,
        //            InputDate = DateTime.Now,
        //            DepartmentId = request.Department_ID,
        //            DoctorAssignId = request.DoctorAssign_ID,
        //            Status = request.Status,
        //            SoKham = soKhamMoi,
        //            UuTien = request.uu_tien,
        //            MaKhoaThien = request.MA_KHOA_THIEN,
        //            MaPhongStt = request.MA_PHONG_STT,
        //            MaCoSo = request.Ma_CoSo,
        //            ExamId = examIdMoi,
        //            HienThi = request.Hien_Thi ?? 1,
        //            QmsHienThi = request.QMS_HienThi
        //        };

        //        _dbcontext.QmsChoKham.Add(newRecord);
        //        _dbcontext.SaveChanges();

        //        return Ok(new APIResponse(true, "Sinh và lưu số khám mới thành công", newRecord));
        //    }
        //    catch (Exception ex)
        //    {
        //        var message = ex.InnerException?.Message ?? ex.Message;
        //        return BadRequest(new APIResponse(false, message, null));
        //    }
        //}

        [HttpGet("/api/GetListService")]
        public IActionResult Danhsachdichvu(string loai, string tendichvu, int pageNumber = 1, int pageSize = 10)
        {
            try
            {
                var ds = SPHelper.ExecuteStoredProcedure(
                    globalValue.ConnectionString,
                    "GetListService", loai, tendichvu
                );

                var list = ds.Tables[0].AsEnumerable()
                    .Select(row => row.ItemArray.Select((val, idx) => new { idx, val })
                        .ToDictionary(x => ds.Tables[0].Columns[x.idx].ColumnName, x => x.val))
                    .ToList();

                var totalCount = list.Count;
                var pagedList = list
                    .Skip((pageNumber - 1) * pageSize)
                    .Take(pageSize)
                    .ToList(); // materialize để tránh deferred execution

                return Ok(new
                {
                    success = true,
                    message = string.Empty,
                    data = new
                    {
                        data = pagedList,
                        pagination = new
                        {
                            pageNumber,
                            pageSize,
                            totalCount,
                            totalPages = (int)Math.Ceiling((double)totalCount / pageSize)
                        }
                    }
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    success = false,
                    message = e.Message
                });
            }
        }


        [HttpGet("/api/GetListServiceType")]
        public IActionResult Danhsachloaidichvu()
        {

            try
            {
                var ds = SPHelper.ExecuteStoredProcedure(
                    globalValue.ConnectionString,
                    "GetListServiceType"
                    );

                return Ok(new
                {
                    success = true,
                    message = string.Empty,
                    data = ds
                });
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    message = e.Message
                });
            }
        }

        //[HttpPost("/api/QMS/TaoSoKhamTheoQuay")]
        //public IActionResult TaoSoKhamTheoQuay([FromBody] TaoSoKhamTheoQuayRequest request)
        //{
        //    try
        //    {
        //        DateTime today = DateTime.Today;
        //        short soKhamMoi = 1;
        //        string quayMacDinh;

        //        if ((request.Is_UuTien ?? 0) == 1)
        //        {
        //            // Nếu ưu tiên thì quầy = QUAY_1
        //            quayMacDinh = "QUAY_1";

        //            var lastUuTien = _dbcontext.QmsSoKham
        //                .Where(x => x.NgayTao.HasValue &&
        //                            x.NgayTao.Value.Date == today &&
        //                            x.IsUuTien == 1)
        //                .OrderByDescending(x => x.SoKham)
        //                .FirstOrDefault();

        //            soKhamMoi = (short)((lastUuTien?.SoKham ?? 0) + 1);
        //        }
        //        else
        //        {
        //            // Nếu thường thì quầy = QUAY_2
        //            quayMacDinh = "QUAY_2";

        //            var lastThuong = _dbcontext.QmsSoKham
        //                .Where(x => x.NgayTao.HasValue &&
        //                            x.NgayTao.Value.Date == today &&
        //                            x.IsUuTien == 0 &&
        //                            x.MaQuay.ToUpper() == quayMacDinh)
        //                .OrderByDescending(x => x.SoKham)
        //                .FirstOrDefault();

        //            soKhamMoi = (short)((lastThuong?.SoKham ?? 0) + 1);
        //        }

        //        var newRecord = new VietBaIT.WebGolf.DBModelsQMS.QmsSoKham
        //        {
        //            SoKham = soKhamMoi,
        //            LoaiQms = (request.Is_UuTien ?? 0) == 1 ? "UUTIEN" : "SOTHUONG",
        //            NgayTao = DateTime.Now,
        //            MayTao = request.May_Tao,
        //            MaQuay = quayMacDinh, // QUAY_1 hoặc QUAY_2
        //            IpMayTao = request.Ip_May_Tao,
        //            PatientCode = request.Patient_Code,
        //            PatientId = request.Patient_ID ?? -1,
        //            IsUuTien = request.Is_UuTien ?? 0,
        //            Status = 0,
        //            IsDaXoa = 0,
        //            SoPhong = request.So_Phong ?? -1,
        //            DepartmentId = request.Department_ID ?? 0,
        //            MaCoSo = request.Ma_CoSo,
        //            MaBenhVien = request.Ma_BenhVien,
        //            MaTram = request.Ma_Tram,
        //            MaDoituongKcb = request.Ma_DoiTuongKcb
        //        };

        //        _dbcontext.QmsSoKham.Add(newRecord);
        //        _dbcontext.SaveChanges();

        //        return Ok(new APIResponse(true, "Tạo số khám thành công", newRecord));
        //    }
        //    catch (Exception ex)
        //    {
        //        return BadRequest(new APIResponse(false, ex.InnerException?.Message ?? ex.Message, null));
        //    }
        //}

        [HttpPost("/api/QMS/TaoSoKhamTheoQuay")]
        public IActionResult TaoSoKhamTheoQuay([FromBody] TaoSoKhamTheoQuayRequest request)
        {
            try
            {
                DateTime today = DateTime.Today;
                short soKhamMoi = 1;
                string loaiQms;

                if ((request.Is_UuTien ?? 0) == 1)
                {
                    // Ưu tiên
                    loaiQms = "UUTIEN";
                    var lastUuTien = _dbcontext.QmsSoKham
                        .Where(x => x.NgayTao.HasValue &&
                                    x.NgayTao.Value.Date == today &&
                                    (x.LoaiQms == "UUTIEN" || x.IsUuTien == 1))
                        .OrderByDescending(x => x.SoKham)
                        .FirstOrDefault();
                    soKhamMoi = (short)((lastUuTien?.SoKham ?? 0) + 1);
                }
                else
                {
                    // Thường
                    loaiQms = "SOTHUONG";
                    var lastThuong = _dbcontext.QmsSoKham
                        .Where(x => x.NgayTao.HasValue &&
                                    x.NgayTao.Value.Date == today &&
                                    (x.LoaiQms == "SOTHUONG" || (x.IsUuTien == 0 && x.LoaiQms != "UUTIEN")))
                        .OrderByDescending(x => x.SoKham)
                        .FirstOrDefault();
                    soKhamMoi = (short)((lastThuong?.SoKham ?? 0) + 1);
                }

                var newRecord = new VietBaIT.WebGolf.DBModelsQMS.QmsSoKham
                {
                    SoKham = soKhamMoi,
                    LoaiQms = loaiQms,  // UUTIEN hoặc SOTHUONG
                    NgayTao = DateTime.Now,
                    MayTao = request.May_Tao,
                    MaQuay = " ", // Lấy từ request hoặc default
                    IpMayTao = request.Ip_May_Tao,
                    PatientCode = request.Patient_Code,
                    PatientId = request.Patient_ID ?? -1,
                    IsUuTien = request.Is_UuTien ?? 0,
                    Status = 0,
                    IsDaXoa = 0,
                    SoPhong = request.So_Phong ?? -1,
                    DepartmentId = request.Department_ID ?? 0,
                    MaCoSo = request.Ma_CoSo,
                    MaBenhVien = request.Ma_BenhVien,
                    MaTram = request.Ma_Tram,
                    MaDoituongKcb = request.Ma_DoiTuongKcb
                };

                _dbcontext.QmsSoKham.Add(newRecord);
                _dbcontext.SaveChanges();

                return Ok(new APIResponse(true, "Tạo số khám thành công", newRecord));
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse(false, ex.InnerException?.Message ?? ex.Message, null));
            }
        }

        [HttpGet("/api/QMS/MaxSoKhamTrongNgay")]
        public IActionResult MaxSoKhamTrongNgay([FromQuery] byte? isUuTien = 0, [FromQuery] string loaiQms = null,
                                        [FromQuery] string maQuay = null,
                                        [FromQuery] string maCoSo = null,
                                        [FromQuery] short? departmentId = null)
        {
            try
            {
                var today = DateTime.Today;
                var tomorrow = today.AddDays(1);

                // Base filter: trong ngày hôm nay
                var query = _dbcontext.QmsSoKham
                    .Where(x => x.NgayTao.HasValue &&
                                x.NgayTao.Value >= today &&
                                x.NgayTao.Value < tomorrow);

                // Optional filter phụ (nếu muốn bó theo quầy/cơ sở/khoa)
                if (!string.IsNullOrWhiteSpace(maQuay))
                    query = query.Where(x => x.MaQuay == maQuay);

                if (!string.IsNullOrWhiteSpace(maCoSo))
                    query = query.Where(x => x.MaCoSo == maCoSo);

                if (departmentId.HasValue && departmentId.Value > 0)
                    query = query.Where(x => x.DepartmentId == departmentId.Value);

                // Xác định loại lọc: ưu tiên hay thường
                string loai;
                if (!string.IsNullOrWhiteSpace(loaiQms))
                {
                    loai = loaiQms.Trim().ToUpperInvariant();
                }
                else
                {
                    loai = (isUuTien ?? 0) == 1 ? "UUTIEN" : "SOTHUONG";
                }

                if (loai == "UUTIEN")
                {
                    query = query.Where(x => x.LoaiQms == "UUTIEN" || x.IsUuTien == 1);
                }
                else // SOTHUONG
                {
                    query = query.Where(x => x.LoaiQms == "SOTHUONG" || (x.IsUuTien == 0 && x.LoaiQms != "UUTIEN"));
                }

                // Lấy số lớn nhất (nếu không có trả 0)
                int maxSo = query.Select(x => (int?)x.SoKham).Max() ?? 0;

                return Ok(new APIResponse(true, "OK", new
                {
                    Ngay = today.ToString("yyyy-MM-dd"),
                    Loai = loai,
                    MaQuay = maQuay,
                    MaCoSo = maCoSo,
                    DepartmentId = departmentId,
                    Max = maxSo
                }));
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse(false, ex.InnerException?.Message ?? ex.Message, null));
            }
        }





        //[HttpGet("/api/QMS/QMSDanhSachChoTiepDon")]
        //public async Task<ActionResult<string>> QMSDanhSachChoTiepDon(string maPhong, int numberRow = 3)
        //{
        //    Utility.Log = LogManager.GetLogger("QMSDanhSachChoTiepDon");
        //    ResultResponse responseData = new ResultResponse();

        //    try
        //    {
        //        var lstQMSModels = new List<QMSModels>();
        //        DataSet ds = SPHelper.ExecuteStoredProcedure(globalValue.QMSConnectionString, "QMS_DanhSachChoTiepDon", maPhong, 5);
        //        var dt = ds.Tables[0];
        //        var rowDangKham = dt.Select("Status = 1");
        //        var dtDangKham = rowDangKham.Any() ? rowDangKham.CopyToDataTable() : new DataTable();

        //        var rowChoKham = dt.Select("Status = 0");
        //        var dtChoKham = rowChoKham.Any() ? rowChoKham.CopyToDataTable() : new DataTable();

        //        var rowNho = dt.Select("Status = 2");
        //        var dtNho = rowNho.Any() ? rowNho.CopyToDataTable() : new DataTable();

        //        //var lstPhongKham = (from row in dt.AsEnumerable()
        //        //                    select Utility.sDbnull(row["MA_PHONG_STT"])).Distinct().ToList();
        //        var lstPhongKham = maPhong.Split(',');
        //        foreach (string phongKham in lstPhongKham)
        //        {
        //            var qmsModels = new QMSModels();
        //            qmsModels.PhongKham = phongKham.Trim();
        //            qmsModels.QMSDangKham = GetQMSListDangTiepDon(dtDangKham, phongKham);
        //            qmsModels.QMSChoKham = GetQMSListChoTiepDon(dtChoKham, phongKham);
        //            qmsModels.QMSNho = GetQMSListNhoTiepDon(dtNho, phongKham);
        //            lstQMSModels.Add(qmsModels);
        //        }
        //        responseData.IsSuccess = true;
        //        responseData.Messge = "Thành công";

        //        //responseData.data = JsonConvert.SerializeObject(qmsModels, Formatting.Indented);
        //        responseData.data = lstQMSModels;
        //    }
        //    catch (Exception exception)
        //    {
        //        Utility.Log.Error("Exception: " + exception.ToString());

        //        responseData.IsSuccess = false;
        //        responseData.Messge = exception.Message;

        //        // Optional: Trả cả stack trace để debug nếu bạn không chạy ở môi trường production
        //        responseData.data = new
        //        {
        //            StackTrace = exception.StackTrace,
        //            InnerException = exception.InnerException?.ToString(),
        //            Parameters = new
        //            {
        //                maPhong,
        //                numberRow
        //            }
        //        };
        //    }

        //    return new JsonResult(responseData);
        //}

        //private List<QMSNho> GetQMSListNhoTiepDon(DataTable dtNho, string phongKham)
        //{
        //    var lstNho = new List<QMSNho>();
        //    if (dtNho.Rows.Count > 0)
        //    {
        //        var qmsNho = new QMSNho();

        //        var drsNhoTheoPhong = (from row in dtNho.AsEnumerable()
        //                               where Utility.sDbnull(row["Ma_Phong"]) == phongKham
        //                               select row);
        //        if (drsNhoTheoPhong.Any())
        //        {
        //            var dtNhoTheoPhong = drsNhoTheoPhong.CopyToDataTable();

        //            var objDanhSachNho = new List<QMSBenhNhanNho>();
        //            var count = dtNhoTheoPhong.Rows.Count <= 4 ? dtNhoTheoPhong.Rows.Count : 4;
        //            for (int i = 0; i < count; i++)
        //            {
        //                var row = dtNhoTheoPhong.Rows[i];
        //                var qmsBenhNhanNho = new QMSBenhNhanNho();
        //                qmsBenhNhanNho.So_Kham = Utility.sDbnull(row["So_Kham"]);
        //                objDanhSachNho.Add(qmsBenhNhanNho);
        //            }
        //            qmsNho.DanhSachNho = objDanhSachNho;
        //            lstNho.Add(qmsNho);
        //        }
        //    }
        //    return lstNho;
        //}

        //private List<QMSChoTiepDon> GetQMSListChoTiepDon(DataTable dtChoKham, string phongKham)
        //{
        //    var lstChoTiepDon = new List<QMSChoTiepDon>();
        //    if (dtChoKham.Rows.Count > 0)
        //    {
        //        var qmsChoTiepDon = new QMSChoTiepDon();

        //        var drsChoKhamTheoPhong = (from row in dtChoKham.AsEnumerable()
        //                                   where Utility.sDbnull(row["Ma_Phong"]) == phongKham
        //                                   select row);
        //        if (drsChoKhamTheoPhong.Any())
        //        {
        //            var dtChoKhamTheoPhong = drsChoKhamTheoPhong.CopyToDataTable();

        //            var objDanhSachChoTiepDon = new List<QMSBenhNhanChoTiepDon>();
        //            var count = dtChoKhamTheoPhong.Rows.Count <= 4 ? dtChoKhamTheoPhong.Rows.Count : 4;
        //            for (int i = 0; i < count; i++)
        //            {
        //                var row = dtChoKhamTheoPhong.Rows[i];
        //                var qmsBenhNhanDangTiepDon = new QMSBenhNhanChoTiepDon();
        //                qmsBenhNhanDangTiepDon.So_Kham = Utility.sDbnull(row["So_Kham"]);
        //                objDanhSachChoTiepDon.Add(qmsBenhNhanDangTiepDon);
        //            }
        //            qmsChoTiepDon.DanhSachChoTiepDon = objDanhSachChoTiepDon;
        //            lstChoTiepDon.Add(qmsChoTiepDon);
        //        }
        //    }
        //    return lstChoTiepDon;
        //}

        //private List<QMSDangTiepDon> GetQMSListDangTiepDon(DataTable dtDangKham, string phongKham)
        //{
        //    var lstDangTiepDon = new List<QMSDangTiepDon>();
        //    if (dtDangKham.Rows.Count > 0)
        //    {
        //        var qmsDangTiepDon = new QMSDangTiepDon();

        //        var drsDangKhamTheoPhong = (from row in dtDangKham.AsEnumerable()
        //                                    where Utility.sDbnull(row["Ma_Phong"]) == phongKham
        //                                    select row);
        //        if (drsDangKhamTheoPhong.Any())
        //        {
        //            var dtDangKhamTheoPhong = drsDangKhamTheoPhong.CopyToDataTable();
        //            // Danh sách đang khám chỉ lấy 1 BN đầu tiên
        //            var rowDangKham = dtDangKhamTheoPhong.Rows[0];
        //            QMSBenhNhanDangTiepDon qmsBenhNhanDangTiepDon = new QMSBenhNhanDangTiepDon();
        //            qmsBenhNhanDangTiepDon.So_Kham = Utility.sDbnull(rowDangKham["So_Kham"]);
        //            qmsDangTiepDon.BenhNhanDangTiepDon = qmsBenhNhanDangTiepDon;
        //            lstDangTiepDon.Add(qmsDangTiepDon);
        //        }
        //    }
        //    return lstDangTiepDon;
        //}

        //[HttpGet("/api/QMS/QMSDanhSachChoTiepDon")]
        //public async Task<ActionResult<string>> QMSDanhSachChoTiepDon(string loaiQMS = "UUTIEN,SOTHUONG", int numberRow = 20)
        //{
        //    Utility.Log = LogManager.GetLogger("QMSDanhSachChoTiepDon");
        //    ResultResponse responseData = new ResultResponse();
        //    try
        //    {
        //        var lstQMSModels = new List<QMSModels>();

        //        // Gọi SP với parameter mới
        //        DataSet ds = SPHelper.ExecuteStoredProcedure(
        //            globalValue.QMSConnectionString,
        //            "QMS_DanhSachChoTiepDon",
        //            loaiQMS,  // Đổi từ maPhong thành loaiQMS
        //            numberRow
        //        );

        //        var dt = ds.Tables[0];

        //        // Phân loại theo Status (không cần theo Ma_Phong nữa)
        //        var rowDangKham = dt.Select("Status = 1");
        //        var dtDangKham = rowDangKham.Any() ? rowDangKham.CopyToDataTable() : new DataTable();

        //        var rowChoKham = dt.Select("Status = 0");
        //        var dtChoKham = rowChoKham.Any() ? rowChoKham.CopyToDataTable() : new DataTable();

        //        var rowNho = dt.Select("Status = 2");
        //        var dtNho = rowNho.Any() ? rowNho.CopyToDataTable() : new DataTable();

        //        // Tạo danh sách theo loại QMS thay vì theo phòng
        //        var lstLoaiQMS = loaiQMS.Split(',').Select(p => p.Trim()).Distinct().ToList();

        //        foreach (string loai in lstLoaiQMS)
        //        {
        //            var qmsModels = new QMSModels();
        //            qmsModels.PhongKham = loai; // Đổi thành loại QMS
        //            qmsModels.QMSDangKham = GetQMSListDangTiepDon(dtDangKham, loai);
        //            qmsModels.QMSChoKham = GetQMSListChoTiepDon(dtChoKham, loai);
        //            qmsModels.QMSNho = GetQMSListNhoTiepDon(dtNho, loai);
        //            lstQMSModels.Add(qmsModels);
        //        }

        //        responseData.IsSuccess = true;
        //        responseData.Messge = "Thành công";
        //        responseData.data = lstQMSModels;
        //    }
        //    catch (Exception exception)
        //    {
        //        Utility.Log.Error("Exception: " + exception.ToString());
        //        responseData.IsSuccess = false;
        //        responseData.Messge = exception.Message;
        //        responseData.data = new
        //        {
        //            StackTrace = exception.StackTrace,
        //            InnerException = exception.InnerException?.ToString(),
        //            Parameters = new { loaiQMS, numberRow }
        //        };
        //    }
        //    return new JsonResult(responseData);
        //}

        //// Sửa các method helper
        //private List<QMSDangTiepDon> GetQMSListDangTiepDon(DataTable dtDangKham, string loaiQMS)
        //{
        //    var lstDangTiepDon = new List<QMSDangTiepDon>();
        //    if (dtDangKham.Rows.Count > 0)
        //    {
        //        var qmsDangTiepDon = new QMSDangTiepDon();

        //        // Lọc theo Loai_Chinh thay vì Ma_Phong
        //        var drsDangKhamTheoLoai = dtDangKham.AsEnumerable()
        //            .Where(row => Utility.sDbnull(row["Loai_Chinh"]) == loaiQMS);

        //        if (drsDangKhamTheoLoai.Any())
        //        {
        //            var dtDangKhamTheoLoai = drsDangKhamTheoLoai.CopyToDataTable();
        //            if (dtDangKhamTheoLoai.Rows.Count > 0)
        //            {
        //                var rowDangKham = dtDangKhamTheoLoai.Rows[0];
        //                var qmsBenhNhanDangTiepDon = new QMSBenhNhanDangTiepDon();
        //                qmsBenhNhanDangTiepDon.So_Kham = Utility.sDbnull(rowDangKham["So_Kham"]);
        //                qmsDangTiepDon.BenhNhanDangTiepDon = qmsBenhNhanDangTiepDon;
        //                lstDangTiepDon.Add(qmsDangTiepDon);
        //            }
        //        }
        //    }
        //    return lstDangTiepDon;
        //}

        //private List<QMSChoTiepDon> GetQMSListChoTiepDon(DataTable dtChoKham, string loaiQMS)
        //{
        //    var lstChoTiepDon = new List<QMSChoTiepDon>();
        //    if (dtChoKham.Rows.Count > 0)
        //    {
        //        var qmsChoTiepDon = new QMSChoTiepDon();

        //        // Lọc theo Loai_Chinh thay vì Ma_Phong
        //        var drsChoKhamTheoLoai = dtChoKham.AsEnumerable()
        //            .Where(row => Utility.sDbnull(row["Loai_Chinh"]) == loaiQMS);

        //        if (drsChoKhamTheoLoai.Any())
        //        {
        //            var dtChoKhamTheoLoai = drsChoKhamTheoLoai.CopyToDataTable();
        //            var objDanhSachChoTiepDon = new List<QMSBenhNhanChoTiepDon>();
        //            var uniqueSoKham = new HashSet<string>();
        //            var count = dtChoKhamTheoLoai.Rows.Count <= 4 ? dtChoKhamTheoLoai.Rows.Count : 4;

        //            for (int i = 0; i < count; i++)
        //            {
        //                var row = dtChoKhamTheoLoai.Rows[i];
        //                var soKham = Utility.sDbnull(row["So_Kham"]);
        //                if (!uniqueSoKham.Contains(soKham))
        //                {
        //                    var qmsBenhNhanChoTiepDon = new QMSBenhNhanChoTiepDon();
        //                    qmsBenhNhanChoTiepDon.So_Kham = soKham;
        //                    objDanhSachChoTiepDon.Add(qmsBenhNhanChoTiepDon);
        //                    uniqueSoKham.Add(soKham);
        //                }
        //            }
        //            qmsChoTiepDon.DanhSachChoTiepDon = objDanhSachChoTiepDon;
        //            lstChoTiepDon.Add(qmsChoTiepDon);
        //        }
        //    }
        //    return lstChoTiepDon;
        //}

        //private List<QMSNho> GetQMSListNhoTiepDon(DataTable dtNho, string loaiQMS)
        //{
        //    var lstNho = new List<QMSNho>();
        //    if (dtNho.Rows.Count > 0)
        //    {
        //        var qmsNho = new QMSNho();

        //        // Lọc theo Loai_Chinh thay vì Ma_Phong
        //        var drsNhoTheoLoai = dtNho.AsEnumerable()
        //            .Where(row => Utility.sDbnull(row["Loai_Chinh"]) == loaiQMS);

        //        if (drsNhoTheoLoai.Any())
        //        {
        //            var dtNhoTheoLoai = drsNhoTheoLoai.CopyToDataTable();
        //            var objDanhSachNho = new List<QMSBenhNhanNho>();
        //            var uniqueSoKham = new HashSet<string>();
        //            var count = dtNhoTheoLoai.Rows.Count <= 4 ? dtNhoTheoLoai.Rows.Count : 4;

        //            for (int i = 0; i < count; i++)
        //            {
        //                var row = dtNhoTheoLoai.Rows[i];
        //                var soKham = Utility.sDbnull(row["So_Kham"]);
        //                if (!uniqueSoKham.Contains(soKham))
        //                {
        //                    var qmsBenhNhanNho = new QMSBenhNhanNho();
        //                    qmsBenhNhanNho.So_Kham = soKham;
        //                    objDanhSachNho.Add(qmsBenhNhanNho);
        //                    uniqueSoKham.Add(soKham);
        //                }
        //            }
        //            qmsNho.DanhSachNho = objDanhSachNho;
        //            lstNho.Add(qmsNho);
        //        }
        //    }
        //    return lstNho;
        //}

        private List<QMSDangTiepDon> GetQMSListDangTiepDon(DataTable dtDangKham, string loaiQMS)
        {
            var result = new List<QMSDangTiepDon>();
            if (dtDangKham == null || dtDangKham.Rows.Count == 0) return result;
            if (string.IsNullOrWhiteSpace(loaiQMS)) return result;

            var row = dtDangKham.AsEnumerable()
                .Where(r => string.Equals(
                                Utility.sDbnull(r["Loai_Chinh"]).Trim(),
                                loaiQMS.Trim(),
                                StringComparison.OrdinalIgnoreCase))
                .Select(r => new
                {
                    Row = r,
                    SoKhamNum = int.TryParse(Utility.sDbnull(r["So_Kham"]), out var n) ? n : int.MaxValue,
                    IdNum = int.TryParse(Utility.sDbnull(r["Id"]), out var id) ? id : int.MaxValue
                })
                .OrderBy(x => x.SoKhamNum)
                .ThenBy(x => x.IdNum)
                .Select(x => x.Row)
                .FirstOrDefault();

            if (row == null) return result;

            result.Add(new QMSDangTiepDon
            {
                BenhNhanDangTiepDon = new QMSBenhNhanDangTiepDon
                {
                    So_Kham = Utility.sDbnull(row["So_Kham"])
                }
            });

            return result;
        }

        private List<QMSChoTiepDon> GetQMSListChoTiepDon(DataTable dtChoKham, string loaiQMS, int take)
        {
            var lstCho = new List<QMSChoTiepDon>();
            if (dtChoKham == null || dtChoKham.Rows.Count == 0) return lstCho;
            if (string.IsNullOrWhiteSpace(loaiQMS)) return lstCho;
            if (take <= 0) take = 1;

            var rows = dtChoKham.AsEnumerable()
                .Where(r => string.Equals(
                                Utility.sDbnull(r["Loai_Chinh"]).Trim(),
                                loaiQMS.Trim(),
                                StringComparison.OrdinalIgnoreCase))
                .Select(r => new
                {
                    Row = r,
                    SoKhamNum = int.TryParse(Utility.sDbnull(r["So_Kham"]), out var n) ? n : int.MaxValue,
                    IdNum = int.TryParse(Utility.sDbnull(r["Id"]), out var id) ? id : int.MaxValue,
                    SoKhamStr = Utility.sDbnull(r["So_Kham"])
                })
                .OrderBy(x => x.SoKhamNum)
                .ThenBy(x => x.IdNum);

            var unique = new HashSet<string>();
            var list = new List<QMSBenhNhanChoTiepDon>();

            foreach (var x in rows)
            {
                if (unique.Add(x.SoKhamStr))
                {
                    list.Add(new QMSBenhNhanChoTiepDon { So_Kham = x.SoKhamStr });
                    if (list.Count >= take) break;
                }
            }

            if (list.Count > 0)
                lstCho.Add(new QMSChoTiepDon { DanhSachChoTiepDon = list });

            return lstCho;
        }

        private List<QMSNho> GetQMSListNhoTiepDon(DataTable dtNho, string loaiQMS)
        {
            var lstNho = new List<QMSNho>();
            if (dtNho.Rows.Count > 0)
            {
                var qmsNho = new QMSNho();

                // Lọc theo Loai_Chinh thay vì Ma_Phong
                var drsNhoTheoLoai = dtNho.AsEnumerable()
                    .Where(row => Utility.sDbnull(row["Loai_Chinh"]) == loaiQMS);

                if (drsNhoTheoLoai.Any())
                {
                    var dtNhoTheoLoai = drsNhoTheoLoai.CopyToDataTable();
                    var objDanhSachNho = new List<QMSBenhNhanNho>();
                    var uniqueSoKham = new HashSet<string>();
                    var count = dtNhoTheoLoai.Rows.Count <= 4 ? dtNhoTheoLoai.Rows.Count : 4;

                    for (int i = 0; i < count; i++)
                    {
                        var row = dtNhoTheoLoai.Rows[i];
                        var soKham = Utility.sDbnull(row["So_Kham"]);
                        if (!uniqueSoKham.Contains(soKham))
                        {
                            var qmsBenhNhanNho = new QMSBenhNhanNho();
                            qmsBenhNhanNho.So_Kham = soKham;
                            objDanhSachNho.Add(qmsBenhNhanNho);
                            uniqueSoKham.Add(soKham);
                        }
                    }
                    qmsNho.DanhSachNho = objDanhSachNho;
                    lstNho.Add(qmsNho);
                }
            }
            return lstNho;
        }

        [HttpGet("/api/QMS/QMSDanhSachChoTiepDon")]
        public async Task<ActionResult<string>> QMSDanhSachChoTiepDon(
    string loaiQMS = "UUTIEN,SOTHUONG", int numberRow = 20)
        {
            Utility.Log = LogManager.GetLogger("QMSDanhSachChoTiepDon");
            var responseData = new ResultResponse();

            try
            {
                var lstQMSModels = new List<QMSModels>();

                // Gọi SP: đảm bảo đúng thứ tự tham số (LoaiQMS_List, SoLuongBanGhi)
                DataSet ds = SPHelper.ExecuteStoredProcedure(
                    globalValue.QMSConnectionString,
                    "QMS_DanhSachChoTiepDon",
                    loaiQMS,
                    numberRow
                );
                var dt = ds.Tables[0];

                // Chia theo Status
                var dtDangKham = dt.Select("Status = 1").Any()
                    ? dt.Select("Status = 1").CopyToDataTable() : new DataTable();
                var dtChoKham = dt.Select("Status = 0").Any()
                    ? dt.Select("Status = 0").CopyToDataTable() : new DataTable();
                var dtNho = dt.Select("Status = 2").Any()
                    ? dt.Select("Status = 2").CopyToDataTable() : new DataTable();

                // Danh sách loại
                var lstLoaiQMS = loaiQMS.Split(',')
                                        .Select(p => p.Trim().ToUpper())
                                        .Where(p => !string.IsNullOrWhiteSpace(p))
                                        .Distinct()
                                        .ToList();

                // Chia đều số lượng cho mỗi loại (tuỳ nhu cầu)
                var numberRowPerLoai = Math.Max(1, numberRow / Math.Max(1, lstLoaiQMS.Count));

                foreach (var loai in lstLoaiQMS)
                {
                    var qmsModels = new QMSModels
                    {
                        PhongKham = loai,
                        QMSDangKham = GetQMSListDangTiepDon(dtDangKham, loai), // 1 đang tiếp đón là hợp lý
                        QMSChoKham = GetQMSListChoTiepDon(dtChoKham, loai, numberRowPerLoai),
                        QMSNho = GetQMSListNhoTiepDon(dtNho, loai)
                    };
                    lstQMSModels.Add(qmsModels);
                }

                responseData.IsSuccess = true;
                responseData.Messge = "Thành công";
                responseData.data = lstQMSModels;
            }
            catch (Exception ex)
            {
                Utility.Log.Error("Exception: " + ex);
                responseData.IsSuccess = false;
                responseData.Messge = ex.Message;
                responseData.data = new { StackTrace = ex.StackTrace, Parameters = new { loaiQMS, numberRow } };
            }

            return new JsonResult(responseData);
        }



        [HttpGet("/api/QMS/KIOSH_DanhSachCLS")]
        public IActionResult LayDanhSachCLS_QMS(string barcode)
        {
            try
            {
                var ds = SPHelper.ExecuteStoredProcedure(
                    globalValue.ConnectionString,
                    "LayDanhSachCLS_QMS", barcode
                );

                // Giả sử ds chứa ít nhất một bảng và bạn lấy bảng đầu tiên
                var dataTable = ds.Tables[0];

                if (dataTable.Rows.Count == 0)
                {
                    return NotFound(new
                    {
                        success = false,
                        message = "Không tìm thấy thông tin."
                    });
                }

                // Lấy thông tin bệnh nhân từ dòng đầu tiên
                var firstEntry = dataTable.Rows[0];

                // Chuyển đổi thông tin bệnh nhân và chỉ định dịch vụ
                var response = new
                {
                    success = true,
                    message = string.Empty,
                    data = new
                    {
                        patient_id = firstEntry["patient_id"].ToString(),
                        ho_ten = firstEntry["ho_ten"].ToString(),
                        ma_lan_kham = firstEntry["ma_lan_kham"].ToString(),
                        so_dien_thoai = firstEntry["so_dien_thoai"].ToString(),
                        as_dia_chi = firstEntry["as_dia_chi"].ToString(),
                        ngay_sinh = firstEntry["ngay_sinh"].ToString(),
                        gioi_tinh = firstEntry["gioi_tinh"].ToString(),
                        cccd = firstEntry["cccd"].ToString(),
                        ngay_chi_dinh = DateTime.Parse(firstEntry["ngay_chi_dinh"].ToString()).ToString("yyyy-MM-ddTHH:mm:ss"),

                        ds_chi_dinh = dataTable.AsEnumerable().Select(item => new
                        {
                            service_ID = item.Field<int>("service_ID"),
                            ten_phong = item.Field<string>("ten_chi_dinh"),
                            id_dich_vu = item.Field<int>("id_dich_vu"),
                            ten_dich_vu = item.Field<string>("ten_dich_vu"),
                            trangthai = item.Field<int>("trangthai")
                            //trangThai = item.Field<int>("trangThai") // Giả sử trangThai có trong bảng
                        }).ToList()
                    }
                };

                return Ok(response);
            }
            catch (Exception e)
            {
                return BadRequest(new
                {
                    message = e.Message
                });
            }
        }

        [HttpPost("/api/QMS/TaoSoKhamPhongCLS")]
        public IActionResult TaoSoKhamPhongCLS([FromBody] TaoSoKhamTheoPhongCLSRequest request)
        {
            try
            {
                if (request.DanhSachPhong == null || !request.DanhSachPhong.Any())
                {
                    return BadRequest(new APIResponse(false, "Danh sách phòng không hợp lệ", null));
                }

                var today = DateTime.Now.Date;
                var createdRecords = new List<QmsCanLamSang>();

                foreach (var phong in request.DanhSachPhong)
                {
                    if (string.IsNullOrEmpty(phong.MaPhong) || phong.ServiceDetailIds == null || !phong.ServiceDetailIds.Any())
                        continue;

                    int soKhamMoi;

                    var existing = _dbcontext.QmsCanLamSang.FirstOrDefault(x =>
                        x.MaPhong == phong.MaPhong &&
                        x.NgayTao.Date == today &&
                        x.MaCoSo == (request.MaCoSo ?? "BV01") &&
                        x.MaChucnang == "CLS" &&
                        x.MaPhieu == request.MaPhieu);

                    if (existing != null)
                    {
                        soKhamMoi = existing.SoKham;
                    }
                    else
                    {
                        var maxSoKham = _dbcontext.QmsCanLamSang
                            .Where(x =>
                                x.MaPhong == phong.MaPhong &&
                                x.NgayTao.Date == today &&
                                x.MaChucnang == "CLS" &&
                                x.MaCoSo == (request.MaCoSo ?? "BV01"))
                            .Max(x => (int?)x.SoKham) ?? 0;

                        soKhamMoi = maxSoKham + 1;
                    }

                    var records = phong.ServiceDetailIds.Select(serviceDetailId => new QmsCanLamSang
                    {
                        MaPhong = phong.MaPhong,
                        SoKham = soKhamMoi,
                        NgayTao = DateTime.Now,
                        MaCoSo = request.MaCoSo ?? "BV01",
                        MaBenhVien = request.MaBenhVien ?? "01831",
                        UuTien = request.UuTien ?? 0,
                        SoPhong = request.SoPhong,
                        MaChucnang = request.MaChucnang,
                        PatientId = request.PatientId,
                        PatientCode = request.PatientCode,
                        TenBenhnhan = request.TenBenhnhan,
                        NamSinh = request.NamSinh,
                        TrangThai = request.TrangThai ?? 0,
                        MaKhoa = request.MaKhoa,
                        MaPhieu = request.MaPhieu,
                        CoKetqua = request.CoKetqua,
                        ServiceDetailId = serviceDetailId
                    }).ToList();

                    _dbcontext.QmsCanLamSang.AddRange(records);
                    createdRecords.AddRange(records);
                }

                _dbcontext.SaveChanges();
                var groupedResults = createdRecords
                    .GroupBy(x => x.MaPhong)
                    .Select(g => new
                    {
                        MaPhong = g.Key,
                        SoKham = g.First().SoKham,
                        Ids = g.Select(x => x.Id).ToList()
                    })
                    .ToList();

                return Ok(new APIResponse(true, "Tạo số khám thành công", groupedResults));
            }
            catch (Exception ex)
            {
                return BadRequest(new APIResponse(false, ex.InnerException?.Message ?? ex.Message, null));
            }
        }


    }



    public class ResultResponse
        {
            public bool IsSuccess { get; set; }
            public string Messge { get; set; }
            public object data { get; set; }
        }

    public class TaoSoQMSPhongKhamRequest
    {
        public int Patient_ID { get; set; }
        public string Patient_Code { get; set; }
        public string PatientName { get; set; }
        public int YearOfBirth { get; set; }
        public int PatientSex { get; set; }
        public DateTime Reg_Date { get; set; }
        public short? Department_ID { get; set; }
        public short? DoctorAssign_ID { get; set; }
        public byte? Status { get; set; }
        public int So_Kham { get; set; }
        public short? uu_tien { get; set; }
        public string MA_KHOA_THIEN { get; set; }
        public string MA_PHONG_STT { get; set; }
        public string Ma_CoSo { get; set; }
        public int Exam_ID { get; set; }
        public byte? Hien_Thi { get; set; }
        public bool QMS_HienThi { get; set; }
    }

    // Model Entity đại diện cho bảng QMSPhongKham trong DB
    public class QMSPhongKham
    {
        public int Reg_ID { get; set; }
        public int Patient_ID { get; set; }
        public string Patient_Code { get; set; }
        public string PatientName { get; set; }
        public int YearOfBirth { get; set; }
        public int PatientSex { get; set; }
        public DateTime Reg_Date { get; set; }
        public DateTime Input_Date { get; set; }
        public int Department_ID { get; set; }
        public int DoctorAssign_ID { get; set; }
        public int Status { get; set; }
        public short? So_Kham { get; set; }
        public int uu_tien { get; set; }
        public string MA_KHOA_THIEN { get; set; }
        public string MA_PHONG_STT { get; set; }
        public string Ma_CoSo { get; set; }
        public int Exam_ID { get; set; }
        public byte Hien_Thi { get; set; }
        public bool QMS_HienThi { get; set; }
    }
}

public class TaoSoQMSPhongKhamRequest
{
    public int Patient_ID { get; set; }
    public string Patient_Code { get; set; }
    public string PatientName { get; set; }
    public int YearOfBirth { get; set; }
    public int PatientSex { get; set; }
    public DateTime Reg_Date { get; set; }
    public short? Department_ID { get; set; }
    public short? DoctorAssign_ID { get; set; }
    public byte? Status { get; set; }
    public int So_Kham { get; set; }
    public byte? uu_tien { get; set; }
    public string MA_KHOA_THIEN { get; set; }
    public string MA_PHONG_STT { get; set; }
    public string Ma_CoSo { get; set; }
    public int Exam_ID { get; set; }
    public byte? Hien_Thi { get; set; }
    public bool QMS_HienThi { get; set; }
}

public class TaoSoKhamTheoQuayRequest
{
    public string May_Tao { get; set; }
    public string Ip_May_Tao { get; set; }
    public string Patient_Code { get; set; }
    public int? Patient_ID { get; set; }
    public byte? Is_UuTien { get; set; }
    public int? So_Phong { get; set; }
    public short? Department_ID { get; set; }
    public string Ma_CoSo { get; set; }
    public string Ma_BenhVien { get; set; }
    public string Ma_Tram { get; set; }
    public string Ma_DoiTuongKcb { get; set; }
}

public class TaoSoKhamTheoPhongCLSRequest
{
    public List<PhongVaDichVuCLSRequest> DanhSachPhong { get; set; }
    public DateTime NgayTao { get; set; }
    public string MaCoSo { get; set; }
    public string MaBenhVien { get; set; }
    public byte? UuTien { get; set; }
    public string SoPhong { get; set; }
    public string MaChucnang { get; set; }
    public long PatientId { get; set; }
    public string PatientCode { get; set; }
    public string TenBenhnhan { get; set; }
    public int NamSinh { get; set; }
    public byte? TrangThai { get; set; }
    public string MaKhoa { get; set; }
    public string MaPhieu { get; set; }
    public byte? CoKetqua { get; set; }
}

public class PhongVaDichVuCLSRequest
{
    public string MaPhong { get; set; }
    public List<int> ServiceDetailIds { get; set; }
}