namespace DesktopNegocio.Views.Details.PedidosFiltrados
{
    partial class DetallePedidoView
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
            lblPedidoId = new Label();
            lblTotal = new Label();
            lblEstado = new Label();
            lblFechaPedido = new Label();
            lblCliente = new Label();
            dataGridDetalle = new DataGridView();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            label2 = new Label();
            label3 = new Label();
            label4 = new Label();
            label5 = new Label();
            label6 = new Label();
            chFuePagado = new CheckBox();
            ((System.ComponentModel.ISupportInitialize)dataGridDetalle).BeginInit();
            SuspendLayout();
            // 
            // lblPedidoId
            // 
            lblPedidoId.AutoSize = true;
            lblPedidoId.BorderStyle = BorderStyle.FixedSingle;
            lblPedidoId.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblPedidoId.Location = new Point(226, 80);
            lblPedidoId.Name = "lblPedidoId";
            lblPedidoId.Size = new Size(2, 36);
            lblPedidoId.TabIndex = 0;
            // 
            // lblTotal
            // 
            lblTotal.AutoSize = true;
            lblTotal.BorderStyle = BorderStyle.FixedSingle;
            lblTotal.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblTotal.Location = new Point(745, 555);
            lblTotal.Name = "lblTotal";
            lblTotal.Size = new Size(2, 36);
            lblTotal.TabIndex = 1;
            // 
            // lblEstado
            // 
            lblEstado.AutoSize = true;
            lblEstado.BorderStyle = BorderStyle.FixedSingle;
            lblEstado.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblEstado.Location = new Point(652, 139);
            lblEstado.Name = "lblEstado";
            lblEstado.Size = new Size(2, 36);
            lblEstado.TabIndex = 2;
            // 
            // lblFechaPedido
            // 
            lblFechaPedido.AutoSize = true;
            lblFechaPedido.BorderStyle = BorderStyle.FixedSingle;
            lblFechaPedido.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblFechaPedido.Location = new Point(226, 139);
            lblFechaPedido.Name = "lblFechaPedido";
            lblFechaPedido.Size = new Size(2, 36);
            lblFechaPedido.TabIndex = 3;
            // 
            // lblCliente
            // 
            lblCliente.AutoSize = true;
            lblCliente.BorderStyle = BorderStyle.FixedSingle;
            lblCliente.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            lblCliente.Location = new Point(652, 80);
            lblCliente.Name = "lblCliente";
            lblCliente.Size = new Size(2, 36);
            lblCliente.TabIndex = 4;
            // 
            // dataGridDetalle
            // 
            dataGridDetalle.AllowUserToAddRows = false;
            dataGridDetalle.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridDetalle.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridDetalle.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridDetalle.BackgroundColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridDetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridDetalle.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(255, 224, 192);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(255, 128, 0);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridDetalle.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridDetalle.Location = new Point(48, 192);
            dataGridDetalle.Name = "dataGridDetalle";
            dataGridDetalle.ReadOnly = true;
            dataGridDetalle.RowHeadersWidth = 51;
            dataGridDetalle.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridDetalle.Size = new Size(993, 360);
            dataGridDetalle.TabIndex = 5;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(387, -1);
            label1.Name = "label1";
            label1.Size = new Size(435, 72);
            label1.TabIndex = 6;
            label1.Text = "Detalle de Pedido";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Gray;
            iconButton1.Font = new Font("Bahnschrift SemiCondensed", 13.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.Close;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 35;
            iconButton1.Location = new Point(951, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(122, 45);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Cerrar";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Location = new Point(141, 89);
            label2.Name = "label2";
            label2.Size = new Size(79, 22);
            label2.TabIndex = 8;
            label2.Text = "N° Pedido:";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Location = new Point(165, 148);
            label3.Name = "label3";
            label3.Size = new Size(55, 22);
            label3.TabIndex = 9;
            label3.Text = "Fecha:";
            // 
            // label4
            // 
            label4.AutoSize = true;
            label4.Location = new Point(584, 94);
            label4.Name = "label4";
            label4.Size = new Size(62, 22);
            label4.TabIndex = 10;
            label4.Text = "Cliente:";
            // 
            // label5
            // 
            label5.AutoSize = true;
            label5.Location = new Point(584, 153);
            label5.Name = "label5";
            label5.Size = new Size(60, 22);
            label5.TabIndex = 11;
            label5.Text = "Estado:";
            // 
            // label6
            // 
            label6.AutoSize = true;
            label6.Location = new Point(635, 564);
            label6.Name = "label6";
            label6.Size = new Size(104, 22);
            label6.TabIndex = 12;
            label6.Text = "Importe Total:";
            // 
            // chFuePagado
            // 
            chFuePagado.AutoSize = true;
            chFuePagado.Location = new Point(948, 145);
            chFuePagado.Name = "chFuePagado";
            chFuePagado.Size = new Size(92, 26);
            chFuePagado.TabIndex = 13;
            chFuePagado.Text = "Abonado";
            chFuePagado.UseVisualStyleBackColor = true;
            // 
            // DetallePedidoView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(255, 128, 0);
            ClientSize = new Size(1100, 600);
            Controls.Add(chFuePagado);
            Controls.Add(label6);
            Controls.Add(label5);
            Controls.Add(label4);
            Controls.Add(label3);
            Controls.Add(label2);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Controls.Add(dataGridDetalle);
            Controls.Add(lblCliente);
            Controls.Add(lblFechaPedido);
            Controls.Add(lblEstado);
            Controls.Add(lblTotal);
            Controls.Add(lblPedidoId);
            Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetallePedidoView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "DetallePedidoView";
            ((System.ComponentModel.ISupportInitialize)dataGridDetalle).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Label lblPedidoId;
        private Label lblTotal;
        private Label lblEstado;
        private Label lblFechaPedido;
        private Label lblCliente;
        private DataGridView dataGridDetalle;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
        private Label label2;
        private Label label3;
        private Label label4;
        private Label label5;
        private Label label6;
        private CheckBox chFuePagado;
    }
}