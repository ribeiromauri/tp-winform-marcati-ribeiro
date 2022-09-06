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
    public partial class frmDetalle : Form
    {
        Articulos articulo = new Articulos();
        public frmDetalle(Articulos articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
        }

        private void frmDetalle_Load(object sender, EventArgs e)
        {
            CargarImagen(articulo.ImagenUrl);
            lblNombre.Text = articulo.Nombre;
            txtCodigo2.Text = articulo.Codigo;
            txtMarca.Text = articulo.Marca.Descripcion;
            txtCategoria.Text = articulo.Categoria.Descripcion;
            string precio = articulo.Precio.ToString();
            txtPrecio.Text = precio;
            txtDescripcion.Text = articulo.Descripcion;
        }

        public void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
