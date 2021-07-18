using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Quanlybaidoxe.BS_Layer
{
    class BLTaiKhoan
    {
        public DBQLBaiDoXe dbtaikhoan = null;
        public BLTaiKhoan()
        {
            dbtaikhoan = new DBQLBaiDoXe();
        }

        /// <summary>
        /// Lấy tài khoản nhân viên
        /// </summary>
        /// <returns></returns>
        public DataSet GetStaffAccounts()
        {
            return dbtaikhoan.ExecuteQueryDataSet("SELECT TaiKhoan,MatKhau,TaiKhoan.MaNV as MaNV, TenNV, MaCV FROM dbo.TaiKhoan, dbo.NhanVien WHERE TaiKhoan.MaNV = NhanVien.MaNV", CommandType.Text);
        }
        public DataSet GetStaffAccount(string TaiKhoan, string MatKhau)
        {
            return dbtaikhoan.ExecuteQueryDataSet("SELECT TaiKhoan, MatKhau, MaNV FROM TaiKhoan WHERE TaiKhoan ='" + TaiKhoan.Trim() + "' and MatKhau = '"+MatKhau.Trim() +"'", CommandType.Text);
        }
    }
}
