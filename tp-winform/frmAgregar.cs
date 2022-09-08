using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Dominio;
using Controlador;

namespace tp_winform
{
    public partial class frmAgregar : Form
    {
        public frmAgregar()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            Articulos artNuevo = new Articulos();
            ControladorArticulos controlador = new ControladorArticulos();

            try
            {
                artNuevo.Codigo = txtCodigo.Text;
                artNuevo.Nombre = txtNombre.Text;
                artNuevo.Descripcion = txtDescripcion.Text;
                artNuevo.Marca = (Marcas)cboMarca.SelectedItem;
                artNuevo.Categoria = (Categorias)cboCategoria.SelectedItem;
                artNuevo.ImagenUrl = txtURL.Text;
                artNuevo.Precio = decimal.Parse(txtPrecio.Text);

                controlador.Agregar(artNuevo);
                MessageBox.Show("Se agregó con éxito");
                Close();

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void frmAgregar_Load(object sender, EventArgs e)
        {
            ControladorMarcas marcas = new ControladorMarcas();
            ControladorCategorias categorias = new ControladorCategorias();
            try
            {
                cboMarca.DataSource = marcas.listar();
                cboCategoria.DataSource = categorias.listar();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private void txtURL_Leave(object sender, EventArgs e)
        {
            CargarImagen(txtURL.Text);
        }

        private void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulos.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulos.Load("https://cdn.onlinewebfonts.com/svg/img_526949.png");
                string mensaje = "Error al cargar imagen. Revisar URL";
                MessageBox.Show(mensaje, ex.Message);
            }
        }
    }
}
