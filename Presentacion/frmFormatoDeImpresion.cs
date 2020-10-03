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
    public enum TipoImpresion
    {
        Lista,
        Selecionado,
        NoImprimir
    }

    public partial class frmFormatoDeImpresion : Form
    {
        public TipoImpresion tipoImpresion;
        public frmFormatoDeImpresion()
        {
            InitializeComponent();
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (rbLista.Checked)
            {
                tipoImpresion = TipoImpresion.Lista;
            }
            else
            {
                tipoImpresion = TipoImpresion.Selecionado;
            }
            Close();
        }

        private void btnSalir_Click(object sender, EventArgs e)
        {
            tipoImpresion = TipoImpresion.NoImprimir;
            Close();
        }
    }
}
