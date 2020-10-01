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
        private int _idTurnoCerrar;
        public frmCierreTurno()
        {
            InitializeComponent();
            _idTurnoCerrar = Globales.Turno.IdTurno;
        }

        public frmCierreTurno(int idTurnoCerrar)
        {
            InitializeComponent();
            _idTurnoCerrar = idTurnoCerrar;
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
                    turnoCerrar.TotalEnCaja = Convert.ToDecimal(txtTotalEnCaja.Text);

                    int registroAfectado = TurnoLG.CerrarTurno(turnoCerrar);
                    if (registroAfectado > 0)
                    {
                        MessageBox.Show("Turno cerrado correctamente", "TURNO CERRADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                        this.Dispose();
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
                    Turno turnoAbierto = TurnoLG.BuscarTurnoPorID(_idTurnoCerrar);
                    Empleado empleadoTurnoAbierto = EmpleadoLG.BuscarEmpleado(turnoAbierto.IdEmpleado);

                    decimal sumatoriaCobradaTurno = TurnoLG.BuscarSumatoriaCierreTurno(_idTurnoCerrar);

                    txtCodigoTurno.Text = turnoAbierto.IdTurno.ToString();
                    txtCodigoEmpleadoTurno.Text = turnoAbierto.IdEmpleado.ToString();
                    txtMontoApertura.Text = turnoAbierto.MontoApertura.Formatear();
                    txtMontoCobrado.Text = sumatoriaCobradaTurno.Formatear();
                    txtMontoDiferencia.Text = turnoAbierto.MontoDiferencia.Formatear();
                    txtMontoEntregado.Text = "0.00";
                    txtNombreEmpleado.Text = empleadoTurnoAbierto.Nombre;
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error: \n" + error.Message);                
            }
        }

        /// <summary>
        /// Fucion que se encarga de realziar los calculos del turno con los datos suministrados por el usuario
        /// </summary>
        /// <param name="montoApertura"> Monto que representa el fondo de caja en la apertura del turno</param>
        /// <param name="montoCobrado"> Representa la sumatoria de todos los tickets cobrados en el turno correspondiente </param>
        /// <param name="montoEntregado"> Representa el monto colocado por el usuario segun el conteo realizado en la caja al momento de cuadrar</param>
        private void CalcularDatosTurno(decimal montoApertura, decimal montoCobrado, decimal montoEntregado)
        {
            decimal montoDiferencia, montoTotalEnCaja;

            montoDiferencia = montoEntregado - montoCobrado;
            montoTotalEnCaja = montoApertura + montoCobrado; //Este valor se puede colocar en un nuevo Textbox (incluso guardarlo en la base de datos como alternativa a mayor control )

            //Asignando los valores acalculados a los textbox

            txtMontoDiferencia.Text = montoDiferencia.Formatear();
            txtTotalEnCaja.Text = montoTotalEnCaja.Formatear();
            
        }

        private void txtMontoEntregado_TextChanged(object sender, EventArgs e)
        {
            if (txtMontoEntregado.Text == "")
            {
                txtMontoEntregado.Text = "0.00";
            }

            decimal montoApertura, montoCobrado, montoDiferencia, montoEntregado;

            montoApertura = Convert.ToDecimal(txtMontoApertura.Text);
            montoCobrado = Convert.ToDecimal(txtMontoCobrado.Text);
            montoEntregado = Convert.ToDecimal(txtMontoEntregado.Text);

            CalcularDatosTurno(montoApertura, montoCobrado, montoEntregado);
        }

        private void txtMontoEntregado_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.SoloNumeros();
        }
    }
}
