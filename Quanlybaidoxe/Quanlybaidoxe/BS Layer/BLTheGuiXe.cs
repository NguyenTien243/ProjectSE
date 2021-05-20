using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using Quanlybaidoxe.DB_Layer;
namespace Quanlybaidoxe.BS_Layer
{
    class BLTheGuiXe
    {
        public DBQLBaiDoXe dbTheGuiXe = null;
        public BLTheGuiXe()
        {
            dbTheGuiXe = new DBQLBaiDoXe();
        }
        public DataSet GetAllCard()
        {
            return dbTheGuiXe.ExecuteQueryDataSet("SELECT * FROM TheGuiXe", CommandType.Text);
        }
        public bool AddCard(string MaTheGui, ref string err)
        {
            string sqlString = "INSERT INTO TheGuiXe VALUES(@MaTheGui, NULL, NULL)";
            SqlParameter[] parameters = {
                new SqlParameter("@MaTheGui", MaTheGui),                
               // new SqlParameter("@MaXe", "NULL"),
            };
            return dbTheGuiXe.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);
        }
        public bool CheckIdCard(string MaTheGui)
        {
            string sqlString = "SELECT MaTheGuiXe From TheGuiXe WHERE MaTheGuiXe = '"+MaTheGui+"'";
            if (dbTheGuiXe.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows.Count >= 1)
                return false;
            return true;  //chưa bị trùng ID
        }
        public bool CheckVehicle(string MaTheGui)
        {
            string sqlString = "SELECT MaTheGuiXe From TheGuiXe WHERE MaTheGuiXe = '" + MaTheGui + "' AND MaXe IS NOT NULL";
            if (dbTheGuiXe.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows.Count >= 1)
                return true; //đã có xe gửi
            return false;  
        }

        public bool DeleteCard(string MaTheGui, ref string err)
        {
            string sqlString = "Delete From TheGuiXe Where MaTheGuiXe = @MaTheGui";
            SqlParameter[] para = { new SqlParameter("@MaTheGui", MaTheGui) };
            return dbTheGuiXe.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }
        public DataSet CountSumTicket()
        {
            return dbTheGuiXe.ExecuteQueryDataSet("Select COUNT(MaTheGuiXe) as SoLuongThe From TheGuiXe", CommandType.Text);
        }
    }
}
