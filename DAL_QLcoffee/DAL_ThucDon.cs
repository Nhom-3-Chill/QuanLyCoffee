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

        //static void Main(string[] args)
        //{
        //    var exampleClass = new ExampleClass();
        //    var returnedClass = exampleClass.ExampleMethod();
        //    returnedClass.AnotherExampleMethod();
        //}
        //class ExampleClass
        //{
        //    public ReturnedClass ExampleMethod()
        //    {
        //        return null;
        //    }
        //}
        //class ReturnedClass
        //{
        //    public void AnotherExampleMethod()
        //    {
        //    }
        //}
        // Bo sung 3 ham:
        public DataTable DanhSachTenMon()
        {
            try
            {
                connection.Open();
                SqlCommand scm = new SqlCommand();
                scm.CommandType = CommandType.StoredProcedure;
                scm.CommandText = "DanhSanhMon";
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
        public string DonGiaMon(string tenmon)
        {
            try
            {
                connection.Open();
                SqlCommand scm = new SqlCommand();
                scm.CommandType = CommandType.StoredProcedure;
                scm.CommandText = "DonGiaMon";
                scm.Parameters.AddWithValue("@tenmon", tenmon);
                scm.Connection = connection;
                return Convert.ToString(scm.ExecuteScalar());
            }
            finally
            {
                connection.Close();
            }
        }
        public bool ThanhToanTien(string tenkh, string tennv, DateTime ngaylap, float tongtien)
        {
            try
            {
                connection.Open();
                SqlCommand scm = new SqlCommand();
                scm.CommandType = CommandType.StoredProcedure;
                scm.CommandText = "ThanhToan";
                scm.Parameters.AddWithValue("@TenKH", tenkh);
                scm.Parameters.AddWithValue("@TenNV", tennv);
                scm.Parameters.AddWithValue("@Ngaylap", ngaylap);
                scm.Parameters.AddWithValue("@TongTien", tongtien);
                scm.Connection = connection;
                if (scm.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        // Get Danh sach thuc don
        public DataTable DSThucDon()
        {
            try
            {
                connection.Open();
                SqlCommand scm = new SqlCommand();
                scm.CommandType = CommandType.StoredProcedure;
                scm.CommandText = "DanhSachTD";
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
                scm.Parameters.AddWithValue("@MaTD", td.MaTD);
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
                scm.Parameters.AddWithValue("@MaTD", td.MaTD);
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
