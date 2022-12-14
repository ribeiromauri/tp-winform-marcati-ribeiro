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
                ocultarColumnas();
                CargarImagen(listaArticulos[0].ImagenUrl);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void ocultarColumnas()
        {
            dgvArticulos.Columns["ID"].Visible = false;
            dgvArticulos.Columns["ImagenUrl"].Visible = false;
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
            cboCampo.Items.Add("Precio");
            cboCampo.Items.Add("Codigo");
            cboCampo.Items.Add("Nombre");
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAgregar agregar = new frmAgregar();
            agregar.ShowDialog();
            Cargar();
        }

        private void btnDetalle_Click(object sender, EventArgs e)
        {
            if (dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                frmDetalle detalle = new frmDetalle(seleccionado);
                detalle.ShowDialog();
            }
            else
            {
                MessageBox.Show("No hay ningún articulo seleccionado");
                return;
            }
            Cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            if(dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado;
                seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                frmAgregar modificar = new frmAgregar(seleccionado);
                modificar.ShowDialog();
            }
            Cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            ControladorArticulos controlador = new ControladorArticulos();
            Articulos seleccionado; 
            try
            {
                if (dgvArticulos.CurrentRow == null)
                {
                    MessageBox.Show("No hay ningún articulo seleccionado");
                    return;
                }
                DialogResult eliminar = MessageBox.Show("¿Eliminar articulo?", "Eliminando articulo", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
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
            if(dgvArticulos.CurrentRow != null)
            {
                Articulos seleccionado = (Articulos)dgvArticulos.CurrentRow.DataBoundItem;
                CargarImagen(seleccionado.ImagenUrl);
            }
        }

        private void cboColumna_SelectedIndexChanged(object sender, EventArgs e)
        {
            string opcion = cboCampo.SelectedItem.ToString();
            if (opcion == "Precio")
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Menor a");
                cboCriterio.Items.Add("Mayor a");
                cboCriterio.Items.Add("Igual a");
            }

            else
            {
                cboCriterio.Items.Clear();
                cboCriterio.Items.Add("Comienza con");
                cboCriterio.Items.Add("Termina con");
                cboCriterio.Items.Add("Contiene");
            }
        }

        private void txtBuscar_TextChanged(object sender, EventArgs e)
        {
            List<Articulos> listaFiltro;
            string filtro = txtBuscar.Text;

            if (filtro != null)
            {
                listaFiltro = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()) || x.Marca.Descripcion.ToUpper().Contains(filtro.ToUpper()) || x.Categoria.Descripcion.ToUpper().Contains(filtro.ToUpper()) );
            }
            else
            {
                listaFiltro = listaArticulos;
            }

            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaFiltro;
            ocultarColumnas();
        }

        private bool validacionFiltro()
        {
            if(cboCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione una columna");
                return true;
            }
            if(cboCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un criterio");
                return true;
            }
            if(cboCampo.SelectedItem.ToString() == "Precio")
            {
                if (string.IsNullOrEmpty(txtFiltroAvanzado.Text))
                {
                    MessageBox.Show("Completar campo numerico");
                    return true;
                }
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Busqueda por precio solo acepta valores numericos");
                    return true;
                }
            }

            return false;
        }

        private void btnBuscar_Click(object sender, EventArgs e)
        {
            ControladorArticulos negocio = new ControladorArticulos();
            try
            {
                if (validacionFiltro())
                {
                    return;
                }
                string campo = cboCampo.SelectedItem.ToString();
                string criterio = cboCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;
                dgvArticulos.DataSource = negocio.Filtrar(campo, criterio, filtro);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                    return false;
            }
            return true;
        }

        private void btnCategoriasMarcas_Click(object sender, EventArgs e)
        {
            frmMenuCategorias agregar = new frmMenuCategorias();
            agregar.ShowDialog();
            Cargar();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            frmMenuMarcas agregar = new frmMenuMarcas();
            agregar.ShowDialog();
            Cargar();
        }
    }
}
