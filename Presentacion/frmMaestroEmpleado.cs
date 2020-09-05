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

        }

        private void AsignarValoresPorDefecto()
        {
            txtCedula.Clear();
            txtCelular.Clear();
            txtClave.Clear();
            txtCodigoEmpleado.Clear(); //Debe haber un metodo que busque la secuencia y actualice este campo
            txtDireccion.Clear();
            //txtEstado.Clear();
            txtNombre.Clear();
            txtUsuario.Clear();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            Close();
        }
    }
}
