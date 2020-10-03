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
        ///Esta propieda sirve para saber si se esta editando un empleado o no
        public bool estaEditando { get; set; }
        public int idEmpleadoEditar { get; set; }

        public frmMaestroEmpleado()
        {
            InitializeComponent();
            idEmpleadoEditar = 0;
            estaEditando = false;
        }

        /// <summary>
        /// Constructor que se utiliza cuando se llama el formulario para editar un Empleado
        /// </summary>
        public frmMaestroEmpleado(int idEmpleadoBusqueda)
        {
            InitializeComponent();
            idEmpleadoEditar = idEmpleadoBusqueda;
            CargarDatosEmpleado(idEmpleadoBusqueda);
        }

        private void frmMaestroEmpleado_Load(object sender, EventArgs e)
        {
            //Colocar valores por defecto al cargar el formulario
            if (estaEditando == false)
            {
                AsignarValoresPorDefecto();
            }
        }

        private void AsignarValoresPorDefecto()
        {
            txtCedula.Clear();
            txtCelular.Clear();
            txtClave.Clear();
            txtCodigoEmpleado.Text = EmpleadoLG.ObtenerSecuencia().ToString();
            txtDireccion.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
            chkEstado.Checked = true;
            estaEditando = false;
        }

        private void bntGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombre.Text == "")
            {
                MessageBox.Show("El campo Nombre no debe estar vacío, complete la información para continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombre.Focus();
            }
            else if (txtUsuario.Text == "")
            {
                MessageBox.Show("El campo Usuario no debe estar vacío, complete la información para continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtUsuario.Focus();
            }
            else if (txtClave.Text == "" && estaEditando == false)
            {
                MessageBox.Show("El campo Contraseña no debe estar vacío, complete la información para continuar.", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtClave.Focus();
            }
            
            else if (txtCodigoEmpleado.Text == "" || txtCodigoEmpleado.Text == "0")
            {
                MessageBox.Show("Por alguna razón el campo Código del Empleado está vacío, contacte su proveedor de software y notifique la situación actual.",
                    "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
            else
            {
                try
                {
                    DialogResult respuesta = MessageBox.Show("Seguro que desea guardar esta operación?", "GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

                    if (respuesta == DialogResult.Yes)
                    {
                        EmpleadoLG empleadoLogica = new EmpleadoLG();
                        Empleado empleadoEntidad = new Empleado();

                        //Asignando valores recogidos del formulario a los atributos de la entidad
                        empleadoEntidad.IdEmpleado = this.idEmpleadoEditar;   //debe llenarse depende si es creado o modifinando
                        empleadoEntidad.Nombre = txtNombre.Text.Trim();
                        empleadoEntidad.Cedula = txtCedula.Text.Trim();
                        empleadoEntidad.Celular = txtCelular.Text.Trim();
                        empleadoEntidad.Direccion = txtDireccion.Text.Trim();
                        empleadoEntidad.Clave = txtClave.Text.Trim();
                        empleadoEntidad.Usuario = txtUsuario.Text.Trim();
                        empleadoEntidad.EstaActivo = chkEstado.Checked;
                        empleadoEntidad.PuedeHacerDescuento = chkPuedeHacerDescuento.Checked;

                        //Ejecutando la funcion que guarda y/o actualiza. La funcion devuelve la cantidad de registros afectados
                        int registroGuardado = empleadoLogica.GuardarEmpleado(empleadoEntidad);
                        if (registroGuardado >= 1)
                        {
                            if (empleadoEntidad.IdEmpleado == Globales.Empleado.IdEmpleado)
                            {
                                Globales.LimpiarEmpleado();
                            }

                            MessageBox.Show("Guardado correctamente", "GUARDAR", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            if (this.idEmpleadoEditar == default)
                            {
                                AsignarValoresPorDefecto();
                            } else
                            {
                                Dispose();
                            }
                        }

                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("Ha ocurrido un error y los datos no se han guardado : " + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
                    ///throw;
                }
            }
        }

        private void btnNuevo_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Este proceso limpiará la pantalla, desea continuar?",
                "LIMPIAR LA PANTALLA", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                AsignarValoresPorDefecto();
            }
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que desea salir de esta ventana?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void CargarDatosEmpleado(int idEmpleado)
        {
            //Cargando el empleado en una variable tipo Entidad Empleado
            Empleado empleadoCargado = EmpleadoLG.BuscarEmpleado(idEmpleado);
            
            //Colocando los datos en cada campo que corresponde
            txtCodigoEmpleado.Text = empleadoCargado.IdEmpleado.ToString();
            txtNombre.Text = empleadoCargado.Nombre;
            txtCedula.Text = empleadoCargado.Cedula;
            txtCelular.Text = empleadoCargado.Celular;
            txtDireccion.Text = empleadoCargado.Direccion;
            txtUsuario.Text = empleadoCargado.Usuario;
            chkEstado.Checked = empleadoCargado.EstaActivo;
            txtClave.Visible = false;
            lblClave.Visible = false;
            chkPuedeHacerDescuento.Checked = empleadoCargado.PuedeHacerDescuento;
        }

        private void txtCedula_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.SoloNumeros();
        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void lblEstado_Click(object sender, EventArgs e)
        {

        }

        private void chkEstado_CheckedChanged(object sender, EventArgs e)
        {

        }

        private void chkPuedeHacerDescuento_CheckedChanged(object sender, EventArgs e)
        {

        }
    }
}
