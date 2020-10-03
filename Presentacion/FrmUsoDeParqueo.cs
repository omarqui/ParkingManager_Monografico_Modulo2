using CapaNegocio;
using CapaPresentacion.Reportes;
using Entidades;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Runtime.InteropServices.WindowsRuntime;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaPresentacion
{
    public partial class FrmUsoDeParqueo : Form
    {
        int _idTicket;
        UsoDeParqueo ticket;
        private decimal descuento;
        private decimal pagado;

        public FrmUsoDeParqueo()
        {
            InitializeComponent();
        }

        public FrmUsoDeParqueo(int idTicket)
        {
            InitializeComponent();
            _idTicket = idTicket;
        }

        private void FrmUsoDeParqueo_Load(object sender, EventArgs e)
        {
            if (_idTicket > 0)
            {
                txtNumeroTicket.Text = _idTicket.ToString();
                txtNumeroTicket_TextChanged(txtNumeroTicket, null);
                btnDerecha.PerformClick();
            } else
            {
                txtNumeroTicket.Focus();
            }
            btnDerecha_EnabledChanged(null, null);
            txtDescuentoTab2.Enabled = Globales.Empleado.PuedeHacerDescuento;
        }

        private void tabControl1_Selected(object sender, TabControlEventArgs e)
        {
            switch (((TabControl)sender).SelectedIndex)
            {
                case 0:
                    btnIzquierda.Text = "Cancelar";
                    btnDerecha.Text = "Siguiente";
                    txtNumeroTicket.Focus();
                    btnDerecha.Enabled = txtNumeroTicket.Text.Length > 0;
                    break;
                case 1:
                    btnIzquierda.Text = "Atras";
                    btnDerecha.Text = "Siguiente";
                    btnDerecha.Enabled = txtPagadoTab2.Text.Length > 0;
                    break;
                case 2:
                    btnIzquierda.Text = "Atras";
                    btnDerecha.Text = "Finalizar";
                    btnDerecha.Enabled = true;
                    break;
                default:
                    break;
            }
        }

        private void btnIzquierda_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    Close();
                    break;
                case 1:
                    tabControl1.SelectedIndex--;
                    txtNumeroTicket.Focus();
                    break;
                case 2:
                    tabControl1.SelectedIndex--;
                    txtPagadoTab2.Focus();
                    break;
                default:
                    break;
            }
        }

        private void btnDerecha_Click(object sender, EventArgs e)
        {
            switch (tabControl1.SelectedIndex)
            {
                case 0:
                    try
                    {
                        if (!int.TryParse(txtNumeroTicket.Text, out int idTicket))
                        {
                            return;
                        }

                        CargarTurno(idTicket);
                        tabControl1.SelectedIndex++;
                        txtPagadoTab2.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txtNumeroTicket.Clear();
                    }

                    break;
                case 1:
                    try
                    {
                        if (!CargarPago())
                        {
                            return;
                        }
                        tabControl1.SelectedIndex++;
                        btnDerecha.Focus();
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                        txtPagadoTab2.Clear();
                    }

                    break;
                case 2:
                    try
                    {
                        bool guardo = UsoParqueoLN.CerrarUso(ticket);
                        if (guardo)
                        {
                            Reportero.Imprimir(UsoParqueoLN.ImprimirCobroTicket(ticket.IdUso));
                            Close();
                        }
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show(ex.Message);
                    }
                    break;
                default:
                    break;
            }
        }

        private bool CargarPago()
        {
            if (!decimal.TryParse(txtPagadoTab2.Text, out decimal pagado))
            {
                return false;
            }
            if (!decimal.TryParse(txtDescuentoTab2.Text, out decimal descuento))
            {
                return false;
            }

            ticket.Cobro = new CobroParqueo(ticket, descuento, pagado, Globales.Turno.IdTurno);
            txtPagadoTab3.Text = ticket.Cobro.MontoPagado.Formatear();
            txtDescuentoTab3.Text = ticket.Cobro.Descuento.Formatear();
            txtNetoTab3.Text = ticket.Cobro.TotalCobrado.Formatear();
            txtDevueltaTab3.Text = ticket.Cobro.Devuelta.Formatear();

            return true;
        }

        private void txtNumeroTicket_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.SoloNumeros();
            e.ClickBotonConEnter(btnDerecha);
        }

        private bool CargarTurno(int idTicket)
        {
            ticket = UsoParqueoLN.BuscarPorIDParaCerrar(idTicket);
            
            txtNumeroTicketTab2.Text = ticket.IdUso.ToString();
            txtEntradaTab2.Text = ticket.FechaEntrada.ToString();
            txtSalidaTab2.Text = ticket.FechaSalida.ToString();
            txtPrecioXMinTab2.Text = ticket.PrecioPorMinuto.Formatear();
            txtTiempoTab2.Text = ticket.TiempoUso.Formatear();
            txtTotalTab2.Text = ticket.Total.Formatear();
            txtDescuentoTab2.Text = descuento.Formatear();
            txtNetoTab2.Text = (ticket.Total - descuento).Formatear();

            txtNumeroTicketTab3.Text = ticket.IdUso.ToString();
            txtEntradaTab3.Text = ticket.FechaEntrada.ToString();
            txtSalidaTab3.Text = ticket.FechaSalida.ToString();
            txtPrecioXMinTab3.Text = ticket.PrecioPorMinuto.Formatear();
            txtTiempoTab3.Text = ticket.TiempoUso.Formatear();
            txtTotalTab3.Text = ticket.Total.Formatear();
            txtDescuentoTab3.Text = descuento.Formatear();
            txtPagadoTab2.Text = "";

            return true;
        }

        private void txtNetoTab2_TextChanged(object sender, EventArgs e)
        {
            btnDerecha.Enabled = txtNetoTab2.Text.Length > 0;
        }

        private void txtNumeroTicket_TextChanged(object sender, EventArgs e)
        {
            btnDerecha.Enabled = txtNumeroTicket.Text.Length > 0;
        }

        private void txtPagadoTab2_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtPagadoTab2.Text, out decimal pagado))
            {
                return;
            }

            btnDerecha.Enabled = pagado >= (ticket.Total - descuento);
        }

        private void txtPagadoTab2_KeyPress(object sender, KeyPressEventArgs e)
        {
            e.SoloNumeros();
            e.ClickBotonConEnter(btnDerecha);
        }

        private void FrmUsoDeParqueo_Shown(object sender, EventArgs e)
        {
            txtNumeroTicket.Focus();
        }

        private void btnDerecha_EnabledChanged(object sender, EventArgs e)
        {
            if (btnDerecha.Enabled)
            {
                btnDerecha.BackColor = Color.FromArgb(240, 36, 85);
                btnDerecha.ForeColor = Color.White;
            } else
            {
                btnDerecha.BackColor = Color.FromArgb(247, 136, 162);
                btnDerecha.ForeColor = Color.Gainsboro;
            }
        }

        private void txtDescuentoTab2_TextChanged(object sender, EventArgs e)
        {
            if (!decimal.TryParse(txtDescuentoTab2.Text, out descuento))
            {
                return;
            }

            txtNetoTab2.Text = (ticket.Total - descuento).Formatear();
        }
    }
    
}
