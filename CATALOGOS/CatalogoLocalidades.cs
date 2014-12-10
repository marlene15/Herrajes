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
    public partial class CatalogoLocalidades : Form
    {
        public CatalogoLocalidades()
        {
            InitializeComponent();
        }

        private void h_LocalidadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.h_LocalidadesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.herrajesDataSet);

        }

        private void CatalogoLocalidades_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'herrajesDataSet.H_Localidades' table. You can move, or remove it, as needed.
            this.h_LocalidadesTableAdapter.Fill(this.herrajesDataSet.H_Localidades);

            //Carga los comboBox desde que se abre el programa 
            try
            {
                //Coloca los datos en el ComboBox1 de la tabla H_Municipios
                comboBox1.DataSource = GetData();
                comboBox1.DisplayMember = "Descripcion";
                comboBox1.ValueMember = "Descripcion";

                comboBox2.DataSource = GetData2();
                comboBox2.DisplayMember = "Descripcion";
                comboBox2.ValueMember = "Descripcion";

                h_LocalidadesBindingSource.DataSource = GetData3();
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }

        }

        //Este método recupera los datos de la tabla H_Estados
        private DataTable GetData()
        {
            try
            {         //Conexión a la base de datos               
                using (SqlConnection cnn = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True"))
                {
                    //Extrae los datos de la tabla H_Municipios
                    string sql = "SELECT Descripcion FROM H_Estados";
                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                    DataTable dt = new DataTable("H_Estados");
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

        //Este método recupera los datos de la tabla H_Municipios al darle clic en un Estado
        private DataTable GetData2()
        {
            try
            {
                int seleccionado = comboBox1.SelectedIndex + 1;
                //Conexión a la base de datos               
                using (SqlConnection cnn = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True"))
                {
                    //Extrae los datos de la tabla H_Municipios
                    string sql = "SELECT * FROM H_Municipios WHERE ID_Estado = " + seleccionado + "";
                    SqlDataAdapter da = new SqlDataAdapter(sql, cnn);
                    DataTable dt = new DataTable("H_Estados");
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

        //Este método carga las Localidades según el Municipio Seleccionado
        private DataTable GetData3()
        {
            try
            {
                int seleccionado = comboBox2.SelectedIndex + 1;
                //Conexión a la base de datos               
                using (SqlConnection cnn = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True"))
                {
                    //Extrae los datos de la tabla H_Municipios
                    string sql = "SELECT * FROM H_Localidades  WHERE Municipio_ID = " + seleccionado + "";
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

        private void comboBox1_SelectedIndexChanged(object sender, EventArgs e)
        {
            comboBox2.DataSource = GetData2();
            comboBox2.DisplayMember = "Descripcion";
            comboBox2.ValueMember = "Descripcion";  
        }

        private void comboBox2_SelectedIndexChanged(object sender, EventArgs e)
        {
            h_LocalidadesBindingSource.DataSource = GetData3();
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Dispose();
        }

    }
}
