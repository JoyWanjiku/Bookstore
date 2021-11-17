using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;

namespace DatabasteknikBookStore
{
    class Connect
    {
        public SqlConnection con = new SqlConnection();
        public SqlCommand cmd = new SqlCommand();
        public string locate = @"Data Source=DESKTOP-1VTNQ7J;Initial Catalog=[Book Store];Integrated Security=True";

    }
}
