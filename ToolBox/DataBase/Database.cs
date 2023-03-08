using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;

namespace ToolBox.ToolBox.DataBase
{
    public class Database
    {
        public Database() 
        { 
            MySqlConnection mconect = new MySqlConnection("server=localhost;user=root;database=cm4_5;");
            mconect.Open();
        }
    }
}
