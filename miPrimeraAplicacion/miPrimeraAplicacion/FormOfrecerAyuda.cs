
using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using System.Data.SqlClient;

namespace miPrimeraAplicacion
{
    public partial class FormOfrecerAyuda : Form
    {
        private Button btnPublicar;
        private ComboBox cboCategoria;
        private DataGridView dgvOfertas;
        private Label lblTitulo;

        private readonly Conexion conexion = new Conexion();

        public FormOfrecerAyuda()
        {
            InitializeComponent();
            CrearInterfaz();
            CargarCategorias();
            CargarOfertas();
        }

        private void CrearInterfaz()
        {
            Text = "Comunidad Conecta - Ofrecer ayuda";
            Size = new Size(1050, 650);
            StartPosition = FormStartPosition.CenterScreen;
            BackColor = Color.White;

            lblTitulo = new Label
            {
                Text = "Ofrecer ayuda",
                Font = new Font("Segoe UI", 22, FontStyle.Bold),
                Location = new Point(30, 20),
                AutoSize = true
            };

            Label lblDescripcion = new Label
            {
                Text = "Comparte lo que puedas ofrecer para ayudar a tu comunidad.",
                Location = new Point(33, 68),
                AutoSize = true,
                Font = new Font("Segoe UI", 10)
            };

            btnPublicar = new Button
            {
                Text = "+ Publicar nueva ayuda",
                Location = new Point(30, 105),
                Size = new Size(350, 42),
                BackColor = Color.FromArgb(120, 195, 218),
                ForeColor = Color.Black,
                FlatStyle = FlatStyle.Flat,
                Font = new Font("Segoe UI", 10, FontStyle.Bold)
            };

            btnPublicar.Click += BtnPublicar_Click;

            cboCategoria = new ComboBox
            {
                Location = new Point(30, 165),
                Size = new Size(250, 32),
                DropDownStyle = ComboBoxStyle.DropDownList,
                Font = new Font("Segoe UI", 10)
            };

            dgvOfertas = new DataGridView
            {
                Location = new Point(30, 215),
                Size = new Size(960, 360),
                ReadOnly = true,
                AllowUserToAddRows = false,
                AutoSizeColumnsMode =
                    DataGridViewAutoSizeColumnsMode.Fill,
                SelectionMode =
                    DataGridViewSelectionMode.FullRowSelect,
                MultiSelect = false,
                RowHeadersVisible = false,
                BackgroundColor = Color.White,
                BorderStyle = BorderStyle.FixedSingle
            };

            Controls.Add(lblTitulo);
            Controls.Add(lblDescripcion);
            Controls.Add(btnPublicar);
            Controls.Add(cboCategoria);
            Controls.Add(dgvOfertas);
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

                        DataRow todos = tabla.NewRow();
                        todos["id_categoria"] = 0;
                        todos["nombre"] = "Todos";
                        tabla.Rows.InsertAt(todos, 0);

                        cboCategoria.DisplayMember = "nombre";
                        cboCategoria.ValueMember = "id_categoria";
                        cboCategoria.DataSource = tabla;
                    }
                }

                cboCategoria.SelectedIndexChanged +=
                    (s, e) => CargarOfertas();
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las categorías:\n" + ex.Message);
            }
        }

        private void CargarOfertas()
        {
            try
            {
                using (SqlConnection cn = conexion.AbrirConexion())
                {
                    string sql = @"
                        SELECT
                            O.titulo AS Titulo,
                            O.descripcion AS Descripcion,
                            C.nombre AS Categoria,
                            U.direccion AS Ubicacion,
                            O.fecha_publicacion AS Fecha,
                            O.estado AS Estado
                        FROM OFERTAS_AYUDA O
                        INNER JOIN CATEGORIAS C
                            ON O.id_categoria = C.id_categoria
                        LEFT JOIN UBICACIONES U
                            ON O.id_ubicacion = U.id_ubicacion
                        WHERE
                            (@categoria = 0
                            OR O.id_categoria = @categoria)
                        ORDER BY O.fecha_publicacion DESC";

                    using (SqlCommand cmd = new SqlCommand(sql, cn))
                    {
                        int categoria = cboCategoria.SelectedValue == null
                            ? 0
                            : Convert.ToInt32(cboCategoria.SelectedValue);

                        cmd.Parameters.Add("@categoria",
                            SqlDbType.Int).Value = categoria;

                        using (SqlDataAdapter da =
                            new SqlDataAdapter(cmd))
                        {
                            DataTable tabla = new DataTable();
                            da.Fill(tabla);
                            dgvOfertas.DataSource = tabla;
                        }
                    }

                    if (dgvOfertas.Columns["Fecha"] != null)
                    {
                        dgvOfertas.Columns["Fecha"]
                            .DefaultCellStyle.Format = "dd/MM/yyyy HH:mm";
                    }
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(
                    "Error al cargar las ofertas:\n" + ex.Message);
            }
        }

        private void BtnPublicar_Click(object sender, EventArgs e)
        {
            using (FormPublicarAyuda frm = new FormPublicarAyuda())
            {
                if (frm.ShowDialog() == DialogResult.OK)
                {
                    CargarOfertas();
                }
            }
        }

        private void FormOfrecerAyuda_Load(object sender, EventArgs e)
        {

        }
    }
}
