namespace miPrimeraAplicacion
{
    partial class login
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
            this.lblTituloLogin = new System.Windows.Forms.Label();
            this.lblUsuarioLogin = new System.Windows.Forms.Label();
            this.lblUsuarioClave = new System.Windows.Forms.Label();
            this.txtUsuarioLogin = new System.Windows.Forms.TextBox();
            this.txtClaveLogin = new System.Windows.Forms.TextBox();
            this.btnIngresarLogin = new System.Windows.Forms.Button();
            this.btnSalirLogin = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblTituloLogin
            // 
            this.lblTituloLogin.AutoSize = true;
            this.lblTituloLogin.Font = new System.Drawing.Font("Times New Roman", 20F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblTituloLogin.Location = new System.Drawing.Point(407, 66);
            this.lblTituloLogin.Name = "lblTituloLogin";
            this.lblTituloLogin.Size = new System.Drawing.Size(118, 45);
            this.lblTituloLogin.TabIndex = 0;
            this.lblTituloLogin.Text = "Login";
            // 
            // lblUsuarioLogin
            // 
            this.lblUsuarioLogin.AutoSize = true;
            this.lblUsuarioLogin.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioLogin.Location = new System.Drawing.Point(290, 154);
            this.lblUsuarioLogin.Name = "lblUsuarioLogin";
            this.lblUsuarioLogin.Size = new System.Drawing.Size(118, 32);
            this.lblUsuarioLogin.TabIndex = 1;
            this.lblUsuarioLogin.Text = "Usuario:";
            // 
            // lblUsuarioClave
            // 
            this.lblUsuarioClave.AutoSize = true;
            this.lblUsuarioClave.Font = new System.Drawing.Font("Times New Roman", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuarioClave.Location = new System.Drawing.Point(247, 247);
            this.lblUsuarioClave.Name = "lblUsuarioClave";
            this.lblUsuarioClave.Size = new System.Drawing.Size(161, 32);
            this.lblUsuarioClave.TabIndex = 2;
            this.lblUsuarioClave.Text = "Contraseña:";
            // 
            // txtUsuarioLogin
            // 
            this.txtUsuarioLogin.Location = new System.Drawing.Point(432, 161);
            this.txtUsuarioLogin.Name = "txtUsuarioLogin";
            this.txtUsuarioLogin.Size = new System.Drawing.Size(193, 26);
            this.txtUsuarioLogin.TabIndex = 3;
            // 
            // txtClaveLogin
            // 
            this.txtClaveLogin.Location = new System.Drawing.Point(432, 254);
            this.txtClaveLogin.Name = "txtClaveLogin";
            this.txtClaveLogin.Size = new System.Drawing.Size(193, 26);
            this.txtClaveLogin.TabIndex = 4;
            this.txtClaveLogin.UseSystemPasswordChar = true;
            // 
            // btnIngresarLogin
            // 
            this.btnIngresarLogin.BackColor = System.Drawing.SystemColors.GradientActiveCaption;
            this.btnIngresarLogin.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnIngresarLogin.Location = new System.Drawing.Point(360, 341);
            this.btnIngresarLogin.Name = "btnIngresarLogin";
            this.btnIngresarLogin.Size = new System.Drawing.Size(182, 58);
            this.btnIngresarLogin.TabIndex = 5;
            this.btnIngresarLogin.Text = "Ingresar";
            this.btnIngresarLogin.UseVisualStyleBackColor = false;
            // 
            // btnSalirLogin
            // 
            this.btnSalirLogin.BackColor = System.Drawing.Color.LightCoral;
            this.btnSalirLogin.Font = new System.Drawing.Font("Times New Roman", 11F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnSalirLogin.Location = new System.Drawing.Point(360, 430);
            this.btnSalirLogin.Name = "btnSalirLogin";
            this.btnSalirLogin.Size = new System.Drawing.Size(182, 58);
            this.btnSalirLogin.TabIndex = 6;
            this.btnSalirLogin.Text = "Salir";
            this.btnSalirLogin.UseVisualStyleBackColor = false;
            // 
            // login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(979, 666);
            this.Controls.Add(this.btnSalirLogin);
            this.Controls.Add(this.btnIngresarLogin);
            this.Controls.Add(this.txtClaveLogin);
            this.Controls.Add(this.txtUsuarioLogin);
            this.Controls.Add(this.lblUsuarioClave);
            this.Controls.Add(this.lblUsuarioLogin);
            this.Controls.Add(this.lblTituloLogin);
            this.Name = "login";
            this.Text = "login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblTituloLogin;
        private System.Windows.Forms.Label lblUsuarioLogin;
        private System.Windows.Forms.Label lblUsuarioClave;
        private System.Windows.Forms.TextBox txtUsuarioLogin;
        private System.Windows.Forms.TextBox txtClaveLogin;
        private System.Windows.Forms.Button btnIngresarLogin;
        private System.Windows.Forms.Button btnSalirLogin;
    }
}