using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace WindowsEmpleados
{
    public partial class Form1 : Form
    {
       List <Empleado> empleados;
        public Form1()
        {
            InitializeComponent();
        }
        private void btnAgregarEmpleado_Click(object sender, EventArgs e)
        {
            int filasAfectadas = AdminEmpleado.Insertar(new Empleado(txtLegajo.Text, Convert.ToInt32(txtIdEmpleado.Text), txtNombreEmpleado.Text, txtApellido.Text));
            if (filasAfectadas != 0)
            {
                MessageBox.Show("Empleado añadido con exito!");
            }
            else
            {
                MessageBox.Show("El Empleado no ha podido ser añadido!");
            }
        }

        private void btnListarEmpleados_Click(object sender, EventArgs e)
        {
            empleados = AdminEmpleado.Listar();
            gridEmpleados.DataSource = null;
            gridEmpleados.Rows.Clear();
            gridEmpleados.DataSource = empleados;
        }
    }
}
