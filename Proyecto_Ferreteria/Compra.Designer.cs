
namespace Proyecto_Ferreteria
{
    partial class Compra
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
            this.dgvComp = new System.Windows.Forms.DataGridView();
            this.butcancelar = new System.Windows.Forms.Button();
            this.butconfirmar = new System.Windows.Forms.Button();
            this.btnBorrar = new System.Windows.Forms.Button();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvComp)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.panel1.BackgroundImage = global::Proyecto_Ferreteria.Properties.Resources.MADERA;
            this.panel1.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.panel1.Controls.Add(this.btnBorrar);
            this.panel1.Controls.Add(this.dgvComp);
            this.panel1.Controls.Add(this.butcancelar);
            this.panel1.Controls.Add(this.butconfirmar);
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Margin = new System.Windows.Forms.Padding(2);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(600, 367);
            this.panel1.TabIndex = 0;
            // 
            // dgvComp
            // 
            this.dgvComp.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left) 
            | System.Windows.Forms.AnchorStyles.Right)));
            this.dgvComp.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvComp.Location = new System.Drawing.Point(66, 25);
            this.dgvComp.Margin = new System.Windows.Forms.Padding(2);
            this.dgvComp.Name = "dgvComp";
            this.dgvComp.RowHeadersWidth = 51;
            this.dgvComp.RowTemplate.Height = 24;
            this.dgvComp.Size = new System.Drawing.Size(448, 255);
            this.dgvComp.TabIndex = 2;
            // 
            // butcancelar
            // 
            this.butcancelar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.butcancelar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butcancelar.Location = new System.Drawing.Point(361, 307);
            this.butcancelar.Margin = new System.Windows.Forms.Padding(2);
            this.butcancelar.Name = "butcancelar";
            this.butcancelar.Size = new System.Drawing.Size(113, 37);
            this.butcancelar.TabIndex = 1;
            this.butcancelar.Text = "CANCELAR";
            this.butcancelar.UseVisualStyleBackColor = true;
            this.butcancelar.Click += new System.EventHandler(this.butcancelar_Click);
            // 
            // butconfirmar
            // 
            this.butconfirmar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.butconfirmar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.butconfirmar.Location = new System.Drawing.Point(91, 307);
            this.butconfirmar.Margin = new System.Windows.Forms.Padding(2);
            this.butconfirmar.Name = "butconfirmar";
            this.butconfirmar.Size = new System.Drawing.Size(113, 37);
            this.butconfirmar.TabIndex = 0;
            this.butconfirmar.Text = "CONFIRMAR";
            this.butconfirmar.UseVisualStyleBackColor = true;
            this.butconfirmar.Click += new System.EventHandler(this.butconfirmar_Click);
            // 
            // btnBorrar
            // 
            this.btnBorrar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.btnBorrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBorrar.Location = new System.Drawing.Point(361, 307);
            this.btnBorrar.Margin = new System.Windows.Forms.Padding(2);
            this.btnBorrar.Name = "btnBorrar";
            this.btnBorrar.Size = new System.Drawing.Size(113, 37);
            this.btnBorrar.TabIndex = 3;
            this.btnBorrar.Text = "ELIMINAR REG.";
            this.btnBorrar.UseVisualStyleBackColor = true;
            this.btnBorrar.Click += new System.EventHandler(this.btnBorrar_Click);
            // 
            // Compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(600, 366);
            this.Controls.Add(this.panel1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.Margin = new System.Windows.Forms.Padding(2);
            this.Name = "Compra";
            this.Text = "Compra";
            this.Load += new System.EventHandler(this.Compra_Load);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.dgvComp)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Button butconfirmar;
        private System.Windows.Forms.DataGridView dgvComp;
        private System.Windows.Forms.Button butcancelar;
        private System.Windows.Forms.Button btnBorrar;
    }
}