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
    public partial class frmConfiguracion : Form
    {
        public frmConfiguracion()
        {
            InitializeComponent();
        }

        private void frmConfiguracion_Load(object sender, EventArgs e)
        {
            CargarConfiguracionSistema();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que desea salir de esta ventana?, se descartarán los cambios realizados", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Close();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreEmpresa.Text == "")
            {
                MessageBox.Show("El campo Nombre de Empresa no debe estar vacío", "CAMPOS SIN INFORMACÍON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreEmpresa.Focus();
            }
            else
            {
                try
                {
                    Configuracion configuracionEntidad = new Configuracion();

                    //Recolectando los datos que van a ser guardados
                    configuracionEntidad.NombreEmpresa = txtNombreEmpresa.Text.Trim();
                    configuracionEntidad.DireccionEmpresa = txtDireccionEmpresa.Text.Trim();
                    configuracionEntidad.TelefonoEmpresa = txtTelefonoEmpresa.Text.Trim();
                    configuracionEntidad.CantidadParqueos = Convert.ToInt32(nudCantidadParqueos.Value);
                    configuracionEntidad.PrecioPorHora = Convert.ToDecimal(txtPrecioPorHora.Text);

                    //Ejecutando la funcion que guarda la configuracion
                    int cantidadRegistrosAfectados = ConfiguracionLG.GuardarConfiguracion(configuracionEntidad);
                    if (cantidadRegistrosAfectados >= 1)
                    {
                        Globales.LimpiarConfiguracion();
                        MessageBox.Show("Guardado con éxito", "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                }
                catch (Exception error)
                {
                    MessageBox.Show("No se ha guardado la configuración, verifique los detalles siguientes: \n" + error.Message, "GUARDADO", MessageBoxButtons.OK, MessageBoxIcon.Information);                    
                }
            }
        }

        private void CargarConfiguracionSistema()
        {
            Configuracion configuracionSistema = ConfiguracionLG.BuscarConfiguracionSistema();
            txtNombreEmpresa.Text = configuracionSistema.NombreEmpresa;
            txtDireccionEmpresa.Text = configuracionSistema.DireccionEmpresa;
            txtTelefonoEmpresa.Text = configuracionSistema.TelefonoEmpresa;
            txtPrecioPorHora.Text = configuracionSistema.PrecioPorHora.ToString();
            nudCantidadParqueos.Value = configuracionSistema.CantidadParqueos;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que sea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {

                this.Dispose();
            }
        }

        private void txtPrecioPorHora_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.SoloNumeros();
        }
    }
}
