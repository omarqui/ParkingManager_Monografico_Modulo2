using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace CapaNegocio
{
    public class AbrirFormulario<tipo> where tipo : Form, new()
    {
        public static tipo instancia { get; set; }

        static public tipo ejecutarSoloUnaVez(bool esDialogo)
        {
            if (instancia == null || instancia.IsDisposed)
            {
                instancia = new tipo();
                if (esDialogo)
                    instancia.ShowDialog();
                else
                    instancia.Show();
            }
            else
            {
                instancia.BringToFront();
            }

            return instancia;
        }

        static public tipo ejecutarNuevo(bool esDialogo)
        {
            var nuevaInstancia = new tipo();
            if (esDialogo)
                nuevaInstancia.ShowDialog();
            else
                nuevaInstancia.Show();

            return nuevaInstancia;
        }
    }
}
