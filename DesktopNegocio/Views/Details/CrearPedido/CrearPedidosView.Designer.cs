namespace DesktopNegocio.Views.Details.CrearPedido
{
    partial class CrearPedidosView
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
            label1 = new Label();
            cboClientes = new ComboBox();
            cboModoPagos = new ComboBox();
            label2 = new Label();
            dtpFechaPedido = new DateTimePicker();
            label3 = new Label();
            cboEstadosPedidos = new ComboBox();
            label4 = new Label();
            cbFuePagado = new CheckBox();
            label5 = new Label();
            dataGridDetallePedido = new DataGridView();
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
            lbltotalPedido = new Label();
            iconButtonGuardar = new FontAwesome.Sharp.IconButton();
            label8 = new Label();
            panel2 = new Panel();
            label11 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridDetallePedido).BeginInit();
            panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadImpresion).BeginInit();
            ((System.ComponentModel.ISupportInitialize)cantidadProducto).BeginInit();
            panel2.SuspendLayout();
            SuspendLayout();
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Location = new Point(188, 75);
            label1.Name = "label1";
            label1.Size = new Size(58, 22);
            label1.TabIndex = 0;
            label1.Text = "Cliente";
            // 
            // cboClientes
            // 
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(188, 100);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(402, 30);
            cboClientes.TabIndex = 1;
            // 
            // cboModoPagos
            // 
            cboModoPagos.FormattingEnabled = true;
            cboModoPagos.Location = new Point(645, 100);
            cboModoPagos.Name = "cboModoPagos";
            cboModoPagos.Size = new Size(402, 30);
            cboModoPagos.TabIndex = 3;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(645, 75);
            label2.Name = "label2";
            label2.Size = new Size(104, 22);
            label2.TabIndex = 2;
            label2.Text = "Modo de Pago";
            // 
            // dtpFechaPedido
            // 
            dtpFechaPedido.Location = new Point(195, 210);
            dtpFechaPedido.Name = "dtpFechaPedido";
            dtpFechaPedido.Size = new Size(395, 29);
            dtpFechaPedido.TabIndex = 4;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(198, 182);
            label3.Name = "label3";
            label3.Size = new Size(125, 22);
            label3.TabIndex = 5;
            label3.Text = "Fecha del pedido";
            // 
            // cboEstadosPedidos
            // 
            cboEstadosPedidos.FormattingEnabled = true;
            cboEstadosPedidos.Location = new Point(645, 209);
            cboEstadosPedidos.Name = "cboEstadosPedidos";
            cboEstadosPedidos.Size = new Size(402, 30);
            cboEstadosPedidos.TabIndex = 7;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(645, 184);
            label4.Name = "label4";
            label4.Size = new Size(130, 22);
            label4.TabIndex = 6;
            label4.Text = "Estado del Pedido";
            // 
            // cbFuePagado
            // 
            cbFuePagado.AutoSize = true;
            cbFuePagado.Location = new Point(562, 155);
            cbFuePagado.Name = "cbFuePagado";
            cbFuePagado.Size = new Size(111, 26);
            cbFuePagado.TabIndex = 8;
            cbFuePagado.Text = "Fue Pagado";
            cbFuePagado.UseVisualStyleBackColor = true;
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(115, 249);
            label5.Name = "label5";
            label5.Size = new Size(133, 22);
            label5.TabIndex = 9;
            label5.Text = "Detalle del Pedido";
            // 
            // dataGridDetallePedido
            // 
            dataGridDetallePedido.AllowUserToAddRows = false;
            dataGridDetallePedido.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridDetallePedido.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridDetallePedido.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDetallePedido.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridDetallePedido.BorderStyle = BorderStyle.None;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridDetallePedido.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridDetallePedido.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridDetallePedido.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridDetallePedido.Location = new Point(115, 274);
            dataGridDetallePedido.Name = "dataGridDetallePedido";
            dataGridDetallePedido.ReadOnly = true;
            dataGridDetallePedido.RowHeadersWidth = 51;
            dataGridDetallePedido.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridDetallePedido.Size = new Size(1029, 364);
            dataGridDetallePedido.TabIndex = 10;
            dataGridDetallePedido.CellClick += dataGridDetallePedido_CellClick;
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(255, 128, 0);
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
            panel1.Location = new Point(115, 644);
            panel1.Name = "panel1";
            panel1.Size = new Size(1029, 193);
            panel1.TabIndex = 11;
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
            iconButtonGuardar.Location = new Point(1267, 209);
            iconButtonGuardar.Name = "iconButtonGuardar";
            iconButtonGuardar.Size = new Size(259, 141);
            iconButtonGuardar.TabIndex = 48;
            iconButtonGuardar.Text = "Guardar";
            iconButtonGuardar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonGuardar.UseVisualStyleBackColor = false;
            iconButtonGuardar.Click += iconButtonGuardar_Click;
            // 
            // label8
            // 
            label8.AutoSize = true;
            label8.Font = new Font("Bahnschrift SemiCondensed", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label8.ForeColor = Color.FromArgb(255, 128, 0);
            label8.Location = new Point(140, 19);
            label8.Name = "label8";
            label8.Size = new Size(191, 41);
            label8.TabIndex = 50;
            label8.Text = "Crear Pedido";
            // 
            // panel2
            // 
            panel2.BackColor = Color.FromArgb(255, 128, 0);
            panel2.BorderStyle = BorderStyle.FixedSingle;
            panel2.Controls.Add(label11);
            panel2.Controls.Add(lbltotalPedido);
            panel2.ForeColor = Color.White;
            panel2.Location = new Point(1174, 513);
            panel2.Name = "panel2";
            panel2.Size = new Size(392, 131);
            panel2.TabIndex = 51;
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
            // CrearPedidosView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1660, 860);
            Controls.Add(panel2);
            Controls.Add(label8);
            Controls.Add(iconButtonGuardar);
            Controls.Add(panel1);
            Controls.Add(dataGridDetallePedido);
            Controls.Add(label5);
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
            FormBorderStyle = FormBorderStyle.None;
            Name = "CrearPedidosView";
            Text = "Crear Pedido";
            ((System.ComponentModel.ISupportInitialize)dataGridDetallePedido).EndInit();
            panel1.ResumeLayout(false);
            panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)cantidadImpresion).EndInit();
            ((System.ComponentModel.ISupportInitialize)cantidadProducto).EndInit();
            panel2.ResumeLayout(false);
            panel2.PerformLayout();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label label1;
        private ComboBox cboClientes;
        private ComboBox cboModoPagos;
        private Label label2;
        private DateTimePicker dtpFechaPedido;
        private Label label3;
        private ComboBox cboEstadosPedidos;
        private Label label4;
        private CheckBox cbFuePagado;
        private Label label5;
        private DataGridView dataGridDetallePedido;
        private Panel panel1;
        private NumericUpDown cantidadProducto;
        private Label label6;
        private ComboBox cboProductos;
        private Label label9;
        private NumericUpDown cantidadImpresion;
        private Label label10;
        private ComboBox cboImpresiones;
        private Label lbltotalPedido;
        private Label label7;
        private FontAwesome.Sharp.IconButton btnAgregarProducto;
        private FontAwesome.Sharp.IconButton iconButtonGuardar;
        private FontAwesome.Sharp.IconButton btnAgregarImpresion;
        private Label label8;
        private Panel panel2;
        private Label label11;
    }
}