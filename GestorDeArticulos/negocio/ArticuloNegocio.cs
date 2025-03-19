using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using dominio;

namespace negocio
{
    class ArticuloNegocio
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
					aux.UrlImagen = (string)datos.Lector["ImagenUrl"];
					aux.Precio = (float)datos.Lector["Precio"];

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
    }
}
