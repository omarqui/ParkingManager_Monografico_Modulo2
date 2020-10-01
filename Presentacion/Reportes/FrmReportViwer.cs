using CapaNegocio;
using Microsoft.Reporting.WinForms;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion.Reportes
{
    public partial class FrmReportViwer : Form
    {
        private string _nombreReporte;
        Dictionary<string, DataTable> _fuentesDatos;

        public FrmReportViwer()
        {
            InitializeComponent();
            _nombreReporte = "RptListadoTicket";
            _fuentesDatos = new Dictionary<string, DataTable>
            {
                { "Configuracion", ConfiguracionLG.BuscarConfiguracion() },
                { "Tickets", UsoParqueoLN.BuscarTodos() },
                //{ "Turno", TurnoLG.BuscarTurnoImpresion(1) }
            };
        }

        public FrmReportViwer(
            string nombreReporte,
            Dictionary<string, DataTable> fuentesDatos)
        {
            InitializeComponent();
            _nombreReporte = nombreReporte;
            _fuentesDatos = fuentesDatos;
        }

        private void FrmReportViwer_Load(object sender, EventArgs e)
        {
            reportViewer1.LocalReport.ReportEmbeddedResource = $"CapaPresentacion.Reportes.{_nombreReporte}.rdlc";

            reportViewer1.LocalReport.DataSources.Clear();
            foreach (var fuente in _fuentesDatos)
            {
                ReportDataSource reportData = new ReportDataSource(fuente.Key, fuente.Value);
                reportViewer1.LocalReport.DataSources.Add(reportData);
            }

            //reportViewer1.LocalReport.Refresh();
            reportViewer1.RefreshReport();
        }
    }
}
