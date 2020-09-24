using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Data.SqlClient;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using CapaNegocio;

namespace CapaPresentacion
{
    public partial class frmConsultaEmpleado : Form
    {
        public frmConsultaEmpleado()
        {
            InitializeComponent();
        }

        private void frmConsultaEmpleado_Load(object sender, EventArgs e)
        {
            LlenarInformacionDataDrid();            
        }

        /// <summary>
        /// Este metodo llena la informacion del grid
        /// </summary>
        private void LlenarInformacionDataDrid()
        {
            //Limpar el grid
            dtgvEmpleado.Rows.Clear();

            DataTable datosEmpleado = EmpleadoLG.BuscarTodosEmpleados();

            foreach (DataRow registro in datosEmpleado.Rows)
            {
                dtgvEmpleado.Rows.Add(((int)registro["IdEmpleado"]).ToString(),
                    (registro["Nombre"]).ToString(),
                    (registro["Usuario"]).ToString(),
                    ((bool)registro["EstaActivo"] == true) ? "Activo" : "Inactivo");
            }
        }

        private void btnEditarEmpleado_Click(object sender, EventArgs e)
        {
            int idEmpleado = Convert.ToInt32(dtgvEmpleado.CurrentRow.Cells["dgvIdEmpleado"].Value);
            
            frmMaestroEmpleado maestroEmpleado = new frmMaestroEmpleado(idEmpleado);
            maestroEmpleado.estaEditando = true;
            maestroEmpleado.ShowDialog(this);
            LlenarInformacionDataDrid();

        }

        private void btnNuevoEmpleado_Click(object sender, EventArgs e)
        {
            frmMaestroEmpleado maestroEmpleado = new frmMaestroEmpleado();
            maestroEmpleado.estaEditando = false;
            maestroEmpleado.ShowDialog(this);
            LlenarInformacionDataDrid();
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
