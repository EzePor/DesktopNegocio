using DesktopNegocio.Interfaces;
using DesktopNegocio.Models.Commos;
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
using DesktopNegocio.Interfaces.Pedidos;
using DesktopNegocio.Enums;
using static System.Runtime.InteropServices.JavaScript.JSType;
using System.Windows.Controls;
using DesktopNegocio.Util;

namespace DesktopNegocio.Views.Details.PedidosCompletados
{
    public partial class PedidosCompletadosView : Form
    {
        IGenericService<Pedido> pedidoService = new GenericService<Pedido>();
        private List<Pedido> pedidosCompletados = new List<Pedido>();
        public PedidosCompletadosView()
        {

            InitializeComponent();
            CargarPedidosCompletados();

        }

        private async void CargarPedidosCompletados()
        {
            ShowInActivity.Show("Descargando/actualizando ...");
            pedidosCompletados = (await pedidoService.GetAllAsync())
                .Where(p => p.estadoPedido == EstadoPedidoEnum.Completado)
                .ToList();
            ShowInActivity.Hide();

            ActualizarDataGridPedidosCompletados();
        }

        private void ActualizarDataGridPedidosCompletados()
        {
            dataGridPedidosCompletados.DataSource = null;
            dataGridPedidosCompletados.Columns.Clear();
            dataGridPedidosCompletados.DataSource = pedidosCompletados.Select(p => new
            {
                p.id,
                FechaPedido = p.fechaPedido.ToShortDateString(),
                Cliente = p.cliente.apellidoNombre,
                TotalProductos = p.DetallesProducto.Sum(d => d.total).ToString("F2"),
                TotalImpresiones = p.DetallesImpresion.Sum(d => d.total).ToString("F2"),
                TotalPedido = p.TotalPedido.ToString("F2"),
                Estado = p.estadoPedido,
                FuePagado = p.FuePagado ? "Sí" : "No"
            }).ToList();

            dataGridPedidosCompletados.Columns["id"].HeaderText = "N° Pedido";
            dataGridPedidosCompletados.Columns["FechaPedido"].HeaderText = "Fecha del Pedido";
            dataGridPedidosCompletados.Columns["Cliente"].HeaderText = "Cliente";
            dataGridPedidosCompletados.Columns["TotalProductos"].HeaderText = "Total Productos";
            dataGridPedidosCompletados.Columns["TotalImpresiones"].HeaderText = "Total Impresiones";
            dataGridPedidosCompletados.Columns["TotalPedido"].HeaderText = "Total Pedido";
            dataGridPedidosCompletados.Columns["Estado"].HeaderText = "Estado";
            dataGridPedidosCompletados.Columns["FuePagado"].HeaderText = "Fue Pagado";

            // Estilos de las columnas
            dataGridPedidosCompletados.ColumnHeadersDefaultCellStyle.Font = new Font("Bahnschrift", 10, FontStyle.Bold);
            dataGridPedidosCompletados.ColumnHeadersDefaultCellStyle.BackColor = Color.LightGray;
            dataGridPedidosCompletados.EnableHeadersVisualStyles = false;

            // Columnas de botones para editar estado y pago
            AgregarBotonColumna(dataGridPedidosCompletados, "Actualizar Estado", "Actualizar Estado", Color.LightBlue, Color.DarkBlue);
            AgregarBotonColumna(dataGridPedidosCompletados, "Marcar Pago", "Marcar Pago", Color.LightGreen, Color.DarkGreen);
            dataGridPedidosCompletados.Refresh();
        }

        private void AgregarBotonColumna(DataGridView dataGridPedidosCompletados, string nombre, string texto, Color fondo, Color textoColor)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = nombre,
                Text = texto,
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat,
                DefaultCellStyle = new DataGridViewCellStyle
                {
                    BackColor = fondo,
                    ForeColor = textoColor,
                    Font = new Font("Bahnschrift", 10, FontStyle.Bold)
                }
            };
            dataGridPedidosCompletados.Columns.Add(buttonColumn);
        }

        private async void dataGridPedidosCompletados_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0)
            {
                var pedido = pedidosCompletados[e.RowIndex];

                if (dataGridPedidosCompletados.Columns[e.ColumnIndex].Name == "Actualizar Estado")
                {
                    var nuevoEstado = EstadoPedidoEnum.Enviado;  // O puedes mostrar una lista de estados posibles
                    pedido.estadoPedido = nuevoEstado;
                    ShowInActivity.Show("Actualizando estado ...");
                    await pedidoService.UpdateAsync(pedido);
                    ShowInActivity.Hide();
                    MessageBox.Show($"Estado actualizado a {nuevoEstado}.", "Estado Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }
                else if (dataGridPedidosCompletados.Columns[e.ColumnIndex].Name == "Marcar Pago")
                {
                    pedido.FuePagado = true;
                    await pedidoService.UpdateAsync(pedido);
                    MessageBox.Show("El pedido ha sido marcado como pagado.", "Pago Actualizado", MessageBoxButtons.OK, MessageBoxIcon.Information);
                }

                ActualizarDataGridPedidosCompletados();
            }
        }
    }
}
