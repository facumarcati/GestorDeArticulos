﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    public class ArticuloNegocio
    {
        public List<Articulo> listar()
        {
			AccesoDatos datos = new AccesoDatos();
			List<Articulo> lista = new List<Articulo>();

			try
			{
				string consulta = "select a.Id, Codigo, Nombre, a.Descripcion, IdMarca, M.Descripcion as Marca, IdCategoria, c.Descripcion as Categoria, ImagenUrl, Precio from ARTICULOS A inner join CATEGORIAS C on C.Id = a.IdCategoria inner join MARCAS M on M.Id = a.IdMarca";
				datos.setearConsulta(consulta);
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Articulo aux = new Articulo();
					aux.Id = (int)datos.Lector["Id"];
					aux.Codigo = (string)datos.Lector["Codigo"];
					aux.Nombre = (string)datos.Lector["Nombre"];
					aux.Descripcion = (string)datos.Lector["Descripcion"];
					aux.Marca = new Marca();
					aux.Marca.Id = (int)datos.Lector["IdMarca"];
					aux.Marca.Descripcion = (string)datos.Lector["Marca"];
					aux.Categoria = new Categoria();
					aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
					aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull)){
						aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
					}
                    aux.Precio = Math.Round((decimal)datos.Lector["Precio"], 2);

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
				datos.cerrarConexion();
			}
        }

		public bool agregarArticulo(Articulo nuevo)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				string consulta = "insert into ARTICULOS (Codigo,Nombre,Descripcion,IdMarca,IdCategoria,ImagenUrl,Precio) values (@Codigo,@Nombre,@Descripcion,@IdMarca,@IdCategoria,@ImagenUrl,CONVERT(MONEY, @Precio))";
				datos.setearConsulta(consulta);
				datos.setearParametros("@Codigo", nuevo.Codigo);
				datos.setearParametros("@Nombre", nuevo.Nombre);
				datos.setearParametros("@Descripcion", nuevo.Descripcion);
				datos.setearParametros("@IdMarca", nuevo.Marca.Id);
				datos.setearParametros("@IdCategoria", nuevo.Categoria.Id);
				datos.setearParametros("@ImagenUrl", nuevo.UrlImagen);
				datos.setearParametros("@Precio", nuevo.Precio);
				datos.ejecutarAccion();

				return true;
			}
			catch (Exception)
			{
				return false;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}

		public void eliminarArticulo(int id)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				string consulta = "delete from ARTICULOS where Id = @Id";
				datos.setearConsulta(consulta);
				datos.setearParametros("@Id", id);
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

		public bool modificarArticulo(Articulo articulo)
		{
			AccesoDatos datos = new AccesoDatos();

			try
			{
				string consulta = "update ARTICULOS set Codigo = @Codigo, Nombre = @Nombre, Descripcion = @Descripcion, IdMarca = @IdMarca, IdCategoria = @IdCategoria, ImagenUrl = @ImagenUrl, Precio = @Precio where Id = @Id";
				datos.setearConsulta(consulta);
				datos.setearParametros("@Codigo", articulo.Codigo);
				datos.setearParametros("@Nombre", articulo.Nombre);
				datos.setearParametros("@Descripcion", articulo.Descripcion);
				datos.setearParametros("@IdMarca", articulo.Marca.Id);
				datos.setearParametros("@IdCategoria", articulo.Categoria.Id);
				datos.setearParametros("@ImagenUrl", articulo.UrlImagen);
				datos.setearParametros("@Precio", articulo.Precio);
				datos.setearParametros("@Id", articulo.Id);
				datos.ejecutarAccion();

				return true;
			}
			catch (Exception)
			{
				return false;
			}
			finally
			{
				datos.cerrarConexion();
			}
		}

		public List<Articulo> filtrar(string categoria, string marca)
		{
			AccesoDatos datos = new AccesoDatos();
			List<Articulo> listaFiltrada = new List<Articulo>();

			try
			{
				string consulta = "select a.Id, Codigo, Nombre, a.Descripcion, IdMarca, M.Descripcion as Marca, IdCategoria, c.Descripcion as Categoria, ImagenUrl, Precio from ARTICULOS A inner join CATEGORIAS C on C.Id = a.IdCategoria inner join MARCAS M on M.Id = a.IdMarca where m.Descripcion like @Marca and c.Descripcion like @Categoria";
				datos.setearConsulta(consulta);
				datos.setearParametros("@Marca", marca);
				datos.setearParametros("@Categoria", categoria);
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
					Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }
                    aux.Precio = Math.Round((decimal)datos.Lector["Precio"], 2);

					listaFiltrada.Add(aux);
                }

				return listaFiltrada;
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

		public List<Articulo> filtrar(string campo, string criterio, string filtro)
		{
			AccesoDatos datos = new AccesoDatos();
			List<Articulo> listaFiltrada = new List<Articulo>();

			try
			{
				string consulta = "select a.Id, Codigo, Nombre, a.Descripcion, IdMarca, M.Descripcion as Marca, IdCategoria, c.Descripcion as Categoria, ImagenUrl, Precio from ARTICULOS A inner join CATEGORIAS C on C.Id = a.IdCategoria inner join MARCAS M on M.Id = a.IdMarca where ";

				if(campo == "Precio")
				{
					switch (criterio)
					{
						case "Mayor a":
							consulta += "a.Precio > " + filtro;
							break;
						case "Menor a":
							consulta += "a.Precio < " + filtro;
							break;
						case "Igual a":
							consulta += "a.Precio = " + filtro;
							break;
						default:
							break;
					}
				}
				if(campo == "Codigo")
				{
                    switch (criterio)
                    {
                        case "Comienza con":
							consulta += "Codigo like '" + filtro + "%'";
                            break;
						case "Termina con":
							consulta += "Codigo like '%" + filtro + "'";
							break;
						case "Contiene":
							consulta += "Codigo like '%" + filtro + "%'";
							break;
                        default:
                            break;
                    }
                }
				if(campo == "Nombre")
				{
                    switch (criterio)
                    {
                        case "Comienza con":
                            consulta += "Nombre like '" + filtro + "%'";
                            break;
                        case "Termina con":
                            consulta += "Nombre like '%" + filtro + "'";
                            break;
                        case "Contiene":
                            consulta += "Nombre like '%" + filtro + "%'";
                            break;
                        default:
                            break;
                    }
                }

				datos.setearConsulta(consulta);
				datos.ejecutarLectura();

				while (datos.Lector.Read())
				{
                    Articulo aux = new Articulo();
                    aux.Id = (int)datos.Lector["Id"];
                    aux.Codigo = (string)datos.Lector["Codigo"];
                    aux.Nombre = (string)datos.Lector["Nombre"];
                    aux.Descripcion = (string)datos.Lector["Descripcion"];
                    aux.Marca = new Marca();
                    aux.Marca.Id = (int)datos.Lector["IdMarca"];
                    aux.Marca.Descripcion = (string)datos.Lector["Marca"];
                    aux.Categoria = new Categoria();
                    aux.Categoria.Id = (int)datos.Lector["IdCategoria"];
                    aux.Categoria.Descripcion = (string)datos.Lector["Categoria"];
                    if (!(datos.Lector["ImagenUrl"] is DBNull))
                    {
                        aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
                    }
                    aux.Precio = Math.Round((decimal)datos.Lector["Precio"], 2);

                    listaFiltrada.Add(aux);
                }

				return listaFiltrada;
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
    }
}
