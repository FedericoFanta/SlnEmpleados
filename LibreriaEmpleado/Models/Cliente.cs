using LibreriaEmpleado.Models.Base;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LibreriaEmpleado.Models
{
    public class Cliente : Persona

    {
        public Cliente( int id, string nombre, string apellido, int cuit, string telefono) : base(id, nombre, apellido)
        {
            Cuit=cuit;
            Telefono=telefono;

        }

        public int Cuit { get; set; }
        public string Telefono { get; set; }

    }
}
