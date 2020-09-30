using CapaNegocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Globalization;
using System.Data.Odbc;

namespace CapaPresentacion
{
    public partial class FrmPrincipal : Form
    {
        public FrmPrincipal()
        {
            InitializeComponent();
            hideSubMenu();
        }

        private void hideSubMenu()
        {
            PnSubMenuProcesos.Visible = false;
            PnSubMenuConsulta.Visible = false;
            PnSubMenuReportes.Visible = false;

        }

        private void showSubMenu(Panel subMenu)
        {
            if (subMenu.Visible == false)
            {
                hideSubMenu();
                subMenu.Visible = true;
            }
            else
                subMenu.Visible = false;
        }

        private void FrmPrincipal_Load(object sender, EventArgs e)
        {
            timer1.Enabled = true;

            lblNombreUsuario.Text = Globales.Empleado.Usuario;

        }

        private void button1_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button14_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void BtnProcesos_Click(object sender, EventArgs e)
        {
            showSubMenu(PnSubMenuProcesos);
        }

        private void button4_Click(object sender, EventArgs e)
        {
            showSubMenu(PnSubMenuConsulta);
        }

        private void button8_Click(object sender, EventArgs e)
        {
            showSubMenu(PnSubMenuReportes);
        }

        private void BtnInicio_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button1_Click_1(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Seguro que desea generar un ticket?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            UsoParqueoLN.AperturarUso();


            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmTurno>.ejecutarSoloUnaVez(true);
            //frmTurno ControlTurno = new frmTurno();
            //ControlTurno.Show();
            hideSubMenu();
        }

        private void BtnSubMenuProcesos_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmCierreTurno>.ejecutarSoloUnaVez(true);
            hideSubMenu();
        }

        private void button5_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FrmUsoDeParqueo>.ejecutarNuevo(true);
            hideSubMenu();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmConsultaEmpleado>.ejecutarSoloUnaVez(true);

            //frmConsultaEmpleado ConsultarEmpleado = new frmConsultaEmpleado();
            //ConsultarEmpleado.Show();

            hideSubMenu();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button9_Click_1(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button10_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void button11_Click(object sender, EventArgs e)
        {
            hideSubMenu();
        }

        private void BtnSalirPrincipal_Click(object sender, EventArgs e)
        {
            DialogResult respuesta = MessageBox.Show("Seguro que sea Salir?", "SALIR", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                Application.Exit();
            }
        }

        private void button16_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmConfiguracion>.ejecutarSoloUnaVez(true);
            hideSubMenu();

            //frmConfiguracion ConfiguracionEmpresa = new frmConfiguracion();
            //ConfiguracionEmpresa.Show();
        }

        private void button12_Click(object sender, EventArgs e)
        {
            AbrirFormulario<frmConfiguracion>.ejecutarSoloUnaVez(true);
            hideSubMenu();

            //frmConfiguracion ConfiguracionEmpresa = new frmConfiguracion();
            //ConfiguracionEmpresa.Show();
        }
        private void btnGenerarTicket_Click(object sender, EventArgs e)
        {
            var respuesta = MessageBox.Show("Seguro que desea generar un ticket?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.No)
            {
                return;
            }

            UsoParqueoLN.AperturarUso();
        }

        private void btnCobrar_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmUsoDeParqueo>.ejecutarNuevo(true);
            hideSubMenu();
        }

        private void button1_Click_2(object sender, EventArgs e)
        {
            AbrirFormulario<frmConsultaTurno>.ejecutarSoloUnaVez(true);
            hideSubMenu();
        }
        private void btnCobrarTicket_Click(object sender, EventArgs e)
        {
            AbrirFormulario<FrmUsoDeParqueo>.ejecutarSoloUnaVez(true);
            hideSubMenu();
        }

        private void FrmPrincipal_KeyDown(object sender, KeyEventArgs e)
        {
            switch (e.KeyCode)
            {
                case Keys.F1:
                    MessageBox.Show("Trataste de ejecutar una accion con la tecla F1");
                    break;

                case Keys.F2:

                    var respuesta = MessageBox.Show("Seguro que desea generar un ticket?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.No)
                    {
                        return;
                    }
                    UsoParqueoLN.AperturarUso();
 
                    break;

                case Keys.F3:
                    AbrirFormulario<FrmUsoDeParqueo>.ejecutarNuevo(true);
                    break;               

                case Keys.F4:
                    AbrirFormulario<FrmConsultaTicket>.ejecutarSoloUnaVez(true);
                    break;

                default:
                    //MessageBox.Show("Esta tacla no esta registrada");
                    break;
            }
        }

        private void button14_Click_1(object sender, EventArgs e)
        {
            AbrirFormulario<FrmConsultaTicket>.ejecutarSoloUnaVez(true);
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            LblHora.Text = DateTime.Now.ToString("hh:mm:ss");
            LblFecha.Text = DateTime.Now.ToLongDateString();
        }
    }
}
