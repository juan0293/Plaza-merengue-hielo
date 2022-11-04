namespace RegistarVentas
{
    partial class Form_comprobantes
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(Form_comprobantes));
            this.groupBox2 = new System.Windows.Forms.GroupBox();
            this.label4 = new System.Windows.Forms.Label();
            this.txt_finalizar_secuencia = new System.Windows.Forms.TextBox();
            this.label5 = new System.Windows.Forms.Label();
            this.txt_proximo = new System.Windows.Forms.TextBox();
            this.label3 = new System.Windows.Forms.Label();
            this.label2 = new System.Windows.Forms.Label();
            this.dtpvencimiento = new System.Windows.Forms.DateTimePicker();
            this.label1 = new System.Windows.Forms.Label();
            this.cbo_tipo = new System.Windows.Forms.ComboBox();
            this.txt_cantidad = new System.Windows.Forms.TextBox();
            this.label9 = new System.Windows.Forms.Label();
            this.txt_secuencia = new System.Windows.Forms.TextBox();
            this.groupBox1 = new System.Windows.Forms.GroupBox();
            this.rdb_desactivar = new System.Windows.Forms.RadioButton();
            this.rdb_activar = new System.Windows.Forms.RadioButton();
            this.btn_close = new System.Windows.Forms.Button();
            this.btn_guardar = new System.Windows.Forms.Button();
            this.groupBox2.SuspendLayout();
            this.groupBox1.SuspendLayout();
            this.SuspendLayout();
            // 
            // groupBox2
            // 
            this.groupBox2.Controls.Add(this.label4);
            this.groupBox2.Controls.Add(this.txt_finalizar_secuencia);
            this.groupBox2.Controls.Add(this.label5);
            this.groupBox2.Controls.Add(this.txt_proximo);
            this.groupBox2.Controls.Add(this.label3);
            this.groupBox2.Controls.Add(this.label2);
            this.groupBox2.Controls.Add(this.dtpvencimiento);
            this.groupBox2.Controls.Add(this.label1);
            this.groupBox2.Controls.Add(this.cbo_tipo);
            this.groupBox2.Controls.Add(this.txt_cantidad);
            this.groupBox2.Controls.Add(this.label9);
            this.groupBox2.Controls.Add(this.txt_secuencia);
            this.groupBox2.Location = new System.Drawing.Point(9, 10);
            this.groupBox2.Name = "groupBox2";
            this.groupBox2.Size = new System.Drawing.Size(744, 166);
            this.groupBox2.TabIndex = 145;
            this.groupBox2.TabStop = false;
            this.groupBox2.Text = "Agregar";
            // 
            // label4
            // 
            this.label4.AutoSize = true;
            this.label4.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label4.ForeColor = System.Drawing.Color.Black;
            this.label4.Location = new System.Drawing.Point(464, 82);
            this.label4.Name = "label4";
            this.label4.Size = new System.Drawing.Size(167, 19);
            this.label4.TabIndex = 148;
            this.label4.Text = "Secuencia a Finalizar";
            // 
            // txt_finalizar_secuencia
            // 
            this.txt_finalizar_secuencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_finalizar_secuencia.Location = new System.Drawing.Point(463, 113);
            this.txt_finalizar_secuencia.MaxLength = 8;
            this.txt_finalizar_secuencia.Name = "txt_finalizar_secuencia";
            this.txt_finalizar_secuencia.ReadOnly = true;
            this.txt_finalizar_secuencia.Size = new System.Drawing.Size(200, 29);
            this.txt_finalizar_secuencia.TabIndex = 147;
            this.txt_finalizar_secuencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_finalizar_secuencia_KeyPress);
            // 
            // label5
            // 
            this.label5.AutoSize = true;
            this.label5.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label5.ForeColor = System.Drawing.Color.Black;
            this.label5.Location = new System.Drawing.Point(226, 82);
            this.label5.Name = "label5";
            this.label5.Size = new System.Drawing.Size(167, 19);
            this.label5.TabIndex = 146;
            this.label5.Text = "Próximo NCF a Emitir";
            // 
            // txt_proximo
            // 
            this.txt_proximo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_proximo.Location = new System.Drawing.Point(225, 114);
            this.txt_proximo.MaxLength = 8;
            this.txt_proximo.Name = "txt_proximo";
            this.txt_proximo.ReadOnly = true;
            this.txt_proximo.Size = new System.Drawing.Size(200, 29);
            this.txt_proximo.TabIndex = 145;
            this.txt_proximo.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_proximo_KeyPress);
            // 
            // label3
            // 
            this.label3.AutoSize = true;
            this.label3.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label3.ForeColor = System.Drawing.Color.Black;
            this.label3.Location = new System.Drawing.Point(9, 88);
            this.label3.Name = "label3";
            this.label3.Size = new System.Drawing.Size(201, 19);
            this.label3.TabIndex = 144;
            this.label3.Text = "Cantidad de Comprbantes";
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label2.ForeColor = System.Drawing.Color.Black;
            this.label2.Location = new System.Drawing.Point(447, 25);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(170, 19);
            this.label2.TabIndex = 143;
            this.label2.Text = "Fecha de Vencimiento";
            // 
            // dtpvencimiento
            // 
            this.dtpvencimiento.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.dtpvencimiento.Format = System.Windows.Forms.DateTimePickerFormat.Short;
            this.dtpvencimiento.Location = new System.Drawing.Point(451, 49);
            this.dtpvencimiento.Name = "dtpvencimiento";
            this.dtpvencimiento.Size = new System.Drawing.Size(200, 29);
            this.dtpvencimiento.TabIndex = 2;
            // 
            // label1
            // 
            this.label1.AutoSize = true;
            this.label1.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label1.ForeColor = System.Drawing.Color.Black;
            this.label1.Location = new System.Drawing.Point(175, 25);
            this.label1.Name = "label1";
            this.label1.Size = new System.Drawing.Size(177, 19);
            this.label1.TabIndex = 141;
            this.label1.Text = "Secuencia 8 caracteres";
            // 
            // cbo_tipo
            // 
            this.cbo_tipo.DisplayMember = "nombre";
            this.cbo_tipo.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.cbo_tipo.FormattingEnabled = true;
            this.cbo_tipo.Items.AddRange(new object[] {
            "B01",
            "B02",
            "B15"});
            this.cbo_tipo.Location = new System.Drawing.Point(10, 50);
            this.cbo_tipo.Name = "cbo_tipo";
            this.cbo_tipo.Size = new System.Drawing.Size(160, 29);
            this.cbo_tipo.TabIndex = 0;
            this.cbo_tipo.ValueMember = "idsegurom";
            // 
            // txt_cantidad
            // 
            this.txt_cantidad.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_cantidad.Location = new System.Drawing.Point(10, 114);
            this.txt_cantidad.MaxLength = 50;
            this.txt_cantidad.Name = "txt_cantidad";
            this.txt_cantidad.Size = new System.Drawing.Size(200, 29);
            this.txt_cantidad.TabIndex = 2;
            this.txt_cantidad.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_cantidad_KeyPress);
            this.txt_cantidad.Leave += new System.EventHandler(this.txt_cantidad_Leave);
            // 
            // label9
            // 
            this.label9.AutoSize = true;
            this.label9.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.label9.ForeColor = System.Drawing.Color.Black;
            this.label9.Location = new System.Drawing.Point(6, 25);
            this.label9.Name = "label9";
            this.label9.Size = new System.Drawing.Size(47, 19);
            this.label9.TabIndex = 134;
            this.label9.Text = "Tipo:";
            // 
            // txt_secuencia
            // 
            this.txt_secuencia.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_secuencia.Location = new System.Drawing.Point(179, 50);
            this.txt_secuencia.MaxLength = 8;
            this.txt_secuencia.Name = "txt_secuencia";
            this.txt_secuencia.Size = new System.Drawing.Size(230, 29);
            this.txt_secuencia.TabIndex = 1;
            this.txt_secuencia.KeyPress += new System.Windows.Forms.KeyPressEventHandler(this.txt_secuencia_KeyPress);
            // 
            // groupBox1
            // 
            this.groupBox1.Controls.Add(this.rdb_desactivar);
            this.groupBox1.Controls.Add(this.rdb_activar);
            this.groupBox1.Location = new System.Drawing.Point(451, 185);
            this.groupBox1.Name = "groupBox1";
            this.groupBox1.Size = new System.Drawing.Size(197, 78);
            this.groupBox1.TabIndex = 150;
            this.groupBox1.TabStop = false;
            // 
            // rdb_desactivar
            // 
            this.rdb_desactivar.AutoSize = true;
            this.rdb_desactivar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_desactivar.Location = new System.Drawing.Point(18, 52);
            this.rdb_desactivar.Name = "rdb_desactivar";
            this.rdb_desactivar.Size = new System.Drawing.Size(108, 25);
            this.rdb_desactivar.TabIndex = 1;
            this.rdb_desactivar.TabStop = true;
            this.rdb_desactivar.Text = "Desactivar";
            this.rdb_desactivar.UseVisualStyleBackColor = true;
            this.rdb_desactivar.CheckedChanged += new System.EventHandler(this.rdb_desactivar_CheckedChanged);
            // 
            // rdb_activar
            // 
            this.rdb_activar.AutoSize = true;
            this.rdb_activar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.rdb_activar.Location = new System.Drawing.Point(18, 20);
            this.rdb_activar.Name = "rdb_activar";
            this.rdb_activar.Size = new System.Drawing.Size(82, 25);
            this.rdb_activar.TabIndex = 0;
            this.rdb_activar.TabStop = true;
            this.rdb_activar.Text = "Activar";
            this.rdb_activar.UseVisualStyleBackColor = true;
            this.rdb_activar.CheckedChanged += new System.EventHandler(this.rdb_activar_CheckedChanged);
            // 
            // btn_close
            // 
            this.btn_close.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_close.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_close.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_close.Image = ((System.Drawing.Image)(resources.GetObject("btn_close.Image")));
            this.btn_close.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_close.Location = new System.Drawing.Point(266, 195);
            this.btn_close.Name = "btn_close";
            this.btn_close.Size = new System.Drawing.Size(165, 44);
            this.btn_close.TabIndex = 149;
            this.btn_close.Text = "Salir";
            this.btn_close.UseVisualStyleBackColor = false;
            this.btn_close.Click += new System.EventHandler(this.btn_close_Click);
            // 
            // btn_guardar
            // 
            this.btn_guardar.BackColor = System.Drawing.Color.FromArgb(((int)(((byte)(224)))), ((int)(((byte)(224)))), ((int)(((byte)(224)))));
            this.btn_guardar.FlatStyle = System.Windows.Forms.FlatStyle.Flat;
            this.btn_guardar.Font = new System.Drawing.Font("Segoe UI", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btn_guardar.Image = ((System.Drawing.Image)(resources.GetObject("btn_guardar.Image")));
            this.btn_guardar.ImageAlign = System.Drawing.ContentAlignment.MiddleLeft;
            this.btn_guardar.Location = new System.Drawing.Point(71, 195);
            this.btn_guardar.Name = "btn_guardar";
            this.btn_guardar.Size = new System.Drawing.Size(165, 44);
            this.btn_guardar.TabIndex = 148;
            this.btn_guardar.Text = "Guardar";
            this.btn_guardar.UseVisualStyleBackColor = false;
            this.btn_guardar.Click += new System.EventHandler(this.btn_guardar_Click);
            // 
            // Form_comprobantes
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(770, 286);
            this.Controls.Add(this.groupBox1);
            this.Controls.Add(this.btn_close);
            this.Controls.Add(this.btn_guardar);
            this.Controls.Add(this.groupBox2);
            this.Name = "Form_comprobantes";
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterScreen;
            this.Text = "Form_comprobantes";
            this.Load += new System.EventHandler(this.Form_comprobantes_Load);
            this.groupBox2.ResumeLayout(false);
            this.groupBox2.PerformLayout();
            this.groupBox1.ResumeLayout(false);
            this.groupBox1.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox groupBox2;
        private System.Windows.Forms.Label label4;
        public System.Windows.Forms.TextBox txt_finalizar_secuencia;
        private System.Windows.Forms.Label label5;
        public System.Windows.Forms.TextBox txt_proximo;
        private System.Windows.Forms.Label label3;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.DateTimePicker dtpvencimiento;
        private System.Windows.Forms.Label label1;
        private System.Windows.Forms.ComboBox cbo_tipo;
        public System.Windows.Forms.TextBox txt_cantidad;
        private System.Windows.Forms.Label label9;
        public System.Windows.Forms.TextBox txt_secuencia;
        private System.Windows.Forms.GroupBox groupBox1;
        private System.Windows.Forms.RadioButton rdb_desactivar;
        private System.Windows.Forms.RadioButton rdb_activar;
        private System.Windows.Forms.Button btn_close;
        private System.Windows.Forms.Button btn_guardar;
    }
}