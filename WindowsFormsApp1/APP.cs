using System;
using System.Collections.Generic;
using System.Data; 

using System.Data.SqlClient;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Xml.Linq;

namespace WindowsFormsApp1
{
    public class APP
    {
        public static string CurrentUserName { get; set; } 
        public static string Trackname { get; set; }
        public static string Phone { get; set; }

        public static string Address { get; set; }


        public static DataTable Getdata ( ) 
        
        {
           SqlCommand cmd = new SqlCommand ("select * from course");
            return DAL.Select ( cmd );


        }

        public static int Add(int _id, string _name)

        {

            
            SqlCommand cmd = new SqlCommand("insert into  course values (@id,@name)");

            cmd.Parameters.AddWithValue ( "id", _id );
            cmd.Parameters.AddWithValue( "name", _name );
            return DAL.DML(cmd);
       
        }

        public static int Delete(int _id) 
        
        {
            SqlCommand cmd = new SqlCommand("delete from course where id=@id");
            cmd.Parameters.AddWithValue("id", _id);
            return DAL.DML(cmd); 
        
        
        }

        public static int update(int _id , string _name) 
        
        {
            SqlCommand cmd = new SqlCommand("UPDATE course SET name = @name WHERE id = @id");
            cmd.Parameters.AddWithValue("id", _id);

            cmd.Parameters.AddWithValue("name", _name);
            return DAL.DML(cmd);

        }

        public static int edit(int _phone, string _address, string _track, string _username , byte[] _image )

        {


            SqlCommand cmd = new SqlCommand("update clinet set phone=@phone , track = @track , address = @address , image=@image where username=@username");

            cmd.Parameters.AddWithValue("phone", _phone);

            cmd.Parameters.AddWithValue("track", _track);
            cmd.Parameters.AddWithValue("address", _address);
            cmd.Parameters.AddWithValue("username", _username);
            cmd.Parameters.AddWithValue("image", _image);
            return DAL.DML(cmd);


        }
        public static byte[] GetImageByUsername(string _username)
        {
            SqlCommand cmd = new SqlCommand("SELECT image FROM clinet WHERE username=@username");
            cmd.Parameters.AddWithValue("username", _username);

            DataTable dt = DAL.Select(cmd);
            if (dt.Rows.Count > 0 && dt.Rows[0]["image"] != DBNull.Value)
            {
                return (byte[])dt.Rows[0]["image"];
            }

            return null;
        }

    }
}
