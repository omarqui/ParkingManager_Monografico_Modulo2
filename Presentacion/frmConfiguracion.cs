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

        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que desea salir de esta ventana?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);

            if (respuesta == DialogResult.Yes)
            {
                this.Dispose();
            }
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            if (txtNombreEmpresa.Text == "")
            {
                MessageBox.Show("El campo Dirección de Empresas no debe estar vacío", "CAMPOS SIN INFORMACÍON", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                txtNombreEmpresa.Focus();
            }
            else
            {
                DialogResult repuesta = MessageBox.Show("Seguro que desea guardar esta operación?", "GUARDAR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                if (repuesta == DialogResult.Yes)
                {
                    Configuracion configuracion = new Configuracion();
                    
                }
            }
        }
    }
}
