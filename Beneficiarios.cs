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
    public partial class Beneficiarios : Form
    {
        public Beneficiarios()
        {           
            InitializeComponent();
            button3.Enabled = false;
            button4.Enabled = false;
        }

        private void button1_Click(object sender, EventArgs e)
        {
            label1.Visible = true;
            comboBox1.Visible = true;
            SelectorDePersonas sp = new SelectorDePersonas();
            button3.Enabled = true;
            sp.Show();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            label2.Visible = true;
            comboBox2.Visible = true;
            SelectorDePersonas sp = new SelectorDePersonas();
            button4.Enabled = true;
            sp.Show();
        }

        //Este método recupera los datos de la tabla H_Relaciones
        private DataTable GetData()
        {
            try
            {
                using (SqlConnection cnn = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True"))
                {
                    //Extrae los datos de la tabla H_Relaciones                   
                    string sql2 = "SELECT Descripcion FROM H_Relaciones";
                    SqlDataAdapter ba = new SqlDataAdapter(sql2, cnn);
                    DataTable dt2 = new DataTable("H_Relaciones");
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
                comboBox1.DataSource = GetData();
                comboBox1.DisplayMember = "Descripcion";
                comboBox1.ValueMember = "Descripcion";

                //Coloca los datos en el ComboBox1 de la tabla H_Municipios
                comboBox2.DataSource = GetData();
                comboBox2.DisplayMember = "Descripcion";
                comboBox2.ValueMember = "Descripcion";
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }

        private void label1_Click(object sender, EventArgs e)
        {

        }

        private void button4_Click(object sender, EventArgs e)
        {
            comboBox2.Visible = false;
            label2.Visible = false;
            button4.Enabled = false;
        }

        private void button3_Click(object sender, EventArgs e)
        {
            comboBox1.Visible = false;
            label1.Visible = false;
            button3.Enabled = false;
        }
    }
}
