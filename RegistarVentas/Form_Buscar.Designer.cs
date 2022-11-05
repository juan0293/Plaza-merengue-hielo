namespace RegistarVentas
{
    partial class Form_Buscar
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
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Buscar));
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle6 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbProducto = new System.Windows.Forms.Label();
            this.cboCategoria = new System.Windows.Forms.ComboBox();
            this.rdbcategoria = new System.Windows.Forms.RadioButton();
            this.rdbCodigo = new System.Windows.Forms.RadioButton();
            this.rdb_nombre = new System.Windows.Forms.RadioButton();
            this.txtBuscar = new System.Windows.Forms.TextBox();
            this.pictureBox4 = new System.Windows.Forms.PictureBox();
            this.label2 = new System.Windows.Forms.Label();
            this.dgvproducto = new System.Windows.Forms.DataGridView();
            this.agregar = new System.Windows.Forms.DataGridViewButtonColumn();
            this.Column1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column2 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column3 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column4 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Column5 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoIDDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.codigoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.nombreDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoriaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplidorDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descripcionProductoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.estatusDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.precionetoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.preciosalidaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.impuestoDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.fechaentradaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itbisDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.categoria1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalleVentaDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.inventarioDataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.suplidor1DataGridViewTextBoxColumn = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.productoBindingSource = new System.Windows.Forms.BindingSource(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).BeginInit();
            this.SuspendLayout();
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(585, 92);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(41, 36);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 84;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(11, 102);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(70, 22);
            this.label1.TabIndex = 83;
            this.label1.Text = "Buscar";
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.ForeColor = System.Drawing.Color.DimGray;
            this.lbProducto.Location = new System.Drawing.Point(264, 22);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(147, 32);
            this.lbProducto.TabIndex = 82;
            this.lbProducto.Text = " Productos";
            // 
            // cboCategoria
            // 
            this.cboCategoria.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboCategoria.Enabled = false;
            this.cboCategoria.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboCategoria.FormattingEnabled = true;
            this.cboCategoria.Location = new System.Drawing.Point(374, 101);
            this.cboCategoria.Name = "cboCategoria";
            this.cboCategoria.Size = new System.Drawing.Size(196, 27);
            this.cboCategoria.TabIndex = 81;
            this.cboCategoria.SelectedIndexChanged += new System.EventHandler(this.cboCategoria_SelectedIndexChanged);
            // 
            // rdbcategoria
            // 
            this.rdbcategoria.AutoSize = true;
            this.rdbcategoria.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbcategoria.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbcategoria.ForeColor = System.Drawing.Color.DimGray;
            this.rdbcategoria.Location = new System.Drawing.Point(374, 72);
            this.rdbcategoria.Name = "rdbcategoria";
            this.rdbcategoria.Size = new System.Drawing.Size(96, 23);
            this.rdbcategoria.TabIndex = 80;
            this.rdbcategoria.TabStop = true;
            this.rdbcategoria.Text = "Categoria";
            this.rdbcategoria.UseVisualStyleBackColor = true;
            this.rdbcategoria.CheckedChanged += new System.EventHandler(this.rdbcategoria_CheckedChanged);
            // 
            // rdbCodigo
            // 
            this.rdbCodigo.AutoSize = true;
            this.rdbCodigo.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdbCodigo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdbCodigo.ForeColor = System.Drawing.Color.DimGray;
            this.rdbCodigo.Location = new System.Drawing.Point(173, 72);
            this.rdbCodigo.Name = "rdbCodigo";
            this.rdbCodigo.Size = new System.Drawing.Size(76, 23);
            this.rdbCodigo.TabIndex = 79;
            this.rdbCodigo.TabStop = true;
            this.rdbCodigo.Text = "Codigo";
            this.rdbCodigo.UseVisualStyleBackColor = true;
            // 
            // rdb_nombre
            // 
            this.rdb_nombre.AutoSize = true;
            this.rdb_nombre.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.rdb_nombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_nombre.ForeColor = System.Drawing.Color.DimGray;
            this.rdb_nombre.Location = new System.Drawing.Point(83, 72);
            this.rdb_nombre.Name = "rdb_nombre";
            this.rdb_nombre.Size = new System.Drawing.Size(84, 23);
            this.rdb_nombre.TabIndex = 78;
            this.rdb_nombre.TabStop = true;
            this.rdb_nombre.Text = "Nombre";
            this.rdb_nombre.UseVisualStyleBackColor = true;
            // 
            // txtBuscar
            // 
            this.txtBuscar.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtBuscar.Location = new System.Drawing.Point(83, 101);
            this.txtBuscar.Name = "txtBuscar";
            this.txtBuscar.Size = new System.Drawing.Size(285, 26);
            this.txtBuscar.TabIndex = 77;
            this.txtBuscar.TextChanged += new System.EventHandler(this.txtBuscar_TextChanged);
            // 
            // pictureBox4
            // 
            this.pictureBox4.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox4.Image")));
            this.pictureBox4.Location = new System.Drawing.Point(2, -1);
            this.pictureBox4.Name = "pictureBox4";
            this.pictureBox4.Size = new System.Drawing.Size(54, 45);
            this.pictureBox4.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox4.TabIndex = 86;
            this.pictureBox4.TabStop = false;
            this.pictureBox4.Click += new System.EventHandler(this.pictureBox4_Click);
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.DimGray;
            this.label2.Location = new System.Drawing.Point(3, 45);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(48, 19);
            this.label2.TabIndex = 87;
            this.label2.Text = "Atrás";
            // 
            // dgvproducto
            // 
            this.dgvproducto.AllowUserToAddRows = false;
            this.dgvproducto.AutoGenerateColumns = false;
            this.dgvproducto.AutoSizeRowsMode = System.Windows.Forms.DataGridViewAutoSizeRowsMode.AllCells;
            this.dgvproducto.BackgroundColor = System.Drawing.Color.White;
            this.dgvproducto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvproducto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvproducto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvproducto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.agregar,
            this.Column1,
            this.Column2,
            this.Column3,
            this.Column4,
            this.Column5,
            this.codigoIDDataGridViewTextBoxColumn,
            this.codigoDataGridViewTextBoxColumn,
            this.nombreDataGridViewTextBoxColumn,
            this.categoriaDataGridViewTextBoxColumn,
            this.suplidorDataGridViewTextBoxColumn,
            this.descripcionProductoDataGridViewTextBoxColumn,
            this.estatusDataGridViewTextBoxColumn,
            this.precionetoDataGridViewTextBoxColumn,
            this.preciosalidaDataGridViewTextBoxColumn,
            this.impuestoDataGridViewTextBoxColumn,
            this.fechaentradaDataGridViewTextBoxColumn,
            this.itbisDataGridViewTextBoxColumn,
            this.categoria1DataGridViewTextBoxColumn,
            this.detalleVentaDataGridViewTextBoxColumn,
            this.inventarioDataGridViewTextBoxColumn,
            this.suplidor1DataGridViewTextBoxColumn});
            this.dgvproducto.DataSource = this.productoBindingSource;
            dataGridViewCellStyle6.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopLeft;
            dataGridViewCellStyle6.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle6.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.SelectionBackColor = System.Drawing.SystemColors.ControlLight;
            dataGridViewCellStyle6.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle6.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvproducto.DefaultCellStyle = dataGridViewCellStyle6;
            this.dgvproducto.EnableHeadersVisualStyles = false;
            this.dgvproducto.Location = new System.Drawing.Point(8, 143);
            this.dgvproducto.Name = "dgvproducto";
            this.dgvproducto.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvproducto.RowHeadersVisible = false;
            this.dgvproducto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvproducto.Size = new System.Drawing.Size(715, 376);
            this.dgvproducto.TabIndex = 85;
            this.dgvproducto.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvproducto_CellContentClick);
            this.dgvproducto.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvproducto_CellFormatting);
            this.dgvproducto.DoubleClick += new System.EventHandler(this.dgvproducto_DoubleClick);
            // 
            // agregar
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle2.BackColor = System.Drawing.Color.Lavender;
            dataGridViewCellStyle2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle2.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle2.SelectionBackColor = System.Drawing.SystemColors.GradientActiveCaption;
            dataGridViewCellStyle2.SelectionForeColor = System.Drawing.Color.Black;
            this.agregar.DefaultCellStyle = dataGridViewCellStyle2;
            this.agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.agregar.HeaderText = "";
            this.agregar.MinimumWidth = 10;
            this.agregar.Name = "agregar";
            this.agregar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.agregar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            this.agregar.Width = 50;
            // 
            // Column1
            // 
            this.Column1.DataPropertyName = "Codigo_ID";
            dataGridViewCellStyle3.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column1.DefaultCellStyle = dataGridViewCellStyle3;
            this.Column1.HeaderText = "ID";
            this.Column1.Name = "Column1";
            this.Column1.ReadOnly = true;
            // 
            // Column2
            // 
            this.Column2.DataPropertyName = "codigo";
            this.Column2.HeaderText = "CODIGO";
            this.Column2.Name = "Column2";
            this.Column2.ReadOnly = true;
            // 
            // Column3
            // 
            this.Column3.DataPropertyName = "Nombre";
            this.Column3.HeaderText = "NOMBRE";
            this.Column3.Name = "Column3";
            this.Column3.ReadOnly = true;
            this.Column3.Width = 320;
            // 
            // Column4
            // 
            this.Column4.DataPropertyName = "precio_salida";
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Column4.DefaultCellStyle = dataGridViewCellStyle4;
            this.Column4.HeaderText = "PRECIO";
            this.Column4.Name = "Column4";
            this.Column4.ReadOnly = true;
            this.Column4.Width = 140;
            // 
            // Column5
            // 
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            this.Column5.DefaultCellStyle = dataGridViewCellStyle5;
            this.Column5.HeaderText = "EXISTENCIA";
            this.Column5.Name = "Column5";
            this.Column5.ReadOnly = true;
            this.Column5.Visible = false;
            this.Column5.Width = 150;
            // 
            // codigoIDDataGridViewTextBoxColumn
            // 
            this.codigoIDDataGridViewTextBoxColumn.DataPropertyName = "Codigo_ID";
            this.codigoIDDataGridViewTextBoxColumn.HeaderText = "Codigo_ID";
            this.codigoIDDataGridViewTextBoxColumn.Name = "codigoIDDataGridViewTextBoxColumn";
            // 
            // codigoDataGridViewTextBoxColumn
            // 
            this.codigoDataGridViewTextBoxColumn.DataPropertyName = "codigo";
            this.codigoDataGridViewTextBoxColumn.HeaderText = "codigo";
            this.codigoDataGridViewTextBoxColumn.Name = "codigoDataGridViewTextBoxColumn";
            // 
            // nombreDataGridViewTextBoxColumn
            // 
            this.nombreDataGridViewTextBoxColumn.DataPropertyName = "Nombre";
            this.nombreDataGridViewTextBoxColumn.HeaderText = "Nombre";
            this.nombreDataGridViewTextBoxColumn.Name = "nombreDataGridViewTextBoxColumn";
            // 
            // categoriaDataGridViewTextBoxColumn
            // 
            this.categoriaDataGridViewTextBoxColumn.DataPropertyName = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.HeaderText = "Categoria";
            this.categoriaDataGridViewTextBoxColumn.Name = "categoriaDataGridViewTextBoxColumn";
            // 
            // suplidorDataGridViewTextBoxColumn
            // 
            this.suplidorDataGridViewTextBoxColumn.DataPropertyName = "Suplidor";
            this.suplidorDataGridViewTextBoxColumn.HeaderText = "Suplidor";
            this.suplidorDataGridViewTextBoxColumn.Name = "suplidorDataGridViewTextBoxColumn";
            // 
            // descripcionProductoDataGridViewTextBoxColumn
            // 
            this.descripcionProductoDataGridViewTextBoxColumn.DataPropertyName = "Descripcion_Producto";
            this.descripcionProductoDataGridViewTextBoxColumn.HeaderText = "Descripcion_Producto";
            this.descripcionProductoDataGridViewTextBoxColumn.Name = "descripcionProductoDataGridViewTextBoxColumn";
            // 
            // estatusDataGridViewTextBoxColumn
            // 
            this.estatusDataGridViewTextBoxColumn.DataPropertyName = "estatus";
            this.estatusDataGridViewTextBoxColumn.HeaderText = "estatus";
            this.estatusDataGridViewTextBoxColumn.Name = "estatusDataGridViewTextBoxColumn";
            // 
            // precionetoDataGridViewTextBoxColumn
            // 
            this.precionetoDataGridViewTextBoxColumn.DataPropertyName = "precio_neto";
            this.precionetoDataGridViewTextBoxColumn.HeaderText = "precio_neto";
            this.precionetoDataGridViewTextBoxColumn.Name = "precionetoDataGridViewTextBoxColumn";
            // 
            // preciosalidaDataGridViewTextBoxColumn
            // 
            this.preciosalidaDataGridViewTextBoxColumn.DataPropertyName = "precio_salida";
            this.preciosalidaDataGridViewTextBoxColumn.HeaderText = "precio_salida";
            this.preciosalidaDataGridViewTextBoxColumn.Name = "preciosalidaDataGridViewTextBoxColumn";
            // 
            // impuestoDataGridViewTextBoxColumn
            // 
            this.impuestoDataGridViewTextBoxColumn.DataPropertyName = "impuesto";
            this.impuestoDataGridViewTextBoxColumn.HeaderText = "impuesto";
            this.impuestoDataGridViewTextBoxColumn.Name = "impuestoDataGridViewTextBoxColumn";
            // 
            // fechaentradaDataGridViewTextBoxColumn
            // 
            this.fechaentradaDataGridViewTextBoxColumn.DataPropertyName = "fecha_entrada";
            this.fechaentradaDataGridViewTextBoxColumn.HeaderText = "fecha_entrada";
            this.fechaentradaDataGridViewTextBoxColumn.Name = "fechaentradaDataGridViewTextBoxColumn";
            // 
            // itbisDataGridViewTextBoxColumn
            // 
            this.itbisDataGridViewTextBoxColumn.DataPropertyName = "itbis";
            this.itbisDataGridViewTextBoxColumn.HeaderText = "itbis";
            this.itbisDataGridViewTextBoxColumn.Name = "itbisDataGridViewTextBoxColumn";
            // 
            // categoria1DataGridViewTextBoxColumn
            // 
            this.categoria1DataGridViewTextBoxColumn.DataPropertyName = "categoria1";
            this.categoria1DataGridViewTextBoxColumn.HeaderText = "categoria1";
            this.categoria1DataGridViewTextBoxColumn.Name = "categoria1DataGridViewTextBoxColumn";
            // 
            // detalleVentaDataGridViewTextBoxColumn
            // 
            this.detalleVentaDataGridViewTextBoxColumn.DataPropertyName = "detalleVenta";
            this.detalleVentaDataGridViewTextBoxColumn.HeaderText = "detalleVenta";
            this.detalleVentaDataGridViewTextBoxColumn.Name = "detalleVentaDataGridViewTextBoxColumn";
            // 
            // inventarioDataGridViewTextBoxColumn
            // 
            this.inventarioDataGridViewTextBoxColumn.DataPropertyName = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.HeaderText = "Inventario";
            this.inventarioDataGridViewTextBoxColumn.Name = "inventarioDataGridViewTextBoxColumn";
            // 
            // suplidor1DataGridViewTextBoxColumn
            // 
            this.suplidor1DataGridViewTextBoxColumn.DataPropertyName = "suplidor1";
            this.suplidor1DataGridViewTextBoxColumn.HeaderText = "suplidor1";
            this.suplidor1DataGridViewTextBoxColumn.Name = "suplidor1DataGridViewTextBoxColumn";
            // 
            // productoBindingSource
            // 
            this.productoBindingSource.DataSource = typeof(RegistarVentas.Producto);
            // 
            // Form_Buscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(730, 522);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.pictureBox4);
            this.Controls.Add(this.dgvproducto);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.cboCategoria);
            this.Controls.Add(this.rdbcategoria);
            this.Controls.Add(this.rdbCodigo);
            this.Controls.Add(this.rdb_nombre);
            this.Controls.Add(this.txtBuscar);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(750, 565);
            this.MinimumSize = new System.Drawing.Size(750, 565);
            this.Name = "Form_Buscar";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Productos ";
            this.Load += new System.EventHandler(this.Form_Buscar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Buscar_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox4)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.dgvproducto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.productoBindingSource)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.ComboBox cboCategoria;
        private System.Windows.Forms.RadioButton rdbcategoria;
        private System.Windows.Forms.RadioButton rdbCodigo;
        private System.Windows.Forms.RadioButton rdb_nombre;
        private System.Windows.Forms.PictureBox pictureBox4;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DataGridView dgvproducto;
        private System.Windows.Forms.BindingSource productoBindingSource;
        private System.Windows.Forms.DataGridViewButtonColumn agregar;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column1;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column2;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column3;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column4;
        private System.Windows.Forms.DataGridViewTextBoxColumn Column5;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoIDDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn codigoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn nombreDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoriaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplidorDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn descripcionProductoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn estatusDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn precionetoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn preciosalidaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn impuestoDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn fechaentradaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn itbisDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn categoria1DataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalleVentaDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn inventarioDataGridViewTextBoxColumn;
        private System.Windows.Forms.DataGridViewTextBoxColumn suplidor1DataGridViewTextBoxColumn;
        public System.Windows.Forms.TextBox txtBuscar;
    }
}