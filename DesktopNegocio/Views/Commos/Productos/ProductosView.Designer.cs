namespace DesktopNegocio.Views.Commos
{
    partial class ProductosView
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
            DataGridViewCellStyle dataGridViewCellStyle1 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle2 = new DataGridViewCellStyle();
            BtnBuscarProducto = new FontAwesome.Sharp.IconButton();
            textBoxBuscarProducto = new TextBox();
            label2 = new Label();
            dataGridViewProductos = new DataGridView();
            iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            iconButtonEditar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            SuspendLayout();
            // 
            // BtnBuscarProducto
            // 
            BtnBuscarProducto.BackColor = Color.FromArgb(255, 128, 0);
            BtnBuscarProducto.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarProducto.ForeColor = Color.White;
            BtnBuscarProducto.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscarProducto.IconColor = Color.White;
            BtnBuscarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscarProducto.IconSize = 55;
            BtnBuscarProducto.Location = new Point(1302, 61);
            BtnBuscarProducto.Name = "BtnBuscarProducto";
            BtnBuscarProducto.Size = new Size(168, 68);
            BtnBuscarProducto.TabIndex = 11;
            BtnBuscarProducto.Text = "&Buscar";
            BtnBuscarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBuscarProducto.UseVisualStyleBackColor = false;
            BtnBuscarProducto.Click += BtnBuscarProducto_Click;
            // 
            // textBoxBuscarProducto
            // 
            textBoxBuscarProducto.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            textBoxBuscarProducto.Location = new Point(82, 80);
            textBoxBuscarProducto.Name = "textBoxBuscarProducto";
            textBoxBuscarProducto.Size = new Size(1212, 32);
            textBoxBuscarProducto.TabIndex = 10;
            textBoxBuscarProducto.TextChanged += textBoxBuscarProducto_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold Condensed", 24F, FontStyle.Bold | FontStyle.Underline, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.FromArgb(255, 128, 0);
            label2.Location = new Point(42, 26);
            label2.Name = "label2";
            label2.Size = new Size(158, 48);
            label2.TabIndex = 9;
            label2.Text = "Productos:";
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewProductos.BorderStyle = BorderStyle.None;
            dataGridViewProductos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewProductos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.True;
            dataGridViewProductos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.False;
            dataGridViewProductos.DefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewProductos.Location = new Point(42, 154);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewProductos.Size = new Size(1801, 565);
            dataGridViewProductos.TabIndex = 8;
            // 
            // iconButtonEliminar
            // 
            iconButtonEliminar.BackColor = Color.Red;
            iconButtonEliminar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonEliminar.ForeColor = Color.White;
            iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.DeleteLeft;
            iconButtonEliminar.IconColor = Color.White;
            iconButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEliminar.Location = new Point(1572, 807);
            iconButtonEliminar.Name = "iconButtonEliminar";
            iconButtonEliminar.Size = new Size(226, 63);
            iconButtonEliminar.TabIndex = 14;
            iconButtonEliminar.Text = "Eliminar";
            iconButtonEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonEliminar.UseVisualStyleBackColor = false;
            iconButtonEliminar.Click += iconButtonEliminar_Click;
            // 
            // iconButtonAgregar
            // 
            iconButtonAgregar.BackColor = Color.FromArgb(0, 192, 0);
            iconButtonAgregar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonAgregar.ForeColor = Color.White;
            iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButtonAgregar.IconColor = Color.White;
            iconButtonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAgregar.Location = new Point(82, 807);
            iconButtonAgregar.Name = "iconButtonAgregar";
            iconButtonAgregar.Size = new Size(226, 63);
            iconButtonAgregar.TabIndex = 12;
            iconButtonAgregar.Text = "Agregar";
            iconButtonAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonAgregar.UseVisualStyleBackColor = false;
            iconButtonAgregar.Click += iconButtonAgregar_Click;
            // 
            // iconButtonEditar
            // 
            iconButtonEditar.BackColor = Color.Blue;
            iconButtonEditar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonEditar.ForeColor = Color.White;
            iconButtonEditar.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            iconButtonEditar.IconColor = Color.White;
            iconButtonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEditar.Location = new Point(875, 807);
            iconButtonEditar.Name = "iconButtonEditar";
            iconButtonEditar.Size = new Size(226, 63);
            iconButtonEditar.TabIndex = 15;
            iconButtonEditar.Text = "Editar";
            iconButtonEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonEditar.UseVisualStyleBackColor = false;
            iconButtonEditar.Click += iconButtonEditar_Click;
            // 
            // ProductosView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1871, 939);
            Controls.Add(iconButtonEditar);
            Controls.Add(iconButtonEliminar);
            Controls.Add(iconButtonAgregar);
            Controls.Add(BtnBuscarProducto);
            Controls.Add(textBoxBuscarProducto);
            Controls.Add(label2);
            Controls.Add(dataGridViewProductos);
            Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ProductosView";
            Text = "Productos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnBuscarProducto;
        private TextBox textBoxBuscarProducto;
        private Label label2;
        private DataGridView dataGridViewProductos;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
        private FontAwesome.Sharp.IconButton iconButtonEditar;
    }
}