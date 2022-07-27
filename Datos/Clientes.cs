using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Datos
{
    public class Clientes
    {
        int idCliente;
        string cedula;
        string nombre;
        string apellido;
        string sexo;
        string fechaNacimiento;

        public Clientes()
        {

        }
        public Clientes(int idCliente, string cedula, string nombre, string apellido, string sexo, string fechaNacimiento)
        {
            this.idCliente = idCliente;
            this.cedula = cedula;
            this.nombre = nombre;
            this.apellido = apellido;
            this.sexo = sexo;
            this.fechaNacimiento = fechaNacimiento;
        }


        public int IdCliente 
        {
            get { return idCliente; }
            set { idCliente = value; }  
        }
            
        public string Cedula
        {
            get { return cedula; }
            set { cedula = value; } 
        }
        public string Nombre
        {
            get { return nombre; }
            set { nombre = value; }
        }
        public string Apellido
        {
            get { return apellido; }
            set { apellido = value; }   
        }
        public string Sexo
        {
            get { return sexo; }
            set{ sexo = value; }   
        }
        public string FechaNacimiento
        {
            get { return fechaNacimiento; }
            set { fechaNacimiento = value; }   
        }


}
}
