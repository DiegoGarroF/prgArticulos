namespace prgArticulos
{
    partial class frmAcceso
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.lbUsuario = new System.Windows.Forms.Label();
            this.lbContraseña = new System.Windows.Forms.Label();
            this.txCodigo = new System.Windows.Forms.TextBox();
            this.txClave = new System.Windows.Forms.TextBox();
            this.btnIngresar = new System.Windows.Forms.Button();
            this.btnSalir = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lbUsuario
            // 
            this.lbUsuario.AutoSize = true;
            this.lbUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbUsuario.ForeColor = System.Drawing.SystemColors.ActiveCaptionText;
            this.lbUsuario.Location = new System.Drawing.Point(50, 39);
            this.lbUsuario.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbUsuario.Name = "lbUsuario";
            this.lbUsuario.Size = new System.Drawing.Size(62, 16);
            this.lbUsuario.TabIndex = 0;
            this.lbUsuario.Text = "Usuario";
            this.lbUsuario.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbContraseña
            // 
            this.lbContraseña.AutoSize = true;
            this.lbContraseña.Location = new System.Drawing.Point(50, 111);
            this.lbContraseña.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lbContraseña.Name = "lbContraseña";
            this.lbContraseña.Size = new System.Drawing.Size(87, 16);
            this.lbContraseña.TabIndex = 0;
            this.lbContraseña.Text = "Contraseña";
            // 
            // txCodigo
            // 
            this.txCodigo.Location = new System.Drawing.Point(216, 33);
            this.txCodigo.Margin = new System.Windows.Forms.Padding(4);
            this.txCodigo.Name = "txCodigo";
            this.txCodigo.Size = new System.Drawing.Size(148, 22);
            this.txCodigo.TabIndex = 0;
            this.txCodigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txCodigo_KeyPress);
            // 
            // txClave
            // 
            this.txClave.Location = new System.Drawing.Point(216, 105);
            this.txClave.Margin = new System.Windows.Forms.Padding(4);
            this.txClave.Name = "txClave";
            this.txClave.PasswordChar = '*';
            this.txClave.Size = new System.Drawing.Size(148, 22);
            this.txClave.TabIndex = 1;
            this.txClave.BorderStyleChanged += new System.EventHandler(this.label1_Click);
            this.txClave.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txClave_KeyPress);
            // 
            // btnIngresar
            // 
            this.btnIngresar.Enabled = false;
            this.btnIngresar.Location = new System.Drawing.Point(53, 193);
            this.btnIngresar.Name = "btnIngresar";
            this.btnIngresar.Size = new System.Drawing.Size(75, 23);
            this.btnIngresar.TabIndex = 2;
            this.btnIngresar.Text = "Ingresar";
            this.btnIngresar.UseVisualStyleBackColor = true;
            this.btnIngresar.Click += new System.EventHandler(this.btnIngresar_Click);
            // 
            // btnSalir
            // 
            this.btnSalir.Location = new System.Drawing.Point(250, 193);
            this.btnSalir.Name = "btnSalir";
            this.btnSalir.Size = new System.Drawing.Size(75, 23);
            this.btnSalir.TabIndex = 3;
            this.btnSalir.Text = "Salir";
            this.btnSalir.UseVisualStyleBackColor = true;
            this.btnSalir.Click += new System.EventHandler(this.btnSalir_Click);
            // 
            // frmAcceso
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 16F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Gray;
            this.ClientSize = new System.Drawing.Size(445, 275);
            this.ControlBox = false;
            this.Controls.Add(this.btnSalir);
            this.Controls.Add(this.btnIngresar);
            this.Controls.Add(this.txClave);
            this.Controls.Add(this.txCodigo);
            this.Controls.Add(this.lbContraseña);
            this.Controls.Add(this.lbUsuario);
            this.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Margin = new System.Windows.Forms.Padding(4);
            this.Name = "frmAcceso";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Ventana De Acceso";
            this.Load += new System.EventHandler(this.frmAcceso_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbUsuario;
        private System.Windows.Forms.Label lbContraseña;
        private System.Windows.Forms.TextBox txCodigo;
        private System.Windows.Forms.TextBox txClave;
        private System.Windows.Forms.Button btnIngresar;
        private System.Windows.Forms.Button btnSalir;
    }
}

