using DesktopNegocio.Interfaces;
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
using static System.Runtime.InteropServices.JavaScript.JSType;

namespace DesktopNegocio.Views.Details.ResumenPedidos
{
    public partial class ResumenPedidosView : Form
    {

        IGenericService<Pedido> pedidoService = new GenericService<Pedido>();
        private List<Pedido> pedidos = new List<Pedido>();
        public ResumenPedidosView()
        {
            InitializeComponent();
            CargarPedidos();
        }

        private async void CargarPedidos()
        {
            ShowInActivity.Show("Descargando/actualizando ...");
            pedidos = await pedidoService.GetAllAsync();
            ShowInActivity.Hide();
            ActualizarGrilla();
            
        }

        private void ActualizarGrilla()
        {
            dataGridResumenPedidos.DataSource = null;
            dataGridResumenPedidos.Columns.Clear();

            // Asignar la lista de pedidos al DataGridView
            dataGridResumenPedidos.DataSource = pedidos.Select(p => new
            {
                p.id,
                Cliente = p.cliente.apellidoNombre,
                FechaPedido = p.fechaPedido.ToShortDateString(),
                TotalProductos = p.DetallesProducto.Sum(d => d.total).ToString("F2"),
                TotalImpresiones = p.DetallesImpresion.Sum(d => d.total).ToString("F2"),
                TotalPedido = p.TotalPedido.ToString("F2"),
                Estado = p.estadoPedido.ToString()
            }).ToList();

            // Configurar columnas
            dataGridResumenPedidos.Columns["Estado"].HeaderText = "Estado";
            dataGridResumenPedidos.Columns["id"].HeaderText = "N° Pedido";
            dataGridResumenPedidos.Columns["Cliente"].HeaderText = "Cliente";
            dataGridResumenPedidos.Columns["FechaPedido"].HeaderText = "Fecha del Pedido";
            dataGridResumenPedidos.Columns["TotalProductos"].HeaderText = "Total Productos";
            dataGridResumenPedidos.Columns["TotalImpresiones"].HeaderText = "Total Impresiones";
            dataGridResumenPedidos.Columns["TotalPedido"].HeaderText = "Total Pedido";

            // Agregar columna de botones para ver detalles
            AgregarBotonColumna(dataGridResumenPedidos, "VerDetalle", "Ver Detalles", Color.LightBlue, Color.DarkBlue);

            // Aplicar color a los estados de "Enviado"
            dataGridResumenPedidos.CellFormatting += DataGridResumenPedidos_CellFormatting;
        }

        private void AgregarBotonColumna(DataGridView dataGridResumenPedidos, string nombre, string texto, Color colorFondo, Color colorTexto)
        {
            DataGridViewButtonColumn buttonColumn = new DataGridViewButtonColumn
            {
                Name = nombre,
                Text = texto,
                UseColumnTextForButtonValue = true,
                FlatStyle = FlatStyle.Flat
            };

            buttonColumn.DefaultCellStyle.BackColor = colorFondo;
            buttonColumn.DefaultCellStyle.ForeColor = colorTexto;
            buttonColumn.DefaultCellStyle.Font = new Font("Bahnschrift", 10, FontStyle.Bold);

            dataGridResumenPedidos.Columns.Add(buttonColumn);
        }

        private void DataGridResumenPedidos_CellFormatting(object? sender, DataGridViewCellFormattingEventArgs e)
        {
            if (dataGridResumenPedidos.Columns[e.ColumnIndex].Name == "Estado" && e.Value != null)
            {
                if (e.Value.ToString() == "Enviado" || e.Value.ToString() == "Entregado" || e.Value.ToString() == "Completado")
                {
                    e.CellStyle.ForeColor = Color.Red;
                }
            }
        }

        private void dataGridResumenPedidos_CellContentClick(object sender, DataGridViewCellEventArgs e)
        {
            if (e.RowIndex >= 0 && dataGridResumenPedidos.Columns[e.ColumnIndex].Name == "VerDetalle")
            {
                var pedidoId = Convert.ToInt32(dataGridResumenPedidos.Rows[e.RowIndex].Cells["id"].Value);
                MostrarDetallesPedido(pedidoId);
            }
        }

        private void MostrarDetallesPedido(int pedidoId)
        {
            var pedido = pedidos.FirstOrDefault(p => p.id == pedidoId);
            if (pedido != null)
            {
                var detallesForm = new DetalleView(pedido);
                detallesForm.ShowDialog();
            }
        }
    }
}
