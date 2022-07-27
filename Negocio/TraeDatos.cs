using System;
using System.Collections.Generic;
using System.Data;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Xml;
using Datos;


namespace Negocio
{
    public class TraeDatos
    {
        private static List<Clientes> listaClientes = new List<Clientes>();
        private static List<Productos> listaProductos;
        private static List<Compras> listaCompras;

        public TraeDatos()
        {

            List<Productos> listaProductos = new List<Productos>();
            List<Compras> listaCompras = new List<Compras>();
    }


        public static DataTable consultaTodosElementos(string tabla, string[] columnas)
        {
            string campos = "";
            for (int i = 0; i < columnas.Length; i++)
            {
                campos += "\"" + columnas[i] + "\"";
                if (i != columnas.Length - 1)
                {
                    campos += ",";
                }
            }

            string query = "Select " + campos + " from " + "\"" + tabla + "\"";
            DataTable resultado = Connect.consultaUnDato(query);
            return resultado;

        }

        public static void registraCliente(string tabla, string[] datos)
        {
            Connect.insertaDatos(tabla, datos);
            Connect.desconectarPostgreSQL();
        }

        public static void eliminarRegistro(string tabla, string identificacion)
        {
            Connect.eliminarRegistro(tabla, identificacion);
        }
        public static void actualizar(string tabla, string columna, string[] datos)
        {
            Connect.actualizarRegistro(tabla, columna, datos);
        }


        public void GuardaClientes()
        {
            //Raiz del documento
            XmlDocument documento = new XmlDocument();
            XmlElement raiz = documento.CreateElement("CLIENTES");
            documento.AppendChild(raiz);
            try
            {
                for (int i = 0; i < listaClientes.Count; i++)
                {
                    //Agrega el libro
                    XmlElement libro = documento.CreateElement("cliente");
                    raiz.AppendChild(libro);
                    //Agrega los datos del libro
                    XmlElement id_cliente = documento.CreateElement("id_cliente");
                    id_cliente.AppendChild(documento.CreateTextNode(listaClientes.ElementAt(i).IdCliente.ToString()));
                    libro.AppendChild(id_cliente);

                    XmlElement cedula = documento.CreateElement("cedula");
                    cedula.AppendChild(documento.CreateTextNode(listaClientes.ElementAt(i).Cedula));
                    libro.AppendChild(cedula);

                    XmlElement nombre = documento.CreateElement("nombre");
                    nombre.AppendChild(documento.CreateTextNode(listaClientes.ElementAt(i).Nombre));
                    libro.AppendChild(nombre);

                    XmlElement apellido = documento.CreateElement("apellido");
                    apellido.AppendChild(documento.CreateTextNode(listaClientes.ElementAt(i).Apellido));
                    libro.AppendChild(apellido);

                    XmlElement sexo = documento.CreateElement("sexo");
                    sexo.AppendChild(documento.CreateTextNode(listaClientes.ElementAt(i).Sexo));
                    libro.AppendChild(sexo);

                    XmlElement nacimiento = documento.CreateElement("nacimiento");
                    nacimiento.AppendChild(documento.CreateTextNode(listaClientes.ElementAt(i).FechaNacimiento));
                    libro.AppendChild(nacimiento);

                }
                documento.Save("ClientesCODEXA.xml");
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }


        }

        public void guardaroductos()
        {

            //Raiz del documento
            XmlDocument documento = new XmlDocument();
            XmlElement raiz = documento.CreateElement("PRODUCTOS");
            documento.AppendChild(raiz);
            try
            {
                for (int i = 0; i < listaProductos.Count; i++)
                {
                    //Agrega el libro
                    XmlElement libro = documento.CreateElement("producto");
                    raiz.AppendChild(libro);
                    //Agrega los datos del libro
                    XmlElement id_producto = documento.CreateElement("id_producto");
                    id_producto.AppendChild(documento.CreateTextNode(listaProductos.ElementAt(i).IdProducto.ToString()));
                    libro.AppendChild(id_producto);

                    XmlElement descripcion = documento.CreateElement("descripcion");
                    descripcion.AppendChild(documento.CreateTextNode(listaProductos.ElementAt(i).Descripcion));
                    libro.AppendChild(descripcion);

                    XmlElement precio = documento.CreateElement("precio");
                    precio.AppendChild(documento.CreateTextNode(listaProductos.ElementAt(i).Precio.ToString()));
                    libro.AppendChild(precio);

                }
                documento.Save("Productos.xml");
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }

        }

        public void guardaCompras()
        {
            //Raiz del documento
            XmlDocument documento = new XmlDocument();
            XmlElement raiz = documento.CreateElement("COMPRAS");
            documento.AppendChild(raiz);
            try
            {
                for (int i = 0; i < listaCompras.Count; i++)
                {
                    //Agrega el libro
                    XmlElement libro = documento.CreateElement("compra");
                    raiz.AppendChild(libro);
                    //Agrega los datos del libro
                    XmlElement id_cliente = documento.CreateElement("id_cliente");
                    id_cliente.AppendChild(documento.CreateTextNode(listaCompras.ElementAt(i).IdCliente.ToString()));
                    libro.AppendChild(id_cliente);

                    XmlElement id_producto = documento.CreateElement("id_producto");
                    id_producto.AppendChild(documento.CreateTextNode(listaCompras.ElementAt(i).IdProducto.ToString()));
                    libro.AppendChild(id_producto);

                    XmlElement fecha_compra = documento.CreateElement("fecha_compra");
                    fecha_compra.AppendChild(documento.CreateTextNode(listaCompras.ElementAt(i).FechaCompra));
                    libro.AppendChild(fecha_compra);

                }
                documento.Save("Compras.xml");
            }
            catch (Exception excep)
            {
                MessageBox.Show(excep.ToString());
            }
        }

        //Cargar las listas 

        public static void cargaListaCiente()
        {
            DataTable Clientes = 
            for (int i = 0; i < Clientes.Rows.Count; i++)
            {
                int codigo = int.Parse(Clientes.Rows[i]["id_cliente"].ToString());
                String cedula = Clientes.Rows[i]["cedula"].ToString();
                String nombre = Clientes.Rows[i]["nombre"].ToString();
                String apellido = Clientes.Rows[i]["apellido"].ToString();
                String sexo = Clientes.Rows[i]["sexo"].ToString();
                string fechaNacimiento = Clientes.Rows[i]["fecha_nacimiento"].ToString();

                listaClientes.Add(new Clientes(codigo, cedula, nombre, apellido, sexo, fechaNacimiento));
            }



        }
    }

}
