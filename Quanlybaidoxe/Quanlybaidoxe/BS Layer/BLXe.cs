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
       
    }
}
