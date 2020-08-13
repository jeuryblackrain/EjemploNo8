using EjemploTarea8Class;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity.ModelConfiguration;
using EjemploNo8.Models;
using System.Data.Entity.ModelConfiguration.Conventions;

namespace EjemploTarea8Class.DAL
{
    public class EmpleadoContext : DbContext
    {
        public EmpleadoContext() 
            : base("EmpleadoContext")
        {
        }

        public DbSet<Empleado> Empleados {get;set;}
        public DbSet<Departamento> Departamentos { get; set; }
        public DbSet<Registro> Registros { get; set; }

        protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            modelBuilder.Conventions.Remove<PluralizingTableNameConvention>();

        }

    }
}
