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
    public partial class CatalogoEstados : Form
    {
        //Variable declarada para la conexion
        SqlConnection cn = new SqlConnection();

        int index = 0;
        string dato_a_modificar1 = "";
        string dato_a_modificar2 = "";

        public CatalogoEstados()
        {
            InitializeComponent();
        }

        private void h_EstadosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.h_EstadosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.herrajesDataSet);

        }

        private void CatalogoEstados_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'herrajesDataSet.H_Estados' table. You can move, or remove it, as needed.
            this.h_EstadosTableAdapter.Fill(this.herrajesDataSet.H_Estados);

        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            index = 2;
            captura.Visible = true;
            dato_a_modificar1 = h_EstadosDataGridView.Rows[h_EstadosDataGridView.CurrentRow.Index].Cells[2].Value.ToString();
            estado.Text = dato_a_modificar1;
            dato_a_modificar2 = h_EstadosDataGridView.Rows[h_EstadosDataGridView.CurrentRow.Index].Cells[3].Value.ToString();
            capital.Text = dato_a_modificar2;
            
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            captura.Visible = true;
            index = 1;
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            //Código para guardar un registro nuevo
           /* if (index == 1)
            {
                int seleccionado = comboBox1.SelectedIndex + 1;
                string sql = "", Estado = "";
                try
                {
                    cn.Open();
                    Estado = this.estado.Text;
                    sql = "insert into H_Estados values(" + seleccionado + ",'" + Municipio + "',null," + seleccionado + ")";
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
                        String actualiza = "UPDATE H_Estados SET Descripcion='" + estado.Text + "'WHERE Descripcion='" + dato_a_modificar + "'";
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
            this.h_EstadosTableAdapter.Update(this.herrajesDataSet.H_Estados);*/
        }
    }
}
