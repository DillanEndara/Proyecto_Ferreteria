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
//using Capa_Negocio;

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
                logear(txt_usuario.Text, txt_password.Text);
            }
        }

        private void logear(string usuario, string contraseña)
        {
             /*con.Open();

            //Seleccionar el nombre y tipo de usuario desde la tabla y muestra
            //el usuario y la contraseña siempre y cuando sean iguales 
            SqlCommand cmd = new SqlCommand("select usu_nombre, usu_password from Tbl_Usuario where usu_nomlogin = @usu", con);
            cmd.Parameters.AddWithValue("usu", usuario);

            //traduce el codigo desde sql a visual va a comparar lo ingresado con las tablas
            SqlDataAdapter sda = new SqlDataAdapter(cmd);

            //muestra la tabla y permite interactuar
            DataTable dt = new DataTable();
            sda.Fill(dt);

            con.Close();
            try
            {

                if (dt.Rows.Count == 1)
                {

                    string encrypt = "HASHBYTES('MD5','" + contraseña + "')";
                    con.Open();

                    //Verificación a través de una consulta para ver los datos del usuario
                    SqlCommand cmd1 = new SqlCommand("select usu_nombre ,tusu_id  from Tbl_Usuario" +
                        " where usu_nomlogin = @us and usu_password = " + encrypt, con);

                    cmd1.Parameters.AddWithValue("us", usuario);

                    //Traduce el codigo desde sql a visual para comparar lo ingresado con las tablas
                    SqlDataAdapter sda1 = new SqlDataAdapter(cmd1);

                    //Muestra la tabla y permite interactuar
                    DataTable dt1 = new DataTable();
                    sda1.Fill(dt1);

                    //Termina la conexion 
                    con.Close();

                    //Validar el usuario
                    if (dt1.Rows.Count == 1)
                    {
                        this.Hide();
                        int rol = objetoCN.logeo(txt_usuario.Text, txt_password.Text);
                        if (rol == 1)
                        {
                                this.Hide();
                                new Form1().ShowDialog();
                                this.Close();
                        }
                        else if (rol == 2)
                        {
                                this.Hide();
                                new Form1().ShowDialog();
                                this.Close();
                        }
                        this.Close();

                    }
                    else
                    {
                        MessageBox.Show("Contraseña incorrecta!\n");
                        lbl_intentos.Text = contador.ToString();
                        contador--;
                        if (lbl_intentos.Text == "0")
                        {
                            //Bloqueo del usuario en la Base de Datos
                            con.Open();
                            SqlCommand cmd3 = new SqlCommand("UPDATE Tbl_Usuario SET usu_estado = 'I'  WHERE usu_nomlogin ='" + usuario + "'", con);
                            cmd3.ExecuteNonQuery();
                            con.Close();

                            MessageBox.Show("Límite de intentos superado \n Usuario Bloqueado");
                            btningresar.Enabled = false;
                        }
                    }

                }
                else
                {
                    MessageBox.Show("Usuario incorrecto (No existe)");
                }
            }
            catch (Exception)
            {

                throw;
            }*/

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
