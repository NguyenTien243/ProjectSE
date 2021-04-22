using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Quanlybaidoxe.BS_Layer
{
    class BLNhanVien
    {
        public DBQLBaiDoXe dbNhanVien = null;
        public BLNhanVien()
        {
            dbNhanVien = new DBQLBaiDoXe();
        }
        public DataSet GetPositionStaff(string manv)
        {
            return dbNhanVien.ExecuteQueryDataSet("SELECT TenNV, TenCV FROM NhanVien, ChucVu WHERE NhanVien.MaCV = ChucVu.MaCV", CommandType.Text);
        }
        public DataSet GetStaffs()
        {
            return dbNhanVien.ExecuteQueryDataSet("SELECT TaiKhoan.MaNV, TenNV, NgaySinh, GioiTinh, CMND, SDT, DiaChi, TaiKhoan, MatKhau, Luong FROM TaiKhoan, NhanVien WHERE TaiKhoan.MaNV = NhanVien.MaNV AND NhanVien.MaCV = 'CV02'", CommandType.Text);
        }
        public bool AddStaff(string MaNV, string TenNV, DateTime NgaySinh, string GioiTinh, string CMND, string sdt, string DiaChi, string TaiKhoan, string MatKhau,float Luong, ref string err)
        {
            string sqlString = "Insert Into NhanVien Values( @MaNV,@TenNV,@NgaySinh, @GioiTinh, @CMND ,@SDT,@DiaChi, @MaCV, @Luong); Insert Into TaiKhoan Values( @TaiKhoan, @MatKhau, @MaNV)";
            SqlParameter[] parameters = {
            new SqlParameter("@MaNV", MaNV),
            new SqlParameter("@TenNV", TenNV),
            new SqlParameter("@GioiTinh", GioiTinh),
            new SqlParameter("@NgaySinh", NgaySinh),
            new SqlParameter("@CMND", CMND),
            new SqlParameter("@SDT", sdt),
            new SqlParameter("@DiaChi", DiaChi),         
            new SqlParameter("@MaCV", "CV02"),
            new SqlParameter("@TaiKhoan", TaiKhoan),
             new SqlParameter("@Luong", Luong),
            new SqlParameter("@MatKhau", MatKhau)};

            return dbNhanVien.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);
        }
        
        /// <summary>
        /// Kiểm tra trùng mã nhân viên
        /// </summary>
        /// <param name="MaNV"></param>
        /// <returns></returns>
        public DataSet CheckStaffId(string MaNV) 
        {
            return dbNhanVien.ExecuteQueryDataSet("SELECT MaNV FROM NhanVien WHERE MaNV ='"+MaNV+"'", CommandType.Text);
        }

        /// <summary>
        /// Kiểm tra trùng mã tài khoản
        /// </summary>
        /// <param name="TaiKhoan"></param>
        /// <returns></returns>
        public DataSet CheckAcount(string TaiKhoan)
        {
            return dbNhanVien.ExecuteQueryDataSet("SELECT TaiKhoan FROM TaiKhoan WHERE TaiKhoan ='" + TaiKhoan + "'", CommandType.Text);
        }

        public bool UpdateStaff(string MaNV, string TenNV, DateTime NgaySinh, string GioiTinh, string CMND, string sdt, string DiaChi, string TaiKhoan, string MatKhau,float Luong, ref string err)
        {
            string sqlString = "Update NhanVien Set TenNV=@TenNV, NgaySinh= @NgaySinh, GioiTinh =  @GioiTinh, CMND = @CMND, SDT = @SDT,DiaChi = @DiaChi, Luong = @Luong WHERE MaNV= @MaNV; Update TaiKhoan Set TaiKhoan = @TaiKhoan, MatKhau = @MatKhau WHERE MaNV= @MaNV";
            SqlParameter[] para = {
            new SqlParameter("@MaNV", MaNV),
            new SqlParameter("@TenNV", TenNV),
            new SqlParameter("@NgaySinh", NgaySinh),
            new SqlParameter("@GioiTinh", GioiTinh),
            new SqlParameter("@CMND", CMND),
            new SqlParameter("@SDT", sdt),
            new SqlParameter("@DiaChi", DiaChi),
          //  new SqlParameter("@MaCV", "CV02"),
            new SqlParameter("@TaiKhoan", TaiKhoan),
            new SqlParameter("@Luong", Luong),
            new SqlParameter("@MatKhau", MatKhau)};
            return dbNhanVien.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }

        public bool DeleteStaff(string MaNV, ref string err)
        {
            string sqlString = "Delete From TaiKhoan Where MaNV = @MaNV; Delete From NhanVien Where MaNV = @MaNV";
            SqlParameter[] para = { new SqlParameter("@MaNV", MaNV) };
            return dbNhanVien.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }
    }
}
