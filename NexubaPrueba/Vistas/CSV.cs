using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace NexubaPrueba.Vistas
{
    public partial class CSV : Form
    {
        Modelo.Usuarios Seleccionado;
        string Nombre;
        string Login;
        string Paterno;
        string Materno;
        string Sueldo;
        string FechaIngreso;
        public CSV(Modelo.Usuarios seleccionado)
        {
            InitializeComponent();
            Seleccionado = seleccionado;
            Login = seleccionado.Login;
            Nombre = seleccionado.Nombre;
            Paterno = seleccionado.Paterno;
            Materno = seleccionado.Materno;
            Sueldo = seleccionado.Sueldo.ToString();
            FechaIngreso = seleccionado.FechaIngreso;
            label1.Text = "Estas apunto de generar un CSV de " + Nombre + " "+ Paterno +" "+ Materno +  ".";
            
        }

        static void Generar(string Login, string Nombre, string Paterno, string Materno, string Sueldo, string FechaIngreso)
        {
            string ruta = @"C:\Users\xxd19\source\repos\NexubaPrueba\"+Nombre+".csv";
            string separado = ",";
            StringBuilder salida = new StringBuilder();
            string cadena = Login + "," + Nombre + "," + Paterno + "," + Materno + "," + Sueldo + "," + FechaIngreso;
            List<string> lista = new List<string>();
            lista.Add(cadena);
            for (int i = 0; i < lista.Count; i++)
            {
                salida.AppendLine(string.Join(separado, lista[i]));
                File.AppendAllText(ruta, salida.ToString());
            }
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            Generar(Login, Nombre, Paterno, Materno, Sueldo, FechaIngreso);
            MessageBox.Show("Generado correctamente");
            Form1 form1 = new Form1();
            form1.Show();
            this.Hide();
        }
    }
}
