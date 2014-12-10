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
    public partial class RegistroDePatenteGMenorA : Form
    {
        public RegistroDePatenteGMenorA()
        {
            InitializeComponent();
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

        //Método que abre la pantalla de selector de personas
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
            Beneficiarios ben = new Beneficiarios();
            ben.Show();

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

        //Método que carga los comboBox desde que se abre el programa 
        private void RegistroDePatente_Load(object sender, EventArgs e)
        {
            //Pone las etiquetas a los botones al acercar el Mouse
            this.toolTip1.SetToolTip(this.button1, "Agregar Ganadero");
            this.toolTip1.SetToolTip(this.button2, "Agregar Sociedad");
            this.toolTip1.SetToolTip(this.button3, "Agregar Manifestación Pecuaria");
            this.toolTip1.SetToolTip(this.button4, "Agregar Fierro Y Marca");
            this.toolTip1.SetToolTip(this.button5, "Agregar Beneficiarios");
            this.toolTip1.SetToolTip(this.button6, "Agregar Testigo 1");
            this.toolTip1.SetToolTip(this.button7, "Agregar Testigo 2");
            this.toolTip1.SetToolTip(this.button8,"Quitar Testigo 1");
            this.toolTip1.SetToolTip(this.button9,"Quitar Testigo 2");

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
            ManifestacionPecuariaGMenorA mgma = new ManifestacionPecuariaGMenorA();
            mgma.Show();
        }

        private void button4_Click(object sender, EventArgs e)
        {
            RegFierroYmarca rfm = new RegFierroYmarca();
            rfm.Show();
        }

        private void button6_Click(object sender, EventArgs e)
        {
            SelectorDePersonas sp = new SelectorDePersonas();
            sp.Show();
        }

        private void button7_Click(object sender, EventArgs e)
        {
            SelectorDePersonas sp = new SelectorDePersonas();
            sp.Show();
        }


    }
}
        
