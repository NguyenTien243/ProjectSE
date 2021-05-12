using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Quanlybaidoxe.BS_Layer
{
    class BLKhachHang
    {
        public DBQLBaiDoXe dbKhachHang = null;
        public BLKhachHang()
        {
            dbKhachHang = new DBQLBaiDoXe();
        }
        public DataSet CountKhachHang()
        {
            return dbKhachHang.ExecuteQueryDataSet("Select COUNT(KhachHang.MaKH) From KhachHang ", CommandType.Text);
        }
        public DataSet GetAllCustomers()
        {
            return dbKhachHang.ExecuteQueryDataSet("Select * From KhachHang ", CommandType.Text);
        }

        public bool CustomerRegister(string MaKH, string TenKH, DateTime NgaySinh, string GioiTinh, string CMND, string SDT, string DiaChi, DateTime HetHan, string MaXe, ref string err)
        {
           
            string sqlString = "Insert Into KhachHang Values( @MaKH,@TenKH,@NgaySinh, @GioiTinh, @CMND ,@SDT,@DiaChi, @HetHan, @MaXe)";
                SqlParameter[] parameters = {
            new SqlParameter("@MaKH", MaKH),
            new SqlParameter("@TenKH", TenKH),
            new SqlParameter("@GioiTinh", GioiTinh),
            new SqlParameter("@NgaySinh", NgaySinh),
            new SqlParameter("@CMND", CMND),
            new SqlParameter("@SDT", SDT),
            new SqlParameter("@DiaChi", DiaChi),
            new SqlParameter("@HetHan", HetHan),   //chưa biết cách để tính chỗ hết hạn
            new SqlParameter("@MaXe", MaXe),
           };
                return dbKhachHang.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);
            
        }

        public bool UpdateCustomer(string MaKH, string TenKH, DateTime NgaySinh, string GioiTinh, string CMND, string SDT, string DiaChi, DateTime HetHan, string MaXe, ref string err)
        {

            string sqlString = "UPDATE KhachHang SET TenKH = @TenKH, NgaySinh=@NgaySinh, GioiTinh=@GioiTinh, CMND=@CMND , SDT=@SDT, DiaChi=@DiaChi, HetHan=@HetHan WHERE MaXe = @MaXe";
            SqlParameter[] parameters = {
            new SqlParameter("@MaKH", MaKH),
            new SqlParameter("@TenKH", TenKH),
            new SqlParameter("@GioiTinh", GioiTinh),
            new SqlParameter("@NgaySinh", NgaySinh),
            new SqlParameter("@CMND", CMND),
            new SqlParameter("@SDT", SDT),
            new SqlParameter("@DiaChi", DiaChi),
            new SqlParameter("@HetHan", HetHan),
            new SqlParameter("@MaXe", MaXe),
           };
            return dbKhachHang.MyExecuteNonQuery(sqlString, parameters, CommandType.Text, ref err);

        }

        public bool DeleteCustomer(string MaKH, string MaXe, ref string err)
        {
            string sqlString = "DELETE FROM KhachHang Where MaKH = @MaKH; Delete From Xe Where MaXe = @MaXe";
             SqlParameter[] para = { 
                new SqlParameter("@MaKH", MaKH),
                new SqlParameter("@MaXe", MaXe)
                };
            return dbKhachHang.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        }

        public DataSet GetNameTicket()
        {
            return dbKhachHang.ExecuteQueryDataSet("SELECT TenGiaVe FROM GiaVe WHERE VeThang = 1 ", CommandType.Text);
        }
        public DataSet GetTicketNameOfCustomer(string MaKH)
        {
            return dbKhachHang.ExecuteQueryDataSet("SELECT KhachHang.MaXe FROM KhachHang WHERE MaKH = '"+MaKH +"'", CommandType.Text);
        }
    }
}
