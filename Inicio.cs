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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        SqlConnection miconexion = new SqlConnection("Data Source=MARLENE-HP;Initial Catalog=Herrajes;Integrated Security=True");

        //Método para Impedir que el formulario se cierre pulsando X o Alt + F4 
        private void Inicio_FormClosing(object sender, FormClosingEventArgs e)
        {           
            switch (e.CloseReason)
            {
                case CloseReason.UserClosing:
                    e.Cancel = true;
                    break;
            }
        }

        //Se hace la conexion a la base de datos para permitir el acceso a usuarios registrados
        public void acceso()
        {
            try
            {
                miconexion.Open();
                SqlCommand consulta = new SqlCommand("select * from H_Personas where Nombre = '" + txtNombre.Text + "' and Paterno = '" + txtPassword.Text + "' ", miconexion);
                SqlDataReader ejecuta = consulta.ExecuteReader();

                if (ejecuta.Read() == true)
                {
                    MessageBox.Show("Bienvenido " + txtNombre.Text);
                    this.Hide();
                    Principal p = new Principal();
                    p.Show();
                }
                else
                {
                    MessageBox.Show("Acceso denegado");
                    txtNombre.Clear();
                    txtPassword.Clear();
                    txtNombre.Focus();
                }
            }
            catch (Exception Exp)
            {
                MessageBox.Show(Exp.Message, "Error General");
            }
            miconexion.Close();
        }

        //Método para salir del sistema
        private void button2_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }            

        private void Form1_Load(object sender, EventArgs e)
        {

        }

        //Método que permite el acceso a la pantalla Principal
        private void btn_Iniciar_Click(object sender, EventArgs e)
        {
            acceso();
        }

        private void txtPassword_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.KeyCode == Keys.Enter)
            {
                acceso();
            }
        }
    }
}
