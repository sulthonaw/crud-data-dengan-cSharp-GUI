using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataMahasiswa
{
    internal class KoneksiDatabase
    {
        public SqlConnection GetConnectionDBSekolah()
        {
            SqlConnection conn = new SqlConnection();
            conn.ConnectionString = "Data Source=SULTHON\\SQLEXPRESS;Initial Catalog=db_sekolah;Integrated Security=True";
            return conn;
        }
    }
}
