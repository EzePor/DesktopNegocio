namespace DesktopNegocio.Views.Commos.Impresiones
{
    partial class ImpresionesView
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
            BtnBuscarImpresion = new FontAwesome.Sharp.IconButton();
            textBoxBuscarImpresion = new TextBox();
            label2 = new Label();
            dataGridViewImpresiones = new DataGridView();
            iconButtonEditar = new FontAwesome.Sharp.IconButton();
            iconButtonEliminar = new FontAwesome.Sharp.IconButton();
            iconButtonAgregar = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewImpresiones).BeginInit();
            SuspendLayout();
            // 
            // BtnBuscarImpresion
            // 
            BtnBuscarImpresion.BackColor = Color.FromArgb(255, 128, 0);
            BtnBuscarImpresion.Font = new Font("Bahnschrift SemiCondensed", 12F, FontStyle.Regular, GraphicsUnit.Point, 0);
            BtnBuscarImpresion.ForeColor = Color.White;
            BtnBuscarImpresion.IconChar = FontAwesome.Sharp.IconChar.Search;
            BtnBuscarImpresion.IconColor = Color.White;
            BtnBuscarImpresion.IconFont = FontAwesome.Sharp.IconFont.Auto;
            BtnBuscarImpresion.IconSize = 55;
            BtnBuscarImpresion.Location = new Point(1148, 57);
            BtnBuscarImpresion.Name = "BtnBuscarImpresion";
            BtnBuscarImpresion.Size = new Size(149, 65);
            BtnBuscarImpresion.TabIndex = 15;
            BtnBuscarImpresion.Text = "&Buscar";
            BtnBuscarImpresion.TextImageRelation = TextImageRelation.ImageBeforeText;
            BtnBuscarImpresion.UseVisualStyleBackColor = false;
            BtnBuscarImpresion.Click += BtnBuscarImpresion_Click;
            // 
            // textBoxBuscarImpresion
            // 
            textBoxBuscarImpresion.Location = new Point(54, 85);
            textBoxBuscarImpresion.Name = "textBoxBuscarImpresion";
            textBoxBuscarImpresion.Size = new Size(1088, 28);
            textBoxBuscarImpresion.TabIndex = 19;
            textBoxBuscarImpresion.TextChanged += textBoxBuscarImpresion_TextChanged;
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiCondensed", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(98, 9);
            label2.Name = "label2";
            label2.Size = new Size(259, 57);
            label2.TabIndex = 13;
            label2.Text = "Impresiones:";
            // 
            // dataGridViewImpresiones
            // 
            dataGridViewImpresiones.AllowUserToAddRows = false;
            dataGridViewImpresiones.AllowUserToDeleteRows = false;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.ForeColor = Color.Black;
            dataGridViewCellStyle1.Padding = new Padding(0, 5, 0, 0);
            dataGridViewCellStyle1.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewImpresiones.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle1;
            dataGridViewImpresiones.Anchor = AnchorStyles.Top | AnchorStyles.Bottom | AnchorStyles.Left | AnchorStyles.Right;
            dataGridViewImpresiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewImpresiones.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewImpresiones.BorderStyle = BorderStyle.None;
            dataGridViewImpresiones.CellBorderStyle = DataGridViewCellBorderStyle.Raised;
            dataGridViewImpresiones.ColumnHeadersBorderStyle = DataGridViewHeaderBorderStyle.Single;
            dataGridViewCellStyle2.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle2.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle2.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle2.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle2.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle2.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle2.WrapMode = DataGridViewTriState.True;
            dataGridViewImpresiones.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle2;
            dataGridViewImpresiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle3.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle3.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle3.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle3.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle3.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle3.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle3.WrapMode = DataGridViewTriState.False;
            dataGridViewImpresiones.DefaultCellStyle = dataGridViewCellStyle3;
            dataGridViewImpresiones.Location = new Point(28, 146);
            dataGridViewImpresiones.Name = "dataGridViewImpresiones";
            dataGridViewImpresiones.ReadOnly = true;
            dataGridViewCellStyle4.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle4.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle4.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle4.ForeColor = SystemColors.WindowText;
            dataGridViewCellStyle4.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewCellStyle4.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle4.WrapMode = DataGridViewTriState.True;
            dataGridViewImpresiones.RowHeadersDefaultCellStyle = dataGridViewCellStyle4;
            dataGridViewImpresiones.RowHeadersWidth = 51;
            dataGridViewCellStyle5.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle5.ForeColor = Color.Black;
            dataGridViewCellStyle5.SelectionBackColor = Color.FromArgb(128, 128, 255);
            dataGridViewImpresiones.RowsDefaultCellStyle = dataGridViewCellStyle5;
            dataGridViewImpresiones.SelectionMode = DataGridViewSelectionMode.FullRowSelect;
            dataGridViewImpresiones.Size = new Size(1601, 539);
            dataGridViewImpresiones.TabIndex = 12;
            // 
            // iconButtonEditar
            // 
            iconButtonEditar.BackColor = Color.FromArgb(224, 224, 224);
            iconButtonEditar.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButtonEditar.ForeColor = Color.Blue;
            iconButtonEditar.IconChar = FontAwesome.Sharp.IconChar.PenClip;
            iconButtonEditar.IconColor = Color.Blue;
            iconButtonEditar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButtonEditar.Location = new Point(517, 761);
            iconButtonEditar.Name = "iconButtonEditar";
            iconButtonEditar.Size = new Size(201, 60);
            iconButtonEditar.TabIndex = 18;
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
            iconButtonEliminar.Location = new Point(1001, 761);
            iconButtonEliminar.Name = "iconButtonEliminar";
            iconButtonEliminar.Size = new Size(201, 60);
            iconButtonEliminar.TabIndex = 17;
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
            iconButtonAgregar.Location = new Point(66, 761);
            iconButtonAgregar.Name = "iconButtonAgregar";
            iconButtonAgregar.Size = new Size(201, 60);
            iconButtonAgregar.TabIndex = 16;
            iconButtonAgregar.Text = "Agregar";
            iconButtonAgregar.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButtonAgregar.UseVisualStyleBackColor = false;
            iconButtonAgregar.Click += iconButtonAgregar_Click;
            // 
            // ImpresionesView
            // 
            AutoScaleDimensions = new SizeF(8F, 21F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1660, 860);
            Controls.Add(iconButtonEditar);
            Controls.Add(iconButtonEliminar);
            Controls.Add(iconButtonAgregar);
            Controls.Add(BtnBuscarImpresion);
            Controls.Add(textBoxBuscarImpresion);
            Controls.Add(label2);
            Controls.Add(dataGridViewImpresiones);
            Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "ImpresionesView";
            Text = "Impresiones";
            ((System.ComponentModel.ISupportInitialize)dataGridViewImpresiones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private FontAwesome.Sharp.IconButton BtnBuscarImpresion;
        private TextBox textBoxBuscarImpresion;
        private Label label2;
        private DataGridView dataGridViewImpresiones;
        private FontAwesome.Sharp.IconButton iconButtonEditar;
        private FontAwesome.Sharp.IconButton iconButtonEliminar;
        private FontAwesome.Sharp.IconButton iconButtonAgregar;
    }
}