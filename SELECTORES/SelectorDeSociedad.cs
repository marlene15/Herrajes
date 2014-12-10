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
    public partial class SelectorDeSociedad : Form
    {
        public SelectorDeSociedad()
        {
            InitializeComponent();
        }

        private void h_SociedadesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
           
        }

        private void SelectorDeSociedad_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'herrajesDataSet.H_Sociedades' table. You can move, or remove it, as needed.
           // this.h_SociedadesTableAdapter.Fill(this.herrajesDataSet.H_Sociedades);
        }

        //Método para efectuar la búsqueda de las sociedades
        private void button1_Click(object sender, EventArgs e)
        {
            SqlConnection miconexion = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True");
            try
            {
                string ConsultaSQL = "SELECT * FROM H_Sociedades ORDER BY ID";
                miconexion.Open();
                BindingSource source1 = new BindingSource();
                SqlDataAdapter CustomerTableAdapter = new SqlDataAdapter(ConsultaSQL, miconexion);
                DataTable MiDataTable = new DataTable();
                CustomerTableAdapter.Fill(MiDataTable);
                source1.DataSource = MiDataTable;
                this.h_SociedadesBindingSource.DataSource = source1;
                source1.Filter = "RazonSocial LIKE '%" + this.BRazon.Text + "%'";
                miconexion.Close();
            }
            catch (Exception ex)
            {
                throw (ex);
            }        
        }

        private void button2_Click(object sender, EventArgs e)
        {
            Sociedad soc = new Sociedad();
            soc.Show();
        }
    }
}
