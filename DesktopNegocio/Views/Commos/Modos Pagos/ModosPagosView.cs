using DesktopNegocio.ExtensionMethods;
using DesktopNegocio.Interfaces;
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

namespace DesktopNegocio.Views.Commos.Modos_Pagos
{
    public partial class ModosPagosView : Form
    {
        IGenericService<ModoPago> modoPagoService = new GenericService<ModoPago>();
        BindingSource listaModosPagos = new BindingSource();
        BindingSource BindingModosPagos = new BindingSource();
        List<ModoPago> ListaModosPagos = new List<ModoPago>();

        public ModosPagosView()
        {
            InitializeComponent();
            dataGridViewModosPagos.DataSource = listaModosPagos;
            CargarGrilla();

        }

        private async Task CargarGrilla()
        {
            ShowInActivity.Show("Descargando/actualizando ... lista de Modos de pago");
            var modosPagos = await modoPagoService.GetAllAsync();

            foreach (var modoPago in modosPagos)
            {
                modoPago.ajusteF = modoPago.ajuste.ToString("F2");

            }
            listaModosPagos.DataSource = modosPagos;

            dataGridViewModosPagos.OcultarColumnas(new string[] { "eliminado", "ajusteF" });

            // Personalizar nombres de columnas y tipo de letra
            PersonalizarColumnas();

            ShowInActivity.Hide();
        }

        // PERSONALIZAR TÍTULOS DE COLUMNAS
        private void PersonalizarColumnas()
        {
            dataGridViewModosPagos.Columns["id"].HeaderText = "ID";
            dataGridViewModosPagos.Columns["nombre"].HeaderText = "NOMBRE";
            dataGridViewModosPagos.Columns["ajuste"].HeaderText = "AJUSTE";

            // Cambiar tipo de letra
            foreach (DataGridViewColumn column in dataGridViewModosPagos.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
                column.HeaderCell.Style.SelectionBackColor = Color.Orange; // Cambia a tu color preferido
            }
        }

        private async void iconButtonAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarModoPagoView agregarEditarModoPagoView = new AgregarEditarModoPagoView();

            agregarEditarModoPagoView.StartPosition = FormStartPosition.CenterParent;
            agregarEditarModoPagoView.ShowDialog();
            await CargarGrilla();

        }

        private async void iconButtonEditar_Click(object sender, EventArgs e)
        {
            var modoPago = (ModoPago)listaModosPagos.Current;
            AgregarEditarModoPagoView agregarEditarModoPagoView = new AgregarEditarModoPagoView(modoPago);

            agregarEditarModoPagoView.StartPosition = FormStartPosition.CenterParent;
            agregarEditarModoPagoView.ShowDialog();
            await CargarGrilla();
        }

        private async void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            var modoPago = (ModoPago)listaModosPagos.Current;
            var respuesta = MessageBox.Show($"¿Estás seguro de eliminar el modo de pago {modoPago.nombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await modoPagoService.DeleteAsync(modoPago.id);
                await CargarGrilla();
            }
        }

        private void textBoxBuscarModoPago_TextChanged(object sender, EventArgs e)
        {
            BtnBuscarModoPago.PerformClick();
        }

        private async void BtnBuscarModoPago_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxBuscarModoPago.Text.ToLower();

            // Obtiene todos los clientes
            List<ModoPago> todosLosModosPagos = await modoPagoService.GetAllAsync();

            // Filtra los clientes que contienen el término de búsqueda
            var ModosPagosFiltrados = todosLosModosPagos
                .Where(c => c.nombre.ToLower().Contains(searchTerm))
                .OrderBy(c => c.nombre)
                .ToList();

            // Actualiza el BindingSource con los clientes filtrados
            listaModosPagos.DataSource = ModosPagosFiltrados;
        }
    }
}
