using DesktopNegocio.Enums;
using DesktopNegocio.Interfaces;
using DesktopNegocio.Models.Commos;
using DesktopNegocio.Models.Details;
using DesktopNegocio.Services;
using DesktopNegocio.Util;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.ComponentModel.DataAnnotations;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using System.Windows.Forms;

namespace DesktopNegocio.Views.Details.CrearPedido
{
    public partial class CrearPedidosView : Form
    {
        IGenericService<Pedido> pedidoService = new GenericService<Pedido>();
        IGenericService<Cliente> clienteService = new GenericService<Cliente>();
        IGenericService<Producto> productoService = new GenericService<Producto>();
        IGenericService<ModoPago> modoPagoService = new GenericService<ModoPago>();
        IGenericService<Impresion> impresionService = new GenericService<Impresion>();
        IGenericService<DetalleProducto> detallePedidoService = new GenericService<DetalleProducto>();
        IGenericService<DetalleImpresion> detalleImpresionService = new GenericService<DetalleImpresion>();
        BindingSource bindingPedidos = new BindingSource();
        List<Cliente>? listaClientes = new List<Cliente>();
        List<Producto>? listaProductos = new List<Producto>();
        List<ModoPago>? listaModosPagos = new List<ModoPago>();
        List<Impresion>? listaImpresiones = new List<Impresion>();
        List<DetalleProducto>? listaDetalleProductos = new List<DetalleProducto>();
        List<DetalleImpresion>? listaDetalleImpresiones = new List<DetalleImpresion>();
        List<Pedido>? listaPedidos = new List<Pedido>();
        Pedido pedido = new Pedido();
        DataTable dataTable;

        public CrearPedidosView()
        {
            InitializeComponent();

            initializeDataGrid();

            CargarCombos();

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

            // Asignar el DataTable al BindingSource
            bindingPedidos.DataSource = dataTable;

            // Asignar el BindingSource al DataGridView
            dataGridDetallePedido.DataSource = bindingPedidos;

            // Configuración de columnas
            dataGridDetallePedido.Columns["id"].Visible = false;
            dataGridDetallePedido.Columns["ProductoId"].Visible = false;
            dataGridDetallePedido.Columns["ImpresionId"].Visible = false;
            dataGridDetallePedido.Columns["Tipo"].Visible = false;
            dataGridDetallePedido.Columns["nombre"].HeaderText = "Nombre";
            dataGridDetallePedido.Columns["cantidad"].HeaderText = "Cantidad";
            dataGridDetallePedido.Columns["precioUnitario"].HeaderText = "Precio Unitario";

            // Formatear la columna precioUnitario para mostrar solo dos decimales
            dataGridDetallePedido.Columns["precioUnitario"].DefaultCellStyle.Format = "N2";
            dataGridDetallePedido.Columns["total"].DefaultCellStyle.Format = "N2";

            dataGridDetallePedido.Columns["total"].HeaderText = "Total";

            // Cambiar tamaño de fuente y estilo
            dataGridDetallePedido.DefaultCellStyle.Font = new Font("Bahnschift", 10);
            dataGridDetallePedido.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschift", 12, FontStyle.Bold);


            DataGridViewButtonColumn btnEliminar = new DataGridViewButtonColumn
            {
                Name = "Eliminar",
                HeaderText = "Eliminar",
                Text = "Eliminar",
                UseColumnTextForButtonValue = true
            };
            dataGridDetallePedido.Columns.Add(btnEliminar);
            dataGridDetallePedido.CellFormatting += (s, e) =>
            {
                if (e.ColumnIndex == dataGridDetallePedido.Columns["Eliminar"].Index)
                {
                    e.CellStyle.BackColor = Color.Red;
                    e.CellStyle.SelectionBackColor = Color.Red;
                    e.CellStyle.ForeColor = Color.White;
                    e.CellStyle.Font = new Font("Bahnschrift", 9, FontStyle.Bold);
                }
            };
        }

        private async void CargarCombos()
        {
            ShowInActivity.Show("Descargando/actualizando ...");

            // Agregar placeholder al cargar combo clientes
            listaClientes = await clienteService.GetAllAsync();
            listaClientes.Insert(0, new Cliente { id = 0, apellidoNombre = "Elija un cliente" });
            cboClientes.DataSource = listaClientes;
            cboClientes.DisplayMember = "apellidoNombre";
            cboClientes.ValueMember = "id";
            cboClientes.SelectedIndex = 0; // Placeholder seleccionado por defecto

            // Agregar placeholder al cargar combo productos
            listaProductos = await productoService.GetAllAsync();
            listaProductos.Insert(0, new Producto { id = 0, nombre = "Elija un producto" });
            cboProductos.DataSource = listaProductos;
            cboProductos.DisplayMember = "nombre";
            cboProductos.ValueMember = "id";
            cboProductos.SelectedIndex = 0;

            // Agregar placeholder al cargar combo modos de pago
            listaModosPagos = await modoPagoService.GetAllAsync();
            listaModosPagos.Insert(0, new ModoPago { id = 0, nombre = "Elija el modo de pago" });
            cboModoPagos.DataSource = listaModosPagos;
            cboModoPagos.DisplayMember = "nombre";
            cboModoPagos.ValueMember = "id";
            cboModoPagos.SelectedIndex = 0;

            // Agregar placeholder al cargar combo impresiones
            listaImpresiones = await impresionService.GetAllAsync();
            listaImpresiones.Insert(0, new Impresion { id = 0, tamanio = "Elija una impresión" });
            cboImpresiones.DataSource = listaImpresiones;
            cboImpresiones.DisplayMember = "tamanio";
            cboImpresiones.ValueMember = "id";
            cboImpresiones.SelectedIndex = 0;

            // Cargar estados de pedido en ComboBox (si es un enum)
            cboEstadosPedidos.DataSource = Enum.GetValues(typeof(EstadoPedidoEnum));

            ShowInActivity.Hide();
        }

        private async void btnAgregarProducto_Click(object sender, EventArgs e)
        {
            // Obtener valores seleccionados y calcular el total
            var producto = (Producto)cboProductos.SelectedItem;
            if(producto == null)
            {
                MessageBox.Show("Debe seleccionar un producto", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }

            int cantidad = (int)cantidadProducto.Value;

            // Verificar si el stock es suficiente
            Producto productoActualizado = await productoService.GetByIdAsync(producto.id); // Consultar el stock actualizado
            if (productoActualizado.stock < cantidad)
            {
                MessageBox.Show($"Stock insuficiente para el producto seleccionado. Stock actual: {productoActualizado.stock}.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return;
            }
            // Calcular el total si el stock es suficiente
            decimal precioUnitario = producto.precio;
            decimal total = cantidad * precioUnitario;

            //verificar si se selecciono un producto correcto
            if (cboProductos.SelectedIndex > 0)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["id"] = producto.id;
                newRow["ProductoId"] = producto.id;
                newRow["nombre"] = producto.nombre;
                newRow["cantidad"] = cantidad;
                newRow["precioUnitario"] = precioUnitario;
                newRow["total"] = total;
                newRow["Tipo"] = "Producto";
                dataTable.Rows.Add(newRow);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione un producto válido.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

            CalcularTotalPedido();
            ResetProductoFields();

        }

        private void ResetProductoFields()
        {
            cboProductos.SelectedIndex = -1;
            cantidadProducto.Value = 1;
        }

        private void btnAgregarImpresion_Click(object sender, EventArgs e)
        {
            // obtener valores seleccionados y calcular el total
            var impresion = (Impresion)cboImpresiones.SelectedItem;
            if (impresion == null)
            {
                MessageBox.Show("Debe seleccionar una impresión", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return;
            }
            int cantidad = (int)cantidadImpresion.Value;
            decimal precioUnitario = impresion.precioBase;
            decimal total = cantidad * precioUnitario;

            if (cboImpresiones.SelectedIndex > 0)
            {
                DataRow newRow = dataTable.NewRow();
                newRow["id"] = impresion.id;
                newRow["ImpresionId"] = impresion.id;
                newRow["nombre"] = impresion.tamanio;
                newRow["cantidad"] = cantidad;
                newRow["precioUnitario"] = precioUnitario;
                newRow["total"] = total;
                newRow["Tipo"] = "Impresion";
                dataTable.Rows.Add(newRow);
            }
            else
            {
                MessageBox.Show("Por favor, seleccione una impresión válida.", "Advertencia", MessageBoxButtons.OK, MessageBoxIcon.Warning);
            }

                CalcularTotalPedido();
            ResetImpresionFields();
        }

        private void ResetImpresionFields()
        {
            cboImpresiones.SelectedIndex = -1;
            cantidadImpresion.Value = 1;
        }

        private void CalcularTotalPedido()
        {
            decimal totalPedido = dataTable.AsEnumerable().Sum(row => row.Field<decimal>("total"));
            lbltotalPedido.Text = $"{totalPedido:C}";
        }

        

        private void dataGridDetallePedido_CellClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.ColumnIndex == dataGridDetallePedido.Columns["Eliminar"].Index && e.RowIndex >= 0)
            {
                dataGridDetallePedido.Rows.RemoveAt(e.RowIndex);
                // Recalcular el total del pedido después de eliminar una fila
                CalcularTotalPedido();
            }
        }

        private async void iconButtonGuardar_Click(object sender, EventArgs e)
        {
            // crear un nuevo pedido y asignarle los valores
            try
            {
                var nuevoPedido = new Pedido
                {
                    ClienteId = (int)cboClientes.SelectedValue,
                    fechaPedido = DateTime.Now,
                    estadoPedido = (EstadoPedidoEnum)cboEstadosPedidos.SelectedItem,
                    ModoPagoId = (int)cboModoPagos.SelectedValue,
                    FuePagado = cbFuePagado.Checked,
                    DetallesProducto = new List<DetalleProducto>(),
                    DetallesImpresion = new List<DetalleImpresion>()
                };

                foreach (DataGridViewRow row in dataGridDetallePedido.Rows)
                {
                    if (row.Cells["Tipo"].Value?.ToString() == "Producto" && row.Cells["ProductoId"].Value != null)
                    {
                        nuevoPedido.DetallesProducto.Add(new DetalleProducto
                        {
                            ProductoId = (int)row.Cells["ProductoId"].Value,
                            cantidad = (int)row.Cells["cantidad"].Value,
                            precioUnitario = (decimal)row.Cells["precioUnitario"].Value
                        });
                    }
                    else if (row.Cells["Tipo"].Value?.ToString() == "Impresion" && row.Cells["ImpresionId"].Value != null)
                    {
                        nuevoPedido.DetallesImpresion.Add(new DetalleImpresion
                        {
                            ImpresionId = (int)row.Cells["ImpresionId"].Value,
                            cantidad = (int)row.Cells["cantidad"].Value,
                            precioUnitario = (decimal)row.Cells["precioUnitario"].Value
                        });
                    }

                }
                ShowInActivity.Show("Guardando pedido ...");
                await pedidoService.AddAsync(nuevoPedido);
                ShowInActivity.Hide();
                MessageBox.Show("Pedido agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                ResetForm();
            }
            catch (Exception ex)
            {
                MessageBox.Show($"Error al guardar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
            }
        }

        private void ResetForm()
        {
            cboClientes.SelectedIndex = 0;
            cboProductos.SelectedIndex = 0;
            cboModoPagos.SelectedIndex = 0;
            cbFuePagado.Checked = false;
            cboImpresiones.SelectedIndex = 0;
            cboEstadosPedidos.SelectedIndex = 1; // Estado de pedido en "Recepcionado"
            cantidadProducto.Value = 1;
            cantidadImpresion.Value = 1;
            lbltotalPedido.Text = "Total Pedido: $0.00";

            // Limpiar la grilla
            var dataTable = (DataTable)bindingPedidos.DataSource;
            dataTable.Clear();
        }
    }
}
