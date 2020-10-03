﻿using CapaNegocio;
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
            _nombreReporte = "RptTurno";
            _fuentesDatos = new Dictionary<string, DataTable>
            {
                { "Configuracion", ConfiguracionLG.BuscarConfiguracion() },
                //{ "Tickets", UsoParqueoLN.BuscarTodos() },
                //{ "Ticket", UsoParqueoLN.BuscarTicketImpresion(1) },
                //{ "Turnos", TurnoLG.BuscarTurnos() },
                { "Turno", TurnoLG.BuscarTurnoImpresion(1) }
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
            reportViewer1.SetDisplayMode(DisplayMode.PrintLayout);
            reportViewer1.ZoomMode = ZoomMode.PageWidth;
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

        private void FrmReportViwer_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Escape)
            {
                Close();
            }
        }
    }
}
