﻿using DesktopNegocio.Enums;
using DesktopNegocio.ExtensionMethods;
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
using System.Windows.Controls;
using System.Windows.Forms;
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesktopNegocio.Views.Details.PedidosFiltrados
{
    public partial class PedidosFiltradosView : Form
    {
        IGenericService<Pedido> pedidoService = new GenericService<Pedido>();
        IGenericService<Cliente> clienteService = new GenericService<Cliente>();
        private List<Cliente> clientes = new List<Cliente>();
        private List<Pedido> pedidos = new List<Pedido>();
        private List<Pedido> pedidosFiltrados = new List<Pedido>();
        public PedidosFiltradosView()
        {
            InitializeComponent();
            CargarPedidos();
            CargarCombos();

           // dataGridPedidos.CellContentClick += dataGridPedidos_CellContentClick;

        }

        private async void CargarCombos()
        {
            // Llenar los combos de clientes, estados y rubros
            cboClientes.Items.Add("Todos");
            cboEstados.Items.Add("Todos");
            cboRubro.Items.Add("Todos");

            // Obtener la lista de clientes desde el servicio y llenarla en el ComboBox
            clientes = await clienteService.GetAllAsync(); // Asegúrate de que GetAllAsync esté implementado
            foreach (var cliente in clientes)
            {
                cboClientes.Items.Add(cliente.apellidoNombre);
            }

            // Llenar combo de estado y rubro usando enums
            cboEstados.Items.AddRange(Enum.GetValues(typeof(EstadoPedidoEnum)).Cast<object>().ToArray());
            cboRubro.Items.AddRange(Enum.GetValues(typeof(RubroEnum)).Cast<object>().ToArray());
        }

        private async void CargarPedidos()
        {
            ShowInActivity.Show("Descargando/actualizando ...");
            pedidos = await pedidoService.GetAllAsync();
           ShowInActivity.Hide();

            pedidosFiltrados = pedidos;
            ActualizarDataGridView();
        }

        private void ActualizarDataGridView()
        {
            // reseteo DataGridView 
            dataGridPedidos.ColumnHeadersDefaultCellStyle = new DataGridViewCellStyle();
            dataGridPedidos.DataSource = null;
            dataGridPedidos.Columns.Clear();

            // Establecer la fuente de datos para la grilla
            dataGridPedidos.DataSource = pedidosFiltrados;

            // Ocultar columnas específicas
            OcultarColumnas(dataGridPedidos, new string[] { "ClienteId", "ModoPagoId", "ModoPago", "DetallesProducto", "DetallesImpresion", "eliminado", "TotalPedido" });

            // Cambiar los títulos de las columnas visibles
            dataGridPedidos.Columns["id"].HeaderText = "ID Pedido";
            dataGridPedidos.Columns["cliente"].HeaderText = "Cliente";
            dataGridPedidos.Columns["estadoPedido"].HeaderText = "Estado del Pedido";
            dataGridPedidos.Columns["fechaPedido"].HeaderText = "Fecha del Pedido";
            dataGridPedidos.Columns["totalPedidoF"].HeaderText = "Total";

            // Aplicar estilos a las columnas
            dataGridPedidos.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
            dataGridPedidos.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridPedidos.ColumnHeadersDefaultCellStyle.ForeColor = Color.Black;
            dataGridPedidos.EnableHeadersVisualStyles = false;

            // Agregar columnas de botones con estilo
            AgregarBotonColumna(dataGridPedidos, "Detalle", "Detalle", Color.LightBlue, Color.DarkBlue);
            AgregarBotonColumna(dataGridPedidos, "Editar", "Editar", Color.LightGreen, Color.DarkGreen);
            AgregarBotonColumna(dataGridPedidos, "Eliminar", "Eliminar", Color.LightCoral, Color.DarkRed);

            // Forzar la actualización de los estilos
            dataGridPedidos.Refresh();

        }

        private void AgregarBotonColumna(DataGridView dataGridPedidos, string nombre, string texto, Color colorFondo, Color colorTexto)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = nombre,
                Text = texto,
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat

            };

            // Establecer estilos para los botones
       
            buttonColumn.DefaultCellStyle.BackColor = colorFondo;
            buttonColumn.DefaultCellStyle.ForeColor = colorTexto;
            buttonColumn.DefaultCellStyle.Font = new Font("Bahnschrift", 10, FontStyle.Bold);

            dataGridPedidos.Columns.Add(buttonColumn);
        }

        private void OcultarColumnas(DataGridView dataGridPedidos, string[] nombresColumnas)
        {
            foreach (string nombreColumna in nombresColumnas)
            {
                if (dataGridPedidos.Columns[nombreColumna] != null)
                {
                    dataGridPedidos.Columns[nombreColumna].Visible = false;
                }
            }
        }

        private void btnFiltrar_Click(object sender, EventArgs e)
        {
            AplicarFiltros();
        }

        private void AplicarFiltros()
        {
            var clienteSeleccionado = cboClientes.SelectedItem?.ToString();
            var estadoSeleccionado = cboEstados.SelectedItem as EstadoPedidoEnum?;
            var rubroSeleccionado = cboRubro.SelectedItem as RubroEnum?;

            pedidosFiltrados = pedidos.Where(p =>
                (string.IsNullOrEmpty(clienteSeleccionado) || p.cliente?.apellidoNombre == clienteSeleccionado) &&
                (estadoSeleccionado == null || p.estadoPedido == estadoSeleccionado) &&
                (rubroSeleccionado == null || p.DetallesProducto.Any(dp => dp.producto?.Rubro == rubroSeleccionado) ||
                    (rubroSeleccionado == RubroEnum.Fotografia && p.DetallesImpresion.Any()))
            ).ToList();

            ActualizarDataGridView();
        }

        private async void dataGridPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            // Verificar que el clic fue en una columna de botón
            if (e.RowIndex >= 0)
            {
                var pedidoSeleccionado = pedidosFiltrados[e.RowIndex];

                if (dataGridPedidos.Columns[e.ColumnIndex].Name == "Detalle")
                {
                    // Aquí puedes abrir una ventana para mostrar el detalle del pedido
                    var pedidoSeleccionadoDetalle = pedidosFiltrados[e.RowIndex];

                    // Crea una instancia del formulario de detalles y pásale el pedido seleccionado
                    DetallePedidoView detalleForm = new DetallePedidoView(pedidoSeleccionado);
                    detalleForm.ShowDialog(); // Mostrar como un cuadro de diálogo modal
                }
                else if (dataGridPedidos.Columns[e.ColumnIndex].Name == "Editar")
                {
                    var pedidoSeleccionadoEditar = pedidosFiltrados[e.RowIndex];
                    var EditarPedido = new EditarPedidoView(pedidoSeleccionadoEditar.id);

                    // Suscribirse al evento PedidoEditado para actualizar la grilla al cerrar el formulario de edición
                    EditarPedido.PedidoEditado += CargarPedidos;

                    EditarPedido.ShowDialog();
                }

                else if( dataGridPedidos.Columns[e.ColumnIndex].Name == "Eliminar")
                {
                    //Confirmación de eliminación
                   var confirmResult = MessageBox.Show(
                       $"¿Está seguro de que desea eliminar el pedido del cliente: {pedidoSeleccionado.cliente}?",
                       "Confirmar eliminación",
                       MessageBoxButtons.YesNo,
                       MessageBoxIcon.Warning
                   );

                    if (confirmResult == DialogResult.Yes)
                    {
                        try
                        {
                            
                            ShowInActivity.Show("Eliminando pedido ...");
                            // Llama al servicio para eliminar el pedido
                            await pedidoService.DeleteAsync(pedidoSeleccionado.id);
                            ShowInActivity.Hide();
                            // Elimina el pedido de la lista y actualiza el DataGridView
                            pedidos.Remove(pedidoSeleccionado);
                            pedidosFiltrados.Remove(pedidoSeleccionado);


                            MessageBox.Show("Pedido eliminado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                            ActualizarDataGridView();

                        }
                        catch (Exception ex)
                        {
                            MessageBox.Show($"Error al eliminar el pedido: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                        }


                    }
                    
                }
            }
            else if (e.RowIndex >= 0 && dataGridPedidos.Columns[e.ColumnIndex].Name == "Editar")
            {
                var pedidoSeleccionadoEliminar = pedidosFiltrados[e.RowIndex];
                var EditarPedido = new EditarPedidoView(pedidoSeleccionadoEliminar.id); // Pasar el ID del pedido en lugar del objeto
                EditarPedido.ShowDialog();
            }
        }
    }
}
