using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace NexubaPrueba.Controlador
{
    public class EmpleadoC
    {
        public bool Editar(Modelo.Empleado usuario)
        {
            try
            {
                String sentencia = "update empleados set Sueldo = @P0 WHERE userid = @P1;";
                MySqlCommand cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@P0", usuario.Sueldo);
                cmd.Parameters.AddWithValue("@P1", usuario.userId);
                cmd.Parameters.AddWithValue("@P2", usuario.FechaIngreso);
                cmd.Parameters.AddWithValue("@P3", usuario.userId_usuario);
                Conexion con = new Conexion();
                return ((con.ejecutarSentencia(cmd, false) == 1) ? true : false);
            }
            catch (Exception ex)
            {
                return false;
            }
            finally
            {
                if (Conexion.ConexionDb != null)
                {
                    Conexion.ConexionDb.Close();
                }
            }
        }

        public int AgregarEmpleado(Modelo.Empleado empleado)
        {
            try
            {
                String sentencia;
                sentencia = "insert into empleados(Sueldo, FechaIngreso, userid_usuarios) values " +
                    "values (@P0,@P1,@P2)";
                MySqlCommand cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@P0", empleado.Sueldo);
                cmd.Parameters.AddWithValue("@P1", empleado.FechaIngreso);
                cmd.Parameters.AddWithValue("@P2", empleado.userId_usuario);
                Conexion con = new Conexion();
                return con.ejecutarSentencia(cmd, true);
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (Conexion.ConexionDb != null)
                {
                    Conexion.ConexionDb.Close();
                }
            }
        }
    }
}
