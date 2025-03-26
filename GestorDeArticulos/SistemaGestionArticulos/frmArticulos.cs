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
        private List<Articulo> listaArticulos;
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
                modificarColumnas();
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

                cbxCampo.Items.Add("Codigo");
                cbxCampo.Items.Add("Nombre");
                cbxCampo.Items.Add("Precio");

                cargar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void cargarImagen(string imagen)
        {
            try
            {
                pbArticulos.Load(imagen);
            }
            catch (Exception)
            {
                pbArticulos.Load("https://media.istockphoto.com/id/1147544807/vector/thumbnail-image-vector-graphic.jpg?s=612x612&w=0&k=20&c=rnCKVbdxqkjlcs3xH87-9gocETqpspHFXu5dIGB4wuM=");
            }
        }

        private void dgvArticulos_SelectionChanged(object sender, EventArgs e)
        {
            try
            {
                Articulo articuloSeleccionado = (Articulo)dgvArticulos.CurrentRow.DataBoundItem;
                cargarImagen(articuloSeleccionado.UrlImagen);
            }
            catch (Exception ex)
            {
                throw ex;
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

        private void cbxCampo_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cbxCampo.SelectedItem.ToString() == "Precio")
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Mayor a");
                cbxCriterio.Items.Add("Menor a");
                cbxCriterio.Items.Add("Igual a");
            }
            else
            {
                cbxCriterio.Items.Clear();
                cbxCriterio.Items.Add("Comienza con");
                cbxCriterio.Items.Add("Termina con");
                cbxCriterio.Items.Add("Contiene");
            }
        }

        private void btnLimpiarFIltro_Click(object sender, EventArgs e)
        {
            try
            {
                txtFiltro.Text = "";
                cargar();
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                txtFiltro.Text = "";
                string categoria = cbxCategoria.SelectedItem.ToString();
                string marca = cbxMarca.SelectedItem.ToString();

                listaArticulos = negocio.filtrar(categoria, marca);
                if (listaArticulos.Count == 0)
                {
                    MessageBox.Show("No hay articulos con esa Categoria y Marca");
                    return;
                }
                dgvArticulos.DataSource = listaArticulos;
                modificarColumnas();
                cargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }

        private void modificarColumnas()
        {
            dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N2";
            dgvArticulos.Columns["UrlImagen"].Visible = false;
            dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
        }

        public void controladorDGV(List<Articulo> listaArticulos)
        {
            dgvArticulos.DataSource = null;
            dgvArticulos.DataSource = listaArticulos;
        }

        private void txtFiltro_TextChanged(object sender, EventArgs e)
        {
            List<Articulo> listaFiltrada;
            ArticuloNegocio negocio = new ArticuloNegocio();
            string filtro = txtFiltro.Text;
            controladorDGV(listaArticulos = negocio.listar());

            if (filtro != "")
            {
                listaFiltrada = listaArticulos.FindAll(x => x.Nombre.ToUpper().Contains(filtro.ToUpper()));
            }
            else
            {
                listaFiltrada = listaArticulos;
            }

            controladorDGV(listaFiltrada);
            modificarColumnas();
        }

        private bool validarFiltro()
        {
            if (cbxCampo.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un campo para filtrar");
                return true;
            }
            if (cbxCriterio.SelectedIndex < 0)
            {
                MessageBox.Show("Seleccione un criterio para filtrar");
                return true;
            }
            if (cbxCampo.SelectedItem.ToString() == "Precio")
            {
                if (!(soloNumeros(txtFiltroAvanzado.Text)))
                {
                    MessageBox.Show("Ingresar solo numeros");
                    return true;
                }
                if (txtFiltroAvanzado.Text == "")
                {
                    return true;
                }
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

        private void btnFiltrarAvanzado_Click(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();

            try
            {
                if (validarFiltro())
                {
                    return;
                }

                string campo = cbxCampo.SelectedItem.ToString();
                string criterio = cbxCriterio.SelectedItem.ToString();
                string filtro = txtFiltroAvanzado.Text;

                listaArticulos = negocio.filtrar(campo, criterio, filtro);
                dgvArticulos.DataSource = listaArticulos;
                modificarColumnas();
                cargarImagen(listaArticulos[0].UrlImagen);
            }
            catch (Exception ex)
            {
                throw ex;
            }
        }
    }
}
