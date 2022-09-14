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
    public partial class frmAgregarMarca : Form
    {
        public frmAgregarMarca()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ControladorMarcas controlador = new ControladorMarcas();
            try
            {
                Marcas marcas = new Marcas();
                if (validarFormulario())
                {
                    return;
                }
                marcas.Descripcion = txtDesMarcas.Text;

                controlador.Agregar(marcas);
                MessageBox.Show("Se agregó la marca con éxito");

                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.ToString());
            }
        } 

        private bool validarFormulario()
        {
            ControladorMarcas controlador = new ControladorMarcas();
            if (string.IsNullOrEmpty(txtDesMarcas.Text))
            {
                MessageBox.Show("Completar campos requeridos (*)");
                return true;
            }
            if (controlador.ComprobarRegistro(txtDesMarcas.Text))
            {
                MessageBox.Show("Ya existe una categoria con la misma descripción. Intente nuevamente");
                return true;
            }
            return false;
        }
    }
}
