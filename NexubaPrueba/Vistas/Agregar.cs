using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexubaPrueba.Vistas
{
    public partial class Agregar : Form
    {
        String hoy = DateTime.Now + "";
        Controlador.UsuariosC usuariosC = new Controlador.UsuariosC();
        public Agregar()
        {
            InitializeComponent();
            txtFechaIngreso.Text = hoy.Substring(6, 4) + "-" + hoy.Substring(3, 2) + "-" + hoy.Substring(0, 2);
            txtFechaIngreso.Enabled = false;
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Modelo.Usuarios nuevo = new Modelo.Usuarios(0,txtLogin.Text,txtNombre.Text,txtPaterno.Text,txtMaterno.Text);

            if (usuariosC.AgregarUsuario(nuevo) == 1)
            {
                Controlador.UsuariosC u = new Controlador.UsuariosC();
                int i = u.MostrarUno();

                Modelo.Usuarios nuevo2 = new Modelo.Usuarios(0, double.Parse(txtSueldo.Text), txtFechaIngreso.Text, i);

                if (usuariosC.AgregarEmpleado(nuevo2) == 1)
                {
                    
                }
                else
                {
                    MessageBox.Show("Se Editaron los datos con exito" + i);
                }
            }
            else
            {
                //En este caso lo puse ta,bien aqui porque me da un error en la ejecuion del comando de la consulta, pero si lo realiza.
                Controlador.UsuariosC u = new Controlador.UsuariosC();
                int i = u.MostrarUno();

                Modelo.Usuarios nuevo2 = new Modelo.Usuarios(0, double.Parse(txtSueldo.Text), txtFechaIngreso.Text, i);

                if (usuariosC.AgregarEmpleado(nuevo2) == 1)
                {
                }
                else
                {
                    MessageBox.Show("Se Editaron los datos con exito" + i);
                }
            }

            

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
        }
    }
}
