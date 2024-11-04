namespace LoginForm
{
    partial class Form1
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
            this.lblNombre = new System.Windows.Forms.Label();
            this.textNombre = new System.Windows.Forms.TextBox();
            this.textContraseña = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btnSesion = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // lblNombre
            // 
            this.lblNombre.AutoSize = true;
            this.lblNombre.Location = new System.Drawing.Point(284, 68);
            this.lblNombre.Name = "lblNombre";
            this.lblNombre.Size = new System.Drawing.Size(99, 13);
            this.lblNombre.TabIndex = 0;
            this.lblNombre.Text = "Nombre de usuario:";
            // 
            // textNombre
            // 
            this.textNombre.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.textNombre.Location = new System.Drawing.Point(389, 65);
            this.textNombre.Name = "textNombre";
            this.textNombre.Size = new System.Drawing.Size(100, 20);
            this.textNombre.TabIndex = 1;
            // 
            // textContraseña
            // 
            this.textContraseña.Location = new System.Drawing.Point(389, 101);
            this.textContraseña.Name = "textContraseña";
            this.textContraseña.PasswordChar = '$';
            this.textContraseña.Size = new System.Drawing.Size(100, 20);
            this.textContraseña.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(323, 101);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(63, 13);
            this.label1.TabIndex = 3;
            this.label1.Text = "contraseña:";
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.panel1.Location = new System.Drawing.Point(11, 58);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(220, 369);
            this.panel1.TabIndex = 4;
            // 
            // btnSesion
            // 
            this.btnSesion.BackColor = System.Drawing.SystemColors.MenuHighlight;
            this.btnSesion.Location = new System.Drawing.Point(326, 148);
            this.btnSesion.Name = "btnSesion";
            this.btnSesion.Size = new System.Drawing.Size(182, 67);
            this.btnSesion.TabIndex = 5;
            this.btnSesion.Text = "Iniciar sesión";
            this.btnSesion.UseVisualStyleBackColor = false;
            this.btnSesion.Click += new System.EventHandler(this.btnSesion_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(562, 450);
            this.Controls.Add(this.btnSesion);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.textContraseña);
            this.Controls.Add(this.textNombre);
            this.Controls.Add(this.lblNombre);
            this.Name = "Form1";
            this.Text = "Inicio de Sesión";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lblNombre;
        private System.Windows.Forms.TextBox textNombre;
        private System.Windows.Forms.TextBox textContraseña;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button btnSesion;
    }
}

