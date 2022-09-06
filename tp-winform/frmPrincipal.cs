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
                CargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        void CargarImagen(string imagen)
        {
            try
            {
                pbxArticulo.Load(imagen);
            }
            catch (Exception ex)
            {
                pbxArticulo.Load("https://mpng.subpng.com/20180820/iyz/kisspng-computer-icons-vector-graphics-image-icon-design-i-flat-delete-icon-bing-images-5b7b43bfdfb3e4.1170827415348049279163.jpg");
                throw ex;
            }
        }

        private void frmPrincipal_Load(object sender, EventArgs e)
        {
            ControladorArticulos controlador = new ControladorArticulos();
            Cargar();
      
        }

        
    }
}
