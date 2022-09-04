using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Controlador;

namespace Dominio
{
    public class Articulos
    {
        public int ID { get; set; }
        public string Codigo { get; set; }
        public string Nombre { get; set; }
        public string Descripcion { get; set; }
        public Marcas Marca { get; set; }
        public Categorias Categoria { get; set; }
        public string ImagenUrl { get; set; }
        public float Precio { get; set; } //Ver Decimal - Float

        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setConsulta("SELECT Id, Codigo, Nombre, Descripcion, IdMarca, IdCategoria, ImagenUrl, Precio FROM ARTICULOS");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.ID = (int)accesoDatos.Lector[ID];
                    aux.Codigo = (string)accesoDatos.Lector[Codigo];
                    aux.Nombre = (string)accesoDatos.Lector[Nombre];
                    aux.Descripcion = (string)accesoDatos.Lector[Descripcion];
                    aux.Marca.ID = (int)accesoDatos.Lector[Marca.ID];
                    aux.Categoria.ID = (int)accesoDatos.Lector[Categoria.ID];
                    aux.ImagenUrl = (string)accesoDatos.Lector[ImagenUrl];
                    aux.Precio = accesoDatos.Lector.GetFloat(7);

                    lista.Add(aux);
                }

                return lista;
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                accesoDatos.cerrarConexion();
            }
        }
    }
}
