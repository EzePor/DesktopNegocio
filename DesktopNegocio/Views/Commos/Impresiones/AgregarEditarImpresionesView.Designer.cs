namespace DesktopNegocio.Views.Commos.Impresiones
{
    partial class AgregarEditarImpresionesView
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
            txtPrecioBase = new TextBox();
            label8 = new Label();
            txtTamanio = new TextBox();
            labelNombre = new Label();
            SuspendLayout();
            // 
            // iconButtonSalir
            // 
            iconButtonSalir.BackColor = Color.Gray;
            iconButtonSalir.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonSalir.ForeColor = Color.White;
            iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconButtonSalir.IconColor = Color.White;
            iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSalir.Location = new Point(1256, 573);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Size = new Size(259, 141);
            iconButtonSalir.TabIndex = 40;
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
            iconButtonGuardar.Location = new Point(1256, 259);
            iconButtonGuardar.Name = "iconButtonGuardar";
            iconButtonGuardar.Size = new Size(259, 141);
            iconButtonGuardar.TabIndex = 39;
            iconButtonGuardar.Text = "Guardar";
            iconButtonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonGuardar.UseVisualStyleBackColor = false;
            iconButtonGuardar.Click += iconButtonGuardar_Click;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(479, 136);
            label3.Name = "label3";
            label3.Size = new Size(533, 57);
            label3.TabIndex = 38;
            label3.Text = "Agregar/Editar Impresiones";
            // 
            // txtPrecioBase
            // 
            txtPrecioBase.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecioBase.Location = new Point(324, 487);
            txtPrecioBase.Name = "txtPrecioBase";
            txtPrecioBase.Size = new Size(742, 32);
            txtPrecioBase.TabIndex = 36;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(228, 495);
            label8.Name = "label8";
            label8.Size = new Size(63, 24);
            label8.TabIndex = 35;
            label8.Text = "Precio:";
            // 
            // txtTamanio
            // 
            txtTamanio.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtTamanio.Location = new Point(324, 317);
            txtTamanio.Name = "txtTamanio";
            txtTamanio.Size = new Size(742, 32);
            txtTamanio.TabIndex = 31;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(218, 325);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(73, 24);
            labelNombre.TabIndex = 30;
            labelNombre.Text = "Tamaño:";
            // 
            // AgregarEditarImpresionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1660, 850);
            Controls.Add(iconButtonSalir);
            Controls.Add(iconButtonGuardar);
            Controls.Add(label3);
            Controls.Add(txtPrecioBase);
            Controls.Add(label8);
            Controls.Add(txtTamanio);
            Controls.Add(labelNombre);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarEditarImpresionesView";
            Text = "AgregarEditarImpresionesView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private FontAwesome.Sharp.IconButton iconButtonGuardar;
        private Label label3;
        private TextBox txtPrecioBase;
        private Label label8;
        private TextBox txtTamanio;
        private Label labelNombre;
    }
}