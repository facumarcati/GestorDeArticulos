namespace presentacion
{
    partial class frmArticulos
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
            this.btnAgregar = new System.Windows.Forms.Button();
            this.btnModificar = new System.Windows.Forms.Button();
            this.btnEliminar = new System.Windows.Forms.Button();
            this.pbArticulos = new System.Windows.Forms.PictureBox();
            this.btnMostrar = new System.Windows.Forms.Button();
            this.cbxMarca = new System.Windows.Forms.ComboBox();
            this.cbxCategoria = new System.Windows.Forms.ComboBox();
            this.lblMarca = new System.Windows.Forms.Label();
            this.btnFiltrar = new System.Windows.Forms.Button();
            this.lblCategoria = new System.Windows.Forms.Label();
            this.txtFiltro = new System.Windows.Forms.TextBox();
            this.lblFiltroNombre = new System.Windows.Forms.Label();
            this.btnLimpiarFIltro = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.btnFiltrarAvanzado = new System.Windows.Forms.Button();
            this.lblFIltro = new System.Windows.Forms.Label();
            this.rbnMayorPrecio = new System.Windows.Forms.RadioButton();
            this.rbnMenorPrecio = new System.Windows.Forms.RadioButton();
            this.gbOrdenar = new System.Windows.Forms.GroupBox();
            this.rbnMayorId = new System.Windows.Forms.RadioButton();
            this.rbnMenorId = new System.Windows.Forms.RadioButton();
            this.rbnMenorCodigo = new System.Windows.Forms.RadioButton();
            this.rbnMayorCodigo = new System.Windows.Forms.RadioButton();
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            this.gbOrdenar.SuspendLayout();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvArticulos.Location = new System.Drawing.Point(475, 153);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.Size = new System.Drawing.Size(951, 357);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnAgregar.Location = new System.Drawing.Point(715, 531);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 58);
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnModificar.Location = new System.Drawing.Point(874, 531);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 58);
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnEliminar.Location = new System.Drawing.Point(1034, 531);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 58);
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pbArticulos
            // 
            this.pbArticulos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
            this.pbArticulos.Location = new System.Drawing.Point(18, 51);
            this.pbArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(432, 491);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulos.TabIndex = 4;
            this.pbArticulos.TabStop = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnMostrar.Location = new System.Drawing.Point(165, 571);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(135, 71);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar Detalle";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
            this.cbxMarca.Location = new System.Drawing.Point(757, 105);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(127, 28);
            this.cbxMarca.TabIndex = 6;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
            this.cbxCategoria.Location = new System.Drawing.Point(553, 107);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(128, 28);
            this.cbxCategoria.TabIndex = 7;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
            this.lblMarca.Location = new System.Drawing.Point(696, 110);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrar.Location = new System.Drawing.Point(899, 37);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(133, 51);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
            this.lblCategoria.Location = new System.Drawing.Point(471, 113);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 20);
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtFiltro
            // 
            this.txtFiltro.Location = new System.Drawing.Point(482, 66);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(205, 26);
            this.txtFiltro.TabIndex = 11;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
            this.lblFiltroNombre.Location = new System.Drawing.Point(477, 42);
            this.lblFiltroNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(69, 20);
            this.lblFiltroNombre.TabIndex = 12;
            this.lblFiltroNombre.Text = "Nombre:";
            // 
            // btnLimpiarFIltro
            // 
            this.btnLimpiarFIltro.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnLimpiarFIltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFIltro.Location = new System.Drawing.Point(899, 92);
            this.btnLimpiarFIltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnLimpiarFIltro.Name = "btnLimpiarFIltro";
            this.btnLimpiarFIltro.Size = new System.Drawing.Size(133, 51);
            this.btnLimpiarFIltro.TabIndex = 13;
            this.btnLimpiarFIltro.Text = "Limpiar Filtro";
            this.btnLimpiarFIltro.UseVisualStyleBackColor = false;
            this.btnLimpiarFIltro.Click += new System.EventHandler(this.btnLimpiarFIltro_Click);
            // 
            // lblCampo
            // 
            this.lblCampo.AutoSize = true;
            this.lblCampo.Location = new System.Drawing.Point(583, 618);
            this.lblCampo.Name = "lblCampo";
            this.lblCampo.Size = new System.Drawing.Size(60, 20);
            this.lblCampo.TabIndex = 14;
            this.lblCampo.Text = "Campo";
            // 
            // cbxCampo
            // 
            this.cbxCampo.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCampo.FormattingEnabled = true;
            this.cbxCampo.Location = new System.Drawing.Point(649, 615);
            this.cbxCampo.Name = "cbxCampo";
            this.cbxCampo.Size = new System.Drawing.Size(149, 28);
            this.cbxCampo.TabIndex = 15;
            this.cbxCampo.SelectedIndexChanged += new System.EventHandler(this.cbxCampo_SelectedIndexChanged);
            // 
            // cbxCriterio
            // 
            this.cbxCriterio.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCriterio.FormattingEnabled = true;
            this.cbxCriterio.Location = new System.Drawing.Point(876, 615);
            this.cbxCriterio.Name = "cbxCriterio";
            this.cbxCriterio.Size = new System.Drawing.Size(149, 28);
            this.cbxCriterio.TabIndex = 17;
            // 
            // lblCriterio
            // 
            this.lblCriterio.AutoSize = true;
            this.lblCriterio.Location = new System.Drawing.Point(811, 618);
            this.lblCriterio.Name = "lblCriterio";
            this.lblCriterio.Size = new System.Drawing.Size(59, 20);
            this.lblCriterio.TabIndex = 16;
            this.lblCriterio.Text = "Criterio";
            // 
            // txtFiltroAvanzado
            // 
            this.txtFiltroAvanzado.Location = new System.Drawing.Point(1104, 617);
            this.txtFiltroAvanzado.Name = "txtFiltroAvanzado";
            this.txtFiltroAvanzado.Size = new System.Drawing.Size(167, 26);
            this.txtFiltroAvanzado.TabIndex = 18;
            // 
            // btnFiltrarAvanzado
            // 
            this.btnFiltrarAvanzado.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnFiltrarAvanzado.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnFiltrarAvanzado.Location = new System.Drawing.Point(1298, 604);
            this.btnFiltrarAvanzado.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrarAvanzado.Name = "btnFiltrarAvanzado";
            this.btnFiltrarAvanzado.Size = new System.Drawing.Size(110, 51);
            this.btnFiltrarAvanzado.TabIndex = 19;
            this.btnFiltrarAvanzado.Text = "Filtrar";
            this.btnFiltrarAvanzado.UseVisualStyleBackColor = false;
            this.btnFiltrarAvanzado.Click += new System.EventHandler(this.btnFiltrarAvanzado_Click);
            // 
            // lblFIltro
            // 
            this.lblFIltro.AutoSize = true;
            this.lblFIltro.Location = new System.Drawing.Point(1054, 620);
            this.lblFIltro.Name = "lblFIltro";
            this.lblFIltro.Size = new System.Drawing.Size(44, 20);
            this.lblFIltro.TabIndex = 20;
            this.lblFIltro.Text = "Filtro";
            // 
            // rbnMayorPrecio
            // 
            this.rbnMayorPrecio.AutoSize = true;
            this.rbnMayorPrecio.Location = new System.Drawing.Point(257, 33);
            this.rbnMayorPrecio.Name = "rbnMayorPrecio";
            this.rbnMayorPrecio.Size = new System.Drawing.Size(125, 24);
            this.rbnMayorPrecio.TabIndex = 21;
            this.rbnMayorPrecio.TabStop = true;
            this.rbnMayorPrecio.Text = "Mayor Precio";
            this.rbnMayorPrecio.UseVisualStyleBackColor = true;
            this.rbnMayorPrecio.CheckedChanged += new System.EventHandler(this.ordenarDGV);
            this.rbnMayorPrecio.Click += new System.EventHandler(this.ordenarDGV);
            // 
            // rbnMenorPrecio
            // 
            this.rbnMenorPrecio.AutoSize = true;
            this.rbnMenorPrecio.Location = new System.Drawing.Point(257, 64);
            this.rbnMenorPrecio.Name = "rbnMenorPrecio";
            this.rbnMenorPrecio.Size = new System.Drawing.Size(127, 24);
            this.rbnMenorPrecio.TabIndex = 22;
            this.rbnMenorPrecio.TabStop = true;
            this.rbnMenorPrecio.Text = "Menor Precio";
            this.rbnMenorPrecio.UseVisualStyleBackColor = true;
            this.rbnMenorPrecio.CheckedChanged += new System.EventHandler(this.ordenarDGV);
            this.rbnMenorPrecio.Click += new System.EventHandler(this.ordenarDGV);
            // 
            // gbOrdenar
            // 
            this.gbOrdenar.Controls.Add(this.rbnMenorCodigo);
            this.gbOrdenar.Controls.Add(this.rbnMayorCodigo);
            this.gbOrdenar.Controls.Add(this.rbnMenorId);
            this.gbOrdenar.Controls.Add(this.rbnMayorId);
            this.gbOrdenar.Controls.Add(this.rbnMenorPrecio);
            this.gbOrdenar.Controls.Add(this.rbnMayorPrecio);
            this.gbOrdenar.FlatStyle = System.Windows.Forms.FlatStyle.System;
            this.gbOrdenar.Location = new System.Drawing.Point(1039, 29);
            this.gbOrdenar.Name = "gbOrdenar";
            this.gbOrdenar.Size = new System.Drawing.Size(388, 114);
            this.gbOrdenar.TabIndex = 23;
            this.gbOrdenar.TabStop = false;
            this.gbOrdenar.Text = "Ordenar por";
            // 
            // rbnMayorId
            // 
            this.rbnMayorId.AutoSize = true;
            this.rbnMayorId.Location = new System.Drawing.Point(14, 35);
            this.rbnMayorId.Name = "rbnMayorId";
            this.rbnMayorId.Size = new System.Drawing.Size(95, 24);
            this.rbnMayorId.TabIndex = 23;
            this.rbnMayorId.TabStop = true;
            this.rbnMayorId.Text = "Mayor Id";
            this.rbnMayorId.UseVisualStyleBackColor = true;
            this.rbnMayorId.CheckedChanged += new System.EventHandler(this.ordenarDGV);
            // 
            // rbnMenorId
            // 
            this.rbnMenorId.AutoSize = true;
            this.rbnMenorId.Location = new System.Drawing.Point(14, 64);
            this.rbnMenorId.Name = "rbnMenorId";
            this.rbnMenorId.Size = new System.Drawing.Size(97, 24);
            this.rbnMenorId.TabIndex = 24;
            this.rbnMenorId.TabStop = true;
            this.rbnMenorId.Text = "Menor Id";
            this.rbnMenorId.UseVisualStyleBackColor = true;
            this.rbnMenorId.CheckedChanged += new System.EventHandler(this.ordenarDGV);
            // 
            // rbnMenorCodigo
            // 
            this.rbnMenorCodigo.AutoSize = true;
            this.rbnMenorCodigo.Location = new System.Drawing.Point(115, 64);
            this.rbnMenorCodigo.Name = "rbnMenorCodigo";
            this.rbnMenorCodigo.Size = new System.Drawing.Size(133, 24);
            this.rbnMenorCodigo.TabIndex = 26;
            this.rbnMenorCodigo.TabStop = true;
            this.rbnMenorCodigo.Text = "Menor Codigo";
            this.rbnMenorCodigo.UseVisualStyleBackColor = true;
            this.rbnMenorCodigo.CheckedChanged += new System.EventHandler(this.ordenarDGV);
            // 
            // rbnMayorCodigo
            // 
            this.rbnMayorCodigo.AutoSize = true;
            this.rbnMayorCodigo.Location = new System.Drawing.Point(115, 33);
            this.rbnMayorCodigo.Name = "rbnMayorCodigo";
            this.rbnMayorCodigo.Size = new System.Drawing.Size(131, 24);
            this.rbnMayorCodigo.TabIndex = 25;
            this.rbnMayorCodigo.TabStop = true;
            this.rbnMayorCodigo.Text = "Mayor Codigo";
            this.rbnMayorCodigo.UseVisualStyleBackColor = true;
            this.rbnMayorCodigo.CheckedChanged += new System.EventHandler(this.ordenarDGV);
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(9F, 20F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
            this.ClientSize = new System.Drawing.Size(1444, 698);
            this.Controls.Add(this.gbOrdenar);
            this.Controls.Add(this.lblFIltro);
            this.Controls.Add(this.btnFiltrarAvanzado);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnLimpiarFIltro);
            this.Controls.Add(this.lblFiltroNombre);
            this.Controls.Add(this.txtFiltro);
            this.Controls.Add(this.lblCategoria);
            this.Controls.Add(this.btnFiltrar);
            this.Controls.Add(this.lblMarca);
            this.Controls.Add(this.cbxCategoria);
            this.Controls.Add(this.cbxMarca);
            this.Controls.Add(this.btnMostrar);
            this.Controls.Add(this.pbArticulos);
            this.Controls.Add(this.btnEliminar);
            this.Controls.Add(this.btnModificar);
            this.Controls.Add(this.btnAgregar);
            this.Controls.Add(this.dgvArticulos);
            this.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.MaximizeBox = false;
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).EndInit();
            this.gbOrdenar.ResumeLayout(false);
            this.gbOrdenar.PerformLayout();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvArticulos;
        private System.Windows.Forms.Button btnAgregar;
        private System.Windows.Forms.Button btnModificar;
        private System.Windows.Forms.Button btnEliminar;
        private System.Windows.Forms.PictureBox pbArticulos;
        private System.Windows.Forms.Button btnMostrar;
        private System.Windows.Forms.ComboBox cbxMarca;
        private System.Windows.Forms.ComboBox cbxCategoria;
        private System.Windows.Forms.Label lblMarca;
        private System.Windows.Forms.Button btnFiltrar;
        private System.Windows.Forms.Label lblCategoria;
        private System.Windows.Forms.TextBox txtFiltro;
        private System.Windows.Forms.Label lblFiltroNombre;
        private System.Windows.Forms.Button btnLimpiarFIltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button btnFiltrarAvanzado;
        private System.Windows.Forms.Label lblFIltro;
        private System.Windows.Forms.RadioButton rbnMayorPrecio;
        private System.Windows.Forms.RadioButton rbnMenorPrecio;
        private System.Windows.Forms.GroupBox gbOrdenar;
        private System.Windows.Forms.RadioButton rbnMenorId;
        private System.Windows.Forms.RadioButton rbnMayorId;
        private System.Windows.Forms.RadioButton rbnMenorCodigo;
        private System.Windows.Forms.RadioButton rbnMayorCodigo;
    }
}

