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
    public partial class frmTurno : Form
    {
        public frmTurno()
        {
            InitializeComponent();
        }

        private void btnRegistrarTurno_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void btnSalirTurno_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que sea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }
    }
}
