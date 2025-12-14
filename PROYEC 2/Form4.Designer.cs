namespace PROYEC_2
{
    partial class iniciarsessionlong1
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
            this.titulodelongin = new System.Windows.Forms.Label();
            this.titulousuario = new System.Windows.Forms.Label();
            this.titulocontra = new System.Windows.Forms.Label();
            this.Usuariolong = new System.Windows.Forms.TextBox();
            this.Contralog = new System.Windows.Forms.TextBox();
            this.Iniciarsesión1 = new System.Windows.Forms.Button();
            this.Registrarusuario = new System.Windows.Forms.Button();
            this.SuspendLayout();
            // 
            // titulodelongin
            // 
            this.titulodelongin.AutoSize = true;
            this.titulodelongin.Font = new System.Drawing.Font("Stencil", 24F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulodelongin.Location = new System.Drawing.Point(293, 31);
            this.titulodelongin.Name = "titulodelongin";
            this.titulodelongin.Size = new System.Drawing.Size(336, 38);
            this.titulodelongin.TabIndex = 0;
            this.titulodelongin.Text = "BIENVENDO USUARIO";
            // 
            // titulousuario
            // 
            this.titulousuario.AutoSize = true;
            this.titulousuario.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulousuario.Location = new System.Drawing.Point(326, 140);
            this.titulousuario.Name = "titulousuario";
            this.titulousuario.Size = new System.Drawing.Size(85, 19);
            this.titulousuario.TabIndex = 1;
            this.titulousuario.Text = "Usuario  ";
            // 
            // titulocontra
            // 
            this.titulocontra.AutoSize = true;
            this.titulocontra.Font = new System.Drawing.Font("Stencil", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.titulocontra.Location = new System.Drawing.Point(316, 231);
            this.titulocontra.Name = "titulocontra";
            this.titulocontra.Size = new System.Drawing.Size(109, 19);
            this.titulocontra.TabIndex = 2;
            this.titulocontra.Text = "Contraseña";
            // 
            // Usuariolong
            // 
            this.Usuariolong.Location = new System.Drawing.Point(452, 141);
            this.Usuariolong.Name = "Usuariolong";
            this.Usuariolong.Size = new System.Drawing.Size(124, 20);
            this.Usuariolong.TabIndex = 3;
            // 
            // Contralog
            // 
            this.Contralog.Location = new System.Drawing.Point(452, 230);
            this.Contralog.Name = "Contralog";
            this.Contralog.Size = new System.Drawing.Size(124, 20);
            this.Contralog.TabIndex = 4;
            // 
            // Iniciarsesión1
            // 
            this.Iniciarsesión1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(192)))), ((int)(((byte)(64)))), ((int)(((byte)(0)))));
            this.Iniciarsesión1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Iniciarsesión1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Iniciarsesión1.Location = new System.Drawing.Point(452, 297);
            this.Iniciarsesión1.Name = "Iniciarsesión1";
            this.Iniciarsesión1.Size = new System.Drawing.Size(124, 31);
            this.Iniciarsesión1.TabIndex = 5;
            this.Iniciarsesión1.Text = "Iniciar sesión ";
            this.Iniciarsesión1.UseVisualStyleBackColor = false;
            this.Iniciarsesión1.Click += new System.EventHandler(this.Iniciarsesión1_Click);
            // 
            // Registrarusuario
            // 
            this.Registrarusuario.Location = new System.Drawing.Point(452, 346);
            this.Registrarusuario.Name = "Registrarusuario";
            this.Registrarusuario.Size = new System.Drawing.Size(124, 31);
            this.Registrarusuario.TabIndex = 6;
            this.Registrarusuario.Text = "Registrar";
            this.Registrarusuario.UseVisualStyleBackColor = true;
            // 
            // iniciarsessionlong1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(0)))));
            this.ClientSize = new System.Drawing.Size(800, 450);
            this.Controls.Add(this.Registrarusuario);
            this.Controls.Add(this.Iniciarsesión1);
            this.Controls.Add(this.Contralog);
            this.Controls.Add(this.Usuariolong);
            this.Controls.Add(this.titulocontra);
            this.Controls.Add(this.titulousuario);
            this.Controls.Add(this.titulodelongin);
            this.Name = "iniciarsessionlong1";
            this.Text = "Form4";
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label titulodelongin;
        private System.Windows.Forms.Label titulousuario;
        private System.Windows.Forms.Label titulocontra;
        private System.Windows.Forms.TextBox Usuariolong;
        private System.Windows.Forms.TextBox Contralog;
        private System.Windows.Forms.Button Iniciarsesión1;
        private System.Windows.Forms.Button Registrarusuario;
    }
}