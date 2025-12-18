using System;
using System.Drawing;
using System.Media;
using System.Windows.Forms;

namespace PROYEC_2
{
    public partial class Form3 : Form
    {
        // Campos estáticos para persistir el estado entre instancias de Form3
        private static SoundPlayer musicPlayer;
        private static bool isPlaying = false;

        private readonly string rutaSonido = @"C:\Users\barre\OneDrive\Escritorio\PROYEC 2\APLICACIÓNESCRITORIO\PROYEC 2\Resources\musicamenu.wav";

        public Form3()
        {
            InitializeComponent();

            // Aplicar el estado actual al crear la instancia (mantiene el color del botón)
            ApplyButtonState();
        }

        private void ApplyButtonState()
        {
            // Si el control existe (asegura que InitializeComponent ya lo creó)
            if (this.Botonmusica == null)
                return;

            if (isPlaying)
            {
                try
                {
                    if (musicPlayer == null)
                        musicPlayer = new SoundPlayer(rutaSonido);

                    // Asegurar que está reproduciéndose en bucle si el estado indica reproducción
                    musicPlayer.PlayLooping();
                    Botonmusica.BackColor = Color.Green;
                }
                catch
                {
                    // Si falla el audio, sólo reflejamos el estado visual
                    Botonmusica.BackColor = Color.Red;
                }
            }
            else
            {
                Botonmusica.BackColor = Color.Red;
            }
        }

        private void Tituloconfi_Click(object sender, EventArgs e)
        {

        }

        private void Cerrarconf_Click(object sender, EventArgs e)
        {
            Pestaña2m ventana = new Pestaña2m();
            ventana.Show();
            this.Hide();  // Oculta el formulario actual
        }

        private void Botonmusica_Click(object sender, EventArgs e)
        {
            // Alterna la reproducción y actualiza color; usa campos estáticos para persistencia
            if (!isPlaying)
            {
                try
                {
                    if (musicPlayer == null)
                        musicPlayer = new SoundPlayer(rutaSonido);

                    musicPlayer.PlayLooping();
                    isPlaying = true;

                    Botonmusica.BackColor = Color.Green;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo reproducir el sonido: " + ex.Message, "Error de audio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
            else
            {
                try
                {
                    musicPlayer?.Stop();
                    isPlaying = false;

                    Botonmusica.BackColor = Color.Red;
                }
                catch (Exception ex)
                {
                    MessageBox.Show("Error al detener el audio: " + ex.Message, "Error de audio", MessageBoxButtons.OK, MessageBoxIcon.Warning);
                }
            }
        }
    }
}
