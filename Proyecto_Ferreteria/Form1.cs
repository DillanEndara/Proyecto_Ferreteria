using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Data;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using System.Runtime.InteropServices; // para mover la ventana


namespace Proyecto_Ferreteria
{
    public partial class Form1 : Form
    {
        public Form1()
        {
            InitializeComponent();
        }

        private void btnCerrar_Click(object sender, EventArgs e)
        {
            Application.Exit();
        }

        private void btnRestaurar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Normal;
            btnRestaurar.Visible = false;
            btnMaximizar.Visible = true;
        }

        private void btnMaximizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Maximized;
            btnMaximizar.Visible = false;
            btnRestaurar.Visible = true;
        }

        private void btnMinimizar_Click_1(object sender, EventArgs e)
        {
            this.WindowState = FormWindowState.Minimized;
        }
        private void Form1_Load(object sender, EventArgs e)
        {
            //admin
            //if(Inicio.rol == "1")
            //{
            //    btninicio_Click(null, e);
            //    btninicio.Enabled = true;
            //    btnadm.Enabled = true;
            //    btncliente.Enabled = true;
            //    btncompra.Enabled = true;
            //    btnpagos.Enabled = true;
            //}
            //else if (Inicio.rol == "2")
            //{
            //    btninicio_Click(null, e);
            //    btninicio.Enabled = true;
            //    btnadm.Enabled = false;
            //    btncliente.Enabled = true;
            //    btncompra.Enabled = true;
            //    btnpagos.Enabled = true; 
            //}
            
        }

        // mover la ventana

        [DllImport("user32.DLL", EntryPoint = "ReleaseCapture")]
        private extern static void ReleaseCapture();
        [DllImport("user32.DLL", EntryPoint = "SendMessage")]

        private extern static void SendMessage(System.IntPtr hWnd, int wMsg, int wParam, int lParam);

        private void BarraTitulo_MouseDown(object sender, MouseEventArgs e)
        {
            ReleaseCapture();
            SendMessage(this.Handle, 0x112, 0xf012, 0);
        }
        //desplegar submenu de opciones
        private void btncliente_Click(object sender, EventArgs e)
        {
            Submenucliente.Visible = true;
        }

        private void btncompra_Click(object sender, EventArgs e)
        {
            AbrirFormson(new Inventario());
            Submenucliente.Visible = false;

        }

        private void btnpagos_Click(object sender, EventArgs e)
        {
            AbrirFormson(new Compra());
            Submenucliente.Visible = false;
        }

        private void btnsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().ShowDialog();
            this.Close();
        }

        //abrir o llamar formularios al fomulario principal
        public void AbrirFormson(object formson)
        {
            if (this.panelvista.Controls.Count > 0)
                this.panelvista.Controls.RemoveAt(0);
            Form fh = formson as Form;
            fh.TopLevel = false;                // formulario de nivel inferior al establecido
            fh.Dock = DockStyle.Fill;           //acoplar al panelvista
            this.panelvista.Controls.Add(fh);   //agregar al panel
            this.panelvista.Tag = fh;
            fh.Show();                          //visualizar

        }

        private void btnadm_Click(object sender, EventArgs e)
        {
            AbrirFormson(new Administrador());

        }

        private void btninicio_Click(object sender, EventArgs e)
        {
            AbrirFormson(new stock());
        }
    }

}
