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

namespace DesktopNegocio.Views.Commos.Impresiones
{
    public partial class AgregarEditarImpresionesView : Form
    {
        IGenericService<Impresion> impresionService = new GenericService<Impresion>();
        private Impresion impresion;
        // nueva impresion
        public AgregarEditarImpresionesView()
        {
            InitializeComponent();
            impresion = new Impresion();
        }

        // editar impresion
        public AgregarEditarImpresionesView(Impresion impresion)
        {
            InitializeComponent();
            this.impresion = impresion;
            CargarDatosImpresionesAEditar();
        }

        private void CargarDatosImpresionesAEditar()
        {
            txtTamanio.Text = impresion.tamanio;
            txtPrecioBase.Text = impresion.precioBase.ToString();
        }

        // Método para validar los campos obligatorios
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtTamanio.Text))
            {
                MessageBox.Show("El campo Tamaño es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtPrecioBase.Text))
            {
                MessageBox.Show("El campo Precio Base es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private async void iconButtonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                impresion.tamanio = txtTamanio.Text;
                impresion.precioBase = decimal.Parse(txtPrecioBase.Text);
                try
                {
                    if (impresion.id == 0) // Nuevo cliente
                    {
                        ShowInActivity.Show("Agregando una impresión ...");
                        await impresionService.AddAsync(impresion);
                        ShowInActivity.Hide();
                        MessageBox.Show("Impresión agregada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Cliente existente (editar)
                    {
                        ShowInActivity.Show("Actualizando impresión ...");
                        await impresionService.UpdateAsync(impresion);
                        ShowInActivity.Hide();
                        MessageBox.Show("Impresión actualizada exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error al guardar la impresión: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                }
            }
        }

        private void iconButtonSalir_Click(object sender, EventArgs e)
        {
            this.DialogResult = DialogResult.Cancel;
            this.Close();
        }
    }
}
