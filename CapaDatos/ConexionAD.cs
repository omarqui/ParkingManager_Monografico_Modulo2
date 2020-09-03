using System;
using System.Collections.Generic;
using System.Data.SqlClient;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaDatos
{
    class ConexionAD
    {
        //ASI ES COMO EL PROFESOR LO UTILIZA
        public static string ObetenerConexion()
        {
            return @"Data Source=MRCODE\MRCODE2017;Initial Catalog=DB_ESTACIONAMIENTO; Integrated Security=True";
        }


        //COMO YO LO USO 
        //public static string cadenaConexion { get; set; }
        ///// <summary>
        ///// Este metodo busca el archivo donde esta la conexion y la crear para poder ser utilizada
        ///// </summary>
        ///// <returns>Retorna un objeto de tipo conexion para ser usado por la app en los procesos donde sea solicitado</returns>
        //public static SqlConnection Abrir_Conexion()
        //{
        //    SqlConnection Conectar = new SqlConnection();

        //    StreamReader leerConexion = new StreamReader(@"C:\conexion_monografico\conexion.txt");
        //    cadenaConexion = leerConexion.ReadLine();

        //    Conectar = new SqlConnection(cadenaConexion);
        //    //Conectar = new SqlConnection("server=MRCODE\\MRCODE2017; database=BD_VENTAS_OFICIAL; user = monografico; password = clavesql");

        //    Conectar.Open();
        //    return Conectar;
        //}


        //PROTOTIPO PARA QUE FUNCIONE IGUAL QUE COMO EL PROFE LO USA PERO MAS DINAMICO Y NO HAYA QUE CAMBIAR CONEXIONES 

        //public static string cadenaConexion { get; set; }
        ///// <summary>
        ///// Este metodo busca el archivo donde esta la conexion y la crear para poder ser utilizada
        ///// </summary>
        ///// <returns>Retorna un objeto de tipo conexion para ser usado por la app en los procesos donde sea solicitado</returns>
        //public static string Abrir_Conexion()
        //{
        //    StreamReader leerConexion = new StreamReader(@"C:\conexion_monografico\conexion.txt");
        //    cadenaConexion = leerConexion.ReadLine();


        //    return cadenaConexion;
        //}
        /// pALOMO

    }
}
