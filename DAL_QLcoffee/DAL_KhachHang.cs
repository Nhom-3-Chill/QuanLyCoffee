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
            //catch (Exception a)
            //{
            //    MessageBox.Show(a.Message);
            //}
            finally
            {
                connection.Close();
            }
        }
    }
}
