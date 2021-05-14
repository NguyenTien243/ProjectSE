using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Quanlybaidoxe.BS_Layer
{
    class BLDoXe
    {
        public DBQLBaiDoXe dbDoXe = null;
        public BLDoXe()
        {
            dbDoXe = new DBQLBaiDoXe();
        }
        public DataSet LoadData()
        {
            string query = StringLoadData();
            return dbDoXe.ExecuteQueryDataSet(query, CommandType.Text);
        }
        public DataSet GetTicketID()
        {

        }
        public DataSet GetVehicleType()
        {
            string query = "SELECT * FROM dbo.LoaiXe";
            return dbDoXe.ExecuteQueryDataSet(query, CommandType.Text);
        }
        private string StringLoadData()
        {
            string query = "SELECT MaTheGuiXe,Xe.MaXe,BienSo,TenXe,MauSac,TenLoaiXe,TenViTri,DangKyThang FROM dbo.TheGuiXe,dbo.Xe,dbo.ViTri,dbo.LoaiXe WHERE TheGuiXe.MaXe = dbo.Xe.MaXe AND ViTri.MaXe = Xe.MaXe AND Xe.MaLoaiXe = LoaiXe.MaLoaiXe";
            return query;
        }
    }
}
