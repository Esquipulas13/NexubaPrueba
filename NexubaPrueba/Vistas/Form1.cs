using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexubaPrueba
{
    public partial class Form1 : Form
    {
        List<Modelo.Usuarios> Mostrar;
        Controlador.UsuariosC usuariosC = new Controlador.UsuariosC();
        Modelo.Usuarios seleccionado;
        public Form1()
        {
            InitializeComponent();
            Mostrar = usuariosC.MostrarTodo();
            actualizarTabla();
        }

        public void actualizarTabla()
        {
            dgvUsuarios.DataSource = null;
            dgvUsuarios.DataSource = Mostrar;
        }

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        private void dgvUsuarios_CellEnter(object sender, DataGridViewCellEventArgs e)
        {
            try
            {
                Modelo.Usuarios seleccionado = Mostrar[dgvUsuarios.CurrentRow.Index];
                lblSeleccionado.Visible = true;
                lblSeleccionado.Text = "Seleccionaste a: "+ seleccionado.Nombre + " " + seleccionado.Paterno;
            }
            catch (Exception)
            {

            }
            seleccionado = Mostrar[dgvUsuarios.CurrentRow.Index];

        }

        private void dgvUsuarios_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {

        }

        private void btnEditar_Click(object sender, EventArgs e)
        {
            Vistas.DetallesUsuario frmDetalles = new Vistas.DetallesUsuario(seleccionado);
            frmDetalles.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Vistas.Agregar mostrar = new Vistas.Agregar();
            mostrar.Show();
            this.Hide();
        }

        private void btnCsv_Click(object sender, EventArgs e)
        {
            Vistas.CSV CSV = new Vistas.CSV(seleccionado);
            CSV.Show();
            this.Hide();
        }
    }
}
