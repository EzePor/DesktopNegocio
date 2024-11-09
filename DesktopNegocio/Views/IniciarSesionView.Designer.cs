namespace DesktopNegocio.Views
{
    partial class IniciarSesionView
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
            panel1 = new Panel();
            txtUsuario = new TextBox();
            label1 = new Label();
            label2 = new Label();
            label3 = new Label();
            txtContraseña = new TextBox();
            btnIngresar = new FontAwesome.Sharp.IconButton();
            iconButton1 = new FontAwesome.Sharp.IconButton();
            chMostrarContrasena = new CheckBox();
            SuspendLayout();
            // 
            // panel1
            // 
            panel1.BackColor = Color.FromArgb(128, 128, 255);
            panel1.Location = new Point(36, 135);
            panel1.Name = "panel1";
            panel1.Size = new Size(455, 22);
            panel1.TabIndex = 0;
            // 
            // txtUsuario
            // 
            txtUsuario.BorderStyle = BorderStyle.None;
            txtUsuario.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtUsuario.Location = new Point(36, 249);
            txtUsuario.Name = "txtUsuario";
            txtUsuario.PlaceholderText = "Ingreso su usuario";
            txtUsuario.Size = new Size(455, 33);
            txtUsuario.TabIndex = 1;
            // 
            // label1
            // 
            label1.AutoSize = true;
            label1.Font = new Font("Bahnschrift SemiCondensed", 36F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label1.ForeColor = Color.White;
            label1.Location = new Point(100, 29);
            label1.Name = "label1";
            label1.Size = new Size(337, 72);
            label1.TabIndex = 2;
            label1.Text = "Iniciar sesión";
            // 
            // label2
            // 
            label2.AutoSize = true;
            label2.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label2.ForeColor = Color.White;
            label2.Location = new Point(57, 224);
            label2.Name = "label2";
            label2.Size = new Size(74, 22);
            label2.TabIndex = 3;
            label2.Text = "Usuario";
            // 
            // label3
            // 
            label3.AutoSize = true;
            label3.Font = new Font("Bahnschrift SemiLight", 10.8F, FontStyle.Regular, GraphicsUnit.Point, 0);
            label3.ForeColor = Color.White;
            label3.Location = new Point(57, 348);
            label3.Name = "label3";
            label3.Size = new Size(104, 22);
            label3.TabIndex = 5;
            label3.Text = "Contraseña";
            // 
            // txtContraseña
            // 
            txtContraseña.BorderStyle = BorderStyle.None;
            txtContraseña.Font = new Font("Bahnschrift SemiCondensed", 16.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            txtContraseña.Location = new Point(36, 373);
            txtContraseña.Name = "txtContraseña";
            txtContraseña.PasswordChar = '*';
            txtContraseña.PlaceholderText = "Ingreso su contraseña";
            txtContraseña.Size = new Size(455, 33);
            txtContraseña.TabIndex = 4;
            // 
            // btnIngresar
            // 
            btnIngresar.BackColor = Color.DarkOrange;
            btnIngresar.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            btnIngresar.ForeColor = Color.White;
            btnIngresar.IconChar = FontAwesome.Sharp.IconChar.ArrowRightToFile;
            btnIngresar.IconColor = Color.White;
            btnIngresar.IconFont = FontAwesome.Sharp.IconFont.Auto;
            btnIngresar.Location = new Point(36, 493);
            btnIngresar.Name = "btnIngresar";
            btnIngresar.RightToLeft = RightToLeft.No;
            btnIngresar.Size = new Size(455, 71);
            btnIngresar.TabIndex = 6;
            btnIngresar.Text = "Ingresar";
            btnIngresar.TextAlign = ContentAlignment.MiddleRight;
            btnIngresar.TextImageRelation = TextImageRelation.ImageBeforeText;
            btnIngresar.UseVisualStyleBackColor = false;
            btnIngresar.Click += btnIngresar_Click;
            // 
            // iconButton1
            // 
            iconButton1.BackColor = Color.Gray;
            iconButton1.Font = new Font("Bahnschrift", 19.8000011F, FontStyle.Regular, GraphicsUnit.Point, 0);
            iconButton1.ForeColor = Color.White;
            iconButton1.IconChar = FontAwesome.Sharp.IconChar.ArrowAltCircleLeft;
            iconButton1.IconColor = Color.White;
            iconButton1.IconFont = FontAwesome.Sharp.IconFont.Auto;
            iconButton1.Location = new Point(36, 611);
            iconButton1.Name = "iconButton1";
            iconButton1.RightToLeft = RightToLeft.No;
            iconButton1.Size = new Size(455, 53);
            iconButton1.TabIndex = 7;
            iconButton1.Text = "Cancelar";
            iconButton1.TextAlign = ContentAlignment.MiddleRight;
            iconButton1.TextImageRelation = TextImageRelation.ImageBeforeText;
            iconButton1.UseVisualStyleBackColor = false;
            iconButton1.Click += iconButton1_Click;
            // 
            // chMostrarContrasena
            // 
            chMostrarContrasena.AutoSize = true;
            chMostrarContrasena.Font = new Font("Bahnschrift SemiCondensed", 10.2F, FontStyle.Regular, GraphicsUnit.Point, 0);
            chMostrarContrasena.ForeColor = Color.White;
            chMostrarContrasena.Location = new Point(35, 424);
            chMostrarContrasena.Name = "chMostrarContrasena";
            chMostrarContrasena.Size = new Size(160, 25);
            chMostrarContrasena.TabIndex = 8;
            chMostrarContrasena.Text = "Mostrar contraseña";
            chMostrarContrasena.UseVisualStyleBackColor = true;
            chMostrarContrasena.CheckedChanged += chMostrarContrasena_CheckedChanged;
            // 
            // IniciarSesionView
            // 
            AutoScaleDimensions = new SizeF(8F, 20F);
            AutoScaleMode = AutoScaleMode.Font;
            BackColor = Color.FromArgb(64, 64, 64);
            ClientSize = new Size(532, 700);
            Controls.Add(chMostrarContrasena);
            Controls.Add(iconButton1);
            Controls.Add(btnIngresar);
            Controls.Add(label3);
            Controls.Add(txtContraseña);
            Controls.Add(label2);
            Controls.Add(label1);
            Controls.Add(txtUsuario);
            Controls.Add(panel1);
            FormBorderStyle = FormBorderStyle.None;
            Name = "IniciarSesionView";
            StartPosition = FormStartPosition.CenterScreen;
            Text = "Iniciar Sesión";
            ResumeLayout(false);
            PerformLayout();
        }

        #endregion

        private Panel panel1;
        private TextBox txtUsuario;
        private Label label1;
        private Label label2;
        private Label label3;
        private TextBox txtContraseña;
        private FontAwesome.Sharp.IconButton btnIngresar;
        private FontAwesome.Sharp.IconButton iconButton1;
        private CheckBox chMostrarContrasena;
    }
}