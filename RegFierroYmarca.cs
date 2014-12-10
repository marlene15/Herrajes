using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Herrajes
{
    public partial class RegFierroYmarca : Form
    {
        public RegFierroYmarca()
        {
            InitializeComponent();
        }

        //Muestra la ventana para seleccionar una imagén desde la pc
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
        }

        //Muestra la ventana para seleccionar una imagén desde la pc
        private void button2_Click(object sender, EventArgs e)
        {
            openFileDialog2.ShowDialog();
            pictureBox2.Image = System.Drawing.Image.FromFile(openFileDialog2.FileName);
        }

        private void button5_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("Cargue una imagen");
            }
            else
            {
                Image bmp = this.pictureBox1.Image;
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox1.Image = bmp;
            }
        }

        private void button6_Click(object sender, EventArgs e)
        {
            if (pictureBox1.Image == null)
            {
                MessageBox.Show("No hay imagen para descargar");
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|All files (*.*)|*.*";
                save.FilterIndex = 4;
                save.RestoreDirectory = true;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    pictureBox1.Image.Save(save.FileName);
                }
            }
        }

        private void button7_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("Cargue una imagen");
            }
            else
            {
                Image bmp = this.pictureBox2.Image;
                bmp.RotateFlip(RotateFlipType.Rotate90FlipNone);
                pictureBox2.Image = bmp;
            }
        }

        private void button3_Click(object sender, EventArgs e)
        {
            if (pictureBox2.Image == null)
            {
                MessageBox.Show("No hay imagen para descargar");
            }
            else
            {
                SaveFileDialog save = new SaveFileDialog();
                save.Filter = "Bitmap files (*.bmp)|*.bmp|JPG files (*.jpg)|*.jpg|GIF files (*.gif)|*.gif|All files (*.*)|*.*";
                save.FilterIndex = 4;
                save.RestoreDirectory = true;
                if (save.ShowDialog() == DialogResult.OK)
                {
                    pictureBox2.Image.Save(save.FileName);
                }
            }
        }
    }
}
