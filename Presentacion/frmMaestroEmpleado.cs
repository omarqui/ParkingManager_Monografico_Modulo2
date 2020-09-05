using CapaNegocio;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class frmMaestroEmpleado : Form
    {
        public frmMaestroEmpleado()
        {
            InitializeComponent();
        }

        private void frmMaestroEmpleado_Load(object sender, EventArgs e)
        {
            //Colocar valores por defecto al cargar el formulario
            AsignarValoresPorDefecto();
        }

        private void AsignarValoresPorDefecto()
        {
            txtCedula.Clear();
            txtCelular.Clear();
            txtClave.Clear();
            txtCodigoEmpleado.Text = EmpleadoLG.ObtenerSecuencia().ToString(); ; //Debe haber un metodo que busque la secuencia y actualice este campo
            txtDireccion.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
            chkEstado.Checked = true;
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            try
            {
                EmpleadoLG empleadoLogica = new EmpleadoLG();
                Empleado empleadoEntidad = new Empleado();

                //Asignando valores recogidos del formulario a los atributos de la entidad
                empleadoEntidad.IdEmpleado = 0; //debe llenarse depende si es creado o modi
                empleadoEntidad.Nombre = txtNombre.Text.Trim();
                empleadoEntidad.Cedula = txtCedula.Text.Trim();
                empleadoEntidad.Celular = txtCelular.Text.Trim();
                empleadoEntidad.Direccion = txtDireccion.Text.Trim();
                empleadoEntidad.Clave = txtClave.Text.Trim();
                empleadoEntidad.Usuario = txtUsuario.Text.Trim();
                empleadoEntidad.EstaActivo = (chkEstado.Checked == true) ? true : false ;

                //Ejecutando metodo que guarda y/o actualiza y devuelve la cantidad de registros afectados
                
                DialogResult respuesta = MessageBox.Show("Seguro que desea guardar esta operación?", "GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                if (respuesta == DialogResult.Yes)
                {
                    int registroGuardado = empleadoLogica.GuardarEmpleado(empleadoEntidad);
                    if (registroGuardado >= 1)
                    {
                        MessageBox.Show("Guardado correctamente", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
                        AsignarValoresPorDefecto();
                    }

                }               
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            AsignarValoresPorDefecto();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que desea salir de esta ventana?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Dispose();
            }
        }
    }
}
