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
    public partial class frmDetalle : Form
    {        
        public frmDetalle(Articulos articulos)
        {
            InitializeComponent();
            Cargar(articulos); 
        }

        public void Cargar(Articulos articulo)
        {
            CargarImagen(articulo.ImagenUrl);
            lblNombre.Text = articulo.Nombre;
            txtCodigo.Text = articulo.Codigo;
            txtMarca.Text = articulo.Marca.Descripcion;
            txtCategoria.Text = articulo.Categoria.Descripcion;
            string precio = articulo.Precio.ToString();
            txtPrecio.Text = precio;
            txtDescripcion.Text = articulo.Descripcion;
        }

        void CargarImagen(string imagen)
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

    }
}
