namespace RegistarVentas
{
    partial class Form_restaurar
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
            this.Gbox_restaurar = new System.Windows.Forms.GroupBox();
            this.Txt_buscar_ruta = new System.Windows.Forms.TextBox();
            this.label2 = new System.Windows.Forms.Label();
            this.Btn_restaurar = new System.Windows.Forms.Button();
            this.Btn_buscar_restaurar = new System.Windows.Forms.Button();
            this.Gbox_restaurar.SuspendLayout();
            this.SuspendLayout();
            // 
            // Gbox_restaurar
            // 
            this.Gbox_restaurar.BackColor = System.Drawing.Color.White;
            this.Gbox_restaurar.Controls.Add(this.Txt_buscar_ruta);
            this.Gbox_restaurar.Controls.Add(this.label2);
            this.Gbox_restaurar.Controls.Add(this.Btn_restaurar);
            this.Gbox_restaurar.Controls.Add(this.Btn_buscar_restaurar);
            this.Gbox_restaurar.Location = new System.Drawing.Point(112, 56);
            this.Gbox_restaurar.Name = "Gbox_restaurar";
            this.Gbox_restaurar.Size = new System.Drawing.Size(394, 117);
            this.Gbox_restaurar.TabIndex = 2;
            this.Gbox_restaurar.TabStop = false;
            this.Gbox_restaurar.Text = "Restaurar BaseDatos";
            // 
            // Txt_buscar_ruta
            // 
            this.Txt_buscar_ruta.Location = new System.Drawing.Point(77, 34);
            this.Txt_buscar_ruta.Name = "Txt_buscar_ruta";
            this.Txt_buscar_ruta.Size = new System.Drawing.Size(210, 20);
            this.Txt_buscar_ruta.TabIndex = 2;
            // 
            // label2
            // 
            this.label2.AutoSize = true;
            this.label2.Location = new System.Drawing.Point(17, 37);
            this.label2.Name = "label2";
            this.label2.Size = new System.Drawing.Size(61, 13);
            this.label2.TabIndex = 1;
            this.label2.Text = "Buscar en.:";
            // 
            // Btn_restaurar
            // 
            this.Btn_restaurar.Location = new System.Drawing.Point(304, 61);
            this.Btn_restaurar.Name = "Btn_restaurar";
            this.Btn_restaurar.Size = new System.Drawing.Size(75, 23);
            this.Btn_restaurar.TabIndex = 0;
            this.Btn_restaurar.Text = "Restaurar";
            this.Btn_restaurar.UseVisualStyleBackColor = true;
            this.Btn_restaurar.Click += new System.EventHandler(this.Btn_restaurar_Click);
            // 
            // Btn_buscar_restaurar
            // 
            this.Btn_buscar_restaurar.Location = new System.Drawing.Point(304, 32);
            this.Btn_buscar_restaurar.Name = "Btn_buscar_restaurar";
            this.Btn_buscar_restaurar.Size = new System.Drawing.Size(75, 23);
            this.Btn_buscar_restaurar.TabIndex = 0;
            this.Btn_buscar_restaurar.Text = "Buscar";
            this.Btn_buscar_restaurar.UseVisualStyleBackColor = true;
            this.Btn_buscar_restaurar.Click += new System.EventHandler(this.Btn_buscar_restaurar_Click);
            // 
            // Form_restaurar
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(690, 265);
            this.Controls.Add(this.Gbox_restaurar);
            this.Name = "Form_restaurar";
            this.Text = "Form_restaurar";
            this.Gbox_restaurar.ResumeLayout(false);
            this.Gbox_restaurar.PerformLayout();
            this.ResumeLayout(false);

        }

        #endregion

        private System.Windows.Forms.GroupBox Gbox_restaurar;
        private System.Windows.Forms.TextBox Txt_buscar_ruta;
        private System.Windows.Forms.Label label2;
        private System.Windows.Forms.Button Btn_restaurar;
        private System.Windows.Forms.Button Btn_buscar_restaurar;
    }
}