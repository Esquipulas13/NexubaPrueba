using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NexubaPrueba.Modelo
{
    public class Empleado
    {
        public int userId { get; set; }
        public int userId_usuario { get; set; }
        public double Sueldo { get; set; }
        public string FechaIngreso { get; set; }

        public Empleado()
        {

        }

        public Empleado(int userid, double Sueldo, string FechaIngreso, int userId_usuario)
        {
            this.userId = userid;
            this.Sueldo = Sueldo;
            this.FechaIngreso = FechaIngreso;
            this.userId_usuario = userId_usuario;
        }
    }
}
