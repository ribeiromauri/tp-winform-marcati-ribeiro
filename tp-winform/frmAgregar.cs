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
        private Articulos articulo = null;
        public frmAgregar()
        {
            InitializeComponent();
        }

        public frmAgregar(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificacion";
            btnAgregarArticulo.Text = "Modificar";
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregarArticulo_Click(object sender, EventArgs e)
        {
            ControladorArticulos controlador = new ControladorArticulos();

            try
            {
                if(articulo == null)
                {
                    articulo = new Articulos();
                }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marcas)cboMarca.SelectedItem;
                articulo.Categoria = (Categorias)cboCategoria.SelectedItem;
                articulo.ImagenUrl = txtURL.Text;
                articulo.Precio = decimal.Parse(txtPrecio.Text);

                if(articulo.ID != 0)
                {
                    controlador.Modificar(articulo);
                    MessageBox.Show("Se modificó con éxito");
                }
                else
                {
                    controlador.Agregar(articulo);
                    MessageBox.Show("Se agregó con éxito");
                }


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
                cboMarca.ValueMember = "ID";
                cboMarca.DisplayMember = "Descripcion";
                cboCategoria.DataSource = categorias.listar();
                cboCategoria.ValueMember = "ID";
                cboCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtURL.Text = articulo.ImagenUrl;
                    txtPrecio.Text = articulo.Precio.ToString();
                    txtDescripcion.Text = articulo.Descripcion;
                    CargarImagen(articulo.ImagenUrl);
                    cboMarca.SelectedValue = articulo.Marca.ID;
                    cboCategoria.SelectedValue = articulo.Categoria.ID;
                }
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
            }
        }
    }
}
