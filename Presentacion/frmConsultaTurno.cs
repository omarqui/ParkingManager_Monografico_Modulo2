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

namespace CapaPresentacion
{
    public partial class frmConsultaTurno : Form
    {
        public frmConsultaTurno()
        {
            InitializeComponent();
        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void frmConsultaTurno_Load(object sender, EventArgs e)
        {
            //BuscarTurnosConsulta();            
        }

        private void BuscarTurnosConsulta()
        {
            int? idTurno = null; 
            DateTime fechaDesde = dtpDesde.Value;
            DateTime fechaHasta = dtpHasta.Value;
            bool? estaAbierto = (rbAbierto.Checked) ? true : (rbCerrado.Checked) ? (bool?)false : null ;


            dtgvTurnos.Rows.Clear();

            DataTable datosTurnos = TurnoLG.BuscarTurnos(idTurno, fechaDesde, fechaHasta, estaAbierto);
            
            foreach (DataRow turnos in datosTurnos.Rows)
            {
                dtgvTurnos.Rows.Add((int)turnos["IdTurno"], 
                    (int)turnos["IdEmpleado"],
                    turnos["NombreEmpleado"],
                    Convert.ToDateTime(turnos["FechaApertura"]).ToShortDateString(),
                    ((DateTime)turnos["FechaCierre"] == Convert.ToDateTime("1900-01-01")) ? "N/A" : Convert.ToDateTime(turnos["FechaCierre"]).ToShortDateString(),
                    (decimal)turnos["MontoApertura"],
                    (decimal)turnos["MontoCobrado"],
                    (decimal)turnos["MontoEntregado"],
                    (decimal)turnos["MontoDiferencia"],
                    ((bool)turnos["EstaAbierto"] == true) ? "ABIERTO" : "CERRADO");
            }

        }

        private void btnBuscarConsultaTurno_Click(object sender, EventArgs e)
        {
            BuscarTurnosConsulta();
        }

        private void btnSalirConsultaTurno_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

        private void btnCierreConsultaTurno_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCierreTurno>.ejecutarSoloUnaVez(true);
        }

        private void btnCierreConsultaTurno_Click_1(object sender, EventArgs e)
        {
            int idturno;

            if (dtgvTurnos.Rows.Count > 0)
            {
                idturno = Convert.ToInt32(dtgvTurnos.CurrentRow.Cells["dgvIdTurno"].Value);

                try
                {
                    Turno turnoCerrar = TurnoLG.BuscarTurnoPorID(idturno);

                    if (turnoCerrar.EstaAbierto == true)
                    {
                        frmCierreTurno formularioCierreTurno = new frmCierreTurno(idturno);
                        formularioCierreTurno.ShowDialog(this);
                    }
                    else
                    {
                        MessageBox.Show("Este turno está cerrado, debe seleccionar un turno abierto.", "TURNO CERRADO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error: " + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
                
            }
            else
            {
                MessageBox.Show("Debe seleccionar un turno para poder cerrar.", "SELECCIONAR TURNO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
                        
            
            
        }
    }
}
