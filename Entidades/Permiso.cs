using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    class Permiso
    {
        public int IdEmpleado { get; set; }
        public int IdFormulario { get; set; }
        public bool TieneAcceso { get; set; }
    }
}
