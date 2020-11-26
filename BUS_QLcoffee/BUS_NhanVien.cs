using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Net;
using System.Net.Mail;
using System.Threading.Tasks;
using DAL_QLcoffee;
using DTO_QLcoffee;
using System.Security.Cryptography;
using System.Windows.Forms;

namespace BUS_QLcoffee
{
    public class BUS_NhanVien
    {
        DAL_NhanVien dAL_nhanvien = new DAL_NhanVien();

        public string encryption(string password)
        {
            MD5CryptoServiceProvider md5 = new MD5CryptoServiceProvider();
            byte[] encrypt;
            UTF8Encoding encode = new UTF8Encoding();
            //encrypt the given password string into Encrypted data
            encrypt = md5.ComputeHash(encode.GetBytes(password));
            StringBuilder encryptdata = new StringBuilder();
            // Create a new string using the encryted data
            for (int i = 0; i < encrypt.Length; i++)
            {
                encryptdata.Append(encrypt[i].ToString());
            }
            return encryptdata.ToString();
        }
        public bool NVDangNhap(DTO_NhanVien nv)
        {
            return dAL_nhanvien.DangNhap(nv);
        }
        public int NVVaiTro(DTO_NhanVien nv)
        {
            return dAL_nhanvien.VaiTroNV(nv);
        }
        public int NVTinhTrang(DTO_NhanVien nv)
        {
            return dAL_nhanvien.TinhTrang(nv);
        }
        public bool NVQuenMatKhau(DTO_NhanVien nv)
        {
            return dAL_nhanvien.QuenMatKhau(nv);
        }
        public bool NVTaoMatKhau(string email, string matkhau)
        {
            return dAL_nhanvien.TaoMatKhau(email, matkhau);
        }
        public bool NVDoiMatKhau(DTO_NhanVien nv, string matkhaucu, string matkhaumoi)
        {
            return dAL_nhanvien.DoiMatKhau(nv,matkhaucu,matkhaumoi);
        }
        public DataTable DSNhanVien()
        {
            return dAL_nhanvien.DSNhanVien();
        }
        public bool LuuNhanVien(DTO_NhanVien nv)
        {
            return dAL_nhanvien.LuuNhanVien(nv);
        }
        public bool XoaNhanVien(string Manv)
        {
            return dAL_nhanvien.XoaNhanVien(Manv);
        }
        public bool SuaNhanVien(DTO_NhanVien nv)
        {
            return dAL_nhanvien.SuaNhanVien(nv);
        }
        public DataTable TimKiemNhanVien(string nv)
        {
            return dAL_nhanvien.TimKiemNhanVien(nv);
        }
        public string RandomString(int size, bool lowerCase)
        {
            StringBuilder builder = new StringBuilder();
            Random random = new Random();
            char ch;
            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToInt32(Math.Floor(26 * random.NextDouble() + 65)));
                builder.Append(ch);
            }
            if (lowerCase)
                return builder.ToString().ToLower();
            return builder.ToString();
        }

        public int RamdomNumber(int min, int max)
        {
            Random random = new Random();
            return random.Next(min, max);
        }

        public void SendEmail(string email, string matKhau)
        {
            try
            {
                // Now we must create a new Smtop clients to send our email
                SmtpClient client = new SmtpClient("smtp.gmail.com", 25); //smtp.gmail.com // For Gmail
                // Authentication
                // This is where the valid email account comes into play. You must have a valid email
                // account(with password) to give our program a place to send the mail from.
                NetworkCredential cred = new NetworkCredential("hungplhaihuoc1999@gmail.com", "hunghaihuoc1999@1999");
                //To send an email we must first create a new mailMessage(an email) to send.
                MailMessage Msg = new MailMessage();
                // Send e-mail address
                Msg.From = new MailAddress("hungplhaihuoc1999@gmail.com");// Nothing But Above Credentials or your credentials (*********@gmail.com)
                // Rcipient e-mail address.
                Msg.To.Add(email);
                // Assign the subject of our message.
                Msg.Subject = "Bạn đã sử dụng tính năng quên mật khẩu";
                // Create the content(body) of our message.
                Msg.Body = "Chào anh/chị. Mật khẩu mới truy cập phần mềm là: " + matKhau;
                // Send our account login details to the client.
                client.Credentials = cred;
                // Enabling SSL(Secure Sockets Layer, encyription) is required by most email providers to send mail
                client.EnableSsl = true;
                client.Send(Msg);//Send our email;
                // confirmation After Click the Button
                MessageBox.Show("Một Email phục hồi mật khẩu đã được gửi tới bạn!");
            }
            catch (Exception ex)
            {
                // If Mail doesn't send error message will be displayed
                MessageBox.Show(ex.Message);
            }
        }
    }
}
