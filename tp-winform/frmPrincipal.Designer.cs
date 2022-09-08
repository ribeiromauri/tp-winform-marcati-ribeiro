
namespace tp_winform
{
    partial class frmPrincipal
    {
        /// <summary>
        /// Variable del diseñador necesaria.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary>
        /// Limpiar los recursos que se estén usando.
        /// </summary>
        /// <param name="disposing">true si los recursos administrados se deben desechar; false en caso contrario.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Código generado por el Diseñador de Windows Forms

        /// <summary>
        /// Método necesario para admitir el Diseñador. No se puede modificar
        /// el contenido de este método con el editor de código.
        /// </summary>
        private void InitializeComponent()
        {
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.pbxArticulo = new System.Windows.Forms.PictureBox();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.btnDetalle = new System.Windows.Forms.Button();
            this.gbColumna = new System.Windows.Forms.GroupBox();
            this.rbtPrecio = new System.Windows.Forms.RadioButton();
            this.rbtDescripcion = new System.Windows.Forms.RadioButton();
            this.rbtMarca = new System.Windows.Forms.RadioButton();
            this.rbtNombre = new System.Windows.Forms.RadioButton();
            this.gpCriterio = new System.Windows.Forms.GroupBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txtCriterio = new System.Windows.Forms.TextBox();
            this.rbtMenor = new System.Windows.Forms.RadioButton();
            this.rbtMayor = new System.Windows.Forms.RadioButton();
            this.rbtIgual = new System.Windows.Forms.RadioButton();
            this.btnBuscar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).BeginInit();
            this.gbColumna.SuspendLayout();
            this.gpCriterio.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.EditMode = System.Windows.Forms.DataGridViewEditMode.EditProgrammatically;
            this.dgvArticulos.Location = new System.Drawing.Point(124, 191);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvArticulos.MultiSelect = false;
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvArticulos.Size = new System.Drawing.Size(644, 247);
            this.dgvArticulos.TabIndex = 5;
            this.dgvArticulos.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvArticulos_CellContentClick);
            // 
            // pbxArticulo
            // 
            this.pbxArticulo.Location = new System.Drawing.Point(818, 191);
            this.pbxArticulo.Name = "pbxArticulo";
            this.pbxArticulo.Size = new System.Drawing.Size(235, 218);
            this.pbxArticulo.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbxArticulo.TabIndex = 8;
            this.pbxArticulo.TabStop = false;
            // 
            // btnAgregar
            // 
            this.btnAgregar.Location = new System.Drawing.Point(28, 227);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(75, 23);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = true;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.Location = new System.Drawing.Point(28, 288);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(75, 23);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = true;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.Location = new System.Drawing.Point(28, 348);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(75, 23);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = true;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // btnDetalle
            // 
            this.btnDetalle.Location = new System.Drawing.Point(905, 415);
            this.btnDetalle.Name = "btnDetalle";
            this.btnDetalle.Size = new System.Drawing.Size(75, 23);
            this.btnDetalle.TabIndex = 4;
            this.btnDetalle.Text = "Ver Detalle";
            this.btnDetalle.UseVisualStyleBackColor = true;
            this.btnDetalle.Click += new System.EventHandler(this.btnDetalle_Click);
            // 
            // gbColumna
            // 
            this.gbColumna.Controls.Add(this.rbtPrecio);
            this.gbColumna.Controls.Add(this.rbtDescripcion);
            this.gbColumna.Controls.Add(this.rbtMarca);
            this.gbColumna.Controls.Add(this.rbtNombre);
            this.gbColumna.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gbColumna.Location = new System.Drawing.Point(124, 12);
            this.gbColumna.Name = "gbColumna";
            this.gbColumna.Size = new System.Drawing.Size(547, 54);
            this.gbColumna.TabIndex = 15;
            this.gbColumna.TabStop = false;
            this.gbColumna.Text = "Columna";
            // 
            // rbtPrecio
            // 
            this.rbtPrecio.AutoSize = true;
            this.rbtPrecio.Location = new System.Drawing.Point(426, 22);
            this.rbtPrecio.Name = "rbtPrecio";
            this.rbtPrecio.Size = new System.Drawing.Size(70, 20);
            this.rbtPrecio.TabIndex = 3;
            this.rbtPrecio.Text = "Precio";
            this.rbtPrecio.UseVisualStyleBackColor = true;
            // 
            // rbtDescripcion
            // 
            this.rbtDescripcion.AutoSize = true;
            this.rbtDescripcion.Location = new System.Drawing.Point(301, 22);
            this.rbtDescripcion.Name = "rbtDescripcion";
            this.rbtDescripcion.Size = new System.Drawing.Size(108, 20);
            this.rbtDescripcion.TabIndex = 2;
            this.rbtDescripcion.Text = "Descripcion";
            this.rbtDescripcion.UseVisualStyleBackColor = true;
            // 
            // rbtMarca
            // 
            this.rbtMarca.AutoSize = true;
            this.rbtMarca.Location = new System.Drawing.Point(210, 22);
            this.rbtMarca.Name = "rbtMarca";
            this.rbtMarca.Size = new System.Drawing.Size(68, 20);
            this.rbtMarca.TabIndex = 1;
            this.rbtMarca.Text = "Marca";
            this.rbtMarca.UseVisualStyleBackColor = true;
            // 
            // rbtNombre
            // 
            this.rbtNombre.AutoSize = true;
            this.rbtNombre.Checked = true;
            this.rbtNombre.Location = new System.Drawing.Point(106, 22);
            this.rbtNombre.Name = "rbtNombre";
            this.rbtNombre.Size = new System.Drawing.Size(80, 20);
            this.rbtNombre.TabIndex = 0;
            this.rbtNombre.TabStop = true;
            this.rbtNombre.Text = "Nombre";
            this.rbtNombre.UseVisualStyleBackColor = true;
            // 
            // gpCriterio
            // 
            this.gpCriterio.Controls.Add(this.label1);
            this.gpCriterio.Controls.Add(this.txtCriterio);
            this.gpCriterio.Controls.Add(this.rbtMenor);
            this.gpCriterio.Controls.Add(this.rbtMayor);
            this.gpCriterio.Controls.Add(this.rbtIgual);
            this.gpCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.gpCriterio.Location = new System.Drawing.Point(124, 72);
            this.gpCriterio.Name = "gpCriterio";
            this.gpCriterio.Size = new System.Drawing.Size(547, 91);
            this.gpCriterio.TabIndex = 16;
            this.gpCriterio.TabStop = false;
            this.gpCriterio.Text = "Criterio";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Location = new System.Drawing.Point(16, 56);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(44, 16);
            this.label1.TabIndex = 27;
            this.label1.Text = "Valor";
            // 
            // txtCriterio
            // 
            this.txtCriterio.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriterio.Location = new System.Drawing.Point(83, 56);
            this.txtCriterio.Name = "txtCriterio";
            this.txtCriterio.Size = new System.Drawing.Size(424, 22);
            this.txtCriterio.TabIndex = 3;
            // 
            // rbtMenor
            // 
            this.rbtMenor.AutoSize = true;
            this.rbtMenor.Location = new System.Drawing.Point(340, 16);
            this.rbtMenor.Name = "rbtMenor";
            this.rbtMenor.Size = new System.Drawing.Size(102, 20);
            this.rbtMenor.TabIndex = 2;
            this.rbtMenor.Text = "Menor que ";
            this.rbtMenor.UseVisualStyleBackColor = true;
            // 
            // rbtMayor
            // 
            this.rbtMayor.AutoSize = true;
            this.rbtMayor.Location = new System.Drawing.Point(210, 16);
            this.rbtMayor.Name = "rbtMayor";
            this.rbtMayor.Size = new System.Drawing.Size(98, 20);
            this.rbtMayor.TabIndex = 1;
            this.rbtMayor.Text = "Mayor que";
            this.rbtMayor.UseVisualStyleBackColor = true;
            // 
            // rbtIgual
            // 
            this.rbtIgual.AutoSize = true;
            this.rbtIgual.Checked = true;
            this.rbtIgual.Location = new System.Drawing.Point(116, 16);
            this.rbtIgual.Name = "rbtIgual";
            this.rbtIgual.Size = new System.Drawing.Size(59, 20);
            this.rbtIgual.TabIndex = 0;
            this.rbtIgual.TabStop = true;
            this.rbtIgual.Text = "Igual";
            this.rbtIgual.UseVisualStyleBackColor = true;
            // 
            // btnBuscar
            // 
            this.btnBuscar.Location = new System.Drawing.Point(677, 140);
            this.btnBuscar.Name = "btnBuscar";
            this.btnBuscar.Size = new System.Drawing.Size(75, 23);
            this.btnBuscar.TabIndex = 0;
            this.btnBuscar.Text = "Buscar";
            this.btnBuscar.UseVisualStyleBackColor = true;
            this.btnBuscar.Click += new System.EventHandler(this.btnBuscar_Click);
            // 
            // frmPrincipal
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.btnBuscar);
            this.Controls.Add(this.gpCriterio);
            this.Controls.Add(this.gbColumna);
            this.Controls.Add(this.btnDetalle);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.pbxArticulo);
            this.Controls.Add(this.dgvArticulos);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximumSize = new System.Drawing.Size(1098, 489);
            this.MinimumSize = new System.Drawing.Size(1098, 489);
            this.Name = "frmPrincipal";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "TP2 WINFORM";
            this.Load += new System.EventHandler(this.frmPrincipal_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbxArticulo)).EndInit();
            this.gbColumna.ResumeLayout(false);
            this.gbColumna.PerformLayout();
            this.gpCriterio.ResumeLayout(false);
            this.gpCriterio.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.PictureBox pbxArticulo;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.Button btnDetalle;
        private System.Windows.Forms.GroupBox gbColumna;
        private System.Windows.Forms.RadioButton rbtPrecio;
        private System.Windows.Forms.RadioButton rbtDescripcion;
        private System.Windows.Forms.RadioButton rbtMarca;
        private System.Windows.Forms.RadioButton rbtNombre;
        private System.Windows.Forms.GroupBox gpCriterio;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.TextBox txtCriterio;
        private System.Windows.Forms.RadioButton rbtMenor;
        private System.Windows.Forms.RadioButton rbtMayor;
        private System.Windows.Forms.RadioButton rbtIgual;
        private System.Windows.Forms.Button btnBuscar;
    }
}

