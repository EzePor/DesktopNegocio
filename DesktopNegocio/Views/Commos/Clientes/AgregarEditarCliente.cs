﻿using DesktopNegocio.Interfaces;
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

namespace DesktopNegocio.Views
{
    public partial class AgregarEditarCliente : Form
    {
        IGenericService<Cliente> clienteService = new GenericService<Cliente>();
        Cliente cliente;

        // nuevo cliente
        public AgregarEditarCliente()
        {
            InitializeComponent();
            cliente = new Cliente();

        }

        // editar cliente
        public AgregarEditarCliente(Cliente cliente)
        {
            InitializeComponent();
            this.cliente = cliente;
            CargarDatosClientesAEditar();
        }

        private void CargarDatosClientesAEditar()
        {
            txtApellidoNombre.Text = cliente.apellidoNombre;
            txtCuitDni.Text = cliente.cuitDni;
            txtDireccion.Text = cliente.direccion;
            txtTelefono.Text = cliente.telefono;
            txtEmail.Text = cliente.email;
            txtLocalidad.Text = cliente.Localidad;
            txtCodigoPostal.Text = cliente.CodigoPostal;
            txtProvincia.Text = cliente.Provincia;

        }

        // Método para validar los campos obligatorios
        private bool ValidarCampos()
        {
            if (string.IsNullOrWhiteSpace(txtApellidoNombre.Text))
            {
                MessageBox.Show("El campo 'Apellido y Nombre' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCuitDni.Text))
            {
                MessageBox.Show("El campo 'CUIT/DNI' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccion.Text))
            {
                MessageBox.Show("El campo 'Dirección' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefono.Text))
            {
                MessageBox.Show("El campo 'Teléfono' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtEmail.Text))
            {
                MessageBox.Show("El campo 'Email' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtLocalidad.Text))
            {
                MessageBox.Show("El campo 'Localidad' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtCodigoPostal.Text))
            {
                MessageBox.Show("El campo 'Código Postal' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtProvincia.Text))
            {
                MessageBox.Show("El campo 'Provincia' es obligatorio.", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }

            return true;
        }


        private async void iconButtonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                cliente.apellidoNombre = txtApellidoNombre.Text;
                cliente.cuitDni = txtCuitDni.Text;
                cliente.direccion = txtDireccion.Text;
                cliente.telefono = txtTelefono.Text;
                cliente.email = txtEmail.Text;
                cliente.Localidad = txtLocalidad.Text;
                cliente.CodigoPostal = txtCodigoPostal.Text;
                cliente.Provincia = txtProvincia.Text;

                try
                {
                    if (cliente.id == 0) // Nuevo cliente
                    {
                        ShowInActivity.Show("Agregando un cliente ...");
                        await clienteService.AddAsync(cliente);
                        ShowInActivity.Hide();
                        MessageBox.Show("Cliente agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Cliente existente (editar)
                    {
                        ShowInActivity.Show("Actualizando un cliente ...");
                        await clienteService.UpdateAsync(cliente);
                        ShowInActivity.Hide();
                        MessageBox.Show("Cliente actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();
                }
                catch (Exception ex)
                {
                    MessageBox.Show($"Error al guardar el cliente: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
