
namespace tp_winform
{
    partial class Form1
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
            this.btnConectarse = new System.Windows.Forms.Button();
            this.btnDesconectarse = new System.Windows.Forms.Button();
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.dgvArticulos = new System.Windows.Forms.DataGridView();
            this.txtCriterioConsulta = new System.Windows.Forms.TextBox();
            this.lblCriterioFiltrar = new System.Windows.Forms.Label();
            this.btnConsulta = new System.Windows.Forms.Button();
            this.txtColumnaConsulta = new System.Windows.Forms.TextBox();
            this.lblColumaFiltrar = new System.Windows.Forms.Label();
            this.btnMostrarTodo = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // btnConectarse
            // 
            this.btnConectarse.BackColor = System.Drawing.Color.Linen;
            this.btnConectarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConectarse.FlatAppearance.BorderColor = System.Drawing.Color.MistyRose;
            this.btnConectarse.FlatAppearance.MouseDownBackColor = System.Drawing.Color.Transparent;
            this.btnConectarse.FlatAppearance.MouseOverBackColor = System.Drawing.Color.Transparent;
            this.btnConectarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConectarse.Location = new System.Drawing.Point(13, 12);
            this.btnConectarse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConectarse.Name = "btnConectarse";
            this.btnConectarse.Size = new System.Drawing.Size(190, 65);
            this.btnConectarse.TabIndex = 2;
            this.btnConectarse.Text = "CONECTARSE";
            this.btnConectarse.UseVisualStyleBackColor = false;
            this.btnConectarse.Click += new System.EventHandler(this.btnConectarse_Click);
            // 
            // btnDesconectarse
            // 
            this.btnDesconectarse.BackColor = System.Drawing.Color.Linen;
            this.btnDesconectarse.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnDesconectarse.FlatAppearance.BorderSize = 10;
            this.btnDesconectarse.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnDesconectarse.Location = new System.Drawing.Point(13, 83);
            this.btnDesconectarse.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnDesconectarse.Name = "btnDesconectarse";
            this.btnDesconectarse.Size = new System.Drawing.Size(190, 65);
            this.btnDesconectarse.TabIndex = 3;
            this.btnDesconectarse.Text = "DESCONECTARSE";
            this.btnDesconectarse.UseVisualStyleBackColor = false;
            this.btnDesconectarse.Click += new System.EventHandler(this.btnDesconectarse_Click);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.Linen;
            this.btnAgregar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(13, 373);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(190, 65);
            this.btnAgregar.TabIndex = 4;
            this.btnAgregar.Text = "AGREGAR";
            this.btnAgregar.UseVisualStyleBackColor = false;
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.Linen;
            this.btnModificar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(13, 302);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(190, 65);
            this.btnModificar.TabIndex = 5;
            this.btnModificar.Text = "MODIFICAR";
            this.btnModificar.UseVisualStyleBackColor = false;
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.Linen;
            this.btnEliminar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(13, 231);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(190, 65);
            this.btnEliminar.TabIndex = 6;
            this.btnEliminar.Text = "ELIMINAR";
            this.btnEliminar.UseVisualStyleBackColor = false;
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.Color.White;
            this.dgvArticulos.BorderStyle = System.Windows.Forms.BorderStyle.None;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(224, 12);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.Size = new System.Drawing.Size(843, 226);
            this.dgvArticulos.TabIndex = 7;
            // 
            // txtCriterioConsulta
            // 
            this.txtCriterioConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtCriterioConsulta.Location = new System.Drawing.Point(967, 416);
            this.txtCriterioConsulta.Name = "txtCriterioConsulta";
            this.txtCriterioConsulta.Size = new System.Drawing.Size(100, 22);
            this.txtCriterioConsulta.TabIndex = 8;
            // 
            // lblCriterioFiltrar
            // 
            this.lblCriterioFiltrar.AutoSize = true;
            this.lblCriterioFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblCriterioFiltrar.Location = new System.Drawing.Point(964, 397);
            this.lblCriterioFiltrar.Name = "lblCriterioFiltrar";
            this.lblCriterioFiltrar.Size = new System.Drawing.Size(80, 16);
            this.lblCriterioFiltrar.TabIndex = 9;
            this.lblCriterioFiltrar.Text = "Criterio filtrar";
            // 
            // btnConsulta
            // 
            this.btnConsulta.BackColor = System.Drawing.Color.Linen;
            this.btnConsulta.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnConsulta.Location = new System.Drawing.Point(649, 373);
            this.btnConsulta.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnConsulta.Name = "btnConsulta";
            this.btnConsulta.Size = new System.Drawing.Size(190, 65);
            this.btnConsulta.TabIndex = 10;
            this.btnConsulta.Text = "CONSULTAR";
            this.btnConsulta.UseVisualStyleBackColor = false;
            this.btnConsulta.Click += new System.EventHandler(this.btnConsulta_Click);
            // 
            // txtColumnaConsulta
            // 
            this.txtColumnaConsulta.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtColumnaConsulta.Location = new System.Drawing.Point(849, 416);
            this.txtColumnaConsulta.Name = "txtColumnaConsulta";
            this.txtColumnaConsulta.Size = new System.Drawing.Size(100, 22);
            this.txtColumnaConsulta.TabIndex = 11;
            // 
            // lblColumaFiltrar
            // 
            this.lblColumaFiltrar.AutoSize = true;
            this.lblColumaFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lblColumaFiltrar.Location = new System.Drawing.Point(846, 397);
            this.lblColumaFiltrar.Name = "lblColumaFiltrar";
            this.lblColumaFiltrar.Size = new System.Drawing.Size(91, 16);
            this.lblColumaFiltrar.TabIndex = 12;
            this.lblColumaFiltrar.Text = "Columna filtrar";
            // 
            // btnMostrarTodo
            // 
            this.btnMostrarTodo.BackColor = System.Drawing.Color.Linen;
            this.btnMostrarTodo.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btnMostrarTodo.Font = new System.Drawing.Font("Microsoft Sans Serif", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrarTodo.Location = new System.Drawing.Point(451, 373);
            this.btnMostrarTodo.Margin = new System.Windows.Forms.Padding(4, 3, 4, 3);
            this.btnMostrarTodo.Name = "btnMostrarTodo";
            this.btnMostrarTodo.Size = new System.Drawing.Size(190, 65);
            this.btnMostrarTodo.TabIndex = 13;
            this.btnMostrarTodo.Text = "MOSTRAR TODOS LOS ARTICULOS";
            this.btnMostrarTodo.UseVisualStyleBackColor = false;
            this.btnMostrarTodo.Click += new System.EventHandler(this.btnMostrarTodo_Click);
            // 
            // Form1
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Bisque;
            this.ClientSize = new System.Drawing.Size(1082, 450);
            this.Controls.Add(this.btnMostrarTodo);
            this.Controls.Add(this.lblColumaFiltrar);
            this.Controls.Add(this.txtColumnaConsulta);
            this.Controls.Add(this.btnConsulta);
            this.Controls.Add(this.lblCriterioFiltrar);
            this.Controls.Add(this.txtCriterioConsulta);
            this.Controls.Add(this.dgvArticulos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.btnDesconectarse);
            this.Controls.Add(this.btnConectarse);
            this.Cursor = System.Windows.Forms.Cursors.Arrow;
            this.MaximumSize = new System.Drawing.Size(1098, 489);
            this.MinimumSize = new System.Drawing.Size(1098, 489);
            this.Name = "Form1";
            this.Text = "TP2 WINFORM";
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Button btnConectarse;
        private System.Windows.Forms.Button btnDesconectarse;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.TextBox txtCriterioConsulta;
        private System.Windows.Forms.Label lblCriterioFiltrar;
        private System.Windows.Forms.Button btnConsulta;
        private System.Windows.Forms.TextBox txtColumnaConsulta;
        private System.Windows.Forms.Label lblColumaFiltrar;
        private System.Windows.Forms.Button btnMostrarTodo;
    }
}

