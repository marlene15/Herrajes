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
    public partial class CatalogoPrecios : Form
    {
        public CatalogoPrecios()
        {
            InitializeComponent();
        }

        private void h_PreciosBindingNavigatorSaveItem_Click(object sender, EventArgs e)
        {
            this.Validate();
            this.h_PreciosBindingSource.EndEdit();
            this.tableAdapterManager.UpdateAll(this.herrajesDataSet);

        }

        private void CatalogoPrecios_Load(object sender, EventArgs e)
        {
            // TODO: This line of code loads data into the 'herrajesDataSet.H_Precios' table. You can move, or remove it, as needed.
            this.h_PreciosTableAdapter.Fill(this.herrajesDataSet.H_Precios);

        }

        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            this.Close();
        }
    }
}
