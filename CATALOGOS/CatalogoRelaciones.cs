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
    public partial class CatalogoRelaciones : Form
    {
        public CatalogoRelaciones()
        {
            InitializeComponent();
        }

        private void h_RelacionesBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.h_RelacionesBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.herrajesDataSet);

        }

        private void CatalogoRelaciones_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'herrajesDataSet.H_Relaciones' table. You can move, or remove it, as needed.
            this.h_RelacionesTableAdapter.Fill(this.herrajesDataSet.H_Relaciones);

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
