using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Controlador;
using Dominio;

namespace tp_winform
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnConectarse_Click(object sender, EventArgs e)
        {
            Articulos articulos = new Articulos();
            dgvArticulos.DataSource = articulos.listar();
        }

        private void btnDesconectarse_Click(object sender, EventArgs e)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.cerrarConexion();
        }
    }
}
