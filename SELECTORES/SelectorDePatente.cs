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
    public partial class SelectorDePatente : Form
    {
        public SelectorDePatente()
        {
            InitializeComponent();
        }

        private void button2_Click(object sender, EventArgs e)
        {
            if (Principal.aux == 1)
            {
                RegistroDeMovimiento rm = new RegistroDeMovimiento();
                rm.Show();
            }
            else
            {
                if (Principal.aux == 2)
                {
                    //Aquí se pone el código para mandar a llamar el documento del historial
                }
                else
                {
                    if (Principal.aux == 3)
                    {
                        ReimpresionesDeDocumentos rd = new ReimpresionesDeDocumentos();
                        rd.Show();
                    }
                }
            }

        }

        private void ag_PatentesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {            

        }

        private void SelectorDePatente_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'herrajesDataSet.ag_PatentesGmenor' table. You can move, or remove it, as needed.
            this.ag_PatentesGmenorTableAdapter.Fill(this.herrajesDataSet.ag_PatentesGmenor);
            // TODO: This line of code loads data into the 'herrajesDataSet.ag_Patentes' table. You can move, or remove it, as needed.
            this.ag_PatentesTableAdapter.Fill(this.herrajesDataSet.ag_Patentes);

        }

        private void radioButton1_CheckedChanged(object sender, EventArgs e)
        {
            ag_PatentesDataGridView.Visible=true;
            ag_PatentesGmenorDataGridView.Visible = false;
        }

        private void radioButton2_CheckedChanged(object sender, EventArgs e)
        {
            ag_PatentesDataGridView.Visible = false;
            ag_PatentesGmenorDataGridView.Visible = true;           
        }

        private void ag_PatentesBindingNavigatorSaveItem_Click_1(object sender, EventArgs e)
        {
            this.Validate();
            this.ag_PatentesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.herrajesDataSet);

        }
    }
}
