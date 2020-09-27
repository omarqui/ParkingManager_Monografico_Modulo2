using System.Data.SqlClient;

namespace CapaDatos
{
    public class AccesadorDatos
    {
        private SqlConnection conexion;
        protected bool esConexionAutoManejado = true;
        protected SqlConnection _conexion
        {
            get
            {
                if (conexion == null || conexion.ConnectionString == string.Empty)
                {
                    conexion = ManejadorConexion.Conexion;
                }
                return conexion;
            }
            set
            {
                conexion = value;
            }
        }

        public AccesadorDatos()
        {
            _conexion = ManejadorConexion.Conexion;
        }
    }
}