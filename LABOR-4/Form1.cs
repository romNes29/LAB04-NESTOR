using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Negocio;
namespace LABOR_4
{
    public partial class Form1 : Form
    {
        TraeDatos oTraeDatos = new TraeDatos();
        public Form1()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            oTraeDatos.GuardaClientes();
        }

        private void btnRespaldoProductos_Click(object sender, EventArgs e)
        {
            oTraeDatos.guardaroductos();
        }

        private void btnRespaldoCompras_Click(object sender, EventArgs e)
        {
            oTraeDatos.guardaCompras();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            
        }
    }
}
