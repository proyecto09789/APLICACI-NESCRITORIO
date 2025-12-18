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
            // Form2
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackgroundImage = global::PROYEC_2.Properties.Resources.WhatsApp_Image_2025_12_06_at_6_52_23_PM;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(1025, 526);
            this.Controls.Add(this.Regresarmenu1);
            this.Name = "Form2";
            this.Text = "Form2";
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Button Regresarmenu1;
    }
}