namespace PROYEC_2
{
    partial class Form2
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
            this.Regresarmenu1 = new System.Windows.Forms.Button();
            this.pictureBox1 = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).BeginInit();
            this.SuspendLayout();
            // 
            // Regresarmenu1
            // 
            this.Regresarmenu1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(192)))), ((int)(((byte)(128)))));
            this.Regresarmenu1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.Regresarmenu1.Font = new System.Drawing.Font("Stencil", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Regresarmenu1.Location = new System.Drawing.Point(13, 13);
            this.Regresarmenu1.Name = "Regresarmenu1";
            this.Regresarmenu1.Size = new System.Drawing.Size(75, 27);
            this.Regresarmenu1.TabIndex = 1;
            this.Regresarmenu1.Text = "MENU";
            this.Regresarmenu1.UseVisualStyleBackColor = false;
            this.Regresarmenu1.Click += new System.EventHandler(this.Regresarmenu1_Click);
            // 
            // pictureBox1
            // 
            this.pictureBox1.Image = global::PROYEC_2.Properties.Resources.WhatsApp_Image_2025_12_06_at_6_52_23_PM;
            this.pictureBox1.Location = new System.Drawing.Point(-12, -6);
            this.pictureBox1.Name = "pictureBox1";
            this.pictureBox1.Size = new System.Drawing.Size(800, 371);
            this.pictureBox1.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox1.TabIndex = 0;
            this.pictureBox1.TabStop = false;
            // 
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(790, 364);
            this.Controls.Add(this.Regresarmenu1);
            this.Controls.Add(this.pictureBox1);
            this.Name = "Form2";
            this.Text = "Form2";
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.PictureBox pictureBox1;
        private System.Windows.Forms.Button Regresarmenu1;
    }
}