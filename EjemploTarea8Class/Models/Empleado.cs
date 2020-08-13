﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploNo8.Models
{
    public class Empleado
    {
        public int EmpleadoID { get; set; }
        public string Nombres { get; set; }
        public string Apellidos { get; set; }
        public Nullable<System.DateTime> Fecha_Ingreso { get; set; }
        public ICollection<Registro> Registros { get; set; }

    }
}