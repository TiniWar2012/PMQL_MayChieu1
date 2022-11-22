using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PMQL_MayChieu
{
    class KetNoi
    {
        private string con_str = "Data Source=TINI\\SQLEXPRESS;Initial Catalog=QlyMayChieuEPU;User ID=sa;Password=123456";
        public DataSet LayDuLieu( String query, String table_name)
        {
            SqlConnection conn = new SqlConnection(con_str);
            SqlDataAdapter da = new SqlDataAdapter(query, conn);
            DataSet ds = new DataSet();
            da.Fill(ds, table_name);
            return ds;

        }

        public bool ThucThi(String query)
        {
            SqlConnection conn = new SqlConnection(con_str);
            conn.Open();
            SqlCommand cmd = new SqlCommand(query, conn);
            int kt = cmd.ExecuteNonQuery();
            conn.Close();
            return kt > 0;
        }
    }
}
