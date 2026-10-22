
namespace miPrimeraAplicacion
{
    partial class frm_usuario
    {
        private System.ComponentModel.IContainer components = null;

        protected override void Dispose(bool disposing)
        {
            if (disposing && components != null)
                components.Dispose();

            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        private void InitializeComponent()
        {
            this.grbDatosUsuario = new System.Windows.Forms.GroupBox();
            this.txtIdUsuario = new System.Windows.Forms.TextBox();
            this.txtClaveUsuario = new System.Windows.Forms.TextBox();
            this.txtNombreUsuario = new System.Windows.Forms.TextBox();
            this.txtDireccionUsuario = new System.Windows.Forms.TextBox();
            this.txtTelefonoUsuario = new System.Windows.Forms.TextBox();
            this.lblIdUsuario = new System.Windows.Forms.Label();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClaveUsuario = new System.Windows.Forms.Label();
            this.lblNombreUsuario = new System.Windows.Forms.Label();
            this.lblDireccionUsuario = new System.Windows.Forms.Label();
            this.lblTelefonoUsuario = new System.Windows.Forms.Label();
            this.grbNavegacionUsuario = new System.Windows.Forms.GroupBox();
            this.btnPrimeroUsuario = new System.Windows.Forms.Button();
            this.btnAnteriorUsuario = new System.Windows.Forms.Button();
            this.btnSiguienteUsuario = new System.Windows.Forms.Button();
            this.btnUltimoUsuario = new System.Windows.Forms.Button();
            this.lblnRegistrosUsuario = new System.Windows.Forms.Label();
            this.grbEdicionUsuario = new System.Windows.Forms.GroupBox();
            this.btnAgregarUsuario = new System.Windows.Forms.Button();
            this.btnModificarUsuario = new System.Windows.Forms.Button();
            this.btnEliminarUsuario = new System.Windows.Forms.Button();
            this.txtUsuario = new System.Windows.Forms.TextBox();
            this.grbDatosUsuario.SuspendLayout();
            this.grbNavegacionUsuario.SuspendLayout();
            this.grbEdicionUsuario.SuspendLayout();
            this.SuspendLayout();
            // 
            // grbDatosUsuario
            // 
            this.grbDatosUsuario.Controls.Add(this.txtIdUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtClaveUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtNombreUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtDireccionUsuario);
            this.grbDatosUsuario.Controls.Add(this.txtTelefonoUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblIdUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblClaveUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblNombreUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblDireccionUsuario);
            this.grbDatosUsuario.Controls.Add(this.lblTelefonoUsuario);
            this.grbDatosUsuario.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.grbDatosUsuario.Location = new System.Drawing.Point(130, 25);
            this.grbDatosUsuario.Name = "grbDatosUsuario";
            this.grbDatosUsuario.Size = new System.Drawing.Size(800, 490);
            this.grbDatosUsuario.TabIndex = 0;
            this.grbDatosUsuario.TabStop = false;
            this.grbDatosUsuario.Text = "Datos";
            // 
            // txtIdUsuario
            // 
            this.txtIdUsuario.Location = new System.Drawing.Point(150, 42);
            this.txtIdUsuario.Name = "txtIdUsuario";
            this.txtIdUsuario.ReadOnly = true;
            this.txtIdUsuario.Size = new System.Drawing.Size(240, 40);
            this.txtIdUsuario.TabIndex = 1;
            // 
            // txtClaveUsuario
            // 
            this.txtClaveUsuario.Location = new System.Drawing.Point(150, 152);
            this.txtClaveUsuario.MaxLength = 35;
            this.txtClaveUsuario.Name = "txtClaveUsuario";
            this.txtClaveUsuario.Size = new System.Drawing.Size(500, 40);
            this.txtClaveUsuario.TabIndex = 5;
            this.txtClaveUsuario.UseSystemPasswordChar = true;
            // 
            // txtNombreUsuario
            // 
            this.txtNombreUsuario.Location = new System.Drawing.Point(150, 207);
            this.txtNombreUsuario.MaxLength = 65;
            this.txtNombreUsuario.Name = "txtNombreUsuario";
            this.txtNombreUsuario.Size = new System.Drawing.Size(600, 40);
            this.txtNombreUsuario.TabIndex = 7;
            // 
            // txtDireccionUsuario
            // 
            this.txtDireccionUsuario.Location = new System.Drawing.Point(150, 262);
            this.txtDireccionUsuario.MaxLength = 85;
            this.txtDireccionUsuario.Multiline = true;
            this.txtDireccionUsuario.Name = "txtDireccionUsuario";
            this.txtDireccionUsuario.ScrollBars = System.Windows.Forms.ScrollBars.Vertical;
            this.txtDireccionUsuario.Size = new System.Drawing.Size(600, 105);
            this.txtDireccionUsuario.TabIndex = 9;
            // 
            // txtTelefonoUsuario
            // 
            this.txtTelefonoUsuario.Location = new System.Drawing.Point(150, 397);
            this.txtTelefonoUsuario.MaxLength = 9;
            this.txtTelefonoUsuario.Name = "txtTelefonoUsuario";
            this.txtTelefonoUsuario.Size = new System.Drawing.Size(240, 40);
            this.txtTelefonoUsuario.TabIndex = 11;
            // 
            // lblIdUsuario
            // 
            this.lblIdUsuario.AutoSize = true;
            this.lblIdUsuario.Location = new System.Drawing.Point(25, 45);
            this.lblIdUsuario.Name = "lblIdUsuario";
            this.lblIdUsuario.Size = new System.Drawing.Size(53, 32);
            this.lblIdUsuario.TabIndex = 0;
            this.lblIdUsuario.Text = "ID:";
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Location = new System.Drawing.Point(25, 100);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(118, 32);
            this.lblUsuario.TabIndex = 2;
            this.lblUsuario.Text = "Usuario:";
            // 
            // lblClaveUsuario
            // 
            this.lblClaveUsuario.AutoSize = true;
            this.lblClaveUsuario.Location = new System.Drawing.Point(25, 155);
            this.lblClaveUsuario.Name = "lblClaveUsuario";
            this.lblClaveUsuario.Size = new System.Drawing.Size(91, 32);
            this.lblClaveUsuario.TabIndex = 4;
            this.lblClaveUsuario.Text = "Clave:";
            // 
            // lblNombreUsuario
            // 
            this.lblNombreUsuario.AutoSize = true;
            this.lblNombreUsuario.Location = new System.Drawing.Point(25, 210);
            this.lblNombreUsuario.Name = "lblNombreUsuario";
            this.lblNombreUsuario.Size = new System.Drawing.Size(118, 32);
            this.lblNombreUsuario.TabIndex = 6;
            this.lblNombreUsuario.Text = "Nombre:";
            // 
            // lblDireccionUsuario
            // 
            this.lblDireccionUsuario.AutoSize = true;
            this.lblDireccionUsuario.Location = new System.Drawing.Point(12, 265);
            this.lblDireccionUsuario.Name = "lblDireccionUsuario";
            this.lblDireccionUsuario.Size = new System.Drawing.Size(136, 32);
            this.lblDireccionUsuario.TabIndex = 8;
            this.lblDireccionUsuario.Text = "Dirección:";
            // 
            // lblTelefonoUsuario
            // 
            this.lblTelefonoUsuario.AutoSize = true;
            this.lblTelefonoUsuario.Location = new System.Drawing.Point(25, 400);
            this.lblTelefonoUsuario.Name = "lblTelefonoUsuario";
            this.lblTelefonoUsuario.Size = new System.Drawing.Size(123, 32);
            this.lblTelefonoUsuario.TabIndex = 10;
            this.lblTelefonoUsuario.Text = "Teléfono:";
            // 
            // grbNavegacionUsuario
            // 
            this.grbNavegacionUsuario.Controls.Add(this.btnPrimeroUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnAnteriorUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnSiguienteUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.btnUltimoUsuario);
            this.grbNavegacionUsuario.Controls.Add(this.lblnRegistrosUsuario);
            this.grbNavegacionUsuario.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.grbNavegacionUsuario.Location = new System.Drawing.Point(15, 530);
            this.grbNavegacionUsuario.Name = "grbNavegacionUsuario";
            this.grbNavegacionUsuario.Size = new System.Drawing.Size(460, 130);
            this.grbNavegacionUsuario.TabIndex = 12;
            this.grbNavegacionUsuario.TabStop = false;
            this.grbNavegacionUsuario.Text = "Navegación";
            // 
            // btnPrimeroUsuario
            // 
            this.btnPrimeroUsuario.Location = new System.Drawing.Point(10, 40);
            this.btnPrimeroUsuario.Name = "btnPrimeroUsuario";
            this.btnPrimeroUsuario.Size = new System.Drawing.Size(65, 50);
            this.btnPrimeroUsuario.TabIndex = 0;
            this.btnPrimeroUsuario.Text = "|<";
            this.btnPrimeroUsuario.UseVisualStyleBackColor = true;
            this.btnPrimeroUsuario.Click += new System.EventHandler(this.btnPrimeroUsuario_Click);
            // 
            // btnAnteriorUsuario
            // 
            this.btnAnteriorUsuario.Location = new System.Drawing.Point(75, 40);
            this.btnAnteriorUsuario.Name = "btnAnteriorUsuario";
            this.btnAnteriorUsuario.Size = new System.Drawing.Size(65, 50);
            this.btnAnteriorUsuario.TabIndex = 1;
            this.btnAnteriorUsuario.Text = "<";
            this.btnAnteriorUsuario.UseVisualStyleBackColor = true;
            this.btnAnteriorUsuario.Click += new System.EventHandler(this.btnAnteriorUsuario_Click);
            // 
            // btnSiguienteUsuario
            // 
            this.btnSiguienteUsuario.Location = new System.Drawing.Point(295, 40);
            this.btnSiguienteUsuario.Name = "btnSiguienteUsuario";
            this.btnSiguienteUsuario.Size = new System.Drawing.Size(65, 50);
            this.btnSiguienteUsuario.TabIndex = 3;
            this.btnSiguienteUsuario.Text = ">";
            this.btnSiguienteUsuario.UseVisualStyleBackColor = true;
            this.btnSiguienteUsuario.Click += new System.EventHandler(this.btnSiguienteUsuario_Click);
            // 
            // btnUltimoUsuario
            // 
            this.btnUltimoUsuario.Location = new System.Drawing.Point(360, 40);
            this.btnUltimoUsuario.Name = "btnUltimoUsuario";
            this.btnUltimoUsuario.Size = new System.Drawing.Size(65, 50);
            this.btnUltimoUsuario.TabIndex = 4;
            this.btnUltimoUsuario.Text = ">|";
            this.btnUltimoUsuario.UseVisualStyleBackColor = true;
            this.btnUltimoUsuario.Click += new System.EventHandler(this.btnUltimoUsuario_Click);
            // 
            // lblnRegistrosUsuario
            // 
            this.lblnRegistrosUsuario.AutoSize = true;
            this.lblnRegistrosUsuario.Location = new System.Drawing.Point(155, 55);
            this.lblnRegistrosUsuario.Name = "lblnRegistrosUsuario";
            this.lblnRegistrosUsuario.Size = new System.Drawing.Size(84, 32);
            this.lblnRegistrosUsuario.TabIndex = 2;
            this.lblnRegistrosUsuario.Text = "0 de 0";
            // 
            // grbEdicionUsuario
            // 
            this.grbEdicionUsuario.Controls.Add(this.btnAgregarUsuario);
            this.grbEdicionUsuario.Controls.Add(this.btnModificarUsuario);
            this.grbEdicionUsuario.Controls.Add(this.btnEliminarUsuario);
            this.grbEdicionUsuario.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold);
            this.grbEdicionUsuario.Location = new System.Drawing.Point(490, 530);
            this.grbEdicionUsuario.Name = "grbEdicionUsuario";
            this.grbEdicionUsuario.Size = new System.Drawing.Size(660, 130);
            this.grbEdicionUsuario.TabIndex = 13;
            this.grbEdicionUsuario.TabStop = false;
            this.grbEdicionUsuario.Text = "Edición";
            // 
            // btnAgregarUsuario
            // 
            this.btnAgregarUsuario.Location = new System.Drawing.Point(10, 45);
            this.btnAgregarUsuario.Name = "btnAgregarUsuario";
            this.btnAgregarUsuario.Size = new System.Drawing.Size(200, 50);
            this.btnAgregarUsuario.TabIndex = 0;
            this.btnAgregarUsuario.Text = "Nuevo";
            this.btnAgregarUsuario.UseVisualStyleBackColor = true;
            this.btnAgregarUsuario.Click += new System.EventHandler(this.btnAgregarUsuario_Click);
            // 
            // btnModificarUsuario
            // 
            this.btnModificarUsuario.Location = new System.Drawing.Point(225, 45);
            this.btnModificarUsuario.Name = "btnModificarUsuario";
            this.btnModificarUsuario.Size = new System.Drawing.Size(200, 50);
            this.btnModificarUsuario.TabIndex = 1;
            this.btnModificarUsuario.Text = "Modificar";
            this.btnModificarUsuario.UseVisualStyleBackColor = true;
            this.btnModificarUsuario.Click += new System.EventHandler(this.btnModificarUsuario_Click);
            // 
            // btnEliminarUsuario
            // 
            this.btnEliminarUsuario.Location = new System.Drawing.Point(440, 45);
            this.btnEliminarUsuario.Name = "btnEliminarUsuario";
            this.btnEliminarUsuario.Size = new System.Drawing.Size(200, 50);
            this.btnEliminarUsuario.TabIndex = 2;
            this.btnEliminarUsuario.Text = "Eliminar";
            this.btnEliminarUsuario.UseVisualStyleBackColor = true;
            this.btnEliminarUsuario.Click += new System.EventHandler(this.btnEliminarUsuario_Click);
            // 
            // txtUsuario
            // 
            this.txtUsuario.Location = new System.Drawing.Point(150, 97);
            this.txtUsuario.MaxLength = 16;
            this.txtUsuario.Name = "txtUsuario";
            this.txtUsuario.Size = new System.Drawing.Size(350, 40);
            this.txtUsuario.TabIndex = 3;
            // 
            // frm_usuario
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(1180, 690);
            this.Controls.Add(this.grbDatosUsuario);
            this.Controls.Add(this.grbNavegacionUsuario);
            this.Controls.Add(this.grbEdicionUsuario);
            this.Name = "frm_usuario";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Administración de usuarios";
            this.Load += new System.EventHandler(this.frm_usuario_Load);
            this.grbDatosUsuario.ResumeLayout(false);
            this.grbDatosUsuario.PerformLayout();
            this.grbNavegacionUsuario.ResumeLayout(false);
            this.grbNavegacionUsuario.PerformLayout();
            this.grbEdicionUsuario.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox grbDatosUsuario;
        private System.Windows.Forms.TextBox txtIdUsuario;
        private System.Windows.Forms.TextBox txtClaveUsuario;
        private System.Windows.Forms.TextBox txtNombreUsuario;
        private System.Windows.Forms.TextBox txtDireccionUsuario;
        private System.Windows.Forms.TextBox txtTelefonoUsuario;
        private System.Windows.Forms.Label lblIdUsuario;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClaveUsuario;
        private System.Windows.Forms.Label lblNombreUsuario;
        private System.Windows.Forms.Label lblDireccionUsuario;
        private System.Windows.Forms.Label lblTelefonoUsuario;

        private System.Windows.Forms.GroupBox grbNavegacionUsuario;
        private System.Windows.Forms.Button btnPrimeroUsuario;
        private System.Windows.Forms.Button btnAnteriorUsuario;
        private System.Windows.Forms.Button btnSiguienteUsuario;
        private System.Windows.Forms.Button btnUltimoUsuario;
        private System.Windows.Forms.Label lblnRegistrosUsuario;

        private System.Windows.Forms.GroupBox grbEdicionUsuario;
        private System.Windows.Forms.Button btnAgregarUsuario;
        private System.Windows.Forms.Button btnModificarUsuario;
        private System.Windows.Forms.Button btnEliminarUsuario;
        private System.Windows.Forms.TextBox txtUsuario;
    }
}
