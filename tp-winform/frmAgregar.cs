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
using System.IO;
using System.Configuration;

namespace tp_winform
{
    public partial class frmAgregar : Form
    {
        private Articulos articulo = null;
        private OpenFileDialog archivo = null;

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
            lblCodigoRequerido.Text = "";
            lblNombreRequerido.Text = "";
            lblMarcaRequerida.Text = "";
            lblCatRequerida.Text = "";
            lblPrecioRequerido.Text = "";
            lblValidar.Text = "";
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
                if (validarFormulario(articulo))
                {
                    return;
                }
                if(articulo == null)
                {
                    articulo = new Articulos();
                }
                articulo.Codigo = txtCodigo.Text;
                articulo.Nombre = txtNombre.Text;
                articulo.Descripcion = txtDescripcion.Text;
                articulo.Marca = (Marcas)cboMarca.SelectedItem;
                articulo.Categoria = (Categorias)cboCategoria.SelectedItem;
                if (archivo != null && !(txtURL.Text.ToUpper().Contains("HTTP")))
                {
                    File.Copy(archivo.FileName, ConfigurationManager.AppSettings["imagenes-articulos"] + archivo.SafeFileName);
                }
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

        private void btnAltaImagen_Click(object sender, EventArgs e)
        {
            OpenFileDialog archivo = new OpenFileDialog();
            archivo.Filter = "jpg|*.jpg;|png|*.png";
            if(archivo.ShowDialog() == DialogResult.OK)
            {
                txtURL.Text = archivo.FileName;
                CargarImagen(archivo.FileName);
            }
        }

        private bool validarFormulario(Articulos articulo)
        {
            if (articulo != null)
            {
                return false;
            }
            ControladorArticulos controlador = new ControladorArticulos();
            if (string.IsNullOrEmpty(txtCodigo.Text) || string.IsNullOrEmpty(txtNombre.Text) || string.IsNullOrEmpty(txtPrecio.Text))
            {
                MessageBox.Show("Completar campos requeridos (*)");
                return true;
            }
            if (controlador.ComprobarRegistro(txtCodigo.Text))
            {
                MessageBox.Show("Ya existe un registro con el mismo codigo. Intente nuevamente");
                return true;
            }
           
            return false;
        }

        private void txtPrecio_KeyPress(object sender, KeyPressEventArgs e)
        {
            if (!char.IsControl(e.KeyChar) && !char.IsDigit(e.KeyChar) && (e.KeyChar != '.'))
            {
                e.Handled = true;
            }

            // solo 1 decimal
            if ((e.KeyChar == '.') && ((sender as TextBox).Text.IndexOf('.') > -1))
            {
                e.Handled = true;
            }
        }
    }
}
