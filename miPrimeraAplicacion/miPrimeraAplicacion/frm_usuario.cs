
using System;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Windows.Forms;

namespace miPrimeraAplicacion
{
    public partial class frm_usuario : Form
    {
        private readonly Conexion objConexion = new Conexion();
        private DataSet objDs = new DataSet();
        private DataTable objDt = new DataTable();

        public int posicion = 0;
        public string accion = "nuevo";

        public frm_usuario()
        {
            InitializeComponent();
        }

        private void frm_usuario_Load(object sender, EventArgs e)
        {
            txtIdUsuario.ReadOnly = true;
            txtClaveUsuario.UseSystemPasswordChar = true;

            actualizarDs();
            estadoControles(false);
        }


        private void actualizarDs()
        {
            try
            {
                objDs = objConexion.obtenerDatos();

                objDt = objDs.Tables["usuarios_usss148726"];

                if (objDt == null)
                {
                    MessageBox.Show(
                        "No se encontró la tabla usuarios_usss148726.",
                        "Error",
                        MessageBoxButtons.OK,
                        MessageBoxIcon.Error
                    );
                    return;
                }

                objDt.PrimaryKey = new DataColumn[]
                {
            objDt.Columns["idUsuario"]
                };

                if (objDt.Rows.Count == 0)
                    posicion = 0;
                else if (posicion >= objDt.Rows.Count)
                    posicion = objDt.Rows.Count - 1;

                mostrarDatos();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar los usuarios:\n" + ex.Message,
                    "Error de conexión",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error
                );
            }
        }


        private void mostrarDatos()
        {
            if (objDt.Rows.Count > 0 &&
                posicion >= 0 &&
                posicion < objDt.Rows.Count)
            {
                DataRow fila = objDt.Rows[posicion];

                txtIdUsuario.Text = fila["idUsuario"].ToString();
                txtUsuario.Text = fila["usuario"].ToString();
                txtClaveUsuario.Text = fila["clave"].ToString();
                txtNombreUsuario.Text = fila["nombre"].ToString();
                txtDireccionUsuario.Text = fila["direccion"].ToString();
                txtTelefonoUsuario.Text = fila["telefono"].ToString();

                lblnRegistrosUsuario.Text =
                    (posicion + 1) + " de " + objDt.Rows.Count;
            }
            else
            {
                limpiarControles();
                lblnRegistrosUsuario.Text = "0 de 0";
            }
        }

        private void limpiarControles()
        {
            txtIdUsuario.Clear();
            txtUsuario.Clear();
            txtClaveUsuario.Clear();
            txtNombreUsuario.Clear();
            txtDireccionUsuario.Clear();
            txtTelefonoUsuario.Clear();
        }

        private void estadoControles(bool editar)
        {
            grbDatosUsuario.Enabled = editar;
            grbNavegacionUsuario.Enabled = !editar;

            btnEliminarUsuario.Enabled =
                !editar && objDt.Rows.Count > 0;

            txtIdUsuario.ReadOnly = true;
        }

        private bool validarDatos()
        {
            string usuario = txtUsuario.Text.Trim();
            string clave = txtClaveUsuario.Text;

            if (usuario.Length < 6 || usuario.Length > 16)
            {
                MessageBox.Show(
                    "El usuario debe tener entre 6 y 16 caracteres.",
                    "Validación de usuario",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(clave))
            {
                MessageBox.Show(
                    "Debes escribir una contraseña.",
                    "Validación de contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtClaveUsuario.Focus();
                return false;
            }

            bool tieneLetras = clave.Any(char.IsLetter);
            bool tieneNumeros = clave.Any(char.IsDigit);

            if (!tieneLetras || !tieneNumeros)
            {
                MessageBox.Show(
                    "La contraseña debe contener al menos una letra y un número.",
                    "Validación de contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtClaveUsuario.Focus();
                return false;
            }

            if (clave.Length > 35)
            {
                MessageBox.Show(
                    "La contraseña no puede superar los 35 caracteres.",
                    "Validación de contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtClaveUsuario.Focus();
                return false;
            }

            if (txtNombreUsuario.Text.Length > 65 ||
                txtDireccionUsuario.Text.Length > 85 ||
                txtTelefonoUsuario.Text.Length > 9)
            {
                MessageBox.Show(
                    "Revisa los límites de longitud: nombre 65, dirección 85 y teléfono 9 caracteres.",
                    "Validación de datos",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                return false;
            }

            if (string.IsNullOrWhiteSpace(txtNombreUsuario.Text))
            {
                MessageBox.Show("Escribe el nombre del usuario.");
                txtNombreUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtDireccionUsuario.Text))
            {
                MessageBox.Show("Escribe la dirección del usuario.");
                txtDireccionUsuario.Focus();
                return false;
            }

            if (string.IsNullOrWhiteSpace(txtTelefonoUsuario.Text))
            {
                MessageBox.Show("Escribe el teléfono del usuario.");
                txtTelefonoUsuario.Focus();
                return false;
            }

            return true;
        }

        private string solicitarConfirmacionClave()
        {
            using (Form formulario = new Form())
            using (Label etiqueta = new Label())
            using (TextBox txtConfirmacion = new TextBox())
            using (Button btnAceptar = new Button())
            using (Button btnCancelar = new Button())
            {
                formulario.Text = "Confirmar contraseña";
                formulario.StartPosition = FormStartPosition.CenterParent;
                formulario.FormBorderStyle = FormBorderStyle.FixedDialog;
                formulario.ClientSize = new Size(360, 135);
                formulario.MaximizeBox = false;
                formulario.MinimizeBox = false;
                formulario.ShowInTaskbar = false;

                etiqueta.Text = "Escribe nuevamente la contraseña:";
                etiqueta.AutoSize = true;
                etiqueta.Location = new Point(15, 15);

                txtConfirmacion.Location = new Point(18, 42);
                txtConfirmacion.Size = new Size(320, 25);
                txtConfirmacion.UseSystemPasswordChar = true;

                btnAceptar.Text = "Confirmar";
                btnAceptar.Location = new Point(75, 82);
                btnAceptar.DialogResult = DialogResult.OK;

                btnCancelar.Text = "Cancelar";
                btnCancelar.Location = new Point(190, 82);
                btnCancelar.DialogResult = DialogResult.Cancel;

                formulario.Controls.Add(etiqueta);
                formulario.Controls.Add(txtConfirmacion);
                formulario.Controls.Add(btnAceptar);
                formulario.Controls.Add(btnCancelar);

                formulario.AcceptButton = btnAceptar;
                formulario.CancelButton = btnCancelar;

                if (formulario.ShowDialog(this) == DialogResult.OK)
                    return txtConfirmacion.Text;

                return null;
            }
        }

        private void btnPrimeroUsuario_Click(object sender, EventArgs e)
        {
            if (objDt.Rows.Count > 0)
            {
                posicion = 0;
                mostrarDatos();
            }
        }

        private void btnAnteriorUsuario_Click(object sender, EventArgs e)
        {
            if (posicion > 0)
            {
                posicion--;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ya estás en el primer registro.");
            }
        }

        private void btnSiguienteUsuario_Click(object sender, EventArgs e)
        {
            if (posicion < objDt.Rows.Count - 1)
            {
                posicion++;
                mostrarDatos();
            }
            else
            {
                MessageBox.Show("Ya estás en el último registro.");
            }
        }

        private void btnUltimoUsuario_Click(object sender, EventArgs e)
        {
            if (objDt.Rows.Count > 0)
            {
                posicion = objDt.Rows.Count - 1;
                mostrarDatos();
            }
        }

        private void btnAgregarUsuario_Click(object sender, EventArgs e)
        {
            if (btnAgregarUsuario.Text == "Nuevo")
            {
                accion = "nuevo";
                limpiarControles();
                estadoControles(true);

                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";

                txtUsuario.Focus();
                return;
            }

            if (!validarDatos())
                return;

            string confirmacion = solicitarConfirmacionClave();

            if (confirmacion == null)
                return;

            if (txtClaveUsuario.Text != confirmacion)
            {
                MessageBox.Show(
                    "Las contraseñas no coinciden. No se guardó el registro.",
                    "Confirmación de contraseña",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);

                txtClaveUsuario.Focus();
                return;
            }

            string[] datos =
            {
                "",
                txtUsuario.Text.Trim(),
                txtClaveUsuario.Text,
                txtNombreUsuario.Text.Trim(),
                txtDireccionUsuario.Text.Trim(),
                txtTelefonoUsuario.Text.Trim()
            };

            string respuesta =
                objConexion.administrarDatosUsuarios(datos, accion);

            if (respuesta != "1")
            {
                MessageBox.Show(
                    respuesta,
                    "Error al guardar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("Usuario guardado correctamente.");

            posicion = int.MaxValue;
            btnAgregarUsuario.Text = "Nuevo";
            btnModificarUsuario.Text = "Modificar";

            actualizarDs();
            estadoControles(false);
        }

        private void btnModificarUsuario_Click(object sender, EventArgs e)
        {
            if (btnModificarUsuario.Text == "Modificar")
            {
                if (objDt.Rows.Count == 0)
                {
                    MessageBox.Show("No hay usuarios para modificar.");
                    return;
                }

                accion = "modificar";
                estadoControles(true);

                btnAgregarUsuario.Text = "Guardar";
                btnModificarUsuario.Text = "Cancelar";

                txtUsuario.Focus();
            }
            else
            {
                mostrarDatos();

                btnAgregarUsuario.Text = "Nuevo";
                btnModificarUsuario.Text = "Modificar";

                estadoControles(false);
            }
        }

        private void btnEliminarUsuario_Click(object sender, EventArgs e)
        {
            if (objDt.Rows.Count == 0)
                return;

            DialogResult confirmacion = MessageBox.Show(
                "¿Estás seguro de eliminar al usuario " +
                txtUsuario.Text + "?",
                "Eliminar usuario",
                MessageBoxButtons.YesNo,
                MessageBoxIcon.Question);

            if (confirmacion != DialogResult.Yes)
                return;

            string[] datos =
            {
                txtIdUsuario.Text,
                "",
                "",
                "",
                "",
                ""
            };

            string respuesta =
                objConexion.administrarDatosUsuarios(datos, "eliminar");

            if (respuesta != "1")
            {
                MessageBox.Show(
                    respuesta,
                    "Error al eliminar",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);

                return;
            }

            MessageBox.Show("Usuario eliminado correctamente.");

            if (posicion > 0)
                posicion--;

            actualizarDs();
            estadoControles(false);
        }

       
    }
}
