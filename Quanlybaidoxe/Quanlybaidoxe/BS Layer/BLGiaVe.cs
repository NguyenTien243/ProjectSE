using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

namespace Quanlybaidoxe.BS_Layer
{
    class BLGiaVe
    {
        public DBQLBaiDoXe dbGiaVe = null;
        public BLGiaVe()
        {
            dbGiaVe = new DBQLBaiDoXe();
        }
        public DataSet GetVehicleCategory()
        {
            return dbGiaVe.ExecuteQueryDataSet("SELECT DISTINCT TenLoaiXe FROM GiaVe JOIN LoaiXe ON GiaVe.MaLoaiXe = LoaiXe.MaLoaiXe", CommandType.Text);
        }
        public DataSet GetNameVehicle(string MaLoaiXe)
        {
            string GetName = "SELECT DISTINCT TenLoaiXe FROM GiaVe JOIN LoaiXe ON GiaVe.MaLoaiXe = LoaiXe.MaLoaiXe WHERE LoaiXe.MaLoaiXe = '" + MaLoaiXe +"'";
            return dbGiaVe.ExecuteQueryDataSet(GetName, CommandType.Text); 
        }
        public DataSet GetVechicleId(string TenLoaiXe)
        {
            string GetID = "SELECT MaLoaiXe FROM LoaiXe WHERE TenLoaiXe = '" + TenLoaiXe + "'";
            return dbGiaVe.ExecuteQueryDataSet(GetID, CommandType.Text);
        }
        public DataSet GetAllTickets()
        {
            return dbGiaVe.ExecuteQueryDataSet("SELECT * FROM GiaVe", CommandType.Text);
        }
        public bool AddTicket(string MaGiaVe, string TenGiaVe, float GiaTien, string MaLoaiXe, string GioToiThieu, string GioToiDa, string UuDai, int VeThang, ref string err)
        {
            //try { 
            //    Int32.Parse(GioToiDa); 
            //    Int32.Parse(GioToiThieu);
            //    Int32.Parse(UuDai);
            //}
            //catch { GioToiDa = "0";
            //    GioToiThieu = "0";
            //    UuDai = "0";
            //}
            string sqlString = "INSERT INTO GiaVe VALUES(@MaGiaVe, @TenGiaVe, @GiaTien, @MaLoaiXe, @GioToiThieu, @GioToiDa, @UuDai, @VeThang)";
            SqlParameter[] parameters = {
                new SqlParameter("@MaGiaVe", MaGiaVe),
                new SqlParameter("@TenGiaVe",TenGiaVe),
                new SqlParameter("@GiaTien",GiaTien),
                new SqlParameter("@MaLoaiXe",MaLoaiXe),
                new SqlParameter("@GioToiThieu",GioToiThieu),
                new SqlParameter("@GioToiDa",GioToiDa),
                new SqlParameter("@UuDai",UuDai),
                new SqlParameter("@VeThang",VeThang)
               // new SqlParameter("@MaXe", "NULL"),
            };
            return dbGiaVe.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);

        }
        public DataSet CheckTicketId(string MaGiaVe)
        {
            return dbGiaVe.ExecuteQueryDataSet("SELECT MaGiaVe FROM GiaVe WHERE MaGiaVe = '" + MaGiaVe + "'", CommandType.Text);
        }
        public bool CheckTime(string GioToiThieu, string GioToiDa)
        {
            if(Int32.Parse(GioToiThieu) > Int32.Parse(GioToiDa))
            { 
                MessageBox.Show("GIỜ TỐI ĐA phải lớn hơn GIỜ TỐI THIỂU");
                return false;
            }
            return true;
        }
        public bool CheckType(string GioToiThieu, string GioToiDa, string UuDai)
        {
            try
            {
                Int32.Parse(GioToiDa);
                Int32.Parse(GioToiThieu);
                Int32.Parse(UuDai);
                return true;
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng kiểu dữ liệu");
                //GioToiDa = "0";
                //GioToiThieu = "0";
                //UuDai = "0";
                return false;
            }
        }
    }
}
