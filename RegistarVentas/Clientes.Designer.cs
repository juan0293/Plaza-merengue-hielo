namespace RegistarVentas
{
    partial class Clientes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Clientes));
            this.panel1 = new System.Windows.Forms.Panel();
            this.lbcedula = new System.Windows.Forms.Label();
            this.txt_cedula = new System.Windows.Forms.TextBox();
            this.label11 = new System.Windows.Forms.Label();
            this.lbProducto = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.lbprecioVenta = new System.Windows.Forms.Label();
            this.lbprecioCompra = new System.Windows.Forms.Label();
            this.txt_lugartrabajo = new System.Windows.Forms.TextBox();
            this.txt_telefono = new System.Windows.Forms.TextBox();
            this.detalle = new System.Windows.Forms.Label();
            this.txtDetalle = new System.Windows.Forms.TextBox();
            this.label1 = new System.Windows.Forms.Label();
            this.lbapellido = new System.Windows.Forms.Label();
            this.txtnombre = new System.Windows.Forms.TextBox();
            this.txt_apellido = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.txt_limite_credito = new System.Windows.Forms.TextBox();
            this.picatras = new System.Windows.Forms.PictureBox();
            this.picbGuardar = new System.Windows.Forms.PictureBox();
            ((System.ComponentModel.ISupportInitialize)(this.picatras)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGuardar)).BeginInit();
            this.SuspendLayout();
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(528, 33);
            this.panel1.TabIndex = 109;
            // 
            // lbcedula
            // 
            this.lbcedula.AutoSize = true;
            this.lbcedula.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbcedula.ForeColor = System.Drawing.Color.DimGray;
            this.lbcedula.Location = new System.Drawing.Point(18, 252);
            this.lbcedula.Name = "lbcedula";
            this.lbcedula.Size = new System.Drawing.Size(64, 19);
            this.lbcedula.TabIndex = 134;
            this.lbcedula.Text = "Cedula:";
            // 
            // txt_cedula
            // 
            this.txt_cedula.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cedula.Location = new System.Drawing.Point(18, 274);
            this.txt_cedula.MaxLength = 11;
            this.txt_cedula.Name = "txt_cedula";
            this.txt_cedula.Size = new System.Drawing.Size(233, 26);
            this.txt_cedula.TabIndex = 5;
            this.txt_cedula.Leave += new System.EventHandler(this.txt_cedula_Leave);
            // 
            // label11
            // 
            this.label11.AutoSize = true;
            this.label11.BackColor = System.Drawing.Color.Transparent;
            this.label11.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label11.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label11.Location = new System.Drawing.Point(281, 368);
            this.label11.Name = "label11";
            this.label11.Size = new System.Drawing.Size(53, 22);
            this.label11.TabIndex = 133;
            this.label11.Text = "Atras";
            // 
            // lbProducto
            // 
            this.lbProducto.AutoSize = true;
            this.lbProducto.Font = new System.Drawing.Font("Cambria", 20.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbProducto.ForeColor = System.Drawing.Color.DimGray;
            this.lbProducto.Location = new System.Drawing.Point(151, 53);
            this.lbProducto.Name = "lbProducto";
            this.lbProducto.Size = new System.Drawing.Size(190, 32);
            this.lbProducto.TabIndex = 131;
            this.lbProducto.Text = "Nuevo Cliente:";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.BackColor = System.Drawing.Color.Transparent;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.MidnightBlue;
            this.label2.Location = new System.Drawing.Point(184, 368);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(78, 22);
            this.label2.TabIndex = 129;
            this.label2.Text = "Guardar";
            // 
            // lbprecioVenta
            // 
            this.lbprecioVenta.AutoSize = true;
            this.lbprecioVenta.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprecioVenta.ForeColor = System.Drawing.Color.DimGray;
            this.lbprecioVenta.Location = new System.Drawing.Point(265, 202);
            this.lbprecioVenta.Name = "lbprecioVenta";
            this.lbprecioVenta.Size = new System.Drawing.Size(143, 19);
            this.lbprecioVenta.TabIndex = 123;
            this.lbprecioVenta.Text = "Lugar de Trabajo.:";
            // 
            // lbprecioCompra
            // 
            this.lbprecioCompra.AutoSize = true;
            this.lbprecioCompra.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbprecioCompra.ForeColor = System.Drawing.Color.DimGray;
            this.lbprecioCompra.Location = new System.Drawing.Point(18, 202);
            this.lbprecioCompra.Name = "lbprecioCompra";
            this.lbprecioCompra.Size = new System.Drawing.Size(80, 19);
            this.lbprecioCompra.TabIndex = 122;
            this.lbprecioCompra.Text = "Telefono.:";
            // 
            // txt_lugartrabajo
            // 
            this.txt_lugartrabajo.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_lugartrabajo.Location = new System.Drawing.Point(269, 224);
            this.txt_lugartrabajo.MaxLength = 20;
            this.txt_lugartrabajo.Name = "txt_lugartrabajo";
            this.txt_lugartrabajo.Size = new System.Drawing.Size(233, 26);
            this.txt_lugartrabajo.TabIndex = 4;
            // 
            // txt_telefono
            // 
            this.txt_telefono.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_telefono.Location = new System.Drawing.Point(18, 224);
            this.txt_telefono.MaxLength = 11;
            this.txt_telefono.Name = "txt_telefono";
            this.txt_telefono.Size = new System.Drawing.Size(233, 26);
            this.txt_telefono.TabIndex = 3;
            // 
            // detalle
            // 
            this.detalle.AutoSize = true;
            this.detalle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.detalle.ForeColor = System.Drawing.Color.DimGray;
            this.detalle.Location = new System.Drawing.Point(22, 151);
            this.detalle.Name = "detalle";
            this.detalle.Size = new System.Drawing.Size(88, 19);
            this.detalle.TabIndex = 121;
            this.detalle.Text = "Direccion.:";
            // 
            // txtDetalle
            // 
            this.txtDetalle.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtDetalle.Location = new System.Drawing.Point(22, 173);
            this.txtDetalle.MaxLength = 50;
            this.txtDetalle.Name = "txtDetalle";
            this.txtDetalle.Size = new System.Drawing.Size(484, 26);
            this.txtDetalle.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(18, 100);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(75, 19);
            this.label1.TabIndex = 120;
            this.label1.Text = "Nombre.:";
            // 
            // lbapellido
            // 
            this.lbapellido.AutoSize = true;
            this.lbapellido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbapellido.ForeColor = System.Drawing.Color.DimGray;
            this.lbapellido.Location = new System.Drawing.Point(274, 100);
            this.lbapellido.Name = "lbapellido";
            this.lbapellido.Size = new System.Drawing.Size(86, 19);
            this.lbapellido.TabIndex = 119;
            this.lbapellido.Text = "Apellidos.:";
            // 
            // txtnombre
            // 
            this.txtnombre.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtnombre.Location = new System.Drawing.Point(22, 122);
            this.txtnombre.MaxLength = 20;
            this.txtnombre.Name = "txtnombre";
            this.txtnombre.Size = new System.Drawing.Size(233, 26);
            this.txtnombre.TabIndex = 0;
            // 
            // txt_apellido
            // 
            this.txt_apellido.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_apellido.Location = new System.Drawing.Point(273, 122);
            this.txt_apellido.MaxLength = 50;
            this.txt_apellido.Name = "txt_apellido";
            this.txt_apellido.Size = new System.Drawing.Size(233, 26);
            this.txt_apellido.TabIndex = 1;
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(269, 252);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(140, 19);
            this.label3.TabIndex = 136;
            this.label3.Text = "Limite de Credito:";
            // 
            // txt_limite_credito
            // 
            this.txt_limite_credito.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_limite_credito.Location = new System.Drawing.Point(269, 274);
            this.txt_limite_credito.Name = "txt_limite_credito";
            this.txt_limite_credito.Size = new System.Drawing.Size(233, 26);
            this.txt_limite_credito.TabIndex = 6;
            this.txt_limite_credito.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_limite_credito_KeyPress);
            // 
            // picatras
            // 
            this.picatras.Image = ((System.Drawing.Image)(resources.GetObject("picatras.Image")));
            this.picatras.Location = new System.Drawing.Point(284, 322);
            this.picatras.Name = "picatras";
            this.picatras.Size = new System.Drawing.Size(50, 43);
            this.picatras.TabIndex = 132;
            this.picatras.TabStop = false;
            this.picatras.Click += new System.EventHandler(this.picatras_Click);
            // 
            // picbGuardar
            // 
            this.picbGuardar.Image = ((System.Drawing.Image)(resources.GetObject("picbGuardar.Image")));
            this.picbGuardar.Location = new System.Drawing.Point(197, 322);
            this.picbGuardar.Name = "picbGuardar";
            this.picbGuardar.Size = new System.Drawing.Size(40, 40);
            this.picbGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.AutoSize;
            this.picbGuardar.TabIndex = 127;
            this.picbGuardar.TabStop = false;
            this.picbGuardar.Click += new System.EventHandler(this.picbGuardar_Click);
            // 
            // Clientes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.AutoSize = true;
            this.BackColor = System.Drawing.SystemColors.Control;
            this.ClientSize = new System.Drawing.Size(528, 412);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.txt_limite_credito);
            this.Controls.Add(this.lbcedula);
            this.Controls.Add(this.txt_cedula);
            this.Controls.Add(this.label11);
            this.Controls.Add(this.picatras);
            this.Controls.Add(this.lbProducto);
            this.Controls.Add(this.label2);
            this.Controls.Add(this.picbGuardar);
            this.Controls.Add(this.lbprecioVenta);
            this.Controls.Add(this.lbprecioCompra);
            this.Controls.Add(this.txt_lugartrabajo);
            this.Controls.Add(this.txt_telefono);
            this.Controls.Add(this.detalle);
            this.Controls.Add(this.txtDetalle);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbapellido);
            this.Controls.Add(this.txtnombre);
            this.Controls.Add(this.txt_apellido);
            this.Controls.Add(this.panel1);
            this.ForeColor = System.Drawing.SystemColors.ControlText;
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.Fixed3D;
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.MaximizeBox = false;
            this.MaximumSize = new System.Drawing.Size(548, 455);
            this.MinimumSize = new System.Drawing.Size(548, 455);
            this.Name = "Clientes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Clientes";
            this.Load += new System.EventHandler(this.Clientes_Load);
            ((System.ComponentModel.ISupportInitialize)(this.picatras)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picbGuardar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.Label lbcedula;
        public System.Windows.Forms.TextBox txt_cedula;
        private System.Windows.Forms.Label label11;
        private System.Windows.Forms.PictureBox picatras;
        private System.Windows.Forms.Label lbProducto;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.PictureBox picbGuardar;
        private System.Windows.Forms.Label lbprecioVenta;
        private System.Windows.Forms.Label lbprecioCompra;
        public System.Windows.Forms.TextBox txt_lugartrabajo;
        public System.Windows.Forms.TextBox txt_telefono;
        private System.Windows.Forms.Label detalle;
        public System.Windows.Forms.TextBox txtDetalle;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Label lbapellido;
        public System.Windows.Forms.TextBox txtnombre;
        public System.Windows.Forms.TextBox txt_apellido;
        private System.Windows.Forms.Label label3;
        public System.Windows.Forms.TextBox txt_limite_credito;
    }
}