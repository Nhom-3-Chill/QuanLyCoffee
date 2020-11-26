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
    public class DAL_NhanVien : DataConnect
    {
        public bool DangNhap(DTO_NhanVien nv)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DangNhap";
                command.Connection = connection;
                command.Parameters.AddWithValue("@email", nv.Email);
                command.Parameters.AddWithValue("@matkhau", nv.MatKhau);
                if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public int VaiTroNV(DTO_NhanVien nv)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "VaiTro";
                command.Connection = connection;
                command.Parameters.AddWithValue("@email", nv.Email);
                if (command.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
            }
            finally
            {
                connection.Close();
            }
            return 0;
        }
        public int TinhTrang(DTO_NhanVien nv)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "TinhTrang";
                command.Connection = connection;
                command.Parameters.AddWithValue("@email", nv.Email);
                if (command.ExecuteNonQuery() > 0)
                {
                    return 1;
                }
            }
            finally
            {
                connection.Close();
            }
            return 0;
        }
        public bool QuenMatKhau(DTO_NhanVien nv)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "QuenMatKhau";
                command.Connection = connection;
                command.Parameters.AddWithValue("@email", nv.Email);
                if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public bool TaoMatKhau (string email, string matkhau)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "TaoMatKhau";
                command.Connection = connection;
                command.Parameters.AddWithValue("@email", email);
                command.Parameters.AddWithValue("@matkhau", matkhau);
                if (command.ExecuteNonQuery() > 0)
                {
                    return true;
                }
            }
            catch(Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public bool DoiMatKhau(DTO_NhanVien nv, string matkhaucu, string matkhaumoi)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DoiMatKhau";
                command.Connection = connection;
                command.Parameters.AddWithValue("@email", nv.Email);
                command.Parameters.AddWithValue("@matkhaucu", matkhaucu);
                command.Parameters.AddWithValue("@matkhaumoi", matkhaumoi);
                if (Convert.ToInt32(command.ExecuteScalar()) > 0)
                {
                    return true;
                }
            }
            catch (Exception x)
            {
                MessageBox.Show(x.Message);
            }
            finally
            {
                connection.Close();
            }
            return false;
        }
        public DataTable DSNhanVien()
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "DanhSachNV";
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

        public bool LuuNhanVien(DTO_NhanVien nv)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "LuuNV";
                command.Parameters.AddWithValue("@manv", nv.MaNV);
                command.Parameters.AddWithValue("@email", nv.Email);
                command.Parameters.AddWithValue("@tennv", nv.TenNV);
                command.Parameters.AddWithValue("@diachi", nv.DiaChi);
                command.Parameters.AddWithValue("@vaitro", nv.VaiTro);
                command.Parameters.AddWithValue("@tinhtrang", nv.TinhTrang);
                command.Parameters.AddWithValue("@sdt", nv.SoDT);
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

        public bool XoaNhanVien(string MaNhanVien)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "XoaNV";
                command.Parameters.AddWithValue("@manv", MaNhanVien);
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

        public bool SuaNhanVien(DTO_NhanVien nv)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "SuaNV";
                command.Parameters.AddWithValue("@manv", nv.MaNV);
                command.Parameters.AddWithValue("@email", nv.Email);
                command.Parameters.AddWithValue("@tennv", nv.TenNV);
                command.Parameters.AddWithValue("@diachi", nv.DiaChi);
                command.Parameters.AddWithValue("@vaitro", nv.VaiTro);
                command.Parameters.AddWithValue("@tinhtrang", nv.TinhTrang);
                command.Parameters.AddWithValue("@sdt", nv.SoDT);
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

        public DataTable TimKiemNhanVien(string TenNV)
        {
            try
            {
                connection.Open();
                SqlCommand command = new SqlCommand();
                command.CommandType = CommandType.StoredProcedure;
                command.CommandText = "TimKiemNV";
                command.Parameters.AddWithValue("@tennv", TenNV);
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
