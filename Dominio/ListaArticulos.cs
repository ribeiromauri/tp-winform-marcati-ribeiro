using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Controlador;

namespace Dominio
{
    public class ListaArticulos
    {
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
                    aux.ID = (int)accesoDatos.Lector["Id"];
                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    aux.idMarca = (int)accesoDatos.Lector["IdMarca"];
                    aux.idCategoria = (int)accesoDatos.Lector["IdCategoria"];
                    aux.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];
                    aux.Precio = (decimal)accesoDatos.Lector["Precio"];

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
