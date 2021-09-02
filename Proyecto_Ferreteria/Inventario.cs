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
        CNVenta objetoCNV = new CNVenta();
        DataTable datos = new DataTable();
        static int idUsu;
        double precioTotal;
        double total;
        string col;
        public Inventario()
        {
            InitializeComponent();
        }

        public Inventario(int id)
        {
            idUsu = id;
        }

        private void Inventario_Load(object sender, EventArgs e)
        {
            objetoCNV.agregarVenta(idUsu, DateTime.Now.ToShortDateString(), precioTotal);
            cargarCat();
        }

        public void limpiar()
        {
            cmbcat.Text = "";
            cmbpro.Text = "";
            lblPrecio.Text = "";
            lblTotal.Text = "";
            nUDcant.Value = 1;
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
            if (cmbcat.SelectedValue.ToString() != null)
            {
                string id = cmbcat.SelectedValue.ToString();
                cargarProd(id);
                lblPrecio.Text = datos.Rows[0][3].ToString();
            }
            else
            {
                cmbpro.Text = "";
            }
        }

        private void btnagregar_Click(object sender, EventArgs e)
        {
            int stock = Convert.ToInt32(datos.Rows[0][2].ToString());
            idUsu = encontrarIdVenta();
            if (stock > nUDcant.Value)
            {
                objetoCNV.agregarDetalle(idUsu, cmbpro.SelectedValue.ToString(), Convert.ToInt32(nUDcant.Value), total);
                objetoCN.StockProd(Convert.ToInt32(nUDcant.Value), cmbpro.SelectedValue.ToString());
                listarDeta(idUsu);
            }
            else if (stock == nUDcant.Value)
            {
                objetoCNV.agregarDetalle(idUsu, cmbpro.SelectedValue.ToString(), Convert.ToInt32(nUDcant.Value), total);
                objetoCN.inactivoProd(Convert.ToInt32(nUDcant.Value), cmbpro.SelectedValue.ToString());
                listarDeta(idUsu);
            }
            else
            {
                MessageBox.Show("Solo hay " + stock + " unidades de ese producto");
            }
            precioTotal = total + precioTotal;
            limpiar();
        }

        private void cmbpro_SelectedIndexChanged(object sender, EventArgs e)
        {
            string id = cmbpro.SelectedValue.ToString();
            datos = objetoCN.datosProd(id);
            lblPrecio.Text = datos.Rows[0][3].ToString();
            total = Convert.ToDouble(lblPrecio.Text) * Convert.ToDouble(nUDcant.Value);
            lblTotal.Text = total.ToString();
        }

        private void nUDcant_ValueChanged(object sender, EventArgs e)
        {
            double precio;
            if (lblPrecio.Text == "")
            {
                precio = 0;
                total = precio * Convert.ToDouble(nUDcant.Value);
                lblTotal.Text = total.ToString();
            }
            else
            {
                precio = Convert.ToDouble(lblPrecio.Text);
                total = precio * Convert.ToDouble(nUDcant.Value);
                lblTotal.Text = total.ToString();
            }
        }

        private void btnfin_Click(object sender, EventArgs e)
        {
            idUsu = encontrarIdVenta();
            objetoCNV.editarVenta(precioTotal, idUsu);
            MessageBox.Show("Se ingreso correctamente al carrito \n Ingresar al apartado Pagar");
        }

        public void listarDeta(int id)
        {
            CNVenta objetoV = new CNVenta();
            dataGridView1.DataSource = objetoV.listarDetalle(id);
        }

        public int encontrarIdVenta()
        {
            int id;
            DataTable dataId = new DataTable();
            dataId = objetoCNV.buscarVenta();
            id = Convert.ToInt32(dataId.Rows[0][0].ToString());
            return id;
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                col = dataGridView1.CurrentRow.Cells["idDetalle"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
                limpiar();
            }
        }

        private void btneliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(col))
            {
                MessageBox.Show("Doble click en una fila para eliminar");
            }
            else
            {
                try
                {
                    idUsu = encontrarIdVenta();
                    objetoCNV.eliminarDetalle(Convert.ToInt32(col));
                    MessageBox.Show("Se eliminó correctamente el producto");
                    listarDeta(idUsu);
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar el producto " + ex);
                    throw;
                }
            }
        }

        private void dataGridView1_CellMouseDoubleClick_1(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                btneliminar.Visible = true;
                col = dataGridView1.CurrentRow.Cells["idDetalle"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
                limpiar();
            }
        }
    }
}
