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
    public partial class SelectorDePersonas : Form
    {
        public SelectorDePersonas()
        {
            InitializeComponent();
        }

        private void h_PersonasBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void SelectorDePersonas_Load(object sender, EventArgs e)
        {           
            // TODO: This line of code loads data into the 'herrajesDataSet.H_Personas' table. You can move, or remove it, as needed.
          //  this.h_PersonasTableAdapter.Fill(this.herrajesDataSet.H_Personas);
        }       

        //Método para efectuar la búsqueda de personal
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection miconexion = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True");
            try
            {
                string ConsultaSQL = "SELECT * FROM H_Personas ORDER BY ID";
                miconexion.Open();
                BindingSource source1 = new BindingSource();
                SqlDataAdapter CustomerTableAdapter =   new SqlDataAdapter(ConsultaSQL, miconexion);
                DataTable MiDataTable = new DataTable();
                CustomerTableAdapter.Fill(MiDataTable);
                source1.DataSource = MiDataTable;
                this.h_PersonasBindingSource.DataSource = source1;
                source1.Filter = "Nombre LIKE '%" + this.BNombre.Text + "%'";
                miconexion.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Registro reg = new Registro();
            reg.Show();
        }      
       
    }
}
