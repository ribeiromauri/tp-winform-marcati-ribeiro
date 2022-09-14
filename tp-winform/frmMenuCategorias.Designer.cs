namespace tp_winform
{
    partial class frmMenuCategorias
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
            this.dgvCategorias = new System.Windows.Forms.DataGridView();
            this.gbBusquedaCategoria = new System.Windows.Forms.GroupBox();
            this.txtBuscarCategoria = new System.Windows.Forms.TextBox();
            this.btnAgregarCat = new System.Windows.Forms.Button();
            this.btnEliminarCat = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).BeginInit();
            this.gbBusquedaCategoria.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvCategorias
            // 
            this.dgvCategorias.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategorias.Location = new System.Drawing.Point(137, 125);
            this.dgvCategorias.Name = "dgvCategorias";
            this.dgvCategorias.Size = new System.Drawing.Size(244, 214);
            this.dgvCategorias.TabIndex = 0;
            // 
            // gbBusquedaCategoria
            // 
            this.gbBusquedaCategoria.Controls.Add(this.txtBuscarCategoria);
            this.gbBusquedaCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbBusquedaCategoria.Location = new System.Drawing.Point(34, 28);
            this.gbBusquedaCategoria.Name = "gbBusquedaCategoria";
            this.gbBusquedaCategoria.Size = new System.Drawing.Size(347, 54);
            this.gbBusquedaCategoria.TabIndex = 16;
            this.gbBusquedaCategoria.TabStop = false;
            this.gbBusquedaCategoria.Text = "Búsqueda por descripción";
            // 
            // txtBuscarCategoria
            // 
            this.txtBuscarCategoria.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscarCategoria.Location = new System.Drawing.Point(103, 21);
            this.txtBuscarCategoria.Name = "txtBuscarCategoria";
            this.txtBuscarCategoria.Size = new System.Drawing.Size(205, 22);
            this.txtBuscarCategoria.TabIndex = 30;
            this.txtBuscarCategoria.TextChanged += new System.EventHandler(this.txtBuscarCategoria_TextChanged);
            // 
            // btnAgregarCat
            // 
            this.btnAgregarCat.Location = new System.Drawing.Point(34, 198);
            this.btnAgregarCat.Name = "btnAgregarCat";
            this.btnAgregarCat.Size = new System.Drawing.Size(75, 23);
            this.btnAgregarCat.TabIndex = 17;
            this.btnAgregarCat.Text = "Agregar";
            this.btnAgregarCat.UseVisualStyleBackColor = true;
            this.btnAgregarCat.Click += new System.EventHandler(this.btnAgregarCat_Click);
            // 
            // btnEliminarCat
            // 
            this.btnEliminarCat.Location = new System.Drawing.Point(34, 250);
            this.btnEliminarCat.Name = "btnEliminarCat";
            this.btnEliminarCat.Size = new System.Drawing.Size(75, 23);
            this.btnEliminarCat.TabIndex = 18;
            this.btnEliminarCat.Text = "Eliminar";
            this.btnEliminarCat.UseVisualStyleBackColor = true;
            this.btnEliminarCat.Click += new System.EventHandler(this.btnEliminarCat_Click);
            // 
            // frmMenuCategorias
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.PapayaWhip;
            this.ClientSize = new System.Drawing.Size(425, 364);
            this.Controls.Add(this.btnEliminarCat);
            this.Controls.Add(this.btnAgregarCat);
            this.Controls.Add(this.gbBusquedaCategoria);
            this.Controls.Add(this.dgvCategorias);
            this.MaximumSize = new System.Drawing.Size(441, 403);
            this.MinimumSize = new System.Drawing.Size(441, 403);
            this.Name = "frmMenuCategorias";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Menú Categorias";
            this.Load += new System.EventHandler(this.frmMenuCategorias_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategorias)).EndInit();
            this.gbBusquedaCategoria.ResumeLayout(false);
            this.gbBusquedaCategoria.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvCategorias;
        private System.Windows.Forms.GroupBox gbBusquedaCategoria;
        private System.Windows.Forms.TextBox txtBuscarCategoria;
        private System.Windows.Forms.Button btnAgregarCat;
        private System.Windows.Forms.Button btnEliminarCat;
    }
}