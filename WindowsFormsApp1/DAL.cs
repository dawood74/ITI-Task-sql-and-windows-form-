using System;
using System.Collections.Generic;
using System.Data;
using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsFormsApp1
{
    public  class DAL
    { 

        static SqlConnection con = new SqlConnection("Data Source=DAWOOD\\SQLEXPRESS;Initial Catalog=taskcourse;Integrated Security=True;");

        public static DataTable Select(SqlCommand _cmd ) 
        
        {
            DataTable dt = new DataTable();
            _cmd.Connection = con;
            SqlDataAdapter adapter = new SqlDataAdapter(_cmd);
            adapter.Fill(dt);
            return dt;

        }

        public static int DML(SqlCommand _cmd) 
        
        {
            int result = 0;


            _cmd.Connection = con; 
            con.Open();

            result = _cmd.ExecuteNonQuery();

            con.Close();

            return result; 
        
        }




    }
}
