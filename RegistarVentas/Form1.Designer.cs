namespace RegistarVentas
{
    partial class Registro_Producto
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Registro_Producto));
            this.txtRegistro = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.cbocategorias = new System.Windows.Forms.ComboBox();
            this.label11 = new System.Windows.Forms.Label();
            this.picatras = new System.Windows.Forms.PictureBox();
            this.lbProducto = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.picbLimpiar = new System.Windows.Forms.PictureBox();
            this.picbGuardar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.cbo_itebis = new System.Windows.Forms.ComboBox();
            this.label7 = new System.Windows.Forms.Label();
            this.label6 = new System.Windows.Forms.Label();
            this.cboProveedor = new System.Windows.Forms.ComboBox();
            this.lbprecioVenta = new System.Windows.Forms.Label();
            this.lbprecioCompra = new System.Windows.Forms.Label();
            this.txt_preciosalida = new System.Windows.Forms.TextBox();
            this.txt_precioentrada = new System.Windows.Forms.TextBox();
            this.detalle = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.Codigo = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txt_codigo = new System.Windows.Forms.TextBox();
            this.lbCantidad = new System.Windows.Forms.Label();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.check1 = new System.Windows.Forms.CheckBox();
            this.label3 = new System.Windows.Forms.Label();
            this.chItbis = new System.Windows.Forms.CheckBox();
            ((System.ComponentModel.ISupportInitialize)(this.picatras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbLimpiar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // txtRegistro
            // 
            this.txtRegistro.Location = new System.Drawing.Point(397, 607);
            this.txtRegistro.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.txtRegistro.Name = "txtRegistro";
            this.txtRegistro.ReadOnly = true;
            this.txtRegistro.Size = new System.Drawing.Size(180, 27);
            this.txtRegistro.TabIndex = 82;
            this.txtRegistro.Text = "Registro";
            this.txtRegistro.Visible = false;
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(551, 33);
            this.panel1.TabIndex = 84;
            // 
            // cbocategorias
            // 
            this.cbocategorias.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cbocategorias.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbocategorias.FormattingEnabled = true;
            this.cbocategorias.Location = new System.Drawing.Point(35, 236);
            this.cbocategorias.Name = "cbocategorias";
            this.cbocategorias.Size = new System.Drawing.Size(233, 27);
            this.cbocategorias.TabIndex = 3;
            this.cbocategorias.SelectedIndexChanged += new System.EventHandler(this.cbocategorias_SelectedIndexChanged);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(336, 426);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 22);
            this.label11.TabIndex = 107;
            this.label11.Text = "Atras";
            // 
            // picatras
            // 
            this.picatras.Image = ((System.Drawing.Image)(resources.GetObject("picatras.Image")));
            this.picatras.Location = new System.Drawing.Point(336, 380);
            this.picatras.Name = "picatras";
            this.picatras.Size = new System.Drawing.Size(50, 43);
            this.picatras.TabIndex = 106;
            this.picatras.TabStop = false;
            this.picatras.Click += new System.EventHandler(this.picatras_Click);
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.ForeColor = System.Drawing.Color.DimGray;
            this.lbProducto.Location = new System.Drawing.Point(170, 53);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(219, 32);
            this.lbProducto.TabIndex = 105;
            this.lbProducto.Text = "Nuevo Producto:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.BackColor = System.Drawing.Color.Transparent;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label9.Location = new System.Drawing.Point(249, 426);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(63, 22);
            this.label9.TabIndex = 104;
            this.label9.Text = "Nuevo";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(149, 426);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 103;
            this.label2.Text = "Guardar";
            // 
            // picbLimpiar
            // 
            this.picbLimpiar.Image = ((System.Drawing.Image)(resources.GetObject("picbLimpiar.Image")));
            this.picbLimpiar.Location = new System.Drawing.Point(260, 380);
            this.picbLimpiar.Name = "picbLimpiar";
            this.picbLimpiar.Size = new System.Drawing.Size(46, 43);
            this.picbLimpiar.TabIndex = 102;
            this.picbLimpiar.TabStop = false;
            this.picbLimpiar.Click += new System.EventHandler(this.picbLimpiar_Click);
            // 
            // picbGuardar
            // 
            this.picbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("picbGuardar.Image")));
            this.picbGuardar.Location = new System.Drawing.Point(162, 380);
            this.picbGuardar.Name = "picbGuardar";
            this.picbGuardar.Size = new System.Drawing.Size(40, 40);
            this.picbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbGuardar.TabIndex = 101;
            this.picbGuardar.TabStop = false;
            this.picbGuardar.Click += new System.EventHandler(this.picbGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(22, 380);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(46, 19);
            this.label8.TabIndex = 100;
            this.label8.Text = "Itbis:";
            this.label8.Visible = false;
            // 
            // cbo_itebis
            // 
            this.cbo_itebis.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_itebis.FormattingEnabled = true;
            this.cbo_itebis.Location = new System.Drawing.Point(35, 426);
            this.cbo_itebis.Name = "cbo_itebis";
            this.cbo_itebis.Size = new System.Drawing.Size(233, 27);
            this.cbo_itebis.TabIndex = 8;
            this.cbo_itebis.Text = "0";
            this.cbo_itebis.Visible = false;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(282, 214);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(91, 19);
            this.label7.TabIndex = 99;
            this.label7.Text = "Proveedor.:";
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(35, 216);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(87, 19);
            this.label6.TabIndex = 98;
            this.label6.Text = "Categoria.:";
            // 
            // cboProveedor
            // 
            this.cboProveedor.DropDownStyle = System.Windows.Forms.ComboBoxStyle.DropDownList;
            this.cboProveedor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cboProveedor.FormattingEnabled = true;
            this.cboProveedor.Location = new System.Drawing.Point(286, 236);
            this.cboProveedor.Name = "cboProveedor";
            this.cboProveedor.Size = new System.Drawing.Size(233, 27);
            this.cboProveedor.TabIndex = 4;
            this.cboProveedor.SelectedIndexChanged += new System.EventHandler(this.cboProveedor_SelectedIndexChanged);
            // 
            // lbprecioVenta
            // 
            this.lbprecioVenta.AutoSize = true;
            this.lbprecioVenta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprecioVenta.ForeColor = System.Drawing.Color.DimGray;
            this.lbprecioVenta.Location = new System.Drawing.Point(282, 266);
            this.lbprecioVenta.Name = "lbprecioVenta";
            this.lbprecioVenta.Size = new System.Drawing.Size(132, 19);
            this.lbprecioVenta.TabIndex = 97;
            this.lbprecioVenta.Text = "Precio de Venta.:";
            // 
            // lbprecioCompra
            // 
            this.lbprecioCompra.AutoSize = true;
            this.lbprecioCompra.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprecioCompra.ForeColor = System.Drawing.Color.DimGray;
            this.lbprecioCompra.Location = new System.Drawing.Point(35, 266);
            this.lbprecioCompra.Name = "lbprecioCompra";
            this.lbprecioCompra.Size = new System.Drawing.Size(148, 19);
            this.lbprecioCompra.TabIndex = 96;
            this.lbprecioCompra.Text = "Precio de Compra.:";
            // 
            // txt_preciosalida
            // 
            this.txt_preciosalida.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_preciosalida.Location = new System.Drawing.Point(286, 288);
            this.txt_preciosalida.Name = "txt_preciosalida";
            this.txt_preciosalida.Size = new System.Drawing.Size(233, 26);
            this.txt_preciosalida.TabIndex = 6;
            this.txt_preciosalida.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_preciosalida_KeyPress);
            this.txt_preciosalida.Leave += new System.EventHandler(this.txt_preciosalida_Leave);
            // 
            // txt_precioentrada
            // 
            this.txt_precioentrada.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_precioentrada.Location = new System.Drawing.Point(35, 288);
            this.txt_precioentrada.Name = "txt_precioentrada";
            this.txt_precioentrada.Size = new System.Drawing.Size(233, 26);
            this.txt_precioentrada.TabIndex = 5;
            this.txt_precioentrada.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_precioentrada_KeyPress);
            this.txt_precioentrada.Leave += new System.EventHandler(this.txt_precioentrada_Leave);
            // 
            // detalle
            // 
            this.detalle.AutoSize = true;
            this.detalle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalle.ForeColor = System.Drawing.Color.DimGray;
            this.detalle.Location = new System.Drawing.Point(287, 115);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(168, 19);
            this.detalle.TabIndex = 95;
            this.detalle.Text = "Detalles del producto";
            this.detalle.Visible = false;
            // 
            // txtDetalle
            // 
            this.txtDetalle.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txtDetalle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(35, 187);
            this.txtDetalle.MaxLength = 30;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(484, 26);
            this.txtDetalle.TabIndex = 2;
            this.txtDetalle.TextChanged += new System.EventHandler(this.txtDetalle_TextChanged);
            // 
            // Codigo
            // 
            this.Codigo.AutoSize = true;
            this.Codigo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.Codigo.ForeColor = System.Drawing.Color.DimGray;
            this.Codigo.Location = new System.Drawing.Point(35, 115);
            this.Codigo.Name = "Codigo";
            this.Codigo.Size = new System.Drawing.Size(67, 19);
            this.Codigo.TabIndex = 93;
            this.Codigo.Text = "Codigo.:";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(286, 136);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(233, 26);
            this.txtnombre.TabIndex = 1;
            this.txtnombre.Visible = false;
            // 
            // txt_codigo
            // 
            this.txt_codigo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_codigo.Location = new System.Drawing.Point(35, 137);
            this.txt_codigo.MaxLength = 30;
            this.txt_codigo.Name = "txt_codigo";
            this.txt_codigo.Size = new System.Drawing.Size(233, 26);
            this.txt_codigo.TabIndex = 0;
            this.txt_codigo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_codigo_KeyPress_1);
            this.txt_codigo.Leave += new System.EventHandler(this.txt_codigo_Leave);
            // 
            // lbCantidad
            // 
            this.lbCantidad.AutoSize = true;
            this.lbCantidad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbCantidad.ForeColor = System.Drawing.Color.DimGray;
            this.lbCantidad.Location = new System.Drawing.Point(35, 317);
            this.lbCantidad.Name = "lbCantidad";
            this.lbCantidad.Size = new System.Drawing.Size(81, 19);
            this.lbCantidad.TabIndex = 109;
            this.lbCantidad.Text = "Cantidad:";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(35, 339);
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(233, 26);
            this.txt_cantidad.TabIndex = 7;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress_1);
            // 
            // check1
            // 
            this.check1.AutoSize = true;
            this.check1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold);
            this.check1.ForeColor = System.Drawing.Color.DimGray;
            this.check1.Location = new System.Drawing.Point(39, 87);
            this.check1.Name = "check1";
            this.check1.Size = new System.Drawing.Size(140, 23);
            this.check1.TabIndex = 110;
            this.check1.Text = "Generar código";
            this.check1.UseVisualStyleBackColor = true;
            this.check1.CheckedChanged += new System.EventHandler(this.check1_CheckedChanged);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(35, 166);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(167, 19);
            this.label3.TabIndex = 111;
            this.label3.Text = "Nombre del producto";
            // 
            // chItbis
            // 
            this.chItbis.AutoSize = true;
            this.chItbis.ForeColor = System.Drawing.Color.DimGray;
            this.chItbis.Location = new System.Drawing.Point(292, 339);
            this.chItbis.Name = "chItbis";
            this.chItbis.Size = new System.Drawing.Size(66, 22);
            this.chItbis.TabIndex = 112;
            this.chItbis.Text = "Itbis";
            this.chItbis.UseVisualStyleBackColor = true;
            // 
            // Registro_Producto
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(11F, 18F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.BackgroundImageLayout = System.Windows.Forms.ImageLayout.Stretch;
            this.ClientSize = new System.Drawing.Size(551, 465);
            this.Controls.Add(this.chItbis);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.check1);
            this.Controls.Add(this.lbCantidad);
            this.Controls.Add(this.txt_cantidad);
            this.Controls.Add(this.cbocategorias);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.picatras);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picbLimpiar);
            this.Controls.Add(this.picbGuardar);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.cbo_itebis);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.cboProveedor);
            this.Controls.Add(this.lbprecioVenta);
            this.Controls.Add(this.lbprecioCompra);
            this.Controls.Add(this.txt_preciosalida);
            this.Controls.Add(this.txt_precioentrada);
            this.Controls.Add(this.detalle);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.Codigo);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txt_codigo);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.txtRegistro);
            this.DoubleBuffered = true;
            this.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.KeyPreview = true;
            this.Margin = new System.Windows.Forms.Padding(6, 4, 6, 4);
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(571, 508);
            this.MinimumSize = new System.Drawing.Size(571, 508);
            this.Name = "Registro_Producto";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Registro de Productos";
            this.Load += new System.EventHandler(this.Registro_Producto_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Registro_Producto_KeyDown);
            ((System.ComponentModel.ISupportInitialize)(this.picatras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbLimpiar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.TextBox txtRegistro;
        private System.Windows.Forms.Panel panel1;
        public System.Windows.Forms.ComboBox cbocategorias;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picatras;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picbLimpiar;
        private System.Windows.Forms.PictureBox picbGuardar;
        private System.Windows.Forms.Label label8;
        public System.Windows.Forms.ComboBox cbo_itebis;
        private System.Windows.Forms.Label label7;
        private System.Windows.Forms.Label label6;
        public System.Windows.Forms.ComboBox cboProveedor;
        private System.Windows.Forms.Label lbprecioVenta;
        private System.Windows.Forms.Label lbprecioCompra;
        public System.Windows.Forms.TextBox txt_preciosalida;
        public System.Windows.Forms.TextBox txt_precioentrada;
        private System.Windows.Forms.Label detalle;
        public System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label Codigo;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txt_codigo;
        private System.Windows.Forms.Label lbCantidad;
        public System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.CheckBox check1;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.CheckBox chItbis;
    }
}

