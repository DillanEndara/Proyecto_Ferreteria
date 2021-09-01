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
                objetoCN.registrar(txtnom.Text, txtape.Text, txtcor.Text, cmbrol.SelectedValue.ToString(), txtcon.Text, txtced.Text, txttel.Text);
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
            cmbrol.DisplayMember = "nombreRol";
            cmbrol.ValueMember = "idRol";
            cmbrol.DataSource = objetoCN.listarRol();
        }
    }
}
