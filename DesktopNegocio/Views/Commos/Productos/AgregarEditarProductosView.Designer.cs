namespace DesktopNegocio.Views.Commos.Productos
{
    partial class AgregarEditarProductosView
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
            txtPrecio = new TextBox();
            label8 = new Label();
            txtStock = new TextBox();
            label2 = new Label();
            label1 = new Label();
            txtNombre = new TextBox();
            labelNombre = new Label();
            cboRubro = new ComboBox();
            label3 = new Label();
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            iconButtonGuardar = new FontAwesome.Sharp.IconButton();
            SuspendLayout();
            // 
            // txtPrecio
            // 
            txtPrecio.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtPrecio.Location = new Point(300, 429);
            txtPrecio.Name = "txtPrecio";
            txtPrecio.Size = new Size(742, 32);
            txtPrecio.TabIndex = 25;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.Location = new Point(122, 437);
            label8.Name = "label8";
            label8.Size = new Size(63, 24);
            label8.TabIndex = 24;
            label8.Text = "Precio:";
            // 
            // txtStock
            // 
            txtStock.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtStock.Location = new Point(300, 510);
            txtStock.Name = "txtStock";
            txtStock.Size = new Size(742, 32);
            txtStock.TabIndex = 23;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(122, 518);
            label2.Name = "label2";
            label2.Size = new Size(57, 24);
            label2.TabIndex = 22;
            label2.Text = "Stock:";
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(122, 347);
            label1.Name = "label1";
            label1.Size = new Size(60, 24);
            label1.TabIndex = 20;
            label1.Text = "Rubro:";
            // 
            // txtNombre
            // 
            txtNombre.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtNombre.Location = new Point(300, 259);
            txtNombre.Name = "txtNombre";
            txtNombre.Size = new Size(742, 32);
            txtNombre.TabIndex = 19;
            // 
            // labelNombre
            // 
            labelNombre.AutoSize = true;
            labelNombre.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            labelNombre.Location = new Point(122, 267);
            labelNombre.Name = "labelNombre";
            labelNombre.Size = new Size(74, 24);
            labelNombre.TabIndex = 18;
            labelNombre.Text = "Nombre:";
            // 
            // cboRubro
            // 
            cboRubro.FormattingEnabled = true;
            cboRubro.Location = new Point(300, 343);
            cboRubro.Name = "cboRubro";
            cboRubro.Size = new Size(742, 29);
            cboRubro.TabIndex = 26;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(455, 78);
            label3.Name = "label3";
            label3.Size = new Size(345, 41);
            label3.TabIndex = 27;
            label3.Text = "Agregar/Editar Producto";
            // 
            // iconButtonSalir
            // 
            iconButtonSalir.BackColor = Color.Gray;
            iconButtonSalir.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonSalir.ForeColor = Color.White;
            iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.DoorOpen;
            iconButtonSalir.IconColor = Color.White;
            iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSalir.Location = new Point(1232, 515);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Size = new Size(259, 141);
            iconButtonSalir.TabIndex = 29;
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
            iconButtonGuardar.Location = new Point(1232, 201);
            iconButtonGuardar.Name = "iconButtonGuardar";
            iconButtonGuardar.Size = new Size(259, 141);
            iconButtonGuardar.TabIndex = 28;
            iconButtonGuardar.Text = "Guardar";
            iconButtonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonGuardar.UseVisualStyleBackColor = false;
            iconButtonGuardar.Click += iconButtonGuardar_Click;
            // 
            // AgregarEditarProductosView
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1660, 850);
            Controls.Add(iconButtonSalir);
            Controls.Add(iconButtonGuardar);
            Controls.Add(label3);
            Controls.Add(cboRubro);
            Controls.Add(txtPrecio);
            Controls.Add(label8);
            Controls.Add(txtStock);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtNombre);
            Controls.Add(labelNombre);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "AgregarEditarProductosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "AgregarEditarProductosView";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private TextBox txtPrecio;
        private Label label8;
        private TextBox txtStock;
        private Label label2;
        private Label label1;
        private TextBox txtNombre;
        private Label labelNombre;
        private ComboBox cboRubro;
        private Label label3;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
        private FontAwesome.Sharp.IconButton iconButtonGuardar;
    }
}