using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Runtime.InteropServices;
using System.Windows.Forms;
using Capa_Negocio;

namespace Proyecto_Ferreteria
{
    public partial class Inicio : Form
    {
        CNUsuario objetoCN = new CNUsuario();
        static int contador=5;
        public Inicio()
        {
            InitializeComponent();
            lblContador.Text = contador.ToString();
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
            int rol;
            rol = objetoCN.logeo(usuario, contraseña);
            if (rol == 1)
            {
                this.Hide();
                new Registro().ShowDialog();
                this.Close();
            }
            else if (rol == 2)
            {
                this.Hide();
                new Registro().ShowDialog();
                this.Close();
            }
            else
            {
                MessageBox.Show("Informacion Incorrecta");
                contador--;
                lblContador.Text = contador.ToString();
                if (contador == 0)
                {
                    MessageBox.Show("Cantidad de intentos excedida");
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

        // mover la ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void btnCerrar_Click_1(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }

        private void BarraTitulo_Paint(object sender, PaintEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
    }
}
