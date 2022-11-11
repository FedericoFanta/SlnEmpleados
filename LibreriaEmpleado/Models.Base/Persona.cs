using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models.Base
{
    public class Persona
    {
        public Persona(int id, string nombre, string apellido)
        {
            Id=id;
            Nombre=nombre;
            Apellido=apellido;
        }
        public int Id { get; set; }
        public string Nombre { get; set; }
        public string Apellido { get; set; }

        

        
    }
}
