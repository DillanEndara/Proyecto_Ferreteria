using Capa_Negocio;
using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace Proyecto_Ferreteria
{
    public partial class Registro : Form
    {
        CNUsuario objetoCN = new CNUsuario();
        public Registro()
        {
            InitializeComponent();
        }

        private void butsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().ShowDialog();
            this.Close();
        }

        private void butagregar_Click(object sender, EventArgs e)
        {
            objetoCN.registrar(textBox2.Text, textBox3.Text, textBox6.Text,Convert.ToInt32(comboBox1.Text) , textBox5.Text, textBox1.Text, Convert.ToInt32(textBox4.Text));
            MessageBox.Show("Usuario registrado correctamente");
        }
    }
}
