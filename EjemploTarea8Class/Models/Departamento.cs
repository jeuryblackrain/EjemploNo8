using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;

namespace EjemploNo8.Models
{
    public class Departamento
    {
        public int DepartamentoID { get; set; }
        public string Descripcion { get; set; }

        public ICollection<Registro> Registros { get; set; }


    }
}