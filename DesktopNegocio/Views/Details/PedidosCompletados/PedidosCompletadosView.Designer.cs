namespace DesktopNegocio.Views.Details.PedidosCompletados
{
    partial class PedidosCompletadosView
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
            dataGridPedidosCompletados = new DataGridView();
            label1 = new Label();
            ((System.ComponentModel.ISupportInitialize)dataGridPedidosCompletados).BeginInit();
            SuspendLayout();
            // 
            // dataGridPedidosCompletados
            // 
            dataGridPedidosCompletados.AllowUserToAddRows = false;
            dataGridPedidosCompletados.AllowUserToDeleteRows = false;
            dataGridPedidosCompletados.AutoSizeColumnsMode = DataGridViewAutoSizeColumnsMode.Fill;
            dataGridPedidosCompletados.BackgroundColor = Color.FromArgb(192, 192, 255);
            dataGridPedidosCompletados.ColumnHeadersHeightSizeMode = DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            dataGridViewCellStyle1.Alignment = DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle1.BackColor = Color.FromArgb(192, 192, 255);
            dataGridViewCellStyle1.Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            dataGridViewCellStyle1.ForeColor = SystemColors.ControlText;
            dataGridViewCellStyle1.SelectionBackColor = SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = DataGridViewTriState.False;
            dataGridPedidosCompletados.DefaultCellStyle = dataGridViewCellStyle1;
            dataGridPedidosCompletados.Location = new Point(37, 96);
            dataGridPedidosCompletados.Name = "dataGridPedidosCompletados";
            dataGridPedidosCompletados.ReadOnly = true;
            dataGridPedidosCompletados.RowHeadersWidth = 51;
            dataGridPedidosCompletados.Size = new Size(1593, 739);
            dataGridPedidosCompletados.TabIndex = 0;
            dataGridPedidosCompletados.CellContentClick += dataGridPedidosCompletados_CellContentClick;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiBold Condensed", 28.2F, FontStyle.Bold, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(381, 23);
            label1.Name = "label1";
            label1.Size = new Size(353, 57);
            label1.TabIndex = 1;
            label1.Text = "Pedidos Completados";
            // 
            // PedidosCompletadosView
            // 
            AutoScaleDimensions = new SizeF(9F, 22F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(1660, 860);
            Controls.Add(label1);
            Controls.Add(dataGridPedidosCompletados);
            Font = new Font("Bahnschrift SemiCondensed", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            FormBorderStyle = FormBorderStyle.None;
            Name = "PedidosCompletadosView";
            Text = "Pedidos Completados";
            ((System.ComponentModel.ISupportInitialize)dataGridPedidosCompletados).EndInit();
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private DataGridView dataGridPedidosCompletados;
        private Label label1;
    }
}