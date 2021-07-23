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
    public partial class Inicio : Form
    {
        public Inicio()
        {
            InitializeComponent();
        }

        private void butingreso_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(txt_password.Text) && string.IsNullOrEmpty(txt_usuario.Text))
            {
                MessageBox.Show("Campos vacios..!! \nPor favor ingrese su informacion");
            }
            else if (string.IsNullOrEmpty(txt_usuario.Text))
            {
                MessageBox.Show("Usuario no ingresado");
            }
            else if (string.IsNullOrEmpty(txt_password.Text))
            {
                MessageBox.Show("Campo de contraseña no ingresado");
            }
            else
            {
                logear(txt_usuario.Text, txt_password.Text);
            }
        }

        private void logear(string usuario, string contraseña) 
        {



        }



        private void linkregistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Registro().ShowDialog();
            this.Close();
        }




    }
}
