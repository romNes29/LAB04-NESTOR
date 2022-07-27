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
        private static List<Productos> listaProductos = new List<Productos>();
        private static List<Compras> listaCompras = new List<Compras>();

        public TraeDatos()
        {
            cargaListaCiente();
            cargaListaProductos();
            cargaListaCompras();    
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
            if (listaClientes.Count == 0)
            {
                MessageBox.Show("No existe informacion de clientes en la base de datos.");
            }
            else
            {
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
                    MessageBox.Show("Respaldo de clientes creado con exito");
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.ToString());
                }
            }

        }

        public void guardaroductos()
        {

            //Raiz del documento
            XmlDocument documento = new XmlDocument();
            XmlElement raiz = documento.CreateElement("PRODUCTOS");
            documento.AppendChild(raiz);
            if (listaProductos.Count == 0)
            {
                MessageBox.Show("No existe informacion de productos en la base de datos.");
            }
            else
            {
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
                    MessageBox.Show("Respaldo de productos creado con exito");
                    documento.Save("Productos.xml");
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.ToString());
                }
            }

        }

        public void guardaCompras()
        {
            //Raiz del documento
            XmlDocument documento = new XmlDocument();
            XmlElement raiz = documento.CreateElement("COMPRAS");
            documento.AppendChild(raiz);

            if (listaCompras.Count == 0)
            {
                MessageBox.Show("No existe informacion de compras en la base de datos.");
            }
            else
            {
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
                    MessageBox.Show("Respaldo de compras creado con exito");
                    documento.Save("Compras.xml");
                }
                catch (Exception excep)
                {
                    MessageBox.Show(excep.ToString());
                }
            }
        }

        //Cargar las listas 

        public static void cargaListaCiente()
        {
            string query = "select * from clientes";
            DataTable Clientes = Connect.consultaUnDato(query);
            if (Clientes.Rows.Count == 0)
            {
                MessageBox.Show("No existe informacion de productos en la base de datos.");
            }
            else
            {
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

        public static void cargaListaProductos()
        {
            string query = "select * from productos";
            DataTable productos = Connect.consultaUnDato(query);
            if (productos.Rows.Count == 0)
            {
                MessageBox.Show("No existe informacion de productos en la base de datos.");
            }
            else
            {
                for (int i = 0; i < productos.Rows.Count; i++)
                {
                    int codigo = int.Parse(productos.Rows[i]["id_producto"].ToString());
                    String descripcion = productos.Rows[i]["descripcion"].ToString();
                    String precio = productos.Rows[i]["precio"].ToString();

                    listaProductos.Add(new Productos(codigo, descripcion, double.Parse(precio)));
                }
            }
        }

        public static void cargaListaCompras()
        {
            string query = "select * from compras";
            DataTable compras = Connect.consultaUnDato(query);
            if (compras.Rows.Count == 0)
            {
                MessageBox.Show("No existe informacion de compras en la base de datos.");
            }
            else
            {
                for (int i = 0; i < compras.Rows.Count; i++)
                {
                    int idCliente = int.Parse(compras.Rows[i]["id_cliente"].ToString());
                    int idProducto = int.Parse(compras.Rows[i]["id_producto"].ToString());
                    String fechaCompra = compras.Rows[i]["fecha_compra"].ToString();

                    listaCompras.Add(new Compras(idCliente, idProducto, fechaCompra));
                }
            }
        }
    }

}
