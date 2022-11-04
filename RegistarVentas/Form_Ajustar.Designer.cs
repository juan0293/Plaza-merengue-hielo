namespace RegistarVentas
{
    partial class Form_Ajustar
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_Ajustar));
            this.label1 = new System.Windows.Forms.Label();
            this.lbdetalle = new System.Windows.Forms.Label();
            this.txt_existencia = new System.Windows.Forms.TextBox();
            this.panel1 = new System.Windows.Forms.Panel();
            this.btn_close = new System.Windows.Forms.PictureBox();
            this.lbNombre = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.txtcompra = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txtprecioventa = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.txtcantidad = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.picGuardar = new System.Windows.Forms.PictureBox();
            this.label8 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.label10 = new System.Windows.Forms.Label();
            this.picajustar = new System.Windows.Forms.PictureBox();
            this.panel1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.picajustar)).BeginInit();
            this.SuspendLayout();
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.BackColor = System.Drawing.Color.Transparent;
            this.label1.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.DimGray;
            this.label1.Location = new System.Drawing.Point(162, 36);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(234, 28);
            this.label1.TabIndex = 74;
            this.label1.Text = "Ajuste de Inventario";
            this.label1.Click += new System.EventHandler(this.label1_Click);
            // 
            // lbdetalle
            // 
            this.lbdetalle.AutoSize = true;
            this.lbdetalle.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbdetalle.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbdetalle.Location = new System.Drawing.Point(225, 120);
            this.lbdetalle.Name = "lbdetalle";
            this.lbdetalle.Size = new System.Drawing.Size(70, 22);
            this.lbdetalle.TabIndex = 73;
            this.lbdetalle.Text = "detalle";
            // 
            // txt_existencia
            // 
            this.txt_existencia.BackColor = System.Drawing.Color.White;
            this.txt_existencia.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_existencia.ForeColor = System.Drawing.Color.RoyalBlue;
            this.txt_existencia.Location = new System.Drawing.Point(229, 155);
            this.txt_existencia.Multiline = true;
            this.txt_existencia.Name = "txt_existencia";
            this.txt_existencia.ReadOnly = true;
            this.txt_existencia.Size = new System.Drawing.Size(219, 36);
            this.txt_existencia.TabIndex = 72;
            this.txt_existencia.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txt_existencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_txtcantidad_KeyPress);
            // 
            // panel1
            // 
            this.panel1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            this.panel1.Controls.Add(this.btn_close);
            this.panel1.Dock = System.Windows.Forms.DockStyle.Top;
            this.panel1.Location = new System.Drawing.Point(0, 0);
            this.panel1.Name = "panel1";
            this.panel1.Size = new System.Drawing.Size(626, 33);
            this.panel1.TabIndex = 78;
            // 
            // btn_close
            // 
            this.btn_close.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(28)))), ((int)(((byte)(34)))), ((int)(((byte)(96)))));
            this.btn_close.Cursor = System.Windows.Forms.Cursors.Hand;
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.Location = new System.Drawing.Point(591, 0);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(32, 33);
            this.btn_close.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.btn_close.TabIndex = 77;
            this.btn_close.TabStop = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // lbNombre
            // 
            this.lbNombre.AutoSize = true;
            this.lbNombre.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold);
            this.lbNombre.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.lbNombre.Location = new System.Drawing.Point(225, 73);
            this.lbNombre.Name = "lbNombre";
            this.lbNombre.Size = new System.Drawing.Size(79, 22);
            this.lbNombre.TabIndex = 79;
            this.lbNombre.Text = "nombre";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.DimGray;
            this.label3.Location = new System.Drawing.Point(118, 163);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(104, 22);
            this.label3.TabIndex = 80;
            this.label3.Text = "Existencia:";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.DimGray;
            this.label4.Location = new System.Drawing.Point(53, 207);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(170, 22);
            this.label4.TabIndex = 82;
            this.label4.Text = "Precio de Compra:";
            // 
            // txtcompra
            // 
            this.txtcompra.BackColor = System.Drawing.Color.White;
            this.txtcompra.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcompra.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtcompra.Location = new System.Drawing.Point(229, 199);
            this.txtcompra.Multiline = true;
            this.txtcompra.Name = "txtcompra";
            this.txtcompra.Size = new System.Drawing.Size(219, 36);
            this.txtcompra.TabIndex = 81;
            this.txtcompra.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcompra.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox1_KeyPress);
            this.txtcompra.Leave += new System.EventHandler(this.txtcompra_Leave);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.DimGray;
            this.label5.Location = new System.Drawing.Point(73, 255);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(150, 22);
            this.label5.TabIndex = 84;
            this.label5.Text = "Precio de Venta:";
            // 
            // txtprecioventa
            // 
            this.txtprecioventa.BackColor = System.Drawing.Color.White;
            this.txtprecioventa.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtprecioventa.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtprecioventa.Location = new System.Drawing.Point(229, 247);
            this.txtprecioventa.Multiline = true;
            this.txtprecioventa.Name = "txtprecioventa";
            this.txtprecioventa.Size = new System.Drawing.Size(219, 36);
            this.txtprecioventa.TabIndex = 83;
            this.txtprecioventa.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtprecioventa.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.textBox2_KeyPress);
            this.txtprecioventa.Leave += new System.EventHandler(this.txtprecioventa_Leave);
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.DimGray;
            this.label6.Location = new System.Drawing.Point(73, 303);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(150, 22);
            this.label6.TabIndex = 86;
            this.label6.Text = "Nueva Cantidad:";
            // 
            // txtcantidad
            // 
            this.txtcantidad.BackColor = System.Drawing.Color.White;
            this.txtcantidad.Font = new System.Drawing.Font("Cambria", 18F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txtcantidad.ForeColor = System.Drawing.Color.MediumSeaGreen;
            this.txtcantidad.Location = new System.Drawing.Point(229, 295);
            this.txtcantidad.Multiline = true;
            this.txtcantidad.Name = "txtcantidad";
            this.txtcantidad.Size = new System.Drawing.Size(219, 36);
            this.txtcantidad.TabIndex = 85;
            this.txtcantidad.Text = "0";
            this.txtcantidad.TextAlign = System.Windows.Forms.HorizontalAlignment.Center;
            this.txtcantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txtcantidad_KeyPress);
            this.txtcantidad.Leave += new System.EventHandler(this.txtcantidad_Leave);
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.DimGray;
            this.label7.Location = new System.Drawing.Point(280, 381);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(48, 12);
            this.label7.TabIndex = 88;
            this.label7.Text = "Guardar";
            // 
            // picGuardar
            // 
            this.picGuardar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picGuardar.BackColor = System.Drawing.Color.Transparent;
            this.picGuardar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picGuardar.Image = ((System.Drawing.Image)(resources.GetObject("picGuardar.Image")));
            this.picGuardar.Location = new System.Drawing.Point(270, 337);
            this.picGuardar.Name = "picGuardar";
            this.picGuardar.Size = new System.Drawing.Size(58, 41);
            this.picGuardar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picGuardar.TabIndex = 87;
            this.picGuardar.TabStop = false;
            this.picGuardar.Click += new System.EventHandler(this.picGuardar_Click);
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.DimGray;
            this.label8.Location = new System.Drawing.Point(124, 120);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(77, 22);
            this.label8.TabIndex = 89;
            this.label8.Text = "Detalle:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.DimGray;
            this.label9.Location = new System.Drawing.Point(124, 73);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(86, 22);
            this.label9.TabIndex = 90;
            this.label9.Text = "Nombre:";
            // 
            // label10
            // 
            this.label10.AutoSize = true;
            this.label10.Font = new System.Drawing.Font("Cambria", 8.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label10.ForeColor = System.Drawing.Color.DimGray;
            this.label10.Location = new System.Drawing.Point(347, 381);
            this.label10.Name = "label10";
            this.label10.Size = new System.Drawing.Size(82, 12);
            this.label10.TabIndex = 92;
            this.label10.Text = "Ajustar en Cero";
            this.label10.Visible = false;
            // 
            // picajustar
            // 
            this.picajustar.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Right)));
            this.picajustar.BackColor = System.Drawing.Color.Transparent;
            this.picajustar.Cursor = System.Windows.Forms.Cursors.Hand;
            this.picajustar.Enabled = false;
            this.picajustar.Image = ((System.Drawing.Image)(resources.GetObject("picajustar.Image")));
            this.picajustar.Location = new System.Drawing.Point(361, 337);
            this.picajustar.Name = "picajustar";
            this.picajustar.Size = new System.Drawing.Size(58, 41);
            this.picajustar.SizeMode = System.Windows.Forms.PictureBoxSizeMode.Zoom;
            this.picajustar.TabIndex = 91;
            this.picajustar.TabStop = false;
            this.picajustar.Visible = false;
            this.picajustar.Click += new System.EventHandler(this.pictureBox1_Click);
            // 
            // Form_Ajustar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(626, 417);
            this.Controls.Add(this.label10);
            this.Controls.Add(this.picajustar);
            this.Controls.Add(this.label9);
            this.Controls.Add(this.label8);
            this.Controls.Add(this.label7);
            this.Controls.Add(this.picGuardar);
            this.Controls.Add(this.label6);
            this.Controls.Add(this.txtcantidad);
            this.Controls.Add(this.label5);
            this.Controls.Add(this.txtprecioventa);
            this.Controls.Add(this.label4);
            this.Controls.Add(this.txtcompra);
            this.Controls.Add(this.label3);
            this.Controls.Add(this.lbNombre);
            this.Controls.Add(this.panel1);
            this.Controls.Add(this.label1);
            this.Controls.Add(this.lbdetalle);
            this.Controls.Add(this.txt_existencia);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.None;
            this.KeyPreview = true;
            this.Name = "Form_Ajustar";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_Ajustar";
            this.Load += new System.EventHandler(this.Form_Ajustar_Load);
            this.KeyDown += new System.Windows.Forms.KeyEventHandler(this.Form_Ajustar_KeyDown);
            this.panel1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.btn_close)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picGuardar)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.picajustar)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion
        private System.Windows.Forms.Label label1;
        public System.Windows.Forms.Label lbdetalle;
        public System.Windows.Forms.TextBox txt_existencia;
        private System.Windows.Forms.Panel panel1;
        private System.Windows.Forms.PictureBox btn_close;
        public System.Windows.Forms.Label lbNombre;
        public System.Windows.Forms.Label label3;
        public System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txtcompra;
        public System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txtprecioventa;
        public System.Windows.Forms.Label label6;
        public System.Windows.Forms.TextBox txtcantidad;
        public System.Windows.Forms.Label label7;
        private System.Windows.Forms.PictureBox picGuardar;
        public System.Windows.Forms.Label label8;
        public System.Windows.Forms.Label label9;
        public System.Windows.Forms.Label label10;
        private System.Windows.Forms.PictureBox picajustar;
    }
}