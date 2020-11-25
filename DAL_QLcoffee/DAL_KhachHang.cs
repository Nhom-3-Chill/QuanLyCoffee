using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using DTO_QLcoffee;
using System.Windows.Forms;

namespace DAL_QLcoffee
{
    public class DAL_KhachHang : DataConnect
    {
        public DataTable DSKhacHang()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DanhSachKH";
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

        public bool LuuKhachHang(DTO_KhachHang kh)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LuuKH";
                command.Parameters.AddWithValue("MaKH", kh.MaKh);
                command.Parameters.AddWithValue("TenK   hach", kh.TenKh);
                command.Parameters.AddWithValue("SoDT", kh.SoDt);
                command.Parameters.AddWithValue("Email", kh.Email);
                command.Parameters.AddWithValue("DiaChi", kh.DiaChi);
                command.Connection = connection;
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }

            }
            catch (Exception a)
            {
                MessageBox.Show(a.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool XoaKhachHang(string MaKhachHang)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "XoaKH";
                command.Parameters.AddWithValue("MaKH", MaKhachHang);
                command.Connection = connection;
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception b)
            {
                MessageBox.Show(b.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public bool SuaKhachHang(DTO_KhachHang kh)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SuaKH";
                command.Parameters.AddWithValue("MaKH", kh.MaKh);
                command.Parameters.AddWithValue("TenKhach", kh.TenKh);
                command.Parameters.AddWithValue("SoDT", kh.SoDt);
                command.Parameters.AddWithValue("Email", kh.Email);
                command.Parameters.AddWithValue("DiaChi", kh.DiaChi);
                command.Connection = connection;
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch (Exception c)
            {
                MessageBox.Show(c.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }

        public DataTable TimKiemKhachHang(string TenKH)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "TimKiemKH";
                command.Parameters.AddWithValue("TenKhach", TenKH);
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
