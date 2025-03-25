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
<<<<<<< HEAD
            this.btnLimpiarFIltro = new System.Windows.Forms.Button();
            this.lblCampo = new System.Windows.Forms.Label();
            this.cbxCampo = new System.Windows.Forms.ComboBox();
            this.cbxCriterio = new System.Windows.Forms.ComboBox();
            this.lblCriterio = new System.Windows.Forms.Label();
            this.txtFiltroAvanzado = new System.Windows.Forms.TextBox();
            this.button1 = new System.Windows.Forms.Button();
            this.lblFIltro = new System.Windows.Forms.Label();
=======
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvArticulos
            // 
            this.dgvArticulos.BackgroundColor = System.Drawing.SystemColors.ControlLightLight;
            this.dgvArticulos.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
<<<<<<< HEAD
            this.dgvArticulos.Location = new System.Drawing.Point(476, 128);
            this.dgvArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
=======
            this.dgvArticulos.Location = new System.Drawing.Point(317, 83);
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            this.dgvArticulos.Name = "dgvArticulos";
            this.dgvArticulos.RowHeadersWidth = 62;
            this.dgvArticulos.Size = new System.Drawing.Size(634, 232);
            this.dgvArticulos.TabIndex = 0;
            this.dgvArticulos.SelectionChanged += new System.EventHandler(this.dgvArticulos_SelectionChanged);
            // 
            // btnAgregar
            // 
            this.btnAgregar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnAgregar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnAgregar.Location = new System.Drawing.Point(717, 515);
            this.btnAgregar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(135, 58);
=======
            this.btnAgregar.Location = new System.Drawing.Point(478, 335);
            this.btnAgregar.Name = "btnAgregar";
            this.btnAgregar.Size = new System.Drawing.Size(90, 46);
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            this.btnAgregar.TabIndex = 1;
            this.btnAgregar.Text = "Agregar";
            this.btnAgregar.UseVisualStyleBackColor = false;
            this.btnAgregar.Click += new System.EventHandler(this.btnAgregar_Click);
            // 
            // btnModificar
            // 
            this.btnModificar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnModificar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnModificar.Location = new System.Drawing.Point(876, 515);
            this.btnModificar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(135, 58);
=======
            this.btnModificar.Location = new System.Drawing.Point(584, 335);
            this.btnModificar.Name = "btnModificar";
            this.btnModificar.Size = new System.Drawing.Size(90, 46);
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            this.btnModificar.TabIndex = 2;
            this.btnModificar.Text = "Modificar";
            this.btnModificar.UseVisualStyleBackColor = false;
            this.btnModificar.Click += new System.EventHandler(this.btnModificar_Click);
            // 
            // btnEliminar
            // 
            this.btnEliminar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnEliminar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnEliminar.Location = new System.Drawing.Point(1036, 515);
            this.btnEliminar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(135, 58);
=======
            this.btnEliminar.Location = new System.Drawing.Point(691, 335);
            this.btnEliminar.Name = "btnEliminar";
            this.btnEliminar.Size = new System.Drawing.Size(90, 46);
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            this.btnEliminar.TabIndex = 3;
            this.btnEliminar.Text = "Eliminar";
            this.btnEliminar.UseVisualStyleBackColor = false;
            this.btnEliminar.Click += new System.EventHandler(this.btnEliminar_Click);
            // 
            // pbArticulos
            // 
            this.pbArticulos.BackColor = System.Drawing.SystemColors.ControlLightLight;
            this.pbArticulos.BorderStyle = System.Windows.Forms.BorderStyle.FixedSingle;
<<<<<<< HEAD
            this.pbArticulos.Location = new System.Drawing.Point(18, 51);
            this.pbArticulos.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
=======
            this.pbArticulos.Location = new System.Drawing.Point(12, 33);
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            this.pbArticulos.Name = "pbArticulos";
            this.pbArticulos.Size = new System.Drawing.Size(289, 320);
            this.pbArticulos.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pbArticulos.TabIndex = 4;
            this.pbArticulos.TabStop = false;
            // 
            // btnMostrar
            // 
            this.btnMostrar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnMostrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnMostrar.Location = new System.Drawing.Point(165, 571);
            this.btnMostrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
=======
            this.btnMostrar.Location = new System.Drawing.Point(110, 371);
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            this.btnMostrar.Name = "btnMostrar";
            this.btnMostrar.Size = new System.Drawing.Size(90, 46);
            this.btnMostrar.TabIndex = 5;
            this.btnMostrar.Text = "Mostrar Detalle";
            this.btnMostrar.UseVisualStyleBackColor = false;
            this.btnMostrar.Click += new System.EventHandler(this.btnMostrar_Click);
            // 
            // cbxMarca
            // 
            this.cbxMarca.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxMarca.FormattingEnabled = true;
<<<<<<< HEAD
            this.cbxMarca.Location = new System.Drawing.Point(760, 49);
            this.cbxMarca.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(127, 28);
=======
            this.cbxMarca.Location = new System.Drawing.Point(534, 34);
            this.cbxMarca.Name = "cbxMarca";
            this.cbxMarca.Size = new System.Drawing.Size(105, 21);
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            this.cbxMarca.TabIndex = 6;
            // 
            // cbxCategoria
            // 
            this.cbxCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbxCategoria.FormattingEnabled = true;
<<<<<<< HEAD
            this.cbxCategoria.Location = new System.Drawing.Point(556, 51);
            this.cbxCategoria.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(128, 28);
=======
            this.cbxCategoria.Location = new System.Drawing.Point(371, 33);
            this.cbxCategoria.Name = "cbxCategoria";
            this.cbxCategoria.Size = new System.Drawing.Size(106, 21);
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            this.cbxCategoria.TabIndex = 7;
            // 
            // lblMarca
            // 
            this.lblMarca.AutoSize = true;
<<<<<<< HEAD
            this.lblMarca.Location = new System.Drawing.Point(699, 57);
            this.lblMarca.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(53, 20);
=======
            this.lblMarca.Location = new System.Drawing.Point(491, 38);
            this.lblMarca.Name = "lblMarca";
            this.lblMarca.Size = new System.Drawing.Size(37, 13);
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            this.lblMarca.TabIndex = 8;
            this.lblMarca.Text = "Marca";
            // 
            // btnFiltrar
            // 
            this.btnFiltrar.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnFiltrar.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
<<<<<<< HEAD
            this.btnFiltrar.Location = new System.Drawing.Point(901, 41);
            this.btnFiltrar.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(110, 51);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
            this.btnFiltrar.Click += new System.EventHandler(this.btnFiltrar_Click);
=======
            this.btnFiltrar.Location = new System.Drawing.Point(654, 30);
            this.btnFiltrar.Name = "btnFiltrar";
            this.btnFiltrar.Size = new System.Drawing.Size(94, 33);
            this.btnFiltrar.TabIndex = 9;
            this.btnFiltrar.Text = "Filtrar";
            this.btnFiltrar.UseVisualStyleBackColor = false;
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            // 
            // lblCategoria
            // 
            this.lblCategoria.AutoSize = true;
<<<<<<< HEAD
            this.lblCategoria.Location = new System.Drawing.Point(474, 57);
            this.lblCategoria.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(78, 20);
=======
            this.lblCategoria.Location = new System.Drawing.Point(316, 37);
            this.lblCategoria.Name = "lblCategoria";
            this.lblCategoria.Size = new System.Drawing.Size(52, 13);
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            this.lblCategoria.TabIndex = 10;
            this.lblCategoria.Text = "Categoria";
            // 
            // txtFiltro
            // 
<<<<<<< HEAD
            this.txtFiltro.Location = new System.Drawing.Point(1203, 52);
            this.txtFiltro.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(205, 26);
            this.txtFiltro.TabIndex = 11;
            this.txtFiltro.TextChanged += new System.EventHandler(this.txtFiltro_TextChanged);
=======
            this.txtFiltro.Location = new System.Drawing.Point(802, 34);
            this.txtFiltro.Name = "txtFiltro";
            this.txtFiltro.Size = new System.Drawing.Size(138, 20);
            this.txtFiltro.TabIndex = 11;
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            // 
            // lblFiltroNombre
            // 
            this.lblFiltroNombre.AutoSize = true;
<<<<<<< HEAD
            this.lblFiltroNombre.Location = new System.Drawing.Point(1198, 28);
            this.lblFiltroNombre.Margin = new System.Windows.Forms.Padding(4, 0, 4, 0);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(104, 20);
            this.lblFiltroNombre.TabIndex = 12;
            this.lblFiltroNombre.Text = "Filtro Nombre";
            // 
            // btnLimpiarFIltro
            // 
            this.btnLimpiarFIltro.BackColor = System.Drawing.Color.AntiqueWhite;
            this.btnLimpiarFIltro.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnLimpiarFIltro.Location = new System.Drawing.Point(1019, 41);
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
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.AntiqueWhite;
            this.button1.Font = new System.Drawing.Font("Microsoft Sans Serif", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.Location = new System.Drawing.Point(1298, 604);
            this.button1.Margin = new System.Windows.Forms.Padding(4, 5, 4, 5);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(110, 51);
            this.button1.TabIndex = 19;
            this.button1.Text = "Filtrar";
            this.button1.UseVisualStyleBackColor = false;
            // 
            // lblFIltro
            // 
            this.lblFIltro.AutoSize = true;
            this.lblFIltro.Location = new System.Drawing.Point(1054, 620);
            this.lblFIltro.Name = "lblFIltro";
            this.lblFIltro.Size = new System.Drawing.Size(44, 20);
            this.lblFIltro.TabIndex = 20;
            this.lblFIltro.Text = "Filtro";
=======
            this.lblFiltroNombre.Location = new System.Drawing.Point(799, 18);
            this.lblFiltroNombre.Name = "lblFiltroNombre";
            this.lblFiltroNombre.Size = new System.Drawing.Size(69, 13);
            this.lblFiltroNombre.TabIndex = 12;
            this.lblFiltroNombre.Text = "Filtro Nombre";
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
            // 
            // frmArticulos
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.Moccasin;
<<<<<<< HEAD
            this.ClientSize = new System.Drawing.Size(1444, 698);
            this.Controls.Add(this.lblFIltro);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.txtFiltroAvanzado);
            this.Controls.Add(this.cbxCriterio);
            this.Controls.Add(this.lblCriterio);
            this.Controls.Add(this.cbxCampo);
            this.Controls.Add(this.lblCampo);
            this.Controls.Add(this.btnLimpiarFIltro);
=======
            this.ClientSize = new System.Drawing.Size(963, 430);
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
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
            this.MaximizeBox = false;
            this.Name = "frmArticulos";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Gestion de Articulos";
            this.WindowState = System.Windows.Forms.FormWindowState.Minimized;
            this.Load += new System.EventHandler(this.Form1_Load);
            ((System.ComponentModel.ISupportInitialize)(this.dgvArticulos)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pbArticulos)).EndInit();
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
<<<<<<< HEAD
        private System.Windows.Forms.Button btnLimpiarFIltro;
        private System.Windows.Forms.Label lblCampo;
        private System.Windows.Forms.ComboBox cbxCampo;
        private System.Windows.Forms.ComboBox cbxCriterio;
        private System.Windows.Forms.Label lblCriterio;
        private System.Windows.Forms.TextBox txtFiltroAvanzado;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.Label lblFIltro;
=======
>>>>>>> 9282c1c6f9f30489069c25278cf7e47c72e6b17a
    }
}

