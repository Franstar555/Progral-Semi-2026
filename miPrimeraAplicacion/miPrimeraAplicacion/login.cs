
using System;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class login : Form
    {
        private readonly Conexion conexion = new Conexion();

        public login()
        {
            InitializeComponent();

            txtClaveLogin.UseSystemPasswordChar = true;

            AcceptButton = btnIngresarLogin;
            CancelButton = btnSalirLogin;

            btnIngresarLogin.Click += btnIngresarLogin_Click;
            btnSalirLogin.Click += btnSalirLogin_Click;
        }

        private void btnIngresarLogin_Click(object sender, EventArgs e)
        {
            string usuario = txtUsuarioLogin.Text.Trim();
            string clave = txtClaveLogin.Text;

            if (string.IsNullOrWhiteSpace(usuario) ||
                string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show(
                    "Escribe tu usuario y contraseña.",
                    "Campos obligatorios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return;
            }

            try
            {
                if (conexion.validarLogin(usuario, clave))
                {
                    MessageBox.Show(
                        "Inicio de sesión correcto.",
                        "Bienvenido",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Information);

                    Hide();

                    using (frm_usuario formulario = new frm_usuario())
                    {
                        formulario.ShowDialog();
                    }

                    Close();
                }
                else
                {
                    MessageBox.Show(
                        "Usuario o contraseña incorrectos. Acceso denegado.",
                        "Error de inicio de sesión",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error);

                    txtClaveLogin.Clear();
                    txtClaveLogin.Focus();
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo verificar el acceso a la base de datos.\n" + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
        }

        private void btnSalirLogin_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void login_Load(object sender, EventArgs e)
        {

        }
    }
}
