using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data;
using System.Data.SqlClient;

namespace WindowsFormsApp1
{
    public class LoginDL
    
    {

        public static DataTable Login(string _username, string _password)
        {
            DataTable dt = new DataTable();

            SqlCommand cmd = new SqlCommand("SELECT * FROM clinet WHERE username = @username AND userpass = @userpass");
            cmd.Parameters.AddWithValue("@username", _username);
            cmd.Parameters.AddWithValue("@userpass", _password);

            return DAL.Select(cmd);
        }



    }

}
