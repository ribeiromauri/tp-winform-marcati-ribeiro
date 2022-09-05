using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Data.SqlClient;
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
            AccesoDatos accesoDatos = new AccesoDatos();
            ListaArticulos listaArt = new ListaArticulos();
            dgvArticulos.DataSource = listaArt.listar();
        }

        private void btnDesconectarse_Click(object sender, EventArgs e)
        {
            AccesoDatos accesoDatos = new AccesoDatos();
            accesoDatos.cerrarConexion();
        }

        // CORREGIR, ABRE LA CONEXCION CUANDO ABRIS EL FORMULARIO
        SqlConnection conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");

        private void btnConsulta_Click(object sender, EventArgs e)
        {
            AccesoDatos datos = new AccesoDatos();

            if (txtCriterioConsulta.Text == "")
            {
                string consulta = "SELECT * FROM ARTICULOS";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvArticulos.DataSource = tabla;

            }
            else
            {
                string consulta = "SELECT * FROM ARTICULOS WHERE " + txtColumnaConsulta.Text + " = '" + txtCriterioConsulta.Text + "'";
                SqlCommand comando = new SqlCommand(consulta, conexion);
                SqlDataAdapter data = new SqlDataAdapter(comando);
                DataTable tabla = new DataTable();
                data.Fill(tabla);
                dgvArticulos.DataSource = tabla;
            }
        }

        private void btnMostrarTodo_Click(object sender, EventArgs e)
        {
            ListaArticulos listaArt = new ListaArticulos();
            dgvArticulos.DataSource = listaArt.listar();
        }
    }
}
