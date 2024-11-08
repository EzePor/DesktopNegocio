namespace DesktopNegocio.Views.Details.ResumenPedidos
{
    partial class DetalleView
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
            dataGridViewProductos = new DataGridView();
            dataGridViewImpresiones = new DataGridView();
            label1 = new Label();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).BeginInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewImpresiones).BeginInit();
            SuspendLayout();
            // 
            // dataGridViewProductos
            // 
            dataGridViewProductos.AllowUserToAddRows = false;
            dataGridViewProductos.AllowUserToDeleteRows = false;
            dataGridViewProductos.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewProductos.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewProductos.BorderStyle = BorderStyle.None;
            dataGridViewProductos.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewProductos.Location = new Point(74, 83);
            dataGridViewProductos.Name = "dataGridViewProductos";
            dataGridViewProductos.ReadOnly = true;
            dataGridViewProductos.RowHeadersWidth = 51;
            dataGridViewProductos.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewProductos.Size = new Size(1156, 355);
            dataGridViewProductos.TabIndex = 0;
            // 
            // dataGridViewImpresiones
            // 
            dataGridViewImpresiones.AllowUserToAddRows = false;
            dataGridViewImpresiones.AllowUserToDeleteRows = false;
            dataGridViewImpresiones.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridViewImpresiones.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridViewImpresiones.BorderStyle = BorderStyle.None;
            dataGridViewImpresiones.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewImpresiones.Location = new Point(74, 444);
            dataGridViewImpresiones.Name = "dataGridViewImpresiones";
            dataGridViewImpresiones.ReadOnly = true;
            dataGridViewImpresiones.RowHeadersWidth = 51;
            dataGridViewImpresiones.SelectionMode = DataGridViewSelectionMode.CellSelect;
            dataGridViewImpresiones.Size = new Size(1156, 355);
            dataGridViewImpresiones.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 28.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(327, 12);
            label1.Name = "label1";
            label1.Size = new Size(605, 57);
            label1.TabIndex = 2;
            label1.Text = "Detalle del pedido seleccionado";
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Silver;
            iconButton1.ForeColor = Color.Red;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.DoorClosed;
            iconButton1.IconColor = Color.Red;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.IconSize = 25;
            iconButton1.Location = new Point(1156, 12);
            iconButton1.Name = "iconButton1";
            iconButton1.Size = new Size(111, 37);
            iconButton1.TabIndex = 3;
            iconButton1.Text = "Cerrar";
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // DetalleView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(128, 128, 255);
            ClientSize = new Size(1300, 820);
            Controls.Add(iconButton1);
            Controls.Add(label1);
            Controls.Add(dataGridViewImpresiones);
            Controls.Add(dataGridViewProductos);
            Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "DetalleView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Detalle";
            ((System.ComponentModel.ISupportInitialize)dataGridViewProductos).EndInit();
            ((System.ComponentModel.ISupportInitialize)dataGridViewImpresiones).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridViewProductos;
        private DataGridView dataGridViewImpresiones;
        private Label label1;
        private FontAwesome.Sharp.IconButton iconButton1;
    }
}