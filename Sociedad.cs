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
    public partial class Sociedad : Form
    {
        public Sociedad()
        {
            InitializeComponent();
        }

        private void label31_Click(object sender, EventArgs e)
        {

        }

        private void button6_Click(object sender, EventArgs e)
        {

        }

        //Este método recupera los datos de la tabla H_Municipios
        private DataTable GetData()
        {
            try
            {                                    //Conexión a la base de datos             
                using (SqlConnection cnn = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True"))
                {
                    //Extrae los datos de la tabla H_Municipios
                    string sql = "SELECT Municipio FROM H_Municipios";
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
                    string sql2 = "SELECT Localidad FROM H_Localidades";
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

        private void metodo_Load(object sender, EventArgs e)
        {
            try
            {
                //Coloca los datos en el ComboBox1 de la tabla H_Municipios
                comboBox8.DataSource = GetData();
                comboBox8.DisplayMember = "Municipio";
                comboBox8.ValueMember = "Municipio";

                //Coloca los datos en el ComboBox2 de la tabla H_Localidades
                comboBox9.DataSource = GetData2();
                comboBox9.DisplayMember = "Localidad";
                comboBox9.ValueMember = "Localidad";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
