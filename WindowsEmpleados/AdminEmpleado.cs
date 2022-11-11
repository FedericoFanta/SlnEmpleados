using LibreriaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace WindowsEmpleados
{
    public class AdminEmpleado : Empleado
    {
        public AdminEmpleado(Departamento departamento, int id, string nombre, string apellido, string legajo) : base(departamento, id, nombre, apellido, legajo)
        {

        }

        public void insertarEmpleado(Empleado empleado) { }

        public void listar() { }

    }
}
