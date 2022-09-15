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
    public partial class frmMenuCategorias : Form
    {
        private List<Categorias> listaCategorias;
        public frmMenuCategorias()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            ControladorCategorias negocio = new ControladorCategorias();
            try
            {
                listaCategorias = negocio.listar();
                dgvCategorias.DataSource = listaCategorias;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMenuCategorias_Load(object sender, EventArgs e)
        {
            ControladorCategorias controlador = new ControladorCategorias();
            Cargar();
        }

        private void txtBuscarCategoria_TextChanged(object sender, EventArgs e)
        {
            List<Categorias> listaFiltro;
            string filtro = txtBuscarCategoria.Text;

            if (filtro != null)
            {
                listaFiltro = listaCategorias.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltro = listaCategorias;
            }

            dgvCategorias.DataSource = null;
            dgvCategorias.DataSource = listaFiltro;
        }

        private void btnAgregarCat_Click(object sender, EventArgs e)
        {
            frmAgregarCategoria agregar = new frmAgregarCategoria();
            agregar.ShowDialog();
            Cargar();
        }

        private void btnEliminarCat_Click(object sender, EventArgs e)
        {
            ControladorCategorias controlador = new ControladorCategorias();
            Categorias seleccionado;
            ControladorArticulos controladorArt = new ControladorArticulos();
            try
            {
                if (dgvCategorias.CurrentRow == null)
                {
                    MessageBox.Show("No hay ninguna categoría seleccionada");
                    return;
                }
                seleccionado = (Categorias)dgvCategorias.CurrentRow.DataBoundItem;
                List<Articulos> lista = new List<Articulos>();
                lista = controladorArt.listar();
                foreach (var item in lista)
                {
                    if (item.Categoria.ID == seleccionado.ID)
                    {
                        MessageBox.Show("No se puede eliminar una categoria que tiene articulos dados de alta");
                        return;
                    }
                }
                DialogResult eliminar = MessageBox.Show("¿Eliminar categoría?", "Eliminando categoría", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (eliminar == DialogResult.Yes)
                {
                    controlador.Eliminar(seleccionado.ID);
                    Cargar();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }
    }
}
