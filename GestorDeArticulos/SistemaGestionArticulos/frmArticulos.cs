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

namespace SistemaGestionArticulos
{
    public partial class frmArticulos: Form
    {
        public frmArticulos()
        {
            InitializeComponent();
        }

        private void Form1_Load(object sender, EventArgs e)
        {
            ArticuloNegocio negocio = new ArticuloNegocio();
            List<Articulo> listaArticulos = new List<Articulo>();
            Articulo articulo = new Articulo();

            try
            {
                listaArticulos = negocio.listar();
                dgvArticulos.DataSource = listaArticulos;
                dgvArticulos.Columns["Precio"].DefaultCellStyle.Format = "N2";
                dgvArticulos.Columns["UrlImagen"].Visible = false;
                dgvArticulos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.AllCells;
                pbArticulos.Load(listaArticulos[0].UrlImagen);
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
    }
}
