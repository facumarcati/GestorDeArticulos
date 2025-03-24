using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using negocio;
using dominio;

namespace presentacion
{
    public partial class frmArticulos: Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        public void cargar()
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArticulos = new List<Articulo>();

            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N2";
                dgvArticulos.Columns["UrlImagen"].Visible = false;
                dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                pbArticulos.Load(listaArticulos[0].UrlImagen);
            }
            catch (Exception)
            {

                throw;
            }
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            MarcaNegocio negocioMarca = new MarcaNegocio();
            CategoriaNegocio negocioCategoria = new CategoriaNegocio();

            try
            {
                cbxMarca.DataSource = negocioMarca.listar();
                cbxCategoria.DataSource = negocioCategoria.listar();
                cargar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cargarImagen()
        {
            Articulo seleccionado;

            if (dgvArticulos.CurrentRow != null)
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                pbArticulos.Load(seleccionado.UrlImagen);
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                cargarImagen();
            }
            catch (Exception)
            {
                pbArticulos.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }

        private void btnAgregar_Click(object sender, EventArgs e)
        {
            frmAltaArticulo alta = new frmAltaArticulo();
            alta.ShowDialog();
            cargar();
        }

        private void btnModificar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;

            frmAltaArticulo modificar = new frmAltaArticulo(seleccionado);
            modificar.ShowDialog();
            cargar();
        }

        private void btnEliminar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                DialogResult response =  MessageBox.Show("Seguro que queres eliminar este articulo?", "Eliminando", MessageBoxButtons.YesNo, MessageBoxIcon.Warning);
                if (response == DialogResult.Yes)
                {
                    seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                    negocio.eliminarArticulo(seleccionado.Id);
                    cargar();
                }
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnMostrar_Click(object sender, EventArgs e)
        {
            Articulo seleccionado;

            try
            {
                seleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                frmAltaArticulo mostrar = new frmAltaArticulo(seleccionado, true);
                mostrar.ShowDialog();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
