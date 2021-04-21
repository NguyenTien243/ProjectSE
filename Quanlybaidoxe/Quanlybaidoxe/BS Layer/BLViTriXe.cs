using System;
using System.Collections.Generic;
using System.Text;
using Quanlybaidoxe.DB_Layer;
using System.Data;
using System.Data.SqlClient;

namespace Quanlybaidoxe.BS_Layer
{

    class BLViTriXe

    {
        public DBQLBaiDoXe dbViTri = null;
        public BLViTriXe()
        {
            dbViTri = new DBQLBaiDoXe();
        }
        public DataSet GetPosition()
        {
            return dbViTri.ExecuteQueryDataSet("SELECT * FROM ViTri", CommandType.Text);
        }
        public bool AddPosition(string MaViTri, string TenViTri, ref string err)
        {
            string sqlString = "INSERT INTO ViTri VALUES(@MaViTri, @TenViTri, NULL)";
            SqlParameter[] parameters = {
                new SqlParameter("@MaViTri", MaViTri),
                new SqlParameter("@TenViTri",TenViTri),
               // new SqlParameter("@MaXe", "NULL"),
            };
            return dbViTri.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);
        }
        public bool EditPosition(string MaViTri, string TenViTri, ref string err)
        {
            string sqlString = "UPDATE ViTri SET TenViTri=@TenViTri WHERE MaViTri=@MaViTri";
            SqlParameter[] parameters = {
                new SqlParameter("@MaViTri", MaViTri),
                new SqlParameter("@TenViTri",TenViTri),
            };
            return dbViTri.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);
        }
        public DataSet CheckPositionId(string MaViTri)
        {
            return dbViTri.ExecuteQueryDataSet("SELECT MaViTri FROM ViTri WHERE MaViTri = '"+MaViTri+"'", CommandType.Text);
        }
        public DataSet CountCar()
        {
            return dbViTri.ExecuteQueryDataSet("SELECT COUNT(ViTri.MaXe) FROM ViTri JOIN Xe ON ViTri.MaXe = Xe.MaXe WHERE MaLoaiXe = (SELECT MaLoaiXe FROM LoaiXe WHERE TenLoaiXe = 'Ô tô')", CommandType.Text);
        }
        public DataSet CountMotorbike()
        {
            //return dbViTri.MyExecuteNonQuery("SELECT COUNT(ViTri.MaXe) FROM ViTri JOIN Xe ON ViTri.MaXe = Xe.MaXe WHERE MaLoaiXe = (SELECT MaLoaiXe FROM LoaiXe WHERE TenLoaiXe='Xe máy')", CommandType.Text, ref err);
            return dbViTri.ExecuteQueryDataSet("SELECT COUNT(ViTri.MaXe) FROM ViTri JOIN Xe ON ViTri.MaXe = Xe.MaXe WHERE MaLoaiXe = (SELECT MaLoaiXe FROM LoaiXe WHERE TenLoaiXe = 'Xe máy')", CommandType.Text);
        }
    }
}