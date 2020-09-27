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
    public partial class frmCierreTurno : Form
    {
        public frmCierreTurno()
        {
            InitializeComponent();
        }

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que desea cerrar este turno?", "CERRAR TURNO", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                try
                {
                    Turno turnoCerrar = new Turno();
                    turnoCerrar.IdTurno = Convert.ToInt32(txtCodigoTurno.Text);
                    turnoCerrar.MontoCobrado = Convert.ToDecimal(txtMontoCobrado.Text);
                    turnoCerrar.MontoEntregado = Convert.ToDecimal(txtMontoEntregado.Text);
                    turnoCerrar.MontoDiferencia = Convert.ToDecimal(txtMontoDiferencia.Text);

                    int registroAfectado = TurnoLG.CerrarTurno(turnoCerrar);
                    if (registroAfectado > 0)
                    {
                        MessageBox.Show("Turno cerrado correctamente", "TURNO CERRADO", MessageBoxButtons.YesNo, MessageBoxIcon.Information);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("HA OCURRIDO UN ERROR Y LA OPERACIÓN NO HA SIDO COMPLETADA: \r "+ error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    throw;
                }
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirTurno_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que sea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {

                this.Dispose();
            }
        }

        private void frmCierreTurno_Load(object sender, EventArgs e)
        {
            BuscarInformacionTurnoAbierto();
        }

        private void BuscarInformacionTurnoAbierto()
        {
            try
            {
                if (Globales.Turno != null)
                {
                    Turno turnoAbierto = TurnoLG.BuscarTurnoPorID(Globales.Turno.IdTurno);
                    Empleado empleadoTurnoAbierto = EmpleadoLG.BuscarEmpleado(Globales.Turno.IdEmpleado);


                    txtCodigoTurno.Text = turnoAbierto.IdTurno.ToString();
                    txtCodigoEmpleadoTurno.Text = turnoAbierto.IdEmpleado.ToString();
                    txtMontoApertura.Text = turnoAbierto.MontoApertura.Formatear();
                    txtMontoCobrado.Text = turnoAbierto.MontoCobrado.Formatear();
                    txtMontoDiferencia.Text = turnoAbierto.MontoDiferencia.Formatear();
                    txtMontoEntregado.Text = "0.00";
                    txtNombreEmpleado.Text = empleadoTurnoAbierto.Nombre;

                }
            }
            catch (Exception)
            {

                throw;
            }
        }
    }
}
