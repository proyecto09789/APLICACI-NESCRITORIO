namespace PROYEC_2
{
    partial class Form3
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
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            this.Tituloconfi = new System.Windows.Forms.Label();
            this.Botonmusica = new System.Windows.Forms.Button();
            this.Cerrarconf = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYEC_2.Properties.Resources.fondo_configuración;
            this.pictureBox1.Location = new System.Drawing.Point(2, 1);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(241, 370);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Tituloconfi
            // 
            this.Tituloconfi.AutoSize = true;
            this.Tituloconfi.BackColor = System.Drawing.SystemColors.Highlight;
            this.Tituloconfi.Font = new System.Drawing.Font("Stencil", 15.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Tituloconfi.Location = new System.Drawing.Point(38, 61);
            this.Tituloconfi.Name = "Tituloconfi";
            this.Tituloconfi.Size = new System.Drawing.Size(173, 25);
            this.Tituloconfi.TabIndex = 1;
            this.Tituloconfi.Text = "CONFIGURACIÓN";
            this.Tituloconfi.Click += new System.EventHandler(this.Tituloconfi_Click);
            // 
            // Botonmusica
            // 
            this.Botonmusica.BackColor = System.Drawing.SystemColors.ActiveCaption;
            this.Botonmusica.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Botonmusica.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Botonmusica.Location = new System.Drawing.Point(72, 115);
            this.Botonmusica.Name = "Botonmusica";
            this.Botonmusica.Size = new System.Drawing.Size(94, 29);
            this.Botonmusica.TabIndex = 2;
            this.Botonmusica.Text = "MÚSICA";
            this.Botonmusica.UseVisualStyleBackColor = false;
            this.Botonmusica.Click += new System.EventHandler(this.Botonmusica_Click);
            // 
            // Cerrarconf
            // 
            this.Cerrarconf.BackColor = System.Drawing.Color.Red;
            this.Cerrarconf.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Cerrarconf.Font = new System.Drawing.Font("Stencil", 11.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Cerrarconf.Location = new System.Drawing.Point(182, 22);
            this.Cerrarconf.Name = "Cerrarconf";
            this.Cerrarconf.Size = new System.Drawing.Size(28, 24);
            this.Cerrarconf.TabIndex = 3;
            this.Cerrarconf.Text = "X";
            this.Cerrarconf.UseVisualStyleBackColor = false;
            this.Cerrarconf.Click += new System.EventHandler(this.Cerrarconf_Click);
            // 
            // Form3
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(241, 372);
            this.Controls.Add(this.Cerrarconf);
            this.Controls.Add(this.Botonmusica);
            this.Controls.Add(this.Tituloconfi);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form3";
            this.Text = "Form3";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Label Tituloconfi;
        private System.Windows.Forms.Button Botonmusica;
        private System.Windows.Forms.Button Cerrarconf;
    }
}