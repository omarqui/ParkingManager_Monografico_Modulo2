using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace System.Windows.Forms
{
    static class ExtensionesFormulario
    {
        public static void SendFocusTo(this KeyPressEventArgs e, Control control)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    control.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        } 

        public static void ClickBotonConEnter(this KeyPressEventArgs e, Button button)
        {
            try
            {
                if (e.KeyChar == '\r')
                {
                    e.Handled = true;
                    button.PerformClick();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        static public void SoloNumeros(this KeyPressEventArgs e)
        {
            e.Handled = !char.IsDigit(e.KeyChar) && !char.IsControl(e.KeyChar);
        }

        static public void JustNumbers(this TextBox textBox)
        {
            if (Text.RegularExpressions.Regex.IsMatch(textBox.Text, "[^0-9]"))
            {
                textBox.Text = "";
            }
        }

        public static void ShowMessageBoxFromException(this Exception ex)
        {
            MessageBox.Show(ex.Message,"Error",MessageBoxButtons.OK,MessageBoxIcon.Error);
        }

        public static void ShowMessageBoxFromCustomException(this Exception ex)
        {
            MessageBox.Show(ex.Message, "Aviso", MessageBoxButtons.OK, MessageBoxIcon.Exclamation);
        }

        public static string Formatear(this decimal value, int decimales = 2)
        {
            return string.Format($"{{0:N{decimales}}}", value);
        }

    }    
}
