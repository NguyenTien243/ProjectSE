using Quanlybaidoxe.DB_Layer;
using System;
using System.Collections.Generic;
using System.Data;
using System.Text;

namespace Quanlybaidoxe.BS_Layer
{
    class BLXe
    {
        public DBQLBaiDoXe dbXe = null;
        public BLXe()
        {
            dbXe = new DBQLBaiDoXe();
        }
        public DataSet CountXe()
        {
            return dbXe.ExecuteQueryDataSet("Select COUNT(Xe.MaXe) From Xe ", CommandType.Text);
        }
    }
}
