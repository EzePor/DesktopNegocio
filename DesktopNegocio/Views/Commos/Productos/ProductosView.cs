using DesktopNegocio.ExtensionMethods;
using DesktopNegocio.Models.Commos;
using DesktopNegocio.Services;
using DesktopNegocio.Util;
using DesktopNegocio.Views.Commos.Productos;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace DesktopNegocio.Views.Commos
{
    public partial class ProductosView : Form
    {

        GenericService<Producto> productoService = new GenericService<Producto>();
        BindingSource listaProductos = new BindingSource();
        BindingSource BindingProductos = new BindingSource();
        List<Producto> ListaProductos = new List<Producto>();
        public ProductosView()
        {
            InitializeComponent();
            dataGridViewProductos.DataSource = listaProductos;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            ShowInActivity.Show("Descargando/actualizando la lista de productos");
            var productos = await productoService.GetAllAsync();
            foreach (var producto in productos)
            {
                producto.precioF = producto.precio.ToString("F2");
               
            }
            listaProductos.DataSource = productos;
            dataGridViewProductos.OcultarColumnas(new string[] {"precioF" ,"eliminado" });

            // Personalizar nombres de columnas y tipo de letra
            PersonalizarColumnas();

            ShowInActivity.Hide();
        }

        // PERSONALIZAR TÍTULOS DE COLUMNAS
        private void PersonalizarColumnas()
        {
            dataGridViewProductos.Columns["id"].HeaderText = "ID";
            dataGridViewProductos.Columns["nombre"].HeaderText = "NOMBRE";
            dataGridViewProductos.Columns["Rubro"].HeaderText = "RUBRO";
            dataGridViewProductos.Columns["precio"].HeaderText = "PRECIO";
            dataGridViewProductos.Columns["stock"].HeaderText = "STOCK";

            // Cambiar tipo de letra
            foreach (DataGridViewColumn column in dataGridViewProductos.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
                column.HeaderCell.Style.SelectionBackColor = Color.Orange; // Cambia a tu color preferido
            }
        }



        private async void iconButtonAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarProductosView agregarEditarProductosView = new AgregarEditarProductosView();
            agregarEditarProductosView.ShowDialog();

            

            await CargarGrilla();
        }

       

        private async void iconButtonEditar_Click(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductos.Current;
            AgregarEditarProductosView agregarEditarProductosView = new AgregarEditarProductosView(producto);
            agregarEditarProductosView.ShowDialog();
            await CargarGrilla();
        }

        private async void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            var producto = (Producto)listaProductos.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que desea borrar  el producto {producto.nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await productoService.DeleteAsync(producto.id);
                await CargarGrilla();
            }
        }

        private void textBoxBuscarProducto_TextChanged(object sender, EventArgs e)
        {
            BtnBuscarProducto.PerformClick();
        }

        private async void BtnBuscarProducto_Click(object sender, EventArgs e)
        {

            string searchTerm = textBoxBuscarProducto.Text.ToLower();

            // Obtiene todos los clientes
            List<Producto> todosLosProductos = await productoService.GetAllAsync();

            // Filtra los clientes que contienen el término de búsqueda
            var productosFiltrados = todosLosProductos
                .Where(c => c.nombre.ToLower().Contains(searchTerm))
                .OrderBy(c => c.nombre)
                .ToList();

            // Actualiza el BindingSource con los clientes filtrados
            listaProductos.DataSource = productosFiltrados;
        }
    }
}
