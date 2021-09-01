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
using Capa_Entidad;

namespace Proyecto_Ferreteria
{
    public partial class Inicio : Form
    {
        //CNUsuario objetoCN = new CNUsuario();
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
                logueo();
            }
        }

        CEUsuario objeuser = new CEUsuario();
        CNUsuario objnuser = new CNUsuario();
        Form1 frm1 = new Form1();
        public static string usuario_nombre;
        public static string rol;

        private void logueo()
        {
            DataTable dt = new DataTable();
            objeuser.usuario = txt_usuario.Text;
            objeuser.clave = txt_password.Text;
            dt = objnuser.CNusuario(objeuser);
            if (dt.Rows.Count>0)
            {
                MessageBox.Show("Bienvenido   "+dt.Rows[0][0].ToString(), "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
                usuario_nombre = dt.Rows[0][0].ToString();
                rol = dt.Rows[0][1].ToString();

                frm1.ShowDialog();

                Inicio login = new Inicio();
                login.ShowDialog();
                if (login.DialogResult == DialogResult.OK)
                    Application.Run(new Form1());

                txt_password.Clear();
                txt_usuario.Clear();

            }
            else
            {
                MessageBox.Show("Usuario o Contraseña Incorrecta", "Mensaje", MessageBoxButtons.OK, MessageBoxIcon.Information);
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
