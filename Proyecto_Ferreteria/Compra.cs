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
    public partial class Compra : Form
    {
        CNVenta objetoCN = new CNVenta();
        static int idU;
        int idVenta;
        public Compra()
        {
            InitializeComponent();
        }

        public Compra(int id)
        {
            idU = id;
        }

        private void butconfirmar_Click(object sender, EventArgs e)
        {
            objetoCN.finalizarVenta(idVenta);
            listar();
            MessageBox.Show("Compra realizada");
        }

        private void butcancelar_Click(object sender, EventArgs e)
        {
            objetoCN.cancelarVenta(idVenta);
            listar();
            MessageBox.Show("Compra cancelada");
            btnBorrar.Visible = true;
        }

        private void Compra_Load(object sender, EventArgs e)
        {
            listar();
        }

        public void listar()
        {
            CNVenta objetoC = new CNVenta();
            dgvComp.DataSource = objetoC.listarVenta(idU);
            DataTable data = new DataTable();
            data = objetoCN.listarVenta(idU);
            if (data.Rows.Count == 0)
            {
                MessageBox.Show("No hay datos que mostrar");
            }
            else
            {
                idVenta = Convert.ToInt32(data.Rows[0][0].ToString());
            }
        }

        private void btnBorrar_Click(object sender, EventArgs e)
        {
            objetoCN.eliminarDetalle(idVenta);
            btnBorrar.Visible = false;
            listar();
        }
    }
}
