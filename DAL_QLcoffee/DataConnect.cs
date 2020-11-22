using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace DAL_QLcoffee
{
    public class DataConnect
    {
        SqlConnection connection = new SqlConnection(@"Data Source=ADMIN;Initial Catalog=QuanLyCoffee;Integrated Security=True");
    }
}
