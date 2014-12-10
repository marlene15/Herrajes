using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;
using System.Data.SqlClient;
using System.IO;

namespace Herrajes
{
    public partial class RegistroDePatenteGMenorB : Form
    {
        public RegistroDePatenteGMenorB()
        {
            InitializeComponent();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            SelectorDePersonas sepe = new SelectorDePersonas();
            sepe.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            SelectorDeSociedad ss = new SelectorDeSociedad();
            ss.Show();
        }

        private void button5_Click(object sender, EventArgs e)
        {
            Beneficiarios benef = new Beneficiarios();
            benef.Show();   
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SelectorDePersonas sp = new SelectorDePersonas();
            sp.Show();
        }

        //Método que muestra el mapa de los Municipios segun se seleccionen en el ComboBox1
        private void seleccionado(object sender, EventArgs e)
        {
            if (comboBox1.Text == "Armería")
            {
                armeria_imagen.Visible = true;
                colima_imagen.Visible = false;
                comala_imagen.Visible = false;
                imagen_coqui.Visible = false;
                cuahutemoc_imagen.Visible = false;
                ixtlahuacan_imagen.Visible = false;
                manzanillo_imagen.Visible = false;
                minatitlan_imagen.Visible = false;
                tecoman_imagen.Visible = false;
                villadealvarez_imagen.Visible = false;
            }
            else
            {
                if (comboBox1.Text == "Colima")
                {
                    colima_imagen.Visible = true;
                    armeria_imagen.Visible = false;
                    comala_imagen.Visible = false;
                    imagen_coqui.Visible = false;
                    cuahutemoc_imagen.Visible = false;
                    ixtlahuacan_imagen.Visible = false;
                    manzanillo_imagen.Visible = false;
                    minatitlan_imagen.Visible = false;
                    tecoman_imagen.Visible = false;
                    villadealvarez_imagen.Visible = false;
                }
                else
                {
                    if (comboBox1.Text == "Comala")
                    {
                        comala_imagen.Visible = true;
                        armeria_imagen.Visible = false;
                        colima_imagen.Visible = false;
                        imagen_coqui.Visible = false;
                        cuahutemoc_imagen.Visible = false;
                        ixtlahuacan_imagen.Visible = false;
                        manzanillo_imagen.Visible = false;
                        minatitlan_imagen.Visible = false;
                        tecoman_imagen.Visible = false;
                        villadealvarez_imagen.Visible = false;
                    }
                    else
                    {
                        if (comboBox1.Text == "Coquimatlán")
                        {
                            imagen_coqui.Visible = true;
                            armeria_imagen.Visible = false;
                            colima_imagen.Visible = false;
                            comala_imagen.Visible = false;
                            cuahutemoc_imagen.Visible = false;
                            ixtlahuacan_imagen.Visible = false;
                            manzanillo_imagen.Visible = false;
                            minatitlan_imagen.Visible = false;
                            tecoman_imagen.Visible = false;
                            villadealvarez_imagen.Visible = false;
                        }
                        else
                        {
                            if (comboBox1.Text == "Cuauhtémoc")
                            {
                                cuahutemoc_imagen.Visible = true;
                                imagen_coqui.Visible = false;
                                armeria_imagen.Visible = false;
                                colima_imagen.Visible = false;
                                comala_imagen.Visible = false;
                                ixtlahuacan_imagen.Visible = false;
                                manzanillo_imagen.Visible = false;
                                minatitlan_imagen.Visible = false;
                                tecoman_imagen.Visible = false;
                                villadealvarez_imagen.Visible = false;
                            }
                            else
                            {
                                if (comboBox1.Text == "Ixtlahuacán")
                                {
                                    ixtlahuacan_imagen.Visible = true;
                                    cuahutemoc_imagen.Visible = false;
                                    imagen_coqui.Visible = false;
                                    armeria_imagen.Visible = false;
                                    colima_imagen.Visible = false;
                                    comala_imagen.Visible = false;
                                    manzanillo_imagen.Visible = false;
                                    minatitlan_imagen.Visible = false;
                                    tecoman_imagen.Visible = false;
                                    villadealvarez_imagen.Visible = false;
                                }
                                else
                                {
                                    if (comboBox1.Text == "Manzanillo")
                                    {
                                        manzanillo_imagen.Visible = true;
                                        ixtlahuacan_imagen.Visible = false;
                                        cuahutemoc_imagen.Visible = false;
                                        imagen_coqui.Visible = false;
                                        armeria_imagen.Visible = false;
                                        colima_imagen.Visible = false;
                                        comala_imagen.Visible = false;
                                        minatitlan_imagen.Visible = false;
                                        tecoman_imagen.Visible = false;
                                        villadealvarez_imagen.Visible = false;

                                    }
                                    else
                                    {
                                        if (comboBox1.Text == "Minatitlán")
                                        {
                                            minatitlan_imagen.Visible = true;
                                            manzanillo_imagen.Visible = false;
                                            ixtlahuacan_imagen.Visible = false;
                                            cuahutemoc_imagen.Visible = false;
                                            imagen_coqui.Visible = false;
                                            armeria_imagen.Visible = false;
                                            colima_imagen.Visible = false;
                                            comala_imagen.Visible = false;
                                            tecoman_imagen.Visible = false;
                                            villadealvarez_imagen.Visible = false;
                                        }
                                        else
                                        {
                                            if (comboBox1.Text == "Tecomán")
                                            {
                                                tecoman_imagen.Visible = true;
                                                minatitlan_imagen.Visible = false;
                                                manzanillo_imagen.Visible = false;
                                                ixtlahuacan_imagen.Visible = false;
                                                cuahutemoc_imagen.Visible = false;
                                                imagen_coqui.Visible = false;
                                                armeria_imagen.Visible = false;
                                                colima_imagen.Visible = false;
                                                comala_imagen.Visible = false;
                                                villadealvarez_imagen.Visible = false;

                                            }
                                            else
                                            {
                                                if (comboBox1.Text == "Villa de Álvarez")
                                                {
                                                    villadealvarez_imagen.Visible = true;
                                                    tecoman_imagen.Visible = false;
                                                    minatitlan_imagen.Visible = false;
                                                    manzanillo_imagen.Visible = false;
                                                    ixtlahuacan_imagen.Visible = false;
                                                    cuahutemoc_imagen.Visible = false;
                                                    imagen_coqui.Visible = false;
                                                    armeria_imagen.Visible = false;
                                                    colima_imagen.Visible = false;
                                                    comala_imagen.Visible = false;

                                                }
                                            }
                                        }

                                    }
                                }
                            }
                        }

                    }

                }

            }
        }

        //Este método recupera los datos de la tabla H_Localidades
        private DataTable GetData()
        {
            try
            {
                int seleccionado = comboBox1.SelectedIndex + 1;
                //Conexión a la base de datos               
                using (SqlConnection cnn = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True"))
                {
                    //Extrae los datos de la tabla H_Municipios
                    string sql = "SELECT Descripcion FROM H_Localidades WHERE Municipio_ID = " + seleccionado + "";
                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                    DataTable dt = new DataTable("H_Localidades");
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


        //Este método recupera los datos de la tabla H_Municipios
        private DataTable GetData2()
        {
            try
            {
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
        private void GetData3()
        {
            try
            {
                byte[] m_imagen = new byte[0];

                SqlConnection m_SqlConnection = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True");
                SqlCommand m_SqlCommand = new SqlCommand("select Imagen from H_Municipios where Descripcion='" + comboBox1.SelectedValue.ToString() + "'", m_SqlConnection);
                SqlDataAdapter m_SqlDataAdapter = new SqlDataAdapter(m_SqlCommand);

                MessageBox.Show(comboBox1.SelectedValue.ToString());

                DataSet ds = new DataSet();
                m_SqlDataAdapter.Fill(ds, "H_Municipios");
                

                //Aqui simplemente revertimos la conversion que realizamos a guardar
                m_imagen = (byte[])ds.Tables["H_Municipios"].Rows[0]["Imagen"];
                MemoryStream m_MemoryStream = new MemoryStream(m_imagen);
                //pictureBox8.Image = Image.FromStream(m_MemoryStream);
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
                throw;
            }
        }

        //Método que carga los comboBox desde que se abre el programa 
        private void RegistroDePatente_Load(object sender, EventArgs e)
        {
            try
            {
                
                //Coloca los datos en el ComboBox1 de la tabla H_Localidades
                comboBox1.DataSource = GetData2();
                comboBox1.DisplayMember = "Descripcion";
                comboBox1.ValueMember = "Descripcion";

                //Coloca los datos en el ComboBox2 de la tabla H_Municipios
                comboBox2.DataSource = GetData();
                comboBox2.DisplayMember = "Descripcion";
                comboBox2.ValueMember = "Descripcion";

               // GetData3();
                
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void timer1_Tick(object sender, EventArgs e)
        {
            toolStripStatusLabel1.Text = DateTime.Now.ToShortDateString().ToString() + " - " + DateTime.Now.ToLongTimeString().ToString();
        }

        private void button3_Click(object sender, EventArgs e)
        {
            ManifestacionPecuariaGMenorB gmb = new ManifestacionPecuariaGMenorB();
            gmb.Show();
        }

        private void panel2_Paint(object sender, PaintEventArgs e)
        {

        }

        private void button15_Click(object sender, EventArgs e)
        {
            string c;
            c= comboBox1.SelectedValue.ToString();
            MessageBox.Show(c);
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SelectorDePersonas sp = new SelectorDePersonas();
            sp.Show();
        }
    }
}
