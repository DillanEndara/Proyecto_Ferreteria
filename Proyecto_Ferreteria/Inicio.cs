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
                int rol;
                rol = objetoCN.logeo(txt_usuario.Text, txt_password.Text);
                Form1 fr = new Form1(rol);
                if (rol == 1)
                {
                    int idUs;
                    DataTable findId = new DataTable();
                    findId = objetoCN.encontrarId(txt_usuario.Text, txt_password.Text);
                    idUs = Convert.ToInt32(findId.Rows[0][0].ToString());
                    Inventario inv = new Inventario(idUs);
                    Compra comp = new Compra(idUs);
                    this.Hide();
                    new Form1().ShowDialog();
                    this.Close();
                }
                else if (rol == 2)
                {
                    int idUs;
                    DataTable findId = new DataTable();
                    findId = objetoCN.encontrarId(txt_usuario.Text, txt_password.Text);
                    idUs = Convert.ToInt32(findId.Rows[0][0].ToString());
                    Inventario inv = new Inventario(idUs);
                    Compra comp = new Compra(idUs);
                    this.Hide();
                    new Form1().ShowDialog();
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
                //logear(txt_usuario.Text, txt_password.Text);
            }
        }

        CEUsuario objeuser = new CEUsuario();
        CNUsuario objnuser = new CNUsuario();
        Form1 frm1 = new Form1();
        public static string correo;
        public static string rol;


        private void logear(string usuario, string contraseña)
        {
            DataTable dt = new DataTable();
            //objeuser.correo = txt_usuario.Text;
            //objeuser.pass = txt_password.Text;

            //dt = objnuser.CNusuario(objeuser);
            //if (dt.Rows.Count > 0)
            //{
            //    MessageBox.Show("Bienvenido ", "Mensaje ", MessageBoxButtons.OK, MessageBoxIcon.Information);
            //    correo = dt.Rows[0][1].ToString();
            //    rol = dt.Rows[0][0].ToString();

            //    frm1.ShowDialog();
            //    Inicio login = new Inicio();
            //    login.ShowDialog();
            //    if (login.DialogResult == DialogResult.OK)
            //        Application.Run(new Inicio());
            //    txt_usuario.Clear();
            //    txt_password.Clear();

            //}
            //else
            //{
            //    MessageBox.Show("Informacion Incorrecta", "Mensaje", MessageBoxButtons.OK,MessageBoxIcon.Information);
            //    contador--;
            //    lblContador.Text = contador.ToString();
            //    if (contador == 0)
            //    {
            //        MessageBox.Show("Cantidad de intentos excedida");
            //        this.Close();
            //    }
            //}
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
