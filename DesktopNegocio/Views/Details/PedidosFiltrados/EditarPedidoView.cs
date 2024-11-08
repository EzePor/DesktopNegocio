using DesktopNegocio.Enums;
using DesktopNegocio.Interfaces;
using DesktopNegocio.Models.Commos;
using DesktopNegocio.Models.Details;
using DesktopNegocio.Services;
using DesktopNegocio.Util;
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
    public partial class EditarPedidoView : Form
    {
        IGenericService<Pedido> pedidoService = new GenericService<Pedido>();
        IGenericService<Cliente> clienteService = new GenericService<Cliente>();
        IGenericService<Producto> productoService = new GenericService<Producto>();
        IGenericService<ModoPago> modoPagoService = new GenericService<ModoPago>();
        IGenericService<Impresion> impresionService = new GenericService<Impresion>();
        IGenericService<DetalleProducto> detalleProductoService = new GenericService<DetalleProducto>();
        IGenericService<DetalleImpresion> detalleImpresionService = new GenericService<DetalleImpresion>();

        List<Cliente> listaClientes = new List<Cliente>();
        List<Producto> listaProductos = new List<Producto>();
        List<ModoPago> listaModosPagos = new List<ModoPago>();
        List<Impresion> listaImpresiones = new List<Impresion>();
        List<DetalleProducto>? listaDetallesProducto = new List<DetalleProducto>();
        List<DetalleImpresion>? listaDetallesImpresion = new List<DetalleImpresion>();
        List<Pedido>? listaPedidos = new List<Pedido>();

        BindingSource bindingPedidos = new BindingSource();
        DataTable dataTable;
        Pedido pedidoActual; // El pedido que se está editando

        public EditarPedidoView(int pedidoId)
        {
            InitializeComponent();
            initializeDataGrid();

            // Cargar el pedido seleccionado primero para obtener el ClienteId correcto
            CargarPedidoExistente(pedidoId);
        }



        private async Task CargarPedidoExistente(int pedidoId)
        {
            ShowInActivity.Show("Descargando/actualizando pedidos ...");
            pedidoActual = await pedidoService.GetByIdAsync(pedidoId);
            ShowInActivity.Hide();

            if (pedidoActual != null)
            {
                // Cargar los combos después de tener el pedido
                await CargarCombos();

                // Asigna valores a los controles del formulario
                cboClientes.SelectedValue = pedidoActual.ClienteId;
                cboModoPagos.SelectedValue = pedidoActual.ModoPagoId;
                cboEstadosPedidos.SelectedItem = pedidoActual.estadoPedido;
                cbFuePagado.Checked = pedidoActual.FuePagado;

                // Deshabilitar el combo de cliente para que no se pueda editar
                cboClientes.Enabled = false;

                // Cargar detalles de productos e impresiones en el DataTable
                foreach (var detalleProducto in pedidoActual.DetallesProducto)
                {
                    DataRow row = dataTable.NewRow();
                    row["id"] = detalleProducto.ProductoId;
                    row["ProductoId"] = detalleProducto.ProductoId;
                    row["nombre"] = detalleProducto.producto.nombre;
                    row["cantidad"] = detalleProducto.cantidad;
                    row["precioUnitario"] = detalleProducto.precioUnitario;
                    row["total"] = detalleProducto.cantidad * detalleProducto.precioUnitario;
                    row["Tipo"] = "Producto";
                    dataTable.Rows.Add(row);
                }

                foreach (var detalleImpresion in pedidoActual.DetallesImpresion)
                {
                    DataRow row = dataTable.NewRow();
                    row["id"] = detalleImpresion.ImpresionId;
                    row["ImpresionId"] = detalleImpresion.ImpresionId;
                    row["nombre"] = detalleImpresion.impresion.tamanio;
                    row["cantidad"] = detalleImpresion.cantidad;
                    row["precioUnitario"] = detalleImpresion.precioUnitario;
                    row["total"] = detalleImpresion.cantidad * detalleImpresion.precioUnitario;
                    row["Tipo"] = "Impresion";
                    dataTable.Rows.Add(row);
                }

                CalcularTotalPedido();
            }
            else
            {
                MessageBox.Show("No se pudo cargar el pedido.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                Close();
            }
        }

        private async Task CargarCombos()
        {
            listaClientes = await clienteService.GetAllAsync();
            listaProductos = await productoService.GetAllAsync();
            listaModosPagos = await modoPagoService.GetAllAsync();
            listaImpresiones = await impresionService.GetAllAsync();

            cboClientes.DataSource = listaClientes;
            cboClientes.DisplayMember = "apellidoNombre";
            cboClientes.ValueMember = "id";

            cboModoPagos.DataSource = listaModosPagos;
            cboModoPagos.DisplayMember = "nombre";
            cboModoPagos.ValueMember = "id";
            cboEstadosPedidos.DataSource = Enum.GetValues(typeof(EstadoPedidoEnum));

            // Actualizar combos de productos e impresiones
            cboProductos.DataSource = listaProductos;
            cboProductos.DisplayMember = "nombre";
            cboProductos.ValueMember = "id";

            cboImpresiones.DataSource = listaImpresiones;
            cboImpresiones.DisplayMember = "tamanio";
            cboImpresiones.ValueMember = "id";

        }

        private async Task CargarCombos(int pedidoId)
        {


        }

        private void CalcularTotalPedido()
        {
            decimal totalPedido = dataTable.AsEnumerable().Sum(row => row.Field<decimal>("total"));
            lbltotalPedido.Text = $"{totalPedido:C}";
        }

        private void initializeDataGrid()
        {
            dataTable = new DataTable();
            dataTable.Columns.Add("id", typeof(int));
            dataTable.Columns.Add("ProductoId", typeof(int));
            dataTable.Columns.Add("ImpresionId", typeof(int));
            dataTable.Columns.Add("nombre", typeof(string));
            dataTable.Columns.Add("cantidad", typeof(int));
            dataTable.Columns.Add("precioUnitario", typeof(decimal));
            dataTable.Columns.Add("total", typeof(decimal));
            dataTable.Columns.Add("Tipo", typeof(string));

            bindingPedidos.DataSource = dataTable;
            dataGridDetallePedido.DataSource = bindingPedidos;
            dataGridDetallePedido.Columns["id"].Visible = false;
            dataGridDetallePedido.Columns["ProductoId"].Visible = false;
            dataGridDetallePedido.Columns["ImpresionId"].Visible = false;
            dataGridDetallePedido.Columns["Tipo"].Visible = false;

            dataGridDetallePedido.Columns["nombre"].HeaderText = "Nombre";
            dataGridDetallePedido.Columns["cantidad"].HeaderText = "Cantidad";
            dataGridDetallePedido.Columns["precioUnitario"].HeaderText = "Precio Unitario";
            dataGridDetallePedido.Columns["precioUnitario"].DefaultCellStyle.Format = "N2";
            dataGridDetallePedido.Columns["total"].DefaultCellStyle.Format = "N2";
            dataGridDetallePedido.Columns["total"].HeaderText = "Total";

            dataGridDetallePedido.DefaultCellStyle.Font = new Font("Bahnschrift", 10);
            dataGridDetallePedido.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 12, FontStyle.Bold);

            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };
            dataGridDetallePedido.Columns.Add(btnEliminar);
        }

        // declarar un evento para notificar que el pedido ha sido actualizado
        public event Action PedidoEditado;

        private async void iconButtonGuardar_Click(object sender, EventArgs e)
        {
            {
                try
                {
                    pedidoActual.ClienteId = (int)cboClientes.SelectedValue;
                    pedidoActual.ModoPagoId = (int)cboModoPagos.SelectedValue;
                    pedidoActual.estadoPedido = (EstadoPedidoEnum)cboEstadosPedidos.SelectedItem;
                    pedidoActual.FuePagado = cbFuePagado.Checked;

                    // Obtener los detalles actuales de productos e impresiones en el pedido
                    var detallesProductoNuevos = dataTable.AsEnumerable()
                        .Where(row => row.Field<string>("Tipo") == "Producto")
                        .Select(row => new DetalleProducto
                        {
                            ProductoId = row.Field<int>("ProductoId"),
                            cantidad = row.Field<int>("cantidad"),
                            precioUnitario = row.Field<decimal>("precioUnitario")
                        }).ToList();

                    var detallesImpresionNuevos = dataTable.AsEnumerable()
           .Where(row => row.Field<string>("Tipo") == "Impresion")
           .Select(row => new DetalleImpresion
           {
               ImpresionId = row.Field<int>("ImpresionId"),
               cantidad = row.Field<int>("cantidad"),
               precioUnitario = row.Field<decimal>("precioUnitario")
           }).ToList();

                    // Comparar productos originales con los nuevos para determinar cambios
                    var productosEliminados = pedidoActual.DetallesProducto
                        .Where(dp => !detallesProductoNuevos.Any(dpn => dpn.ProductoId == dp.ProductoId)).ToList();

                    var productosModificados = pedidoActual.DetallesProducto
                        .Where(dp => detallesProductoNuevos.Any(dpn => dpn.ProductoId == dp.ProductoId && dpn.cantidad != dp.cantidad)).ToList();

                    var productosNuevos = detallesProductoNuevos
                        .Where(dpn => !pedidoActual.DetallesProducto.Any(dp => dp.ProductoId == dpn.ProductoId)).ToList();
                    // Actualizar stock de productos eliminados
                    foreach (var productoEliminado in productosEliminados)
                    {
                        var producto = await productoService.GetByIdAsync(productoEliminado.ProductoId);
                        producto.stock += productoEliminado.cantidad;
                        await productoService.UpdateAsync(producto);
                    }

                    // Actualizar stock de productos modificados
                    foreach (var productoModificado in productosModificados)
                    {
                        var detalleNuevo = detallesProductoNuevos.First(dpn => dpn.ProductoId == productoModificado.ProductoId);
                        int diferenciaCantidad = detalleNuevo.cantidad - productoModificado.cantidad;

                        var producto = await productoService.GetByIdAsync(productoModificado.ProductoId);
                        producto.stock -= diferenciaCantidad;
                        await productoService.UpdateAsync(producto);
                    }


                    // Actualizar stock de productos nuevos
                    foreach (var productoNuevo in productosNuevos)
                    {
                        var producto = await productoService.GetByIdAsync(productoNuevo.ProductoId);
                        producto.stock -= productoNuevo.cantidad;
                        await productoService.UpdateAsync(producto);
                    }

                    // Actualizar los detalles en el pedido actual y guardar cambios
                    pedidoActual.DetallesProducto = detallesProductoNuevos;
                    pedidoActual.DetallesImpresion = detallesImpresionNuevos;

                    await pedidoService.UpdateAsync(pedidoActual);

                    // Notificar que el pedido ha sido actualizado
                    PedidoEditado?.Invoke();

                    MessageBox.Show("Pedido actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);


                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al actualizar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            if (cboProductos.SelectedItem != null)
            {
                var producto = (Producto)cboProductos.SelectedItem;
                var cantidad = 1; // Puedes permitir al usuario ingresar la cantidad si lo deseas
                var precioUnitario = producto.precio;

                if (producto.stock >= cantidad)
                {
                    DataRow row = dataTable.NewRow();
                    row["id"] = producto.id;
                    row["ProductoId"] = producto.id;
                    row["nombre"] = producto.nombre;
                    row["cantidad"] = cantidad;
                    row["precioUnitario"] = precioUnitario;
                    row["total"] = cantidad * precioUnitario;
                    row["Tipo"] = "Producto";
                    dataTable.Rows.Add(row);

                    CalcularTotalPedido();
                }
                else
                {
                    MessageBox.Show("No hay suficiente stock para este producto.", "Stock Insuficiente", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }

        private void btnAgregarImpresion_Click(object sender, EventArgs e)
        {
            if (cboImpresiones.SelectedItem != null)
            {
                var impresion = (Impresion)cboImpresiones.SelectedItem;
                var cantidad = 1; // Puedes permitir al usuario ingresar la cantidad si lo deseas
                var precioUnitario = impresion.precioBase;

                DataRow row = dataTable.NewRow();
                row["id"] = impresion.id;
                row["ImpresionId"] = impresion.id;
                row["nombre"] = impresion.tamanio;
                row["cantidad"] = cantidad;
                row["precioUnitario"] = precioUnitario;
                row["total"] = cantidad * precioUnitario;
                row["Tipo"] = "Impresion";
                dataTable.Rows.Add(row);

                CalcularTotalPedido();
            }
        }

        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.OK;
            this.Close();
        }

        private void dataGridDetallePedido_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridDetallePedido.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                DataRow row = dataTable.Rows[e.RowIndex];
                int id = Convert.ToInt32(row["id"]);
                int cantidad = Convert.ToInt32(row["cantidad"]);
                string tipo = row["Tipo"].ToString();

                if (tipo == "Producto")
                {
                    var producto = listaProductos.FirstOrDefault(p => p.id == id);
                    if (producto != null)
                    {
                        producto.stock += cantidad; // Restablecer stock si era un producto ya en el pedido
                    }
                }
               

                // Eliminar la fila del detalle visualmente
                dataTable.Rows.Remove(row);
                CalcularTotalPedido();
            }
        }
    }

}
