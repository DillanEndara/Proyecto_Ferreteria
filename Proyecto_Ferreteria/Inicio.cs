using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using Capa_Negocio;

namespace Proyecto_Ferreteria
{
    public partial class Inicio : Form
    {
        CNUsuario objetoCN = new CNUsuario();
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
                int rol = objetoCN.logeo(txt_usuario.Text, txt_password.Text);
                if (rol == 1)
                {
                    this.Hide();
                    new Administrador().ShowDialog();
                    this.Close();
                }
                else if (rol == 2)
                {
                    this.Hide();
                    new Inventario().ShowDialog();
                    this.Close();
                }
            }
        }

        private void linkregistro_LinkClicked(object sender, LinkLabelLinkClickedEventArgs e)
        {
            this.Hide();
            new Registro().ShowDialog();
            this.Close();
        }




    }
}
