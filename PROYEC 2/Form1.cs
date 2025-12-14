
using System;
using System.IO;
using System.Media;
using System.Windows.Forms;
//Espacio de nombres del proyecto
namespace PROYEC_2
{

    //Formulario principal
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();

        }
        //Boton de iniciar

        private void Iniciar_Click(object sender, EventArgs e)
        {


            Form2 ventana = new Form2();
            ventana.Show();
            this.Hide(); // Oculta el formulario actual
        }

        //Boton de configuracion

        private void Settin1_Click(object sender, EventArgs e)
        {
            Form3 ventana = new Form3();
            ventana.Show();
            this.Hide();  // Oculta el formulario actual
        }
    }

    //Musica para la app

    public static class AudioManager
    {

        //Ruta del sonido
        private static SoundPlayer player;
        private static readonly string rutaSonido = @"C:\Users\barre\OneDrive\Escritorio\PROYEC 2\APLICACIÓNESCRITORIO\PROYEC 2\Resources\musicamenu.wav";

        //Estado del reproductor
        public static bool IsPlaying { get; private set; }
        //Asegurar que el reproductor este inicializado

        private static void EnsurePlayer()
        {
            if (player == null)
                player = new SoundPlayer(rutaSonido);
        }
        //Reproducir musica en bucle
        public static void PlayLooping()
        {
            try
            {
                // Verificar si el archivo de sonido existe
                if (!File.Exists(rutaSonido))
                    return;

                // Inicializar y reproducir
                EnsurePlayer();
                player.PlayLooping();
                IsPlaying = true;
            }
            
            catch
            // Ignorar errores al reproducir
            {
                IsPlaying = false;
            }
        }
        //Detener musica
        public static void Stop()
             
        {
            try
            {
                player?.Stop();
            }
            catch
            {
                // Ignorar errores al detener
            }
            finally
            {
                IsPlaying = false;
            }
        }
        //Alternar musica
        public static void Toggle()
        {
            if (IsPlaying) Stop(); else PlayLooping();
        }
    }

}