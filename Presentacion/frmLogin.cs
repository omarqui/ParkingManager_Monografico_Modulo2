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

namespace CapaPresentacion
{
    public partial class frmLogin : Form
    {
        public frmLogin()
        {
            InitializeComponent();
        }

        private void frmLogin_Load(object sender, EventArgs e)
        {

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que sea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            string usuario = textBox1.Text.Trim();
            string clave = textBox2.Text.Trim();
            bool esValido = EmpleadoLG.EsUsuarioValido(usuario, clave);

            try
            {
                if (esValido)
                {
                    Globales.Empleado = EmpleadoLG.BuscarPorUsuario(usuario);
                    FrmPrincipal presentacion = new FrmPrincipal();

                    this.Hide();
                    presentacion.Show();
                }
                else
                {
                    MessageBox.Show("Usuario o contraseña incorrecto", "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                    textBox1.Focus();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al momento de verificar los datos suministrados \n " + error.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                textBox1.Focus();
            }

        }
    }
}
