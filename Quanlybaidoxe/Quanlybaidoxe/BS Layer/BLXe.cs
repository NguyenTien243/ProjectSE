using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Quanlybaidoxe.BS_Layer
{
    class BLXe
    {
        public DBQLBaiDoXe dbXe = null;
        public BLXe()
        {
            dbXe = new DBQLBaiDoXe();
        }
        public DataSet CountXe()
        {
            return dbXe.ExecuteQueryDataSet("SELECT COUNT(MaXe) FROM ViTri WHERE MaXe IS NOT NULL", CommandType.Text);
        }
        public bool AddVehicle(string MaXe, string BienSo, string TenXe, string MauSac, string MaLoaiXe, ref string err)
        {
            string sqlString = "Insert Into Xe Values(@MaXe, @BienSo, @TenXe, @MauSac, @MaLoaiXe, 1)";
            SqlParameter[] parameters = {
            new SqlParameter("@MaXe", MaXe),
            new SqlParameter("@BienSo", BienSo),
            new SqlParameter("@TenXe", TenXe),
            new SqlParameter("@MauSac", MauSac),
            new SqlParameter("@MaLoaiXe", MaLoaiXe),
           };

            return dbXe.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);
        }
        public DataSet GetVehicleId(string TenLoaiXe)
        {
            string GetID = "SELECT MaLoaiXe FROM LoaiXe WHERE TenLoaiXe = '" + TenLoaiXe + "'";
            return dbXe.ExecuteQueryDataSet(GetID, CommandType.Text);
        }
        public DataSet DeleteVehicle(string MaXe)
        {
            string DeleteVehicle = "DELETE FROM Xe WHERE MaXe ='" + MaXe + "'";
            return dbXe.ExecuteQueryDataSet(DeleteVehicle, CommandType.Text);
        }
        public DataSet GetVehicleCategory()
        {
            return dbXe.ExecuteQueryDataSet("SELECT DISTINCT TenLoaiXe FROM GiaVe JOIN LoaiXe ON GiaVe.MaLoaiXe = LoaiXe.MaLoaiXe", CommandType.Text);
        }
        public DataSet GetNameVehicle(string MaLoaiXe)
        {
            string GetName = "SELECT DISTINCT TenLoaiXe FROM GiaVe JOIN LoaiXe ON GiaVe.MaLoaiXe = LoaiXe.MaLoaiXe WHERE LoaiXe.MaLoaiXe = '" + MaLoaiXe + "'";
            return dbXe.ExecuteQueryDataSet(GetName, CommandType.Text);
        }
        public DataSet CheckIdVehicle(string MaXe)
        {
           
            return dbXe.ExecuteQueryDataSet("SELECT * FROM XE WHERE MaXe = '" + MaXe.Trim() + "'", CommandType.Text);
        }
        public DataSet CheckLicensePlate(string BienSo)
        {          
            return dbXe.ExecuteQueryDataSet("SELECT * FROM XE WHERE BienSo = '" + BienSo.Trim() + "'", CommandType.Text);

        }
        public bool UpdateVehicle(string MaXe, string BienSo, string TenXe, string MauSac, ref string err)
        {
            string sqlString = "UPDATE Xe SET BienSo = @BienSo, TenXe = @TenXe, MauSac = @MauSac WHERE MaXe=@MaXe";
            SqlParameter[] parameters = {
            new SqlParameter("@MaXe", MaXe),
            new SqlParameter("@BienSo", BienSo),
            new SqlParameter("@TenXe", TenXe),
            new SqlParameter("@MauSac", MauSac),      
           };

            return dbXe.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);
        }
        public DataSet GetVehicle(string MaKH)
        {
            string GetInf = "SELECT Xe.MaXe, BienSo, TenXe, MauSac, MaLoaiXe, DangKyThang FROM KhachHang JOIN Xe ON KhachHang.MaXe = Xe.MaXe WHERE MaKH = '" + MaKH + "'";
            return dbXe.ExecuteQueryDataSet(GetInf, CommandType.Text);
        }
        public DataSet GetVehicleCategoryId(string MaXe)
        {
            string GetCategoryId = "SELECT MaLoaiXe FROM KhachHang JOIN Xe ON KhachHang.MaXe = Xe.MaXe WHERE KhachHang.MaXe = '" + MaXe + "'";
            return dbXe.ExecuteQueryDataSet(GetCategoryId, CommandType.Text);
        }
        public bool CheckDeleteVehicle(string MaXe, ref string err)
        {
            string sqlString = "SELECT * FROM ViTri WHERE MaXe = '" + MaXe + "'";
            if (dbXe.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows.Count >= 1)
                return true; //xe đang đỗ trong bãi
            return false;
        }

        public DataSet GetInfoVehicleRegistered()
        {
            string GetInf = "SELECT Xe.MaXe, BienSo, TenXe, MauSac,  TenLoaiXe, TenKH FROM((KhachHang INNER JOIN Xe ON KhachHang.MaXe = Xe.MaXe) JOIN LoaiXe ON Xe.MaLoaiXe = LoaiXe.MaLoaiXe) WHERE DangKyThang = 1";
            return dbXe.ExecuteQueryDataSet(GetInf, CommandType.Text);
        }
        public DataSet GetInfoVehicleNotRegisted()
        {
            string GetInf = "SELECT Xe.MaXe, BienSo, TenXe, MauSac,  TenLoaiXe FROM Xe JOIN LoaiXe ON Xe.MaLoaiXe = LoaiXe.MaLoaiXe WHERE DangKyThang = 0";
            return dbXe.ExecuteQueryDataSet(GetInf, CommandType.Text);
        }
    }
}
