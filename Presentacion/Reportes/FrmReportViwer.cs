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
        public FrmReportViwer()
        {
            InitializeComponent();
        }

        private void FrmReportViwer_Load(object sender, EventArgs e)
        {
            this.reportViewer1.LocalReport.ReportEmbeddedResource = "CapaPresentacion.Reportes.RptGeneracionTicket.rdlc";

            ReportDataSource configuracion = new ReportDataSource("Configuracion", ConfiguracionLG.BuscarConfiguracion());
            ReportDataSource cobro = new ReportDataSource("Ticket", UsoParqueoLN.BuscarTicketImpresion(1));
            reportViewer1.LocalReport.DataSources.Clear();
            reportViewer1.LocalReport.DataSources.Add(configuracion);
            reportViewer1.LocalReport.DataSources.Add(cobro);

            reportViewer1.LocalReport.Refresh();

            this.reportViewer1.RefreshReport();
        }
    }
}
