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
    public partial class CatalogoSecretarios : Form
    {
        public CatalogoSecretarios()
        {
            InitializeComponent();
        }

        private void h_SecretariosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.h_SecretariosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.herrajesDataSet);
        }

        private void CatalogoSecretarios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'herrajesDataSet.H_Secretarios' table. You can move, or remove it, as needed.
            this.h_SecretariosTableAdapter.Fill(this.herrajesDataSet.H_Secretarios);            
        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
