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
using System.Text.RegularExpressions;
using CapaPresentacion.Reportes;

namespace CapaPresentacion
{
    public partial class frmCierreTurno : Form
    {
        private int _idTurnoCerrar;

        private const char SignoDecimal = '.'; // Carácter separador decimal        
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
                        Globales.LimpiarTurno();
                        Reportero.Imprimir(TurnoLG.ImprimirTurno(turnoCerrar.IdTurno));
                        Dispose();
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("HA OCURRIDO UN ERROR Y LA OPERACIÓN NO HA SIDO COMPLETADA: \r "+ error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
                Turno turnoACerrar = TurnoLG.BuscarTurnoPorID(_idTurnoCerrar);
                if (turnoACerrar == null)
                {
                    MessageBox.Show("No hay turno a cerrar", "Aviso", MessageBoxButtons.OK);
                    return;
                }
                
                Empleado empleadoTurnoAbierto = EmpleadoLG.BuscarEmpleado(turnoACerrar.IdEmpleado);

                decimal sumatoriaCobradaTurno = TurnoLG.BuscarSumatoriaCierreTurno(_idTurnoCerrar);

                txtCodigoTurno.Text = turnoACerrar.IdTurno.ToString();
                txtCodigoEmpleadoTurno.Text = turnoACerrar.IdEmpleado.ToString();
                txtMontoApertura.Text = turnoACerrar.MontoApertura.Formatear();
                dtpFechaApertura.Value = turnoACerrar.FechaApertura;
                txtMontoCobrado.Text = sumatoriaCobradaTurno.Formatear();
                txtMontoDiferencia.Text = turnoACerrar.MontoDiferencia.Formatear();
                txtMontoEntregado.Text = "0.00";
                txtNombreEmpleado.Text = empleadoTurnoAbierto.Nombre;
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

            montoDiferencia =  Convert.ToDecimal(montoEntregado.Formatear()) - (Convert.ToDecimal(montoCobrado.Formatear()) + Convert.ToDecimal(montoApertura.Formatear()));
            montoTotalEnCaja = Convert.ToDecimal(montoApertura) + Convert.ToDecimal(montoCobrado); 

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

            decimal montoApertura, montoCobrado, montoEntregado;

            montoApertura = Convert.ToDecimal(txtMontoApertura.Text);
            montoCobrado = Convert.ToDecimal(txtMontoCobrado.Text);
            montoEntregado = Convert.ToDecimal(txtMontoEntregado.Text);            

            CalcularDatosTurno(montoApertura, montoCobrado, montoEntregado);
        }

        private void txtMontoEntregado_KeyPress(object sender, KeyPressEventArgs e)
        {
            var textBox = (TextBox)sender;
            // Si el carácter pulsado no es un carácter válido se anula
            e.Handled = !char.IsDigit(e.KeyChar) // No es dígito
                        && !char.IsControl(e.KeyChar) // No es carácter de control (backspace)
                        && (e.KeyChar != SignoDecimal // No es signo decimal o es la 1ª posición o ya hay un signo decimal
                            || textBox.SelectionStart == 0
                            || textBox.Text.Contains(SignoDecimal));
        }

        private void txtMontoEntregado_Leave(object sender, EventArgs e)
        {
            txtMontoEntregado.Text = Convert.ToDecimal(txtMontoEntregado.Text).Formatear();
        }
    }
}
