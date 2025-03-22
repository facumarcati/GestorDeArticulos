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

namespace presentacion
{
    public partial class frmAltaArticulo : Form
    {
        private Articulo articulo = null;
        public frmAltaArticulo()
        {
            InitializeComponent();
            Text = "Alta Articulo";
        }
        public frmAltaArticulo(Articulo articulo)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Modificar Articulo";
            btnAgregar.Text = "Modificar";
        }
        public frmAltaArticulo(Articulo articulo, bool estado)
        {
            InitializeComponent();
            this.articulo = articulo;
            Text = "Detalle Articulo";
            detalleArticulo();
            btnAgregar.Visible = false;
            btnCancelar.Visible = false;
        }

        private void detalleArticulo()
        {
            txtCodigo.Enabled = false;
            txtNombre.Enabled = false;
            txtDescripcion.Enabled = false;
            txtPrecio.Enabled = false;
            cbxCategoria.DropDownStyle = ComboBoxStyle.Simple;
            cbxCategoria.Enabled = false;
            cbxMarca.DropDownStyle = ComboBoxStyle.Simple;
            cbxMarca.Enabled = false;
            txtUrlImagen.Visible = false;
            lblUrlImagen.Visible = false;
        }

        private void btnCancelar_Click(object sender, EventArgs e)
        {
            Close();
        }

        private void frmAltaArticulo_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();

            try
            {
                cbxMarca.DataSource = negocioMarca.listar();
                cbxMarca.ValueMember = "Id";
                cbxMarca.DisplayMember = "Descripcion";
                cbxCategoria.DataSource = negocioCategoria.listar();
                cbxCategoria.ValueMember = "Id";
                cbxCategoria.DisplayMember = "Descripcion";

                if(articulo != null)
                {
                    txtCodigo.Text = articulo.Codigo;
                    txtNombre.Text = articulo.Nombre;
                    txtDescripcion.Text = articulo.Descripcion;
                    txtUrlImagen.Text = articulo.UrlImagen;
                    cargarImagen(articulo.UrlImagen);
                    txtPrecio.Text = articulo.Precio.ToString();
                    cbxMarca.SelectedValue = articulo.Marca.Id;
                    cbxCategoria.SelectedValue = articulo.Categoria.Id;
                }

            }
            catch (Exception ex)
            {

                throw ex;
            }
        }

        private bool validarArticulo(string articulo)
        {
            if(articulo.Equals(""))
            {
                return true;
            }

            return false;
        }

        private bool validarPrecioArt(string precio)
        {

            if (precio == "")
            {
                return true;
            }
            if (!(soloNumeros(precio)))
            {
                return true;
            }
            if(decimal.Parse(precio) < 0)
            {
                return true;
            }

            return false;
        }

        private bool soloNumeros(string cadena)
        {
            foreach (char caracter in cadena)
            {
                if (!(char.IsNumber(caracter)))
                {
                    return false;
                }
            }

            return true;
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (articulo == null)
                {
                    articulo = new Articulo();
                }

                articulo.Codigo = txtCodigo.Text;
                if (validarArticulo(txtCodigo.Text))
                {
                    MessageBox.Show("El codigo no puede ser vacio");
                    return;
                }
                articulo.Nombre = txtNombre.Text;
                if (validarArticulo(txtNombre.Text))
                {
                    MessageBox.Show("El nombre no puede ser vacio");
                    return;
                }
                articulo.Descripcion = txtDescripcion.Text;
                articulo.UrlImagen = txtUrlImagen.Text;
                if (validarPrecioArt(txtPrecio.Text))
                {
                    MessageBox.Show("Precio no valido");
                    return;
                }
                articulo.Precio = decimal.Parse(txtPrecio.Text);
                articulo.Marca = (Marca)cbxMarca.SelectedItem;
                articulo.Categoria = (Categoria)cbxCategoria.SelectedItem;


                if (articulo.Id == 0)
                {
                    if (negocio.agregarArticulo(articulo))
                    {
                        MessageBox.Show("Articulo agregado con exito");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo agregar el Articulo");
                    }
                }
                else
                {
                    if (negocio.modificarArticulo(articulo))
                    {
                        MessageBox.Show("Articulo modificado con exito");
                    }
                    else
                    {
                        MessageBox.Show("No se pudo modificar el Articulo");
                    }
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
