using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using MySql.Data.MySqlClient;
using System.Windows.Forms;
using System.Data;

namespace NexubaPrueba.Controlador
{
    public class Conexion
    {

        public static MySqlConnection ConexionDb = null;
        public bool Conectar()
        {
            String servidor = "127.0.0.1";
            String puerto = "3306";
            String usuario = "root";
            String password = "root";
            String database = "bd";
            String SslMode = "0";

            String cadena = "Database=" + database + ";Data Source=" + servidor + "; Port=" + puerto + "; User id=" + usuario +
                "; Password=" + password + ";SSL Mode=0";

            ConexionDb = new MySqlConnection(cadena);
            MySqlDataReader reader = null;
            String data = null;

            try
            {
                ConexionDb.Open();
                return true;
            }
            catch (MySqlException e)
            {
                ConexionDb.Close();
                return false;
            }
            finally
            {
                ConexionDb.Close();
            }
        }

        public DataTable ejecutarConsulta(MySqlCommand com)
        {
            try
            {
                if (Conectar())
                {
                    com.Connection = ConexionDb;
                    MySqlDataAdapter objAdapter =
                        new MySqlDataAdapter(com);
                    DataTable resultado = new DataTable();
                    objAdapter.Fill(resultado);
                    return resultado;
                }
                else
                {
                    return null;
                }
            }
            catch (Exception ex)
            {
                return null;
            }
            finally
            {
                //Solo intentar cerrar la conexión cuando si se encuentra abierta
                if (ConexionDb != null)
                    ConexionDb.Close();
            }

        }

        public int ejecutarSentencia(MySqlCommand objComando, bool esInsert)
        {
            int resultado = 0;
            try
            {
                if (Conectar())
                {
                    objComando.Connection = ConexionDb;
                    MySqlDataAdapter objAdapter = new MySqlDataAdapter(objComando);
                    if (esInsert)
                    {
                        ConexionDb.Open();
                        //Aqui da un error, trato de saber el ultimo id agregado, si lo obtiene, pero tiene un error de execuvion.
                        resultado = int.Parse(objComando.ExecuteScalar().ToString());
                    }
                    else
                    {
                        ConexionDb.Open();
                        objComando.ExecuteNonQuery();
                        resultado = 1;
                    }
                    return resultado;
                }
                else
                {
                    return 0;
                }
            }
            catch (Exception ex)
            {
                return 0;
            }
            finally
            {
                if (ConexionDb != null)
                    ConexionDb.Close();
            }
        }
    }
}
