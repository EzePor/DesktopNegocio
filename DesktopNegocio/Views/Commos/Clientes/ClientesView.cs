using DesktopNegocio.Models.Commos;
using DesktopNegocio.Services;
using DesktopNegocio.Util;
using DesktopNegocio.ExtensionMethods;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using FontAwesome.Sharp;

namespace DesktopNegocio.Views
{
    public partial class ClientesView : Form
    {
        GenericService<Cliente> clienteService = new GenericService<Cliente>();
        BindingSource listaClientes = new BindingSource();
        BindingSource BindingClientes = new BindingSource();
        List<Cliente> ListaClientes = new List<Cliente>();

        public ClientesView()
        {
            InitializeComponent();
            dataGridViewClientes.DataSource = listaClientes;
            CargarGrilla();
        }

        private async Task CargarGrilla()
        {
            ShowInActivity.Show("Descargando/actualizando ... lista de clientes");
            listaClientes.DataSource = await clienteService.GetAllAsync();
            dataGridViewClientes.OcultarColumnas(new string[] { "eliminado", "Pedidos" });

            // Personalizar nombres de columnas y tipo de letra
            PersonalizarColumnas();

            ShowInActivity.Hide();
        }

        // PERSONALIZAR TÍTULOS DE COLUMNAS
        private void PersonalizarColumnas()
        {
            dataGridViewClientes.Columns["id"].HeaderText = "ID";
            dataGridViewClientes.Columns["apellidoNombre"].HeaderText = "APELLIDO Y NOMBRE";
            dataGridViewClientes.Columns["cuitDni"].HeaderText = "CUIT/DNI";
            dataGridViewClientes.Columns["direccion"].HeaderText = "DIRECCIÓN";
            dataGridViewClientes.Columns["telefono"].HeaderText = "TELÉFONO";
            dataGridViewClientes.Columns["email"].HeaderText = "EMAIL";
            dataGridViewClientes.Columns["Localidad"].HeaderText = "LOCALIDAD";
            dataGridViewClientes.Columns["CodigoPostal"].HeaderText = "CÓDIGO POSTAL";
            dataGridViewClientes.Columns["Provincia"].HeaderText = "PROVINCIA";

            // Cambiar tipo de letra
            foreach (DataGridViewColumn column in dataGridViewClientes.Columns)
            {
                column.HeaderCell.Style.Font = new Font("Bahnschrift", 12, FontStyle.Bold);
                column.HeaderCell.Style.SelectionBackColor = Color.Orange; // Cambia a tu color preferido
            }
        }


        private async void iconButtonAgregar_Click(object sender, EventArgs e)
        {
            AgregarEditarCliente agregarEditarCliente = new AgregarEditarCliente();

            // Configura el formulario para que aparezca sobre ClientesView
            agregarEditarCliente.StartPosition = FormStartPosition.CenterParent;

            agregarEditarCliente.ShowDialog(this);
           await CargarGrilla();
        }

        private async void iconButtonEditar_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)listaClientes.Current;
            AgregarEditarCliente agregarEditarCliente = new AgregarEditarCliente(cliente);

            // Configura el formulario para que aparezca sobre ClientesView
            agregarEditarCliente.StartPosition = FormStartPosition.CenterParent;

            agregarEditarCliente.ShowDialog(this);
            await CargarGrilla();
        }

        private async void iconButtonEliminar_Click(object sender, EventArgs e)
        {
            var cliente = (Cliente)listaClientes.Current;
            var respuesta = MessageBox.Show($"¿Está seguro que quiere eliminar al cliente {cliente.apellidoNombre}?", "Eliminar", MessageBoxButtons.YesNo, MessageBoxIcon.Question);
            if (respuesta == DialogResult.Yes)
            {
                await clienteService.DeleteAsync(cliente.id);
                await CargarGrilla();
            }
        }

        private async void BtnBuscar_Click(object sender, EventArgs e)
        {
            string searchTerm = textBoxBuscarCliente.Text.ToLower();

            // Obtiene todos los clientes
            List<Cliente> todosLosClientes = await clienteService.GetAllAsync();

            // Filtra los clientes que contienen el término de búsqueda
            var clientesFiltrados = todosLosClientes
                .Where(c => c.apellidoNombre.ToLower().Contains(searchTerm))
                .OrderBy(c => c.apellidoNombre)
                .ToList();

            // Actualiza el BindingSource con los clientes filtrados
            listaClientes.DataSource = clientesFiltrados;
        }

        private void textBoxBuscarCliente_TextChanged(object sender, EventArgs e)
        {
            BtnBuscar.PerformClick();
        }

       
    }

}
