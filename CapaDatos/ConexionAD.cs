using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class ConexionAD
    {
        public static string ObetenerConexion()
        {
            return @"Data Source=MRCODE\MRCODE2017;Initial Catalog=DB_ESTACIONAMIENTO; Integrated Security=True";
        }
    }
}
