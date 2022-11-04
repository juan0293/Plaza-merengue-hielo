namespace RegistarVentas
{
    partial class Form_cotizacion
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle1 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_cotizacion));
            this.lbProducto = new System.Windows.Forms.Label();
            this.dgvCategoras = new System.Windows.Forms.DataGridView();
            this.idproucto = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Nombre = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.detalle = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.cantidad = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.subtotal = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.itbis = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.condicion = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.quitar = new System.Windows.Forms.DataGridViewImageColumn();
            this.txt_buscar_codigo = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.txt_total = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_nombre_cotizacion = new System.Windows.Forms.TextBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_direccion_cotizacion = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_telefono_cotizacion = new System.Windows.Forms.TextBox();
            this.dataGridViewImageColumn1 = new System.Windows.Forms.DataGridViewImageColumn();
            this.button1 = new System.Windows.Forms.Button();
            this.pictureBox3 = new System.Windows.Forms.PictureBox();
            this.picBuscar = new System.Windows.Forms.PictureBox();
            this.cbo_factura = new System.Windows.Forms.ComboBox();
            this.label6 = new System.Windows.Forms.Label();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_rnc = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.button2 = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).BeginInit();
            this.SuspendLayout();
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Cambria", 26.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.ForeColor = System.Drawing.Color.DimGray;
            this.lbProducto.Location = new System.Drawing.Point(449, 10);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(186, 41);
            this.lbProducto.TabIndex = 137;
            this.lbProducto.Text = "Cotización";
            // 
            // dgvCategoras
            // 
            this.dgvCategoras.AllowUserToAddRows = false;
            this.dgvCategoras.BackgroundColor = System.Drawing.Color.White;
            this.dgvCategoras.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvCategoras.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvCategoras.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvCategoras.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.idproucto,
            this.Nombre,
            this.detalle,
            this.cantidad,
            this.subtotal,
            this.Total,
            this.id,
            this.itbis,
            this.condicion,
            this.quitar});
            dataGridViewCellStyle4.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle4.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle4.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.SelectionBackColor = System.Drawing.Color.LightGray;
            dataGridViewCellStyle4.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle4.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvCategoras.DefaultCellStyle = dataGridViewCellStyle4;
            this.dgvCategoras.EnableHeadersVisualStyles = false;
            this.dgvCategoras.Location = new System.Drawing.Point(0, 220);
            this.dgvCategoras.Name = "dgvCategoras";
            this.dgvCategoras.RowHeadersBorderStyle = System.Windows.Forms.DataGridViewHeaderBorderStyle.None;
            this.dgvCategoras.RowHeadersVisible = false;
            this.dgvCategoras.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvCategoras.Size = new System.Drawing.Size(1027, 407);
            this.dgvCategoras.TabIndex = 138;
            this.dgvCategoras.CellContentClick += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellContentClick);
            this.dgvCategoras.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvCategorias_CellEndEdit);
            this.dgvCategoras.CellFormatting += new System.Windows.Forms.DataGridViewCellFormattingEventHandler(this.dgvCategorias_CellFormatting);
            this.dgvCategoras.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvCategorias_EditingControlShowing);
            // 
            // idproucto
            // 
            this.idproucto.HeaderText = "Codigo";
            this.idproucto.Name = "idproucto";
            this.idproucto.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.idproucto.Width = 200;
            // 
            // Nombre
            // 
            this.Nombre.HeaderText = "Nombre";
            this.Nombre.Name = "Nombre";
            this.Nombre.Width = 300;
            // 
            // detalle
            // 
            this.detalle.HeaderText = "Detalle";
            this.detalle.Name = "detalle";
            this.detalle.Visible = false;
            this.detalle.Width = 200;
            // 
            // cantidad
            // 
            this.cantidad.HeaderText = "Cantidad";
            this.cantidad.Name = "cantidad";
            this.cantidad.Width = 140;
            // 
            // subtotal
            // 
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.subtotal.DefaultCellStyle = dataGridViewCellStyle2;
            this.subtotal.HeaderText = "Subtotal";
            this.subtotal.Name = "subtotal";
            // 
            // Total
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.Total.DefaultCellStyle = dataGridViewCellStyle3;
            this.Total.HeaderText = "Total";
            this.Total.Name = "Total";
            this.Total.ReadOnly = true;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // itbis
            // 
            this.itbis.HeaderText = "itbis";
            this.itbis.Name = "itbis";
            this.itbis.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.itbis.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.NotSortable;
            this.itbis.Visible = false;
            // 
            // condicion
            // 
            this.condicion.HeaderText = "condicion";
            this.condicion.Name = "condicion";
            this.condicion.Visible = false;
            // 
            // quitar
            // 
            this.quitar.HeaderText = "Eliminar";
            this.quitar.Image = ((System.Drawing.Image)(resources.GetObject("quitar.Image")));
            this.quitar.Name = "quitar";
            this.quitar.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.quitar.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // txt_buscar_codigo
            // 
            this.txt_buscar_codigo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_buscar_codigo.Location = new System.Drawing.Point(50, 102);
            this.txt_buscar_codigo.MaxLength = 30;
            this.txt_buscar_codigo.Name = "txt_buscar_codigo";
            this.txt_buscar_codigo.Size = new System.Drawing.Size(294, 26);
            this.txt_buscar_codigo.TabIndex = 0;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(12, 193);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(59, 22);
            this.label1.TabIndex = 144;
            this.label1.Text = "Total:";
            // 
            // txt_total
            // 
            this.txt_total.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_total.Location = new System.Drawing.Point(77, 191);
            this.txt_total.Name = "txt_total";
            this.txt_total.ReadOnly = true;
            this.txt_total.Size = new System.Drawing.Size(141, 26);
            this.txt_total.TabIndex = 143;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(511, 132);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(76, 22);
            this.label3.TabIndex = 148;
            this.label3.Text = "Cliente:";
            // 
            // txt_nombre_cotizacion
            // 
            this.txt_nombre_cotizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_nombre_cotizacion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_nombre_cotizacion.Location = new System.Drawing.Point(591, 131);
            this.txt_nombre_cotizacion.MaxLength = 100;
            this.txt_nombre_cotizacion.Name = "txt_nombre_cotizacion";
            this.txt_nombre_cotizacion.Size = new System.Drawing.Size(256, 26);
            this.txt_nombre_cotizacion.TabIndex = 3;
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(488, 160);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(99, 22);
            this.label4.TabIndex = 150;
            this.label4.Text = "Dirección:";
            // 
            // txt_direccion_cotizacion
            // 
            this.txt_direccion_cotizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_direccion_cotizacion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_direccion_cotizacion.Location = new System.Drawing.Point(591, 160);
            this.txt_direccion_cotizacion.MaxLength = 100;
            this.txt_direccion_cotizacion.Name = "txt_direccion_cotizacion";
            this.txt_direccion_cotizacion.Size = new System.Drawing.Size(256, 26);
            this.txt_direccion_cotizacion.TabIndex = 4;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(497, 188);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(90, 22);
            this.label5.TabIndex = 152;
            this.label5.Text = "Teléfono:";
            // 
            // txt_telefono_cotizacion
            // 
            this.txt_telefono_cotizacion.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_telefono_cotizacion.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono_cotizacion.Location = new System.Drawing.Point(591, 188);
            this.txt_telefono_cotizacion.MaxLength = 100;
            this.txt_telefono_cotizacion.Name = "txt_telefono_cotizacion";
            this.txt_telefono_cotizacion.Size = new System.Drawing.Size(256, 26);
            this.txt_telefono_cotizacion.TabIndex = 5;
            // 
            // dataGridViewImageColumn1
            // 
            this.dataGridViewImageColumn1.HeaderText = "Eliminar";
            this.dataGridViewImageColumn1.Image = ((System.Drawing.Image)(resources.GetObject("dataGridViewImageColumn1.Image")));
            this.dataGridViewImageColumn1.Name = "dataGridViewImageColumn1";
            this.dataGridViewImageColumn1.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.dataGridViewImageColumn1.SortMode = System.Windows.Forms.DataGridViewColumnSortMode.Automatic;
            // 
            // button1
            // 
            this.button1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            this.button1.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button1.ForeColor = System.Drawing.Color.White;
            this.button1.Image = ((System.Drawing.Image)(resources.GetObject("button1.Image")));
            this.button1.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button1.Location = new System.Drawing.Point(878, 77);
            this.button1.Name = "button1";
            this.button1.Size = new System.Drawing.Size(149, 54);
            this.button1.TabIndex = 7;
            this.button1.Text = "      Guardar";
            this.button1.UseVisualStyleBackColor = false;
            this.button1.Click += new System.EventHandler(this.button1_Click);
            // 
            // pictureBox3
            // 
            this.pictureBox3.Image = ((System.Drawing.Image)(resources.GetObject("pictureBox3.Image")));
            this.pictureBox3.Location = new System.Drawing.Point(10, 10);
            this.pictureBox3.Name = "pictureBox3";
            this.pictureBox3.Size = new System.Drawing.Size(34, 40);
            this.pictureBox3.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pictureBox3.TabIndex = 145;
            this.pictureBox3.TabStop = false;
            this.pictureBox3.Click += new System.EventHandler(this.pictureBox3_Click);
            // 
            // picBuscar
            // 
            this.picBuscar.Image = ((System.Drawing.Image)(resources.GetObject("picBuscar.Image")));
            this.picBuscar.Location = new System.Drawing.Point(349, 90);
            this.picBuscar.Name = "picBuscar";
            this.picBuscar.Size = new System.Drawing.Size(53, 40);
            this.picBuscar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.picBuscar.TabIndex = 140;
            this.picBuscar.TabStop = false;
            this.picBuscar.Click += new System.EventHandler(this.picBuscar_Click);
            // 
            // cbo_factura
            // 
            this.cbo_factura.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbo_factura.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_factura.FormattingEnabled = true;
            this.cbo_factura.Items.AddRange(new object[] {
            "Factura de Consumo",
            "Factura Crédito fiscal",
            "Factura Gubernamental"});
            this.cbo_factura.Location = new System.Drawing.Point(591, 72);
            this.cbo_factura.Name = "cbo_factura";
            this.cbo_factura.Size = new System.Drawing.Size(256, 27);
            this.cbo_factura.TabIndex = 1;
            this.cbo_factura.SelectedIndexChanged += new System.EventHandler(this.cbo_factura_SelectedIndexChanged);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(472, 75);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(115, 22);
            this.label6.TabIndex = 155;
            this.label6.Text = "Documento:";
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(533, 104);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(52, 22);
            this.label7.TabIndex = 157;
            this.label7.Text = "RNC:";
            // 
            // txt_rnc
            // 
            this.txt_rnc.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_rnc.Location = new System.Drawing.Point(591, 102);
            this.txt_rnc.MaxLength = 11;
            this.txt_rnc.Name = "txt_rnc";
            this.txt_rnc.Size = new System.Drawing.Size(256, 26);
            this.txt_rnc.TabIndex = 2;
            this.txt_rnc.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_rnc_KeyPress);
            this.txt_rnc.KeyUp += new System.Windows.Forms.KeyEventHandler(this.txt_rnc_KeyUp);
            this.txt_rnc.Leave += new System.EventHandler(this.txt_rnc_Leave);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.lbCantidad.Location = new System.Drawing.Point(46, 77);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(160, 22);
            this.lbCantidad.TabIndex = 158;
            this.lbCantidad.Text = "Buscar Producto:";
            // 
            // button2
            // 
            this.button2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(128)))), ((int)(((byte)(128)))));
            this.button2.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.button2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.button2.ForeColor = System.Drawing.Color.White;
            this.button2.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.button2.Location = new System.Drawing.Point(878, 144);
            this.button2.Name = "button2";
            this.button2.Size = new System.Drawing.Size(149, 49);
            this.button2.TabIndex = 8;
            this.button2.Text = "Limpiar";
            this.button2.UseVisualStyleBackColor = false;
            this.button2.Click += new System.EventHandler(this.button2_Click);
            // 
            // Form_cotizacion
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.GradientInactiveCaption;
            this.ClientSize = new System.Drawing.Size(1060, 627);
            this.Controls.Add(this.button2);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.txt_rnc);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cbo_factura);
            this.Controls.Add(this.button1);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txt_telefono_cotizacion);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txt_direccion_cotizacion);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_nombre_cotizacion);
            this.Controls.Add(this.pictureBox3);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.txt_total);
            this.Controls.Add(this.picBuscar);
            this.Controls.Add(this.txt_buscar_codigo);
            this.Controls.Add(this.dgvCategoras);
            this.Controls.Add(this.lbProducto);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.KeyPreview = true;
            this.MaximizeBox = false;
            this.Name = "Form_cotizacion";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Cotizaciones";
            this.Load += new System.EventHandler(this.Form_cotizacion_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_cotizacion_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.dgvCategoras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pictureBox3)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picBuscar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.PictureBox picBuscar;
        public System.Windows.Forms.TextBox txt_buscar_codigo;
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.TextBox txt_total;
        private System.Windows.Forms.PictureBox pictureBox3;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_nombre_cotizacion;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_direccion_cotizacion;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_telefono_cotizacion;
        private System.Windows.Forms.Button button1;
        private System.Windows.Forms.DataGridViewImageColumn dataGridViewImageColumn1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_rnc;
        private System.Windows.Forms.Label lbCantidad;
        private System.Windows.Forms.Button button2;
        public System.Windows.Forms.DataGridView dgvCategoras;
        public System.Windows.Forms.ComboBox cbo_factura;
        private System.Windows.Forms.DataGridViewTextBoxColumn idproucto;
        private System.Windows.Forms.DataGridViewTextBoxColumn Nombre;
        private System.Windows.Forms.DataGridViewTextBoxColumn detalle;
        private System.Windows.Forms.DataGridViewTextBoxColumn cantidad;
        private System.Windows.Forms.DataGridViewTextBoxColumn subtotal;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
        private System.Windows.Forms.DataGridViewTextBoxColumn itbis;
        private System.Windows.Forms.DataGridViewTextBoxColumn condicion;
        private System.Windows.Forms.DataGridViewImageColumn quitar;
    }
}