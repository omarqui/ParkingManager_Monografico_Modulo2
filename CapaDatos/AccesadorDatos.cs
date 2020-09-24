using System.Data.SqlClient;

namespace CapaDatos
{
    public class AccesadorDatos
    {
        protected bool esConexionAutoManejado = true;
        protected SqlConnection _conexion { get; set; }
    }
}