using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Quanlybaidoxe.BS_Layer
{
    class BLTaiKhoan
    {
        public DBQLBaiDoXe db = null;
        public BLTaiKhoan()
        {
            db = new DBQLBaiDoXe();
        }

        public DataSet LayTaiKkhoanNV()
        {
            return db.ExecuteQueryDataSet("SELECT TaiKhoan,MatKhau,dbo.TaiKhoan.MaNV, TenNV FROM dbo.TaiKhoan, dbo.NhanVien WHERE TaiKhoan.MaNV = NhanVien.MaNV", CommandType.Text);
        }
        //public DataSet KTChucVu(string MaNV)
        //{
        //    return db.ExecuteQueryDataSet("select MaNV,CongViec.MaCV as MaCV from dbo.NhanVien,dbo.CongViec WHERE NhanVien.MaCV = CongViec.MaCV AND MaNV = '" + MaNV + "'", CommandType.Text);
        //}
        //public DataSet LayNV()
        //{
        //    return db.ExecuteQueryDataSet("select n.MaNV,n.TenNV,TenCV,n.GioiTinh,SDT,DiaChi,Luong from NhanVien n, CongViec where n.MaCV = CongViec.MaCV ", CommandType.Text);
        //}
        //public DataSet LayCongViec()
        //{
        //    return db.ExecuteQueryDataSet("select * from CongViec ", CommandType.Text);
        //}
        //public bool ThemNV(string MaNV, string TenNV, string Congviec, string gioitinh, string sdt, string DiaChi, int luong, ref string err)
        //{
        //    string sqlString = "Insert Into NhanVien Values( @MaNV,@TenNV,@CongViec,@GioiTinh,@SDT,@DiaChi,@Luong )";
        //    SqlParameter[] para = {
        //    new SqlParameter("@MaNV", MaNV),
        //    new SqlParameter("@TenNV", TenNV),
        //    new SqlParameter("@CongViec", Congviec),
        //    new SqlParameter("@GioiTinh", gioitinh),
        //    new SqlParameter("@SDT", sdt),
        //    new SqlParameter("@DiaChi", DiaChi),
        //    new SqlParameter("@Luong", luong)};
        //    return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        //}
        //public bool XoaNV(string MaNV, ref string err)
        //{
        //    string sqlString = "Delete From NhanVien Where MaNV = @MaNV ";
        //    SqlParameter[] para = { new SqlParameter("@MaNV", MaNV) };
        //    return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        //}
        //public bool CapNhatNV(string MaNV, string TenNV, string Congviec, string gioitinh, string sdt, string DiaChi, int luong, ref string err)
        //{
        //    //string sqlString = "Update NhanVien Set TenNV =N'" +
        //    //TenNV + "' ,MaCV = '" + Congviec +"' ,GioiTinh = N'" + gioitinh + "',SDT = '" + sdt + "' ,DiaChi = N'" + DiaChi + "',Luong = " + luong + " Where MaNV ='" + MaNV + "'";
        //    string sqlString = "Update NhanVien Set TenNV = @ten,MaCV = @cv,GioiTinh = @gt,SDT =@sdt,DiaChi = @dc,Luong = @luong Where MaNV = @MaNV ";
        //    SqlParameter[] para = {
        //    new SqlParameter("@MaNV", MaNV),
        //    new SqlParameter("@ten", TenNV),
        //    new SqlParameter("@cv", Congviec),
        //    new SqlParameter("@gt", gioitinh),
        //    new SqlParameter("@sdt", sdt),
        //    new SqlParameter("@dc", DiaChi),
        //    new SqlParameter("@luong", luong) };
        //    return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        //}
        //public bool DangKyNV(string MaNV, string TenTK, string MatKhau, ref string err)
        //{
        //    string sqlString = "INSERT INTO dbo.Users VALUES ( @TenTK, @MatKhau , @MaNV )";
        //    SqlParameter[] para = {
        //    new SqlParameter("@TenTK", TenTK),
        //    new SqlParameter("@MatKhau", MatKhau),
        //    new SqlParameter("@MaNV", MaNV) };
        //    return db.MyExecuteNonQuery(sqlString, para, CommandType.Text, ref err);
        //}
        //public DataSet Timkiem(string TK)
        //{
        //    if (SHAREVAR.search_MaNV == true)
        //    {
        //        return db.ExecuteQueryDataSet("Select * from NhanVien where MaNV like N'" + TK + "%'", CommandType.Text);
        //    }
        //    else if (SHAREVAR.search_TenNV == true)
        //    {
        //        return db.ExecuteQueryDataSet("Select * from NhanVien where TenNV like N'" + TK + "%'", CommandType.Text);
        //    }
        //    else
        //    {

        //        return db.ExecuteQueryDataSet("Select * from NhanVien where CongViec like N'" + TK + "%'", CommandType.Text);
        //    }
        //}
    }
}
