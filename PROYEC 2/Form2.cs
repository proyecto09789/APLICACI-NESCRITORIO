using System;
using System.Windows.Forms;

namespace PROYEC_2
{
    public partial class Form2 : Form
    {
        public Form2()
        {
            InitializeComponent();
        }

        private void Regresarmenu1_Click(object sender, EventArgs e)
        {
            Form1 ventana = new Form1();
            ventana.Show();
            this.Hide();  // Oculta el formulario actual
        }

     

        private void pictureBox2_Click(object sender, EventArgs e)
        {
            Form5 ventana = new Form5();
            ventana.Show();
            this.Hide();  // Oculta el formulario actual

        }

        
    }
}
