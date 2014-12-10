using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using AForge.Video;
using AForge.Video.DirectShow;

namespace Herrajes
{
    public partial class Tomar_Foto_CamaraWeb : Form
    {
        private bool ExistenDispositivos = false;
        private FilterInfoCollection DispositivosDeVideo;
        private VideoCaptureDevice FuenteDeVideo = null;

        public Tomar_Foto_CamaraWeb()
        {
            InitializeComponent();
            BuscarDispositivos();
        }

        public void CargarDispositivos(FilterInfoCollection Dispositivos)
        {
            for (int i = 0; i < Dispositivos.Count; i++)
            {
                cboDispositivos.Items.Add(Dispositivos[i].Name.ToString());
            }
            cboDispositivos.Text = cboDispositivos.Items[0].ToString();
        }

        public void BuscarDispositivos()
        {
            DispositivosDeVideo = new FilterInfoCollection(FilterCategory.VideoInputDevice);
            if (DispositivosDeVideo.Count == 0)
                ExistenDispositivos = false;
            else
            {
                ExistenDispositivos = true;
                CargarDispositivos(DispositivosDeVideo);
            }
        }

        public void TerminarFuenteDeVideo()
        {
            if (!(FuenteDeVideo == null))
                if (FuenteDeVideo.IsRunning)
                {
                    FuenteDeVideo.SignalToStop();
                    FuenteDeVideo = null;
                }
        }

        private void video_NuevoFrame(object sender, NewFrameEventArgs eventArgs)
        {
            Bitmap Imagen = (Bitmap)eventArgs.Frame.Clone();
            EspacioCamara.Image = Imagen;
        }

        private void btnIniciar_Click(object sender, EventArgs e)
        {
            if (btnIniciar.Text == "Iniciar")
            {
                if (ExistenDispositivos)
                {
                    FuenteDeVideo = new VideoCaptureDevice(DispositivosDeVideo[cboDispositivos.SelectedIndex].MonikerString);
                    FuenteDeVideo.NewFrame += new NewFrameEventHandler(video_NuevoFrame);
                    FuenteDeVideo.Start();
                    Estado.Text = " Ejecutando dispositivo";
                    btnIniciar.Text = "Detener";
                    cboDispositivos.Enabled = false;
                    groupBox1.Text = DispositivosDeVideo[cboDispositivos.SelectedIndex].Name.ToString();
                }
                else
                    Estado.Text = "Error: No se encuentra dispositivo.";
            }
            else
            {
                if (FuenteDeVideo.IsRunning)
                {
                    TerminarFuenteDeVideo();
                    Estado.Text = " Dispositivo detenido";
                    btnIniciar.Text = "Iniciar";
                    cboDispositivos.Enabled = true;
                }
            }
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SaveFileDialog Guardar = new SaveFileDialog();
            Guardar.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif";
            if (Guardar.ShowDialog() == DialogResult.OK)
                EspacioCamara.Image.Save(Guardar.FileName);
        }

        private void Tomar_Foto_CamaraWeb_FormClosing(object sender, FormClosingEventArgs e)
        {
            if (btnIniciar.Text == "Detener")
                btnIniciar_Click(sender, e);
        }
    }
}
