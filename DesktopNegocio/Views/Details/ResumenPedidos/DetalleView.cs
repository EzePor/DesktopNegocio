using DesktopNegocio.Models.Details;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Drawing.Drawing2D;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopNegocio.Views.Details.ResumenPedidos
{
    public partial class DetalleView : Form
    {
        private readonly Pedido _pedido;
        public DetalleView(Pedido pedido)
        {
            InitializeComponent();
            _pedido = pedido;

            // Configurar estilo del formulario
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Gray; // Color de fondo para hacer contraste con el borde
            Padding = new Padding(2); // Espacio para el borde blanco

            CargarDetalles();
            ConfigurarEstilosDataGridView(dataGridViewProductos);
            ConfigurarEstilosDataGridView(dataGridViewImpresiones);
        }

        private void ConfigurarEstilosDataGridView(DataGridView dataGridView)
        {
            // Ajustar el ancho de columna automáticamente
            dataGridView.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;

            // Estilo del encabezado
            dataGridView.ColumnHeadersDefaultCellStyle.BackColor = System.Drawing.Color.Navy;
            dataGridView.ColumnHeadersDefaultCellStyle.ForeColor = System.Drawing.Color.White;
            dataGridView.ColumnHeadersDefaultCellStyle.Font = new System.Drawing.Font("Bahnschift", 11, System.Drawing.FontStyle.Bold);
            dataGridView.ColumnHeadersDefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Estilo de celdas de datos
            dataGridView.DefaultCellStyle.BackColor = System.Drawing.Color.White;
            dataGridView.DefaultCellStyle.ForeColor = System.Drawing.Color.Black;
            dataGridView.DefaultCellStyle.SelectionBackColor = System.Drawing.Color.LightBlue;
            dataGridView.DefaultCellStyle.SelectionForeColor = System.Drawing.Color.Black;
            dataGridView.DefaultCellStyle.Font = new System.Drawing.Font("Bahnschift", 11);
            dataGridView.DefaultCellStyle.Alignment = DataGridViewContentAlignment.MiddleCenter;

            // Ajustar bordes y altura de filas
            dataGridView.CellBorderStyle = DataGridViewCellBorderStyle.SingleHorizontal;
            dataGridView.RowTemplate.Height = 30;

            // Deshabilitar opciones de agregar filas
            dataGridView.AllowUserToAddRows = false;
            dataGridView.AllowUserToResizeRows = false;
        }


        private void CargarDetalles()
        {
            // Mostrar productos en DataGridViewProductos
            dataGridViewProductos.DataSource = _pedido.DetallesProducto.Select(p => new
            {
                Producto = p.producto?.nombre,
                Cantidad = p.cantidad,
                PrecioUnitario = p.precioUnitario.ToString("F2"),
                Subtotal = p.TotalF
            }).ToList();

            // Mostrar impresiones en DataGridViewImpresiones
            dataGridViewImpresiones.DataSource = _pedido.DetallesImpresion.Select(i => new
            {
                Impresión = i.impresion?.tamanio,
                Cantidad = i.cantidad,
                PrecioUnitario = i.precioUnitario.ToString("F2"),
                Subtotal = i.TotalF
            }).ToList();
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            DialogResult = DialogResult.OK;
            this.Close();
        }


        // Evento Paint para dibujar el borde redondeado
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderRadius = 20;  // Radio de redondeo de esquinas
            int borderSize = 4;     // Grosor del borde

            using (GraphicsPath path = new GraphicsPath())
            {
                // Crear un borde con esquinas redondeadas
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(Width - borderRadius - 1, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(Width - borderRadius - 1, Height - borderRadius - 1, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, Height - borderRadius - 1, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();

                // Dibujar el borde
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.White, borderSize))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
    

