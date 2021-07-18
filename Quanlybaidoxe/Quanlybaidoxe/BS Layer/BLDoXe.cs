using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;
using System.Windows.Forms;

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

        public DataSet SearchMonthTicket(string MaTheGuiXe)
        {
            string query = StringSearchMonthTicket(MaTheGuiXe);
            return dbDoXe.ExecuteQueryDataSet(query, CommandType.Text);
        }
        public DataSet GetPosition()
        {
            string query = "SELECT MaViTri FROM dbo.ViTri WHERE MaXe IS NULL OR MaXe = ''";
            return dbDoXe.ExecuteQueryDataSet(query, CommandType.Text);
        }
        public DataSet GetTicketID()
        {
            string query = "SELECT MaTheGuiXe FROM dbo.TheGuiXe WHERE MaXe IS NULL OR MaXe = ''";
            return dbDoXe.ExecuteQueryDataSet(query, CommandType.Text);
        }
        public bool CheckVehicleID(string MaXe)
        {
            string sqlString = "Select * From Xe Where MaXe = '" + MaXe.ToString() + "'";
            if (dbDoXe.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows.Count >= 1)
                return false;
            return true;
        }
        public bool CheckTicketID(string MaTheGuiXe)
        {
            string sqlString = "Select * From TheGuiXe Where MaXe = '" + MaTheGuiXe.ToString() + "'";
            if (dbDoXe.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows.Count >= 1)
                return false;
            return true;
        }
        public bool CheckPosition(string MaViTri)
        {
            string sqlString = "Select * From ViTri Where ( MaXe IS NULL OR MaXe = '' ) and MaViTri = '" + MaViTri.ToString() + "'";
            if (dbDoXe.ExecuteQueryDataSet(sqlString, CommandType.Text).Tables[0].Rows.Count >= 1)
                return true;
            return false;
        }
        public bool CheckType(string MaXe, string MaTheGui, string MaViTri)
        {
            bool check = true;
            try
            {
                dbDoXe = new DBQLBaiDoXe();
                if (CheckPosition(MaViTri) == false)
                {
                    MessageBox.Show("Mã vị trí hiện không có sẵn, vui lòng chọn vị trí mới!");
                    check = false;
                }
                dbDoXe = new DBQLBaiDoXe();
                if (CheckTicketID(MaTheGui) == false)
                {
                    MessageBox.Show("Mã thẻ gửi hiện đã có xe, vui lòng chọn thẻ mới!");
                    check = false;
                }
                dbDoXe = new DBQLBaiDoXe();



            }
            catch
            {
                MessageBox.Show("Kiểm tra mã xe và mã thẻ gửi bị lỗi, vui lòng thử lại!");

                return false;
            }

            return check;

        }
        public DataSet GetVehicleType()
        {
            string query = "SELECT * FROM dbo.LoaiXe";
            return dbDoXe.ExecuteQueryDataSet(query, CommandType.Text);
        }
        private string StringLoadData()
        {
            string query = "SELECT MaTheGuiXe,Xe.MaXe,BienSo,TenXe,MauSac,TenLoaiXe,TenViTri,GioVao,DangKyThang FROM dbo.TheGuiXe,dbo.Xe,dbo.ViTri,dbo.LoaiXe WHERE TheGuiXe.MaXe = dbo.Xe.MaXe AND ViTri.MaXe = Xe.MaXe AND Xe.MaLoaiXe = LoaiXe.MaLoaiXe";
            return query;
        }

        private string StringSearchMonthTicket(string MaTheGuiXe)
        {
            string query = "SELECT MaTheGuiXe,Xe.MaXe,BienSo,TenXe,MauSac,TenLoaiXe,GioVao,DangKyThang FROM dbo.TheGuiXe,dbo.Xe,dbo.LoaiXe WHERE TheGuiXe.MaXe = dbo.Xe.MaXe AND Xe.MaLoaiXe = LoaiXe.MaLoaiXe AND DangKyThang = 'True' And MaTheGuiXe = '" + MaTheGuiXe.Trim() + "'";
            return query;
        }
        public bool VehicleGoIn(string BienSo, string MaXe, string TenXe, string MauSac, DateTime GioVao, string MaLoaiXe, string MaTheGui, string MaViTri, ref string err)
        {
            string sqlString = StringQueryVehicleGoIn();
            SqlParameter[] parameters = {
                new SqlParameter("@MaXe", MaXe),
                new SqlParameter("@BienSo",BienSo),
                new SqlParameter("@TenXe",TenXe),
                new SqlParameter("@MauSac",MauSac),
                new SqlParameter("@GioVao",GioVao),
                new SqlParameter("@MaLoaiXe",MaLoaiXe),
                new SqlParameter("@MaTheGuiXe",MaTheGui),
                new SqlParameter("@MaViTri",MaViTri)
               // new SqlParameter("@MaXe", "NULL"),
            };
            return dbDoXe.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);

        }
        public bool UpdateVehicle(string BienSo, string MaXe, string TenXe, string MauSac, DateTime GioVao, string MaLoaiXe, string MaTheGui, string MaViTri, ref string err)
        {
            string sqlString = StringUpdateVehicle();
            SqlParameter[] parameters = {
                new SqlParameter("@MaXe", MaXe),
                new SqlParameter("@BienSo",BienSo),
                new SqlParameter("@TenXe",TenXe),
                new SqlParameter("@MauSac",MauSac),
                new SqlParameter("@GioVao",GioVao),
                new SqlParameter("@MaLoaiXe",MaLoaiXe),
                new SqlParameter("@MaTheGuiXe",MaTheGui),
                new SqlParameter("@MaViTri",MaViTri)
               // new SqlParameter("@MaXe", "NULL"),
            };
            return dbDoXe.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);

        }
        public DataSet GetMonthStickIDByVehicleID(string MaXe)
        {
            
            string sqlString = "SELECT MaTheGuiXe FROM dbo.TheGuiXe WHERE MaXe = '"+MaXe.Trim()+"'";
            return dbDoXe.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }

        public DataSet GetVihicles()
        {
           
            string sqlString = "SELECT Xe.MaXe,BienSo,TenXe,MauSac,TenLoaiXe,DangKyThang FROM  dbo.Xe,dbo.LoaiXe WHERE  Xe.MaLoaiXe = LoaiXe.MaLoaiXe ";
            return dbDoXe.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        private string StringQueryVehicleGoIn()
        {
            return "INSERT INTO dbo.Xe(MaXe,BienSo,TenXe,MauSac,MaLoaiXe,DangKyThang) VALUES ( @MaXe, @BienSo, @TenXe, @MauSac, @MaLoaiXe,0);UPDATE dbo.ViTri SET MaXe = @MaXe WHERE MaViTri = @MaViTri;UPDATE dbo.TheGuiXe SET MaXe = @MaXe , GioVao = @GioVao Where MaTheGuiXe = @MaTheGuiXe ";
        }
        private string StringUpdateVehicle()
        {
            return "UPDATE dbo.Xe SET TenXe = @TenXe, MauSac = @MauSac,MaLoaiXe = @MaLoaiXe WHERE BienSo = @BienSo ;UPDATE dbo.TheGuiXe SET MaXe = @MaXe,GioVao = @GioVao WHERE MaTheGuiXe = @MaTheGuiXe;UPDATE dbo.ViTri SET MaXe = @MaXe WHERE MaViTri = @MaViTri";
        }
        public DataSet CountTimeInParkingAtMinute(DateTime Stardate, DateTime Enddate)
        {
            string StringQuery = "SELECT DATEDIFF(MINUTE, '"+Stardate.ToString("MM/dd/yyyy h:mm tt").Trim()+"','"+ Enddate.ToString("MM/dd/yyyy h:mm tt").Trim() + "') as Time";
            
            return dbDoXe.ExecuteQueryDataSet(StringQuery, CommandType.Text);
        }
        public DataSet HourlParkingFee(string MaLoaiXe, DateTime Stardate, DateTime Enddate)
        {
            string StringQuery = StringFindPriceByHour(MaLoaiXe, Stardate.ToString("MM/dd/yyyy h:mm tt"),Enddate.ToString("MM/dd/yyyy h:mm tt"));
            return dbDoXe.ExecuteQueryDataSet(StringQuery, CommandType.Text);
        }
        public DataSet GetFeeOverDay(string MaLoaiXe)
        {
            string StringQuery = "SELECT TenGiaVe, GiaTien FROM dbo.GiaVe WHERE MaLoaiXe = '"+MaLoaiXe.Trim()+"' AND GioToiDa = 24";
            return dbDoXe.ExecuteQueryDataSet(StringQuery, CommandType.Text);
        }
        private string StringFindPriceByHour(string MaLoaiXe,string Stardate, string Enddate)
        {
            return "SELECT * FROM dbo.GiaVe WHERE VeThang = 'False' AND MaLoaiXe = '"+ MaLoaiXe.Trim() + "' AND GioToiThieu <= DATEDIFF(MINUTE, '"+Stardate.Trim()+"','"+Enddate.Trim()+"')/ 60 AND GioToiDa > DATEDIFF(MINUTE, '"+ Stardate.Trim() + "', '"+ Enddate.Trim() + "') / 60";
        }

        public bool CheckOutAndFree(string MaXe, DateTime GioVao,DateTime GioRa, string MaNV,bool TraTheoThang,float TienThu, ref string err)
        {
            string sqlString = "";
            if (TraTheoThang)
                sqlString = StringCheckOutWithMonthTicket();
            else
                sqlString = StringCheckOutWithNormalTicket();
            SqlParameter[] parameters = {
                new SqlParameter("@MaXe", MaXe),
                new SqlParameter("@GioVao",GioVao),
                new SqlParameter("@GioRa",GioRa),
                new SqlParameter("@MaNV",MaNV),
                new SqlParameter("@TienThu",TienThu),
                new SqlParameter("@TraTheoThang",TraTheoThang),
               // new SqlParameter("@MaXe", "NULL"),
            };
            return dbDoXe.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);

        }
        private string StringCheckOutWithNormalTicket()
        {
            return "UPDATE dbo.ViTri SET MaXe = NULL WHERE MaXe = @MaXe;UPDATE dbo.TheGuiXe SET MaXe = NULL,GioVao = NULL WHERE MaXe = @MaXe;INSERT INTO dbo.PhieuThanhToan(MaXe,GioVao,GioRa,TienThu,TraTheoThang,MaNV) VALUES (@MaXe,@GioVao,@GioRa,@TienThu,@TraTheoThang,@MaNV)";
        }
        private string StringCheckOutWithMonthTicket()
        {
            return "UPDATE dbo.ViTri SET MaXe = NULL WHERE MaXe = @MaXe;UPDATE dbo.TheGuiXe SET GioVao = NULL WHERE MaXe = @MaXe;INSERT INTO dbo.PhieuThanhToan(MaXe,GioVao,GioRa,TienThu,TraTheoThang,MaNV) VALUES (@MaXe,@GioVao,@GioRa,@TienThu,@TraTheoThang,@MaNV)";
        }
    }
}
