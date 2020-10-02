using CapaNegocio;
using CapaPresentacion.Reportes;
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
using System.Globalization;
using System.Data.Odbc;
using Entidades;

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

            Turno turnoAbierto = TurnoLG.BuscarTurnoPorID(Globales.Turno.IdTurno);
            LblTurno.Text = turnoAbierto.IdTurno.ToString();

            RefrescarInformacionParqueos();
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
            ValidarParqueosDisponibles();
            hideSubMenu();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Turno turnoVerificar = TurnoLG.EstaTurnoAbiertoEmpleado(Globales.Empleado.IdEmpleado);

            if (turnoVerificar != null && turnoVerificar.IdEmpleado == Globales.Empleado.IdEmpleado && turnoVerificar.EstaAbierto == true)
            {
                MessageBox.Show("Ya existe un turno abierto con este empleado, debe cerrarlo antes de poder crear otro turno con dicho empleado.",
                    "AVISO IMPORTANTE", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AbrirFormulario<frmTurno>.ejecutarSoloUnaVez(true);
            }
            
            hideSubMenu();
        }

        private void BtnSubMenuProcesos_Click(object sender, EventArgs e)
        {
            Turno turno = TurnoLG.EstaTurnoAbiertoEmpleado(Globales.Empleado.IdEmpleado);
                        
            if (turno == null)
            {
                MessageBox.Show("No hay un turno abierto con este usuario", "TURNO", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }
            else
            {
                AbrirFormulario<frmCierreTurno>.ejecutarSoloUnaVez(true);
            }


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
            ValidarParqueosDisponibles();            
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
            LblFecha.Text = DateTime.Now.ToString("dd/MM/yyyy");
        }

        private void ValidarParqueosDisponibles()
        {
            try
            {
                if (UsoParqueoLN.BuscarCantidadParqueoDisponibles() < Globales.Configuracion.CantidadParqueos)
                {
                    var respuesta = MessageBox.Show("Seguro que desea generar un ticket?", "Pregunta", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
                    if (respuesta == DialogResult.No)
                    {
                        return;
                    }

                    UsoDeParqueo ticket = UsoParqueoLN.AperturarUso();
                    Reportero.Imprimir(UsoParqueoLN.ImprimirGeneracionTicket(ticket.IdUso));
                    RefrescarInformacionParqueos();
                }
                else
                {
                    MessageBox.Show("No hay parqueos disponibles, no será posible generar el ticket", "PARQUEOS AGOTADOS", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            catch (Exception error)
            {
                MessageBox.Show("Ha ocurrido un error : " + error.Message, "ERROR", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void timerParqueos_Tick(object sender, EventArgs e)
        {
            RefrescarInformacionParqueos();
        }

        private void RefrescarInformacionParqueos()
        {
            LblParqueos.Text = UsoParqueoLN.BuscarCantidadParqueoDisponibles().ToString();
            lblPDisponible.Text = (Globales.Configuracion.CantidadParqueos - UsoParqueoLN.BuscarCantidadParqueoDisponibles()).ToString();
        }
    }
}
