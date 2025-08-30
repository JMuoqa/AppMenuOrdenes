using System.Drawing;
using System.Runtime.InteropServices;
using Dominio;
namespace ControlDeProyectos
{
    public partial class autenticacion_principal : Form
    {
        public autenticacion_principal()
        {
            InitializeComponent();
        }
        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]
        private extern static void SendMessage(System.IntPtr hwnd, int wmsg, int wparam, int lparam);
        private void AutenticacionPrincipal_Load(object sender, EventArgs e)
        {

        }
        private void entrada_usuario_Enter(object sender, EventArgs e)
        {
            if (entrada_usuario.Text == "USUARIO")
            {
                entrada_usuario.Text = "";
                entrada_usuario.ForeColor = Color.White;
            }
        }
        private void entrada_usuario_Leave(object sender, EventArgs e)
        {
            if (entrada_usuario.Text == "")
            {
                entrada_usuario.Text = "USUARIO";
                entrada_usuario.ForeColor = Color.FromArgb(144, 144, 144);
            }
        }
        private void entrada_pass_Enter(object sender, EventArgs e)
        {
            if (entrada_pass.Text == "CONTRASEÑA")
            {
                entrada_pass.Text = "";
                entrada_pass.ForeColor = Color.White;
                entrada_pass.UseSystemPasswordChar = true;
            }
        }
        private void entrada_pass_Leave(object sender, EventArgs e)
        {
            if (entrada_pass.Text == "")
            {
                entrada_pass.Text = "CONTRASEÑA";
                entrada_pass.ForeColor = Color.FromArgb(144, 144, 144);
                entrada_pass.UseSystemPasswordChar = false;
            }
        }
        private void cerrar_app_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }
        private void minimizar_app_Click(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void autenticacion_principal_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        private void panel_logo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }

        private void boton_confirmar_Click(object sender, EventArgs e)
        {
            IniciarApp();
        }
        private void IniciarApp()
        {
            AutenticarUsuario autenticarUsuario = new AutenticarUsuario();
            string usuario = entrada_usuario.Text;
            string contrasena = entrada_pass.Text;
            bool badnera = ComprobarDatosVacios(usuario, contrasena);
            if (badnera)
            {
                if (autenticarUsuario.IniciarSesion(usuario, contrasena))
                {
                    VistaInicio vista = new VistaInicio();
                    this.Hide();
                    // Suscribimos al evento FormClosed. Agregue esto por que cuando se cerraba la VistaInicio el programa no terminaba
                    vista.FormClosed += (s, args) =>
                    {
                        this.Show(); // Cuando el principal se cierra, mostramos el login otra vez
                    };
                    vista.Show();
                    ResetearTextos();
                    errorProvider1.Clear();
                }
                else
                {
                    errorProvider1.Clear();
                    errorProvider1.SetError(entrada_usuario, "Usuario o contraseña erroneos");
                    errorProvider1.SetError(entrada_pass, "Usuario o contraseña erroneos");
                }
            }
        }
        private bool ComprobarDatosVacios(string usuario, string contrasena)
        {
            errorProvider1.Clear();
            if (string.IsNullOrEmpty(usuario) || usuario == "USUARIO")
            {
                errorProvider1.SetError(entrada_usuario, "El usuario no puede estar vacio");
                return false;
            }
            if (string.IsNullOrEmpty(usuario) || contrasena == "CONTRASEÑA")
            {
                errorProvider1.SetError(entrada_pass, "La contraseña no puede estar vacia");
                return false;
            }
            return true;
        }
        private void ResetearTextos()
        {
            entrada_usuario.Text = "USUARIO";
            entrada_usuario.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_pass.Text = "CONTRASEÑA";
            entrada_pass.ForeColor = Color.FromArgb(144, 144, 144);
            entrada_pass.UseSystemPasswordChar = false;
        }

        private void Entradas_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                IniciarApp();
            }
        }
    }
}
