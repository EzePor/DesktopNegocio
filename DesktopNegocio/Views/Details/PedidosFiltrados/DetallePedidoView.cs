using DesktopNegocio.Interfaces;
using DesktopNegocio.Models.Details;
using DesktopNegocio.Services;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopNegocio.Views.Details.PedidosFiltrados
{

    public partial class DetallePedidoView : Form
    {
        IGenericService<Pedido> pedidoService = new GenericService<Pedido>();
        private Pedido pedido;
        public DetallePedidoView(Pedido pedidoSeleccionado)
        {
            InitializeComponent();
            InicializarColumnasDataGrid();
            pedido = pedidoSeleccionado;
            CargarDetalle();
        }

        private void InicializarColumnasDataGrid()
        {
            dataGridDetalle.Columns.Add("Producto", "Producto");
            dataGridDetalle.Columns.Add("Cantidad", "Cantidad");
            dataGridDetalle.Columns.Add("PrecioUnitario", "Precio Unitario");
            dataGridDetalle.Columns.Add("Total", "Total");
        }

        private void CargarDetalle()
        {
            lblPedidoId.Text = pedido.id.ToString();
            lblCliente.Text = pedido.cliente?.apellidoNombre ?? "Cliente no especificado";
            lblFechaPedido.Text = pedido.fechaPedido.ToString("dd/MM/yyyy");
            chFuePagado.Checked = pedido.FuePagado;
            lblEstado.Text = pedido.estadoPedido.ToString();
            lblTotal.Text = pedido.TotalPedido.ToString("C");

            // Llenar la lista de productos en un DataGridView o ListView dentro del formulario
            foreach (var detalle in pedido.DetallesProducto)
            {
                dataGridDetalle.Rows.Add(detalle.producto.nombre, detalle.cantidad, detalle.precioUnitario.ToString("F2"), detalle.total.ToString("F2"));
            }

            // Llenar la lista de impresiones, incluyendo el tamaño de la impresión
            foreach (var impresion in pedido.DetallesImpresion)
            {
                string impresionDescripcion = $"Impresión ({impresion.impresion?.tamanio ?? "Sin tamaño"})";
                dataGridDetalle.Rows.Add(impresionDescripcion, impresion.cantidad, impresion.precioUnitario.ToString("F2"), impresion.total.ToString("F2"));
            }
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }

}
