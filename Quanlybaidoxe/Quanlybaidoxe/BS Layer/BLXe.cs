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
            return dbXe.ExecuteQueryDataSet("Select COUNT(Xe.MaXe) From Xe ", CommandType.Text);
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
        public DataSet GetVechicleId(string TenLoaiXe)
        {
            string GetID = "SELECT MaLoaiXe FROM LoaiXe WHERE TenLoaiXe = '" + TenLoaiXe + "'";
            return dbXe.ExecuteQueryDataSet(GetID, CommandType.Text);
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
    }
}
