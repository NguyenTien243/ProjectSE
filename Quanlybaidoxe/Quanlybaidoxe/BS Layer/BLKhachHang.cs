using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
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
    }
}
