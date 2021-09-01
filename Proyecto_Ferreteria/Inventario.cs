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
    public partial class Inventario : Form
    {
        CNProducto objetoCN = new CNProducto();
        public Inventario()
        {
            InitializeComponent();
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            cargarCat();
        }

        public void limpiar()
        {
            cmbcat.Text = "";
            cmbpro.Text = "";
        }

        public void cargarCat()
        {
            cmbcat.DisplayMember = "nombreCat";
            cmbcat.ValueMember = "idCat";
            cmbcat.DataSource = objetoCN.listarCat();
        }

        public void cargarProd(string id)
        {
            cmbpro.DisplayMember = "nombrePro";
            cmbpro.ValueMember = "idPro";
            cmbpro.DataSource = objetoCN.listarCmb(id);
        }

        private void cmbcat_SelectedIndexChanged(object sender, EventArgs e)
        {
            if(cmbcat.SelectedValue.ToString() != null)
            {
                string id = cmbcat.SelectedValue.ToString();
                cargarProd(id);
            }
            else
            {
                cmbpro.Text = "";
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            
            limpiar();
        }
    }
}
