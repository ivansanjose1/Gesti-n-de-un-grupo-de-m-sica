namespace Gestion_de_un_grupo_musical
{
    partial class Login
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
            this.lblBienvenida = new System.Windows.Forms.Label();
            this.btnAceptar = new System.Windows.Forms.Button();
            this.btnCancelar = new System.Windows.Forms.Button();
            this.lblUsuario = new System.Windows.Forms.Label();
            this.lblClave_ = new System.Windows.Forms.Label();
            this.textUsuario = new System.Windows.Forms.TextBox();
            this.textClave = new System.Windows.Forms.TextBox();
            this.lblUsuario_ = new System.Windows.Forms.Label();
            this.lblError = new System.Windows.Forms.Label();
            this.lblNombreGrupo = new System.Windows.Forms.Label();
            this.SuspendLayout();
            // 
            // lblBienvenida
            // 
            this.lblBienvenida.AutoSize = true;
            this.lblBienvenida.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblBienvenida.Location = new System.Drawing.Point(119, 86);
            this.lblBienvenida.Name = "lblBienvenida";
            this.lblBienvenida.Size = new System.Drawing.Size(582, 30);
            this.lblBienvenida.TabIndex = 0;
            this.lblBienvenida.Text = "Bienvenido a la gestion de Avenged Sevenfold";
            // 
            // btnAceptar
            // 
            this.btnAceptar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAceptar.Location = new System.Drawing.Point(291, 360);
            this.btnAceptar.Name = "btnAceptar";
            this.btnAceptar.Size = new System.Drawing.Size(103, 41);
            this.btnAceptar.TabIndex = 1;
            this.btnAceptar.Text = "Aceptar";
            this.btnAceptar.UseVisualStyleBackColor = true;
            this.btnAceptar.Click += new System.EventHandler(this.btnAceptar_Click);
            // 
            // btnCancelar
            // 
            this.btnCancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnCancelar.Location = new System.Drawing.Point(484, 360);
            this.btnCancelar.Name = "btnCancelar";
            this.btnCancelar.Size = new System.Drawing.Size(101, 41);
            this.btnCancelar.TabIndex = 2;
            this.btnCancelar.Text = "Cancelar";
            this.btnCancelar.UseVisualStyleBackColor = true;
            this.btnCancelar.Click += new System.EventHandler(this.btnCancelar_Click);
            // 
            // lblUsuario
            // 
            this.lblUsuario.AutoSize = true;
            this.lblUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 10F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario.Location = new System.Drawing.Point(296, 218);
            this.lblUsuario.Name = "lblUsuario";
            this.lblUsuario.Size = new System.Drawing.Size(0, 17);
            this.lblUsuario.TabIndex = 3;
            // 
            // lblClave_
            // 
            this.lblClave_.AutoSize = true;
            this.lblClave_.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblClave_.Location = new System.Drawing.Point(294, 285);
            this.lblClave_.Name = "lblClave_";
            this.lblClave_.Size = new System.Drawing.Size(86, 29);
            this.lblClave_.TabIndex = 4;
            this.lblClave_.Text = "Clave:";
            // 
            // textUsuario
            // 
            this.textUsuario.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textUsuario.Location = new System.Drawing.Point(432, 226);
            this.textUsuario.Name = "textUsuario";
            this.textUsuario.Size = new System.Drawing.Size(120, 24);
            this.textUsuario.TabIndex = 5;
            this.textUsuario.TextChanged += new System.EventHandler(this.textUsuario_TextChanged);
            // 
            // textClave
            // 
            this.textClave.Font = new System.Drawing.Font("Microsoft Sans Serif", 11F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textClave.Location = new System.Drawing.Point(432, 290);
            this.textClave.Name = "textClave";
            this.textClave.Size = new System.Drawing.Size(120, 24);
            this.textClave.TabIndex = 6;
            this.textClave.TextChanged += new System.EventHandler(this.textClave_TextChanged);
            // 
            // lblUsuario_
            // 
            this.lblUsuario_.AutoSize = true;
            this.lblUsuario_.Font = new System.Drawing.Font("Microsoft Sans Serif", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblUsuario_.Location = new System.Drawing.Point(285, 221);
            this.lblUsuario_.Name = "lblUsuario_";
            this.lblUsuario_.Size = new System.Drawing.Size(110, 29);
            this.lblUsuario_.TabIndex = 7;
            this.lblUsuario_.Text = "Usuario:";
            // 
            // lblError
            // 
            this.lblError.AutoSize = true;
            this.lblError.Font = new System.Drawing.Font("Microsoft Sans Serif", 14F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblError.ForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(0)))), ((int)(((byte)(0)))));
            this.lblError.Location = new System.Drawing.Point(287, 156);
            this.lblError.Name = "lblError";
            this.lblError.Size = new System.Drawing.Size(249, 24);
            this.lblError.TabIndex = 8;
            this.lblError.Text = "Usuario y/o clave erronea";
            this.lblError.Visible = false;
            // 
            // lblNombreGrupo
            // 
            this.lblNombreGrupo.AutoSize = true;
            this.lblNombreGrupo.Font = new System.Drawing.Font("Microsoft Sans Serif", 19F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblNombreGrupo.Location = new System.Drawing.Point(285, 22);
            this.lblNombreGrupo.Name = "lblNombreGrupo";
            this.lblNombreGrupo.Size = new System.Drawing.Size(250, 30);
            this.lblNombreGrupo.TabIndex = 9;
            this.lblNombreGrupo.Text = "Avenged Sevenfold";
            // 
            // Login
            // 
            this.AcceptButton = this.btnAceptar;
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(787, 450);
            this.Controls.Add(this.lblNombreGrupo);
            this.Controls.Add(this.lblError);
            this.Controls.Add(this.lblUsuario_);
            this.Controls.Add(this.textClave);
            this.Controls.Add(this.textUsuario);
            this.Controls.Add(this.lblClave_);
            this.Controls.Add(this.lblUsuario);
            this.Controls.Add(this.btnCancelar);
            this.Controls.Add(this.btnAceptar);
            this.Controls.Add(this.lblBienvenida);
            this.Name = "Login";
            this.Text = "Login";
            this.Load += new System.EventHandler(this.Login_Load);
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblBienvenida;
        private System.Windows.Forms.Button btnAceptar;
        private System.Windows.Forms.Button btnCancelar;
        private System.Windows.Forms.Label lblUsuario;
        private System.Windows.Forms.Label lblClave_;
        private System.Windows.Forms.TextBox textUsuario;
        private System.Windows.Forms.TextBox textClave;
        private System.Windows.Forms.Label lblUsuario_;
        private System.Windows.Forms.Label lblError;
        private System.Windows.Forms.Label lblNombreGrupo;
    }
}

