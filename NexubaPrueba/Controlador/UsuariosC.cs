using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Data;

namespace NexubaPrueba.Controlador
{
    public class UsuariosC
    {
        public List<Modelo.Usuarios> MostrarTodo()
        {
            List<Modelo.Usuarios> lista = new List<Modelo.Usuarios>();
            try
            {
                String sentencia = "select u.*, e.Sueldo, e.FechaIngreso from usuarios u, empleados e where u.userid = e.userid limit 10;";
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand(sentencia);
                DataTable dtAlumnos = con.ejecutarConsulta(cmd);
                Modelo.Usuarios objAlumno = null;
                foreach (DataRow fila in dtAlumnos.Rows)
                {
                    objAlumno = new Modelo.Usuarios(
                        int.Parse(fila["userid"].ToString()), fila["Login"].ToString(), fila["Nombre"].ToString(),
                        fila["Paterno"].ToString(), fila["Materno"].ToString(), double.Parse(fila["Sueldo"].ToString()),
                        fila["FechaIngreso"].ToString()
                    );
                    lista.Add(objAlumno);
                }
                return lista;
            }
            catch (Exception ex)
            {
                return lista;
            }
            finally
            {
                if (Conexion.ConexionDb != null)
                {
                    Conexion.ConexionDb.Close();
                }
            }

        }

        public int MostrarUno()
        {
            Modelo.Usuarios objAlumno = null;
            try
            {
                String sentencia = "select count(*) from usuarios;";
                Conexion con = new Conexion();
                MySqlCommand cmd = new MySqlCommand(sentencia);
                int i = con.ejecutarSentencia(cmd, true);
                return i;
            }
            catch (Exception ex)
            {

                return 0;
            }
            finally
            {
                //Solo intentar cerrar la conexión cuando si se encuentra abierta
                if (Conexion.ConexionDb != null)
                {
                    Conexion.ConexionDb.Close();
                }
            }
        }

        public bool Editar(Modelo.Usuarios usuario)
        {
            try
            {
                String sentencia = "update empleados set Sueldo = @P0, FechaIngreso = @P2 WHERE userid = @P1;";
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

        public int AgregarUsuario(Modelo.Usuarios usuario)
        {
            try
            {
                String sentencia;
                sentencia = "insert into usuarios(Login, Nombre, Paterno, Materno) " +
                    "values (@P0,@P1,@P2,@P3)";
                MySqlCommand cmd = new MySqlCommand(sentencia);
                cmd.Parameters.AddWithValue("@P0", usuario.Login);
                cmd.Parameters.AddWithValue("@P1", usuario.Nombre);
                cmd.Parameters.AddWithValue("@P2", usuario.Paterno);
                cmd.Parameters.AddWithValue("@P3", usuario.Materno);
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
        public int AgregarEmpleado(Modelo.Usuarios empleado)
        {
            try
            {
                String sentencia;
                sentencia = "insert into empleados(Sueldo, FechaIngreso, userid_usuarios) " +
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
