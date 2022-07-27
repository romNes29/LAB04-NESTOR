using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Compras
    {
        private int idCliente;
        private int idProducto;
        string fechaCompra;

        public Compras()
        {

        }

        public Compras(int id_cliente, int id_producto, string fechaCompra)
        {
            this.idCliente = id_cliente;
            this.idProducto = id_producto;
            this.fechaCompra = fechaCompra;

        }

        public int IdCliente
        {
            get { return idCliente; }  
            set { this.idCliente = value; }
        }
        public int IdProducto
        {
            get { return idProducto; }
            set { this.idProducto = value; }
        }
        public string FechaCompra
        {
            get { return fechaCompra; } 
            set { this.fechaCompra = value; }
        }
    }
}
