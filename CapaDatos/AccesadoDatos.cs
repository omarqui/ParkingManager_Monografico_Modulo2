using System.Data.SqlClient;

namespace CapaDatos
{
    public class AccesadoDatos
    {
        protected bool esAutoManejado = true;
        protected SqlConnection Connection { get; set; }
    }
}