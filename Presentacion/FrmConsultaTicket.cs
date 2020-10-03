using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Entidades;
using CapaNegocio;
using static System.Windows.Forms.DataGrid;
using CapaPresentacion.Reportes;

namespace CapaPresentacion
{
    public partial class FrmConsultaTicket : Form
    {
        private const string REPRESENTACION_NULL = "N/A";
        private int indexResumen = -1;
        private object[] resumen;
        private DataTable datos;

        public FrmConsultaTicket()
        {
            InitializeComponent();
        }

        private void frmConsultaTurno_Load(object sender, EventArgs e)
        {
            //BuscarTurnosConsulta();

            dtpDesde.Value = DateTime.Today;
            dtpHasta.Value = DateTime.Today;

        }

        private void BuscarDatosConsulta()
        {
            dtgvTicket.Rows.Clear();
            indexResumen = -1;
            DateTime desde = dtpDesde.Value;
            DateTime hasta = dtpDesde.Value;
            string idCajero = txtIdCajero.Text == string.Empty ? "0" : txtIdCajero.Text;
            datos = UsoParqueoLN.BuscarTodos(
                desde: dtpDesde.Value,
                hasta: dtpHasta.Value,
                idCajero: int.Parse(idCajero),
                textoAbierto: txtTextoAbierto.Text);
            decimal sumTotal = 0;
            decimal sumDescuento = 0;
            decimal sumNeto = 0;
            decimal sumTiempo = 0;

            foreach (DataRow usoParqueo in datos.Rows)
            {

                bool estaAbierto = usoParqueo["FechaSalida"] as DateTime? == null;
                bool estaActivo = (bool)usoParqueo["EstaActivo"];

                string estado = estaActivo ? estaAbierto ? "ABIERTO" : "CERRADO" : "CANCELADO";

                decimal? total = (usoParqueo["Total"] as decimal?);
                decimal? descuento = (usoParqueo["Descuento"] as decimal?);
                decimal? neto = (usoParqueo["MontoCobrado"] as decimal?);
                decimal? tiempo = usoParqueo["TiempoUso"] as decimal?;

                sumTotal += total ?? 0;
                sumDescuento += descuento ?? 0;
                sumNeto += neto ?? 0;
                sumTiempo += tiempo ?? 0;
                DataTable dataTable = new DataTable();
                dtgvTicket.Rows.Add(usoParqueo["IdUso"] as int?,
                    (DateTime)usoParqueo["FechaEntrada"],
                    (usoParqueo["FechaSalida"] as DateTime?)?.ToString() ?? REPRESENTACION_NULL,
                    $"{(int)usoParqueo["IdEmpleado"]} - {usoParqueo["NombreEmpleado"]}",
                    tiempo?.Formatear() ?? REPRESENTACION_NULL,
                    total?.Formatear() ?? REPRESENTACION_NULL,
                    descuento?.Formatear() ?? REPRESENTACION_NULL,
                    neto?.Formatear() ?? REPRESENTACION_NULL,
                    estado
                    );

            }
            
            resumen = new object[] {
                "",
                "",
                "",
                "TOTALES:",
                sumTiempo.Formatear(),
                sumTotal.Formatear(),
                sumDescuento.Formatear(),
                sumNeto.Formatear(),
                ""
            };

            InsertarResumen();

            lblCantidad.Text = $"Cantidad: {datos.Rows.Count}";
        }

        private void InsertarResumen()
        {
            if (datos != null && datos.Rows.Count > 0 && indexResumen == -1)
                indexResumen = dtgvTicket.Rows.Add(resumen);
        }

        private void btnBuscarConsultaTurno_Click(object sender, EventArgs e)
        {
            BuscarDatosConsulta();
        }

        private void btnSalirConsultaTurno_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void dtgvTicket_MouseUp(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hti = ((DataGridView)sender).HitTest(e.X, e.Y);
            if (hti.Type == DataGridViewHitTestType.ColumnHeader)
                InsertarResumen();
        }

        private void dtgvTicket_MouseDown(object sender, MouseEventArgs e)
        {
            DataGridView.HitTestInfo hti = ((DataGridView)sender).HitTest(e.X, e.Y);
            if (hti.Type == DataGridViewHitTestType.ColumnHeader)
                EliminarResumen();

        }

        private void EliminarResumen()
        {
            if (dtgvTicket.Rows.Count > indexResumen && indexResumen >= 0)
                dtgvTicket.Rows.RemoveAt(indexResumen);

            indexResumen = -1;
        }

        private void btnImprimirConsultaTurno_Click(object sender, EventArgs e)
        {
            Reportero.Imprimir(new DatosReporte(
                "RptListadoTicket",
                new Dictionary<string, DataTable>()
                {
                    {"Tickets", datos }
                }));
        }

        private void btnCierreConsultaTurno_Click(object sender, EventArgs e)
        {
            if (dtgvTicket.SelectedCells.Count <= 0)
            {
                return;
            }
            int indiceFila = dtgvTicket.SelectedCells[0].RowIndex;
            int idTurno = (int)dtgvTicket.Rows[indiceFila].Cells[0].Value;
            if (!Globales.ObligarAperturaTurno()) return;
            FrmUsoDeParqueo frmUsoDeParqueo = new FrmUsoDeParqueo(idTurno);
            frmUsoDeParqueo.ShowDialog();
        }
    }
}
