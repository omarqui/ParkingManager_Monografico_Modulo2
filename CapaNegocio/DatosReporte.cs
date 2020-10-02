using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaNegocio
{
    public class DatosReporte
    {
        public string NombreReporte { get; set; }
        public Dictionary<String,DataTable> Datos { get; set; }

        public DatosReporte(string nombreReporte, Dictionary<string, DataTable> datos)
        {
            NombreReporte = nombreReporte;
            Datos = datos;
        }

        public DatosReporte()
        {
        }
    }
}
