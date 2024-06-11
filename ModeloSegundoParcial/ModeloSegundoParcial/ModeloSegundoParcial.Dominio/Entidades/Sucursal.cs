﻿using System;
using System.Collections.Generic;

namespace ModeloSegundoParcial.Dominio.Entidades
{
    public partial class Sucursal
    {
        public Sucursal()
        {
            Empleados = new HashSet<Empleado>();
        }

        public int IdSucursal { get; set; }
        public string Direccion { get; set; } = null!;
        public bool Eliminada { get; set; }

        public virtual ICollection<Empleado> Empleados { get; set; }
    }
}
