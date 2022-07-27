using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Productos
    {
        int idProducto;
        string descripcion;
        double precio;
        public Productos()
        {

        }

        public Productos(int idProducto, string descripcion, double precio)
        {
            this.idProducto = idProducto;
            this.descripcion = descripcion;
            this.precio = precio;
        }

        public int IdProducto
        {
            get { return idProducto; }
            set { idProducto = value; }
        }
        public string Descripcion
        {
            get { return descripcion; }
            set { descripcion = value; }
        }
        public double Precio
        {
            get { return precio; }
            set { precio = value; }   
        }
    }
}
