using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Quanlybaidoxe.BS_Layer
{
    class BLDoanhThu
    {
        public DBQLBaiDoXe dbDoanhThu = null;
        public BLDoanhThu()
        {
            dbDoanhThu = new DBQLBaiDoXe();
        }
        public DataSet GetBillListByDate(string checkIn, string checkOut)
        {
            string GetID = "USP_GetListBillByDate '" + checkIn + "', '" + checkOut + "'";
            return dbDoanhThu.ExecuteQueryDataSet(GetID, CommandType.Text);
        }
        public DataSet GetSumBillByDate(string checkIn, string checkOut)
        {
            string GetID = "USP_GetSumBillByDate '" + checkIn + "', '" + checkOut + "'";
            return dbDoanhThu.ExecuteQueryDataSet(GetID, CommandType.Text);
        }
        public DataSet LoadData()
        {
            string StringQuery = "SELECT TenKH, GioVao, GioRa, TienThu, TenNV FROM dbo.PhieuThanhToan, dbo.KhachHang, dbo.NhanVien WHERE PhieuThanhToan.MaXe = KhachHang.MaXe AND NhanVien.MaNV = PhieuThanhToan.MaNV";
            return dbDoanhThu.ExecuteQueryDataSet(StringQuery, CommandType.Text);
        }
    }
}
