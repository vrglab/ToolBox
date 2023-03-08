using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ToolBox.ToolBox
{
    public class Utils
    {
        public static byte[] stringToBytearray(string data)
        {
            return Encoding.Default.GetBytes(data);
        }
    }
}
