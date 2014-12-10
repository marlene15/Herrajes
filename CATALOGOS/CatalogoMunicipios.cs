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
    public partial class CatalogoMunicipios : Form
    {
        //Variable declarada para la conexion
        SqlConnection cn = new SqlConnection();

        int index = 0;
        string dato_a_modificar = ""; 

        public CatalogoMunicipios()
        {
            InitializeComponent();
        }

        private void h_MunicipiosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.h_MunicipiosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.herrajesDataSet);

        }

        private void CatalogoMunicipios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'herrajesDataSet.H_Municipios' table. You can move, or remove it, as needed.
            this.h_MunicipiosTableAdapter.Fill(this.herrajesDataSet.H_Municipios);
            
            cn.ConnectionString = "Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True";
            // en cn.connectionstring pones tu base de datos

            //Carga los comboBox desde que se abre el programa 
            try
            {
                //Coloca los datos en el ComboBox1 de la tabla H_Municipios
                comboBox1.DataSource = GetData();
                comboBox1.DisplayMember = "Descripcion";
                comboBox1.ValueMember = "Descripcion";

                h_MunicipiosBindingSource.DataSource = GetData2();
               
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

        //Este método recupera los datos de la tabla H_Estados al iniciar el Cátalogo de Municipios
        private DataTable GetData2()
        {
            try
            {
                int seleccionado = comboBox1.SelectedIndex + 1;
                //Conexión a la base de datos               
                using (SqlConnection cnn = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True"))
                {
                    //Extrae los datos de la tabla H_Municipios
                    string sql = "SELECT * FROM H_Municipios WHERE ID_Estado = "+seleccionado+"";                    
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


        //Cierra la ventana de Municipios
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //Código para guardar un registro nuevo
            if (index == 1)
            {
                int seleccionado=comboBox1.SelectedIndex+1;
                string sql = "", Municipio = "";
                try
                {
                    cn.Open();
                    Municipio = this.municipio.Text;
                    sql = "insert into H_Municipios values("+seleccionado+",'" + Municipio + "',null,"+seleccionado+")";                    
                    SqlCommand cmd = new SqlCommand(sql, cn);
                    cmd.ExecuteNonQuery();
                    MessageBox.Show("Registro realizado");
                   // this.h_MunicipiosTableAdapter.Update(this.herrajesDataSet.H_Municipios);                    
                    captura.Visible = false;                    
                }
                catch (Exception ex)
                {
                    MessageBox.Show(ex.Message);
                }
                finally
                {
                    if (cn.State == ConnectionState.Open)
                        cn.Close();
                }
            }
            else
            {
                //Código para modificar el registro seleccionado
                if (index == 2)
                {
                    try
                    {
                        cn.ConnectionString = "Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True";
                        // en cn.connectionstring pones tu base de datos
                        cn.Open();
                        String actualiza = "UPDATE H_Municipios SET Descripcion='" + municipio.Text + "'WHERE Descripcion='" + dato_a_modificar + "'";
                        SqlCommand cmd = cn.CreateCommand();
                        cmd.Connection = cn;
                        cmd.CommandText = actualiza;
                        cmd.ExecuteNonQuery();
                        MessageBox.Show("Registro modificado");                   
                        //this.tableAdapterManager.UpdateAll(this.herrajesDataSet);
                        captura.Visible = false;                        
                    }
                    catch (Exception ex)
                    {
                        MessageBox.Show("ERROR al conectar a la base de datos:  \n" + ex.Message);
                    }
                    finally
                    {
                        cn.Close();
                    }
                }

            }
            this.h_MunicipiosTableAdapter.Update(this.herrajesDataSet.H_Municipios);
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            captura.Visible = true;
            index = 1;
        }

        //Pasa los datos del registro seleccionado a la caja de texto municipios para poder ser editado
        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            index = 2;
            captura.Visible = true;
            dato_a_modificar = h_MunicipiosDataGridView.Rows[h_MunicipiosDataGridView.CurrentRow.Index].Cells[2].Value.ToString();
            municipio.Text = dato_a_modificar; 
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            //Boton de Cancelar
            captura.Visible = false;

        }

        //Este método recupera los datos de la tabla H_Localidades al selleccionar un dato en el Combobox1
        private void metodo_seleccion_de_datos(object sender, EventArgs e)
        {
              h_MunicipiosBindingSource.DataSource = GetData2();          
        }

    }
}
