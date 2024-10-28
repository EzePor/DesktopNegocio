namespace DesktopNegocio.Views.Commos.Modos_Pagos
{
    partial class AgregarEditarModoPagoView
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            iconButtonGuardar = new FontAwesome.Sharp.IconButton();
            label3 = new Label();
            txtAjuste = new TextBox();
            label8 = new Label();
            txtModoPago = new TextBox();
            labelNombre = new Label();
            SuspendLayout();
            // 
            // iconButtonSalir
            // 
            iconButtonSalir.BackColor = Color.Gray;
            iconButtonSalir.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonSalir.ForeColor = Color.White;
            iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButtonSalir.IconColor = Color.White;
            iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSalir.Location = new Point(1221, 526);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Size = new Size(259, 141);
            iconButtonSalir.TabIndex = 47;
            iconButtonSalir.Text = "Salir";
            iconButtonSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonSalir.UseVisualStyleBackColor = false;
            iconButtonSalir.Click += iconButtonSalir_Click;
            // 
            // iconButtonGuardar
            // 
            iconButtonGuardar.BackColor = Color.Blue;
            iconButtonGuardar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonGuardar.ForeColor = Color.White;
            iconButtonGuardar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButtonGuardar.IconColor = Color.White;
            iconButtonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonGuardar.Location = new Point(1221, 212);
            iconButtonGuardar.Name = "iconButtonGuardar";
            iconButtonGuardar.Size = new Size(259, 141);
            iconButtonGuardar.TabIndex = 46;
            iconButtonGuardar.Text = "Guardar";
            iconButtonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonGuardar.UseVisualStyleBackColor = false;
            iconButtonGuardar.Click += iconButtonGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(444, 89);
            label3.Name = "label3";
            label3.Size = new Size(389, 41);
            label3.TabIndex = 45;
            label3.Text = "Agregar/Editar Impresiones";
            // 
            // txtAjuste
            // 
            txtAjuste.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtAjuste.Location = new Point(289, 440);
            txtAjuste.Name = "txtAjuste";
            txtAjuste.Size = new Size(742, 32);
            txtAjuste.TabIndex = 44;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(111, 448);
            label8.Name = "label8";
            label8.Size = new Size(63, 24);
            label8.TabIndex = 43;
            label8.Text = "Ajuste:";
            // 
            // txtModoPago
            // 
            txtModoPago.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtModoPago.Location = new Point(289, 270);
            txtModoPago.Name = "txtModoPago";
            txtModoPago.Size = new Size(742, 32);
            txtModoPago.TabIndex = 42;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(111, 278);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(118, 24);
            labelNombre.TabIndex = 41;
            labelNombre.Text = "Modo de pago:";
            // 
            // AgregarEditarModoPagoView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1660, 850);
            Controls.Add(iconButtonSalir);
            Controls.Add(iconButtonGuardar);
            Controls.Add(label3);
            Controls.Add(txtAjuste);
            Controls.Add(label8);
            Controls.Add(txtModoPago);
            Controls.Add(labelNombre);
            Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarEditarModoPagoView";
            Text = "AgregarEditarModoPagoView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private FontAwesome.Sharp.IconButton iconButtonGuardar;
        private Label label3;
        private TextBox txtAjuste;
        private Label label8;
        private TextBox txtModoPago;
        private Label labelNombre;
    }
}