namespace RegistarVentas
{
    partial class FormBuscar
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
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle10 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle11 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle16 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle17 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle18 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle12 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle13 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle14 = new System.Windows.Forms.DataGridViewCellStyle();
            System.Windows.Forms.DataGridViewCellStyle dataGridViewCellStyle15 = new System.Windows.Forms.DataGridViewCellStyle();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(FormBuscar));
            this.dgvDescripcion_Producto = new System.Windows.Forms.DataGridView();
            this.ID = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.NAME = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.DETAIL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.QUATITY = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.SUB_TOTAL = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.TOTAL_PRICE = new System.Windows.Forms.DataGridViewTextBoxColumn();
            this.btnBuscarArticulos = new System.Windows.Forms.Button();
            this.txt_Buscar_articulo = new System.Windows.Forms.TextBox();
            this.lbbuscar = new System.Windows.Forms.Label();
            this.lbvolver = new System.Windows.Forms.Label();
            this.pibvolver = new System.Windows.Forms.PictureBox();
            this.btnagregar = new System.Windows.Forms.Button();
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcion_Producto)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibvolver)).BeginInit();
            this.SuspendLayout();
            // 
            // dgvDescripcion_Producto
            // 
            this.dgvDescripcion_Producto.AllowUserToAddRows = false;
            dataGridViewCellStyle10.ForeColor = System.Drawing.Color.Black;
            this.dgvDescripcion_Producto.AlternatingRowsDefaultCellStyle = dataGridViewCellStyle10;
            this.dgvDescripcion_Producto.BackgroundColor = System.Drawing.Color.White;
            this.dgvDescripcion_Producto.CellBorderStyle = System.Windows.Forms.DataGridViewCellBorderStyle.None;
            dataGridViewCellStyle11.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle11.BackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle11.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle11.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle11.Format = "N2";
            dataGridViewCellStyle11.NullValue = null;
            dataGridViewCellStyle11.SelectionBackColor = System.Drawing.SystemColors.HotTrack;
            dataGridViewCellStyle11.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle11.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDescripcion_Producto.ColumnHeadersDefaultCellStyle = dataGridViewCellStyle11;
            this.dgvDescripcion_Producto.ColumnHeadersHeightSizeMode = System.Windows.Forms.DataGridViewColumnHeadersHeightSizeMode.AutoSize;
            this.dgvDescripcion_Producto.Columns.AddRange(new System.Windows.Forms.DataGridViewColumn[] {
            this.ID,
            this.NAME,
            this.DETAIL,
            this.QUATITY,
            this.SUB_TOTAL,
            this.TOTAL_PRICE});
            dataGridViewCellStyle16.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle16.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle16.Font = new System.Drawing.Font("Verdana", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle16.ForeColor = System.Drawing.Color.White;
            dataGridViewCellStyle16.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle16.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle16.WrapMode = System.Windows.Forms.DataGridViewTriState.False;
            this.dgvDescripcion_Producto.DefaultCellStyle = dataGridViewCellStyle16;
            this.dgvDescripcion_Producto.EnableHeadersVisualStyles = false;
            this.dgvDescripcion_Producto.Location = new System.Drawing.Point(114, 166);
            this.dgvDescripcion_Producto.Name = "dgvDescripcion_Producto";
            dataGridViewCellStyle17.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle17.BackColor = System.Drawing.SystemColors.Window;
            dataGridViewCellStyle17.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle17.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.Format = "N2";
            dataGridViewCellStyle17.NullValue = null;
            dataGridViewCellStyle17.SelectionBackColor = System.Drawing.SystemColors.Highlight;
            dataGridViewCellStyle17.SelectionForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle17.WrapMode = System.Windows.Forms.DataGridViewTriState.True;
            this.dgvDescripcion_Producto.RowHeadersDefaultCellStyle = dataGridViewCellStyle17;
            this.dgvDescripcion_Producto.RowHeadersVisible = false;
            dataGridViewCellStyle18.ForeColor = System.Drawing.Color.Black;
            this.dgvDescripcion_Producto.RowsDefaultCellStyle = dataGridViewCellStyle18;
            this.dgvDescripcion_Producto.SelectionMode = System.Windows.Forms.DataGridViewSelectionMode.FullRowSelect;
            this.dgvDescripcion_Producto.Size = new System.Drawing.Size(579, 347);
            this.dgvDescripcion_Producto.TabIndex = 38;
            // 
            // ID
            // 
            dataGridViewCellStyle12.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle12.BackColor = System.Drawing.Color.White;
            dataGridViewCellStyle12.Font = new System.Drawing.Font("Microsoft Sans Serif", 9.75F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle12.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle12.SelectionBackColor = System.Drawing.Color.GreenYellow;
            dataGridViewCellStyle12.SelectionForeColor = System.Drawing.Color.FromArgb(((int)(((byte)(0)))), ((int)(((byte)(0)))), ((int)(((byte)(192)))));
            this.ID.DefaultCellStyle = dataGridViewCellStyle12;
            this.ID.HeaderText = "CODIGO";
            this.ID.Name = "ID";
            this.ID.ReadOnly = true;
            this.ID.Width = 200;
            // 
            // NAME
            // 
            this.NAME.HeaderText = "NOMBRE";
            this.NAME.Name = "NAME";
            this.NAME.ReadOnly = true;
            this.NAME.Width = 150;
            // 
            // DETAIL
            // 
            this.DETAIL.HeaderText = "DETALLE";
            this.DETAIL.Name = "DETAIL";
            this.DETAIL.ReadOnly = true;
            this.DETAIL.Width = 250;
            // 
            // QUATITY
            // 
            dataGridViewCellStyle13.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle13.Font = new System.Drawing.Font("Cambria", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle13.ForeColor = System.Drawing.Color.Black;
            this.QUATITY.DefaultCellStyle = dataGridViewCellStyle13;
            this.QUATITY.HeaderText = "CANTIDAD";
            this.QUATITY.Name = "QUATITY";
            // 
            // SUB_TOTAL
            // 
            dataGridViewCellStyle14.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle14.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle14.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle14.Format = "N2";
            dataGridViewCellStyle14.NullValue = null;
            this.SUB_TOTAL.DefaultCellStyle = dataGridViewCellStyle14;
            this.SUB_TOTAL.HeaderText = "SUB-TOTAL";
            this.SUB_TOTAL.Name = "SUB_TOTAL";
            // 
            // TOTAL_PRICE
            // 
            dataGridViewCellStyle15.Alignment = System.Windows.Forms.DataGridViewContentAlignment.TopCenter;
            dataGridViewCellStyle15.BackColor = System.Drawing.SystemColors.Info;
            dataGridViewCellStyle15.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            dataGridViewCellStyle15.ForeColor = System.Drawing.Color.Black;
            dataGridViewCellStyle15.Format = "N2";
            dataGridViewCellStyle15.NullValue = null;
            this.TOTAL_PRICE.DefaultCellStyle = dataGridViewCellStyle15;
            this.TOTAL_PRICE.HeaderText = "TOTAL";
            this.TOTAL_PRICE.Name = "TOTAL_PRICE";
            this.TOTAL_PRICE.ReadOnly = true;
            // 
            // btnBuscarArticulos
            // 
            this.btnBuscarArticulos.BackColor = System.Drawing.Color.White;
            this.btnBuscarArticulos.FlatStyle = System.Windows.Forms.FlatStyle.Popup;
            this.btnBuscarArticulos.Font = new System.Drawing.Font("Verdana", 11.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnBuscarArticulos.ForeColor = System.Drawing.Color.Black;
            this.btnBuscarArticulos.Location = new System.Drawing.Point(484, 75);
            this.btnBuscarArticulos.Name = "btnBuscarArticulos";
            this.btnBuscarArticulos.Size = new System.Drawing.Size(98, 37);
            this.btnBuscarArticulos.TabIndex = 41;
            this.btnBuscarArticulos.Text = "Buscar ";
            this.btnBuscarArticulos.UseVisualStyleBackColor = false;
            this.btnBuscarArticulos.Visible = false;
            // 
            // txt_Buscar_articulo
            // 
            this.txt_Buscar_articulo.BackColor = System.Drawing.SystemColors.Info;
            this.txt_Buscar_articulo.Font = new System.Drawing.Font("Arial", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.txt_Buscar_articulo.Location = new System.Drawing.Point(159, 73);
            this.txt_Buscar_articulo.Multiline = true;
            this.txt_Buscar_articulo.Name = "txt_Buscar_articulo";
            this.txt_Buscar_articulo.Size = new System.Drawing.Size(319, 39);
            this.txt_Buscar_articulo.TabIndex = 40;
            this.txt_Buscar_articulo.Visible = false;
            // 
            // lbbuscar
            // 
            this.lbbuscar.AutoSize = true;
            this.lbbuscar.BackColor = System.Drawing.Color.White;
            this.lbbuscar.Font = new System.Drawing.Font("Cambria", 14.25F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbbuscar.ForeColor = System.Drawing.Color.Black;
            this.lbbuscar.Location = new System.Drawing.Point(243, 48);
            this.lbbuscar.Name = "lbbuscar";
            this.lbbuscar.Size = new System.Drawing.Size(155, 22);
            this.lbbuscar.TabIndex = 39;
            this.lbbuscar.Text = "Buscar Producto";
            this.lbbuscar.Visible = false;
            // 
            // lbvolver
            // 
            this.lbvolver.AutoSize = true;
            this.lbvolver.BackColor = System.Drawing.Color.Transparent;
            this.lbvolver.Font = new System.Drawing.Font("Verdana", 12F, System.Drawing.FontStyle.Bold, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.lbvolver.ForeColor = System.Drawing.Color.White;
            this.lbvolver.Location = new System.Drawing.Point(654, 100);
            this.lbvolver.Name = "lbvolver";
            this.lbvolver.Size = new System.Drawing.Size(70, 18);
            this.lbvolver.TabIndex = 43;
            this.lbvolver.Text = "Volver:";
            this.lbvolver.Visible = false;
            // 
            // pibvolver
            // 
            this.pibvolver.BackColor = System.Drawing.Color.Transparent;
            this.pibvolver.Image = ((System.Drawing.Image)(resources.GetObject("pibvolver.Image")));
            this.pibvolver.Location = new System.Drawing.Point(653, 63);
            this.pibvolver.Name = "pibvolver";
            this.pibvolver.Size = new System.Drawing.Size(84, 34);
            this.pibvolver.SizeMode = System.Windows.Forms.PictureBoxSizeMode.StretchImage;
            this.pibvolver.TabIndex = 42;
            this.pibvolver.TabStop = false;
            this.pibvolver.Visible = false;
            // 
            // btnagregar
            // 
            this.btnagregar.BackColor = System.Drawing.Color.GreenYellow;
            this.btnagregar.Font = new System.Drawing.Font("Calibri", 9F, System.Drawing.FontStyle.Regular, System.Drawing.GraphicsUnit.Point, ((byte)(0)));
            this.btnagregar.ForeColor = System.Drawing.Color.Black;
            this.btnagregar.Location = new System.Drawing.Point(715, 186);
            this.btnagregar.Name = "btnagregar";
            this.btnagregar.Size = new System.Drawing.Size(98, 37);
            this.btnagregar.TabIndex = 44;
            this.btnagregar.Text = "Agregar";
            this.btnagregar.UseVisualStyleBackColor = false;
            this.btnagregar.Visible = false;
            // 
            // FormBuscar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(825, 555);
            this.Controls.Add(this.btnagregar);
            this.Controls.Add(this.lbvolver);
            this.Controls.Add(this.pibvolver);
            this.Controls.Add(this.btnBuscarArticulos);
            this.Controls.Add(this.txt_Buscar_articulo);
            this.Controls.Add(this.lbbuscar);
            this.Controls.Add(this.dgvDescripcion_Producto);
            this.Name = "FormBuscar";
            this.Text = "FormBuscar";
            ((System.ComponentModel.ISupportInitialize)(this.dgvDescripcion_Producto)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.pibvolver)).EndInit();
            this.ResumeLayout(false);
            this.PerformLayout();

        }

        #endregion

        private System.Windows.Forms.DataGridView dgvDescripcion_Producto;
        private System.Windows.Forms.DataGridViewTextBoxColumn ID;
        private System.Windows.Forms.DataGridViewTextBoxColumn NAME;
        private System.Windows.Forms.DataGridViewTextBoxColumn DETAIL;
        private System.Windows.Forms.DataGridViewTextBoxColumn QUATITY;
        private System.Windows.Forms.DataGridViewTextBoxColumn SUB_TOTAL;
        private System.Windows.Forms.DataGridViewTextBoxColumn TOTAL_PRICE;
        private System.Windows.Forms.Button btnBuscarArticulos;
        private System.Windows.Forms.TextBox txt_Buscar_articulo;
        private System.Windows.Forms.Label lbbuscar;
        private System.Windows.Forms.Label lbvolver;
        private System.Windows.Forms.PictureBox pibvolver;
        private System.Windows.Forms.Button btnagregar;
    }
}