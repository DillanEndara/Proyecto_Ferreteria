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
            try
            {
                objetoCN.registrar(textBox2.Text, textBox3.Text, textBox6.Text, comboBox1.SelectedValue.ToString(), textBox5.Text, textBox1.Text, textBox4.Text);
                MessageBox.Show("Usuario registrado correctamente");
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo registrar el usuario");
                throw;
            }
        }

        private void Registro_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "nombreRol";
            comboBox1.ValueMember = "idRol";
            comboBox1.DataSource = objetoCN.listarRol();
        }
    }
}
