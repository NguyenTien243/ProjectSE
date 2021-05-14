using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Text;

namespace Quanlybaidoxe.DB_Layer
{
    class DBQLBaiDoXe
    {
        string ConnectString = @"Data Source=(local);Initial Catalog=QLBaiDoXe;Integrated Security=True";
        SqlConnection connect = null;
        SqlCommand command = null;
        SqlDataAdapter adapter = null;
        public DBQLBaiDoXe()
        {
            connect = new SqlConnection(ConnectString);
            command = connect.CreateCommand();
        }

        internal DataTable ExecuteQueryDataSet(string v, object[] vs)
        {
            throw new NotImplementedException();
        }

        public DataSet ExecuteQueryDataSet(string stringquery, CommandType commandtype)
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
            connect.Open();
            command.CommandText = stringquery;
            command.CommandType = commandtype;
            adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            return dataset;
        }
        public DataSet ExecuteQueryDataSet(string stringquery, SqlParameter[] parameters, CommandType commandtype)
        {
            if (connect.State == ConnectionState.Open)
                connect.Close();
            connect.Open();
            command = new SqlCommand();


            command.CommandText = stringquery;
            command.CommandType = commandtype;
            foreach (var item in parameters)
            {
                command.Parameters.Add(item);
            }
            adapter = new SqlDataAdapter(command);
            DataSet dataset = new DataSet();
            adapter.Fill(dataset);
            return dataset;
        }
        public bool MyExecuteNonQuery(string stringquery, SqlParameter[] parameters, CommandType commandtype, ref string error)
        {
            bool check = false;
            if (connect.State == ConnectionState.Open)
                connect.Close();
            connect.Open();
            //comm = new SqlCommand();
            command.CommandText = stringquery;
            command.CommandType = commandtype;

            foreach (var item in parameters)
            {
                command.Parameters.Add(item);
            }
            try
            {

                if (command.ExecuteNonQuery() != 0)
                    check = true;
            }
            catch (SqlException exception)
            {
                error = exception.Message;
            }
            finally
            {
                connect.Close();
            }
            return check;
        }
        public bool MyExecuteNonQuery(string stringquery, CommandType commandtype, ref string error)
        {
            bool check = false;
            if (connect.State == ConnectionState.Open)
                connect.Close();
            connect.Open();
            command.CommandText = stringquery;
            command.CommandType = commandtype;
            try
            {
                command.ExecuteNonQuery();
                check = true;
            }
            catch (SqlException exception)
            {
                error = exception.Message;
            }
            finally
            {
                connect.Close();
            }
            return check;
        }
    }
}
