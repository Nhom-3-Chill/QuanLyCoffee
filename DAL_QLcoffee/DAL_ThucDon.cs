using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using DTO_QLcoffee;

namespace DAL_QLcoffee
{
    public class DAL_ThucDon : DataConnect
    {
        // Get Danh sach thuc don
        public DataTable DSThucDon()
        {
            try
            {
                connection.Open();
                SqlCommand scm = new SqlCommand();
                scm.CommandType = CommandType.StoredProcedure;
                scm.CommandText = "ListTD";
                scm.Connection = connection;
                DataTable tb = new DataTable();
                tb.Load(scm.ExecuteReader());
                return tb;
            }
            finally
            {
                connection.Close();
            }
        }

        // Them mot thuc don moi
        public bool LuuThucDon(DTO_ThucDon td)
        {
            try
            {
                connection.Open();
                SqlCommand scm = new SqlCommand();
                scm.CommandType = CommandType.StoredProcedure;
                scm.CommandText = "InsertTD";
                scm.Parameters.AddWithValue("@TenTD", td.TenTD);
                scm.Parameters.AddWithValue("@Gia",  td.Gia);
                scm.Parameters.AddWithValue("@HinhAnh", td.HinhAnh);
                scm.Connection = connection;
                if (scm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        // Cap nhat thuc don
        public bool SuaThucDon(DTO_ThucDon td)
        {
            try
            {
                connection.Open();
                SqlCommand scm = new SqlCommand();
                scm.CommandType = CommandType.StoredProcedure;
                scm.CommandText = "UpdateTD";
                scm.Parameters.AddWithValue("@TenTD", td.TenTD);
                scm.Parameters.AddWithValue("@Gia", td.Gia);
                scm.Parameters.AddWithValue("@HinhAnh", td.HinhAnh);
                scm.Connection = connection;
                if (scm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public bool XoaThucDon(int MaTD)
        {
            try
            {
                connection.Open();
                SqlCommand scm = new SqlCommand();
                scm.CommandType = CommandType.StoredProcedure;
                scm.CommandText = "DeleteTD";
                scm.Parameters.AddWithValue("@MaTD", MaTD);
                scm.Connection = connection;
                if (scm.ExecuteNonQuery() > 0)
                    return true;
            }
            catch(Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        // Tim kiem thuc don
        public DataTable TimKiemThucDon(string tenTD)
        {
            try
            {
                connection.Open();
                SqlCommand scm = new SqlCommand();
                scm.CommandType = CommandType.StoredProcedure;
                scm.CommandText = "SearchTD";
                scm.Parameters.AddWithValue("@TenTD", tenTD);
                scm.Connection = connection;
                DataTable tb = new DataTable();
                tb.Load(scm.ExecuteReader());
                return tb;
            }
            finally
            {
                connection.Close();
            }
        }

        // Xem thống kê
        public DataTable XemThongKe(string ngayBD, string ngayKT)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "XemThongKe";
                command.Parameters.AddWithValue("ngaybt", ngayBD);
                command.Parameters.AddWithValue("ngaykt", ngayKT);
                command.Connection = connection;
                DataTable table = new DataTable();
                table.Load(command.ExecuteReader());
                return table;
            }
            finally
            {
                connection.Close();
            }
        }
    }
}
