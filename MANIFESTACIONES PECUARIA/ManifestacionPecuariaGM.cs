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
    public partial class ManifestacionPecuariaGM : Form
    {
        public ManifestacionPecuariaGM()
        {
            InitializeComponent();          
        }

        private void textBox18_TextChanged(object sender, EventArgs e)
        {
            
        }

        public void suma_Manifestacion()
        {
            int uno, dos, tres, cuatro, cinco, seis, siete, ocho, nueve, diez, once, doce, trece, catorce;
            uno = Convert.ToInt16(numericUpDown1.Value.ToString());
            dos = Convert.ToInt16(numericUpDown2.Value.ToString());
            tres = Convert.ToInt16(numericUpDown3.Value.ToString());
            cuatro = Convert.ToInt16(numericUpDown4.Value.ToString());
            cinco = Convert.ToInt16(numericUpDown5.Value.ToString());
            seis = Convert.ToInt16(numericUpDown6.Value.ToString());
            siete = Convert.ToInt16(numericUpDown7.Value.ToString());
            ocho = Convert.ToInt16(numericUpDown8.Value.ToString());
            nueve = Convert.ToInt16(numericUpDown9.Value.ToString());
            diez = Convert.ToInt16(numericUpDown10.Value.ToString());
            once = Convert.ToInt16(numericUpDown11.Value.ToString());
            doce = Convert.ToInt16(numericUpDown12.Value.ToString());
            trece = Convert.ToInt16(numericUpDown13.Value.ToString());
            catorce = Convert.ToInt16(numericUpDown14.Value.ToString());
            total.Text = Convert.ToString(uno + dos + tres + cuatro + cinco + seis + siete + ocho + nueve + diez + once + doce + trece + catorce);
        }

        private void metodo_enter(object sender, EventArgs e)
        {
            suma_Manifestacion();
        }

        
    }
}
