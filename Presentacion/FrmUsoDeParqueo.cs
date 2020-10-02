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
        UsoDeParqueo ticket;
        private decimal descuento;
        private decimal pagado;

        public FrmUsoDeParqueo()
        {
            InitializeComponent();
        }

        private void FrmUsoDeParqueo_Load(object sender, EventArgs e)
        {
            txtNumeroTicket.Focus();
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

            ticket.Cobro = new CobroParqueo(ticket, descuento, pagado);
            txtPagadoTab3.Text = ticket.Cobro.MontoPagado.Formatear();
            txtDescuentoTab3.Text = ticket.Cobro.Descuento.Formatear();
            txtNetoTab3.Text = ticket.Cobro.TotalCobrado.Formatear();
            txtDevueltaTab3.Text = ticket.Cobro.Devuelta.Formatear();

            return true;
        }

        private void textBox6_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox7_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox8_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox9_TextChanged(object sender, EventArgs e)
        {

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
            txtDescuentoTab2.Text = "0.00";
            txtNetoTab2.Text = ticket.Total.Formatear();

            txtNumeroTicketTab3.Text = ticket.IdUso.ToString();
            txtEntradaTab3.Text = ticket.FechaEntrada.ToString();
            txtSalidaTab3.Text = ticket.FechaSalida.ToString();
            txtPrecioXMinTab3.Text = ticket.PrecioPorMinuto.Formatear();
            txtTiempoTab3.Text = ticket.TiempoUso.Formatear();
            txtTotalTab3.Text = ticket.Total.Formatear();
            txtPagadoTab2.Text = "";

            return true;
        }

        private void label21_Click(object sender, EventArgs e)
        {

        }

        private void txtNetoTab2_TextChanged(object sender, EventArgs e)
        {
            btnDerecha.Enabled = txtNetoTab2.Text.Length > 0;
        }

        private void tabPage2_Click(object sender, EventArgs e)
        {

        }

        private void txtDescuentoTab2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTotalTab2_TextChanged(object sender, EventArgs e)
        {

        }

        private void btnDescuento_Click(object sender, EventArgs e)
        {

        }

        private void label22_Click(object sender, EventArgs e)
        {

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

            btnDerecha.Enabled = pagado >= ticket.Cobro.TotalCobrado;
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

        private void txtNumeroTicketTab2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtEntradaTab2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSalidaTab2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtTiempoTab2_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPrecioXMinTab2_TextChanged(object sender, EventArgs e)
        {

        }

        private void label12_Click(object sender, EventArgs e)
        {

        }

        private void label13_Click(object sender, EventArgs e)
        {

        }

        private void label14_Click(object sender, EventArgs e)
        {

        }

        private void label15_Click(object sender, EventArgs e)
        {

        }

        private void textBox4_TextChanged(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void textBox5_TextChanged(object sender, EventArgs e)
        {

        }

        private void label17_Click(object sender, EventArgs e)
        {

        }

        private void textBox2_TextChanged(object sender, EventArgs e)
        {

        }

        private void textBox3_TextChanged(object sender, EventArgs e)
        {

        }
    }
    
}
