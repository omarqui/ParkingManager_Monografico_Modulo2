﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;

namespace Entidades
{
    public class Empleado
    {
        public int IdEmpleado { get; set; }
        public string Cedula { get; set; }
        public string Nombre { get; set; }
        public string Direccion { get; set; }
        public string Celular { get; set; }
        public string Usuario { get; set; }
        public string Clave { get; set; }
        public bool PuedeHacerDescuento { get; set; }
        public bool EstaActivo { get; set; }

        public override string ToString()
        {
            return $"{Nombre} ({Usuario})";
        }
    }
}
