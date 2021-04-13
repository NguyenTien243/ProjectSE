using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
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

    }
}
