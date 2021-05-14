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
                if (CheckVehicleID(MaXe) == false)
                {
                    MessageBox.Show("Mã xe bị trùng, vui lòng chọn mã xe mới!");
                    check = false;
                }


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
            string query = "SELECT MaTheGuiXe,Xe.MaXe,BienSo,TenXe,MauSac,TenLoaiXe,GioVao,DangKyThang FROM dbo.TheGuiXe,dbo.Xe,dbo.LoaiXe WHERE TheGuiXe.MaXe = dbo.Xe.MaXe AND Xe.MaLoaiXe = LoaiXe.MaLoaiXe AND DangKyThang = 'True' And MaTheGuiXe = '" + MaTheGuiXe.Trim()+"'";
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
                new SqlParameter("@MaTheGui",MaTheGui),
                new SqlParameter("@MaViTri",MaViTri)
               // new SqlParameter("@MaXe", "NULL"),
            };
            return dbDoXe.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);

        }
        public bool UpdateVehicle(string TenXe, string MauSac, DateTime GioVao, string MaLoaiXe, string MaTheGui, string MaViTri, ref string err)
        {
            string sqlString = StringUpdateVehicle();
            SqlParameter[] parameters = {
                new SqlParameter("@TenXe",TenXe),
                new SqlParameter("@MauSac",MauSac),
                new SqlParameter("@GioVao",GioVao),
                new SqlParameter("@MaLoaiXe",MaLoaiXe),
                new SqlParameter("@MaTheGui",MaTheGui),
                new SqlParameter("@MaViTri",MaViTri)
               // new SqlParameter("@MaXe", "NULL"),
            };
            return dbDoXe.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);

        }
       
        public DataSet GetVihicles()
        {
            string sqlString = "SELECT MaTheGuiXe,Xe.MaXe,BienSo,TenXe,MauSac,TenLoaiXe,GioVao,DangKyThang FROM dbo.TheGuiXe,dbo.Xe,dbo.LoaiXe WHERE TheGuiXe.MaXe = dbo.Xe.MaXe AND Xe.MaLoaiXe = LoaiXe.MaLoaiXe "; 
            return dbDoXe.ExecuteQueryDataSet(sqlString, CommandType.Text);
        }
        private string StringQueryVehicleGoIn()
        {
            return "INSERT INTO dbo.Xe(MaXe,BienSo,TenXe,MauSac,MaLoaiXe) VALUES ( @MaXe, @BienSo, @TenXe, @MauSac, @MaLoaiXe);UPDATE dbo.ViTri SET MaXe = @MaXe WHERE MaViTri = @MaViTri;UPDATE dbo.TheGuiXe SET MaXe = @MaXe , GioVao = @GioVao Where MaTheGuiXe = @MaTheGui ";
        }
        private string StringUpdateVehicle()
        {
            return "UPDATE dbo.Xe SET TenXe = @TenXe, MauSac = @MauSac,MaLoaiXe = @MaLoaiXe WHERE BienSo = @BienSo ;UPDATE dbo.TheGuiXe SET MaXe = @MaXe,GioVao = @GioVao WHERE MaTheGuiXe = @MaTheGuiXe;UPDATE dbo.ViTri SET MaXe = @MaXe WHERE MaViTri = @MaViTri";
        }
    }
}
