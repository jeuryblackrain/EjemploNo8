using EjemploNo8.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace EjemploTarea8Class.DAL
{
    class CargarDatosDB : System.Data.Entity.DropCreateDatabaseIfModelChanges<EmpleadoContext>
    {
        protected override void Seed(EmpleadoContext context)
        {
            var Departamentos = new List<Departamento>
            {
                new Departamento{DepartamentoID=1,Descripcion="Programacion",},
                new Departamento{DepartamentoID=2,Descripcion="Recursos Humanos",},
                new Departamento{DepartamentoID=3,Descripcion="Mercadeo",}
            };
            Departamentos.ForEach(s => context.Departamentos.Add(s));
            context.SaveChanges();

            var Empleados = new List<Empleado>
            {
                new Empleado{Nombres="Juan Carlos",Apellidos="Reyes Jimenes",Fecha_Ingreso=DateTime.Parse("2001-09-01")},
                new Empleado{Nombres="Jean Carlos",Apellidos="Sandoval Polanco",Fecha_Ingreso=DateTime.Parse("2002-10-25")},
                new Empleado{Nombres="Josue",Apellidos="Reyes Sandobal",Fecha_Ingreso=DateTime.Parse("2003-09-15")}
            };
            Empleados.ForEach(s => context.Empleados.Add(s));
            context.SaveChanges();

            var Registros = new List<Registro>
            {
                new Registro{EmpleadoID=1,DepartamentoID=1,Sueldo=Convert.ToDecimal(10000.00)},
                new Registro{EmpleadoID=2,DepartamentoID=2,Sueldo=Convert.ToDecimal(25000.00)},
                new Registro{EmpleadoID=3,DepartamentoID=3,Sueldo=Convert.ToDecimal(12500.00)}
            };
            Registros.ForEach(s => context.Registros.Add(s));
            context.SaveChanges();

        }
    }
}
