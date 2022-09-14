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
    public partial class frmAgregarCategoria : Form
    {
        public frmAgregarCategoria()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ControladorCategorias controlador = new ControladorCategorias();
            try
            {
                Categorias categorias = new Categorias();
                if (validarFormulario())
                {
                    return;
                }
                categorias.Descripcion = txtDesCategoria.Text;

                controlador.Agregar(categorias);
                MessageBox.Show("Se agregó la categoria con éxito");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        }

        private bool validarFormulario()
        {
            ControladorCategorias articulo = new ControladorCategorias();
            if (string.IsNullOrEmpty(txtDesCategoria.Text))
            {
                MessageBox.Show("Completar campos requeridos (*)");
                return true;
            }
            if (articulo.ComprobarRegistro(txtDesCategoria.Text))
            {
                MessageBox.Show("Ya existe una categoria con la misma descripción. Intente nuevamente");
                return true;
            }
            return false;
        }
    }
}
