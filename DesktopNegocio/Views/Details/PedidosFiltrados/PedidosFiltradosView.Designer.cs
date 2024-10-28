namespace DesktopNegocio.Views.Details.PedidosFiltrados
{
    partial class PedidosFiltradosView
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
            cboClientes = new ComboBox();
            label1 = new Label();
            label2 = new Label();
            cboRubro = new ComboBox();
            label3 = new Label();
            cboEstados = new ComboBox();
            btnFiltrar = new FontAwesome.Sharp.IconButton();
            dataGridPedidos = new DataGridView();
            label4 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).BeginInit();
            SuspendLayout();
            // 
            // cboClientes
            // 
            cboClientes.FormattingEnabled = true;
            cboClientes.Location = new Point(108, 102);
            cboClientes.Name = "cboClientes";
            cboClientes.Size = new Size(351, 30);
            cboClientes.TabIndex = 0;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.BackColor = Color.Transparent;
            label1.Font = new Font("Bahnschrift Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.Location = new Point(13, 102);
            label1.Name = "label1";
            label1.Size = new Size(89, 28);
            label1.TabIndex = 1;
            label1.Text = "Cliente:";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.BackColor = Color.Transparent;
            label2.Font = new Font("Bahnschrift Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.Location = new Point(993, 104);
            label2.Name = "label2";
            label2.Size = new Size(81, 28);
            label2.TabIndex = 3;
            label2.Text = "Rubro:";
            // 
            // cboRubro
            // 
            cboRubro.FormattingEnabled = true;
            cboRubro.Location = new Point(1088, 104);
            cboRubro.Name = "cboRubro";
            cboRubro.Size = new Size(351, 30);
            cboRubro.TabIndex = 2;
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.BackColor = Color.Transparent;
            label3.Font = new Font("Bahnschrift Light", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.Location = new Point(492, 104);
            label3.Name = "label3";
            label3.Size = new Size(88, 28);
            label3.TabIndex = 5;
            label3.Text = "Estado:";
            // 
            // cboEstados
            // 
            cboEstados.FormattingEnabled = true;
            cboEstados.Location = new Point(587, 104);
            cboEstados.Name = "cboEstados";
            cboEstados.Size = new Size(351, 30);
            cboEstados.TabIndex = 4;
            // 
            // btnFiltrar
            // 
            btnFiltrar.BackColor = Color.FromArgb(128, 128, 255);
            btnFiltrar.Font = new Font("Bahnschrift SemiBold", 13.8F, FontStyle.Bold, GraphicsUnit.Point, 0);
            btnFiltrar.ForeColor = Color.White;
            btnFiltrar.IconChar = FontAwesome.Sharp.IconChar.Filter;
            btnFiltrar.IconColor = Color.White;
            btnFiltrar.IconFont = FontAwesome.Sharp.IconFont.Solid;
            btnFiltrar.Location = new Point(1467, 77);
            btnFiltrar.Name = "btnFiltrar";
            btnFiltrar.Size = new Size(145, 66);
            btnFiltrar.TabIndex = 6;
            btnFiltrar.Text = "Filtrar";
            btnFiltrar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnFiltrar.UseVisualStyleBackColor = false;
            btnFiltrar.Click += btnFiltrar_Click;
            // 
            // dataGridPedidos
            // 
            dataGridPedidos.AllowUserToAddRows = false;
            dataGridPedidos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridPedidos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridPedidos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPedidos.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridPedidos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridPedidos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridPedidos.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridPedidos.Location = new Point(44, 156);
            dataGridPedidos.Name = "dataGridPedidos";
            dataGridPedidos.ReadOnly = true;
            dataGridPedidos.RowHeadersWidth = 51;
            dataGridPedidos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridPedidos.Size = new Size(1591, 661);
            dataGridPedidos.TabIndex = 7;
            dataGridPedidos.CellContentClick += dataGridPedidos_CellContentClick;
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Font = new Font("Bahnschrift SemiCondensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label4.ForeColor = Color.FromArgb(255, 128, 0);
            label4.Location = new Point(194, 18);
            label4.Name = "label4";
            label4.Size = new Size(371, 72);
            label4.TabIndex = 8;
            label4.Text = "Filtrar Pedidos";
            // 
            // PedidosFiltradosView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 192, 128);
            ClientSize = new Size(1660, 860);
            Controls.Add(label4);
            Controls.Add(dataGridPedidos);
            Controls.Add(btnFiltrar);
            Controls.Add(label3);
            Controls.Add(cboEstados);
            Controls.Add(label2);
            Controls.Add(cboRubro);
            Controls.Add(label1);
            Controls.Add(cboClientes);
            Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PedidosFiltradosView";
            Text = "Pedidos Filtrados";
            ((System.ComponentModel.ISupportInitialize)dataGridPedidos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private ComboBox cboClientes;
        private Label label1;
        private Label label2;
        private ComboBox cboRubro;
        private Label label3;
        private ComboBox cboEstados;
        private FontAwesome.Sharp.IconButton btnFiltrar;
        private DataGridView dataGridPedidos;
        private Label label4;
    }
}