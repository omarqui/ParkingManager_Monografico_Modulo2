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
            TxtUsuarioLogin.Text = "admin";
            TxtPasswordLogin.Text = "123";
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
            string usuario = TxtUsuarioLogin.Text.Trim();
            string clave = TxtPasswordLogin.Text.Trim();
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
                    TxtUsuarioLogin.Focus();
                }

            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error al momento de verificar los datos suministrados \n " + error.Message, "AVISO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                TxtUsuarioLogin.Focus();
            }

        }
        private void textBox2_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                BtnEntrar.Focus();
            }
        }

        private void textBox1_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (e.KeyChar == Convert.ToChar(Keys.Enter))
            {
                TxtPasswordLogin.Focus();
            }
        }
    }
}
