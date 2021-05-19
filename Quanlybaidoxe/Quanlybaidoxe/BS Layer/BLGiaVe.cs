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
        //public DataSet GetVehicleCategory()
        //{
        //    return dbGiaVe.ExecuteQueryDataSet("SELECT DISTINCT TenLoaiXe FROM GiaVe JOIN LoaiXe ON GiaVe.MaLoaiXe = LoaiXe.MaLoaiXe", CommandType.Text);
        //}
        //public DataSet GetNameVehicle(string MaLoaiXe)
        //{
        //    string GetName = "SELECT DISTINCT TenLoaiXe FROM GiaVe JOIN LoaiXe ON GiaVe.MaLoaiXe = LoaiXe.MaLoaiXe WHERE LoaiXe.MaLoaiXe = '" + MaLoaiXe +"'";
        //    return dbGiaVe.ExecuteQueryDataSet(GetName, CommandType.Text); 
        //}
        //public DataSet GetVechicleId(string TenLoaiXe)
        //{
        //    string GetID = "SELECT MaLoaiXe FROM LoaiXe WHERE TenLoaiXe = '" + TenLoaiXe + "'";
        //    return dbGiaVe.ExecuteQueryDataSet(GetID, CommandType.Text);
        //}
        public DataSet GetAllTickets()
        {
            return dbGiaVe.ExecuteQueryDataSet("SELECT * FROM GiaVe", CommandType.Text);
        }
        public bool AddTicket(string MaGiaVe, string TenGiaVe, float GiaTien, string MaLoaiXe, string GioToiThieu, string GioToiDa, string UuDai, int VeThang, int SoThang, ref string err)
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
            string sqlString = "INSERT INTO GiaVe VALUES(@MaGiaVe, @TenGiaVe, @GiaTien, @MaLoaiXe, @GioToiThieu, @GioToiDa, @UuDai, @VeThang, @SoThang)";
            SqlParameter[] parameters = {
                new SqlParameter("@MaGiaVe", MaGiaVe),
                new SqlParameter("@TenGiaVe",TenGiaVe),
                new SqlParameter("@GiaTien",GiaTien),
                new SqlParameter("@MaLoaiXe",MaLoaiXe),
                new SqlParameter("@GioToiThieu",GioToiThieu),
                new SqlParameter("@GioToiDa",GioToiDa),
                new SqlParameter("@UuDai",UuDai),
                new SqlParameter("@VeThang",VeThang),
                new SqlParameter("@SoThang", SoThang),
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
        public bool CheckType(string GioToiThieu, string GioToiDa, string UuDai,string GiaVe)
        {
            bool check = true;
            try
            {
                Int32.Parse(GioToiDa);
                Int32.Parse(GioToiThieu);
                Int32.Parse(UuDai);
                float.Parse(GiaVe);
            }
            catch
            {
                MessageBox.Show("Vui lòng nhập đúng kiểu dữ liệu");
                //GioToiDa = "0";
                //GioToiThieu = "0";
                //UuDai = "0";
                return false;
            }
            if (Int32.Parse(GioToiDa) < 0 || Int32.Parse(GioToiThieu)<0)
            {
                MessageBox.Show("Giờ tối đa và giờ tối thiểu phải lớn hơn hoặc bằng 0!");
                check = false;
            }
            if(Int32.Parse(UuDai) < 0)
            {
                MessageBox.Show("Ưu đãi phải lớn hơn hoặc bằng 0!");
                check = false;
            }  
            if(float.Parse(GiaVe) < 0)
            {
                MessageBox.Show("Giá vé phải lớn hơn hoặc bằng 0!");
                check = false;
            }
            if (Int32.Parse(GioToiThieu) > Int32.Parse(GioToiDa))
            {
                MessageBox.Show("GIỜ TỐI ĐA phải lớn hơn GIỜ TỐI THIỂU");
                check = false;
            }

            return check;

        }

        public bool DeleteTicket(string MaGiaVe, ref string err)
        {
            string sqlString = "Delete From GiaVe Where MaGiaVe = @MaGiaVe";
            SqlParameter[] para = { new SqlParameter("@MaGiaVe", MaGiaVe) };
            return dbGiaVe.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }
        public bool CheckDeleteTicket(string Mave, ref string err)
        {
            // không cho phép xóa vé ngày, chỉ cho phép xóa vé tháng
            string sqlString = GetStringCheckDeleteTicket(Mave);
            if (dbGiaVe.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows.Count >= 1)
                return true;
            return false;
        }
        private string GetStringCheckDeleteTicket(string MaVe)
        {
           return "Select * From Giave Where MaGiaVe = '" + MaVe + "' and VeThang = 1";
        }

        public bool EditTicket(string magiave, string tengiave,float giatien,string maloaixe,int giotoithieu,int giotoida,int uudai,int vethang, int sothang, ref string err)
        {
            string sqlString = "UPDATE GiaVe SET MaGiaVe = @MaGiaVe, TenGiaVe = @TenGiaVe, GiaTien = @GiaTien, MaLoaiXe = @MaLoaiXe, GioToiThieu = @GioToiThieu, GioToiDa = @GioToiDa,UuDai = @UuDai, VeThang = @VeThang, SoThang = @SoThang  where MaGiaVe = @MaGiaVe";
            SqlParameter[] parameters = {
                new SqlParameter("@MaGiaVe", magiave),
                new SqlParameter("@TenGiaVe",tengiave),
                new SqlParameter("@GiaTien",giatien),
                new SqlParameter("@MaLoaiXe",maloaixe),
                new SqlParameter("@GioToiThieu",giotoithieu),
                new SqlParameter("@GioToiDa",giotoida),
                new SqlParameter("@UuDai",uudai),
                new SqlParameter("@VeThang",vethang),
                new SqlParameter("@SoThang", sothang),
            };
            return dbGiaVe.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);
        }

        public bool CheckNameTicket(string magiave, string tengiave, ref string err)
        {
            string sqlString = "Select * From GiaVe Where MaGiaVe != '" + magiave.Trim() + "' and TenGiaVe = '" + tengiave.Trim() + "'";
            if (dbGiaVe.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows.Count >= 1)
                return false;
            return true;
        }
    }
}
