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
    public partial class RegistroDeMovimiento : Form
    {
        public RegistroDeMovimiento()
        {
            InitializeComponent();
        }

        private void checkBox1_CheckedChanged(object sender, EventArgs e)
        {
            if(checkBox1.Checked==true)
                txtComentario.Enabled = true;
            else
                txtComentario.Enabled = false;
        }
    }
}
