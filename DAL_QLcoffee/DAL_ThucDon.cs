using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DAL_QLcoffee
{
    public class DAL_ThucDon : DataConnect
    {
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
            //catch(Exception e)
            //{
            //    //MessageBox.Show(e.Message);
            //    Console.WriteLine(e.Message);
            //}
            finally
            {
                connection.Close();
            }
        }
    }
}
