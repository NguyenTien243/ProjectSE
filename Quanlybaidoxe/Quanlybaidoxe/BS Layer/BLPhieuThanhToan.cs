using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Quanlybaidoxe.BS_Layer
{
    class BLPhieuThanhToan
    {
        public DBQLBaiDoXe dbPhieuThanhToan = null;
        public BLPhieuThanhToan()
        {
            dbPhieuThanhToan = new DBQLBaiDoXe();
        }
        public DataSet GetReceipts()
        {
            return dbPhieuThanhToan.ExecuteQueryDataSet("SELECT MaPhieu,BienSo,Xe.MaXe,GioVao,GioRa,TienThu,TraTheoThang,MaNV FROM dbo.PhieuThanhToan,dbo.Xe WHERE PhieuThanhToan.MaXe = Xe.MaXe", CommandType.Text);
        }

        public DataSet SearchReceicept(string LoaiTimKiem, string KytuTimKiem)
        {
            string querySearch = StringSearch(LoaiTimKiem, KytuTimKiem);
            return dbPhieuThanhToan.ExecuteQueryDataSet(querySearch, CommandType.Text);
        }
        private string StringSearch(string LoaiTimKiem, string KyTuTimKiem)
        {
            return "SELECT MaPhieu,BienSo,Xe.MaXe,GioVao,GioRa,TienThu,TraTheoThang,MaNV FROM dbo.PhieuThanhToan,dbo.Xe WHERE PhieuThanhToan.MaXe = Xe.MaXe AND " + LoaiTimKiem.Trim() + " LIKE N'%" + KyTuTimKiem.Trim() + "%'";
        }
        public DataSet SearchReceiceptByDate(string LoaiTimKiem, string KytuTimKiem)
        {
            string querySearch = StringSearchByDate(LoaiTimKiem, KytuTimKiem);
            return dbPhieuThanhToan.ExecuteQueryDataSet(querySearch, CommandType.Text);
        }
        private string StringSearchByDate(string LoaiTimKiem, string KyTuTimKiem)
        {
            return "SELECT MaPhieu,BienSo,Xe.MaXe,GioVao,GioRa,TienThu,TraTheoThang,MaNV FROM dbo.PhieuThanhToan,dbo.Xe WHERE PhieuThanhToan.MaXe = Xe.MaXe AND FORMAT("+ LoaiTimKiem.Trim() + ", 'MM/dd/yyyy') LIKE N'%" + KyTuTimKiem.Trim() + "%'";
        }
        public DataSet getVehicleByIDReceipt(string MaPhieu)
        {
            string querySearch = "SELECT BienSo,TenLoaiXe,TenXe,MauSac,GioVao,GioRa,TraTheoThang,TienThu FROM dbo.LoaiXe, dbo.Xe,dbo.PhieuThanhToan WHERE LoaiXe.MaLoaiXe = Xe.MaLoaiXe AND PhieuThanhToan.MaXe = Xe.MaXe AND MaPhieu = " + MaPhieu+"";
            return dbPhieuThanhToan.ExecuteQueryDataSet(querySearch, CommandType.Text);
        }
        public DataSet getStaffByIDReceipt(string MaPhieu)
        {
            string querySearch = "SELECT MaPhieu,PhieuThanhToan.MaNV,TenNV,NgaySinh,GioiTinh,CMND,SDT,DiaChi,TenCV FROM dbo.ChucVu,dbo.PhieuThanhToan,dbo.NhanVien WHERE ChucVu.MaCV = NhanVien.MaCV AND NhanVien.MaNV = PhieuThanhToan.MaNV AND MaPhieu = " + MaPhieu + "";
            return dbPhieuThanhToan.ExecuteQueryDataSet(querySearch, CommandType.Text);
        }
    }
}
