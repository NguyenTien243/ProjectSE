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
    }
}
