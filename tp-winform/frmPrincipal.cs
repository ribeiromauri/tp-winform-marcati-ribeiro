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
    public partial class frmPrincipal : Form
    {
        private List<Articulos> listaArticulos;
        public frmPrincipal()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            ControladorArticulos negocio = new ControladorArticulos();
            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["ID"].Visible = false;
                dgvArticulos.Columns["ImagenUrl"].Visible = false;
                CargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://cdn.onlinewebfonts.com/svg/img_526949.png");
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ControladorArticulos controlador = new ControladorArticulos();
            Cargar();     
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
            Cargar();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            frmDetalle detalle = new frmDetalle(seleccionado);
            detalle.ShowDialog();
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulos seleccionado;
            seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            frmAgregar modificar = new frmAgregar(seleccionado);
            modificar.ShowDialog();
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ControladorArticulos controlador = new ControladorArticulos();
            Articulos seleccionado; 
            try
            {
                DialogResult eliminar = MessageBox.Show("¿Eliminar registro?", "Eliminando registro", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (eliminar == DialogResult.Yes)
                {
                    seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                    controlador.Eliminar(seleccionado.ID);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void dgvArticulos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
            CargarImagen(seleccionado.ImagenUrl);
        }

        SqlConnection conexion = new SqlConnection("server=.\\SQLEXPRESS; database=CATALOGO_DB; integrated security=true");

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            string query;
            if (rbtNombre.Checked)
            {
                if (rbtIgual.Checked)
                {
                    query = "Select * From Articulos where Nombre = '" + txtCriterio.Text + "'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvArticulos.DataSource = tabla;
                }
                if (rbtMayor.Checked)
                {
                    query = "Select * From Articulos where Nombre > '" + txtCriterio.Text + "'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvArticulos.DataSource = tabla;
                }
                if (rbtMenor.Checked)
                {
                    query = "Select * From Articulos where Nombre < '" + txtCriterio.Text + "'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvArticulos.DataSource = tabla;

                }
            }
            if (rbtMarca.Checked)
            {
                if (rbtIgual.Checked)
                {
                    query = "Select * From Articulos where idMarca = '" + txtCriterio.Text + "'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvArticulos.DataSource = tabla;
                }
                if (rbtMayor.Checked)
                {
                    query = "Select * From Articulos where idMarca > '" + txtCriterio.Text + "'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvArticulos.DataSource = tabla;
                }
                if (rbtMenor.Checked)
                {
                    query = "Select * From Articulos where idMarca < '" + txtCriterio.Text + "'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvArticulos.DataSource = tabla;
                }
            }
            if (rbtDescripcion.Checked)
            {
                if (rbtIgual.Checked)
                {
                    query = "Select * From Articulos where Descripcion = '" + txtCriterio.Text + "'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvArticulos.DataSource = tabla;
                }
                if (rbtMayor.Checked)
                {
                    query = "Select * From Articulos where Descripcion > '" + txtCriterio.Text + "'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvArticulos.DataSource = tabla;
                }
                if (rbtMenor.Checked)
                {
                    query = "Select * From Articulos where Descripcion < '" + txtCriterio.Text + "'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvArticulos.DataSource = tabla;
                }
            }
            if (rbtPrecio.Checked)
            {
                if (rbtIgual.Checked)
                {
                    query = "Select * From Articulos where Precio = '" + decimal.Parse(txtCriterio.Text) + "'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvArticulos.DataSource = tabla;
                }
                if (rbtMayor.Checked)
                {
                    query = "Select * From Articulos where Precio > '" + txtCriterio.Text + "'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvArticulos.DataSource = tabla;
                }
                if (rbtMenor.Checked)
                {
                    query = "Select * From Articulos where Precio < '" + txtCriterio.Text + "'";
                    SqlCommand comando = new SqlCommand(query, conexion);
                    SqlDataAdapter data = new SqlDataAdapter(comando);
                    DataTable tabla = new DataTable();
                    data.Fill(tabla);
                    dgvArticulos.DataSource = tabla;
                }
            }
        }
    }
}
