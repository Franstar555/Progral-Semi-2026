
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace miPrimeraAplicacion
{
    public partial class FormPublicarAyuda : Form
    {
        private TextBox txtTitulo;
        private TextBox txtDescripcion;
        private ComboBox cboCategoria;
        private TextBox txtUbicacion;
        private Button btnPublicar;
        private Button btnCancelar;

        private readonly Conexion conexion = new Conexion();

        public FormPublicarAyuda()
        {
            InitializeComponent();
            CrearInterfaz();
            CargarCategorias();
        }

        private void CrearInterfaz()
        {
            Text = "Publica tu ayuda";
            Size = new Size(650, 560);
            StartPosition = FormStartPosition.CenterParent;
            FormBorderStyle = FormBorderStyle.FixedDialog;
            MaximizeBox = false;
            BackColor = Color.White;

            Label lblTituloPrincipal = new Label
            {
                Text = "Publica tu ayuda",
                Font = new Font("Segoe UI", 21, FontStyle.Bold),
                Location = new Point(30, 20),
                AutoSize = true
            };

            Label lblTitulo = new Label
            {
                Text = "Título",
                Location = new Point(35, 80),
                AutoSize = true
            };

            txtTitulo = new TextBox
            {
                Location = new Point(35, 103),
                Size = new Size(560, 30),
                Font = new Font("Segoe UI", 10),
                MaxLength = 100
            };

            Label lblDescripcion = new Label
            {
                Text = "Descripción",
                Location = new Point(35, 145),
                AutoSize = true
            };

            txtDescripcion = new TextBox
            {
                Location = new Point(35, 168),
                Size = new Size(560, 85),
                Multiline = true,
                ScrollBars = ScrollBars.Vertical,
                MaxLength = 500,
                Font = new Font("Segoe UI", 10)
            };

            Label lblCategoria = new Label
            {
                Text = "Categoría",
                Location = new Point(35, 265),
                AutoSize = true
            };

            cboCategoria = new ComboBox
            {
                Location = new Point(35, 288),
                Size = new Size(560, 30),
                DropDownStyle = ComboBoxStyle.DropDownList
            };

            Label lblUbicacion = new Label
            {
                Text = "Ubicación (opcional)",
                Location = new Point(35, 330),
                AutoSize = true
            };

            txtUbicacion = new TextBox
            {
                Location = new Point(35, 353),
                Size = new Size(560, 30),
                MaxLength = 150,
                Font = new Font("Segoe UI", 10)
            };

            btnPublicar = new Button
            {
                Text = "Publicar",
                Location = new Point(35, 415),
                Size = new Size(270, 42),
                BackColor = Color.FromArgb(42, 126, 225),
                ForeColor = Color.White,
                FlatStyle = FlatStyle.Flat
            };

            btnCancelar = new Button
            {
                Text = "Cancelar",
                Location = new Point(325, 415),
                Size = new Size(270, 42)
            };

            btnPublicar.Click += BtnPublicar_Click;
            btnCancelar.Click += (s, e) =>
            {
                DialogResult = DialogResult.Cancel;
                Close();
            };

            Controls.AddRange(new Control[]
            {
                lblTituloPrincipal,
                lblTitulo,
                txtTitulo,
                lblDescripcion,
                txtDescripcion,
                lblCategoria,
                cboCategoria,
                lblUbicacion,
                txtUbicacion,
                btnPublicar,
                btnCancelar
            });
        }

        private void CargarCategorias()
        {
            try
            {
                using (SqlConnection cn = conexion.AbrirConexion())
                {
                    string sql = @"
                        SELECT id_categoria, nombre
                        FROM CATEGORIAS
                        WHERE estado = 1
                        ORDER BY nombre";

                    using (SqlDataAdapter da =
                        new SqlDataAdapter(sql, cn))
                    {
                        DataTable tabla = new DataTable();
                        da.Fill(tabla);

                        cboCategoria.DisplayMember = "nombre";
                        cboCategoria.ValueMember = "id_categoria";
                        cboCategoria.DataSource = tabla;
                        cboCategoria.SelectedIndex = -1;
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las categorías:\n" + ex.Message);
            }
        }

        private void BtnPublicar_Click(object sender, EventArgs e)
        {
            string titulo = txtTitulo.Text.Trim();
            string descripcion = txtDescripcion.Text.Trim();
            string ubicacion = txtUbicacion.Text.Trim();

            if (titulo == "" || descripcion == "" ||
                cboCategoria.SelectedIndex < 0)
            {
                MessageBox.Show(
                    "Completa el título, la descripción y la categoría.",
                    "Campos obligatorios",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Warning);
                return;
            }

            btnPublicar.Enabled = false;

            try
            {
                using (SqlConnection cn = conexion.AbrirConexion())
                using (SqlTransaction transaccion = cn.BeginTransaction())
                {
                    try
                    {
                        int? idUbicacion = null;

                        if (ubicacion != "")
                        {
                            string sqlUbicacion = @"
                                INSERT INTO UBICACIONES
                                    (direccion, departamento)
                                OUTPUT INSERTED.id_ubicacion
                                VALUES (@direccion, NULL)";

                            using (SqlCommand cmdUbicacion =
                                new SqlCommand(
                                    sqlUbicacion, cn, transaccion))
                            {
                                cmdUbicacion.Parameters.Add(
                                    "@direccion",
                                    SqlDbType.VarChar, 150).Value = ubicacion;

                                idUbicacion = Convert.ToInt32(
                                    cmdUbicacion.ExecuteScalar());
                            }
                        }

                        string sql = @"
                            INSERT INTO OFERTAS_AYUDA
                            (
                                id_usuario,
                                id_categoria,
                                id_ubicacion,
                                titulo,
                                descripcion
                            )
                            VALUES
                            (
                                @usuario,
                                @categoria,
                                @ubicacion,
                                @titulo,
                                @descripcion
                            )";

                        using (SqlCommand cmd =
                            new SqlCommand(sql, cn, transaccion))
                        {
                            // Usuario de prueba: Carlos Pérez.
                            // Después lo conectaremos al inicio de sesión.
                            cmd.Parameters.Add("@usuario",
                                SqlDbType.Int).Value = 1;

                            cmd.Parameters.Add("@categoria",
                                SqlDbType.Int).Value =
                                Convert.ToInt32(cboCategoria.SelectedValue);

                            cmd.Parameters.Add("@ubicacion",
                                SqlDbType.Int).Value =
                                idUbicacion.HasValue
                                    ? (object)idUbicacion.Value
                                    : DBNull.Value;

                            cmd.Parameters.Add("@titulo",
                                SqlDbType.VarChar, 100).Value = titulo;

                            cmd.Parameters.Add("@descripcion",
                                SqlDbType.VarChar, 500).Value = descripcion;

                            cmd.ExecuteNonQuery();
                        }

                        transaccion.Commit();
                    }
                    catch
                    {
                        transaccion.Rollback();
                        throw;
                    }
                }

                MessageBox.Show(
                    "¡Tu ayuda se publicó correctamente!",
                    "Comunidad Conecta",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Information);

                DialogResult = DialogResult.OK;
                Close();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "No se pudo publicar la ayuda:\n" + ex.Message,
                    "Error",
                    MessageBoxButtons.OK,
                    MessageBoxIcon.Error);
            }
            finally
            {
                btnPublicar.Enabled = true;
            }
        }

        private void FormPublicarAyuda_Load(object sender, EventArgs e)
        {

        }
    }
}
