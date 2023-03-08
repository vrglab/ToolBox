using Microsoft.Data.SqlClient;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Runtime.InteropServices;
using ICSharpCode.Decompiler.IL;
using System.IO;

namespace ToolBox.ToolBox.DataBase
{
    public class Database
    {
        static MySqlConnection mconect;
        public Database() 
        { 
            
        }

        public static void OpenConnection()
        {
            mconect = new MySqlConnection("server=localhost;user=root;database=cm4_5;");
            mconect.Open();
        }

        public static object[] Querry(string querry)
        {
            MySqlCommand cmd = new MySqlCommand(querry, mconect);
            MySqlDataReader rdr = cmd.ExecuteReader();

            List<object> data = new List<object>();

            for (int i = 0; i < rdr.FieldCount; i++)
            {
                data.Add(rdr.GetValue(i));
            }

            return data.ToArray();
        }
    }
}
