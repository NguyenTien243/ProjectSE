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
        public DBQLBaiDoXe db = null;
        public BLNhanVien()
        {
            db = new DBQLBaiDoXe();
        }

        public DataSet LayNV()
        {
            return db.ExecuteQueryDataSet("SELECT TaiKhoan.MaNV, TenNV, NgaySinh, GioiTinh, CMND, SDT, DiaChi, TaiKhoan, MatKhau FROM TaiKhoan, NhanVien WHERE TaiKhoan.MaNV = NhanVien.MaNV AND NhanVien.MaCV = 'CV02'", CommandType.Text);
        }
        public bool ThemNV(string MaNV, string TenNV, DateTime NgaySinh, string GioiTinh, string CMND, string sdt, string DiaChi, string TaiKhoan, string MatKhau, ref string err)
        {
            string sqlString = "Insert Into NhanVien Values( @MaNV,@TenNV,@NgaySinh, @GioiTinh, @CMND ,@SDT,@DiaChi, @MaCV); Insert Into TaiKhoan Values( @TaiKhoan, @MatKhau, @MaNV)";
            SqlParameter[] para = {
            new SqlParameter("@MaNV", MaNV),
            new SqlParameter("@TenNV", TenNV),
            new SqlParameter("@GioiTinh", GioiTinh),
            new SqlParameter("@NgaySinh", NgaySinh),
            new SqlParameter("@CMND", CMND),
            new SqlParameter("@SDT", sdt),
            new SqlParameter("@DiaChi", DiaChi),         
            new SqlParameter("@MaCV", "CV02"),
            new SqlParameter("@TaiKhoan", TaiKhoan),
            new SqlParameter("@MatKhau", MatKhau)};

                //string sqlString2 = "Insert Into TaiKhoan Values( @TaiKhoan, @MatKhau, @MaNV)";
                //SqlParameter[] para2 = {
                //new SqlParameter("@TaiKhoan", TaiKhoan),
                //new SqlParameter("@MatKhau", MatKhau),
                //new SqlParameter("@MaNV", MaNV)
                //};

            return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }
        public DataSet KiemTraTrungMaNV(string MaNV)
        {
            return db.ExecuteQueryDataSet("SELECT MaNV FROM NhanVien WHERE MaNV ='"+MaNV+"'", CommandType.Text);
           
        }

        public DataSet KiemTraTrungTaiKhoan(string TaiKhoan)
        {
            return db.ExecuteQueryDataSet("SELECT TaiKhoan FROM TaiKhoan WHERE TaiKhoan ='" + TaiKhoan + "'", CommandType.Text);
        }
        public bool CapNhatNV(string MaNV, string TenNV, DateTime NgaySinh, string GioiTinh, string CMND, string sdt, string DiaChi, string TaiKhoan, string MatKhau, ref string err)
        {
            string sqlString = "Update NhanVien Set TenNV=@TenNV, NgaySinh= @NgaySinh, GioiTinh =  @GioiTinh, CMND = @CMND, SDT = @SDT,DiaChi = @DiaChi WHERE MaNV= @MaNV; Update TaiKhoan Set TaiKhoan = @TaiKhoan, MatKhau = @MatKhau WHERE MaNV= @MaNV";
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
            new SqlParameter("@MatKhau", MatKhau)};
            return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }
    }
}
