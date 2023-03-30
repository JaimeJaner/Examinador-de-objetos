using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Media;

namespace Examinador_de_objetos
{
    public partial class Form1 : Form
    {
        private SoundPlayer player;

        public Form1()
        {
            InitializeComponent();
            InitializeSound();
        }

        private void InitializeSound()
        {
            // Create an instance of the SoundPlayer class.
            player = new SoundPlayer();

        }

        private void btn_Play_Click(object sender, EventArgs e)
        {
            player.Play();
        }

        private void btn_SeleccionarArchivo_Click(object sender, EventArgs e)
        {
            // Creamos un nuevo OpenFileDialog para buscar el archivo.
            OpenFileDialog dlg = new OpenFileDialog();

            // Make sure the dialog checks for existence of the 
            // selected file.
            dlg.CheckFileExists = true;

            // Allow selection of .wav files only.
            dlg.Filter = "WAV files (*.wav)|*.wav";
            dlg.DefaultExt = ".wav";

            // Activate the file selection dialog.
            if (dlg.ShowDialog() == DialogResult.OK)
            {
                // Get the selected file's path from the dialog.
                this.filepathTextbox.Text = dlg.FileName;

                // Assign the selected file's path to 
                // the SoundPlayer object.  
                player.SoundLocation = filepathTextbox.Text;
            }

        
        }

        private void bnt_Stop_Click(object sender, EventArgs e)
        {
            player.Stop();
        }

        private void filepathTextbox_TextChanged(object sender, EventArgs e)
        {

        }

    }

}
