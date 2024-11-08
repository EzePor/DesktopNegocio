using DesktopNegocio.Enums;
using DesktopNegocio.Interfaces;
using DesktopNegocio.Models.Commos;
using DesktopNegocio.Services;
using DesktopNegocio.Util;
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

namespace DesktopNegocio.Views.Commos.Productos
{
    public partial class AgregarEditarProductosView : Form
    {
        IGenericService<Producto> productoService = new GenericService<Producto>();
        private Producto producto;

        public AgregarEditarProductosView()
        {
            InitializeComponent();
            producto = new Producto();

            // Configurar estilo del formulario
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Gray; // Color de fondo para hacer contraste con el borde
            Padding = new Padding(2); // Espacio para el borde blanco

            CargarComboBoxRubro();
        }
       
        private void CargarComboBoxRubro()
        {
            cboRubro.DataSource = Enum.GetValues(typeof(RubroEnum));
        }

        public AgregarEditarProductosView(Producto producto)
        {
            InitializeComponent();
            this.producto = producto;
            CargarComboBoxRubro();
            CargarDatosProductosAEditar();
        }

        private void CargarDatosProductosAEditar()
        {
            txtNombre.Text = producto.nombre;
            txtPrecio.Text = producto.precioF;
            cboRubro.SelectedItem = producto.Rubro;
            txtStock.Text = producto.stock.ToString();

        }

        // Validación de los datos ingresados
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtNombre.Text))
            {
                MessageBox.Show("El nombre del producto es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!decimal.TryParse(txtPrecio.Text, out _))
            {
                MessageBox.Show("El precio debe ser un valor numérico.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (!int.TryParse(txtStock.Text, out _))
            {
                MessageBox.Show("El stock debe ser un número entero.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            if (cboRubro.SelectedItem == null)
            {
                MessageBox.Show("Debes seleccionar un rubro.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                return false;
            }

            return true;
        }

        private void iconButtonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                producto.nombre = txtNombre.Text;
                producto.precioF = txtPrecio.Text; // Usa `precioF` para asignar el valor formateado
                producto.Rubro = (RubroEnum)cboRubro.SelectedItem;
                producto.stock = int.Parse(txtStock.Text);

                try
                {
                    if (producto.id == 0) // Nuevo producto
                    {
                        ShowInActivity.Show("Agregando producto ...");
                        productoService.AddAsync(producto);
                        ShowInActivity.Hide();
                        MessageBox.Show("Producto agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Producto existente (editar)
                    {
                        ShowInActivity.Show("Actualizando producto ...");
                        productoService.UpdateAsync(producto);
                        ShowInActivity.Hide();
                        MessageBox.Show("Producto actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }

                    this.DialogResult = DialogResult.OK; // Cerrar el formulario con resultado OK
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el producto: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
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
