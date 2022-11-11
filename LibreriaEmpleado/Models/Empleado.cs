using LibreriaEmpleado.Models.Base;
using System;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    [Table("Empleado")]
    public class Empleado : Persona
    {
        
        public Empleado(Departamento departamento,int id, string nombre, string apellido, string legajo) : base(id, nombre, apellido)
        {
            Legajo=legajo;  
        }
       


        public string Legajo { get; set; }

        public Departamento Departamento { get; set; }
    }
}
