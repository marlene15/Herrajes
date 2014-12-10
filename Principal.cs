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
    public partial class Principal : Form
    {
        public Principal()
        {
            InitializeComponent();
            
        }

        public static int aux=0;

        //Método para Impedir que el formulario se cierre pulsando X o Alt + F4 
        private void Principal_FormClosing(object sender, FormClosingEventArgs e)
        {
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        //Mértodo para salir del sistema
        private void toolStripButton5_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void ganadoMayorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDePatenteGmayor rgm = new RegistroDePatenteGmayor();
            rgm.Show();
        }

        private void mantenimientoToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void refrendoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectorDePatente sp = new SelectorDePatente();
            sp.Show();
        }

        private void administrarInformaciónDePropietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {

        }

        private void municipiosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CatalogoMunicipios cm = new CatalogoMunicipios();
            cm.Show();
        }

        private void localidadesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CatalogoLocalidades cl = new CatalogoLocalidades();
            cl.Show();
        }

        private void secretariosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CatalogoSecretarios cs = new CatalogoSecretarios();
            cs.Show();
        }

        private void relacionesToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CatalogoRelaciones cr = new CatalogoRelaciones();
            cr.Show();
        }

        private void preciosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CatalogoPrecios cp = new CatalogoPrecios();
            cp.Show();
        }

        private void buscarFierroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            BusquedaDeFierro bf = new BusquedaDeFierro();
            bf.Show();
        }

        private void toolStripButton4_Click(object sender, EventArgs e)
        {
            CorteDeCaja cc = new CorteDeCaja();
            cc.Show();
        }

        private void municipiosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoMunicipios cm = new CatalogoMunicipios();
            cm.Show();
        }

        private void localidadesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoLocalidades cl = new CatalogoLocalidades();
            cl.Show();
        }

        private void secretariosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoSecretarios cs = new CatalogoSecretarios();
            cs.Show();
        }

        private void relacionesToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoRelaciones cr = new CatalogoRelaciones();
            cr.Show();
        }

        private void preciosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoPrecios cp = new CatalogoPrecios();
            cp.Show();
        }

        private void ganadoMayorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroDePatenteGmayor rgm = new RegistroDePatenteGmayor();
            rgm.Show();
        }

        private void ganadoMenorToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDePatenteGMenorA rgma = new RegistroDePatenteGMenorA();
            rgma.Show();
        }

        private void ganadoMenorBToolStripMenuItem_Click(object sender, EventArgs e)
        {
            RegistroDePatenteGMenorB rgmb = new RegistroDePatenteGMenorB();
            rgmb.Show();
        }

        private void toolStripButton2_Click(object sender, EventArgs e)
        {
            BusquedaDeFierro bf = new BusquedaDeFierro();
            bf.Show();
        }

        private void cambioDePropietarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectorDePatente sp = new SelectorDePatente();
            sp.Show();
            aux = 1;
        }

        private void cambioDeBeneficiarioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectorDePatente sp = new SelectorDePatente();
            sp.Show();
            aux = 1;
        }

        private void cambioDeFierroToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectorDePatente sp = new SelectorDePatente();
            sp.Show();
            aux = 1;
        }

        private void cambioDeMunicipioToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectorDePatente sp = new SelectorDePatente();
            sp.Show();
            aux = 1;
        }

        private void cANCELARToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectorDePatente sp = new SelectorDePatente();
            sp.Show();
            aux = 1;
        }

        private void ganaderoToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectorDePersonas sp = new SelectorDePersonas();
            sp.Show();
        }

        private void sociedadToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            SelectorDeSociedad ss = new SelectorDeSociedad();
            ss.Show();
        }

        private void historialToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectorDePatente sp = new SelectorDePatente();
            sp.Show();
            aux = 2;
        }

        private void ganaderoToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectorDePersonas sp = new SelectorDePersonas();
            sp.Show();
        }

        private void sociedadToolStripMenuItem_Click(object sender, EventArgs e)
        {
            SelectorDeSociedad ss = new SelectorDeSociedad();
            ss.Show();
        }

        private void toolStripButton3_Click(object sender, EventArgs e)
        {
            SelectorDePatente sp = new SelectorDePatente();
            sp.Show();
            aux = 3;
        }

        private void ganadoMenorToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroDePatenteGMenorA rgma = new RegistroDePatenteGMenorA();
            rgma.Show();
        }

        private void ganadoMenorBToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            RegistroDePatenteGMenorB gmb = new RegistroDePatenteGMenorB();
            gmb.Show();
        }

        private void toolStripButton1_Click(object sender, EventArgs e)
        {
            SelectorDePatente sp = new SelectorDePatente();
            sp.Show();
        }

        private void estadosToolStripMenuItem_Click(object sender, EventArgs e)
        {
            CatalogoEstados ce = new CatalogoEstados();
            ce.Show();
        }

        private void estadosToolStripMenuItem1_Click(object sender, EventArgs e)
        {
            CatalogoEstados ce = new CatalogoEstados();
            ce.Show();
        }

    }
}
