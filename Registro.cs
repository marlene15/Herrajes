using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;


namespace Herrajes
{
    public partial class Registro : Form
    {
        public Registro()
        {
            InitializeComponent();
            textBox5.Text = "XXXX000000MXXXXX00";
        }

        //Muestra la ventana para seleccionar una imagén desde la pc
        private void button1_Click(object sender, EventArgs e)
        {
            openFileDialog1.ShowDialog();
            pictureBox1.Image = System.Drawing.Image.FromFile(openFileDialog1.FileName);
        }

        //Este método recupera los datos de la tabla H_Municipios
        private DataTable GetData()
        {           
            try
            {   //Conexión a la base de datos             
                using (SqlConnection cnn = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True"))
                {
                    //Extrae los datos de la tabla H_Municipios
                    string sql = "SELECT Descripcion FROM H_Municipios";                    
                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                    DataTable dt = new DataTable("H_Municipios");                    
                    da.Fill(dt);
                    return dt;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }


        //Este método recupera los datos de la tabla H_Localidades
        private DataTable GetData2()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True"))
                {
                    //Extrae los datos de la tabla H_Localidades                    
                    string sql2 = "SELECT Descripcion FROM H_Localidades";
                    SqlDataAdapter ba = new SqlDataAdapter(sql2, cnn);
                    DataTable dt2 = new DataTable("H_Localidades");
                    ba.Fill(dt2);
                    return dt2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }            
        }

        //Este método recupera los datos de la tabla H_Estados
        private DataTable GetData3()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True"))
                {
                    //Extrae los datos de la tabla H_Localidades                    
                    string sql2 = "SELECT Descripcion FROM H_Estados";
                    SqlDataAdapter ba = new SqlDataAdapter(sql2, cnn);
                    DataTable dt2 = new DataTable("H_Estados");
                    ba.Fill(dt2);
                    return dt2;
                }
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        private void metodo_Load(object sender, EventArgs e)
        {   
            try
            {
                //Coloca los datos en el ComboBox4 de la tabla H_Estados
                comboBox4.DataSource = GetData3();
                comboBox4.DisplayMember = "Descripcion";
                comboBox4.ValueMember = "Descripcion";

                //Coloca los datos en el ComboBox5 de la tabla H_Municipios
                comboBox5.DataSource = GetData();              
                comboBox5.DisplayMember = "Descripcion";
                comboBox5.ValueMember = "Descripcion";

                //Coloca los datos en el ComboBox6 de la tabla H_Localidades
                comboBox6.DataSource = GetData2();
                comboBox6.DisplayMember = "Descripcion";
                comboBox6.ValueMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void toolStrip1_ItemClicked(object sender, ToolStripItemClickedEventArgs e)
        {

        }

        private void button2_Click(object sender, EventArgs e)
        {
            Tomar_Foto_CamaraWeb tf = new Tomar_Foto_CamaraWeb();
            tf.Show();
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
    }
}
