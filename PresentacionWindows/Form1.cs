using LibreriaEmpleado.Models;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PresentacionWindows
{ 
    
    public partial class Form1 : Form

    {
        List<Empleado> Empleados;
        public Form1()
        {
            InitializeComponent();
        }

        private void btnEmpleados_Click(object sender, EventArgs e)
        {
            Empleados=new List<Empleado>();

            Departamento departamento = new Departamento() { Id=25, Nombre="Departamento1",Empleados=3 };

            Empleado empleado1 = new Empleado(departamento,33,"juan", "perez", "c33");

            Empleados.Add(empleado1);

            Empleados.Add(new Empleado(departamento,1, "Ramon", "Jayce", "D456"));
            Empleados.Add(new Empleado(departamento, 77, "Tomas", "Malphite", "g356"));

            MessageBox.Show($"Departamento creado con exito");




        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void btnMostrarEmpleados_Click(object sender, EventArgs e)
        {
            gridEmpleados.DataSource = Empleados;
        }
    }
}
