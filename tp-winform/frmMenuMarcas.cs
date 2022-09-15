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
    public partial class frmMenuMarcas : Form
    {
        private List<Marcas> listaMarcas;
        public frmMenuMarcas()
        {
            InitializeComponent();
        }

        private void Cargar()
        {
            ControladorMarcas negocio = new ControladorMarcas();
            try
            {
                listaMarcas = negocio.listar();
                dgvMarcas.DataSource = listaMarcas;
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void frmMenuMarcas_Load(object sender, EventArgs e)
        {
            ControladorMarcas controlador = new ControladorMarcas();
            Cargar();
        }

        private void txtBuscarMarca_TextChanged(object sender, EventArgs e)
        {
            List<Marcas> listaFiltro;
            string filtro = txtBuscarMarca.Text;

            if (filtro != null)
            {
                listaFiltro = listaMarcas.FindAll(x => x.Descripcion.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltro = listaMarcas;
            }

            dgvMarcas.DataSource = null;
            dgvMarcas.DataSource = listaFiltro;
        }

        private void btnAgregarMarca_Click(object sender, EventArgs e)
        {
            frmAgregarMarca agregar = new frmAgregarMarca();
            agregar.ShowDialog();
            Cargar();
        }

        private void btnEliminarMarca_Click(object sender, EventArgs e)
        {
            ControladorMarcas controlador = new ControladorMarcas();
            Marcas seleccionado;
            ControladorArticulos controladorArt = new ControladorArticulos();
            try
            {
                if (dgvMarcas.CurrentRow == null)
                {
                    MessageBox.Show("No hay ninguna marca seleccionada");
                    return;
                }
                seleccionado = (Marcas)dgvMarcas.CurrentRow.DataBoundItem;
                List<Articulos> lista = new List<Articulos>();
                lista = controladorArt.listar();
                foreach (var item in lista)
                {
                    if (item.Marca.ID == seleccionado.ID)
                    {
                        MessageBox.Show("No se puede eliminar una marca que tiene articulos dados de alta");
                        return;
                    }
                }
                DialogResult eliminar = MessageBox.Show("¿Eliminar marca?", "Eliminando marca", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
