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
    }
}
