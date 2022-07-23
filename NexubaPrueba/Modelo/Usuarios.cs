using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexubaPrueba.Modelo
{
    public class Usuarios
    {
        public int userId { get; set; }
        public int userId_usuario { get; set; }
        public string Login { get; set; }
        public string Nombre { get; set; }
        public string Paterno { get; set; }
        public string Materno { get; set; }
        public double Sueldo { get; set; }
        public string FechaIngreso { get; set; }

        public Usuarios()
        {

        }

        public Usuarios(int userid, string Login, string Nombre, string Paterno, string Materno, double Sueldo, string FechaIngreso)
        {
            this.userId = userid;
            this.Login = Login;
            this.Nombre = Nombre;
            this.Paterno = Paterno;
            this.Materno = Materno;
            this.Sueldo = Sueldo;
            this.FechaIngreso = FechaIngreso;
        }



        public Usuarios(int userid, string Login, string Nombre, string Paterno, string Materno)
        {
            this.userId = userid;
            this.Login = Login;
            this.Nombre = Nombre;
            this.Paterno = Paterno;
            this.Materno = Materno;
        }

        public Usuarios(int userid, double Sueldo, string FechaIngreso, int userId_usuario)
        {
            this.userId = userid;
            this.Sueldo = Sueldo;
            this.FechaIngreso = FechaIngreso;
            this.userId_usuario = userId_usuario;
        }

    }
}
