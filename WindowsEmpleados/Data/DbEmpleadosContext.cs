using LibreriaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEmpleados.Data
{
    public class DbEmpleadosContext:DbContext
    {
        public DbEmpleadosContext() : base("keyDbEmpleados") { }

        //por cada modelo una propiedad DBSET

        public DbSet<Departamento> Departamentos { get; set; }

        public DbSet<Empleado> Empleados { get; set; }
        
         protected override void OnModelCreating(DbModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Empleado>().HasKey(e => e.Id);

            modelBuilder.Entity<Empleado>().Property(e=>e.Legajo).HasColumnType("varchar").HasMaxLength(10).IsRequired();
            modelBuilder.Entity<Empleado>().Property(e => e.Nombre).HasColumnType("varchar").HasMaxLength(40).IsRequired();
            modelBuilder.Entity<Empleado>().Property(e => e.Apellido).HasColumnType("varchar").HasMaxLength(20).IsRequired();

            modelBuilder.Entity<Departamento>().HasKey(e => e.Id);

            modelBuilder.Entity<Departamento>().Property(e => e.Nombre).HasColumnType("varchar").HasMaxLength(50).IsRequired();
        }
    }
}
