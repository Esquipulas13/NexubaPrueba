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
    public partial class DetallesUsuario : Form
    {
        Modelo.Usuarios Seleccionado;
        Controlador.UsuariosC usuariosC = new Controlador.UsuariosC();
        public DetallesUsuario(Modelo.Usuarios seleccionado)
        {
            InitializeComponent();
            Seleccionado = seleccionado;
            lbluserId.Text = seleccionado.userId + "";
            txtLogin.Text = seleccionado.Login;
            txtNombre.Text = seleccionado.Nombre;
            txtPaterno.Text = seleccionado.Paterno;
            txtMaterno.Text = seleccionado.Materno;
            txtSueldo.Text = seleccionado.Sueldo + "";
            txtFechaIngreso.Text = seleccionado.FechaIngreso.Substring(6,4) + "-" + seleccionado.FechaIngreso.Substring(3, 2) + "-" + seleccionado.FechaIngreso.Substring(0, 2);
            txtLogin.Enabled = false;
            txtNombre.Enabled = false;
            txtPaterno.Enabled = false;
            txtMaterno.Enabled = false;
            txtFechaIngreso.Enabled = false;
        }

        private void DetallesUsuario_Load(object sender, EventArgs e)
        {

        }

        private void btnRegresar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void btnGuardar_Click(object sender, EventArgs e)
        {
            Modelo.Usuarios nuevo = new Modelo.Usuarios(int.Parse(lbluserId.Text), double.Parse(txtSueldo.Text), txtFechaIngreso.Text, int.Parse(lbluserId.Text));

            if (usuariosC.Editar(nuevo) == true)
            {
                MessageBox.Show("Se Editaron los datos con exito");
            }
            else
            {
                MessageBox.Show("Ocurrio un Problema");
            }
        }

        private void txtLogin_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtNombre_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtPaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtMaterno_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtSueldo_TextChanged(object sender, EventArgs e)
        {

        }

        private void txtFechaIngreso_TextChanged(object sender, EventArgs e)
        {

        }

        private void label6_Click(object sender, EventArgs e)
        {

        }

        private void label5_Click(object sender, EventArgs e)
        {

        }

        private void label4_Click(object sender, EventArgs e)
        {

        }

        private void label3_Click(object sender, EventArgs e)
        {

        }

        private void label2_Click(object sender, EventArgs e)
        {

        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void lbluserId_Click(object sender, EventArgs e)
        {

        }
    }
}
