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
    public partial class ManifestacionPecuariaGMenorB : Form
    {
        public ManifestacionPecuariaGMenorB()
        {
            InitializeComponent();
        }

        public void suma_Manifestacion()
        {
            int uno, dos, tres, cuatro, cinco, seis,siete;
            uno = Convert.ToInt16(numericUpDown1.Value.ToString());
            dos = Convert.ToInt16(numericUpDown2.Value.ToString());
            tres = Convert.ToInt16(numericUpDown3.Value.ToString());
            cuatro = Convert.ToInt16(numericUpDown4.Value.ToString());
            cinco = Convert.ToInt16(numericUpDown5.Value.ToString());
            seis = Convert.ToInt16(numericUpDown6.Value.ToString());
            siete = Convert.ToInt16(numericUpDown7.Value.ToString());
            total.Text = Convert.ToString(uno + dos + tres + cuatro + cinco + seis + siete);
        }

        private void metodo_enter(object sender, EventArgs e)
        {
            suma_Manifestacion();
        }
    }
}
