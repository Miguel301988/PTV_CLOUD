﻿namespace TPV_CLOUD
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
            this.lblRegistro = new System.Windows.Forms.LinkLabel();
            this.lblOlvidado = new System.Windows.Forms.LinkLabel();
            this.txtContraseña = new System.Windows.Forms.TextBox();
            this.txtTelefono = new System.Windows.Forms.TextBox();
            this.lblContraseña = new System.Windows.Forms.Label();
            this.lblTelefono = new System.Windows.Forms.Label();
            this.BtnContinuar = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblRegistro
            // 
            this.lblRegistro.AutoSize = true;
            this.lblRegistro.Location = new System.Drawing.Point(117, 167);
            this.lblRegistro.Name = "lblRegistro";
            this.lblRegistro.Size = new System.Drawing.Size(60, 13);
            this.lblRegistro.TabIndex = 13;
            this.lblRegistro.TabStop = true;
            this.lblRegistro.Text = "Registrarse";
            // 
            // lblOlvidado
            // 
            this.lblOlvidado.AutoSize = true;
            this.lblOlvidado.Location = new System.Drawing.Point(86, 142);
            this.lblOlvidado.Name = "lblOlvidado";
            this.lblOlvidado.Size = new System.Drawing.Size(116, 13);
            this.lblOlvidado.TabIndex = 12;
            this.lblOlvidado.TabStop = true;
            this.lblOlvidado.Text = "¿Contraseña olvidada?";
            // 
            // txtContraseña
            // 
            this.txtContraseña.Location = new System.Drawing.Point(102, 79);
            this.txtContraseña.Name = "txtContraseña";
            this.txtContraseña.PasswordChar = '*';
            this.txtContraseña.Size = new System.Drawing.Size(100, 20);
            this.txtContraseña.TabIndex = 11;
            // 
            // txtTelefono
            // 
            this.txtTelefono.Location = new System.Drawing.Point(102, 38);
            this.txtTelefono.Name = "txtTelefono";
            this.txtTelefono.Size = new System.Drawing.Size(100, 20);
            this.txtTelefono.TabIndex = 10;
            // 
            // lblContraseña
            // 
            this.lblContraseña.AutoSize = true;
            this.lblContraseña.Location = new System.Drawing.Point(15, 63);
            this.lblContraseña.Name = "lblContraseña";
            this.lblContraseña.Size = new System.Drawing.Size(64, 13);
            this.lblContraseña.TabIndex = 9;
            this.lblContraseña.Text = "Contraseña:";
            // 
            // lblTelefono
            // 
            this.lblTelefono.AutoSize = true;
            this.lblTelefono.Location = new System.Drawing.Point(15, 11);
            this.lblTelefono.Name = "lblTelefono";
            this.lblTelefono.Size = new System.Drawing.Size(101, 13);
            this.lblTelefono.TabIndex = 8;
            this.lblTelefono.Text = "Telefono registrado:";
            // 
            // BtnContinuar
            // 
            this.BtnContinuar.Location = new System.Drawing.Point(102, 116);
            this.BtnContinuar.Name = "BtnContinuar";
            this.BtnContinuar.Size = new System.Drawing.Size(75, 23);
            this.BtnContinuar.TabIndex = 7;
            this.BtnContinuar.Text = "Continuar";
            this.BtnContinuar.UseVisualStyleBackColor = true;
            // 
            // Login
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(278, 195);
            this.Controls.Add(this.lblRegistro);
            this.Controls.Add(this.lblOlvidado);
            this.Controls.Add(this.txtContraseña);
            this.Controls.Add(this.txtTelefono);
            this.Controls.Add(this.lblContraseña);
            this.Controls.Add(this.lblTelefono);
            this.Controls.Add(this.BtnContinuar);
            this.Name = "Login";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Login";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.LinkLabel lblRegistro;
        private System.Windows.Forms.LinkLabel lblOlvidado;
        private System.Windows.Forms.TextBox txtContraseña;
        private System.Windows.Forms.TextBox txtTelefono;
        private System.Windows.Forms.Label lblContraseña;
        private System.Windows.Forms.Label lblTelefono;
        private System.Windows.Forms.Button BtnContinuar;
    }
}

