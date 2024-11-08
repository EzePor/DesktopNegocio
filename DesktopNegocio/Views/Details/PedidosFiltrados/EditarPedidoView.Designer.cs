namespace DesktopNegocio.Views.Details.PedidosFiltrados
{
    partial class EditarPedidoView
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
            DataGridViewCellStyle dataGridViewCellStyle3 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle4 = new DataGridViewCellStyle();
            DataGridViewCellStyle dataGridViewCellStyle5 = new DataGridViewCellStyle();
            label8 = new Label();
            cbFuePagado = new CheckBox();
            cboEstadosPedidos = new ComboBox();
            label4 = new Label();
            label3 = new Label();
            dtpFechaPedido = new DateTimePicker();
            cboModoPagos = new ComboBox();
            label2 = new Label();
            cboClientes = new ComboBox();
            label1 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            lbltotalPedido = new Label();
            iconButtonGuardar = new FontAwesome.Sharp.IconButton();
            panel1 = new Panel();
            btnAgregarImpresion = new FontAwesome.Sharp.IconButton();
            label9 = new Label();
            cantidadImpresion = new NumericUpDown();
            label10 = new Label();
            cboImpresiones = new ComboBox();
            label7 = new Label();
            btnAgregarProducto = new FontAwesome.Sharp.IconButton();
            cantidadProducto = new NumericUpDown();
            label6 = new Label();
            cboProductos = new ComboBox();
            dataGridDetallePedido = new DataGridView();
            label5 = new Label();
            iconButtonSalir = new FontAwesome.Sharp.IconButton();
            panel2.SuspendLayout();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadImpresion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantidadProducto).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDetallePedido).BeginInit();
            SuspendLayout();
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiCondensed", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.White;
            label8.Location = new Point(292, 21);
            label8.Name = "label8";
            label8.Size = new Size(267, 57);
            label8.TabIndex = 60;
            label8.Text = "Editar Pedido";
            // 
            // cbFuePagado
            // 
            cbFuePagado.AutoSize = true;
            cbFuePagado.Location = new Point(555, 164);
            cbFuePagado.Name = "cbFuePagado";
            cbFuePagado.Size = new Size(111, 26);
            cbFuePagado.TabIndex = 59;
            cbFuePagado.Text = "Fue Pagado";
            cbFuePagado.UseVisualStyleBackColor = true;
            // 
            // cboEstadosPedidos
            // 
            cboEstadosPedidos.FormattingEnabled = true;
            cboEstadosPedidos.Location = new Point(638, 218);
            cboEstadosPedidos.Name = "cboEstadosPedidos";
            cboEstadosPedidos.Size = new Size(402, 30);
            cboEstadosPedidos.TabIndex = 58;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(638, 193);
            label4.Name = "label4";
            label4.Size = new Size(130, 22);
            label4.TabIndex = 57;
            label4.Text = "Estado del Pedido";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(191, 191);
            label3.Name = "label3";
            label3.Size = new Size(125, 22);
            label3.TabIndex = 56;
            label3.Text = "Fecha del pedido";
            // 
            // dtpFechaPedido
            // 
            dtpFechaPedido.Location = new Point(188, 219);
            dtpFechaPedido.Name = "dtpFechaPedido";
            dtpFechaPedido.Size = new Size(395, 29);
            dtpFechaPedido.TabIndex = 55;
            // 
            // cboModoPagos
            // 
            cboModoPagos.FormattingEnabled = true;
            cboModoPagos.Location = new Point(638, 109);
            cboModoPagos.Name = "cboModoPagos";
            cboModoPagos.Size = new Size(402, 30);
            cboModoPagos.TabIndex = 54;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(638, 84);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 53;
            label2.Text = "Modo de Pago";
            // 
            // cboClientes
            // 
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(181, 109);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(402, 30);
            cboClientes.TabIndex = 52;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(181, 84);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 51;
            label1.Text = "Cliente";
            // 
            // panel2
            // 
            panel2.BackColor = Color.White;
            panel2.BackgroundImageLayout = ImageLayout.None;
            panel2.BorderStyle = BorderStyle.Fixed3D;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lbltotalPedido);
            panel2.ForeColor = Color.Black;
            panel2.Location = new Point(1227, 563);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 131);
            panel2.TabIndex = 65;
            // 
            // label11
            // 
            label11.AutoSize = true;
            label11.Font = new Font("Bahnschrift SemiCondensed", 18F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label11.Location = new Point(109, 14);
            label11.Name = "label11";
            label11.Size = new Size(160, 36);
            label11.TabIndex = 6;
            label11.Text = "Total Pedido:";
            // 
            // lbltotalPedido
            // 
            lbltotalPedido.AutoSize = true;
            lbltotalPedido.Font = new Font("Bahnschrift Condensed", 25.8000011F, FontStyle.Bold, GraphicsUnit.Point, 0);
            lbltotalPedido.Location = new Point(92, 54);
            lbltotalPedido.Name = "lbltotalPedido";
            lbltotalPedido.Size = new Size(0, 53);
            lbltotalPedido.TabIndex = 5;
            // 
            // iconButtonGuardar
            // 
            iconButtonGuardar.BackColor = Color.Blue;
            iconButtonGuardar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonGuardar.ForeColor = Color.White;
            iconButtonGuardar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButtonGuardar.IconColor = Color.White;
            iconButtonGuardar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonGuardar.Location = new Point(1333, 252);
            iconButtonGuardar.Name = "iconButtonGuardar";
            iconButtonGuardar.Size = new Size(259, 141);
            iconButtonGuardar.TabIndex = 64;
            iconButtonGuardar.Text = "Guardar";
            iconButtonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonGuardar.UseVisualStyleBackColor = false;
            iconButtonGuardar.Click += iconButtonGuardar_Click;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(192, 192, 255);
            panel1.Controls.Add(btnAgregarImpresion);
            panel1.Controls.Add(label9);
            panel1.Controls.Add(cantidadImpresion);
            panel1.Controls.Add(label10);
            panel1.Controls.Add(cboImpresiones);
            panel1.Controls.Add(label7);
            panel1.Controls.Add(btnAgregarProducto);
            panel1.Controls.Add(cantidadProducto);
            panel1.Controls.Add(label6);
            panel1.Controls.Add(cboProductos);
            panel1.ForeColor = Color.FromArgb(64, 64, 64);
            panel1.Location = new Point(181, 705);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 193);
            panel1.TabIndex = 63;
            // 
            // btnAgregarImpresion
            // 
            btnAgregarImpresion.BackColor = Color.Blue;
            btnAgregarImpresion.ForeColor = Color.White;
            btnAgregarImpresion.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btnAgregarImpresion.IconColor = Color.White;
            btnAgregarImpresion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarImpresion.IconSize = 28;
            btnAgregarImpresion.Location = new Point(795, 110);
            btnAgregarImpresion.Name = "btnAgregarImpresion";
            btnAgregarImpresion.Padding = new Padding(7, 0, 0, 0);
            btnAgregarImpresion.Size = new Size(183, 41);
            btnAgregarImpresion.TabIndex = 11;
            btnAgregarImpresion.Text = "Agregar Impresión";
            btnAgregarImpresion.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarImpresion.UseVisualStyleBackColor = false;
            btnAgregarImpresion.Click += btnAgregarImpresion_Click;
            // 
            // label9
            // 
            label9.AutoSize = true;
            label9.Location = new Point(510, 98);
            label9.Name = "label9";
            label9.Size = new Size(69, 22);
            label9.TabIndex = 10;
            label9.Text = "Cantidad";
            // 
            // cantidadImpresion
            // 
            cantidadImpresion.Location = new Point(510, 122);
            cantidadImpresion.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cantidadImpresion.Name = "cantidadImpresion";
            cantidadImpresion.Size = new Size(118, 29);
            cantidadImpresion.TabIndex = 8;
            cantidadImpresion.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label10
            // 
            label10.AutoSize = true;
            label10.Location = new Point(21, 96);
            label10.Name = "label10";
            label10.Size = new Size(96, 22);
            label10.TabIndex = 7;
            label10.Text = "Impresiones";
            // 
            // cboImpresiones
            // 
            cboImpresiones.FormattingEnabled = true;
            cboImpresiones.Location = new Point(21, 121);
            cboImpresiones.Name = "cboImpresiones";
            cboImpresiones.Size = new Size(443, 30);
            cboImpresiones.TabIndex = 6;
            // 
            // label7
            // 
            label7.AutoSize = true;
            label7.Location = new Point(510, 7);
            label7.Name = "label7";
            label7.Size = new Size(69, 22);
            label7.TabIndex = 4;
            label7.Text = "Cantidad";
            // 
            // btnAgregarProducto
            // 
            btnAgregarProducto.BackColor = Color.Blue;
            btnAgregarProducto.ForeColor = Color.White;
            btnAgregarProducto.IconChar = FontAwesome.Sharp.IconChar.CartPlus;
            btnAgregarProducto.IconColor = Color.White;
            btnAgregarProducto.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnAgregarProducto.IconSize = 28;
            btnAgregarProducto.Location = new Point(795, 19);
            btnAgregarProducto.Name = "btnAgregarProducto";
            btnAgregarProducto.Padding = new Padding(7, 0, 0, 0);
            btnAgregarProducto.Size = new Size(183, 41);
            btnAgregarProducto.TabIndex = 3;
            btnAgregarProducto.Text = "Agregar Producto";
            btnAgregarProducto.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnAgregarProducto.UseVisualStyleBackColor = false;
            btnAgregarProducto.Click += btnAgregarProducto_Click;
            // 
            // cantidadProducto
            // 
            cantidadProducto.Location = new Point(510, 31);
            cantidadProducto.Minimum = new decimal(new int[] { 1, 0, 0, 0 });
            cantidadProducto.Name = "cantidadProducto";
            cantidadProducto.Size = new Size(118, 29);
            cantidadProducto.TabIndex = 2;
            cantidadProducto.Value = new decimal(new int[] { 1, 0, 0, 0 });
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(21, 5);
            label6.Name = "label6";
            label6.Size = new Size(73, 22);
            label6.TabIndex = 1;
            label6.Text = "Producto";
            // 
            // cboProductos
            // 
            cboProductos.FormattingEnabled = true;
            cboProductos.Location = new Point(21, 30);
            cboProductos.Name = "cboProductos";
            cboProductos.Size = new Size(443, 30);
            cboProductos.TabIndex = 0;
            // 
            // dataGridDetallePedido
            // 
            dataGridDetallePedido.AllowUserToAddRows = false;
            dataGridDetallePedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.Blue;
            dataGridDetallePedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridDetallePedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDetallePedido.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridDetallePedido.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridDetallePedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = Color.White;
            dataGridViewCellStyle3.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridDetallePedido.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridDetallePedido.Location = new Point(181, 330);
            dataGridDetallePedido.Name = "dataGridDetallePedido";
            dataGridDetallePedido.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridDetallePedido.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridDetallePedido.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(224, 224, 224);
            dataGridViewCellStyle5.ForeColor = Color.FromArgb(64, 64, 64);
            dataGridViewCellStyle5.SelectionBackColor = Color.Blue;
            dataGridDetallePedido.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridDetallePedido.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDetallePedido.Size = new Size(1029, 364);
            dataGridDetallePedido.TabIndex = 62;
            dataGridDetallePedido.CellContentClick += dataGridDetallePedido_CellContentClick;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(181, 299);
            label5.Name = "label5";
            label5.Size = new Size(133, 22);
            label5.TabIndex = 61;
            label5.Text = "Detalle del Pedido";
            // 
            // iconButtonSalir
            // 
            iconButtonSalir.BackColor = Color.Silver;
            iconButtonSalir.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonSalir.ForeColor = Color.Gray;
            iconButtonSalir.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconButtonSalir.IconColor = Color.Gray;
            iconButtonSalir.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonSalir.Location = new Point(1333, 757);
            iconButtonSalir.Name = "iconButtonSalir";
            iconButtonSalir.Size = new Size(259, 141);
            iconButtonSalir.TabIndex = 66;
            iconButtonSalir.Text = "Salir";
            iconButtonSalir.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonSalir.UseVisualStyleBackColor = false;
            iconButtonSalir.Click += iconButtonSalir_Click;
            // 
            // EditarPedidoView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1868, 946);
            Controls.Add(iconButtonSalir);
            Controls.Add(panel2);
            Controls.Add(iconButtonGuardar);
            Controls.Add(panel1);
            Controls.Add(dataGridDetallePedido);
            Controls.Add(label5);
            Controls.Add(label8);
            Controls.Add(cbFuePagado);
            Controls.Add(cboEstadosPedidos);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(dtpFechaPedido);
            Controls.Add(cboModoPagos);
            Controls.Add(label2);
            Controls.Add(cboClientes);
            Controls.Add(label1);
            Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            ForeColor = Color.White;
            FormBorderStyle = FormBorderStyle.None;
            Name = "EditarPedidoView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "EditarPedido";
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadImpresion).EndInit();
            ((System.ComponentModel.ISupportInitialize)cantidadProducto).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridDetallePedido).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label8;
        private CheckBox cbFuePagado;
        private ComboBox cboEstadosPedidos;
        private Label label4;
        private Label label3;
        private DateTimePicker dtpFechaPedido;
        private ComboBox cboModoPagos;
        private Label label2;
        private ComboBox cboClientes;
        private Label label1;
        private Panel panel2;
        private Label label11;
        private Label lbltotalPedido;
        private FontAwesome.Sharp.IconButton iconButtonGuardar;
        private Panel panel1;
        private FontAwesome.Sharp.IconButton btnAgregarImpresion;
        private Label label9;
        private NumericUpDown cantidadImpresion;
        private Label label10;
        private ComboBox cboImpresiones;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private NumericUpDown cantidadProducto;
        private Label label6;
        private ComboBox cboProductos;
        private DataGridView dataGridDetallePedido;
        private Label label5;
        private FontAwesome.Sharp.IconButton iconButtonSalir;
    }
}