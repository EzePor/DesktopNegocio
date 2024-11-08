namespace DesktopNegocio.Views.Commos.Modos_Pagos
{
    partial class ModosPagosView
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
            BtnBuscarModoPago = new FontAwesome.Sharp.IconButton();
            textBoxBuscarModoPago = new TextBox();
            label2 = new Label();
            dataGridViewModosPagos = new DataGridView();
            iconButtonEditar = new FontAwesome.Sharp.IconButton();
            iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewModosPagos).BeginInit();
            SuspendLayout();
            // 
            // BtnBuscarModoPago
            // 
            BtnBuscarModoPago.BackColor = Color.FromArgb(255, 128, 0);
            BtnBuscarModoPago.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarModoPago.ForeColor = Color.White;
            BtnBuscarModoPago.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscarModoPago.IconColor = Color.White;
            BtnBuscarModoPago.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscarModoPago.IconSize = 55;
            BtnBuscarModoPago.Location = new Point(1154, 69);
            BtnBuscarModoPago.Name = "BtnBuscarModoPago";
            BtnBuscarModoPago.Size = new Size(149, 65);
            BtnBuscarModoPago.TabIndex = 22;
            BtnBuscarModoPago.Text = "&Buscar";
            BtnBuscarModoPago.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBuscarModoPago.UseVisualStyleBackColor = false;
            BtnBuscarModoPago.Click += BtnBuscarModoPago_Click;
            // 
            // textBoxBuscarModoPago
            // 
            textBoxBuscarModoPago.Location = new Point(60, 97);
            textBoxBuscarModoPago.Name = "textBoxBuscarModoPago";
            textBoxBuscarModoPago.Size = new Size(1088, 29);
            textBoxBuscarModoPago.TabIndex = 23;
            textBoxBuscarModoPago.TextChanged += textBoxBuscarModoPago_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiBold SemiConden", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(152, 20);
            label2.Name = "label2";
            label2.Size = new Size(327, 57);
            label2.TabIndex = 21;
            label2.Text = "Modos de Pagos:";
            // 
            // dataGridViewModosPagos
            // 
            dataGridViewModosPagos.AllowUserToAddRows = false;
            dataGridViewModosPagos.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(0, 5, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewModosPagos.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewModosPagos.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewModosPagos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewModosPagos.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewModosPagos.BorderStyle = BorderStyle.None;
            dataGridViewModosPagos.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewModosPagos.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewModosPagos.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewModosPagos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewModosPagos.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewModosPagos.Location = new Point(34, 158);
            dataGridViewModosPagos.Name = "dataGridViewModosPagos";
            dataGridViewModosPagos.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.Blue;
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewModosPagos.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewModosPagos.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.Blue;
            dataGridViewModosPagos.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewModosPagos.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewModosPagos.Size = new Size(1601, 539);
            dataGridViewModosPagos.TabIndex = 20;
            // 
            // iconButtonEditar
            // 
            iconButtonEditar.BackColor = Color.FromArgb(224, 224, 224);
            iconButtonEditar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonEditar.ForeColor = Color.Blue;
            iconButtonEditar.IconChar = FontAwesome.Sharp.IconChar.Pencil;
            iconButtonEditar.IconColor = Color.Blue;
            iconButtonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEditar.Location = new Point(554, 761);
            iconButtonEditar.Name = "iconButtonEditar";
            iconButtonEditar.Size = new Size(226, 63);
            iconButtonEditar.TabIndex = 26;
            iconButtonEditar.Text = "Editar";
            iconButtonEditar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonEditar.UseVisualStyleBackColor = false;
            iconButtonEditar.Click += iconButtonEditar_Click;
            // 
            // iconButtonEliminar
            // 
            iconButtonEliminar.BackColor = Color.FromArgb(224, 224, 224);
            iconButtonEliminar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonEliminar.ForeColor = Color.Red;
            iconButtonEliminar.IconChar = FontAwesome.Sharp.IconChar.TrashAlt;
            iconButtonEliminar.IconColor = Color.Red;
            iconButtonEliminar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEliminar.Location = new Point(1068, 761);
            iconButtonEliminar.Name = "iconButtonEliminar";
            iconButtonEliminar.Size = new Size(226, 63);
            iconButtonEliminar.TabIndex = 25;
            iconButtonEliminar.Text = "Eliminar";
            iconButtonEliminar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonEliminar.UseVisualStyleBackColor = false;
            iconButtonEliminar.Click += iconButtonEliminar_Click;
            // 
            // iconButtonAgregar
            // 
            iconButtonAgregar.BackColor = Color.FromArgb(224, 224, 224);
            iconButtonAgregar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonAgregar.ForeColor = Color.FromArgb(0, 192, 0);
            iconButtonAgregar.IconChar = FontAwesome.Sharp.IconChar.FileCirclePlus;
            iconButtonAgregar.IconColor = Color.FromArgb(0, 192, 0);
            iconButtonAgregar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonAgregar.Location = new Point(60, 761);
            iconButtonAgregar.Name = "iconButtonAgregar";
            iconButtonAgregar.Size = new Size(226, 63);
            iconButtonAgregar.TabIndex = 24;
            iconButtonAgregar.Text = "Agregar";
            iconButtonAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonAgregar.UseVisualStyleBackColor = false;
            iconButtonAgregar.Click += iconButtonAgregar_Click;
            // 
            // ModosPagosView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1660, 850);
            Controls.Add(iconButtonEditar);
            Controls.Add(iconButtonEliminar);
            Controls.Add(iconButtonAgregar);
            Controls.Add(BtnBuscarModoPago);
            Controls.Add(textBoxBuscarModoPago);
            Controls.Add(label2);
            Controls.Add(dataGridViewModosPagos);
            Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ModosPagosView";
            StartPosition = FormStartPosition.CenterParent;
            Text = "Modos de Pagos";
            ((System.ComponentModel.ISupportInitialize)dataGridViewModosPagos).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnBuscarModoPago;
        private TextBox textBoxBuscarModoPago;
        private Label label2;
        private DataGridView dataGridViewModosPagos;
        private FontAwesome.Sharp.IconButton iconButtonEditar;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
    }
}