using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Windows.Forms;

namespace Herrajes
{
    public partial class ManifestacionPecuariaGMenorA : Form
    {
        public ManifestacionPecuariaGMenorA()
        {
            InitializeComponent();
        }

        private void h_ApiariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.h_ApiariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.herrajesDataSet);
        }

        private void ManifestacionPecuariaGMenorA_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'herrajesDataSet.H_Apiarios' table. You can move, or remove it, as needed.
            this.h_ApiariosTableAdapter.Fill(this.herrajesDataSet.H_Apiarios);
            //Pone las etiquetas a los botones al acercar el Mouse
            this.toolTip1.SetToolTip(this.button1,"Agregar Apiario");
            this.toolTip1.SetToolTip(this.button2, "Eliminar Apiario"); 
        }

        public void suma_Manifestacion()
        {
            int uno, dos, tres, cuatro, cinco, seis;
            uno = Convert.ToInt16(numericUpDown1.Value.ToString());
            dos = Convert.ToInt16(numericUpDown2.Value.ToString());
            tres = Convert.ToInt16(numericUpDown3.Value.ToString());
            cuatro = Convert.ToInt16(numericUpDown4.Value.ToString());
            cinco = Convert.ToInt16(numericUpDown5.Value.ToString());
            seis = Convert.ToInt16(numericUpDown6.Value.ToString());            
            total.Text = Convert.ToString(uno + dos + tres + cuatro + cinco + seis);
        }

        private void metodo_enter(object sender, EventArgs e)
        {
            suma_Manifestacion();
        }

        private void button1_Click(object sender, EventArgs e)
        {
            AgregarApiario ap = new AgregarApiario();
            ap.Show();
        }

        private void groupBox1_Enter(object sender, EventArgs e)
        {

        }
    }
}
