using DesktopNegocio.ExtensionMethods;
using DesktopNegocio.Models.Commos;
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

namespace DesktopNegocio.Views.Commos.Impresiones
{
    public partial class ImpresionesView : Form
    {
        GenericService<Impresion> impresionService = new GenericService<Impresion>();
        BindingSource listaImpresiones = new BindingSource();
        BindingSource BindingImpresiones = new BindingSource();
        List<Impresion> ListaImpresiones = new List<Impresion>();
        public ImpresionesView()
        {
            InitializeComponent();
            dataGridViewImpresiones.DataSource = listaImpresiones;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            ShowInActivity.Show("Descargando/actualizando ... lista de impresiones");
            var impresiones = await impresionService.GetAllAsync();
            foreach (var impresion in impresiones)
            {
                impresion.precioF = impresion.precioBase.ToString("F2");

            }
            listaImpresiones.DataSource = impresiones;
            dataGridViewImpresiones.OcultarColumnas(new string[] { "eliminado", "precioF","descuento10","descuento20","descuento50" });

            // Personalizar nombres de columnas y tipo de letra
            PersonalizarColumnas();


            ShowInActivity.Hide();
        }

        // PERSONALIZAR TÍTULOS DE COLUMNAS
        private void PersonalizarColumnas()
        {
            dataGridViewImpresiones.Columns["id"].HeaderText = "ID";
            dataGridViewImpresiones.Columns["tamanio"].HeaderText = "TAMAÑO";
            dataGridViewImpresiones.Columns["precioBase"].HeaderText = "PRECIO";

            // Cambiar tipo de letra
            foreach (DataGridViewColumn column in dataGridViewImpresiones.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
            }
        }

        private async void iconButtonAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarImpresionesView agregarEditarImpresionesView = new AgregarEditarImpresionesView();

            // Configura el formulario para que aparezca sobre ClientesView
            agregarEditarImpresionesView.StartPosition = FormStartPosition.CenterParent;

            agregarEditarImpresionesView.ShowDialog(this);
            await CargarGrilla();
        }

        private async void iconButtonEditar_Click(object sender, EventArgs e)
        {
            var impresion = (Impresion)listaImpresiones.Current;
            AgregarEditarImpresionesView agregarEditarImpresionesView = new AgregarEditarImpresionesView(impresion);

            // Configura el formulario para que aparezca sobre ClientesView
            agregarEditarImpresionesView.StartPosition = FormStartPosition.CenterParent;

            agregarEditarImpresionesView.ShowDialog(this);
            await CargarGrilla();
        }

        private async void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            var impresion = (Impresion)listaImpresiones.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que deseas eliminar la impresión{impresion.tamanio}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await impresionService.DeleteAsync(impresion.id);
                await CargarGrilla();
            }
        }

        private void textBoxBuscarImpresion_TextChanged(object sender, EventArgs e)
        {
            BtnBuscarImpresion.PerformClick();
        }

        private async void BtnBuscarImpresion_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxBuscarImpresion.Text.ToLower();

            // Obtiene todos los clientes
            List<Impresion> todosLasImpresiones = await impresionService.GetAllAsync();

            // Filtra las impresiones que contienen el término de búsqueda
            var impresionesFiltradas = todosLasImpresiones
                .Where(c => c.tamanio.ToLower().Contains(searchTerm))
                .OrderBy(c => c.tamanio)
                .ToList();

            // Actualiza el BindingSource con los clientes filtrados
            listaImpresiones.DataSource = impresionesFiltradas;
        }

        
        
    }
}
