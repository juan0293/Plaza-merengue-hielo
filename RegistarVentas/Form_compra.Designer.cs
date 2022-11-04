namespace RegistarVentas
{
    partial class Form_compra
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle5 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle2 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle3 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle4 = new System.Windows.Forms.DataGridViewCellStyle();
            this.lb_total = new System.Windows.Forms.Label();
            this.lb_itebis = new System.Windows.Forms.Label();
            this.lb_cantidad = new System.Windows.Forms.Label();
            this.label4 = new System.Windows.Forms.Label();
            this.label3 = new System.Windows.Forms.Label();
            this.label1 = new System.Windows.Forms.Label();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_rnc = new System.Windows.Forms.Panel();
            this.label2 = new System.Windows.Forms.Label();
            this.dtp_fecha = new System.Windows.Forms.DateTimePicker();
            this.txt_ncf = new System.Windows.Forms.TextBox();
            this.label7 = new System.Windows.Forms.Label();
            this.txt_docuemento = new System.Windows.Forms.TextBox();
            this.label8 = new System.Windows.Forms.Label();
            this.dgvdetalle = new System.Windows.Forms.DataGridView();
            this.textBox1 = new System.Windows.Forms.TextBox();
            this.label6 = new System.Windows.Forms.Label();
            this.cbotipo = new System.Windows.Forms.ComboBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_vendedor = new System.Windows.Forms.TextBox();
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.btn_cerrar = new System.Windows.Forms.Button();
            this.btn_quitar = new System.Windows.Forms.Button();
            this.btn_agregar = new System.Windows.Forms.Button();
            this.checkcocina = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.descrip = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.price = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ITEBIS = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.Total1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.ctd1 = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.id = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.txt_rnc.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).BeginInit();
            this.groupBox2.SuspendLayout();
            this.SuspendLayout();
            // 
            // lb_total
            // 
            this.lb_total.AutoSize = true;
            this.lb_total.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_total.ForeColor = System.Drawing.Color.Black;
            this.lb_total.Location = new System.Drawing.Point(107, 76);
            this.lb_total.Name = "lb_total";
            this.lb_total.Size = new System.Drawing.Size(47, 22);
            this.lb_total.TabIndex = 140;
            this.lb_total.Text = "0.00";
            // 
            // lb_itebis
            // 
            this.lb_itebis.AutoSize = true;
            this.lb_itebis.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_itebis.ForeColor = System.Drawing.Color.Black;
            this.lb_itebis.Location = new System.Drawing.Point(107, 43);
            this.lb_itebis.Name = "lb_itebis";
            this.lb_itebis.Size = new System.Drawing.Size(47, 22);
            this.lb_itebis.TabIndex = 139;
            this.lb_itebis.Text = "0.00";
            // 
            // lb_cantidad
            // 
            this.lb_cantidad.AutoSize = true;
            this.lb_cantidad.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lb_cantidad.ForeColor = System.Drawing.Color.Black;
            this.lb_cantidad.Location = new System.Drawing.Point(107, 7);
            this.lb_cantidad.Name = "lb_cantidad";
            this.lb_cantidad.Size = new System.Drawing.Size(21, 22);
            this.lb_cantidad.TabIndex = 138;
            this.lb_cantidad.Text = "0";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(3, 75);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(63, 22);
            this.label4.TabIndex = 137;
            this.label4.Text = "Total.:";
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(3, 42);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(69, 22);
            this.label3.TabIndex = 136;
            this.label3.Text = "Itebis.:";
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(3, 6);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(95, 22);
            this.label1.TabIndex = 135;
            this.label1.Text = "Articulos:";
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.White;
            this.label9.Location = new System.Drawing.Point(29, 35);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(92, 22);
            this.label9.TabIndex = 134;
            this.label9.Text = "Empresa:";
            // 
            // txt_rnc
            // 
            this.txt_rnc.BackColor = System.Drawing.Color.White;
            this.txt_rnc.BorderStyle = System.Windows.Forms.BorderStyle.Fixed3D;
            this.txt_rnc.Controls.Add(this.lb_total);
            this.txt_rnc.Controls.Add(this.lb_itebis);
            this.txt_rnc.Controls.Add(this.lb_cantidad);
            this.txt_rnc.Controls.Add(this.label4);
            this.txt_rnc.Controls.Add(this.label3);
            this.txt_rnc.Controls.Add(this.label1);
            this.txt_rnc.Location = new System.Drawing.Point(679, 7);
            this.txt_rnc.Name = "txt_rnc";
            this.txt_rnc.Size = new System.Drawing.Size(327, 135);
            this.txt_rnc.TabIndex = 150;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.White;
            this.label2.Location = new System.Drawing.Point(379, 34);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(64, 22);
            this.label2.TabIndex = 142;
            this.label2.Text = "Fecha:";
            // 
            // dtp_fecha
            // 
            this.dtp_fecha.CalendarFont = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtp_fecha.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtp_fecha.Location = new System.Drawing.Point(449, 31);
            this.dtp_fecha.Name = "dtp_fecha";
            this.dtp_fecha.Size = new System.Drawing.Size(200, 29);
            this.dtp_fecha.TabIndex = 1;
            // 
            // txt_ncf
            // 
            this.txt_ncf.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_ncf.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_ncf.Location = new System.Drawing.Point(449, 66);
            this.txt_ncf.MaxLength = 11;
            this.txt_ncf.Name = "txt_ncf";
            this.txt_ncf.Size = new System.Drawing.Size(200, 26);
            this.txt_ncf.TabIndex = 3;
            // 
            // label7
            // 
            this.label7.AutoSize = true;
            this.label7.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label7.ForeColor = System.Drawing.Color.White;
            this.label7.Location = new System.Drawing.Point(17, 63);
            this.label7.Name = "label7";
            this.label7.Size = new System.Drawing.Size(104, 22);
            this.label7.TabIndex = 138;
            this.label7.Text = "ID Factura:";
            // 
            // txt_docuemento
            // 
            this.txt_docuemento.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_docuemento.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_docuemento.Location = new System.Drawing.Point(126, 63);
            this.txt_docuemento.MaxLength = 11;
            this.txt_docuemento.Name = "txt_docuemento";
            this.txt_docuemento.Size = new System.Drawing.Size(230, 26);
            this.txt_docuemento.TabIndex = 2;
            // 
            // label8
            // 
            this.label8.AutoSize = true;
            this.label8.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label8.ForeColor = System.Drawing.Color.White;
            this.label8.Location = new System.Drawing.Point(395, 67);
            this.label8.Name = "label8";
            this.label8.Size = new System.Drawing.Size(48, 22);
            this.label8.TabIndex = 136;
            this.label8.Text = "NCF:";
            // 
            // dgvdetalle
            // 
            this.dgvdetalle.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom) 
            | System.Windows.Forms.AnchorStyles.Left)));
            this.dgvdetalle.BackgroundColor = System.Drawing.Color.White;
            this.dgvdetalle.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.Raised;
            dataGridViewCellStyle1.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle1.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            dataGridViewCellStyle1.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle1.ForeColor = System.Drawing.Color.DimGray;
            dataGridViewCellStyle1.SelectionBackColor = System.Drawing.Color.FromArgb(((int)(((byte)(41)))), ((int)(((byte)(128)))), ((int)(((byte)(185)))));
            dataGridViewCellStyle1.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle1.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdetalle.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle1;
            this.dgvdetalle.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvdetalle.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.checkcocina,
            this.descrip,
            this.price,
            this.ITEBIS,
            this.Total1,
            this.ctd1,
            this.id});
            dataGridViewCellStyle5.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleLeft;
            dataGridViewCellStyle5.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle5.Font = new System.Drawing.Font("Segoe UI", 9.75F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle5.ForeColor = System.Drawing.SystemColors.ControlText;
            dataGridViewCellStyle5.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle5.SelectionForeColor = System.Drawing.SystemColors.HighlightText;
            dataGridViewCellStyle5.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvdetalle.DefaultCellStyle = dataGridViewCellStyle5;
            this.dgvdetalle.EnableHeadersVisualStyles = false;
            this.dgvdetalle.Location = new System.Drawing.Point(3, 148);
            this.dgvdetalle.Name = "dgvdetalle";
            this.dgvdetalle.RowHeadersVisible = false;
            this.dgvdetalle.Size = new System.Drawing.Size(1022, 444);
            this.dgvdetalle.TabIndex = 147;
            this.dgvdetalle.CellEndEdit += new System.Windows.Forms.DataGridViewCellEventHandler(this.dgvdetalle_CellEndEdit);
            this.dgvdetalle.EditingControlShowing += new System.Windows.Forms.DataGridViewEditingControlShowingEventHandler(this.dgvdetalle_EditingControlShowing);
            // 
            // textBox1
            // 
            this.textBox1.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.textBox1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.textBox1.Location = new System.Drawing.Point(449, 98);
            this.textBox1.MaxLength = 11;
            this.textBox1.Name = "textBox1";
            this.textBox1.Size = new System.Drawing.Size(200, 26);
            this.textBox1.TabIndex = 145;
            // 
            // label6
            // 
            this.label6.AutoSize = true;
            this.label6.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label6.ForeColor = System.Drawing.Color.White;
            this.label6.Location = new System.Drawing.Point(395, 99);
            this.label6.Name = "label6";
            this.label6.Size = new System.Drawing.Size(52, 22);
            this.label6.TabIndex = 146;
            this.label6.Text = "RNC:";
            // 
            // cbotipo
            // 
            this.cbotipo.Font = new System.Drawing.Font("Microsoft Sans Serif", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbotipo.FormattingEnabled = true;
            this.cbotipo.Items.AddRange(new object[] {
            "EFECTIVO",
            "CREDITO",
            "CHEQUE ",
            "TARJETA"});
            this.cbotipo.Location = new System.Drawing.Point(126, 92);
            this.cbotipo.Name = "cbotipo";
            this.cbotipo.Size = new System.Drawing.Size(230, 28);
            this.cbotipo.TabIndex = 144;
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.White;
            this.label5.Location = new System.Drawing.Point(66, 94);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(55, 22);
            this.label5.TabIndex = 143;
            this.label5.Text = "Tipo:";
            // 
            // txt_vendedor
            // 
            this.txt_vendedor.CharacterCasing = System.Windows.Forms.CharacterCasing.Upper;
            this.txt_vendedor.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_vendedor.Location = new System.Drawing.Point(126, 34);
            this.txt_vendedor.MaxLength = 50;
            this.txt_vendedor.Name = "txt_vendedor";
            this.txt_vendedor.Size = new System.Drawing.Size(230, 26);
            this.txt_vendedor.TabIndex = 0;
            // 
            // groupBox2
            // 
            this.groupBox2.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.groupBox2.Controls.Add(this.textBox1);
            this.groupBox2.Controls.Add(this.label6);
            this.groupBox2.Controls.Add(this.cbotipo);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtp_fecha);
            this.groupBox2.Controls.Add(this.txt_ncf);
            this.groupBox2.Controls.Add(this.label7);
            this.groupBox2.Controls.Add(this.txt_docuemento);
            this.groupBox2.Controls.Add(this.label8);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_vendedor);
            this.groupBox2.ForeColor = System.Drawing.Color.White;
            this.groupBox2.Location = new System.Drawing.Point(3, 7);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(670, 135);
            this.groupBox2.TabIndex = 148;
            this.groupBox2.TabStop = false;
            // 
            // btn_cerrar
            // 
            this.btn_cerrar.BackColor = System.Drawing.Color.White;
            this.btn_cerrar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_cerrar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_cerrar.ForeColor = System.Drawing.Color.Black;
            this.btn_cerrar.Image = global::RegistarVentas.Properties.Resources.close_sign_30px;
            this.btn_cerrar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_cerrar.Location = new System.Drawing.Point(582, 598);
            this.btn_cerrar.Name = "btn_cerrar";
            this.btn_cerrar.Size = new System.Drawing.Size(149, 51);
            this.btn_cerrar.TabIndex = 152;
            this.btn_cerrar.Text = "Cerrar";
            this.btn_cerrar.UseVisualStyleBackColor = false;
            // 
            // btn_quitar
            // 
            this.btn_quitar.BackColor = System.Drawing.Color.White;
            this.btn_quitar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_quitar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_quitar.ForeColor = System.Drawing.Color.Black;
            this.btn_quitar.Image = global::RegistarVentas.Properties.Resources.delete_26px;
            this.btn_quitar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_quitar.Location = new System.Drawing.Point(250, 598);
            this.btn_quitar.Name = "btn_quitar";
            this.btn_quitar.Size = new System.Drawing.Size(157, 51);
            this.btn_quitar.TabIndex = 151;
            this.btn_quitar.Text = "Borrar";
            this.btn_quitar.UseVisualStyleBackColor = false;
            // 
            // btn_agregar
            // 
            this.btn_agregar.BackColor = System.Drawing.Color.White;
            this.btn_agregar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_agregar.Font = new System.Drawing.Font("Segoe UI", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_agregar.ForeColor = System.Drawing.Color.Black;
            this.btn_agregar.Image = global::RegistarVentas.Properties.Resources.save_24px1;
            this.btn_agregar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_agregar.Location = new System.Drawing.Point(413, 598);
            this.btn_agregar.Name = "btn_agregar";
            this.btn_agregar.Size = new System.Drawing.Size(163, 51);
            this.btn_agregar.TabIndex = 149;
            this.btn_agregar.Text = "Guardar";
            this.btn_agregar.UseVisualStyleBackColor = false;
            // 
            // checkcocina
            // 
            this.checkcocina.HeaderText = "CODIGO";
            this.checkcocina.Name = "checkcocina";
            this.checkcocina.Resizable = System.Windows.Forms.DataGridViewTriState.True;
            this.checkcocina.Width = 140;
            // 
            // descrip
            // 
            this.descrip.HeaderText = "DESCRIPCION";
            this.descrip.Name = "descrip";
            this.descrip.Width = 300;
            // 
            // price
            // 
            dataGridViewCellStyle2.Alignment = System.Windows.Forms.DataGridViewContentAlignment.MiddleRight;
            dataGridViewCellStyle2.Format = "N2";
            dataGridViewCellStyle2.NullValue = null;
            this.price.DefaultCellStyle = dataGridViewCellStyle2;
            this.price.HeaderText = "PRECIO DE COMPRA";
            this.price.Name = "price";
            this.price.Width = 180;
            // 
            // ITEBIS
            // 
            dataGridViewCellStyle3.Format = "N2";
            dataGridViewCellStyle3.NullValue = null;
            this.ITEBIS.DefaultCellStyle = dataGridViewCellStyle3;
            this.ITEBIS.HeaderText = "ITBIS";
            this.ITEBIS.Name = "ITEBIS";
            // 
            // Total1
            // 
            dataGridViewCellStyle4.Format = "N2";
            dataGridViewCellStyle4.NullValue = null;
            this.Total1.DefaultCellStyle = dataGridViewCellStyle4;
            this.Total1.HeaderText = "PRECIO DE VENTA";
            this.Total1.Name = "Total1";
            this.Total1.Width = 160;
            // 
            // ctd1
            // 
            this.ctd1.HeaderText = "CANTIDAD";
            this.ctd1.Name = "ctd1";
            this.ctd1.Width = 140;
            // 
            // id
            // 
            this.id.HeaderText = "id";
            this.id.Name = "id";
            this.id.Visible = false;
            // 
            // Form_compra
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(113)))), ((int)(((byte)(195)))));
            this.ClientSize = new System.Drawing.Size(1027, 661);
            this.Controls.Add(this.btn_cerrar);
            this.Controls.Add(this.btn_quitar);
            this.Controls.Add(this.btn_agregar);
            this.Controls.Add(this.txt_rnc);
            this.Controls.Add(this.dgvdetalle);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form_compra";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Compra";
            this.txt_rnc.ResumeLayout(false);
            this.txt_rnc.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.dgvdetalle)).EndInit();
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion
        private System.Windows.Forms.Label lb_total;
        private System.Windows.Forms.Label lb_itebis;
        private System.Windows.Forms.Label lb_cantidad;
        private System.Windows.Forms.Label label4;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.Button btn_agregar;
        private System.Windows.Forms.Label label9;
        private System.Windows.Forms.Panel txt_rnc;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtp_fecha;
        public System.Windows.Forms.TextBox txt_ncf;
        private System.Windows.Forms.Label label7;
        public System.Windows.Forms.TextBox txt_docuemento;
        private System.Windows.Forms.Label label8;
        private System.Windows.Forms.DataGridView dgvdetalle;
        public System.Windows.Forms.TextBox textBox1;
        private System.Windows.Forms.Label label6;
        private System.Windows.Forms.ComboBox cbotipo;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_vendedor;
        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Button btn_quitar;
        private System.Windows.Forms.Button btn_cerrar;
        private System.Windows.Forms.DataGridViewTextBoxColumn checkcocina;
        private System.Windows.Forms.DataGridViewTextBoxColumn descrip;
        private System.Windows.Forms.DataGridViewTextBoxColumn price;
        private System.Windows.Forms.DataGridViewTextBoxColumn ITEBIS;
        private System.Windows.Forms.DataGridViewTextBoxColumn Total1;
        private System.Windows.Forms.DataGridViewTextBoxColumn ctd1;
        private System.Windows.Forms.DataGridViewTextBoxColumn id;
    }
}