﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Entidades;
using CapaDatos;

namespace CapaNegocio
{
    public class ConfiguracionLG
    {
        private static Configuracion configuracion;

        public static Configuracion Configuracion
        {
            get
            {
                if (configuracion == null)
                {
                    configuracion = BuscarConfiguracionSistema();
                }

                return configuracion;
            }
        }
        public static int GuardarConfiguracion(Configuracion configuracion)
        {
            ConfiguracionAD funcionesConfiguracion = new ConfiguracionAD();
            return funcionesConfiguracion.Guardar(configuracion);
        }

        public static Configuracion BuscarConfiguracionSistema()
        {
            ConfiguracionAD funcionesConfiguracion = new ConfiguracionAD();
            return funcionesConfiguracion.Buscar();
        }
    }
}