﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.SqlClient;
using Dominio;


namespace Controlador
{
    public class ControladorArticulos
    {
        public List<Articulos> listar()
        {
            List<Articulos> lista = new List<Articulos>();

            AccesoDatos accesoDatos = new AccesoDatos();

            try
            {
                accesoDatos.setConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, A.Precio, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.IdMarca, A.IdCategoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdCategoria = C.Id AND A.IdMarca = M.Id");
                //accesoDatos.setConsulta("SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, A.Precio, M.Descripcion AS Marca, C.Descripcion AS Categoria, A.IdMarca, A.IdCategoria FROM ARTICULOS A INNER JOIN MARCAS M ON A.IdMarca = M.Id INNER JOIN CATEGORIAS C ON A.IdCategoria = C.Id");
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.ID = (int)accesoDatos.Lector["ID"];
                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    aux.Marca = new Marcas();
                    aux.Marca.ID = (int)accesoDatos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)accesoDatos.Lector["Marca"];
                    aux.Categoria = new Categorias();
                    aux.Categoria.ID = (int)accesoDatos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)accesoDatos.Lector["Categoria"];
                    if (!(accesoDatos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];
                    }
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

        public void Agregar(Articulos nuevo)
        {
            AccesoDatos datos = new AccesoDatos();

            try
            {
                datos.setConsulta("INSERT INTO ARTICULOS (Codigo, Nombre, Descripcion, IdMarca, IdCategoria, Precio, ImagenUrl) VALUES ('" + nuevo.Codigo + "', '" + nuevo.Nombre + "', '" + nuevo.Descripcion + "', @IdMarca, @IdCategoria, " + nuevo.Precio + ", '@ImagenUrl')");
                datos.setParametro("@IdMarca", nuevo.Marca.ID);
                datos.setParametro("@IdCategoria", nuevo.Categoria.ID);
                datos.setParametro("@ImgenUrl", nuevo.ImagenUrl);
                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Eliminar(int ID)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("DELETE FROM Articulos WHERE Id = @id");
                datos.setParametro("@id", ID);
                datos.ejecutarLectura();
            }
            catch (Exception ex)
            {
                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public void Modificar(Articulos art)
        {
            AccesoDatos datos = new AccesoDatos();
            try
            {
                datos.setConsulta("update ARTICULOS set Codigo = @codigo, Nombre = @nombre, Descripcion = @descripcion, ImagenUrl = @imagen, Precio = @precio, IdMarca = @idMarca, IdCategoria = @idCategoria where Id = @id");
                datos.setParametro("@codigo",art.Codigo);
                datos.setParametro("@nombre",art.Nombre);
                datos.setParametro("@descripcion",art.Descripcion);
                datos.setParametro("@imagen",art.ImagenUrl);
                datos.setParametro("@precio",art.Precio);
                datos.setParametro("@idMarca",art.Marca.ID);
                datos.setParametro("@idCategoria",art.Categoria.ID);
                datos.setParametro("@id",art.ID);

                datos.ejecutarAccion();
            }
            catch (Exception ex)
            {

                throw ex;
            }
            finally
            {
                datos.cerrarConexion();
            }
        }

        public List<Articulos> Filtrar(string columna, string criterio, string valor)
        {
            List<Articulos> lista = new List<Articulos>();
            AccesoDatos accesoDatos = new AccesoDatos();
            try
            {
                string consulta = "SELECT A.Id, A.Codigo, A.Nombre, A.Descripcion, A.ImagenUrl, A.Precio, M.Descripcion Marca, C.Descripcion Categoria, A.IdMarca, A.IdCategoria FROM ARTICULOS A, MARCAS M, CATEGORIAS C WHERE A.IdCategoria = C.Id AND A.IdMarca = M.Id AND ";

                //faltan los otros criterios, pero la consulta siempre tira error. Seleccionar precio < a + valor
                if(columna == "Precio")
                {
                    if(criterio == "Menor a")
                    {
                        consulta += "A.Precio = " + valor;
                    }
                }


                accesoDatos.setConsulta(consulta);
                accesoDatos.ejecutarLectura();

                while (accesoDatos.Lector.Read())
                {
                    Articulos aux = new Articulos();
                    aux.ID = (int)accesoDatos.Lector["ID"];
                    aux.Codigo = (string)accesoDatos.Lector["Codigo"];
                    aux.Nombre = (string)accesoDatos.Lector["Nombre"];
                    aux.Descripcion = (string)accesoDatos.Lector["Descripcion"];
                    aux.Marca = new Marcas();
                    aux.Marca.ID = (int)accesoDatos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)accesoDatos.Lector["Marca"];
                    aux.Categoria = new Categorias();
                    aux.Categoria.ID = (int)accesoDatos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)accesoDatos.Lector["Categoria"];
                    if (!(accesoDatos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.ImagenUrl = (string)accesoDatos.Lector["ImagenUrl"];
                    }
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
