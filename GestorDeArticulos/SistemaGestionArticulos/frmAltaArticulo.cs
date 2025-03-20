using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using dominio;
using negocio;

namespace SistemaGestionArticulos
{
    public partial class frmAltaArticulo : Form
    {
        public frmAltaArticulo()
        {
            InitializeComponent();
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            List<Marca> listaMarca = new List<Marca>();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();
            List<Categoria> listaCategoria = new List<Categoria>();

            listaMarca = negocioMarca.listar();
            listaCategoria = negocioCategoria.listar();

            foreach (var marca in listaMarca)
            {
                cbxMarca.Items.Add(marca);
            }
            foreach (var categoria in listaCategoria)
            {
                cbxCategoria.Items.Add(categoria);
            }

            cbxMarca.SelectedItem = listaMarca[0];
            cbxCategoria.SelectedItem = listaCategoria[0];
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            Articulo nuevo = new Articulo();
            ArticuloNegocio negocio = new ArticuloNegocio();

            // AGREGAR PARA QUE CAPTURE LA MARCA Y LA CATEGORIA

            try
            {
                nuevo.Codigo = txtCodigo.Text;
                nuevo.Nombre = txtNombre.Text;
                nuevo.Descripcion = txtDescripcion.Text;
                nuevo.UrlImagen = txtUrlImagen.Text;
                nuevo.Precio = decimal.Parse(txtPrecio.Text);
                //nuevo.Marca
                //nuevo.Categoria

                if (negocio.agregarArticulo(nuevo))
                {
                    MessageBox.Show("Articulo agregado con exito");
                }

                Close();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void txtUrlImagen_Leave(object sender, EventArgs e)
        {
            cargarImagen(txtUrlImagen.Text);
        }

        public void cargarImagen(string url)
        {
            try
            {
                pbImagenAlta.Load(url);
            }
            catch (Exception)
            {
                pbImagenAlta.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }
    }
}
