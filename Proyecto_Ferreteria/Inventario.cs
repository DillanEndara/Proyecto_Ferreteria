﻿using System;
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
        public Inventario()
        {
            InitializeComponent();
        }

        private void butsalir_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Inicio().ShowDialog();
            this.Close();
        }

        private void butcomprar_Click(object sender, EventArgs e)
        {
            this.Hide();
            new Compra().ShowDialog();
            this.Close();
        }
    }
}
