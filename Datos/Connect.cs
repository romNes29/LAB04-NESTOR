using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Npgsql;
namespace Datos
{
    public class Connect
    {

        private static NpgsqlConnection conn = new NpgsqlConnection("Server=localhost; Database=LAB03; User Id=fundamentos; Password=choco29;");

        public static void conectarPostgreSQL()
        {
            conn.Open();
            Console.WriteLine("Conexion a base de datos establecida.");
        }



        public static void desconectarPostgreSQL()
        {
            conn.Close();
            Console.WriteLine("Desconexion de base de datos realizada.");


        }

        public static string insertaDatos(string tabla, string[] datos)
        {
            try
            {
                conectarPostgreSQL();
                string campos = "(";
                for (int i = 0; i < datos.Length; i++)
                {
                    campos += "'" + datos[i] + "'";
                    if (i != datos.Length - 1)
                    {
                        campos += ",";
                    }
                }
                campos += ")";
                string insertSql = "Insert into \"" + tabla + "\" values " + campos;
                NpgsqlCommand ejecutar = new NpgsqlCommand(insertSql, conn);
                ejecutar.ExecuteNonQuery();
                desconectarPostgreSQL();
                MessageBox.Show("Insertado con exito");
            }
            catch (Exception)
            {
                return "Error";
            }
            return "Ok";

        }

        public static DataTable consultaUnDato(string query)
        {
            try
            {
                conectarPostgreSQL();
                NpgsqlCommand conector = new NpgsqlCommand(query, conn);
                NpgsqlDataAdapter datos = new NpgsqlDataAdapter(conector);
                DataTable tabla = new DataTable();
                datos.Fill(tabla);
                desconectarPostgreSQL();
                return tabla;
            }
            catch (Exception)
            {
                return null;
            }
        }

        public void consultaListaDatos(string tabla, string consulta)
        {

        }

        public static void eliminarRegistro(string tabla, string cedula)
        {
            try
            {
                conectarPostgreSQL();
                string deleteSql = "delete from \'" + tabla + "\' where cedula = \'" + cedula + "\';";
                NpgsqlCommand ejecutar = new NpgsqlCommand(deleteSql, conn);
                ejecutar.ExecuteNonQuery();
                MessageBox.Show("Cliente eliminado con exito.");
                desconectarPostgreSQL();
            }
            catch (Exception error)
            {
                MessageBox.Show("Error eliminando: " + error.ToString());
            }
        }
        public static void actualizarRegistro(string tabla, string columna, string[] datos)
        {
            try
            {
                conectarPostgreSQL();
                string updateSql = "update " + tabla + " set " + columna + " = \'" + datos[1] + "\' where id_cliente = \'" + datos[0] + "\';";
                NpgsqlCommand ejecutar = new NpgsqlCommand(updateSql, conn);
                ejecutar.ExecuteNonQuery();
                MessageBox.Show("Cliente actualizado con exito.");
                MessageBox.Show("Actualizado comn exito.");
                desconectarPostgreSQL();
            }
            catch (Exception e)
            {
                MessageBox.Show("Error actualizando: " + e.ToString());
            }
        }







    }
}
