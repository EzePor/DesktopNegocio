using Firebase.Auth.Providers;
using Firebase.Auth;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Drawing.Drawing2D;

namespace DesktopNegocio.Views
{
    public partial class IniciarSesionView : Form
    {
        FirebaseAuthClient firebaseAuthClient;
        public bool loginSuccessfull { get; set; } = false;
        public IniciarSesionView()
        {
            InitializeComponent();

            // Configurar estilo del formulario
            FormBorderStyle = FormBorderStyle.None;
            BackColor = Color.Gray; // Color de fondo para hacer contraste con el borde
            Padding = new Padding(2); // Espacio para el borde blanco

            ConfiguracionFirebase();
        }

        private void ConfiguracionFirebase()
        {
            // Configure...
            var config = new FirebaseAuthConfig
            {
                ApiKey = "AIzaSyA_UONSAAM8OrTELLhXIL8DmyW-DNi45Ho",
                AuthDomain = "gestionnegocio-f17f0.firebaseapp.com",
                Providers = new FirebaseAuthProvider[]
                {
                    // Add and configure individual providers
                    new EmailProvider()
                    // ...
                },

            };

            // ...and create your FirebaseAuthClient
            firebaseAuthClient = new FirebaseAuthClient(config);
        }

        private async void btnIngresar_Click(object sender, EventArgs e)
        {
            try
            {
                var user = await firebaseAuthClient.SignInWithEmailAndPasswordAsync(txtUsuario.Text, txtContraseña.Text);
                if (user != null)
                {
                    loginSuccessfull = true;
                    this.DialogResult = DialogResult.OK; // Indica que se inició sesión con éxito
                    this.Close();
                }
            }
            catch (Exception)
            {
                MessageBox.Show("Email o password incorrecto, intentelo nuevamente");
            }
        }

        private void chMostrarContrasena_CheckedChanged(object sender, EventArgs e)
        {
            txtContraseña.PasswordChar = chMostrarContrasena.Checked ? '\0' : '*';
        }

        private void iconButton1_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        // Evento Paint para dibujar el borde redondeado
        protected override void OnPaint(PaintEventArgs e)
        {
            base.OnPaint(e);

            int borderRadius = 20;  // Radio de redondeo de esquinas
            int borderSize = 4;     // Grosor del borde

            using (GraphicsPath path = new GraphicsPath())
            {
                // Crear un borde con esquinas redondeadas
                path.AddArc(0, 0, borderRadius, borderRadius, 180, 90);
                path.AddArc(Width - borderRadius - 1, 0, borderRadius, borderRadius, 270, 90);
                path.AddArc(Width - borderRadius - 1, Height - borderRadius - 1, borderRadius, borderRadius, 0, 90);
                path.AddArc(0, Height - borderRadius - 1, borderRadius, borderRadius, 90, 90);
                path.CloseFigure();

                // Dibujar el borde
                e.Graphics.SmoothingMode = SmoothingMode.AntiAlias;
                using (Pen pen = new Pen(Color.White, borderSize))
                {
                    e.Graphics.DrawPath(pen, path);
                }
            }
        }
    }
}
