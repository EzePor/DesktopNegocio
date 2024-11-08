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

namespace DesktopNegocio.Views.Commos.Modos_Pagos
{
    public partial class AgregarEditarModoPagoView : Form
    {
        IGenericService<ModoPago> modoPagoService = new GenericService<ModoPago>();
        private ModoPago modoPago;

        // nuevo modo de pago
        public AgregarEditarModoPagoView()
        {
            InitializeComponent();
            modoPago = new ModoPago();
        }

        // editar modo de pago
        public AgregarEditarModoPagoView(ModoPago modoPago)
        {
            InitializeComponent();
            this.modoPago = modoPago;

            // Configurar estilo del formulario
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Gray; // Color de fondo para hacer contraste con el borde
            Padding = new Padding(2); // Espacio para el borde blanco

            CargarDatosModosPagosAEditar();
        }

        private void CargarDatosModosPagosAEditar()
        {
            txtModoPago.Text = modoPago.nombre;
            txtAjuste.Text = modoPago.ajuste.ToString();
        }

        // Método para validar los campos obligatorios
        private bool ValidarCampos()
        {
            if (string.IsNullOrEmpty(txtModoPago.Text))
            {
                MessageBox.Show("El campo Modo de Pago es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            if (string.IsNullOrEmpty(txtAjuste.Text))
            {
                MessageBox.Show("El campo Ajuste es obligatorio", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
                return false;
            }
            return true;
        }

        private async void iconButtonGuardar_Click(object sender, EventArgs e)
        {
            if (ValidarCampos())
            {
                modoPago.nombre = txtModoPago.Text;
                modoPago.ajuste = Convert.ToDecimal(txtAjuste.Text);

                try
                {
                    if (modoPago.id == 0) // Nuevo cliente
                    {
                        ShowInActivity.Show("Agregando modo de pago ...");
                        await modoPagoService.AddAsync(modoPago);
                        ShowInActivity.Hide();
                        MessageBox.Show("Modo de Pago agregado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    else // Cliente existente (editar)
                    {
                        ShowInActivity.Show("Actualizando modo de pago ...");
                        await modoPagoService.UpdateAsync(modoPago);
                        ShowInActivity.Hide();
                        MessageBox.Show("Modo de Pago actualizado exitosamente.", "Éxito", MessageBoxButtons.OK, MessageBoxIcon.Information);
                    }
                    this.DialogResult = DialogResult.OK;
                    this.Close();

                }
                catch (Exception ex)
                {

                    MessageBox.Show($"Error al guardar el Modo de Pago: {ex.Message}", "Error", MessageBoxButtons.OK, MessageBoxIcon.Error);
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
