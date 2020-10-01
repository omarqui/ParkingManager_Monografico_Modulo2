using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;
using Entidades;

namespace CapaPresentacion
{
    public partial class frmTurno : Form
    {        

        public frmTurno()
        {
            InitializeComponent();
            CargarValoresInicioTurno();
        }

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {
            try
            {
                Turno turnoVerificar = TurnoLG.EstaTurnoAbiertoEmpleado(Globales.Empleado.IdEmpleado);

                if (turnoVerificar != null && turnoVerificar.IdEmpleado == Globales.Empleado.IdEmpleado && turnoVerificar.EstaAbierto == true)
                {
                    MessageBox.Show("Ya existe un turno abierto con este empleado, debe cerrarlo antes de poder crear otro turno con dicho empleado.", 
                        "AVISO IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
                else
                {
                    Turno turno = new Turno();
                    turno.IdEmpleado = Convert.ToInt32(txtCodigoEmpleadoTurno.Text);
                    turno.MontoApertura = Convert.ToDecimal(txtMontoApertura.Text);

                    int turnoGuardardo = TurnoLG.AperturarTurno(turno);
                    if (turnoGuardardo > 0)
                    {
                        MessageBox.Show("Turno creado correctamente", "TURNO CREADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error, los detalles se muestran a continuación:  \n" + error.Message,
                        "AVISO IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Error);               
            }                                  
            
            
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void frmTurno_Load(object sender, EventArgs e)
        {
            CargarValoresInicioTurno();
        }

        private void CargarValoresInicioTurno()
        {
            txtCodigoTurno.Text = TurnoLG.BuscarSecuenciaTurno().ToString();
            dtpFechaApertura.Value = DateTime.Now;
            dtpHora.Value = DateTime.Now;
            txtMontoApertura.Text = "0.00";

            //Cargando la informacion del usuario logueado y que esta abriendo turno
            Empleado empleado = EmpleadoLG.BuscarEmpleado(Globales.Empleado.IdEmpleado);//Cambiar el 1 por la variable que representa el ID del empleado logueado
            txtCodigoEmpleadoTurno.Text = empleado.IdEmpleado.ToString();
            txtNombreEmpleado.Text = empleado.Nombre;
        }

        private void btnSalirTurno_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que desea Cancelar", "CANCELAR", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
            if (respuesta == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void txtMontoApertura_Leave(object sender, EventArgs e)
        {
            if (txtMontoApertura.Text == "")
            {
                txtMontoApertura.Text = "0.00";
            }
        }

        private void txtMontoApertura_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.SoloNumeros();
        }

        private void txtNombreEmpleado_TextChanged(object sender, EventArgs e)
        {

        }
    }
}
