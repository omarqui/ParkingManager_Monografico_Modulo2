using CapaNegocio;
using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CapaPresentacion.Reportes
{
    public class Reportero
    {
        public static void Imprimir(
            string nombreReporte,
            Dictionary<string, DataTable> fuentesDatos)
        {
            fuentesDatos.Add("Configuracion", ConfiguracionLG.BuscarConfiguracion());
            FrmReportViwer reportViwer = new FrmReportViwer(nombreReporte, fuentesDatos);
            reportViwer.ShowDialog();
        }

        public static void Imprimir(DatosReporte datosReporte)
        {
            datosReporte.Datos.Add("Configuracion", ConfiguracionLG.BuscarConfiguracion());
            FrmReportViwer reportViwer = new FrmReportViwer(
                datosReporte.NombreReporte, 
                datosReporte.Datos);
            reportViwer.ShowDialog();
        }
    }
}
