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
            DataTable datosTurnos = TurnoLG.BuscarTurnos();
            
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
    }
}
