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
    public partial class Administrador : Form
    {
        CNProducto objetoCN = new CNProducto();
        string idCol;
        public Administrador()
        {
            InitializeComponent();
            
        }

        private void butagregar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.agregarProducto(textBox1.Text,textBox2.Text,comboBox1.SelectedValue.ToString(),textBox5.Text, textBox4.Text, textBox3.Text);
                MessageBox.Show("Se agregó el producto correctamente");
                mostrarProd();
                limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudo registrar el producto");
                throw;
            }
        }

        private void buteditar_Click(object sender, EventArgs e)
        {
            try
            {
                objetoCN.editarProd(textBox1.Text, textBox2.Text, comboBox1.SelectedValue.ToString(), textBox5.Text, textBox4.Text, textBox3.Text, idCol);
                MessageBox.Show("Se editó correctamente");
                mostrarProd();
                limpiar();
            }
            catch (Exception)
            {
                MessageBox.Show("No se pudieron editar el producto");
                throw;
            }
        }

        private void buteliminar_Click(object sender, EventArgs e)
        {
            if (string.IsNullOrEmpty(idCol))
            {
                MessageBox.Show("Doble click en una fila para eliminar");
            }
            else
            {
                try
                {
                    objetoCN.eliminarProd(idCol);
                    MessageBox.Show("Se eliminó correctamente el producto");
                    mostrarProd();
                    limpiar();
                }
                catch (Exception ex)
                {
                    MessageBox.Show("No se pudo eliminar el producto " + ex);
                    throw;
                }
            }
        }

        private void Administrador_Load(object sender, EventArgs e)
        {
            comboBox1.DisplayMember = "nombreCat";
            comboBox1.ValueMember = "idCat";
            comboBox1.DataSource = objetoCN.listarCat();
            mostrarProd();
        }

        public void mostrarProd()
        {
            CNProducto objetoC = new CNProducto();
            dataGridView1.DataSource = objetoC.listarProductos();
        }

        public void limpiar()
        {
            textBox1.Text = textBox2.Text = comboBox1.Text = textBox5.Text = textBox4.Text = textBox3.Text = "";
        }

        private void dataGridView1_CellMouseDoubleClick(object sender, DataGridViewCellMouseEventArgs e)
        {
            if (dataGridView1.SelectedRows.Count > 0)
            {
                //buteditar = true;
                textBox1.Text = dataGridView1.CurrentRow.Cells["codigoPro"].Value.ToString();
                textBox2.Text = dataGridView1.CurrentRow.Cells["nombrePro"].Value.ToString();
                comboBox1.Text = dataGridView1.CurrentRow.Cells["nombreCat"].Value.ToString();
                textBox5.Text = dataGridView1.CurrentRow.Cells["precioVentaPro"].Value.ToString();
                textBox4.Text = dataGridView1.CurrentRow.Cells["stockPro"].Value.ToString();
                textBox3.Text = dataGridView1.CurrentRow.Cells["descripcionPro"].Value.ToString();
                idCol = dataGridView1.CurrentRow.Cells["idPro"].Value.ToString();
            }
            else
            {
                MessageBox.Show("Seleccione una fila");
                limpiar();
            }
        }
    }
}
