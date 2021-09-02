
namespace Proyecto_Ferreteria
{
    partial class Administrador
    {
        /// <summary>
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.panel1 = new System.Windows.Forms.Panel();
            this.txtcateg = new System.Windows.Forms.TextBox();
            this.cmbcateg = new System.Windows.Forms.ComboBox();
            this.dataGridView1 = new System.Windows.Forms.DataGridView();
            this.buteditar = new System.Windows.Forms.Button();
            this.buteliminar = new System.Windows.Forms.Button();
            this.butagregar = new System.Windows.Forms.Button();
            this.txtprecio = new System.Windows.Forms.TextBox();
            this.txtcant = new System.Windows.Forms.TextBox();
            this.txtdescri = new System.Windows.Forms.TextBox();
            this.txtprod = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Proyecto_Ferreteria.Properties.Resources.inventario;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.label6);
            this.panel1.Controls.Add(this.txtcateg);
            this.panel1.Controls.Add(this.cmbcateg);
            this.panel1.Controls.Add(this.dataGridView1);
            this.panel1.Controls.Add(this.buteditar);
            this.panel1.Controls.Add(this.buteliminar);
            this.panel1.Controls.Add(this.butagregar);
            this.panel1.Controls.Add(this.txtprecio);
            this.panel1.Controls.Add(this.txtcant);
            this.panel1.Controls.Add(this.txtdescri);
            this.panel1.Controls.Add(this.txtprod);
            this.panel1.Controls.Add(this.label5);
            this.panel1.Controls.Add(this.label4);
            this.panel1.Controls.Add(this.label3);
            this.panel1.Controls.Add(this.label2);
            this.panel1.Controls.Add(this.label1);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(716, 439);
            this.panel1.TabIndex = 0;
            // 
            // txtcateg
            // 
            this.txtcateg.Location = new System.Drawing.Point(148, 13);
            this.txtcateg.Name = "txtcateg";
            this.txtcateg.Size = new System.Drawing.Size(296, 20);
            this.txtcateg.TabIndex = 26;
            // 
            // cmbcateg
            // 
            this.cmbcateg.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.cmbcateg.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cmbcateg.FormattingEnabled = true;
            this.cmbcateg.Location = new System.Drawing.Point(148, 56);
            this.cmbcateg.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.cmbcateg.Name = "cmbcateg";
            this.cmbcateg.Size = new System.Drawing.Size(296, 28);
            this.cmbcateg.TabIndex = 25;
            // 
            // dataGridView1
            // 
            this.dataGridView1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dataGridView1.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dataGridView1.Location = new System.Drawing.Point(36, 274);
            this.dataGridView1.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.dataGridView1.Name = "dataGridView1";
            this.dataGridView1.RowHeadersWidth = 51;
            this.dataGridView1.RowTemplate.Height = 24;
            this.dataGridView1.Size = new System.Drawing.Size(620, 132);
            this.dataGridView1.TabIndex = 24;
            this.dataGridView1.CellMouseDoubleClick += new System.Windows.Forms.DataGridViewCellMouseEventHandler(this.dataGridView1_CellMouseDoubleClick);
            // 
            // buteditar
            // 
            this.buteditar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buteditar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buteditar.Location = new System.Drawing.Point(512, 113);
            this.buteditar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buteditar.Name = "buteditar";
            this.buteditar.Size = new System.Drawing.Size(103, 33);
            this.buteditar.TabIndex = 20;
            this.buteditar.Text = "EDITAR";
            this.buteditar.UseVisualStyleBackColor = true;
            this.buteditar.Click += new System.EventHandler(this.buteditar_Click);
            // 
            // buteliminar
            // 
            this.buteliminar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.buteliminar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.buteliminar.Location = new System.Drawing.Point(512, 205);
            this.buteliminar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.buteliminar.Name = "buteliminar";
            this.buteliminar.Size = new System.Drawing.Size(103, 33);
            this.buteliminar.TabIndex = 19;
            this.buteliminar.Text = "ELIMINAR";
            this.buteliminar.UseVisualStyleBackColor = true;
            this.buteliminar.Click += new System.EventHandler(this.buteliminar_Click);
            // 
            // butagregar
            // 
            this.butagregar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.butagregar.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butagregar.Location = new System.Drawing.Point(512, 25);
            this.butagregar.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.butagregar.Name = "butagregar";
            this.butagregar.Size = new System.Drawing.Size(103, 33);
            this.butagregar.TabIndex = 18;
            this.butagregar.Text = "AGREGAR";
            this.butagregar.UseVisualStyleBackColor = true;
            this.butagregar.Click += new System.EventHandler(this.butagregar_Click);
            // 
            // txtprecio
            // 
            this.txtprecio.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtprecio.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecio.Location = new System.Drawing.Point(148, 235);
            this.txtprecio.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtprecio.Name = "txtprecio";
            this.txtprecio.Size = new System.Drawing.Size(296, 25);
            this.txtprecio.TabIndex = 17;
            // 
            // txtcant
            // 
            this.txtcant.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtcant.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcant.Location = new System.Drawing.Point(148, 191);
            this.txtcant.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtcant.Name = "txtcant";
            this.txtcant.Size = new System.Drawing.Size(296, 25);
            this.txtcant.TabIndex = 16;
            // 
            // txtdescri
            // 
            this.txtdescri.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtdescri.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtdescri.Location = new System.Drawing.Point(148, 146);
            this.txtdescri.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtdescri.Name = "txtdescri";
            this.txtdescri.Size = new System.Drawing.Size(296, 25);
            this.txtdescri.TabIndex = 15;
            // 
            // txtprod
            // 
            this.txtprod.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.txtprod.Font = new System.Drawing.Font("Modern No. 20", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprod.Location = new System.Drawing.Point(148, 104);
            this.txtprod.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.txtprod.Name = "txtprod";
            this.txtprod.Size = new System.Drawing.Size(296, 25);
            this.txtprod.TabIndex = 14;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.BackColor = System.Drawing.Color.Transparent;
            this.label5.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.Location = new System.Drawing.Point(29, 143);
            this.label5.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(103, 20);
            this.label5.TabIndex = 12;
            this.label5.Text = "Descripción";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.BackColor = System.Drawing.Color.Transparent;
            this.label4.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.Location = new System.Drawing.Point(30, 233);
            this.label4.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(59, 20);
            this.label4.TabIndex = 11;
            this.label4.Text = "Precio";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.BackColor = System.Drawing.Color.Transparent;
            this.label3.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.Location = new System.Drawing.Point(29, 189);
            this.label3.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(81, 20);
            this.label3.TabIndex = 10;
            this.label3.Text = "Cantidad";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.Location = new System.Drawing.Point(30, 101);
            this.label2.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(81, 20);
            this.label2.TabIndex = 9;
            this.label2.Text = "Producto";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.Location = new System.Drawing.Point(30, 56);
            this.label1.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(87, 20);
            this.label1.TabIndex = 8;
            this.label1.Text = "Categoría";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.BackColor = System.Drawing.Color.Transparent;
            this.label6.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.Location = new System.Drawing.Point(29, 13);
            this.label6.Margin = new System.Windows.Forms.Padding(2, 0, 2, 0);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(65, 20);
            this.label6.TabIndex = 27;
            this.label6.Text = "Código";
            // 
            // Administrador
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(716, 439);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2, 2, 2, 2);
            this.Name = "Administrador";
            this.Text = "Administrador";
            this.Load += new System.EventHandler(this.Administrador_Load);
            this.panel1.ResumeLayout(false);
            this.panel1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dataGridView1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label label5;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtprecio;
        private System.Windows.Forms.TextBox txtcant;
        private System.Windows.Forms.TextBox txtdescri;
        private System.Windows.Forms.TextBox txtprod;
        private System.Windows.Forms.DataGridView dataGridView1;
        private System.Windows.Forms.Button buteditar;
        private System.Windows.Forms.Button buteliminar;
        private System.Windows.Forms.Button butagregar;
        private System.Windows.Forms.ComboBox cmbcateg;
        private System.Windows.Forms.TextBox txtcateg;
        private System.Windows.Forms.Label label6;
    }
}